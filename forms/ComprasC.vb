<Serializable()> Public Class ComprasC
    Private _total As String
    Private _Id As String
    Private _dataCompra As String
    Private _clienteId As String

    Property ClienteId() As String
        Get
            Return _clienteId
        End Get
        Set(ByVal value As String)
            _clienteId = value
        End Set
    End Property

    Property Total() As String
        Get
            Return _total
        End Get
        Set(ByVal value As String)
            _total = value
        End Set
    End Property

    Property Data() As String
        Get
            Return _dataCompra
        End Get
        Set(ByVal value As String)
            _dataCompra = value
        End Set
    End Property
    Property Id() As String
        Get
            Id = _Id
        End Get
        Set(ByVal value As String)
            If value Is Nothing Or value = "" Then
                Throw New Exception("Product code field can’t be empty")
                Exit Property
            End If
            _Id = value
        End Set
    End Property

    Overrides Function ToString() As String
        Return _clienteId & "       " & _dataCompra & "                 " & _Id & "                     " & _total
    End Function

    Public Sub New()
        MyBase.New()
    End Sub
    Public Sub New(ByVal Data As String, ByVal Id As String,
                   ByVal Total As String, ByVal ClienteId As String)
        MyBase.New()
        Me.Data = Data
        Me.Id = Id
        Me.Total = Total
        Me.ClienteId = ClienteId

    End Sub
End Class
