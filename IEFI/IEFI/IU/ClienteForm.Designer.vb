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
        Me.LabelFecha = New System.Windows.Forms.Label
        Me.LabelSaldo = New System.Windows.Forms.Label
        Me.TextBoxFecha = New System.Windows.Forms.TextBox
        Me.TextBoxSaldo = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'LabelId
        '
        Me.LabelId.AutoSize = True
        Me.LabelId.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LabelId.Location = New System.Drawing.Point(130, 36)
        Me.LabelId.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelId.Name = "LabelId"
        Me.LabelId.Size = New System.Drawing.Size(19, 15)
        Me.LabelId.TabIndex = 0
        Me.LabelId.Text = "Id"
        '
        'LabelNombre
        '
        Me.LabelNombre.AutoSize = True
        Me.LabelNombre.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LabelNombre.Location = New System.Drawing.Point(94, 66)
        Me.LabelNombre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelNombre.Name = "LabelNombre"
        Me.LabelNombre.Size = New System.Drawing.Size(58, 15)
        Me.LabelNombre.TabIndex = 1
        Me.LabelNombre.Text = "Nombre"
        '
        'LabelProvincia
        '
        Me.LabelProvincia.AutoSize = True
        Me.LabelProvincia.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LabelProvincia.Location = New System.Drawing.Point(84, 96)
        Me.LabelProvincia.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelProvincia.Name = "LabelProvincia"
        Me.LabelProvincia.Size = New System.Drawing.Size(66, 15)
        Me.LabelProvincia.TabIndex = 2
        Me.LabelProvincia.Text = "Provincia"
        '
        'Aceptar
        '
        Me.Aceptar.Location = New System.Drawing.Point(160, 229)
        Me.Aceptar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Aceptar.Name = "Aceptar"
        Me.Aceptar.Size = New System.Drawing.Size(100, 26)
        Me.Aceptar.TabIndex = 3
        Me.Aceptar.Text = "Aceptar"
        Me.Aceptar.UseVisualStyleBackColor = True
        '
        'Cancelar
        '
        Me.Cancelar.Location = New System.Drawing.Point(302, 229)
        Me.Cancelar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Cancelar.Name = "Cancelar"
        Me.Cancelar.Size = New System.Drawing.Size(100, 26)
        Me.Cancelar.TabIndex = 4
        Me.Cancelar.Text = "Cancelar"
        Me.Cancelar.UseVisualStyleBackColor = True
        '
        'TextBoxId
        '
        Me.TextBoxId.Enabled = False
        Me.TextBoxId.Location = New System.Drawing.Point(160, 32)
        Me.TextBoxId.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBoxId.Name = "TextBoxId"
        Me.TextBoxId.Size = New System.Drawing.Size(98, 21)
        Me.TextBoxId.TabIndex = 5
        '
        'TextBoxNombre
        '
        Me.TextBoxNombre.Location = New System.Drawing.Point(160, 62)
        Me.TextBoxNombre.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBoxNombre.Name = "TextBoxNombre"
        Me.TextBoxNombre.Size = New System.Drawing.Size(356, 21)
        Me.TextBoxNombre.TabIndex = 6
        '
        'ComboBoxProvincia
        '
        Me.ComboBoxProvincia.FormattingEnabled = True
        Me.ComboBoxProvincia.Location = New System.Drawing.Point(160, 92)
        Me.ComboBoxProvincia.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ComboBoxProvincia.Name = "ComboBoxProvincia"
        Me.ComboBoxProvincia.Size = New System.Drawing.Size(356, 23)
        Me.ComboBoxProvincia.TabIndex = 7
        '
        'LabelFecha
        '
        Me.LabelFecha.AutoSize = True
        Me.LabelFecha.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LabelFecha.Location = New System.Drawing.Point(102, 127)
        Me.LabelFecha.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelFecha.Name = "LabelFecha"
        Me.LabelFecha.Size = New System.Drawing.Size(46, 15)
        Me.LabelFecha.TabIndex = 8
        Me.LabelFecha.Text = "Fecha"
        '
        'LabelSaldo
        '
        Me.LabelSaldo.AutoSize = True
        Me.LabelSaldo.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LabelSaldo.Location = New System.Drawing.Point(106, 157)
        Me.LabelSaldo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelSaldo.Name = "LabelSaldo"
        Me.LabelSaldo.Size = New System.Drawing.Size(44, 15)
        Me.LabelSaldo.TabIndex = 9
        Me.LabelSaldo.Text = "Saldo"
        '
        'TextBoxFecha
        '
        Me.TextBoxFecha.Location = New System.Drawing.Point(160, 124)
        Me.TextBoxFecha.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBoxFecha.Name = "TextBoxFecha"
        Me.TextBoxFecha.Size = New System.Drawing.Size(132, 21)
        Me.TextBoxFecha.TabIndex = 10
        '
        'TextBoxSaldo
        '
        Me.TextBoxSaldo.Location = New System.Drawing.Point(160, 154)
        Me.TextBoxSaldo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBoxSaldo.Name = "TextBoxSaldo"
        Me.TextBoxSaldo.Size = New System.Drawing.Size(132, 21)
        Me.TextBoxSaldo.TabIndex = 11
        '
        'ClienteForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Green
        Me.ClientSize = New System.Drawing.Size(564, 294)
        Me.Controls.Add(Me.TextBoxSaldo)
        Me.Controls.Add(Me.TextBoxFecha)
        Me.Controls.Add(Me.LabelSaldo)
        Me.Controls.Add(Me.LabelFecha)
        Me.Controls.Add(Me.ComboBoxProvincia)
        Me.Controls.Add(Me.TextBoxNombre)
        Me.Controls.Add(Me.TextBoxId)
        Me.Controls.Add(Me.Cancelar)
        Me.Controls.Add(Me.Aceptar)
        Me.Controls.Add(Me.LabelProvincia)
        Me.Controls.Add(Me.LabelNombre)
        Me.Controls.Add(Me.LabelId)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ClienteForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
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
    Friend WithEvents LabelFecha As System.Windows.Forms.Label
    Friend WithEvents LabelSaldo As System.Windows.Forms.Label
    Friend WithEvents TextBoxFecha As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxSaldo As System.Windows.Forms.TextBox
End Class
