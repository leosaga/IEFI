Imports System.ComponentModel
Imports System.Text


Public Class ProvinciasCollection
    Inherits BindingList(Of ProvinciaClass)

    Protected Overrides Sub OnAddingNew(ByVal e As System.ComponentModel.AddingNewEventArgs)
        MyBase.OnAddingNew(e)
        e.NewObject = New ProvinciaClass

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


    Public Function TraerRubros() As ProvinciasCollection

        If Me.Items.Count > 0 Then Me.ClearItems()

        'crea la intancia de base de datos
        Dim ObjBaseDatos As New BaseDatosClass
        Dim MiDataTable As New DataTable
        Dim MiRubro As ProvinciaClass

        ObjBaseDatos.objTabla = "Provincias"
        'devuelve los datos de la base de dato
        MiDataTable = ObjBaseDatos.TraerTodo
        'por cada dr (fila)llena Rubros

        For Each dr As DataRow In MiDataTable.Rows
            'crea la instancia por cada campo
            MiRubro = New ProvinciaClass

            MiRubro.Id = CInt(dr("Id"))
            MiRubro.Provincia = dr("Provincia")

            Me.Add(MiRubro)
        Next

        Return Me

    End Function

    Public Sub InsertarRubro(ByVal MiRubro As ProvinciaClass)

        Dim ObjBasedeDato As New BaseDatosClass
        'Establece la propiedad objTabla como Rubros 
        ObjBasedeDato.objTabla = "Provincias"

        Dim vsql As New StringBuilder
        vsql.Append("(Provincia)")

        vsql.Append(" VALUES ")

        vsql.Append("('" & MiRubro.Provincia & "')")

        MiRubro.Id = ObjBasedeDato.Insertar(vsql.ToString)

        'Evalúa el resultado del comando SQL.
        If MiRubro.Id = 0 Then
            MsgBox("No fue posible agregar la Provincia ")
            Exit Sub
        End If

        Me.Add(MiRubro)

    End Sub

    Public Sub EliminarRubro(ByVal MiRubro As ProvinciaClass)

        'Elimina todos los artículos del Rubro
        ClientesList.EliminarArticulo(MiRubro.Id)

        ' Instancio en el objeto BaseDatosClass para accede a la base productos
        Dim objBaseDatos As New BaseDatosClass
        objBaseDatos.objTabla = "Provincias"

        'ejecuta el método base eliminar 
        Dim resultado As Boolean
        resultado = objBaseDatos.Eliminar(MiRubro.Id)

        If Not resultado Then
            MessageBox.Show("No fue posible eliminar el artìculo " + CStr(MiRubro.Provincia))
            Exit Sub
        End If

        'Creates a new collection and assign it the properties for modulo.
        Dim properties As PropertyDescriptorCollection = TypeDescriptor.GetProperties(MiRubro)

        'Sets an PropertyDescriptor to the specific property Id.
        Dim myProperty As PropertyDescriptor = properties.Find("Id", False)

        'Remueve el Turno de la lista.
        Me.RemoveAt(Me.FindCore(myProperty, MiRubro.Id))

    End Sub

    Public Sub ActualizarRubro(ByVal MiRubro As ProvinciaClass)

        'Instancio el el Objeto BaseDatosClass para acceder al la base productos.
        Dim objBaseDatos As New BaseDatosClass
        objBaseDatos.objTabla = "Provincias"

        Dim vSQL As New StringBuilder
        Dim vResultado As Boolean = False

        vSQL.Append("Provincia='" & MiRubro.provincia & "'")

        'Actualizo la tabla Rubros con el Id.
        Dim resultado As Boolean
        'El método actualizar es una función que devuelve True o False
        'Según como haya resultado la operación sobre la tabla SQL.
        resultado = objBaseDatos.Actualizar(vSQL.ToString, MiRubro.Id)

        If Not resultado Then
            MessageBox.Show("No fue posible modificar la Provincia")
            Exit Sub
        End If

        'El código a continuación sirve para localizar el ítem en la lista
        'en este caso un Rubro.
        ' Creates a new collection and assign it the properties for modulo.
        Dim properties As PropertyDescriptorCollection = TypeDescriptor.GetProperties(MiRubro)

        'Sets an PropertyDescriptor to the specific property Id.
        Dim myProperty As PropertyDescriptor = properties.Find("Id", False)
        Me.Items.Item(Me.FindCore(myProperty, MiRubro.Id)) = MiRubro

    End Sub


End Class