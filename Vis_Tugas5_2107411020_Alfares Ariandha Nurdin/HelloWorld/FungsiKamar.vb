Public Class FungsiKamar

    Private jumlahKamar As Integer
    Private hariInap As Integer
    Private tarifInap As Integer = 10000


    Public Property GSTarifInap() As Integer
        Get
            Return tarifInap
        End Get
        Set(ByVal value As Integer)
            tarifInap = value
        End Set
    End Property

    Public Property SHariInap() As Integer
        Get
            Return hariInap
        End Get
        Set(ByVal value As Integer)
            hariInap = value
        End Set
    End Property

    Public Property GSJumlahKamar() As Integer
        Get
            Return jumlahKamar
        End Get
        Set(ByVal value As Integer)
            jumlahKamar = value
        End Set
    End Property

    Public Function HitungBiaya() As Integer
        Return hariInap * tarifInap
    End Function

    Public Function KurangiKamar(requestKamar As Integer) As Integer
        jumlahKamar = jumlahKamar - requestKamar
        Return jumlahKamar
    End Function


    Public Function TambahKamar(requestKamar As Integer) As Integer
        jumlahKamar = jumlahKamar + requestKamar
        Return jumlahKamar
    End Function



End Class
