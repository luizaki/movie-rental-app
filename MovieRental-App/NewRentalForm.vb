Imports MySql.Data.MySqlClient

Public Class NewRentalForm
    Dim MysqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Private Sub NewRentalForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadRentalTable()
    End Sub

    Private Sub LoadRentalTable()
        MysqlConn = New MySqlConnection With {
            .ConnectionString = "server=localhost;userid=root;database=movie_rental;Convert Zero Datetime=True"
        }

        Dim SDA As New MySqlDataAdapter
        Dim dbDataSet As New DataTable
        Dim bSource As New BindingSource

        Try
            MysqlConn.Open()

            Dim Query As String
            Query = "SELECT r.rental_id, CONCAT(firstname, ' ', lastname) AS name, title, datarented, returned, datereturned, amountdue FROM rental r LEFT JOIN rental_detail rd ON r.rental_id = rd.rental_id LEFT JOIN rental_status rs ON r.rental_id = rs.rental_id LEFT JOIN customer c on c.customer_id = r.customer_id LEFT JOIN movie m ON m.movie_id = rd.movie_id"

            COMMAND = New MySqlCommand(Query, MysqlConn)
            SDA.SelectCommand = COMMAND
            SDA.Fill(dbDataSet)
            bSource.DataSource = dbDataSet
            NewRentalView.DataSource = bSource
            SDA.Update(dbDataSet)

            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub CustomerComboBox_Click(sender As Object, e As EventArgs) Handles CustomerComboBox.Click
        MysqlConn = New MySqlConnection With {
            .ConnectionString = "server=localhost;userid=root;database=movie_rental"
        }

        Dim READER As MySqlDataReader

        Try
            MysqlConn.Open()

            ' Reset Combobox
            CustomerComboBox.Items.Clear()

            Dim Query As String
            Query = "SELECT * FROM customer"
            COMMAND = New MySqlCommand(Query, MysqlConn)
            READER = COMMAND.ExecuteReader
            While READER.Read
                Dim name = READER.GetString("firstname") + " " + READER.GetString("lastname")
                CustomerComboBox.Items.Add(name)
            End While

            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub MovieComboBox_Click(sender As Object, e As EventArgs) Handles MovieComboBox.Click
        MysqlConn = New MySqlConnection With {
            .ConnectionString = "server=localhost;userid=root;database=movie_rental"
        }

        Dim READER As MySqlDataReader

        Try
            MysqlConn.Open()

            ' Reset Combobox
            MovieComboBox.Items.Clear()

            ' Only select movies not current being rented
            Dim Query As String
            Query = "SELECT * FROM movie WHERE movie_id NOT IN (SELECT movie_id FROM rental_detail)"
            COMMAND = New MySqlCommand(Query, MysqlConn)
            READER = COMMAND.ExecuteReader()
            While READER.Read
                Dim movie = READER.GetString("title")
                MovieComboBox.Items.Add(movie)
            End While

            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub AddRental_Click(sender As Object, e As EventArgs) Handles AddRental.Click
        MysqlConn = New MySqlConnection With {
            .ConnectionString = "server=localhost;userid=root;database=movie_rental;Convert Zero Datetime=True"
        }

        Dim READER As MySqlDataReader

        Try
            MysqlConn.Open()

            ' Retrieve latest RentalID
            Dim LatestRentalID As String
            Dim LatestRentalIDQuery As String = "SELECT rental_id FROM rental ORDER BY rental_id DESC LIMIT 1"
            COMMAND = New MySqlCommand(LatestRentalIDQuery, MysqlConn)
            LatestRentalID = Convert.ToInt32(COMMAND.ExecuteScalar())

            ' Generate new Rental ID from latest RentalID
            Dim RentalID As String
            RentalID = (LatestRentalID + 1).ToString("00000")

            ' Retrieve CustomerID
            Dim CustomerID As String
            COMMAND = New MySqlCommand("SELECT customer_id FROM customer WHERE CONCAT(firstname, ' ', lastname) LIKE '" & CustomerComboBox.Text & "'", MysqlConn)
            CustomerID = COMMAND.ExecuteScalar()

            ' Retrieve MovieID
            Dim MovieID As String
            COMMAND = New MySqlCommand("SELECT movie_id FROM movie WHERE title LIKE '" & MovieComboBox.Text & "'", MysqlConn)
            MovieID = COMMAND.ExecuteScalar()

            ' Retrieve AmountDue
            Dim AmountDue As Decimal
            COMMAND = New MySqlCommand("SELECT rentalrate FROM movie WHERE movie_id = '" & MovieID & "'", MysqlConn)
            AmountDue = Convert.ToDecimal(COMMAND.ExecuteScalar())

            ' Insert Rental Fields
            Dim RentalQuery As String = "INSERT INTO rental VALUES('" & RentalID & "', '" & CustomerID & "', '" & DateTime.Now.ToString("yyyy-MM-dd") & "', '" & DateTimePicker.Value.ToString("yyyy-MM-dd") & "')"
            COMMAND = New MySqlCommand(RentalQuery, MysqlConn)
            READER = COMMAND.ExecuteReader()
            READER.Close()

            ' Insert Rental Status Fields
            Dim RentalStatusQuery As String = "INSERT INTO rental_status VALUES('" & RentalID & "', 0, null)"
            COMMAND = New MySqlCommand(RentalStatusQuery, MysqlConn)
            READER = COMMAND.ExecuteReader()
            READER.Close()

            ' Insert Rental Details Fields
            Dim RentalDetailQuery As String = "INSERT INTO rental_detail VALUES('" & RentalID & "', '" & MovieID & "', '" & AmountDue & "')"
            COMMAND = New MySqlCommand(RentalDetailQuery, MysqlConn)
            READER = COMMAND.ExecuteReader()
            READER.Close()

            ' Confimation Message
            MessageBox.Show("Successfully added!")

            LoadRentalTable()

            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub NewRentalToHome_Click(sender As Object, e As EventArgs) Handles NewRentalToHome.Click
        Home.Show()
        Me.Close()
    End Sub
End Class