<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Rentals
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Rentals))
        RentalView = New DataGridView()
        RentalToHome = New Button()
        SetToReturn = New Button()
        CType(RentalView, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' RentalView
        ' 
        RentalView.AllowUserToAddRows = False
        RentalView.AllowUserToDeleteRows = False
        RentalView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        RentalView.Location = New Point(12, 12)
        RentalView.Name = "RentalView"
        RentalView.ReadOnly = True
        RentalView.RowHeadersWidth = 62
        RentalView.Size = New Size(690, 565)
        RentalView.TabIndex = 1
        ' 
        ' RentalToHome
        ' 
        RentalToHome.Font = New Font("Segoe UI", 12F)
        RentalToHome.Location = New Point(726, 517)
        RentalToHome.Name = "RentalToHome"
        RentalToHome.Size = New Size(195, 60)
        RentalToHome.TabIndex = 2
        RentalToHome.Text = "Back"
        RentalToHome.UseVisualStyleBackColor = True
        ' 
        ' SetToReturn
        ' 
        SetToReturn.Location = New Point(726, 12)
        SetToReturn.Name = "SetToReturn"
        SetToReturn.Size = New Size(195, 44)
        SetToReturn.TabIndex = 7
        SetToReturn.Text = "Set As Returned"
        SetToReturn.UseVisualStyleBackColor = True
        ' 
        ' Rentals
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(933, 589)
        Controls.Add(SetToReturn)
        Controls.Add(RentalToHome)
        Controls.Add(RentalView)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Rentals"
        Text = "Current Rentals"
        CType(RentalView, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents RentalView As DataGridView
    Friend WithEvents RentalToHome As Button
    Friend WithEvents SetToReturn As Button
End Class
