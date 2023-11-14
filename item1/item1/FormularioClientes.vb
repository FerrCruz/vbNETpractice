Public Class FormularioClientes
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
    Private Sub FormularioClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LinkLabel1.Text = "Click here to get more info."
        LinkLabel1.Links.Add(6, 4, "www.microsoft.com")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Agregar.Click
        Dim a As String = txtName.Text
        Label1.Text = a
        Console.WriteLine(a)
        Console.ReadLine()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal _
        e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        System.Diagnostics.Process.Start(e.Link.LinkData.ToString())
    End Sub


End Class