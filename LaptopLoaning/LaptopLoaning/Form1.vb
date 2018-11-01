Imports System.IO

Public Class Form1

    Dim filePath As String = "C:\Where Laptop Go\"

    Dim locations1 = File.ReadAllLines(filePath + "Locations1.txt")
    Dim ABlockLevels = File.ReadAllLines(filePath + "ABlockLevels.txt")
    Dim ABlockRoomsL0 = File.ReadAllLines(filePath + "ABlockRoomsL0.txt")
    Dim ABlockRoomsL1 = File.ReadAllLines(filePath + "ABlockRoomsL1.txt")
    Dim BBlockLevels = File.ReadAllLines(filePath + "BBlockLevels.txt")
    Dim BBlockRoomsL0 = File.ReadAllLines(filePath + "BBlockRoomsL0.txt")
    Dim BBlockRoomsL1 = File.ReadAllLines(filePath + "BBlockRoomsL1.txt")
    Dim CBlockLevels = File.ReadAllLines(filePath + "CBlockLevels.txt")
    Dim CBlockRoomsL0 = File.ReadAllLines(filePath + "CBlockRoomsL0.txt")
    Dim CBlockRoomsL1 = File.ReadAllLines(filePath + "CBlockRoomsL1.txt")
    Dim CBlockRoomsL2 = File.ReadAllLines(filePath + "CBlockRoomsL2.txt")
    Dim EBlockRooms = File.ReadAllLines(filePath + "EBlockRooms.txt")
    Dim Demountables = File.ReadAllLines(filePath + "Demountables.txt")
    Dim Others = File.ReadAllLines(filePath + "Others.txt")

    Dim SpecialCharacter As Char() = {"\"c}
    Dim Separator As String = "----"

    Dim WhereWent As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cmbLocation1.Items.AddRange(locations1)

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbLocation1.SelectedIndexChanged

        cmbLocation2.Visible = True
        cmbLocation2.Items.Clear()
        cmbLocation2.Text = ""
        cmbLocation3.Visible = False
        cmbLocation3.Items.Clear()
        btnConfirm.Enabled = False

        Select Case cmbLocation1.Text
            Case locations1(0)
                cmbLocation2.Items.AddRange(ABlockLevels)
                cmbLocation3.Visible = True
            Case locations1(1)
                cmbLocation2.Items.AddRange(BBlockLevels)
                cmbLocation3.Visible = True
            Case locations1(2)
                cmbLocation2.Items.AddRange(CBlockLevels)
                cmbLocation3.Visible = True
            Case locations1(3)
                cmbLocation2.Items.AddRange(EBlockRooms)
            Case locations1(4)
                cmbLocation2.Items.AddRange(Demountables)
            Case locations1(5)
                cmbLocation2.Items.AddRange(Others)

        End Select

    End Sub

    Private Sub cmbLocation2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbLocation2.SelectedIndexChanged

        btnConfirm.Enabled = False
        cmbLocation3.Items.Clear()
        cmbLocation3.Text = ""

        Select Case cmbLocation2.Text
            Case ABlockLevels(0)
                cmbLocation3.Items.AddRange(ABlockRoomsL0)
                cmbLocation3.Visible = True
            Case ABlockLevels(1)
                cmbLocation3.Items.AddRange(ABlockRoomsL1)
                cmbLocation3.Visible = True
            Case BBlockLevels(0)
                cmbLocation3.Items.AddRange(BBlockRoomsL0)
                cmbLocation3.Visible = True
            Case BBlockLevels(1)
                cmbLocation3.Items.AddRange(BBlockRoomsL1)
                cmbLocation3.Visible = True
            Case CBlockLevels(0)
                cmbLocation3.Items.AddRange(CBlockRoomsL0)
                cmbLocation3.Visible = True
            Case CBlockLevels(1)
                cmbLocation3.Items.AddRange(CBlockRoomsL1)
                cmbLocation3.Visible = True
            Case CBlockLevels(2)
                cmbLocation3.Items.AddRange(CBlockRoomsL2)
                cmbLocation3.Visible = True
            Case Else
                btnConfirm.Enabled = True

        End Select

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSerialNumber.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtSerialNumber.Text += "\"
            txtSerialNumber.SelectionStart = Len(txtSerialNumber.Text)
        End If
    End Sub

    Private Sub cmbLocation3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbLocation3.SelectedIndexChanged
        btnConfirm.Enabled = True
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        Dim WhereWentLines = File.ReadAllLines(WhereWent)

        If txtSerialNumber.Text(Len(txtSerialNumber.Text) - 1) = SpecialCharacter Then
            txtSerialNumber.Text = txtSerialNumber.Text.Remove(txtSerialNumber.Text.Length - 1)
        End If
        Dim SerialNumbers As String() = txtSerialNumber.Text.Split(SpecialCharacter)

        For Each serialNumber In SerialNumbers
            Dim Found As Boolean = False
            For i = 0 To WhereWentLines.Length() - 1

                'Console.WriteLine("Serial Number from file: " + (WhereWentLines(i).Split(SpecialCharacter))(0))
                'Console.WriteLine("Serial Number from textbox: " + txtSerialNumber.Text)

                If serialNumber = RemoveCharacter((WhereWentLines(i).Split(SpecialCharacter))(0), vbCrLf) Then
                    Found = True
                    If cmbLocation3.Visible Then
                        WhereWentLines(i) = serialNumber + SpecialCharacter + cmbLocation1.Text + Separator + cmbLocation2.Text + Separator + cmbLocation3.Text
                    Else
                        WhereWentLines(i) = serialNumber + SpecialCharacter + cmbLocation1.Text + Separator + cmbLocation2.Text
                    End If
                End If

                If Not Found And i = WhereWentLines.Length() - 1 Then
                    If cmbLocation3.Visible Then
                        WhereWentLines(i) += vbCrLf + serialNumber + SpecialCharacter + cmbLocation1.Text + Separator + cmbLocation2.Text + Separator + cmbLocation3.Text
                    Else
                        WhereWentLines(i) += vbCrLf + serialNumber + SpecialCharacter + cmbLocation1.Text + Separator + cmbLocation2.Text
                    End If
                End If
            Next
        Next

        File.WriteAllLines(WhereWent, WhereWentLines)
        MsgBox("Successfully written to " + WhereWent)
    End Sub

    Private Sub txtFileLocation_TextChanged(sender As Object, e As EventArgs) Handles txtFileLocation.TextChanged
        WhereWent = txtFileLocation.Text
    End Sub

    Private Function RemoveCharacter(ByVal stringToClean, ByVal charRemove)
        Return stringToClean.Replace(charRemove, "")
    End Function
End Class
