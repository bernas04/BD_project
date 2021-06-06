<Serializable()> Public Class SecçaoC
    Private _codigo As String
    Private _name As String
    Private _loja_NIF As String
    Private _ID As String

    Property Codigo As String
        Get
            Return _codigo
        End Get
        Set(ByVal value As String)
            _codigo = value
        End Set
    End Property

    Property ID As String
        Get
            Return _ID
        End Get
        Set(ByVal value As String)
            _ID = value
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

    Property LojaNif() As String
        Get
            LojaNif = _loja_NIF
        End Get
        Set(ByVal value As String)
            If value Is Nothing Or value = "" Then
                Throw New Exception("Loja NIF field can’t be empty")
                Exit Property
            End If
            _loja_NIF = value
        End Set
    End Property

    Overrides Function ToString() As String
        Return _codigo & "     " & _name & "       " & _ID & "      "
    End Function

    Public Sub New()
        MyBase.New()
    End Sub
    Public Sub New(ByVal Codigo As String, ByVal Name As String)
        MyBase.New()
        Me.Codigo = Codigo
        Me.Name = Name
    End Sub

End Class
