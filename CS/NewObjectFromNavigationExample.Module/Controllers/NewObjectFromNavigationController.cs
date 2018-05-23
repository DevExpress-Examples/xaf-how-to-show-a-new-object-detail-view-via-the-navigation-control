using DevExpress.ExpressApp;
using DevExpress.ExpressApp.SystemModule;
using NewObjectFromNavigationExample.Module.BusinessObjects;

namespace NewObjectFromNavigationExample.Module.Controllers {
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
                IObjectSpace objectSpace = Application.CreateObjectSpace();
                Issue newIssue = objectSpace.CreateObject<Issue>();
                DetailView detailView = Application.CreateDetailView(objectSpace, newIssue);
                detailView.ViewEditMode = DevExpress.ExpressApp.Editors.ViewEditMode.Edit;
                e.ActionArguments.ShowViewParameters.CreatedView = detailView;
                e.Handled = true;
            }
        }
    }        
}
