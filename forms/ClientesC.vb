Public Class ClientesC
    Private _id As String
    Private _nome As String
    Private _nif As String
    Private _ntelefone As String
    Private _datanascimento As String
    Private _email As String
    Private _genero As String

    Property Id As String
        Get
            Return _id
        End Get
        Set(ByVal value As String)
            _id = value
        End Set
    End Property

    Property Nome As String
        Get
            Return _nome
        End Get
        Set(ByVal value As String)
            _nome = value
        End Set
    End Property

    Property Nif As String
        Get
            Return _nif
        End Get
        Set(ByVal value As String)
            _nif = value
        End Set
    End Property

    Property Ntelefone As String
        Get
            Return _ntelefone
        End Get
        Set(ByVal value As String)
            _ntelefone = value
        End Set
    End Property

    Property Datanascimento As String
        Get
            Return _datanascimento
        End Get
        Set(ByVal value As String)
            _datanascimento = value
        End Set
    End Property

    Property Email As String
        Get
            Return _email
        End Get
        Set(ByVal value As String)
            _email = value
        End Set
    End Property

    Property Genero As String
        Get
            Return _genero
        End Get
        Set(ByVal value As String)
            _genero = value
        End Set
    End Property

    Overrides Function ToString() As String
        Return _id & "     " & _nome & "       " & _genero & "              " & _nif & "         " & _ntelefone & "              " & _datanascimento & "                 " & _email
    End Function

    Public Sub New()
        MyBase.New()
    End Sub

    Public Sub New(ByVal Id As String, ByVal Nome As String,
                   ByVal Nif As String, ByVal Ntelefone As String, ByVal Datanascimento As String,
                   ByVal Email As String, ByVal Genero As String)
        MyBase.New()
        Me.Id = Id
        Me.Nome = Nome
        Me.Nif = Nif
        Me.Ntelefone = Ntelefone
        Me.Datanascimento = Datanascimento
        Me.Email = Email
        Me.Genero = Genero
    End Sub

End Class
