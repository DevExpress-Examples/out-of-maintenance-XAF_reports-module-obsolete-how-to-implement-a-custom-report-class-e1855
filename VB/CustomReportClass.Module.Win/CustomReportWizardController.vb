Imports System.ComponentModel
Imports System.Text

Imports DevExpress.ExpressApp
Imports DevExpress.ExpressApp.Actions
Imports DevExpress.Persistent.Base
Imports DevExpress.Xpo
Imports DevExpress.ExpressApp.Reports
Imports DevExpress.ExpressApp.Reports.Win
Imports DevExpress.Persistent.Validation

Namespace CustomReportClass.Module.Win
    Partial Public Class ReportWizardModifyController
        Inherits ViewController

        Private reportServiceController As WinReportServiceController
        Public Sub New()
        End Sub
        Protected Overrides Sub OnActivated()
            MyBase.OnActivated()
            reportServiceController = Frame.GetController(Of WinReportServiceController)()
            AddHandler reportServiceController.NewXafReportWizardShowing, AddressOf reportServiceController_NewXafReportWizardShowing
        End Sub
        Protected Overrides Sub OnDeactivated()
            RemoveHandler reportServiceController.NewXafReportWizardShowing, AddressOf reportServiceController_NewXafReportWizardShowing
            reportServiceController = Nothing
            MyBase.OnDeactivated()
        End Sub
        Private Sub reportServiceController_NewXafReportWizardShowing(ByVal sender As Object, ByVal e As NewXafReportWizardShowingEventArgs)
            If Not e.ReportDataType.Equals(GetType(CustomReportData)) Then
                Return
            End If
            Dim newReportParamsObject As New CustomReportWizardParameters(e.WizardParameters.Report)
            newReportParamsObject.ReportName = "Custom report name"
            newReportParamsObject.AdditionalInfo = "AdditionalInfo default value"
            e.WizardParameters = newReportParamsObject
        End Sub
    End Class
    <NonPersistent> _
    Public Class CustomReportWizardParameters
        Inherits NewXafReportWizardParameters

        Public Sub New(ByVal report As XafReport)
            MyBase.New(report)
        End Sub
        Public Property AdditionalInfo() As String
            Get
                Return CType(Report, CustomXafReport).AdditionalInfo
            End Get
            Set(ByVal value As String)
                CType(Report, CustomXafReport).AdditionalInfo = value
            End Set
        End Property
    End Class
End Namespace

