Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Data
Imports System.Windows.Documents
Imports System.Windows.Input
Imports System.Windows.Media
Imports System.Windows.Media.Imaging
Imports System.Windows.Navigation
Imports System.Windows.Shapes

Namespace BarItemLinkSeparatorEx
	''' <summary>
	''' Interaction logic for Window1.xaml
	''' </summary>
	Partial Public Class Window1
		Inherits Window
		Public Sub New()
			InitializeComponent()
		End Sub
		#Region "#1"
		' Respond to clicking the bar items
		Private Sub barManager1_ItemClick(ByVal sender As Object, ByVal e As DevExpress.Xpf.Bars.ItemClickEventArgs)
			MessageBox.Show("Item " & e.Item.Content & " has been clicked.")
		End Sub
		#End Region ' #1
	End Class
End Namespace
