﻿Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ViewAllUser
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        ComboBox1 = New ComboBox()
        ComboBox2 = New ComboBox()
        Label3 = New Label()
        Button1 = New Button()
        Profile_Pic = New PictureBox()
        Username = New Label()
        CType(Profile_Pic, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' ComboBox1
        ' 
        ComboBox1.Font = New Font("Microsoft YaHei", 10.2F)
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(240, 45)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(182, 31)
        ComboBox1.TabIndex = 2
        ComboBox1.Text = "    Filter"
        ' 
        ' ComboBox2
        ' 
        ComboBox2.Font = New Font("Microsoft YaHei", 10.2F)
        ComboBox2.FormattingEnabled = True
        ComboBox2.Location = New Point(460, 45)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(182, 31)
        ComboBox2.TabIndex = 3
        ComboBox2.Text = "  Select Location"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft YaHei", 13.0F)
        Label3.Location = New Point(27, 109)
        Label3.Name = "Label3"
        Label3.Size = New Size(145, 30)
        Label3.TabIndex = 5
        Label3.Text = "Service Type"
        ' 
        ' Button1
        ' 
        Button1.BackgroundImage = My.Resources.Resources.back
        Button1.BackgroundImageLayout = ImageLayout.Zoom
        Button1.Location = New Point(27, 39)
        Button1.Name = "Button1"
        Button1.Size = New Size(93, 37)
        Button1.TabIndex = 7
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Profile_Pic
        ' 
        Profile_Pic.Image = My.Resources.Resources.Ellipse_6
        Profile_Pic.Location = New Point(736, 12)
        Profile_Pic.Name = "Profile_Pic"
        Profile_Pic.Size = New Size(125, 62)
        Profile_Pic.TabIndex = 2
        Profile_Pic.TabStop = False
        ' 
        ' Username
        ' 
        Username.AutoSize = True
        Username.Font = New Font("Microsoft Sans Serif", 10.2F)
        Username.Location = New Point(736, 77)
        Username.Name = "Username"
        Username.Size = New Size(0, 20)
        Username.TabIndex = 3
        ' 
        ' ViewAllUser
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(870, 450)
        Controls.Add(Button1)
        Controls.Add(Label3)
        Controls.Add(ComboBox2)
        Controls.Add(ComboBox1)
        FormBorderStyle = FormBorderStyle.None
        Name = "ViewAllUser"
        Text = "ViewAllUser"
        CType(Profile_Pic, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Profile_Pic As PictureBox
    Friend WithEvents Username As Label

End Class
