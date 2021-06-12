Public Class DetalhesCompraC
    Private _compraID As String
    Private _nomeProduto As String
    Private _precoProduto As String
    Private _nomePessoa As String
    Private _nifCliente As String

    Property CompraId() As String
        Get
            Return _compraID
        End Get
        Set(ByVal value As String)
            _compraID = value
        End Set
    End Property

    Property NomeProduto() As String
        Get
            Return _nomeProduto
        End Get
        Set(ByVal value As String)
            _nomeProduto = value
        End Set
    End Property

    Property PrecoProduto() As String
        Get
            Return _precoProduto
        End Get
        Set(ByVal value As String)
            _precoProduto = value
        End Set
    End Property


    Property nomePessoa() As String
        Get
            Return _nomePessoa
        End Get
        Set(ByVal value As String)
            _nomePessoa = value
        End Set
    End Property
    Property NifCliente() As String
        Get
            Return _nifCliente
        End Get
        Set(ByVal value As String)
            _nifCliente = value
        End Set
    End Property

    Overrides Function ToString() As String
        Return _compraID & "                 " & _nomeProduto & "                     " & _precoProduto & "                       " & _nomePessoa & "                   " & _nifCliente
    End Function

    Public Sub New()
        MyBase.New()
    End Sub

    Public Sub New(ByVal idcompra As String, ByVal nomeProduto As String,
                   ByVal precoProduto As String, ByVal nomePessoa As String, ByVal nifCliente As String)
        MyBase.New()
        Me.CompraId = idcompra
        Me.NomeProduto = nomeProduto
        Me.PrecoProduto = precoProduto
        Me.nomePessoa = nomePessoa
        Me.NifCliente = nifCliente
    End Sub


End Class
