<Serializable()> Public Class FuncionarioC
    Private _nunFunc As String
    Private _pessoa_NIF As String
    Private _nome As String
    Private _sec As String
    Private _mail As String
    Private _tele As String

    Property Sec As String
        Get
            Return _sec
        End Get
        Set(ByVal value As String)
            _sec = value
        End Set
    End Property

    Property Nome As String
        Get
            Return _nome
        End Get
        Set(ByVal value As String)
            _nome = value
        End Set
    End Property
    Property Num_func As String
        Get
            Return _nunFunc
        End Get
        Set(ByVal value As String)
            _nunFunc = value
        End Set
    End Property

    Property Pessoa_NIF As String
        Get
            Return _pessoa_NIF
        End Get
        Set(ByVal value As String)
            _pessoa_NIF = value
        End Set
    End Property
    Property Telefone As String
        Get
            Return _tele
        End Get
        Set(ByVal value As String)
            _tele = value
        End Set
    End Property
    Property Mail As String
        Get
            Return _mail
        End Get
        Set(ByVal value As String)
            _mail = value
        End Set
    End Property
    Overrides Function ToString() As String
        Return _nunFunc & "     " & _nome & "     " & _pessoa_NIF & "     " & _sec & "     " & _tele & "     " & _mail
    End Function

    Public Sub New()
        MyBase.New()
    End Sub



End Class
