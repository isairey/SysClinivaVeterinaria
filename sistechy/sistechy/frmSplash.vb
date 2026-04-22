Imports System.Data.SqlClient

Public Class frmSplash

    Private Sub TimerProgressBar_Tick(sender As Object, e As EventArgs) Handles TimerProgressBar.Tick

        ProgressBar.Increment(1)
        ProgressBar.Maximum = (15)

    End Sub

    Private Sub frmSplash_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        TimerProgressBar.Start()

    End Sub
End Class