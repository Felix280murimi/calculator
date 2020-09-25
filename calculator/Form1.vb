Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Firstnum As Decimal
        Dim Secondnum As Decimal
        Dim Operations As Integer
        Dim Operator_selector As Boolean = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text <> "0" Then
            TextBox1.Text += "1"
        Else
            TextBox1.Text = "1"
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox1.Text <> "0" Then
            TextBox1.Text += "2"
        Else
            TextBox1.Text = "2"
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If TextBox1.Text <> "0" Then
            TextBox1.Text += "3"
        Else
            TextBox1.Text = "3"
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If TextBox1.Text <> "0" Then
            TextBox1.Text += "4"
        Else
            TextBox1.Text = "4"
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If TextBox1.Text <> "0" Then
            TextBox1.Text += "5"
        Else
            TextBox1.Text = "5"
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If TextBox1.Text <> "0" Then
            TextBox1.Text += "6"
        Else
            TextBox1.Text = "6"
        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If TextBox1.Text <> "0" Then
            TextBox1.Text += "7"
        Else
            TextBox1.Text = "7"
        End If
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        If TextBox1.Text <> "0" Then
            TextBox1.Text += "8"
        Else
            TextBox1.Text = "8"
        End If
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        If TextBox1.Text <> "0" Then
            TextBox1.Text += "9"
        Else
            TextBox1.Text = "9"
        End If
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        If TextBox1.Text <> "0" Then
            TextBox1.Text += "0"
        End If
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        If Not (TextBox1.Text.Contains(".")) Then
            TextBox1.Text += "."
        End If
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        TextBox1.Text = "0"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim Firstnum As Decimal
        Dim Operator_selector As Boolean
        Dim Operations As Integer
        Firstnum = TextBox1.Text
        TextBox1.Text = "0"
        Operator_selector = True
        Operations = 1  ' = +
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim Firstnum As Decimal
        Dim Operator_selector As Boolean
        Dim Operations As Integer
        Firstnum = TextBox1.Text
        TextBox1.Text = "0"
        Operator_selector = True
        Operations = 2  ' = -
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Dim Firstnum As Decimal
        Dim Operator_selector As Boolean
        Dim Operations As Integer
        Firstnum = TextBox1.Text
        TextBox1.Text = "0"
        Operator_selector = True
        Operations = 3  ' = *
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        Dim Firstnum As Decimal
        Dim Operator_selector As Boolean
        Dim Operations As Integer
        Firstnum = TextBox1.Text
        TextBox1.Text = "0"
        Operator_selector = True
        Operations = 4  '  /
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        Dim Firstnum As Decimal
        Dim Secondnum As Decimal
        Dim Operations As Integer
        Dim Operator_selector As Boolean
        If Operator_selector = True Then
            Secondnum = TextBox1.Text
            If operations = 1 Then
                TextBox1.Text = Firstnum + Secondnum
            ElseIf Operations = 2 Then
                TextBox1.Text = Firstnum - Secondnum
            ElseIf Operations = 3 Then
                TextBox1.Text = Firstnum * Secondnum
            Else
                If Secondnum = 0 Then
                    TextBox1.Text = "Error!"
                Else
                    TextBox1.Text = Firstnum / Secondnum
                End If
            End If
            Operator_selector = False
        End If
    End Sub
End Class
