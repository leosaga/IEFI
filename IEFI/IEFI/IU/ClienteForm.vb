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

End Class
 