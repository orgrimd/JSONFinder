﻿using Repositories.HTTP.Requests.Wizards.Fields;
using Tests.Core;

namespace Tests.Scenarios.Wizards.Previews
{
    class WizardsPreviewsPreview : TestDecorator
    {

        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }

        public override void Execute()
        {
            PreviewWizard previewWizard = new PreviewWizard()
            {
                countryId = 1,
                langId = 1,
                regionId = 1,
                wizardId = 1
            };

            HTTP.Name("Wizard Previews Preview Testi")
                .Post("api/wizard/preview", previewWizard)
                .ShouldBeOk();
        }
    }
}
