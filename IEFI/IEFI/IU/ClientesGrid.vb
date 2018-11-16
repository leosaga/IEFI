Public Class ClientesGrid

    Private Sub Agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Agregar.Click
        ClienteForm.Text = "Agregar artículo"

        ClienteForm.operacion = "Agregar"


        ClienteForm.Show()

       
    End Sub

    Private Sub Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Eliminar.Click
        'Determina si existen filas en el DataGridView
        If DataGridView1.Rows.Count = 0 Then
            MsgBox("No hay filas para eliminar.")
            Exit Sub
        End If

        'boton Eliminar
        ClienteForm.Text = "Eliminar artículo"

        ClienteForm.operacion = "Eliminar"
        ClienteForm.indice = DataGridView1.CurrentRow.Index

        llenarform()
        ClienteForm.Show()

        Dim fila As Integer = DataGridView1.CurrentRow.Index

        'Selecciono nuevamente la fila para que refresque el contenido, sino no muestra la modificación.
        DataGridView1.Rows.Item(fila).Selected = False
        DataGridView1.Rows.Item(fila).Selected = True

    End Sub

    Private Sub Modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Modificar.Click
        'Determina si existen filas en el DataGridView
        If DataGridView1.Rows.Count = 0 Then
            MsgBox("No hay filas para modificar.")
            Exit Sub
        End If

        'boton modificar
        ClienteForm.Text = "Modificar artículo"
        ClienteForm.operacion = "Modificar"
        ClienteForm.indice = DataGridView1.CurrentRow.Index

        llenarform()
        ClienteForm.Show()

        Dim fila As Integer = DataGridView1.CurrentRow.Index

        'Selecciono nuevamente la fila para que refresque el contenido, sino no muestra la modificación.
        DataGridView1.Rows.Item(fila).Selected = False
        DataGridView1.Rows.Item(fila).Selected = True

    End Sub
    Private Sub llenarform()

        'Número de fila seleccionado en el datagridview
        Dim fila As Integer = DataGridView1.CurrentRow.Index

        'funcion que llena la grilla con los datos de base de datos
        ClienteForm.TextBoxId.Text = ClientesList.Item(fila).Id
        ClienteForm.TextBoxNombre.Text = ClientesList.Item(fila).Nombre
        ClienteForm.IdProvincia = ClientesList.Item(fila).IdProvincia

    End Sub

    Private Sub ClientesGrid_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'ComboBox.DataSource = ProvinciasList.TraerRubros
        'Debe asignar la fuente de datos al bindingsource para se llene con datos.
        ClientesCollectionBindingSource.DataSource = ClientesList.TraerArticulos
        'Se debe llenar provinciasList para que se muestre en la columna nombre de provincia.
        ProvinciasList.TraerRubros()

        If DataGridView1.Rows.Count > 0 Then
            DataGridView1.Rows(0).Selected = True
        End If
    End Sub

    Private Sub Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Salir.Click
        Me.Close()
    End Sub

End Class