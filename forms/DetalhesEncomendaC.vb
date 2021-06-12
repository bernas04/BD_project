Public Class DetalhesEncomendaC
    Private _idEncomenda As String
    Private _nomeProduto As String
    Private _nomeSecçao As String
    Private _codigoSecçao As String
    Private _nomeFuncionario As String
    Private _nifFuncionario As String
    Private _nomeFornecedor As String
    Private _nifFornecedor As String
    Private _moradaFornecedor As String


    Overrides Function ToString() As String
        Return _idEncomenda & "                 " & _nomeProduto & "                     " & _nomeSecçao & "                   " & _nomeFuncionario & "                  " & _nifFuncionario & "              " & _nomeFornecedor & "             " & _nifFornecedor & "         " & _moradaFornecedor
    End Function
    Property IdEncomenda() As String
        Get
            Return _idEncomenda
        End Get
        Set(ByVal value As String)
            _idEncomenda = value
        End Set
    End Property

    Property nomeProduto() As String
        Get
            Return _nomeProduto
        End Get
        Set(ByVal value As String)
            _nomeProduto = value
        End Set
    End Property

    Property nomeSeccao() As String
        Get
            Return _nomeSecçao
        End Get
        Set(ByVal value As String)
            _nomeSecçao = value
        End Set
    End Property

    Property codigoSeccao() As String
        Get
            Return _codigoSecçao
        End Get
        Set(ByVal value As String)
            _codigoSecçao = value
        End Set
    End Property

    Property nomeFuncionario() As String
        Get
            Return _nomeFuncionario
        End Get
        Set(ByVal value As String)
            _nomeFuncionario = value
        End Set
    End Property

    Property nifFuncionario() As String
        Get
            Return _nifFuncionario
        End Get
        Set(ByVal value As String)
            _nifFuncionario = value
        End Set
    End Property

    Property nomeFornecedor() As String
        Get
            Return _nomeFornecedor
        End Get
        Set(ByVal value As String)
            _nomeFornecedor = value
        End Set
    End Property

    Property nifFornecedor() As String
        Get
            Return _nifFornecedor
        End Get
        Set(ByVal value As String)
            _nifFornecedor = value
        End Set
    End Property

    Property moradaFornecedor() As String
        Get
            Return _moradaFornecedor
        End Get
        Set(ByVal value As String)
            _moradaFornecedor = value
        End Set
    End Property

    Public Sub New()
        MyBase.New()
    End Sub

    Public Sub New(ByVal idcompra As String, ByVal nomeProduto As String,
                   ByVal precoProduto As String, ByVal nomePessoa As String, ByVal nifCliente As String,
                   ByVal nomeFuncionario As String, ByVal nomeFornecedor As String, ByVal nifFornecedor As String,
                   ByVal moradaFornecedor As String)
        MyBase.New()
        Me.IdEncomenda = idcompra
        Me.nomeProduto = nomeProduto
        Me.nomeSeccao = precoProduto
        Me.codigoSeccao = nomePessoa
        Me.nifFuncionario = nifCliente
        Me.nomeFuncionario = nomeFuncionario
        Me.nomeFornecedor = nomeFornecedor
        Me.nifFornecedor = nifFornecedor
        Me.moradaFornecedor = moradaFornecedor
    End Sub



End Class
