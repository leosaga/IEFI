Public Class ClienteClass


    Dim Id_, IdProvincia_ As Integer
    Dim Nombre_, NomProvincia_ As String
    Dim Fecha_ As Date
    Dim Saldo_ As Decimal

    ''' <summary>
    ''' Propiedad Id para leer y escribir Id_
    ''' </summary>
    ''' <returns>Id del Artículo.</returns>
    Public Property Id() As Integer
        Get
            Return Id_
        End Get
        Set(ByVal value As Integer)
            Id_ = value
        End Set
    End Property
    Public Property Fecha() As Date
        Get
            Return Fecha_
        End Get
        Set(ByVal value As Date)
            Fecha_ = value
        End Set
    End Property
    Public Property Saldo() As Decimal
        Get
            Return Saldo_
        End Get
        Set(ByVal value As Decimal)
            Saldo_ = value
        End Set
    End Property


    ''' <summary>
    ''' Propiedad Descripcion para leer y escribir Descripcion_
    ''' </summary>
    ''' <returns></returns>
    Public Property Nombre() As String
        Get
            Return Nombre_
        End Get
        Set(ByVal value As String)
            Nombre_ = value
        End Set
    End Property

    Public Property IdProvincia() As Integer
        Get
            Return IdProvincia_
        End Get
        Set(ByVal value As Integer)
            IdProvincia_ = value
        End Set
    End Property

    'Esta es la forma correcta de acceder al nombre de la provincia.
    Public ReadOnly Property NomProvincia()
        Get
            For Each provin As ProvinciaClass In ProvinciasList
                If provin.Id = IdProvincia_ Then
                    NomProvincia_ = provin.Provincia
                    Exit For
                End If
            Next
            Return NomProvincia_
        End Get
    End Property


End Class
