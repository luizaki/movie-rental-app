Imports MySql.Data.MySqlClient

Public Class MovieManagement
    Dim MysqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand

    ' Load table when Form loads
    Private Sub MovieManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadMovieTable()
        AddHandler AddMovieForm.FormClosed, AddressOf AddNewMovie_Closed
        AddHandler UpdateMovieForm.FormClosed, AddressOf UpdateMovie_Closed
    End Sub

    Private Sub AddNewMovie_Closed(sender As Object, e As FormClosedEventArgs)
        LoadMovieTable()
    End Sub

    Private Sub UpdateMovie_Closed(sender As Object, e As FormClosedEventArgs)
        LoadMovieTable()
    End Sub

    '  Method to load movie during other processes.
    Private Sub LoadMovieTable()
        MysqlConn = New MySqlConnection With {
            .ConnectionString = "server=localhost;userid=root;database=movie_rental"
        }

        Dim SDA As New MySqlDataAdapter
        Dim dbDataSet As New DataTable
        Dim bSource As New BindingSource

        Try
            MysqlConn.Open()

            Dim Query As String
            Query = "SELECT * FROM movie_rental.movie"

            COMMAND = New MySqlCommand(Query, MysqlConn)
            SDA.SelectCommand = COMMAND
            SDA.Fill(dbDataSet)
            bSource.DataSource = dbDataSet
            MovieView.DataSource = bSource
            SDA.Update(dbDataSet)

            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    ' Moves the app back to Home
    Private Sub MovieToHome_Click(sender As Object, e As EventArgs) Handles MovieToHome.Click
        MysqlConn = New MySqlConnection With {
            .ConnectionString = "server=localhost;userid=root;database=movie_rental"
        }

        Try
            MysqlConn.Open()

            ' Open Home Form and close current one
            Home.Show()
            Me.Hide()

            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub AddMovie_Click(sender As Object, e As EventArgs) Handles AddMovie.Click
        AddMovieForm.Show()
    End Sub

    Private Sub EditMovie_Click(sender As Object, e As EventArgs) Handles EditMovie.Click
        ' Check if a single row has been selected
        If MovieView.SelectedRows.Count > 1 Then
            MessageBox.Show("Please select one row to update at a time !!!")
        Else
            UpdateMovieForm.Show()
        End If
    End Sub

    ' Delete selected row
    Private Sub DeleteMovie_Click(sender As Object, e As EventArgs) Handles DeleteMovie.Click
        MysqlConn = New MySqlConnection With {
            .ConnectionString = "server=localhost;userid=root;database=movie_rental"
        }

        Try
            MysqlConn.Open()

            ' Check if a single row has been selected
            If MovieView.SelectedRows.Count > 1 Then
                MessageBox.Show("Please select one row to delete at a time !!!")
            Else
                ' Retrieve row
                Dim row As DataGridViewRow = MovieView.Rows(MovieView.CurrentCell.RowIndex)
                Dim movie_id As String = row.Cells("movie_id").Value
                Dim title As String = row.Cells("title").Value

                ' Confirmation message to delete
                Dim response As DialogResult
                response = MessageBox.Show("Are you sure you want to delete '" & title & "'?", "", MessageBoxButtons.YesNo)
                If response = DialogResult.Yes Then
                    Dim Query As String
                    Query = "DELETE FROM movie WHERE movie_id = '" & movie_id & "'"

                    COMMAND = New MySqlCommand(Query, MysqlConn)
                    Dim READER As MySqlDataReader = COMMAND.ExecuteReader()

                    MessageBox.Show("'" & title & "' has been deleted.")
                End If
            End If

            LoadMovieTable()

            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
End Class