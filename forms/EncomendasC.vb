<Serializable()> Public Class EncomendasC
    Private _conta As String
    Private _dataPedido As String
    Private _dataEntrega As String
    Private _codProd As String
    Private _nFunct As String
    Private _niFornecedor As String
    Private _id As String

    Property Conta() As String
        Get
            Return _conta
        End Get
        Set(ByVal value As String)
            _conta = value
        End Set
    End Property

    Property DataPedido() As String
        Get
            Return _dataPedido
        End Get
        Set(ByVal value As String)
            _dataPedido = value
        End Set
    End Property

    Property DataEntrega() As String
        Get
            Return _dataEntrega
        End Get
        Set(ByVal value As String)
            _dataEntrega = value
        End Set
    End Property

    Property Id() As String
        Get
            Id = _id
        End Get
        Set(ByVal value As String)
            If value Is Nothing Or value = "" Then
                Throw New Exception("Product code field can’t be empty")
                Exit Property
            End If
            _id = value
        End Set
    End Property

    Property CodProd() As String
        Get
            CodProd = _codProd
        End Get
        Set(ByVal value As String)
            If value Is Nothing Or value = "" Then
                Throw New Exception("Product code field can’t be empty")
                Exit Property
            End If
            _codProd = value
        End Set
    End Property

    Property niFornecedor() As String
        Get
            niFornecedor = _niFornecedor
        End Get
        Set(ByVal value As String)
            If value Is Nothing Or value = "" Then
                Throw New Exception("Product code field can’t be empty")
                Exit Property
            End If
            _niFornecedor = value
        End Set
    End Property

    Property nFunct() As String
        Get
            nFunct = _nFunct
        End Get
        Set(ByVal value As String)
            If value Is Nothing Or value = "" Then
                Throw New Exception("Product code field can’t be empty")
                Exit Property
            End If
            _nFunct = value
        End Set
    End Property

    Overrides Function ToString() As String
        Return _id & "          " & _conta & "                  " & _dataPedido & "                         " & _dataEntrega & "                         " & _codProd & "                               " & _nFunct & "                                         " & _niFornecedor
    End Function



End Class
