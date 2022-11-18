Public Class fungsiApotek
    Private namaObat As String
    Private tipeKonsumsi As String
    Private tglMasuk As String
    Private tglKadaluarsa As String
    Private stok
    Private satuan As String
    Private hargaSatuan As String
    Private infoTambahan As New List(Of String)
    Private listObat As New List(Of String)
    Private fotoObat As String


    Public Property GSNamaObat() As String
        Get
            Return namaObat
        End Get
        Set(value As String)
            namaObat = value
        End Set
    End Property

    Public Property GSTipeKonsumsi() As String
        Get
            Return tipeKonsumsi
        End Get
        Set(value As String)
            tipeKonsumsi = value
        End Set
    End Property

    Public Property GSTglMasuk() As String
        Get
            Return tglMasuk
        End Get
        Set(value As String)
            tglMasuk = value
        End Set
    End Property

    Public Property GSTglKadaluarsa() As String
        Get
            Return tglKadaluarsa
        End Get
        Set(value As String)
            tglKadaluarsa = value
        End Set
    End Property


    Public Property GSStok() As String
        Get
            Return stok
        End Get
        Set(value As String)
            stok = value
        End Set
    End Property

    Public Property GSSatuan() As String
        Get
            Return satuan
        End Get
        Set(value As String)
            satuan = value
        End Set
    End Property

    Public Property GSHargaSatuan() As String
        Get
            Return hargaSatuan
        End Get
        Set(value As String)
            hargaSatuan = value
        End Set
    End Property

    Public Property GSFotoObat() As String
        Get
            Return fotoObat
        End Get
        Set(value As String)
            fotoObat = value
        End Set
    End Property

    Public Property GSInfoTambahan() As List(Of String)
        Get
            Return infoTambahan
        End Get
        Set(value As List(Of String))
            infoTambahan = value
        End Set
    End Property

    Public Property GSListObat() As List(Of String)
        Get
            Return listObat
        End Get
        Set(value As List(Of String))
            listObat = value
        End Set
    End Property

End Class
