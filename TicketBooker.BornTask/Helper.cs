using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Xml;

namespace TicketBooker.BornTask
{
    public static class Helper
    {
        public static string SettingFileName = "TicketBooker.BornTask.xml";
        public static string PersonFileName = "Person.txt";

        public static BormTaskSetting LoadBormTaskSetting()
        {
            //1. load the xml file.
            XmlDocument document = new XmlDocument();
            document.Load(Path.Combine(Application.StartupPath, SettingFileName));

            //2. build the result.
            var result = new BormTaskSetting();

            //3. the doctor list.
            result.DoctorList = new List<Doctor>();
            XmlNodeList doctors = document.SelectNodes("BormTaskSetting/Doctors/Doctor");
            foreach (XmlNode doctor in doctors)
            {
                result.DoctorList.Add(
                    new Doctor
                        {
                            Name = doctor.Attributes["Name"].Value,
                            Code = doctor.Attributes["Code"].Value
                        }
                    );
            }

            //4. the register date time
            result.RegisterDateTimeList = new List<RegisterDateTime>();
            XmlNodeList registerDateTimeNodeList = document.SelectNodes("BormTaskSetting/RegisterDateTime/RegisterDateType");
            foreach (XmlNode registerDateTimeNode in registerDateTimeNodeList)
            {
                var registerDateTime = new RegisterDateTime
                                           {
                                               DateTimeItemList = new List<RegisterDateTime.DateTimeItem>(),
                                               RegisterDateTypeCode = registerDateTimeNode.Attributes["Code"].Value,
                                               RegisterDateTypeName = registerDateTimeNode.Attributes["Name"].Value
                                           };
                var dateTimeItemNodeList = registerDateTimeNode.SelectNodes("DateTimeItem");
                foreach (XmlNode dateTimeItemNode in dateTimeItemNodeList)
                {
                    registerDateTime.DateTimeItemList.Add(new RegisterDateTime.DateTimeItem
                                                              {
                                                                  Name = dateTimeItemNode.Attributes["Name"].Value,
                                                                  Code = dateTimeItemNode.Attributes["Code"].Value
                                                              });
                }
                result.RegisterDateTimeList.Add(registerDateTime);
            }

            //5. the person.
            result.PersonList = new List<Person>();
            using (StreamReader reader = new StreamReader(Path.Combine(Application.StartupPath, PersonFileName)))
            {
                var line = reader.ReadLine();
                var valueList = line.Split(',');
                result.PersonList.Add(new Person
                                          {
                                              Name = valueList[0],
                                              ID = valueList[1],
                                              Phone = valueList[2],
                                              Memo = line
                                          });
            }
            
            return result;
        }
    }
}