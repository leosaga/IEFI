
Imports System.ComponentModel
Imports System.Text
Public Class ClientesCollection
    Inherits BindingList(Of ClienteClass)

    Protected Overrides Sub OnAddingNew(ByVal e As System.ComponentModel.AddingNewEventArgs)
        MyBase.OnAddingNew(e)
        e.NewObject = New ClienteClass
    End Sub

    Protected Overrides ReadOnly Property SupportsSearchingCore() As Boolean
        Get
            Return True
        End Get
    End Property

    Protected Overrides Function FindCore(ByVal prop As PropertyDescriptor, ByVal key As Object) As Integer
        For Each carrera In Me
            If prop.GetValue(carrera).Equals(key) Then
                Return Me.IndexOf(carrera)
            End If
        Next

        Return -1
    End Function

    ''' <summary>
    ''' Trae todos las Articulos.
    ''' </summary>
    ''' <returns></returns>
    Public Function TraerArticulos() As ClientesCollection

        'Si la lista ya esta cargada la limpiamos.
        If Me.Items.Count > 0 Then Me.ClearItems()

        Dim ObjBaseDatos As New BaseDatosClass
        Dim MiDataTable As New DataTable
        Dim MiArticulo As ClienteClass

        'ObjBaseDatos.objTabla = "Articulos"
        ObjBaseDatos.objTabla = "Clientes"
        MiDataTable = ObjBaseDatos.TraerTodo

        For Each dr As DataRow In MiDataTable.Rows
            MiArticulo = New ClienteClass

            MiArticulo.Id = CInt(dr("Id"))
            MiArticulo.Nombre = dr("Nombre")
            'MiArticulo.IdProvincia = CInt("IdProvincia")
            MiArticulo.IdProvincia = CInt(dr("IdProvincia"))

            Me.Add(MiArticulo)
        Next

        Return Me

    End Function

    ''' <summary>
    ''' Trae las Articulos filtrado por IdTurno.
    ''' </summary>
    ''' <param name="IdRubro"></param>
    ''' <returns></returns>
    Public Function TraerArticulos(ByVal IdRubro As Integer) As ClientesCollection

        'Si la lista ya esta cargada la limpiamos.
        If Me.Items.Count > 0 Then Me.ClearItems()

        Dim ObjBaseDatos As New BaseDatosClass
        Dim MiDataTable As New DataTable
        Dim MiArticulo As ClienteClass
        'Dim filtro As String = "IdRubro = " & IdRubro La columna en la tabla se llama IdProvincia
        Dim filtro As String = "IdProvincia = " & IdRubro

        'ObjBaseDatos.objTabla = "Articulos"
        ObjBaseDatos.objTabla = "Clientes"
        MiDataTable = ObjBaseDatos.TraerFiltrado(filtro)

        For Each dr As DataRow In MiDataTable.Rows
            MiArticulo = New ClienteClass

            MiArticulo.Id = CInt(dr("Id"))
            MiArticulo.Nombre = dr("Nombre")
            MiArticulo.IdProvincia = CInt(dr("IdProvincia"))

            Me.Add(MiArticulo)
        Next

        Return Me

    End Function

    Public Sub InsertarArticulo(ByVal MiArticulo As ClienteClass)

        Dim ObjBasedeDato As New BaseDatosClass
        'busca la tabla personas 
        ObjBasedeDato.objTabla = "Clientes"

        Dim vsql As New StringBuilder

        vsql.Append("(Descripcion")
        vsql.Append(", IdRubro)")

        vsql.Append(" VALUES ")

        vsql.Append("('" & MiArticulo.Nombre & "'")
        vsql.Append(", '" & MiArticulo.IdProvincia & "')")

        MiArticulo.Id = ObjBasedeDato.Insertar(vsql.ToString)

        'Evalúa el resultado del comando SQL.
        If MiArticulo.Id = 0 Then
            MsgBox("No fue posible agregar el Articulo ")
            Exit Sub
        End If

        Me.Add(MiArticulo)

    End Sub

    Public Sub EliminarArticulo(ByVal MiArticulo As ClienteClass)

        'Instancio el el Objeto BaseDatosClass para acceder al la base personas.
        Dim objBaseDatos As New BaseDatosClass
        objBaseDatos.objTabla = "Clientes"

        'Ejecuta el método base eliminar.
        Dim resultado As Boolean
        resultado = objBaseDatos.Eliminar(MiArticulo.Id)

        If Not resultado Then
            MessageBox.Show("No fue posible eliminar el registro.")
            Exit Sub
        End If

        'Creates a new collection and assign it the properties for modulo.
        Dim properties As PropertyDescriptorCollection = TypeDescriptor.GetProperties(MiArticulo)

        'Sets an PropertyDescriptor to the specific property Id.
        Dim myProperty As PropertyDescriptor = properties.Find("Id", False)

        Me.RemoveAt(Me.FindCore(myProperty, MiArticulo.Id))

    End Sub

    Public Sub EliminarArticulo(ByVal IdRubro As Integer)

        'Llena articulosList con articulos del IdRubro
        ClientesList.TraerArticulos(IdRubro)

        'Instancio el el Objeto BaseDatosClass para acceder al la base productos.
        Dim objBaseDatos As New BaseDatosClass
        objBaseDatos.objTabla = "Clientes"

        For Each articulo In ClientesList
            'Ejecuta el método base eliminar.
            Dim resultado As Boolean
            resultado = objBaseDatos.Eliminar(articulo.Id)

            If Not resultado Then
                MessageBox.Show("No fue posible eliminar el registro.")
                Exit For
            End If

            'Creates a new collection and assign it the properties for modulo.
            Dim properties As PropertyDescriptorCollection = TypeDescriptor.GetProperties(articulo)

            'Sets an PropertyDescriptor to the specific property Id.
            Dim myProperty As PropertyDescriptor = properties.Find("Id", False)
        Next

        Me.ClearItems()

    End Sub

    Public Sub ActualizarArticulo(ByVal MiArticulo As ClienteClass)

        'Instancio el el Objeto BaseDatosClass para acceder al la base productos.
        Dim objBaseDatos As New BaseDatosClass
        objBaseDatos.objTabla = "Clientes"

        Dim vSQL As New StringBuilder
        Dim vResultado As Boolean = False

        vSQL.Append("Nombre='" & MiArticulo.Nombre & "'")
        vSQL.Append(",IdProvincia='" & MiArticulo.IdProvincia.ToString & "'")

        'Actualizo la tabla personas con el Id.
        Dim resultado As Boolean
        'El método actualizar es una función que devuelve True o False
        'Según como haya resultado la operación sobre la tabla SQL.
        resultado = objBaseDatos.Actualizar(vSQL.ToString, MiArticulo.Id)

        If Not resultado Then
            MessageBox.Show("No fue posible modificar el registro.")
            Exit Sub
        End If

        'El código a continuación sirve para localizar el ítem en la lista
        'en este caso un persona.
        ' Creates a new collection and assign it the properties for modulo.
        Dim properties As PropertyDescriptorCollection = TypeDescriptor.GetProperties(MiArticulo)

        'Sets an PropertyDescriptor to the specific property Id.
        Dim myProperty As PropertyDescriptor = properties.Find("Id", False)
        Me.Items.Item(Me.FindCore(myProperty, MiArticulo.Id)) = MiArticulo

    End Sub
End Class


