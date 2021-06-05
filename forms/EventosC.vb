<Serializable()> Public Class EventosC
    Private _data As String
    Private _hora As String
    Private _nVagas As String
    Private _custo As String
    Private _codigoSeccao As String
    Private _id As String

    Property Id() As String
        Get
            Return _id
        End Get
        Set(ByVal value As String)
            _id = value
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


    Property Hora() As String
        Get
            Hora = _hora
        End Get
        Set(ByVal value As String)
            If value Is Nothing Or Not value.Contains(":") Or value = "" Then
                Throw New Exception("Hour field can’t be empty")
                Exit Property
            End If
            _hora = value
        End Set
    End Property

    Property Nvagas() As String
        Get
            Nvagas = _nVagas
        End Get
        Set(ByVal value As String)
            _nVagas = value
        End Set
    End Property

    Property Custo() As String
        Get
            Custo = _custo
        End Get
        Set(ByVal value As String)
            _custo = value
        End Set
    End Property

    Property CodSec() As String
        Get
            CodSec = _codigoSeccao
        End Get
        Set(ByVal value As String)
            If value Is Nothing Or value = "" Then
                Throw New Exception("Section field can’t be empty")
                Exit Property
            End If
            _codigoSeccao = value
        End Set
    End Property



    Overrides Function ToString() As String
        Return _id & "     " & _data & "     " & _hora & "          " & _codigoSeccao & "                    " & _custo & "               " & _nVagas
    End Function

    Public Sub New()
        MyBase.New()
    End Sub
    Public Sub New(ByVal Data As String, ByVal Hora As String,
                   ByVal Nvagas As String, ByVal Custo As String, ByVal CodSec As String)
        MyBase.New()
        Me.Data = Data
        Me.Hora = Hora
        Me.Nvagas = Nvagas
        Me.Custo = Custo
        Me.CodSec = CodSec

    End Sub


End Class
