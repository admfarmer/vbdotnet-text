Imports System.Xml


Public Class frmconfig
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txt_Xml.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btn_Dialog.Click
        getfile()
        readfile()

    End Sub

    Private Sub readfile()
        Dim m_xmlr As XmlTextReader
        m_xmlr = New XmlTextReader(txt_Xml.Text)
        m_xmlr.WhitespaceHandling = WhitespaceHandling.None
        m_xmlr.Read()
        m_xmlr.Read()
        While Not m_xmlr.EOF
            m_xmlr.Read()
            If Not m_xmlr.IsStartElement() Then
                Exit While
            End If
            m_xmlr.GetAttribute("IP")
            m_xmlr.Read()
            Me.txt_Api.Text = (m_xmlr.ReadElementString("value"))
            ' MsgBox(m_xmlr.ReadElementStr ing("value"))
            m_xmlr.Close
        End While


    End Sub
    Private Sub getfile()
        Try
            Dim dg As New FolderBrowserDialog
            dg.Description = "Selecte File XML"
            dg.ShowNewFolderButton = True
            dg.SelectedPath = Me.txt_Xml.Text
            OpenFileDialog1.InitialDirectory = "D:\Data\"
            'OpenFileDialog1.InitialDirectory = My.Application.Info.DirectoryPath & "\Data\"
            'OpenFileDialog1.InitialDirectory = My.Application.Info.DirectoryPath & "\data\"
            '  MsgBox(My.Application.Info.DirectoryPath & "Data\")
            'My.Application.Info.DirectoryPath & "\Data\"
            OpenFileDialog1.Filter = ".xml|*xml"
            If OpenFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                Me.txt_Xml.Text = IO.Path.GetFullPath(OpenFileDialog1.FileName)
            End If

        Catch ex As Exception

        End Try
    End Sub
    Private Sub CloseFormMain()
        Dim resp As MsgBoxResult
        Try

            resp = MessageBox.Show("ยืนยัน", "ออกจากโปรแกรม", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
            If resp = MsgBoxResult.Yes Then
                Application.Exit()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CloseFormMain()
    End Sub

    Private Sub frmconfig_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        writefile()
    End Sub

    Private Sub writefile()
        Try
            Dim myXml As New XmlDocument()
            Dim nodes As XmlNodeList
            myXml.Load(Me.txt_Xml.Text)

            ' Dim arr As XmlAttribute
            Dim strxmlNode As XmlNode
            strxmlNode = myXml.SelectSingleNode("/Config/name[@IP='HostName']")
            If Not strxmlNode Is Nothing Then
                nodes = strxmlNode.ChildNodes(0).ChildNodes
                If nodes IsNot Nothing Then
                    nodes.Item(0).InnerText = Me.txt_Api.Text.Trim()
                End If
            End If

            myXml.Save(Me.txt_Xml.Text)
            MsgBox("success!", MsgBoxStyle.Information)
        Catch ex As Exception

        End Try
    End Sub

End Class