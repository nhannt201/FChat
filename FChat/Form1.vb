Imports System.Text
Imports System.Net
Imports System.IO

Public Class Form1

    Public Function getUrlSource(url As String) As String
        Dim Request As HttpWebRequest = HttpWebRequest.Create(url)
        Dim Response As HttpWebResponse = Request.GetResponse()
        Dim reader As StreamReader = New StreamReader(Response.GetResponseStream)
        Dim httpContent As String
        httpContent = reader.ReadToEnd
        Return httpContent
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Send.Click
        ' Dim sourceString As String = New System.Net.WebClient().DownloadString("SomeWebPage")
        If InStr(chat.Text, " ") > 0 Then
            Dim chatt As String = New System.Net.WebClient().DownloadString("http://nghenhac.luutru360.com/fchat/chat2.php?nick=" & nick.Text & "&text=" & chat.Text)
            chat.Text = ""
            chat.SelectionStart = 0
        Else

            MsgBox("Chưa nhập nội dung Text!")
        End If

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Dim chatt As String = getUrlSource("http://nghenhac.luutru360.com/fchat/r2.php")
        '  chattxt.Text = chatt
        checkk.Text = chatt
      
        If InStr(ck2.Text, checkk.Text) > 0 Then

        Else
            wmp.URL = "http://nghenhac.luutru360.com/fchat/mp3.mp3"
            ck2.Text = chatt
            chattxt.Text = chattxt.Text & chatt
            chattxt.SelectionStart = chattxt.TextLength
            chattxt.ScrollToCaret()

        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        'Dim chat2t As String = New System.Net.WebClient().DownloadString("http://nghenhac.luutru360.com/fchat/kill.php")
        chattxt.Text = ""
    End Sub

    Private Sub chat_KeyDown(sender As Object, e As KeyEventArgs) Handles chat.KeyDown
        If e.KeyCode = Keys.Enter Then
            If InStr(chat.Text, " ") > 0 Then
                Dim chatt As String = New System.Net.WebClient().DownloadString("http://nghenhac.luutru360.com/fchat/chat2.php?nick=" & nick.Text & "&text=" & chat.Text)
                chat.Text = ""
                chat.SelectionStart = 0
            Else
              
                MsgBox("Chưa nhập nội dung Text!")
            End If

        End If
    End Sub


    Private Sub chat_TextChanged(sender As Object, e As EventArgs) Handles chat.TextChanged


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        checkk.Hide()
        ck2.Hide()
        wmp.Hide()
        ' Dim chatt As String = getUrlSource("http://nghenhac.luutru360.com/fchat/r2.php")

        ' chattxt.Text = chatt
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Timer2.Enabled = True
        Button2.Enabled = False
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        'Dim chat2t As String = New System.Net.WebClient().DownloadString("http://nghenhac.luutru360.com/fchat/kill.php")
        chattxt.Text = ""
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Timer2.Enabled = False
        Button2.Enabled = True
    End Sub
End Class
