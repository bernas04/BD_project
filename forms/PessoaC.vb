<Serializable()> Public Class PessoaC
    Private _NIF As String
    Private _name As String
    Private _morada As String
    Private _telefone As String
    Private _nascimento As String
    Private _genero As String

    Property Genero() As String
        Get
            Genero = _genero
        End Get
        Set(ByVal value As String)
            If value Is Nothing Or value = "" Then
                Throw New Exception("Morada field can’t be empty")
                Exit Property
            End If
            _genero = value
        End Set
    End Property
    Property Nascimento() As String
        Get
            Nascimento = _nascimento
        End Get
        Set(ByVal value As String)
            If value Is Nothing Or value = "" Then
                Throw New Exception("Morada field can’t be empty")
                Exit Property
            End If
            _nascimento = value
        End Set
    End Property
    Property Nif As String
        Get
            Return _NIF
        End Get
        Set(ByVal value As String)
            _NIF = value
        End Set
    End Property


    Property Name() As String
        Get
            Name = _name
        End Get
        Set(ByVal value As String)
            If value Is Nothing Or value = "" Then
                Throw New Exception("Name field can’t be empty")
                Exit Property
            End If
            _name = value
        End Set
    End Property

    Property Morada() As String
        Get
            Morada = _morada
        End Get
        Set(ByVal value As String)
            If value Is Nothing Or value = "" Then
                Throw New Exception("Morada field can’t be empty")
                Exit Property
            End If
            _morada = value
        End Set
    End Property
    Property Telefone() As String
        Get
            Telefone = _telefone
        End Get
        Set(ByVal value As String)
            If value Is Nothing Or value = "" Then
                Throw New Exception("Morada field can’t be empty")
                Exit Property
            End If
            _telefone = value
        End Set
    End Property

    Overrides Function ToString() As String
        Return _NIF & "     " & _name & "       " & _morada
    End Function

    Public Sub New()
        MyBase.New()
    End Sub
    Public Sub New(ByVal Nif As String, ByVal Name As String,
                   ByVal Morada As String)
        MyBase.New()
        Me.Nif = Nif
        Me.Name = Name
        Me.Morada = Morada
    End Sub


End Class
