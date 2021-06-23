<Serializable()> Public Class Search
    Private _codigo As String
    Private _name As String

    Property Codigo As String
        Get
            Return _codigo
        End Get
        Set(ByVal value As String)
            _codigo = value
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

    Overrides Function ToString() As String
        Return _codigo & "        " & _name
    End Function

    Public Sub New()
        MyBase.New()
    End Sub
End Class
