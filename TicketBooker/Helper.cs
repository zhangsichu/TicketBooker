using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TicketBooker.Core;

namespace TicketBooker
{
    public static class Helper
    {
        private static Dictionary<string, Form> taskSettingList = new Dictionary<string, Form>();

        private static View viewTaskForm;
        private static Load loadTaskForm;
        private static bool taskStarted;

        internal static Dictionary<string, Form> TaskSettingList
        {
            get { return taskSettingList; }
        }

        internal static View ViewTaskForm
        {
            get
            {
                if(viewTaskForm == null)
                    viewTaskForm = new View();
                return viewTaskForm;
            }
        }

        internal static Load LoadTaskForm
        {
            get
            {
                if(loadTaskForm == null)
                    loadTaskForm = new Load();
                return loadTaskForm;
            }
        }

        internal static bool TaskStarted
        {
            get { return taskStarted; }
            set { taskStarted = value; }
        }
    }
}
