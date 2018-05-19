Imports Microsoft.VisualBasic
Imports System
Imports System.ComponentModel

Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering

Imports DevExpress.ExpressApp
Imports DevExpress.Persistent.Base
Imports DevExpress.Persistent.BaseImpl
Imports DevExpress.Persistent.Validation

Namespace CustomReportClass.Module
	<DefaultClassOptions> _
	Public Class Contact
		Inherits Person
		Private webPageAddress_Renamed As String
		Private nickName_Renamed As String
		Private spouseName_Renamed As String
		Private titleOfCourtesy_Renamed As TitleOfCourtesy
		Private notes_Renamed As String
		Private anniversary_Renamed As DateTime
		Public Sub New(ByVal session As Session)
			MyBase.New(session)
		End Sub
		Public Property WebPageAddress() As String
			Get
				Return webPageAddress_Renamed
			End Get
			Set(ByVal value As String)
				SetPropertyValue("WebPageAddress", webPageAddress_Renamed, value)
			End Set
		End Property
		Public Property NickName() As String
			Get
				Return nickName_Renamed
			End Get
			Set(ByVal value As String)
				SetPropertyValue("NickName", nickName_Renamed, value)
			End Set
		End Property
		Public Property SpouseName() As String
			Get
				Return spouseName_Renamed
			End Get
			Set(ByVal value As String)
				SetPropertyValue("SpouseName", spouseName_Renamed, value)
			End Set
		End Property
		Public Property TitleOfCourtesy() As TitleOfCourtesy
			Get
				Return titleOfCourtesy_Renamed
			End Get
			Set(ByVal value As TitleOfCourtesy)
				SetPropertyValue("TitleOfCourtesy", titleOfCourtesy_Renamed, value)
			End Set
		End Property
		Public Property Anniversary() As DateTime
			Get
				Return anniversary_Renamed
			End Get
			Set(ByVal value As DateTime)
				SetPropertyValue("Anniversary", anniversary_Renamed, value)
			End Set
		End Property
		<Size(4096)> _
		Public Property Notes() As String
			Get
				Return notes_Renamed
			End Get
			Set(ByVal value As String)
				SetPropertyValue("Notes", notes_Renamed, value)
			End Set
		End Property
	End Class
	Public Enum TitleOfCourtesy
		Dr
		Miss
		Mr
		Mrs
		Ms
	End Enum
End Namespace
