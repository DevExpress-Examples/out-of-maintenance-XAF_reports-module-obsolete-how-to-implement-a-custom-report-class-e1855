Imports System.Text
Imports DevExpress.ExpressApp.Reports
Imports DevExpress.Xpo
Imports DevExpress.XtraReports
Imports DevExpress.XtraReports.Serialization
Imports DevExpress.Persistent.Base

Namespace CustomReportClass.Module
	<RootClass> _
	Public Class CustomXafReport
		Inherits XafReport

'INSTANT VB NOTE: The variable additionalInfo was renamed since Visual Basic does not allow variables and other class members to have the same name:
		Protected additionalInfo_Renamed As String
		Public Property AdditionalInfo() As String
			Get
				Return additionalInfo_Renamed
			End Get
			Set(ByVal value As String)
				additionalInfo_Renamed = value
			End Set
		End Property
		Protected Overrides Sub SerializeProperties(ByVal serializer As XRSerializer)
			MyBase.SerializeProperties(serializer)
			serializer.SerializeString("AdditionalInfo", AdditionalInfo)
		End Sub
		Protected Overrides Sub DeserializeProperties(ByVal serializer As XRSerializer)
			MyBase.DeserializeProperties(serializer)
			AdditionalInfo = serializer.DeserializeString("AdditionalInfo", String.Empty)
		End Sub
	End Class
	<System.ComponentModel.DisplayName("Custom Report"), NavigationItem("Reports")> _
	Public Class CustomReportData
		Inherits ReportData

		Public Sub New(ByVal session As Session)
			MyBase.New(session)
		End Sub
		Protected Overrides Function CreateReport() As XafReport
			Return New CustomXafReport()
		End Function
	End Class
End Namespace
