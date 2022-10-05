Public Class Form1
    Dim n(2) As Integer
    Dim t As Integer





    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cont As Integer

        n(0) = Convert.ToInt32(TextBox1.Text)
        n(1) = Convert.ToInt32(TextBox2.Text)
        n(2) = Convert.ToInt32(TextBox3.Text)
        cont = 1
suma:

        If cont <= 3 Then
            If n(0) > n(1) Then
                t = n(0)
                n(0) = n(1)
                n(1) = t
            End If

            If n(1) > n(2) Then
                t = n(1)
                n(1) = n(2)
                n(2) = t
            End If
            cont = cont + 1
            GoTo suma
        End If

        TextBox4.Text = n(0)
        TextBox5.Text = n(1)
        TextBox6.Text = n(2)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim cont As Integer

        n(0) = Convert.ToInt32(TextBox1.Text)
        n(1) = Convert.ToInt32(TextBox2.Text)
        n(2) = Convert.ToInt32(TextBox3.Text)
        cont = 1
suma:

        If cont <= 3 Then
            If n(0) < n(1) Then
                t = n(0)
                n(0) = n(1)
                n(1) = t
            End If

            If n(1) < n(2) Then
                t = n(1)
                n(1) = n(2)
                n(2) = t
            End If
            cont = cont + 1
            GoTo suma
        End If

        TextBox4.Text = n(0)
        TextBox5.Text = n(1)
        TextBox6.Text = n(2)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        TextBox1.Text = 0
        TextBox2.Text = 0
        TextBox3.Text = 0

    End Sub
End Class
