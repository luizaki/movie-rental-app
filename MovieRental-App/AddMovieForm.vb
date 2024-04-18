Imports MySql.Data.MySqlClient

Public Class AddMovieForm
    Dim MysqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand

    Private Sub AddNewMovie_Click(sender As Object, e As EventArgs) Handles AddNewMovie.Click
        MysqlConn = New MySqlConnection With {
            .ConnectionString = "server=localhost;userid=root;database=movie_rental"
        }

        Dim READER As MySqlDataReader

        Try
            MysqlConn.Open()

            ' Checking for required values
            If MovieNameTextBox.Text = "" Or DurationTextBox.Text = "" Or RateTextBox.Text = "" Then
                MessageBox.Show("Please fill in at least movie name, duration, and rental rate!")
            Else
                ' Retrieve latest MovieID
                Dim LatestMovieID As String
                Dim LatestMovieIDQuery As String = "SELECT movie_id FROM movie ORDER BY movie_id DESC LIMIT 1"
                COMMAND = New MySqlCommand(LatestMovieIDQuery, MysqlConn)
                LatestMovieID = Convert.ToInt32(COMMAND.ExecuteScalar())

                ' Generate new Movie ID from latest MovieID
                Dim MovieID As String
                MovieID = (LatestMovieID + 1).ToString("00000")

                ' Inserting new movie to the table
                Dim InsertQuery As String = "INSERT INTO movie VALUES('" & MovieID & "', '" & MovieNameTextBox.Text & "', '" & DirectorTextBox.Text & "', '" & YearTextBox.Text & "', '" & DurationTextBox.Text & "', '" & RateTextBox.Text & "')"
                COMMAND = New MySqlCommand(InsertQuery, MysqlConn)
                READER = COMMAND.ExecuteReader()

                ' Confirmation Message
                MessageBox.Show("Successfully added!")
            End If

            MysqlConn.Close()
            Me.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
End Class