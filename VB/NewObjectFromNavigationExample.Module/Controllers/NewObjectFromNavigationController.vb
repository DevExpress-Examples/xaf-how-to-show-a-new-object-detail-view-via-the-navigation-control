Imports DevExpress.ExpressApp
Imports DevExpress.ExpressApp.SystemModule
Imports NewObjectFromNavigationExample.Module.BusinessObjects

Namespace NewObjectFromNavigationExample.Module.Controllers
    Public Class NewObjectFromNavigationController
        Inherits WindowController

        Public Sub New()
            TargetWindowType = WindowType.Main
        End Sub
        Protected Overrides Sub OnActivated()
            MyBase.OnActivated()
            Dim showNavigationItemController As ShowNavigationItemController = Frame.GetController(Of ShowNavigationItemController)()
            AddHandler showNavigationItemController.CustomShowNavigationItem, AddressOf showNavigationItemController_CustomShowNavigationItem
        End Sub
        Private Sub showNavigationItemController_CustomShowNavigationItem(ByVal sender As Object, ByVal e As CustomShowNavigationItemEventArgs)
            If e.ActionArguments.SelectedChoiceActionItem.Id = "NewIssue" Then
                Dim objectSpace As IObjectSpace = Application.CreateObjectSpace()
                Dim newIssue As Issue = objectSpace.CreateObject(Of Issue)()
                Dim detailView As DetailView = Application.CreateDetailView(objectSpace, newIssue)
                detailView.ViewEditMode = DevExpress.ExpressApp.Editors.ViewEditMode.Edit
                e.ActionArguments.ShowViewParameters.CreatedView = detailView
                e.Handled = True
            End If
        End Sub
    End Class
End Namespace
