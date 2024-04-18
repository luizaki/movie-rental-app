Imports MySql.Data.MySqlClient

Public Class Rentals
    Dim MysqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand

    ' Load rental statuses once opened
    Private Sub Rentals_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
            RentalView.DataSource = bSource
            SDA.Update(dbDataSet)

            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub SetToReturn_Click(sender As Object, e As EventArgs) Handles SetToReturn.Click
        MysqlConn = New MySqlConnection With {
            .ConnectionString = "server=localhost;userid=root;database=movie_rental"
        }

        Try
            MysqlConn.Open()

            ' Retrieve row and necessary details
            Dim row As DataGridViewRow = RentalView.Rows(RentalView.CurrentCell.RowIndex)
            Dim rental_id As String = row.Cells("rental_id").Value
            Dim returned As Int32 = row.Cells("returned").Value

            ' Set to return or unreturn depending on current
            Dim Query As String
            If returned = 0 Then
                Query = "UPDATE rental_status SET returned = 1, datereturned = '" & DateTime.Now.ToString("yyyy-MM-dd") & "' WHERE rental_id = '" & rental_id & "'"
                SetToReturn.Text = "Set to Not Returned"
            Else
                Query = "UPDATE rental_status SET returned = 0, datereturned = null WHERE rental_id = '" & rental_id & "'"
                SetToReturn.Text = "Set to Returned"
            End If

            COMMAND = New MySqlCommand(Query, MysqlConn)
            Dim READER = COMMAND.ExecuteReader()

            LoadRentalTable()

            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub RentalToHome_Click(sender As Object, e As EventArgs) Handles RentalToHome.Click
        Home.Show()
        Me.Hide()
    End Sub
End Class