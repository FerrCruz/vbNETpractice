<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormularioClientes
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Agregar = New Button()
        Label1 = New Label()
        txtName = New TextBox()
        Label2 = New Label()
        LinkLabel1 = New LinkLabel()
        SuspendLayout()
        ' 
        ' Agregar
        ' 
        Agregar.Location = New Point(181, 217)
        Agregar.Name = "Agregar"
        Agregar.Size = New Size(127, 38)
        Agregar.TabIndex = 0
        Agregar.Text = "Agregar"
        Agregar.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(438, 187)
        Label1.Name = "Label1"
        Label1.Size = New Size(74, 15)
        Label1.TabIndex = 1
        Label1.Text = "Esperando...."
        ' 
        ' txtName
        ' 
        txtName.AccessibleName = "txtName"
        txtName.Location = New Point(181, 157)
        txtName.Name = "txtName"
        txtName.Size = New Size(127, 23)
        txtName.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(117, 160)
        Label2.Name = "Label2"
        Label2.Size = New Size(51, 15)
        Label2.TabIndex = 3
        Label2.Text = "Nombre"
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.AutoSize = True
        LinkLabel1.Location = New Point(323, 160)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(63, 15)
        LinkLabel1.TabIndex = 4
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "LinkLabel1"
        ' 
        ' FormularioClientes
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(LinkLabel1)
        Controls.Add(Label2)
        Controls.Add(txtName)
        Controls.Add(Label1)
        Controls.Add(Agregar)
        Name = "FormularioClientes"
        Text = "FormularioClientes"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Agregar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
End Class
