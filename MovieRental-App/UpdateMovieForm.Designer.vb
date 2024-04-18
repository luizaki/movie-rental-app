<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateMovieForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UpdateMovieForm))
        RateTextBox = New TextBox()
        DurationTextBox = New TextBox()
        YearTextBox = New TextBox()
        DirectorTextBox = New TextBox()
        MovieNameTextBox = New TextBox()
        UpdateMovie = New Button()
        Label6 = New Label()
        Label3 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' RateTextBox
        ' 
        RateTextBox.Location = New Point(149, 186)
        RateTextBox.Name = "RateTextBox"
        RateTextBox.Size = New Size(165, 31)
        RateTextBox.TabIndex = 24
        ' 
        ' DurationTextBox
        ' 
        DurationTextBox.Location = New Point(149, 148)
        DurationTextBox.Name = "DurationTextBox"
        DurationTextBox.Size = New Size(165, 31)
        DurationTextBox.TabIndex = 23
        ' 
        ' YearTextBox
        ' 
        YearTextBox.Location = New Point(149, 109)
        YearTextBox.Name = "YearTextBox"
        YearTextBox.Size = New Size(165, 31)
        YearTextBox.TabIndex = 22
        ' 
        ' DirectorTextBox
        ' 
        DirectorTextBox.Location = New Point(149, 69)
        DirectorTextBox.Name = "DirectorTextBox"
        DirectorTextBox.Size = New Size(165, 31)
        DirectorTextBox.TabIndex = 21
        ' 
        ' MovieNameTextBox
        ' 
        MovieNameTextBox.Location = New Point(149, 32)
        MovieNameTextBox.Name = "MovieNameTextBox"
        MovieNameTextBox.Size = New Size(165, 31)
        MovieNameTextBox.TabIndex = 20
        ' 
        ' UpdateMovie
        ' 
        UpdateMovie.Location = New Point(30, 236)
        UpdateMovie.Name = "UpdateMovie"
        UpdateMovie.Size = New Size(284, 71)
        UpdateMovie.TabIndex = 19
        UpdateMovie.Text = "Update"
        UpdateMovie.UseVisualStyleBackColor = True
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(52, 189)
        Label6.Name = "Label6"
        Label6.Size = New Size(100, 25)
        Label6.TabIndex = 18
        Label6.Text = "Rental Rate"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(71, 151)
        Label3.Name = "Label3"
        Label3.Size = New Size(81, 25)
        Label3.TabIndex = 17
        Label3.Text = "Duration"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(24, 114)
        Label5.Name = "Label5"
        Label5.Size = New Size(129, 25)
        Label5.TabIndex = 16
        Label5.Text = "Year of Release"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(126, 161)
        Label4.Name = "Label4"
        Label4.Size = New Size(17, 25)
        Label4.TabIndex = 15
        Label4.Text = " "
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(78, 75)
        Label2.Name = "Label2"
        Label2.Size = New Size(75, 25)
        Label2.TabIndex = 14
        Label2.Text = "Director"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(39, 39)
        Label1.Name = "Label1"
        Label1.Size = New Size(113, 25)
        Label1.TabIndex = 13
        Label1.Text = "Movie Name"
        ' 
        ' UpdateMovieForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(338, 338)
        Controls.Add(RateTextBox)
        Controls.Add(DurationTextBox)
        Controls.Add(YearTextBox)
        Controls.Add(DirectorTextBox)
        Controls.Add(MovieNameTextBox)
        Controls.Add(UpdateMovie)
        Controls.Add(Label6)
        Controls.Add(Label3)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "UpdateMovieForm"
        Text = "Update Movie Record"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents RateTextBox As TextBox
    Friend WithEvents DurationTextBox As TextBox
    Friend WithEvents YearTextBox As TextBox
    Friend WithEvents DirectorTextBox As TextBox
    Friend WithEvents MovieNameTextBox As TextBox
    Friend WithEvents UpdateMovie As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
