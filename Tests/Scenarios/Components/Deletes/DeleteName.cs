﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tests.Core;

namespace Tests.Scenarios.Components.Deletes
{
    class ComponentDeleteName : TestDecorator
    {

        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }

        public override void Execute()
        {
            HTTP.Name("Component Delete Testi")
                .Get("api/components/delete/" + Config.data["name_component_id"])
                .ShouldResponseCode(204);
        }
    }
}
