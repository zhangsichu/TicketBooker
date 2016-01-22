using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;
using TicketBooker.Core;

namespace TicketBooker.BornTask
{
    public class BornTask : BaseTask
    {

        public override bool IsImmediatelyTask
        {
            get { return this.requestRegisterData.IsImmediatelyTask; }
        }

        public override DateTime GetTaskStartTime()
        {
            return this.requestRegisterData.TaskTime;
        }

        private readonly string taskName = "BornTask-" + DateTime.Now.ToString("hh:mm:ss");
        public override string TaskName
        {
            get
            {
                return taskName;
            }
        }

        private RequestRegisterData requestRegisterData;
        private Person person;
        public BornTask(RequestRegisterData data, Person person)
        {
            this.requestRegisterData = data;
            this.person = person;
        }

        public Person Person
        {
            get { return person; }
        }

        public  RequestRegisterData RequestRegisterData
        {
            get { return requestRegisterData; }
        }

        public override string GetRequestUrl()
        {
            return BuildRequestUrl(this.requestRegisterData);
        }

        public override void PrepareTaskRequest(System.Net.HttpWebRequest request)
        {
            request.Method = "POST";
            request.Proxy.Credentials = System.Net.CredentialCache.DefaultCredentials;
            request.ContentType = "application/x-www-form-urlencoded";

            request.Referer = RequestBaseUrl;
            byte[] bytes = Encoding.ASCII.GetBytes(BuildRequestData(this.requestRegisterData, this.person));
            request.Timeout = 1200000;
            request.ContentLength = bytes.Length;

            var stream = request.GetRequestStream();
            stream.Write(bytes, 0, bytes.Length);
        }

        public override TaskResult GetResult(System.Net.WebResponse response)
        {
            var result = new TaskResult();
            using(StreamReader reader = new StreamReader(response.GetResponseStream(), DefaultEncoding))
            {
                result.Message = reader.ReadToEnd();
                Regex regex = new Regex("<span class=\"cuti yanse_hongse\">(\\d+)</span>"); //get the code.
                result.IsSucceed = regex.IsMatch(result.Message);
                if (result.IsSucceed)
                    result.Code = regex.Match(result.Message).Groups[1].Value;
            }
            return result;
        }

        #region Static
        private const string RequestBaseUrl = "http://wsgh.sxmch.com/";
        private static Encoding DefaultEncoding = Encoding.GetEncoding("gb2312");

        public static string BuildTestUrl(RequestRegisterData data)
        {
            return string.Format("{0}{1}{2}-{3}-{4}", RequestBaseUrl, "ZhuanJia_Add.asp?",
                                 data.DoctorCode,
                                 Convert.ToBase64String((new UTF8Encoding()).GetBytes(data.RegisterDate.ToString("yyyy-M-d"))),
                                 data.RegisterDateTypeCode);
        }

        public static string BuildRequestUrl(RequestRegisterData data)
        {
            return string.Format("{0}{1}{2}-{3}-{4}", RequestBaseUrl, "ZhuanJia_Add.asp?Type=Save&",
                                 data.DoctorCode,
                                 Convert.ToBase64String((new UTF8Encoding()).GetBytes(data.RegisterDate.ToString("yyyy-M-d"))),
                                 data.RegisterDateTypeCode);
        }

        public static string BuildRequestData(RequestRegisterData data, Person person)
        {
            return "txtHZName=" + HttpUtility.UrlEncode(person.Name, DefaultEncoding).ToUpper() +
                   "&txtIDNumber=" + person.ID +
                   "&txtTel=" + person.Phone +
                   "&txtRQ=" + data.RegisterDate.ToString("yyyy-M-d") +
                   "&ddlBC=" + data.RegisterDateTimeCode +
                   "&rbFZ=1";
        }
        #endregion
    }
}
