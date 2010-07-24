using System;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Win.SystemModule;
using eXpand.ExpressApp.FilterDataStore.Core;
using eXpand.ExpressApp.FilterDataStore.Win.Providers;
using System.Linq;

namespace eXpand.ExpressApp.FilterDataStore.Win
{
    public sealed partial class FilterDataStoreWindowsFormsModule : ModuleBase
    {
        public FilterDataStoreWindowsFormsModule()
        {
            InitializeComponent();
        }
        public override void Setup(XafApplication application)
        {
            base.Setup(application);
            application.SetupComplete+=ApplicationOnSetupComplete;
        }

        void ApplicationOnSetupComplete(object sender, EventArgs eventArgs) {
            SkinFilterProvider skinFilterProvider = FilterProviderManager.Providers.OfType<SkinFilterProvider>().FirstOrDefault();
            if (skinFilterProvider != null)
                skinFilterProvider.FilterValue = ((IModelApplicationOptionsSkin) Application.Model.Options).Skin;
        }
    }
}