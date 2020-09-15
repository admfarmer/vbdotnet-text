<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmmain
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblSalarywithbonus = New System.Windows.Forms.Label()
        Me.lblsalary = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btncal = New System.Windows.Forms.Button()
        Me.txtbonus = New System.Windows.Forms.TextBox()
        Me.txtsalary = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.chksso = New System.Windows.Forms.CheckBox()
        Me.txtsso = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.txtsso)
        Me.Panel1.Controls.Add(Me.chksso)
        Me.Panel1.Controls.Add(Me.btnExit)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.lblSalarywithbonus)
        Me.Panel1.Controls.Add(Me.lblsalary)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.btncal)
        Me.Panel1.Controls.Add(Me.txtbonus)
        Me.Panel1.Controls.Add(Me.txtsalary)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(23, 21)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(366, 365)
        Me.Panel1.TabIndex = 0
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(220, 260)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(91, 38)
        Me.btnExit.TabIndex = 12
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(285, 221)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(26, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "บาท"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(285, 191)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(26, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "บาท"
        '
        'lblSalarywithbonus
        '
        Me.lblSalarywithbonus.AutoSize = True
        Me.lblSalarywithbonus.BackColor = System.Drawing.Color.Crimson
        Me.lblSalarywithbonus.Location = New System.Drawing.Point(141, 221)
        Me.lblSalarywithbonus.Name = "lblSalarywithbonus"
        Me.lblSalarywithbonus.Size = New System.Drawing.Size(10, 13)
        Me.lblSalarywithbonus.TabIndex = 9
        Me.lblSalarywithbonus.Text = "-"
        '
        'lblsalary
        '
        Me.lblsalary.AutoSize = True
        Me.lblsalary.BackColor = System.Drawing.Color.Lime
        Me.lblsalary.Location = New System.Drawing.Point(141, 191)
        Me.lblsalary.Name = "lblsalary"
        Me.lblsalary.Size = New System.Drawing.Size(10, 13)
        Me.lblsalary.TabIndex = 8
        Me.lblsalary.Text = "-"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(11, 221)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "เงินทั้งปีรวมโบนัส"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(46, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "คำนวณภาษีประจำปี"
        '
        'btncal
        '
        Me.btncal.Enabled = False
        Me.btncal.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btncal.Location = New System.Drawing.Point(98, 260)
        Me.btncal.Name = "btncal"
        Me.btncal.Size = New System.Drawing.Size(100, 38)
        Me.btncal.TabIndex = 5
        Me.btncal.Text = "คำนวณ"
        Me.btncal.UseVisualStyleBackColor = True
        '
        'txtbonus
        '
        Me.txtbonus.Location = New System.Drawing.Point(149, 87)
        Me.txtbonus.Name = "txtbonus"
        Me.txtbonus.Size = New System.Drawing.Size(127, 20)
        Me.txtbonus.TabIndex = 4
        Me.txtbonus.Text = "1.5"
        '
        'txtsalary
        '
        Me.txtsalary.Location = New System.Drawing.Point(149, 61)
        Me.txtsalary.Name = "txtsalary"
        Me.txtsalary.Size = New System.Drawing.Size(127, 20)
        Me.txtsalary.TabIndex = 3
        Me.txtsalary.Text = "17000"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(56, 191)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "เงินทั้งปี"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(66, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "โบนัส :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(54, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "เงินเดือน :"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApp1.My.Resources.Resources.IMG_0638
        Me.PictureBox1.Location = New System.Drawing.Point(395, 21)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(177, 181)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'chksso
        '
        Me.chksso.AutoSize = True
        Me.chksso.Location = New System.Drawing.Point(149, 124)
        Me.chksso.Name = "chksso"
        Me.chksso.Size = New System.Drawing.Size(63, 17)
        Me.chksso.TabIndex = 13
        Me.chksso.Text = "หัก ปกส"
        Me.chksso.UseVisualStyleBackColor = True
        '
        'txtsso
        '
        Me.txtsso.Location = New System.Drawing.Point(149, 148)
        Me.txtsso.Name = "txtsso"
        Me.txtsso.Size = New System.Drawing.Size(49, 20)
        Me.txtsso.TabIndex = 14
        Me.txtsso.Text = "5"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(204, 151)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(15, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "%"
        '
        'frmmain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(673, 409)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmmain"
        Me.Text = "โปรแกรมคำนวณภาษี"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblSalarywithbonus As Label
    Friend WithEvents lblsalary As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btncal As Button
    Friend WithEvents txtbonus As TextBox
    Friend WithEvents txtsalary As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtsso As TextBox
    Friend WithEvents chksso As CheckBox
End Class
