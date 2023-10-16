using DevExpress.ExpressApp.SystemModule;
using DevExpress.ExpressApp;
using NavigationItem.Module.BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace NavigationItem.Module.Controllers {
    public class NewObjectFromNavigationController : WindowController {
        public NewObjectFromNavigationController() {
            TargetWindowType = WindowType.Main;
        }
        protected override void OnActivated() {
            base.OnActivated();
            ShowNavigationItemController showNavigationItemController = Frame.GetController<ShowNavigationItemController>();
            showNavigationItemController.CustomShowNavigationItem += showNavigationItemController_CustomShowNavigationItem;
        }
        void showNavigationItemController_CustomShowNavigationItem(object sender, CustomShowNavigationItemEventArgs e) {
            if (e.ActionArguments.SelectedChoiceActionItem.Id == "NewIssue") {
                IObjectSpace objectSpace = Application.CreateObjectSpace(typeof(Issue));
                Issue newIssue = objectSpace.CreateObject<Issue>();
                DetailView detailView = Application.CreateDetailView(objectSpace, newIssue);
                e.ActionArguments.ShowViewParameters.CreatedView = detailView;
                e.Handled = true;
            }
        }
    }
}
