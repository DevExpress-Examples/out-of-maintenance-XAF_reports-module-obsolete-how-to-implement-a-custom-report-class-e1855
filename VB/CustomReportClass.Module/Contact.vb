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

        Private _webPageAddress As String
        Private _nickName As String
        Private _spouseName As String
        Private _titleOfCourtesy As TitleOfCourtesy
        Private _notes As String
        Private _anniversary As Date
        Public Sub New(ByVal session As Session)
            MyBase.New(session)
        End Sub
        Public Property WebPageAddress() As String
            Get
                Return _webPageAddress
            End Get
            Set(ByVal value As String)
                SetPropertyValue("WebPageAddress", _webPageAddress, value)
            End Set
        End Property
        Public Property NickName() As String
            Get
                Return _nickName
            End Get
            Set(ByVal value As String)
                SetPropertyValue("NickName", _nickName, value)
            End Set
        End Property
        Public Property SpouseName() As String
            Get
                Return _spouseName
            End Get
            Set(ByVal value As String)
                SetPropertyValue("SpouseName", _spouseName, value)
            End Set
        End Property
        Public Property TitleOfCourtesy() As TitleOfCourtesy
            Get
                Return _titleOfCourtesy
            End Get
            Set(ByVal value As TitleOfCourtesy)
                SetPropertyValue("TitleOfCourtesy", _titleOfCourtesy, value)
            End Set
        End Property
        Public Property Anniversary() As Date
            Get
                Return _anniversary
            End Get
            Set(ByVal value As Date)
                SetPropertyValue("Anniversary", _anniversary, value)
            End Set
        End Property
        <Size(4096)> _
        Public Property Notes() As String
            Get
                Return _notes
            End Get
            Set(ByVal value As String)
                SetPropertyValue("Notes", _notes, value)
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
