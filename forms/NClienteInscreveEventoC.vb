Public Class NClienteInscreveEventoC
    Private _numEvento As String
    Private _hora As String
    Private _data As String
    Private _vagas As String
    Property Vagas() As String
        Get
            Return _vagas
        End Get
        Set(ByVal value As String)
            _vagas = value
        End Set
    End Property

    Property numEvento() As String
        Get
            Return _numEvento
        End Get
        Set(ByVal value As String)
            _numEvento = value
        End Set
    End Property

    Property Hora() As String
        Get
            Return _hora
        End Get
        Set(ByVal value As String)
            _hora = value
        End Set
    End Property

    Property Data() As String
        Get
            Return _data
        End Get
        Set(ByVal value As String)
            _data = value
        End Set
    End Property

    Overrides Function ToString() As String
        Return _numEvento & "                           " & _hora & "            " & _data & "          " & _vagas
    End Function

    Public Sub New()
        MyBase.New()
    End Sub
    Public Sub New(ByVal nEvento As String, ByVal hora As String,
                   ByVal data As String, ByVal vagas As String)
        MyBase.New()
        Me.numEvento = nEvento
        Me.Hora = hora
        Me.Data = data
        Me.Vagas = vagas
    End Sub
End Class
