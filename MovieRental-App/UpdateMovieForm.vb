Imports MySql.Data.MySqlClient

Public Class UpdateMovieForm
    Dim MysqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand

    Private Sub UpdateMovieForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Retrieve row
        Dim row As DataGridViewRow = MovieManagement.MovieView.Rows(MovieManagement.MovieView.CurrentCell.RowIndex)

        ' Setting rows to text boxes
        MovieNameTextBox.Text = row.Cells("title").Value
        DirectorTextBox.Text = row.Cells("director").Value
        YearTextBox.Text = row.Cells("release_year").Value.ToString
        DurationTextBox.Text = row.Cells("duration").Value.ToString
        RateTextBox.Text = row.Cells("rentalrate").Value.ToString
    End Sub
    Private Sub UpdateMovie_Click(sender As Object, e As EventArgs) Handles UpdateMovie.Click
        MysqlConn = New MySqlConnection With {
            .ConnectionString = "server=localhost;userid=root;database=movie_rental"
        }

        Try
            MysqlConn.Open()

            ' Check for required values
            If MovieNameTextBox.Text = "" Or DurationTextBox.Text = "" Or RateTextBox.Text = "" Then
                MessageBox.Show("Please fill in at least movie name, duration, and rental rate!")
            Else
                ' Retrieve movie_id
                Dim row As DataGridViewRow = MovieManagement.MovieView.Rows(MovieManagement.MovieView.CurrentCell.RowIndex)
                Dim movie_id = row.Cells("movie_id").Value

                ' Update table with current values in textboxes
                Dim Query As String = "UPDATE movie SET title = '" & MovieNameTextBox.Text & "', director = '" & DirectorTextBox.Text & "', release_year = '" & YearTextBox.Text & "', duration = '" & DurationTextBox.Text & "', rentalrate = '" & RateTextBox.Text & "' WHERE movie_id = '" & movie_id & "'"
                COMMAND = New MySqlCommand(Query, MysqlConn)
                Dim READER As MySqlDataReader = COMMAND.ExecuteReader()

                ' Confirmation Message
                MessageBox.Show("Record has been successfully updated!")
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