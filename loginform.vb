Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    If TextBox1.Text = "" Then
        MessageBox.Show("Please enter username")
        TextBox1.Focus()
        Exit Sub
    ElseIf TextBox2.Text = "" Then
        MessageBox.Show("Please enter password")
        TextBox2.Focus()
        Exit Sub
    End If

    If TextBox1.Text = "admin" And TextBox2.Text = "admin" Then
        MessageBox.Show("Welcome admin")
    Else
        MessageBox.Show("Incorrect username or password")
    End If

    If CheckBox1.Checked Then
        TextBox2.PasswordChar = ControlChars.NullChar
    Else
        TextBox2.PasswordChar = "*"c
    End If
End Sub
