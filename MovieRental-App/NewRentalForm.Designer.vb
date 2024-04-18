<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewRentalForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NewRentalForm))
        NewRentalView = New DataGridView()
        NewRentalToHome = New Button()
        Label1 = New Label()
        CustomerComboBox = New ComboBox()
        Label2 = New Label()
        MovieComboBox = New ComboBox()
        DateTimePicker = New DateTimePicker()
        Label3 = New Label()
        AddRental = New Button()
        CType(NewRentalView, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' NewRentalView
        ' 
        NewRentalView.AllowUserToAddRows = False
        NewRentalView.AllowUserToDeleteRows = False
        NewRentalView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        NewRentalView.Location = New Point(231, 12)
        NewRentalView.Name = "NewRentalView"
        NewRentalView.ReadOnly = True
        NewRentalView.RowHeadersWidth = 62
        NewRentalView.Size = New Size(690, 565)
        NewRentalView.TabIndex = 2
        ' 
        ' NewRentalToHome
        ' 
        NewRentalToHome.Font = New Font("Segoe UI", 12F)
        NewRentalToHome.Location = New Point(12, 517)
        NewRentalToHome.Name = "NewRentalToHome"
        NewRentalToHome.Size = New Size(195, 60)
        NewRentalToHome.TabIndex = 3
        NewRentalToHome.Text = "Back"
        NewRentalToHome.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 13F)
        Label1.Location = New Point(12, 12)
        Label1.Name = "Label1"
        Label1.Size = New Size(132, 36)
        Label1.TabIndex = 4
        Label1.Text = "Customer:"
        ' 
        ' CustomerComboBox
        ' 
        CustomerComboBox.FormattingEnabled = True
        CustomerComboBox.Location = New Point(12, 51)
        CustomerComboBox.Name = "CustomerComboBox"
        CustomerComboBox.Size = New Size(182, 33)
        CustomerComboBox.TabIndex = 5
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 13F)
        Label2.Location = New Point(12, 107)
        Label2.Name = "Label2"
        Label2.Size = New Size(184, 36)
        Label2.TabIndex = 6
        Label2.Text = "Movie To Rent:"
        ' 
        ' MovieComboBox
        ' 
        MovieComboBox.FormattingEnabled = True
        MovieComboBox.Location = New Point(12, 146)
        MovieComboBox.Name = "MovieComboBox"
        MovieComboBox.Size = New Size(182, 33)
        MovieComboBox.TabIndex = 7
        ' 
        ' DateTimePicker
        ' 
        DateTimePicker.Location = New Point(10, 248)
        DateTimePicker.Name = "DateTimePicker"
        DateTimePicker.Size = New Size(212, 31)
        DateTimePicker.TabIndex = 8
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 13F)
        Label3.Location = New Point(10, 209)
        Label3.Name = "Label3"
        Label3.Size = New Size(190, 36)
        Label3.TabIndex = 9
        Label3.Text = "Date to Return:"
        ' 
        ' AddRental
        ' 
        AddRental.Location = New Point(12, 305)
        AddRental.Name = "AddRental"
        AddRental.Size = New Size(195, 44)
        AddRental.TabIndex = 10
        AddRental.Text = "Add"
        AddRental.UseVisualStyleBackColor = True
        ' 
        ' NewRentalForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(933, 589)
        Controls.Add(AddRental)
        Controls.Add(Label3)
        Controls.Add(DateTimePicker)
        Controls.Add(MovieComboBox)
        Controls.Add(Label2)
        Controls.Add(CustomerComboBox)
        Controls.Add(Label1)
        Controls.Add(NewRentalToHome)
        Controls.Add(NewRentalView)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "NewRentalForm"
        Text = "Add New Rental"
        CType(NewRentalView, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents NewRentalView As DataGridView
    Friend WithEvents NewRentalToHome As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents CustomerComboBox As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents MovieComboBox As ComboBox
    Friend WithEvents DateTimePicker As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents AddRental As Button
End Class
