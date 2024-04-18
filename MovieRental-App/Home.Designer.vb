<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Home
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Home))
        Button1 = New Button()
        BindingSource1 = New BindingSource(components)
        UpdateMovies = New Button()
        TrackRentals = New Button()
        NewRental = New Button()
        Label1 = New Label()
        ExitButton = New Button()
        CType(BindingSource1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(12, 502)
        Button1.Name = "Button1"
        Button1.Size = New Size(236, 60)
        Button1.TabIndex = 0
        Button1.Text = "Check DB Connection"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' UpdateMovies
        ' 
        UpdateMovies.Location = New Point(310, 193)
        UpdateMovies.Name = "UpdateMovies"
        UpdateMovies.Size = New Size(302, 44)
        UpdateMovies.TabIndex = 1
        UpdateMovies.Text = "Update Movie List"
        UpdateMovies.UseVisualStyleBackColor = True
        ' 
        ' TrackRentals
        ' 
        TrackRentals.Location = New Point(310, 253)
        TrackRentals.Name = "TrackRentals"
        TrackRentals.Size = New Size(302, 44)
        TrackRentals.TabIndex = 2
        TrackRentals.Text = "Track Rentals"
        TrackRentals.UseVisualStyleBackColor = True
        ' 
        ' NewRental
        ' 
        NewRental.Location = New Point(310, 314)
        NewRental.Name = "NewRental"
        NewRental.Size = New Size(302, 44)
        NewRental.TabIndex = 3
        NewRental.Text = "Add a New Rental"
        NewRental.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 30F)
        Label1.Location = New Point(156, 77)
        Label1.Name = "Label1"
        Label1.Size = New Size(633, 81)
        Label1.TabIndex = 4
        Label1.Text = "Movie Rental Manager"
        ' 
        ' ExitButton
        ' 
        ExitButton.Location = New Point(310, 424)
        ExitButton.Name = "ExitButton"
        ExitButton.Size = New Size(302, 34)
        ExitButton.TabIndex = 5
        ExitButton.Text = "Exit"
        ExitButton.UseVisualStyleBackColor = True
        ' 
        ' Home
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(933, 589)
        Controls.Add(ExitButton)
        Controls.Add(Label1)
        Controls.Add(NewRental)
        Controls.Add(TrackRentals)
        Controls.Add(UpdateMovies)
        Controls.Add(Button1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Home"
        Text = "Movie Rental Store"
        CType(BindingSource1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents UpdateMovies As Button
    Friend WithEvents TrackRentals As Button
    Friend WithEvents NewRental As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents ExitButton As Button

End Class
