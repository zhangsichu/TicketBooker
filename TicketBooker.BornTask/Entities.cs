using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TicketBooker.BornTask
{
    public class Doctor
    {
        public string Name { get; set; }
        public string Code { get; set; }
    }

    public class Person
    {
        public string Name { get; set; }
        public string ID { get; set; }
        public string Phone { get; set; }
        public string Memo { get; set; }
    }

    public class RegisterDateTime
    {
        public class DateTimeItem
        {
            public string Name { get; set; }
            public string Code { get; set; }
        }

        public string RegisterDateTypeName { get; set; }
        public string RegisterDateTypeCode { get; set; }
        public List<DateTimeItem> DateTimeItemList { get; set; }
    }

    public class BormTaskSetting
    {
        public List<Doctor> DoctorList { get; set; }
        public List<RegisterDateTime> RegisterDateTimeList { get; set; }
        public List<Person> PersonList { get; set; }
    }

    public class RequestRegisterData
    {
        public string DoctorCode { get; set; }
        public string RegisterDateTypeCode { get; set; }
        public string RegisterDateTimeCode { get; set; }
        public DateTime RegisterDate { get; set; }
        public bool IsImmediatelyTask { get; set; }
        public DateTime TaskTime { get; set; }
    }
}
