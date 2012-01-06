using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using FluentNHibernate.Mapping;


namespace Clinic.ModelMapper.Implementations.HR
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
            .WithLengthOf(100)
            .Nullable();
             Map(x => x.Role)
            .WithLengthOf(100)
            .Nullable();
             Map(x => x.Action)
            .WithLengthOf(100)
            .Nullable();
             Map(x => x.ResultState)
            .WithLengthOf(100)
            .Nullable();

        }
    }

}
