Imports System.Text

Public Class DataPerpus
    Private namaKoleksi
    Private jenisKoleksi
    Private deskripsi
    Private penerbit
    Private tahunTerbit
    Private rakBuku
    Private tglMasuk
    Private stok
    Private bahasa
    Private infoKategori As New List(Of String)
    Private listKoleksi As New List(Of String)
    Private fotoKoleksi
    Private koleksiDataTable As New ArrayList()

    Public Property GSnamaKoleksi() As String
        Get
            Return namaKoleksi
        End Get
        Set(ByVal value As String)
            namaKoleksi = value
        End Set
    End Property

    Public Property GSjenisKoleksi() As Object
        Get
            Return jenisKoleksi
        End Get
        Set(ByVal value As Object)
            jenisKoleksi = value
        End Set
    End Property

    Public Property GSdeskripsiKoleksi() As String
        Get
            Return deskripsi
        End Get
        Set(ByVal value As String)
            deskripsi = value
        End Set
    End Property

    Public Property GSpenerbit() As String
        Get
            Return penerbit
        End Get
        Set(ByVal value As String)
            penerbit = value
        End Set
    End Property

    Public Property GStahun() As String
        Get
            Return tahunTerbit
        End Get
        Set(ByVal value As String)
            tahunTerbit = value
        End Set
    End Property

    Public Property GSrakBuku() As String
        Get
            Return rakBuku
        End Get
        Set(ByVal value As String)
            rakBuku = value
        End Set
    End Property


    Public Property GStglMasuk() As String
        Get
            Return tglMasuk
        End Get
        Set(ByVal value As String)
            tglMasuk = value
        End Set
    End Property


    Public Property GSstok() As String
        Get
            Return stok
        End Get
        Set(ByVal value As String)
            stok = value
        End Set
    End Property

    Public Property GSbahasa() As String
        Get
            Return bahasa
        End Get
        Set(ByVal value As String)
            bahasa = value
        End Set
    End Property

    Public ReadOnly Property GSinfoKategori() As List(Of String)
        Get
            Return infoKategori
        End Get
    End Property

    Public ReadOnly Property GSlistKoleksi() As List(Of String)
        Get
            Return listKoleksi
        End Get
    End Property

    Public Property GSfoto() As String
        Get
            Return fotoKoleksi
        End Get
        Set(ByVal value As String)
            fotoKoleksi = value
        End Set
    End Property


    'List Function
    Public Function addKategori(value As String)
        infoKategori.Add(value)
        Return ""
    End Function

    Public Function resetKategori()
        infoKategori.Clear()
        Return ""
    End Function

    Public Function AddKoleksi(value As String)
        listKoleksi.Add(value)
        Return ""
    End Function

    Public Function RemoveKoleksi(value As String)
        listKoleksi.Remove(value)
        Return ""
    End Function


    'List Function for Tugas Pertemuan 10

    Public Function AddKoleksiData(nmKoleksi As String,
                                   jnsKoleksi As String,
                                   desc As String,
                                   penerbit As String,
                                   thnTerbit As Integer,
                                   rak As String,
                                   tglMsk As String,
                                   stk As Integer,
                                   language As String,
                                   kategori As String,
                                   foto As String)

        koleksiDataTable.Add({nmKoleksi,
                             jnsKoleksi,
                             desc,
                             penerbit,
                             thnTerbit,
                             rak,
                             tglMsk,
                             stk,
                             language,
                             kategori,
                             foto})
        Return ""
    End Function

    Public Function RemoveKoleksiDataTable(index As Integer)
        koleksiDataTable.RemoveAt(index)
        Return ""
    End Function

    Public ReadOnly Property getKoleksiDataTable() As ArrayList
        Get
            Return koleksiDataTable
        End Get
    End Property

    Public Function ConvertKoleksiToString(vals As List(Of String))
        Dim builder As StringBuilder = New StringBuilder()
        For Each val As String In vals
            builder.Append(val).Append("|")
        Next

        'Convert String 
        Dim res = builder.ToString()
        Return res
    End Function

    Public Function ConvertStringToKoleksi(value As String)
        Dim arr() As String = value.Split("|")

        'Convert to List
        Dim vals As List(Of String) = arr.ToList()
        Return vals
    End Function
End Class
