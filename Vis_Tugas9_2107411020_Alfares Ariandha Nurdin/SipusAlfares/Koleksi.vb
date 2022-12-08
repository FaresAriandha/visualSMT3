Imports MySql.Data.MySqlClient

Public Class Koleksi
    Private koleksiDataTable As New ArrayList()
    Public Shared dbConn As New MySqlConnection
    Public Shared sqlCommand As New MySqlCommand
    Public Shared sqlRead As MySqlDataReader
    Private sqlQuery As String

    'Connection
    Private server As String = "localhost"
    Private username As String = "root"
    Private password As String = ""
    Private database As String = "perpustakaan"

    Public Sub New()
        dbConn.ConnectionString = "server = " + server + ";" + "user id = " _
                                  + username + ";" + "password = " + password + ";" _
                                  + "database = " + database
    End Sub

    Public Function GetDataKoleksiDatabase() As DataTable
        Dim result As New DataTable

        dbConn.Open()

        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = "SELECT id_koleksi As 'Id',
                                  nama_koleksi as 'Nama Koleksi',
                                  jenis_koleksi as 'Jenis Koleksi',
                                  penerbit as 'Penerbit',
                                  tahun_terbit as 'Tahun Terbit',
                                  DATE_FORMAT(tanggal_masuk_koleksi, '%Y/%m/%d') as 'Tanggal Masuk Koleksi',
                                  lokasi as 'Lokasi Koleksi',
                                  stock as 'Stok',
                                  bahasa as 'Bahasa'
                                  FROM koleksi"
        sqlRead = sqlCommand.ExecuteReader
        result.Load(sqlRead)
        sqlRead.Close()
        dbConn.Close()
        Return result
    End Function

    Public Function AddDataKoleksiDatabase(nama_koleksi As String,
                                           jenis_koleksi As String,
                                           deskripsi_koleksi As String,
                                           penerbit_koleksi As String,
                                           tahun_terbit As String,
                                           lokasi_rak As String,
                                           tanggal_masuk As Date,
                                           stock_koleksi As Integer,
                                           bahasa_koleksi As String,
                                           kategori_koleksi As String,
                                           dir_gambar As String)


        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "INSERT INTO koleksi VALUES('','" _
                & nama_koleksi & "', '" _
                & dir_gambar & "', '" _
                & deskripsi_koleksi & "', '" _
                & penerbit_koleksi & "', '" _
                & jenis_koleksi & "', '" _
                & tahun_terbit & "', '" _
                & lokasi_rak & "', '" _
                & tanggal_masuk.ToString("yyyy/MM/dd") & "', '" _
                & stock_koleksi & "', '" _
                & bahasa_koleksi & "', '" _
                & kategori_koleksi & "')"

            sqlCommand = New MySqlCommand(sqlQuery, dbConn)
            sqlRead = sqlCommand.ExecuteReader

            dbConn.Close()

            sqlRead.Close()
            dbConn.Close()

        Catch ex As Exception
            Return ex.Message
        Finally
            dbConn.Dispose()
        End Try
    End Function

    Public Function GetDataKoleksiByIDDatabase(ID As Integer) As List(Of String)
        Dim result As New List(Of String)

        dbConn.Open()

        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = "SELECT id_koleksi,
                                  nama_koleksi,
                                  dir_gambar,
                                  deskripsi,
                                  penerbit,
                                  jenis_koleksi,
                                  tahun_terbit,
                                  lokasi,
                                  DATE_FORMAT(tanggal_masuk_koleksi, '%Y/%m/%d'),
                                  stock,
                                  bahasa,
                                  kategori
                                  FROM koleksi
                                  WHERE id_koleksi='" & ID & "'"
        'sqlCommand.CommandText = "SELECT *
        '                          FROM koleksi
        '                          WHERE id_koleksi='" & ID & "'"
        sqlRead = sqlCommand.ExecuteReader


        While sqlRead.Read()
            result.Add(sqlRead.GetString(0).ToString())
            result.Add(sqlRead.GetString(1).ToString())
            result.Add(sqlRead.GetString(2).ToString())
            result.Add(sqlRead.GetString(3).ToString())
            result.Add(sqlRead.GetString(4).ToString())
            result.Add(sqlRead.GetString(5).ToString())
            result.Add(sqlRead.GetString(6).ToString())
            result.Add(sqlRead.GetString(7).ToString())
            result.Add(sqlRead.GetString(8).ToString())
            result.Add(sqlRead.GetString(9).ToString())
            result.Add(sqlRead.GetString(10).ToString())
            result.Add(sqlRead.GetString(11).ToString())
        End While

        sqlRead.Close()
        dbConn.Close()
        Return result
    End Function

    Public Function UpdateDataKoleksiByIDDatabase(ID As Integer,
                                           nama_koleksi As String,
                                           jenis_koleksi As String,
                                           deskripsi_koleksi As String,
                                           penerbit_koleksi As String,
                                           tahun_terbit As Integer,
                                           lokasi_rak As String,
                                           tanggal_masuk As String,
                                           stock_koleksi As Integer,
                                           bahasa_koleksi As String,
                                           kategori_koleksi As String,
                                           dir_gambar As String)
        tahun_terbit = tahun_terbit.ToString()

        'MsgBox(jenis_koleksi)
        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "UPDATE koleksi SET " &
                       "nama_koleksi='" & nama_koleksi & "', " &
                       "dir_gambar='" & dir_gambar & "', " &
                       "deskripsi='" & deskripsi_koleksi & "', " &
                       "penerbit='" & penerbit_koleksi & "', " &
                       "jenis_koleksi='" & jenis_koleksi & "', " &
                       "tahun_terbit='" & tahun_terbit & "', " &
                       "lokasi='" & lokasi_rak & "', " &
                       "tanggal_masuk_koleksi='" & tanggal_masuk & "', " &
                       "stock='" & stock_koleksi & "', " &
                       "bahasa='" & bahasa_koleksi & "', " &
                       "kategori='" & kategori_koleksi & "'" &
                       "WHERE id_koleksi ='" & ID & "'"


            sqlCommand = New MySqlCommand(sqlQuery, dbConn)
            sqlRead = sqlCommand.ExecuteReader

            dbConn.Close()
            sqlRead.Close()
            dbConn.Close()

            'dbConn.Open()
            'sqlCommand.Connection = dbConn
            'sqlQuery = "UPDATE koleksi SET " &
            '           "nama_koleksi='" & nama_koleksi & "', " &
            '           "dir_gambar='" & dir_gambar & "', " &
            '           "deskripsi='" & deskripsi_koleksi & "', " &
            '           "penerbit='" & penerbit_koleksi & "', " &
            '           "jenis_koleksi='" & jenis_koleksi & "', " &
            '           "tahun_terbit ='" & tahun_terbit & "', " &
            '           "lokasi='" & lokasi_rak & "', " &
            '           "tanggal_masuk_koleksi='" & tanggal_masuk & "', " &
            '           "stock='" & stock_koleksi & "', " &
            '           "bahasa='" & bahasa_koleksi & "', " &
            '           "kategori='" & kategori_koleksi & "'" &
            '           "WHERE id_koleksi ='" & ID & "'"

            'sqlCommand = New MySqlCommand(sqlQuery, dbConn)
            'sqlRead = sqlCommand.ExecuteReader
            'dbConn.Close()

            ''perpustakaan.sqlDt,Load(sqlRead)
            'sqlRead.Close()
            'dbConn.Close()

        Catch ex As Exception
            Return ex.Message
        Finally
            dbConn.Dispose()
        End Try
    End Function


    Public Function DeleteDataKoleksiByIDDatabase(ID As Integer)
        dbConn.ConnectionString = "server = " + server + ";" + "user id = " _
                                  + username + ";" + "password = " + password + ";" _
                                  + "database = " + database
        dbConn.Open()

        Try
            sqlCommand.Connection = dbConn
            sqlQuery = "DELETE FROM koleksi WHERE id_koleksi = '" & ID & "'"

            Debug.WriteLine(sqlQuery)

            sqlCommand = New MySqlCommand(sqlQuery, dbConn)
            sqlRead = sqlCommand.ExecuteReader

            dbConn.Close()

            sqlRead.Close()
            dbConn.Close()

        Catch ex As Exception
            Return ex.Message
        Finally
            dbConn.Dispose()
        End Try

    End Function
End Class
