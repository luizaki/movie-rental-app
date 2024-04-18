<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MovieManagement
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MovieManagement))
        MovieView = New DataGridView()
        MovieToHome = New Button()
        AddMovie = New Button()
        EditMovie = New Button()
        DeleteMovie = New Button()
        MenuStrip1 = New MenuStrip()
        CType(MovieView, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MovieView
        ' 
        MovieView.AllowUserToAddRows = False
        MovieView.AllowUserToDeleteRows = False
        MovieView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        MovieView.Location = New Point(12, 12)
        MovieView.Name = "MovieView"
        MovieView.ReadOnly = True
        MovieView.RowHeadersWidth = 62
        MovieView.Size = New Size(690, 565)
        MovieView.TabIndex = 0
        ' 
        ' MovieToHome
        ' 
        MovieToHome.Font = New Font("Segoe UI", 12F)
        MovieToHome.Location = New Point(726, 517)
        MovieToHome.Name = "MovieToHome"
        MovieToHome.Size = New Size(195, 60)
        MovieToHome.TabIndex = 1
        MovieToHome.Text = "Back"
        MovieToHome.UseVisualStyleBackColor = True
        ' 
        ' AddMovie
        ' 
        AddMovie.Location = New Point(726, 12)
        AddMovie.Name = "AddMovie"
        AddMovie.Size = New Size(195, 44)
        AddMovie.TabIndex = 2
        AddMovie.Text = "Add"
        AddMovie.UseVisualStyleBackColor = True
        ' 
        ' EditMovie
        ' 
        EditMovie.Location = New Point(726, 70)
        EditMovie.Name = "EditMovie"
        EditMovie.Size = New Size(195, 44)
        EditMovie.TabIndex = 3
        EditMovie.Text = "Edit"
        EditMovie.UseVisualStyleBackColor = True
        ' 
        ' DeleteMovie
        ' 
        DeleteMovie.Location = New Point(726, 130)
        DeleteMovie.Name = "DeleteMovie"
        DeleteMovie.Size = New Size(195, 44)
        DeleteMovie.TabIndex = 4
        DeleteMovie.Text = "Delete"
        DeleteMovie.UseVisualStyleBackColor = True
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(24, 24)
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(933, 24)
        MenuStrip1.TabIndex = 5
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' MovieManagement
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        ClientSize = New Size(933, 589)
        Controls.Add(DeleteMovie)
        Controls.Add(EditMovie)
        Controls.Add(AddMovie)
        Controls.Add(MovieToHome)
        Controls.Add(MovieView)
        Controls.Add(MenuStrip1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MainMenuStrip = MenuStrip1
        Name = "MovieManagement"
        Text = "Movies"
        CType(MovieView, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MovieView As DataGridView
    Friend WithEvents MovieToHome As Button
    Friend WithEvents AddMovie As Button
    Friend WithEvents EditMovie As Button
    Friend WithEvents DeleteMovie As Button
    Friend WithEvents MenuStrip1 As MenuStrip
End Class
