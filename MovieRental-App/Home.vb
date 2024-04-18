Imports MySql.Data.MySqlClient

Public Class Home
    Dim MysqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand

    ' End the application
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    ' Test the current connection to the DB
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MysqlConn = New MySqlConnection With {
            .ConnectionString = "server=localhost;userid=root;database=movie_rental"
        }

        Try
            MysqlConn.Open()
            MessageBox.Show("Connection Successful")
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    ' Moves the app to the MovieManagement Form
    Private Sub UpdateMovies_Click(sender As Object, e As EventArgs) Handles UpdateMovies.Click
        MysqlConn = New MySqlConnection With {
            .ConnectionString = "server=localhost;userid=root;database=movie_rental"
        }

        Try
            MysqlConn.Open()

            ' Opens the new Form and hides the current one
            MovieManagement.Show()
            Me.Hide()

            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub TrackRentals_Click(sender As Object, e As EventArgs) Handles TrackRentals.Click
        Rentals.Show()
        Me.Hide()
    End Sub

    Private Sub NewRental_Click(sender As Object, e As EventArgs) Handles NewRental.Click
        NewRentalForm.Show()
        Me.Hide()
    End Sub
End Class
