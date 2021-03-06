﻿using Tests.Core;

namespace Tests.Scenarios.Menus
{
    class MenusGetParentMenus : TestDecorator
    {

        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }

        public override void Execute()
        {
            HTTP.Name("Menus GetParentMenus Testi")
                .Get("api/menus/getparentmenus")
                .ShouldBeOk();
        }
    }
}
