<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClienteForm
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
        Me.LabelId = New System.Windows.Forms.Label
        Me.LabelNombre = New System.Windows.Forms.Label
        Me.LabelProvincia = New System.Windows.Forms.Label
        Me.Aceptar = New System.Windows.Forms.Button
        Me.Cancelar = New System.Windows.Forms.Button
        Me.TextBoxId = New System.Windows.Forms.TextBox
        Me.TextBoxNombre = New System.Windows.Forms.TextBox
        Me.ComboBoxProvincia = New System.Windows.Forms.ComboBox
        Me.SuspendLayout()
        '
        'LabelId
        '
        Me.LabelId.AutoSize = True
        Me.LabelId.Location = New System.Drawing.Point(48, 31)
        Me.LabelId.Name = "LabelId"
        Me.LabelId.Size = New System.Drawing.Size(16, 13)
        Me.LabelId.TabIndex = 0
        Me.LabelId.Text = "Id"
        '
        'LabelNombre
        '
        Me.LabelNombre.AutoSize = True
        Me.LabelNombre.Location = New System.Drawing.Point(51, 59)
        Me.LabelNombre.Name = "LabelNombre"
        Me.LabelNombre.Size = New System.Drawing.Size(44, 13)
        Me.LabelNombre.TabIndex = 1
        Me.LabelNombre.Text = "Nombre"
        '
        'LabelProvincia
        '
        Me.LabelProvincia.AutoSize = True
        Me.LabelProvincia.Location = New System.Drawing.Point(54, 92)
        Me.LabelProvincia.Name = "LabelProvincia"
        Me.LabelProvincia.Size = New System.Drawing.Size(51, 13)
        Me.LabelProvincia.TabIndex = 2
        Me.LabelProvincia.Text = "Provincia"
        '
        'Aceptar
        '
        Me.Aceptar.Location = New System.Drawing.Point(57, 189)
        Me.Aceptar.Name = "Aceptar"
        Me.Aceptar.Size = New System.Drawing.Size(75, 23)
        Me.Aceptar.TabIndex = 3
        Me.Aceptar.Text = "Aceptar"
        Me.Aceptar.UseVisualStyleBackColor = True
        '
        'Cancelar
        '
        Me.Cancelar.Location = New System.Drawing.Point(168, 189)
        Me.Cancelar.Name = "Cancelar"
        Me.Cancelar.Size = New System.Drawing.Size(75, 23)
        Me.Cancelar.TabIndex = 4
        Me.Cancelar.Text = "Cancelar"
        Me.Cancelar.UseVisualStyleBackColor = True
        '
        'TextBoxId
        '
        Me.TextBoxId.Location = New System.Drawing.Point(120, 24)
        Me.TextBoxId.Name = "TextBoxId"
        Me.TextBoxId.Size = New System.Drawing.Size(123, 20)
        Me.TextBoxId.TabIndex = 5
        '
        'TextBoxNombre
        '
        Me.TextBoxNombre.Location = New System.Drawing.Point(120, 51)
        Me.TextBoxNombre.Name = "TextBoxNombre"
        Me.TextBoxNombre.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxNombre.TabIndex = 6
        '
        'ComboBoxProvincia
        '
        Me.ComboBoxProvincia.FormattingEnabled = True
        Me.ComboBoxProvincia.Location = New System.Drawing.Point(120, 83)
        Me.ComboBoxProvincia.Name = "ComboBoxProvincia"
        Me.ComboBoxProvincia.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxProvincia.TabIndex = 7
        '
        'ClienteForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.ComboBoxProvincia)
        Me.Controls.Add(Me.TextBoxNombre)
        Me.Controls.Add(Me.TextBoxId)
        Me.Controls.Add(Me.Cancelar)
        Me.Controls.Add(Me.Aceptar)
        Me.Controls.Add(Me.LabelProvincia)
        Me.Controls.Add(Me.LabelNombre)
        Me.Controls.Add(Me.LabelId)
        Me.Name = "ClienteForm"
        Me.Text = "ClienteForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelId As System.Windows.Forms.Label
    Friend WithEvents LabelNombre As System.Windows.Forms.Label
    Friend WithEvents LabelProvincia As System.Windows.Forms.Label
    Friend WithEvents Aceptar As System.Windows.Forms.Button
    Friend WithEvents Cancelar As System.Windows.Forms.Button
    Friend WithEvents TextBoxId As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxNombre As System.Windows.Forms.TextBox
    Friend WithEvents ComboBoxProvincia As System.Windows.Forms.ComboBox
End Class
