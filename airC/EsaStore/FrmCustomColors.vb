Imports System.Windows.Forms

Public Class FrmCustomColors

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub


    Private Sub lbl_color6_Click(sender As Object, e As EventArgs) Handles lbl_color.Click
        Dim sure = Me.ColorDialog1.ShowDialog()

        If sure = vbOK Then
            lbl_color.BackColor = Me.ColorDialog1.Color

        End If
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        Try

            My.Settings.color6 = Me.lbl_color.BackColor
            My.Settings.Save()

            Me.Close()



        Catch ex As Exception

        End Try
    End Sub

    Private Sub FrmCustomColors_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            Me.lbl_color.BackColor = My.Settings.color6

        Catch ex As Exception

        End Try
    End Sub
End Class
