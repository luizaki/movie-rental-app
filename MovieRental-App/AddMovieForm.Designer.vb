<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddMovieForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddMovieForm))
        Label1 = New Label()
        Label2 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label3 = New Label()
        Label6 = New Label()
        AddNewMovie = New Button()
        MovieNameTextBox = New TextBox()
        DirectorTextBox = New TextBox()
        YearTextBox = New TextBox()
        DurationTextBox = New TextBox()
        RateTextBox = New TextBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(32, 42)
        Label1.Name = "Label1"
        Label1.Size = New Size(113, 25)
        Label1.TabIndex = 0
        Label1.Text = "Movie Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(71, 78)
        Label2.Name = "Label2"
        Label2.Size = New Size(75, 25)
        Label2.TabIndex = 1
        Label2.Text = "Director"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(119, 164)
        Label4.Name = "Label4"
        Label4.Size = New Size(17, 25)
        Label4.TabIndex = 3
        Label4.Text = " "
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(17, 117)
        Label5.Name = "Label5"
        Label5.Size = New Size(129, 25)
        Label5.TabIndex = 4
        Label5.Text = "Year of Release"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(64, 154)
        Label3.Name = "Label3"
        Label3.Size = New Size(81, 25)
        Label3.TabIndex = 5
        Label3.Text = "Duration"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(45, 192)
        Label6.Name = "Label6"
        Label6.Size = New Size(100, 25)
        Label6.TabIndex = 6
        Label6.Text = "Rental Rate"
        ' 
        ' AddNewMovie
        ' 
        AddNewMovie.Location = New Point(23, 239)
        AddNewMovie.Name = "AddNewMovie"
        AddNewMovie.Size = New Size(284, 71)
        AddNewMovie.TabIndex = 7
        AddNewMovie.Text = "Add"
        AddNewMovie.UseVisualStyleBackColor = True
        ' 
        ' MovieNameTextBox
        ' 
        MovieNameTextBox.Location = New Point(142, 35)
        MovieNameTextBox.Name = "MovieNameTextBox"
        MovieNameTextBox.Size = New Size(165, 31)
        MovieNameTextBox.TabIndex = 8
        ' 
        ' DirectorTextBox
        ' 
        DirectorTextBox.Location = New Point(142, 72)
        DirectorTextBox.Name = "DirectorTextBox"
        DirectorTextBox.Size = New Size(165, 31)
        DirectorTextBox.TabIndex = 9
        ' 
        ' YearTextBox
        ' 
        YearTextBox.Location = New Point(142, 112)
        YearTextBox.Name = "YearTextBox"
        YearTextBox.Size = New Size(165, 31)
        YearTextBox.TabIndex = 10
        ' 
        ' DurationTextBox
        ' 
        DurationTextBox.Location = New Point(142, 151)
        DurationTextBox.Name = "DurationTextBox"
        DurationTextBox.Size = New Size(165, 31)
        DurationTextBox.TabIndex = 11
        ' 
        ' RateTextBox
        ' 
        RateTextBox.Location = New Point(142, 189)
        RateTextBox.Name = "RateTextBox"
        RateTextBox.Size = New Size(165, 31)
        RateTextBox.TabIndex = 12
        ' 
        ' AddMovieForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(338, 338)
        Controls.Add(RateTextBox)
        Controls.Add(DurationTextBox)
        Controls.Add(YearTextBox)
        Controls.Add(DirectorTextBox)
        Controls.Add(MovieNameTextBox)
        Controls.Add(AddNewMovie)
        Controls.Add(Label6)
        Controls.Add(Label3)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "AddMovieForm"
        Text = "Add New Movie"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents AddNewMovie As Button
    Friend WithEvents MovieNameTextBox As TextBox
    Friend WithEvents DirectorTextBox As TextBox
    Friend WithEvents YearTextBox As TextBox
    Friend WithEvents DurationTextBox As TextBox
    Friend WithEvents RateTextBox As TextBox
End Class
