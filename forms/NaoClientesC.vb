<Serializable()> Public Class NaoClientesC
    Private _NIF As String
    Private _name As String
    Private _email As String
    Private _telefone As String
    Private _genero As String
    Private _data As String


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
    Property Telefone() As String
        Get
            Telefone = _telefone
        End Get
        Set(ByVal value As String)
            If value Is Nothing Or value = "" Then
                Throw New Exception("Name field can’t be empty")
                Exit Property
            End If
            _telefone = value
        End Set
    End Property
    Property Genero() As String
        Get
            Genero = _genero
        End Get
        Set(ByVal value As String)
            If value Is Nothing Or value = "" Then
                Throw New Exception("Name field can’t be empty")
                Exit Property
            End If
            _genero = value
        End Set
    End Property
    Property Data() As String
        Get
            Data = _data
        End Get
        Set(ByVal value As String)
            If value Is Nothing Or value = "" Then
                Throw New Exception("Name field can’t be empty")
                Exit Property
            End If
            _data = value
        End Set
    End Property

    Property Email() As String
        Get
            Email = _email
        End Get
        Set(ByVal value As String)
            If value Is Nothing Or value = "" Then
                Throw New Exception("Morada field can’t be empty")
                Exit Property
            End If
            _email = value
        End Set
    End Property

    Overrides Function ToString() As String
        Return _NIF & "        " & _name & "       " & _email & "      " & _telefone


    End Function

    Public Sub New()
        MyBase.New()
    End Sub
    Public Sub New(ByVal Nif As String, ByVal Name As String,
                   ByVal Email As String, ByVal Genero As String, ByVal Telefone As String, ByVal Data As String)
        MyBase.New()
        Me.Nif = Nif
        Me.Name = Name
        Me.Email = Email
        Me.Data = Data
        Me.Genero = Genero
        Me.Telefone = Telefone
    End Sub

End Class
