Public Class ProdutosecçaoC
    Private _codigosecçao As String
    Private _nomesecçao As String
    Private _codigoproduto As String
    Private _produto As String
    Private _stock As String
    Private _preco As String
    Private _descircao As String

    Property seccao() As String
        Get
            Return _codigosecçao
        End Get
        Set(ByVal value As String)
            _codigosecçao = value
        End Set
    End Property

    Property nomesec() As String
        Get
            Return _nomesecçao
        End Get
        Set(ByVal value As String)
            _nomesecçao = value
        End Set
    End Property

    Property codProd() As String
        Get
            Return _codigoproduto
        End Get
        Set(ByVal value As String)
            _codigoproduto = value
        End Set
    End Property

    Property prod() As String
        Get
            Return _produto
        End Get
        Set(ByVal value As String)
            _produto = value
        End Set
    End Property

    Property stock() As String
        Get
            Return _stock
        End Get
        Set(ByVal value As String)
            _stock = value
        End Set
    End Property

    Property preco() As String
        Get
            Return _preco
        End Get
        Set(ByVal value As String)
            _preco = value
        End Set
    End Property

    Property descricao() As String
        Get
            Return _descircao
        End Get
        Set(ByVal value As String)
            _descircao = value
        End Set
    End Property

    Overrides Function ToString() As String
        Return _codigosecçao & "                    " & _nomesecçao & "                             " & _codigoproduto & "                      " & _produto & "                        " & _stock & "                          " & _preco
    End Function

    Public Sub New()
        MyBase.New()
    End Sub
    Public Sub New(ByVal Id As String,
                   ByVal nomesec As String, ByVal codProd As String, ByVal prod As String, ByVal stock As String,
                   ByVal preco As String, ByVal descricao As String)
        MyBase.New()
        Me.seccao = Id
        Me.nomesec = nomesec
        Me.codProd = codProd
        Me.prod = prod
        Me.stock = stock
        Me.preco = preco
        Me.descricao = descricao

    End Sub



End Class
