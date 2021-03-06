﻿using Repositories.HTTP.Requests.Table.Component;
using System.Collections.Generic;
using Tests.Core;

namespace Tests.Scenarios.Table.Component.Creates.Authors
{
    class TableComponentAuthorsSurnameCreate : TestDecorator
    {

        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }

        public override void Execute()
        {
            Collection collection = new Collection()
            {
                ids = new List<int>()
                {
                    Config.data["surname_component_id"]
                },
                tableId = Config.data["authors_table_id"]
            };
            
            Config.data["authors_table_surname_component_id"] = HTTP.Name("Table Add Component Testi")
                .Post("api/table/component", collection)
                .ShouldBeOk()
                .FetchAsInt("id");
        }
    }
}
