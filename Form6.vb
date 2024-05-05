Imports System.Threading.Thread
Imports System.Globalization
Public Class Form6

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form1.Show()

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

        If CheckBox1.Checked = True Then

            CurrentThread.CurrentUICulture = New CultureInfo("en")
            Controls.Clear()

            InitializeComponent()


        End If
    End Sub
    Private Sub CheckBox1_CheckedChanged_1(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

        If CheckBox1.Checked = True Then
            'Form1.CheckBox1.Checked = True
            CurrentThread.CurrentUICulture = New CultureInfo("en")
            Controls.Clear()

            InitializeComponent()


        End If
    End Sub



    Private Sub Check_CheckedChanged(sender As Object, e As EventArgs) Handles Check.CheckedChanged
        'Form1.CheckBox2.Checked = True
        If Check.Checked = True Then
            CurrentThread.CurrentUICulture = New CultureInfo("er")
            Controls.Clear()

            InitializeComponent()
        End If

    End Sub
End Class