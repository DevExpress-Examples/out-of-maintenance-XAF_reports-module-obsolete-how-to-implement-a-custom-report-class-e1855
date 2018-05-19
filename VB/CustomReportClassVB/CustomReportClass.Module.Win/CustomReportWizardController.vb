Imports Microsoft.VisualBasic
Imports System
Imports System.ComponentModel
Imports System.Collections.Generic
Imports System.Diagnostics
Imports System.Text

Imports DevExpress.ExpressApp
Imports DevExpress.ExpressApp.Actions
Imports DevExpress.Persistent.Base
Imports DevExpress.Xpo
Imports DevExpress.ExpressApp.Reports
Imports DevExpress.ExpressApp.Reports.Win

Namespace CustomReportClass.Module.Win
    Partial Public Class ReportWizardModifyController
        Inherits WindowController        
        Public Sub New()
        End Sub

        Protected Overrides Sub OnActivated()
            MyBase.OnActivated()

            Dim reportServiceController As WinReportServiceController = _
            Frame.GetController(Of WinReportServiceController)()
            AddHandler reportServiceController.NewXafReportWizardShowing, AddressOf MyHandler
        End Sub

        Private Sub MyHandler(ByVal sender As Object, ByVal e As NewXafReportWizardShowingEventArgs)
            If (Not e.ReportDataType.Equals(GetType(CustomReportData))) Then
                Return
            End If
            Dim newReportParamsObject As New CustomReportWizardParameters(e.WizardParameters.Report)
            newReportParamsObject.ReportName = "Custom report name"
            newReportParamsObject.AdditionalInfo = "AdditionalInfo default value"
            e.WizardParameters = newReportParamsObject
        End Sub
    End Class

	<NonPersistent> _
	Friend Class CustomReportWizardParameters
		Inherits NewXafReportWizardParameters
		Public Sub New(ByVal report As XafReport)
			MyBase.New(report)
		End Sub

		Public Property AdditionalInfo() As String
			Get
				Return (CType(Report, CustomXafReport)).AdditionalInfo
			End Get
			Set(ByVal value As String)
				CType(Report, CustomXafReport).AdditionalInfo = value
			End Set
		End Property
	End Class
End Namespace

