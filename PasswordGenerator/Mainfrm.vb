Imports MaterialSkin
Public Class Mainfrm
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer

    Private Sub Form1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        drag = True
        mousex = Cursor.Position.X - Me.Left
        mousey = Cursor.Position.Y - Me.Top
    End Sub

    Private Sub Form1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        If drag Then
            Me.Top = Cursor.Position.Y - mousey
            Me.Left = Cursor.Position.X - mousex
        End If
    End Sub
    Private Sub Form1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp
        drag = False
    End Sub

    Public Function RandomString(ByVal minLength As Integer, ByVal maxLength As Integer, Optional ByVal LCase As Boolean = True, Optional ByVal UCase As Boolean = True, Optional ByVal Numeric As Boolean = True) As String
        If minLength <= 0 OrElse maxLength <= 0 OrElse minLength > maxLength Then Return Nothing
        Dim myChars As String = ""
        If LCase = True Then myChars = "abcdefgijkmnopqrstwxyz"
        If UCase = True Then myChars &= "ABCDEFGHJKLMNPQRSTWXYZ"
        If Numeric = True Then myChars &= "1234567890"
        Dim charGroups As Char()() = New Char()() {myChars.ToCharArray}
        Dim charsLeftInGroup As Integer() = New Integer(charGroups.Length - 1) {}
        For i As Integer = 0 To charsLeftInGroup.Length - 1
            charsLeftInGroup(i) = charGroups(i).Length
        Next
        Dim leftGroupsOrder As Integer() = New Integer(charGroups.Length - 1) {}
        For i As Integer = 0 To leftGroupsOrder.Length - 1
            leftGroupsOrder(i) = i
        Next
        Dim randomBytes As Byte() = New Byte(3) {}
        Dim rng As New System.Security.Cryptography.RNGCryptoServiceProvider()
        rng.GetBytes(randomBytes)
        Dim seed As Integer = (randomBytes(0) And &H7F) << 24 Or randomBytes(1) << 16 Or randomBytes(2) << 8 Or randomBytes(3)
        Dim random As New Random(seed)
        Dim password As Char() = Nothing
        If minLength < maxLength Then
            password = New Char(random.[Next](minLength, maxLength + 1) - 1) {}
        Else
            password = New Char(minLength - 1) {}
        End If
        Dim nextCharIdx As Integer
        Dim nextGroupIdx As Integer
        Dim nextLeftGroupsOrderIdx As Integer
        Dim lastCharIdx As Integer
        Dim lastLeftGroupsOrderIdx As Integer = leftGroupsOrder.Length - 1
        For i As Integer = 0 To password.Length - 1
            If lastLeftGroupsOrderIdx = 0 Then
                nextLeftGroupsOrderIdx = 0
            Else
                nextLeftGroupsOrderIdx = random.[Next](0, lastLeftGroupsOrderIdx)
            End If
            nextGroupIdx = leftGroupsOrder(nextLeftGroupsOrderIdx)
            lastCharIdx = charsLeftInGroup(nextGroupIdx) - 1
            If lastCharIdx = 0 Then
                nextCharIdx = 0
            Else
                nextCharIdx = random.[Next](0, lastCharIdx + 1)
            End If
            password(i) = charGroups(nextGroupIdx)(nextCharIdx)
            If lastCharIdx = 0 Then
                charsLeftInGroup(nextGroupIdx) = charGroups(nextGroupIdx).Length
            Else
                If lastCharIdx <> nextCharIdx Then
                    Dim temp As Char = charGroups(nextGroupIdx)(lastCharIdx)
                    charGroups(nextGroupIdx)(lastCharIdx) = charGroups(nextGroupIdx)(nextCharIdx)
                    charGroups(nextGroupIdx)(nextCharIdx) = temp
                End If
                charsLeftInGroup(nextGroupIdx) -= 1
            End If
            If lastLeftGroupsOrderIdx = 0 Then
                lastLeftGroupsOrderIdx = leftGroupsOrder.Length - 1
            Else
                If lastLeftGroupsOrderIdx <> nextLeftGroupsOrderIdx Then
                    Dim temp As Integer = leftGroupsOrder(lastLeftGroupsOrderIdx)
                    leftGroupsOrder(lastLeftGroupsOrderIdx) = leftGroupsOrder(nextLeftGroupsOrderIdx)
                    leftGroupsOrder(nextLeftGroupsOrderIdx) = temp
                End If
                lastLeftGroupsOrderIdx -= 1
            End If
        Next
        Return New String(password)
    End Function
    Private Sub MaterialFlatButton1_Click(sender As Object, e As EventArgs)
        Environment.Exit(1)
    End Sub

    Private Sub Passwordbtn_Click(sender As Object, e As EventArgs) Handles Passwordbtn.Click
        Try
            If includenumradio.Checked = True Then
                Passwordlbl.Text = RandomString(CInt(Mincharacterlengthtxt.Text), CInt(Maxcharacterlengthtxt.Text), Lowercaseletterchk.Checked, Uppercaseletterchk.Checked, True)
            Else
                Passwordlbl.Text = RandomString(CInt(Mincharacterlengthtxt.Text), CInt(Maxcharacterlengthtxt.Text), Lowercaseletterchk.Checked, Uppercaseletterchk.Checked, False)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Environment.Exit(1)
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Form1.Show()
    End Sub
End Class
