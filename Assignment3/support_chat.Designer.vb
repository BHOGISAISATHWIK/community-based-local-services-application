﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class support_chat
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
        inputTextBox = New TextBox()
        sendButton = New Button()
        Support = New Panel()
        Panel1 = New Panel()
        separatorLine = New Label()
        Panel2 = New Panel()
        Label2 = New Label()
        Label1 = New Label()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' inputTextBox
        ' 
        inputTextBox.BorderStyle = BorderStyle.None
        inputTextBox.Font = New Font("Microsoft YaHei", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        inputTextBox.Location = New Point(24, 568)
        inputTextBox.Margin = New Padding(2)
        inputTextBox.Multiline = True
        inputTextBox.Name = "inputTextBox"
        inputTextBox.PlaceholderText = "   write .."
        inputTextBox.Size = New Size(717, 37)
        inputTextBox.TabIndex = 0
        ' 
        ' sendButton
        ' 
        sendButton.BackColor = Color.FromArgb(CByte(214), CByte(179), CByte(227))
        sendButton.FlatAppearance.BorderSize = 0
        sendButton.FlatStyle = FlatStyle.Flat
        sendButton.Font = New Font("Microsoft YaHei", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        sendButton.Location = New Point(740, 568)
        sendButton.Margin = New Padding(2)
        sendButton.Name = "sendButton"
        sendButton.Size = New Size(76, 37)
        sendButton.TabIndex = 1
        sendButton.Text = "send"
        sendButton.UseVisualStyleBackColor = False
        ' 
        ' Support
        ' 
        Support.AutoScroll = True
        Support.Location = New Point(24, 112)
        Support.Margin = New Padding(2)
        Support.Name = "Support"
        Support.Size = New Size(792, 454)
        Support.TabIndex = 2
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(separatorLine)
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(Support)
        Panel1.Controls.Add(sendButton)
        Panel1.Controls.Add(inputTextBox)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(847, 671)
        Panel1.TabIndex = 3
        ' 
        ' separatorLine
        ' 
        separatorLine.BorderStyle = BorderStyle.FixedSingle
        separatorLine.Location = New Point(24, 50)
        separatorLine.Margin = New Padding(4, 0, 4, 0)
        separatorLine.Name = "separatorLine"
        separatorLine.Size = New Size(680, 2)
        separatorLine.TabIndex = 6
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(214), CByte(179), CByte(227))
        Panel2.Controls.Add(Label2)
        Panel2.Location = New Point(23, 61)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(793, 46)
        Panel2.TabIndex = 4
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft YaHei", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(27, 10)
        Label2.Name = "Label2"
        Label2.Size = New Size(79, 27)
        Label2.TabIndex = 0
        Label2.Text = "Admin"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft YaHei", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(173), CByte(103), CByte(200))
        Label1.Location = New Point(20, 15)
        Label1.Name = "Label1"
        Label1.Size = New Size(222, 37)
        Label1.TabIndex = 3
        Label1.Text = "Chat to Admin"
        ' 
        ' support_chat
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(847, 671)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Margin = New Padding(2)
        Name = "support_chat"
        Text = "support_chat"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents inputTextBox As TextBox
    Friend WithEvents sendButton As Button
    Friend WithEvents Support As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents separatorLine As Label
End Class
