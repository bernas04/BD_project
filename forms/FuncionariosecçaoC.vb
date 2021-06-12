Public Class FuncionariosecçaoC
    Private _nomePessoa As String
    Private _numFunc As String
    Private _NIF As String
    Private _codigo As String
    Private _nomeSec As String
    Private _Chefe As String


    Property nome() As String
        Get
            Return _nomePessoa
        End Get
        Set(ByVal value As String)
            _nomePessoa = value
        End Set
    End Property

    Property numFu() As String
        Get
            Return _numFunc
        End Get
        Set(ByVal value As String)
            _numFunc = value
        End Set
    End Property

    Property nif() As String
        Get
            Return _NIF
        End Get
        Set(ByVal value As String)
            _NIF = value
        End Set
    End Property

    Property codigo() As String
        Get
            Return _codigo
        End Get
        Set(ByVal value As String)
            _codigo = value
        End Set
    End Property

    Property nomeSec() As String
        Get
            Return _nomeSec
        End Get
        Set(ByVal value As String)
            _nomeSec = value
        End Set
    End Property

    Property chefe() As String
        Get
            Return _Chefe
        End Get
        Set(ByVal value As String)
            _Chefe = value
        End Set
    End Property


    Overrides Function ToString() As String
        Return _nomePessoa & "                   " & _numFunc & "                        " & _NIF
    End Function

    Public Sub New()
        MyBase.New()
    End Sub
    Public Sub New(ByVal Id As String,
                   ByVal nomesec As String, ByVal codProd As String, ByVal prod As String, ByVal stock As String,
                   ByVal preco As String)
        MyBase.New()
        Me.nome = Id
        Me.numFu = nomesec
        Me.nif = codProd
        Me.codigo = prod
        Me.nomeSec = stock
        Me.chefe = preco

    End Sub

End Class
