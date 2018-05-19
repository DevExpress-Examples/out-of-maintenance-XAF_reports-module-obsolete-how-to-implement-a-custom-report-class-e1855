Imports System.Text
Imports System.ComponentModel

Imports DevExpress.ExpressApp

Namespace CustomReportClass.Module.Win
	<ToolboxItemFilter("Xaf.Platform.Win")> _
	Public NotInheritable Partial Class CustomReportClassWindowsFormsModule
		Inherits ModuleBase

		Public Sub New()
			InitializeComponent()
		End Sub
	End Class
End Namespace
