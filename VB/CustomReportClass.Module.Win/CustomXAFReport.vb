Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.ExpressApp.Reports
Imports DevExpress.Persistent.Base
Imports DevExpress.Persistent.BaseImpl
Imports DevExpress.Xpo
Imports DevExpress.XtraReports.Serialization

Namespace CustomReportClass.Module
	Public Class CustomXafReport
		Inherits XafReport
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
		Private privateCustomProperty As String
		Public Property CustomProperty() As String
			Get
				Return privateCustomProperty
			End Get
			Set(ByVal value As String)
				privateCustomProperty = value
			End Set
		End Property
	End Class
End Namespace
