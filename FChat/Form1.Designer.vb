<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.nick = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chat = New System.Windows.Forms.TextBox()
        Me.Send = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.chattxt = New System.Windows.Forms.RichTextBox()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.wmp = New AxWMPLib.AxWindowsMediaPlayer()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.ck2 = New System.Windows.Forms.TextBox()
        Me.checkk = New System.Windows.Forms.TextBox()
        CType(Me.wmp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'nick
        '
        Me.nick.Location = New System.Drawing.Point(99, 402)
        Me.nick.Name = "nick"
        Me.nick.Size = New System.Drawing.Size(250, 20)
        Me.nick.TabIndex = 1
        Me.nick.Text = "Chưa có tên"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 403)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "NickName:"
        '
        'chat
        '
        Me.chat.Location = New System.Drawing.Point(12, 433)
        Me.chat.MaxLength = 200
        Me.chat.Multiline = True
        Me.chat.Name = "chat"
        Me.chat.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.chat.Size = New System.Drawing.Size(581, 57)
        Me.chat.TabIndex = 3
        '
        'Send
        '
        Me.Send.Location = New System.Drawing.Point(599, 433)
        Me.Send.Name = "Send"
        Me.Send.Size = New System.Drawing.Size(112, 57)
        Me.Send.TabIndex = 4
        Me.Send.Text = "&Gửi"
        Me.Send.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'chattxt
        '
        Me.chattxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.chattxt.Location = New System.Drawing.Point(12, 12)
        Me.chattxt.Name = "chattxt"
        Me.chattxt.ShowSelectionMargin = True
        Me.chattxt.Size = New System.Drawing.Size(699, 384)
        Me.chattxt.TabIndex = 5
        Me.chattxt.Text = ""
        '
        'Timer2
        '
        Me.Timer2.Interval = 120000
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(599, 402)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 25)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "&Làm sạch"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'wmp
        '
        Me.wmp.Enabled = True
        Me.wmp.Location = New System.Drawing.Point(658, 53)
        Me.wmp.Name = "wmp"
        Me.wmp.OcxState = CType(resources.GetObject("wmp.OcxState"), System.Windows.Forms.AxHost.State)
        Me.wmp.Size = New System.Drawing.Size(30, 32)
        Me.wmp.TabIndex = 8
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(366, 399)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(144, 25)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "&Auto Làm sạch sau 2 phút"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(516, 399)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(77, 25)
        Me.Button3.TabIndex = 11
        Me.Button3.Text = "&Stop Auto"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'ck2
        '
        Me.ck2.Location = New System.Drawing.Point(12, 12)
        Me.ck2.Multiline = True
        Me.ck2.Name = "ck2"
        Me.ck2.Size = New System.Drawing.Size(361, 35)
        Me.ck2.TabIndex = 12
        '
        'checkk
        '
        Me.checkk.Location = New System.Drawing.Point(379, 12)
        Me.checkk.Multiline = True
        Me.checkk.Name = "checkk"
        Me.checkk.Size = New System.Drawing.Size(361, 35)
        Me.checkk.TabIndex = 13
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(719, 502)
        Me.Controls.Add(Me.checkk)
        Me.Controls.Add(Me.ck2)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.wmp)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.chattxt)
        Me.Controls.Add(Me.Send)
        Me.Controls.Add(Me.chat)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.nick)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FChat - HDN Chat Online"
        CType(Me.wmp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents nick As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents chat As System.Windows.Forms.TextBox
    Friend WithEvents Send As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents chattxt As System.Windows.Forms.RichTextBox
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents wmp As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents ck2 As System.Windows.Forms.TextBox
    Friend WithEvents checkk As System.Windows.Forms.TextBox

End Class
