Imports System.IO

Public Class Form1
    Public Class perro
        'atributos del perro
        Public nombre As String
        Public raza As String
        Public edad As Integer
        Public peso As Double
        'metodos del perro
        Public Sub ladrar()
            MessageBox.Show("Guau guau")
        End Sub
        Public Sub comer()
            MessageBox.Show("Estoy comiendo")
        End Sub
        Public Sub dormir()
            MessageBox.Show("Estoy durmiendo")
        End Sub
        'costructor
        Public Sub New()
            nombre = "Firulais"
            raza = "Pastor Aleman"
            edad = 5
            peso = 20.5
        End Sub
        'sobreescribo el metodo tostring
        Public Overrides Function ToString() As String
            Return "Nombre: " & nombre & vbCrLf & "Raza: " & raza & vbCrLf & "Edad: " & edad & vbCrLf & "Peso: " & peso
        End Function

    End Class
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not Directory.Exists(Path.Combine(Application.StartupPath, "notas")) Then
            Directory.CreateDirectory(Path.Combine(Application.StartupPath, "notas"))
        End If
        OpenFileDialog1.InitialDirectory = Path.Combine(Application.StartupPath, "notas")
        SaveFileDialog1.InitialDirectory = Path.Combine(Application.StartupPath, "notas")
        Dim miperro As New perro
        MsgBox(miperro.ToString)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        OpenFileDialog1.ShowDialog()
        If OpenFileDialog1.FileName <> "" Then
            RichTextBox1.LoadFile(OpenFileDialog1.FileName, RichTextBoxStreamType.RichText)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        RichTextBox1.Clear()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        SaveFileDialog1.ShowDialog()
        If SaveFileDialog1.FileName <> "" Then
            RichTextBox1.SaveFile(SaveFileDialog1.FileName, RichTextBoxStreamType.RichText)
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        RichTextBox1.SelectionAlignment = HorizontalAlignment.Left
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        RichTextBox1.SelectionAlignment = HorizontalAlignment.Center
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        RichTextBox1.SelectionAlignment = HorizontalAlignment.Right
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        FontDialog1.ShowDialog()
        RichTextBox1.SelectionFont = FontDialog1.Font
        Label2.Text = FontDialog1.ToString

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim result As DialogResult = ColorDialog1.ShowDialog()
        If result <> DialogResult.OK Then
            Exit Sub
        End If
        RichTextBox1.SelectionColor = ColorDialog1.Color

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim result As DialogResult = ColorDialog1.ShowDialog()
        If result <> DialogResult.OK Then
            Exit Sub
        End If
        RichTextBox1.SelectionBackColor = ColorDialog1.Color

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Me.Close()
    End Sub
End Class
