Imports System.Windows
Imports System.Windows.Controls

Namespace BarItemLinkSeparatorEx

    ''' <summary>
    ''' Interaction logic for Window1.xaml
    ''' </summary>
    Public Partial Class Window1
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
        End Sub

        ' Respond to clicking the bar items
        Private Sub itemClick(ByVal sender As Object, ByVal e As DevExpress.Xpf.Bars.ItemClickEventArgs)
            MessageBox.Show("Item " & e.Item.Content & " has been clicked.")
        End Sub
    End Class
End Namespace
