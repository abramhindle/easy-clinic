using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using FluentNHibernate.Mapping;


namespace Clinic.Repository.NHibernate.Mapping.HR
{
    public class WorkflowStateMachineMapper : ClassMap<Clinic.Model.HR.WorkflowStateMachine>
    {
        //private const string schema = "Actions";
        public WorkflowStateMachineMapper()
        {
            //  SchemaIs(schema);
            Id(x => x.WorkflowStateMachineId);
              Map(x => x.WorkFlow)
            .Nullable();
             Map(x => x.State)
            .Length(100)
            .Nullable();
             Map(x => x.Role)
            .Length(100)
            .Nullable();
             Map(x => x.Action)
            .Length(100)
            .Nullable();
             Map(x => x.ResultState)
            .Length(100)
            .Nullable();

        }
    }

}
