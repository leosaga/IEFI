Public Class ClienteForm
    Dim MiArticulo As New ClienteClass
    Dim operacion_ As String

    Public Property operacion() As String
        Get
            Return operacion_
        End Get
        Set(ByVal value As String)
            operacion_ = value
        End Set
    End Property

    Dim indice_ As Byte

    Public Property indice() As Byte
        Get
            Return indice_
        End Get
        Set(ByVal value As Byte)
            indice_ = value
        End Set
    End Property

    Dim IdProvincia_ As Integer

    Public Property IdProvincia() As Integer
        Get
            Return IdProvincia_
        End Get
        Set(ByVal value As Integer)
            IdProvincia_ = value
        End Set
    End Property


    Private Sub Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Aceptar.Click
        If operacion_ <> "Agregar" Then
            MiArticulo.Id = CInt(TextBoxId.Text)
        End If

        MiArticulo.Nombre = TextBoxNombre.Text
        'MiArticulo.IdRubro = RubroComboBox.SelectedValue
        MiArticulo.IdProvincia = ComboBoxProvincia.SelectedIndex
        MiArticulo.Fecha = TextBoxFecha.Text
        MiArticulo.Saldo = TextBoxSaldo.Text
        Select Case operacion_

            Case "Agregar"
                ' If RubroComboBox.SelectedIndex = -1 Then Exit Sub

                ClientesList.InsertarArticulo(MiArticulo)

            Case "Eliminar"
                ClientesList.EliminarArticulo(MiArticulo)

            Case "Modificar"
                ClientesList.ActualizarArticulo(MiArticulo)

        End Select

        Me.Close()
    End Sub

    Private Sub Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancelar.Click
        Me.Close()
    End Sub

    Private Sub ClienteForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Debe consignar la fuente de datos para ComboBoxProvincia
        ComboBoxProvincia.DataSource = ProvinciasList.TraerRubros
        ComboBoxProvincia.DisplayMember = "Provincia"
        ComboBoxProvincia.ValueMember = "Id"
        ComboBoxProvincia.SelectedValue = IdProvincia_
    End Sub

    
  
    Private Sub TextBoxFecha_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxFecha.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not e.KeyChar = "/" Then
            ' no lo deja pasar
            e.Handled = True
            'sale sin procesar
            Exit Sub

        End If

        Dim pos As Integer = TextBoxFecha.SelectionStart
        'TextBox1.SelectionStart (obtiene la posicion del cursor)
        ' si la tecla pulsada es / y la posicion del cursor es distinta de 2y la posicion del cursor es distinto de 5 entonces habilitar handled y salir
        If e.KeyChar = "/" And pos <> 2 And pos <> 5 Then
            e.Handled = True
            Exit Sub
        End If
        'si la tecla pulsada es un numero y pos es 2 o 5 entonces habilitar handled y salir
        If Char.IsNumber(e.KeyChar) And (pos = 2 Or pos = 5) Then
            e.Handled = True
            Exit Sub
        End If

    End Sub

    Private Sub TextBoxFecha_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBoxFecha.LostFocus

        Dim dia As Integer = CInt(TextBoxFecha.Text.Substring(0, 2))
        Dim mes As Integer = CInt(TextBoxFecha.Text.Substring(3, 2))
        Dim año As Integer = CInt(TextBoxFecha.Text.Substring(6, 4))

        'si el año es menor a 1980 o el año es mayor a 2018 esta mal
        If año < 1990 Or año > 2018 Then
            MsgBox("año no valido")
            TextBoxFecha.Focus()
            Exit Sub
        End If

        If mes < 1 Or mes > 12 Then
            MsgBox("mes no valido")
            TextBoxFecha.Focus()
            Exit Sub

        End If
        Select Case mes
            Case 1, 3, 5, 7, 8, 10, 12
                If dia < 1 Or dia > 31 Then
                    MsgBox("dia no valido")
                    TextBoxFecha.Focus()
                    Exit Sub
                End If
            Case 4, 6, 9, 11
                If dia < 1 Or dia > 30 Then

                    MsgBox("dia no valido")
                    TextBoxFecha.Focus()
                    Exit Sub
                End If
            Case 2
                If año Mod 4 = 0 Then
                    If dia < 1 Or dia > 29 Then
                        MsgBox("dia no valido")
                        TextBoxFecha.Focus()
                    End If
                Else
                    If dia < 1 Or dia > 28 Then

                        MsgBox("dia no valido")
                        TextBoxFecha.Focus()
                        Exit Sub
                    End If
                End If



        End Select
    End Sub


    Private Sub TextBoxNombre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxNombre.KeyPress
        If Char.IsLetter(e.KeyChar) Or Char.IsWhiteSpace(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            'no lo muestra
            e.Handled = True

        End If
    End Sub

    Private Sub TextBoxSaldo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxSaldo.KeyPress
        If Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar) Or e.KeyChar = "." Then
            'lo muestra
            e.Handled = False
        Else
            'no lo muestra
            e.Handled = True

        End If


        'If e.KeyChar = "." And TextBox1.Text.IndexOf(".") > -1 Then
        '    'no lo muestra
        '    e.Handled = True
        'End If
        Dim punto As Integer = TextBoxSaldo.Text.IndexOf(".")
        If e.KeyChar = "." And punto > -1 Then
            e.Handled = True
        End If
        Dim dec As String = TextBoxSaldo.Text.Substring(punto + 1)
        If dec.Length = 2 And punto > -1 And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

End Class
 