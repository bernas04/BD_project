<Serializable()> Public Class FuncionarioC
    Private _nunFunc As String
    Private _pessoa_NIF As String

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
    Overrides Function ToString() As String
        Return _nunFunc & "     " & _pessoa_NIF
    End Function

    Public Sub New()
        MyBase.New()
    End Sub



End Class
