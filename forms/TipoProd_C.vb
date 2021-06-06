<Serializable()> Public Class TipoProd_C
    Private _codigo As String

    Private _descricao As String


    Property Codigo As String
        Get
            Return _codigo
        End Get
        Set(ByVal value As String)
            _codigo = value
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
    Overrides Function ToString() As String
        Return _codigo & "        " & _descricao
    End Function

    Public Sub New()
        MyBase.New()
    End Sub
End Class
