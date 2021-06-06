<Serializable()> Public Class NaoClientesC
    Private _NIF As String
    Private _name As String
    Private _morada As String


    Property Nif As String
        Get
            Return _NIF
        End Get
        Set(ByVal value As String)
            _NIF = value
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

    Property Morada() As String
        Get
            Morada = _morada
        End Get
        Set(ByVal value As String)
            If value Is Nothing Or value = "" Then
                Throw New Exception("Morada field can’t be empty")
                Exit Property
            End If
            _morada = value
        End Set
    End Property

    Overrides Function ToString() As String
        Return _NIF & "     " & _name & "       " & _morada
    End Function

    Public Sub New()
        MyBase.New()
    End Sub
    Public Sub New(ByVal Nif As String, ByVal Name As String,
                   ByVal Morada As String)
        MyBase.New()
        Me.Nif = Nif
        Me.Name = Name
        Me.Morada = Morada
    End Sub

End Class
