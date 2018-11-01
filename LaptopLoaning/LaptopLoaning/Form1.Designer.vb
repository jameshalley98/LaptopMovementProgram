<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.txtSerialNumber = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbLocation1 = New System.Windows.Forms.ComboBox()
        Me.cmbLocation2 = New System.Windows.Forms.ComboBox()
        Me.cmbLocation3 = New System.Windows.Forms.ComboBox()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.txtFileLocation = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtSerialNumber
        '
        Me.txtSerialNumber.Location = New System.Drawing.Point(108, 6)
        Me.txtSerialNumber.Name = "txtSerialNumber"
        Me.txtSerialNumber.Size = New System.Drawing.Size(202, 20)
        Me.txtSerialNumber.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Machine Name(s)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Location"
        '
        'cmbLocation1
        '
        Me.cmbLocation1.FormattingEnabled = True
        Me.cmbLocation1.Location = New System.Drawing.Point(108, 32)
        Me.cmbLocation1.Name = "cmbLocation1"
        Me.cmbLocation1.Size = New System.Drawing.Size(202, 21)
        Me.cmbLocation1.TabIndex = 4
        '
        'cmbLocation2
        '
        Me.cmbLocation2.FormattingEnabled = True
        Me.cmbLocation2.Location = New System.Drawing.Point(108, 60)
        Me.cmbLocation2.Name = "cmbLocation2"
        Me.cmbLocation2.Size = New System.Drawing.Size(202, 21)
        Me.cmbLocation2.TabIndex = 5
        Me.cmbLocation2.Visible = False
        '
        'cmbLocation3
        '
        Me.cmbLocation3.FormattingEnabled = True
        Me.cmbLocation3.Location = New System.Drawing.Point(108, 87)
        Me.cmbLocation3.Name = "cmbLocation3"
        Me.cmbLocation3.Size = New System.Drawing.Size(202, 21)
        Me.cmbLocation3.TabIndex = 7
        Me.cmbLocation3.Visible = False
        '
        'btnConfirm
        '
        Me.btnConfirm.Enabled = False
        Me.btnConfirm.Location = New System.Drawing.Point(235, 114)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(75, 20)
        Me.btnConfirm.TabIndex = 9
        Me.btnConfirm.Text = "Confirm"
        Me.btnConfirm.UseVisualStyleBackColor = True
        '
        'txtFileLocation
        '
        Me.txtFileLocation.Location = New System.Drawing.Point(108, 114)
        Me.txtFileLocation.Name = "txtFileLocation"
        Me.txtFileLocation.Size = New System.Drawing.Size(120, 20)
        Me.txtFileLocation.TabIndex = 10
        Me.txtFileLocation.Text = "C:\Where Laptop Go\WhereWent.txt"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 118)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "File to use"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(324, 142)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtFileLocation)
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.cmbLocation3)
        Me.Controls.Add(Me.cmbLocation2)
        Me.Controls.Add(Me.cmbLocation1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtSerialNumber)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Where laptop go?"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtSerialNumber As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbLocation1 As ComboBox
    Friend WithEvents cmbLocation2 As ComboBox
    Friend WithEvents cmbLocation3 As ComboBox
    Friend WithEvents btnConfirm As Button
    Friend WithEvents txtFileLocation As TextBox
    Friend WithEvents Label3 As Label
End Class
