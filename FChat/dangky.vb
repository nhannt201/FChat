Imports System.Net
Imports System.IO

Public Class dangky

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        load2.Show()
        Me.Hide()
    End Sub
    Public Function getUrlSource(url As String) As String
        Dim Request As HttpWebRequest = HttpWebRequest.Create(url)
        Dim Response As HttpWebResponse = Request.GetResponse()
        Dim reader As StreamReader = New StreamReader(Response.GetResponseStream)
        Dim httpContent As String
        httpContent = reader.ReadToEnd
        Return httpContent
    End Function
    Private Shared ReadOnly VietnameseSigns As String() = New String() {"aAeEoOuUiIdDyY", "áàạảãâấầậẩẫăắằặẳẵ", "ÁÀẠẢÃÂẤẦẬẨẪĂẮẰẶẲẴ", "éèẹẻẽêếềệểễ", "ÉÈẸẺẼÊẾỀỆỂỄ", "óòọỏõôốồộổỗơớờợởỡ", _
                                                                            "ÓÒỌỎÕÔỐỒỘỔỖƠỚỜỢỞỠ", "úùụủũưứừựửữ", "ÚÙỤỦŨƯỨỪỰỬỮ", "íìịỉĩ", "ÍÌỊỈĨ", "đ", _
                                                                            "Đ", "ýỳỵỷỹ", "ÝỲỴỶỸ"}

    Public Shared Function RemoveSign4VietnameseString(ByVal str As String) As String
        For i As Integer = 1 To VietnameseSigns.Length - 1
            For j As Integer = 0 To VietnameseSigns(i).Length - 1
                str = str.Replace(VietnameseSigns(i)(j), VietnameseSigns(0)(i - 1))
            Next
        Next
        Return str
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If TextBox1.Text = "" Then
            MsgBox("Tên đăng nhập rỗng!")
        ElseIf TextBox2.Text = "" Then
            MsgBox("Mã bảo mật rỗng!")
        Else
            'checku()
            Dim chat22t As String = getUrlSource("http://nghenhac.luutru360.com/fchat/user/" & StrConv(RemoveSign4VietnameseString(TextBox1.Text), 2) & ".txt")
            TextBox3.Text = chat22t
            If TextBox1.Text = TextBox3.Text Then
                MsgBox("Tài khoản này đã tồn tại!")
            ElseIf InStr(TextBox3.Text, StrConv(RemoveSign4VietnameseString(TextBox1.Text), 2)) > 0 Then
                ' ElseIf TextBox3.TextLength < 10 Then
                ' MsgBox(TextBox3.TextLength)
                MsgBox("Tài khoản này đã tồn tại!")
                TextBox1.Text = ""
            Else
                dangky()
            End If
        End If

    End Sub


    Sub dangky()
        Dim chat22t As String = New System.Net.WebClient().DownloadString("http://nghenhac.luutru360.com/fchat/u.php?msm=" & StrConv(RemoveSign4VietnameseString(TextBox1.Text), 2) & "&nick=" & StrConv(RemoveSign4VietnameseString(TextBox1.Text), 2) & " " & TextBox2.Text)
        MsgBox("Đăng ký thành công ! Vui lòng đăng nhập!")
        TextBox1.Text = ""
        TextBox2.Text = ""
        load2.Show()
        Me.Hide()
    End Sub

    Private Sub dangky_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox3.Hide()
    End Sub
End Class