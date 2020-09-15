<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmconfig
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_Xml = New System.Windows.Forms.TextBox()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.btn_Dialog = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txt_Api = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Xml File :"
        '
        'txt_Xml
        '
        Me.txt_Xml.Location = New System.Drawing.Point(73, 17)
        Me.txt_Xml.Name = "txt_Xml"
        Me.txt_Xml.Size = New System.Drawing.Size(321, 20)
        Me.txt_Xml.TabIndex = 1
        '
        'btnsave
        '
        Me.btnsave.Location = New System.Drawing.Point(297, 97)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(75, 33)
        Me.btnsave.TabIndex = 2
        Me.btnsave.Text = "SAVE"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'btn_Dialog
        '
        Me.btn_Dialog.Location = New System.Drawing.Point(400, 17)
        Me.btn_Dialog.Name = "btn_Dialog"
        Me.btn_Dialog.Size = New System.Drawing.Size(65, 20)
        Me.btn_Dialog.TabIndex = 3
        Me.btn_Dialog.Text = "..."
        Me.btn_Dialog.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.txt_Api)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btn_Dialog)
        Me.Panel1.Controls.Add(Me.txt_Xml)
        Me.Panel1.Controls.Add(Me.btnsave)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(478, 149)
        Me.Panel1.TabIndex = 4
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(390, 97)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 33)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Exit"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txt_Api
        '
        Me.txt_Api.Location = New System.Drawing.Point(73, 52)
        Me.txt_Api.Name = "txt_Api"
        Me.txt_Api.Size = New System.Drawing.Size(321, 20)
        Me.txt_Api.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "API Value :"
        '
        'frmconfig
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(499, 174)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmconfig"
        Me.Text = "ตั้งค่าฐานข้อมูล"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txt_Xml As TextBox
    Friend WithEvents btnsave As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents btn_Dialog As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txt_Api As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
End Class
