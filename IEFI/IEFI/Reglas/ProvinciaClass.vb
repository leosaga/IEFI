Public Class ProvinciaClass


    Dim Id_ As Integer
    Dim Provincia_ As String

    ''' <summary>
    ''' Propiedad Id para leer y escribir Id_
    ''' </summary>
    ''' <returns></returns>
    Public Property Id() As Integer
        Get
            Return Id_
        End Get
        Set(ByVal value As Integer)
            Id_ = value
        End Set
    End Property

    ''' <summary>
    ''' Propiedad Descripcion para leer y escribir Descripcion_
    ''' </summary>
    ''' <returns></returns>
    Public Property Provincia() As String
        Get
            Return Provincia_
        End Get
        Set(ByVal value As String)
            Provincia_ = value
        End Set
    End Property
End Class

