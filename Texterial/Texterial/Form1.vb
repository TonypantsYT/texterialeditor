Public Class Form1
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
    Private Sub MaterialFlatButton1_Click(sender As Object, e As EventArgs) Handles MaterialFlatButton1.Click
        OpenFileDialog1.ShowDialog()

        RichTextBox1.LoadFile(OpenFileDialog1.FileName)
    End Sub

    Private Sub MaterialFlatButton5_Click(sender As Object, e As EventArgs) Handles MaterialFlatButton5.Click
        Me.Close()
    End Sub

    Private Sub MaterialFlatButton6_Click(sender As Object, e As EventArgs) Handles MaterialFlatButton6.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub MaterialFlatButton4_Click(sender As Object, e As EventArgs) Handles MaterialFlatButton4.Click
        FontDialog1.ShowDialog()
        RichTextBox1.Font = FontDialog1.Font
    End Sub

    Private Sub MaterialFlatButton3_Click(sender As Object, e As EventArgs) Handles MaterialFlatButton3.Click
        ColorDialog1.ShowDialog()
        RichTextBox1.ForeColor = ColorDialog1.Color
    End Sub

    Private Sub MaterialFlatButton2_Click(sender As Object, e As EventArgs) Handles MaterialFlatButton2.Click
        SaveFileDialog1.ShowDialog()
        RichTextBox1.SaveFile(SaveFileDialog1.FileName)
    End Sub
#Region " Move Form "

    ' [ Move Form ]
    '
    ' // By Elektro 

    Public MoveForm As Boolean
    Public MoveForm_MousePosition As Point

    Public Sub MoveForm_MouseDown(sender As Object, e As MouseEventArgs) Handles _
    Panel1.MouseDown ' Add more handles here (Example: PictureBox1.MouseDown)

        If e.Button = MouseButtons.Left Then
            MoveForm = True
            Me.Cursor = Cursors.NoMove2D
            MoveForm_MousePosition = e.Location
        End If

    End Sub

    Public Sub MoveForm_MouseMove(sender As Object, e As MouseEventArgs) Handles _
    Panel1.MouseMove ' Add more handles here (Example: PictureBox1.MouseMove)

        If MoveForm Then
            Me.Location = Me.Location + (e.Location - MoveForm_MousePosition)
        End If

    End Sub

    Public Sub MoveForm_MouseUp(sender As Object, e As MouseEventArgs) Handles _
    Panel1.MouseUp ' Add more handles here (Example: PictureBox1.MouseUp)

        If e.Button = MouseButtons.Left Then
            MoveForm = False
            Me.Cursor = Cursors.Default
        End If

    End Sub

#End Region
End Class
