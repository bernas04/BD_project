<Serializable()> Public Class ProdutosC
    Private _codigo As String
    Private _name As String
    Private _stock As String
    Private _descricao As String
    Private _preco As String
    Private _sec_code As String
    Private _Tipo_prod As String


    Property Codigo As String
        Get
            Return _codigo
        End Get
        Set(ByVal value As String)
            _codigo = value
        End Set
    End Property
    Property TipoProduto() As String
        Get
            TipoProduto = _Tipo_prod
        End Get
        Set(ByVal value As String)
            If value Is Nothing Or value = "" Then
                Throw New Exception("Name field can’t be empty")
                Exit Property
            End If
            _Tipo_prod = value
        End Set
    End Property
    Property SecCode() As String
        Get
            SecCode = _sec_code
        End Get
        Set(ByVal value As String)
            If value Is Nothing Or value = "" Then
                Throw New Exception("Name field can’t be empty")
                Exit Property
            End If
            _sec_code = value
        End Set
    End Property
    Property Preco() As String
        Get
            Preco = _preco
        End Get
        Set(ByVal value As String)
            If value Is Nothing Or value = "" Then
                Throw New Exception("Name field can’t be empty")
                Exit Property
            End If
            _preco = value
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
    Property Descricao() As String
        Get
            Descricao = _descricao
        End Get
        Set(ByVal value As String)
            If value Is Nothing Or value = "" Then
                Throw New Exception("Name field can’t be empty")
                Exit Property
            End If
            _descricao = value
        End Set
    End Property


    Property Stock() As String
        Get
            Stock = _stock
        End Get
        Set(ByVal value As String)
            If value Is Nothing Or value = "" Then
                Throw New Exception("Morada field can’t be empty")
                Exit Property
            End If
            _stock = value
        End Set
    End Property



    Overrides Function ToString() As String
        Return _name & "        " & _preco & "        " & _stock
    End Function

    Public Sub New()
        MyBase.New()
    End Sub

End Class
