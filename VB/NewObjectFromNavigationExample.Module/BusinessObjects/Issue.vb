Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports DevExpress.Persistent.BaseImpl
Imports DevExpress.Xpo
Imports DevExpress.Persistent.Base

Namespace NewObjectFromNavigationExample.Module.BusinessObjects
    <DefaultClassOptions, ImageName("BO_List")>
    Public Class Issue
        Inherits BaseObject

        Public Sub New(ByVal session As Session)
            MyBase.New(session)
        End Sub
'INSTANT VB NOTE: The variable subject was renamed since Visual Basic does not allow variables and other class members to have the same name:
        Private _subject As String
        Public Property Subject() As String
            Get
                Return _subject
            End Get
            Set(ByVal value As String)
                SetPropertyValue("Subject", _subject, value)
            End Set
        End Property
'INSTANT VB NOTE: The variable description was renamed since Visual Basic does not allow variables and other class members to have the same name:
        Private _description As String
        <Size(SizeAttribute.Unlimited)>
        Public Property Description() As String
            Get
                Return _description
            End Get
            Set(ByVal value As String)
                SetPropertyValue("Description", _description, value)
            End Set
        End Property
    End Class
End Namespace
