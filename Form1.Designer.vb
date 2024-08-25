<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Label1 = New Label()
        Button1 = New Button()
        Label2 = New Label()
        TextBox1 = New TextBox()
        Label3 = New Label()
        GroupBox1 = New GroupBox()
        RadioButton3 = New RadioButton()
        RadioButton2 = New RadioButton()
        RadioButton1 = New RadioButton()
        GroupBox2 = New GroupBox()
        RadioButton10 = New RadioButton()
        RadioButton9 = New RadioButton()
        RadioButton8 = New RadioButton()
        RadioButton7 = New RadioButton()
        RadioButton6 = New RadioButton()
        RadioButton5 = New RadioButton()
        RadioButton4 = New RadioButton()
        GroupBox3 = New GroupBox()
        RadioButton13 = New RadioButton()
        RadioButton12 = New RadioButton()
        RadioButton11 = New RadioButton()
        NumericUpDown1 = New NumericUpDown()
        NumericUpDown2 = New NumericUpDown()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Button2 = New Button()
        Label8 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        Label12 = New Label()
        Label13 = New Label()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        GroupBox3.SuspendLayout()
        CType(NumericUpDown1, ComponentModel.ISupportInitialize).BeginInit()
        CType(NumericUpDown2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("黑体", 26.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(30, 30)
        Label1.Name = "Label1"
        Label1.Size = New Size(441, 35)
        Label1.TabIndex = 0
        Label1.Text = "中国铁路 普速票价计算器"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(623, 30)
        Button1.Name = "Button1"
        Button1.Size = New Size(88, 35)
        Button1.TabIndex = 1
        Button1.Text = "作者信息"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(52, 114)
        Label2.Name = "Label2"
        Label2.Size = New Size(80, 17)
        Label2.TabIndex = 2
        Label2.Text = "请输入里程："
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(138, 108)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(96, 23)
        TextBox1.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(240, 114)
        Label3.Name = "Label3"
        Label3.Size = New Size(26, 17)
        Label3.TabIndex = 4
        Label3.Text = "km"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(RadioButton3)
        GroupBox1.Controls.Add(RadioButton2)
        GroupBox1.Controls.Add(RadioButton1)
        GroupBox1.Location = New Point(240, 154)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(236, 107)
        GroupBox1.TabIndex = 5
        GroupBox1.TabStop = False
        GroupBox1.Text = "加快等级"
        ' 
        ' RadioButton3
        ' 
        RadioButton3.AutoSize = True
        RadioButton3.Checked = True
        RadioButton3.Location = New Point(17, 76)
        RadioButton3.Name = "RadioButton3"
        RadioButton3.Size = New Size(127, 21)
        RadioButton3.TabIndex = 2
        RadioButton3.TabStop = True
        RadioButton3.Text = "快速，K、T、Z、Y"
        RadioButton3.UseVisualStyleBackColor = True
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Location = New Point(17, 49)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(141, 21)
        RadioButton2.TabIndex = 1
        RadioButton2.TabStop = True
        RadioButton2.Text = "普快，1001-5998、L"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Location = New Point(17, 22)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(171, 21)
        RadioButton1.TabIndex = 0
        RadioButton1.Text = "普通（各停），6001-7598"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(RadioButton10)
        GroupBox2.Controls.Add(RadioButton9)
        GroupBox2.Controls.Add(RadioButton8)
        GroupBox2.Controls.Add(RadioButton7)
        GroupBox2.Controls.Add(RadioButton6)
        GroupBox2.Controls.Add(RadioButton5)
        GroupBox2.Controls.Add(RadioButton4)
        GroupBox2.Location = New Point(510, 154)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(234, 107)
        GroupBox2.TabIndex = 6
        GroupBox2.TabStop = False
        GroupBox2.Text = "席别"
        ' 
        ' RadioButton10
        ' 
        RadioButton10.AutoSize = True
        RadioButton10.Location = New Point(154, 76)
        RadioButton10.Name = "RadioButton10"
        RadioButton10.Size = New Size(62, 21)
        RadioButton10.TabIndex = 8
        RadioButton10.TabStop = True
        RadioButton10.Text = "软卧下"
        RadioButton10.UseVisualStyleBackColor = True
        ' 
        ' RadioButton9
        ' 
        RadioButton9.AutoSize = True
        RadioButton9.Location = New Point(154, 22)
        RadioButton9.Name = "RadioButton9"
        RadioButton9.Size = New Size(62, 21)
        RadioButton9.TabIndex = 7
        RadioButton9.TabStop = True
        RadioButton9.Text = "软卧上"
        RadioButton9.UseVisualStyleBackColor = True
        ' 
        ' RadioButton8
        ' 
        RadioButton8.AutoSize = True
        RadioButton8.Location = New Point(86, 76)
        RadioButton8.Name = "RadioButton8"
        RadioButton8.Size = New Size(62, 21)
        RadioButton8.TabIndex = 4
        RadioButton8.TabStop = True
        RadioButton8.Text = "硬卧下"
        RadioButton8.UseVisualStyleBackColor = True
        ' 
        ' RadioButton7
        ' 
        RadioButton7.AutoSize = True
        RadioButton7.Location = New Point(86, 49)
        RadioButton7.Name = "RadioButton7"
        RadioButton7.Size = New Size(62, 21)
        RadioButton7.TabIndex = 3
        RadioButton7.TabStop = True
        RadioButton7.Text = "硬卧中"
        RadioButton7.UseVisualStyleBackColor = True
        ' 
        ' RadioButton6
        ' 
        RadioButton6.AutoSize = True
        RadioButton6.Location = New Point(86, 22)
        RadioButton6.Name = "RadioButton6"
        RadioButton6.Size = New Size(62, 21)
        RadioButton6.TabIndex = 2
        RadioButton6.TabStop = True
        RadioButton6.Text = "硬卧上"
        RadioButton6.UseVisualStyleBackColor = True
        ' 
        ' RadioButton5
        ' 
        RadioButton5.AutoSize = True
        RadioButton5.Location = New Point(18, 76)
        RadioButton5.Name = "RadioButton5"
        RadioButton5.Size = New Size(50, 21)
        RadioButton5.TabIndex = 1
        RadioButton5.TabStop = True
        RadioButton5.Text = "软座"
        RadioButton5.UseVisualStyleBackColor = True
        ' 
        ' RadioButton4
        ' 
        RadioButton4.AutoSize = True
        RadioButton4.Checked = True
        RadioButton4.Location = New Point(18, 22)
        RadioButton4.Name = "RadioButton4"
        RadioButton4.Size = New Size(50, 21)
        RadioButton4.TabIndex = 0
        RadioButton4.TabStop = True
        RadioButton4.Text = "硬座"
        RadioButton4.UseVisualStyleBackColor = True
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(RadioButton13)
        GroupBox3.Controls.Add(RadioButton12)
        GroupBox3.Controls.Add(RadioButton11)
        GroupBox3.Location = New Point(52, 154)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(149, 107)
        GroupBox3.TabIndex = 9
        GroupBox3.TabStop = False
        GroupBox3.Text = "空调"
        ' 
        ' RadioButton13
        ' 
        RadioButton13.AutoSize = True
        RadioButton13.Checked = True
        RadioButton13.Location = New Point(38, 76)
        RadioButton13.Name = "RadioButton13"
        RadioButton13.Size = New Size(62, 21)
        RadioButton13.TabIndex = 2
        RadioButton13.TabStop = True
        RadioButton13.Text = "新空调"
        RadioButton13.UseVisualStyleBackColor = True
        ' 
        ' RadioButton12
        ' 
        RadioButton12.AutoSize = True
        RadioButton12.Location = New Point(38, 49)
        RadioButton12.Name = "RadioButton12"
        RadioButton12.Size = New Size(62, 21)
        RadioButton12.TabIndex = 1
        RadioButton12.TabStop = True
        RadioButton12.Text = "旧空调"
        RadioButton12.UseVisualStyleBackColor = True
        ' 
        ' RadioButton11
        ' 
        RadioButton11.AutoSize = True
        RadioButton11.Location = New Point(38, 22)
        RadioButton11.Name = "RadioButton11"
        RadioButton11.Size = New Size(62, 21)
        RadioButton11.TabIndex = 0
        RadioButton11.TabStop = True
        RadioButton11.Text = "无空调"
        RadioButton11.UseVisualStyleBackColor = True
        ' 
        ' NumericUpDown1
        ' 
        NumericUpDown1.Location = New Point(90, 280)
        NumericUpDown1.Name = "NumericUpDown1"
        NumericUpDown1.Size = New Size(120, 23)
        NumericUpDown1.TabIndex = 10
        NumericUpDown1.Value = New Decimal(New Integer() {1, 0, 0, 0})
        ' 
        ' NumericUpDown2
        ' 
        NumericUpDown2.Location = New Point(90, 322)
        NumericUpDown2.Name = "NumericUpDown2"
        NumericUpDown2.Size = New Size(120, 23)
        NumericUpDown2.TabIndex = 11
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(52, 324)
        Label4.Name = "Label4"
        Label4.Size = New Size(20, 17)
        Label4.TabIndex = 12
        Label4.Text = "孩"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(52, 282)
        Label5.Name = "Label5"
        Label5.Size = New Size(20, 17)
        Label5.TabIndex = 13
        Label5.Text = "全"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(229, 282)
        Label6.Name = "Label6"
        Label6.Size = New Size(20, 17)
        Label6.TabIndex = 14
        Label6.Text = "张"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(229, 324)
        Label7.Name = "Label7"
        Label7.Size = New Size(20, 17)
        Label7.TabIndex = 15
        Label7.Text = "张"
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(277, 280)
        Button2.Name = "Button2"
        Button2.Size = New Size(126, 65)
        Button2.TabIndex = 16
        Button2.Text = "计算，启动！"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("微软雅黑", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Label8.Location = New Point(422, 314)
        Label8.Name = "Label8"
        Label8.Size = New Size(86, 31)
        Label8.TabIndex = 17
        Label8.Text = "共计："
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point)
        Label9.Location = New Point(547, 303)
        Label9.Name = "Label9"
        Label9.Size = New Size(137, 45)
        Label9.TabIndex = 18
        Label9.Text = "1145.14"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("微软雅黑", 15F, FontStyle.Regular, GraphicsUnit.Point)
        Label10.Location = New Point(722, 318)
        Label10.Name = "Label10"
        Label10.Size = New Size(32, 27)
        Label10.TabIndex = 19
        Label10.Text = "元"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(316, 97)
        Label12.Name = "Label12"
        Label12.Size = New Size(332, 17)
        Label12.TabIndex = 21
        Label12.Text = "注意！因舍入方法与官方不同，本计算器不保证结果的准确。"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(316, 114)
        Label13.Name = "Label13"
        Label13.Size = New Size(320, 17)
        Label13.TabIndex = 22
        Label13.Text = "使用本计算器规划行程带来的后果，作者不承担任何责任！"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 17F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 376)
        Controls.Add(Label13)
        Controls.Add(Label12)
        Controls.Add(Label10)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(GroupBox2)
        Controls.Add(Button2)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(NumericUpDown2)
        Controls.Add(NumericUpDown1)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox1)
        Controls.Add(Label3)
        Controls.Add(TextBox1)
        Controls.Add(Label2)
        Controls.Add(Button1)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "普速票价计算器 By 1981东方红"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        CType(NumericUpDown1, ComponentModel.ISupportInitialize).EndInit()
        CType(NumericUpDown2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents RadioButton8 As RadioButton
    Friend WithEvents RadioButton7 As RadioButton
    Friend WithEvents RadioButton6 As RadioButton
    Friend WithEvents RadioButton5 As RadioButton
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents RadioButton9 As RadioButton
    Friend WithEvents RadioButton10 As RadioButton
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents RadioButton13 As RadioButton
    Friend WithEvents RadioButton12 As RadioButton
    Friend WithEvents RadioButton11 As RadioButton
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents NumericUpDown2 As NumericUpDown
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label

End Class
