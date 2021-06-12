<Serializable()> Public Class ParticipantsC
    Private _id As String
    Private _nCliente_NIF As String
    Private _nome As String

    Property Id() As String
        Get
            Return _id
        End Get
        Set(ByVal value As String)
            _id = value
        End Set
    End Property

    Property nClienteNIF() As String
        Get
            Return _nCliente_NIF
        End Get
        Set(ByVal value As String)
            _nCliente_NIF = value
        End Set
    End Property

    Property nome() As String
        Get
            Return _nome
        End Get
        Set(ByVal value As String)
            _nome = value
        End Set
    End Property

    Overrides Function ToString() As String
        Return _id & "       " & _nome & "                 " & _nCliente_NIF
    End Function

    Public Sub New()
        MyBase.New()
    End Sub
    Public Sub New(ByVal Id As String,
                   ByVal Nif As String, ByVal nome As String)
        MyBase.New()
        Me.Id = Id
        Me.nClienteNIF = Nif
        Me.nome = nome

    End Sub


End Class
