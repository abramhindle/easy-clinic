using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clinic.Model.HR
{
    public class WorkflowStateMachine
    {
        public int WorkflowStateMachineId { set; get; }
        public int WorkFlow { set; get; }
        public string State { set; get; }
        public string Role { set; get; }
        public string Action { set; get; }
        public string ResultState { set; get; }
             
    }
}
