<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GM1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GM1))
        Me.TextBox_q = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButton5 = New System.Windows.Forms.RadioButton()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.cmdExit = New System.Windows.Forms.Button()
        Me.cmdStart = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox_i1 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox_d1 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox_d2 = New System.Windows.Forms.TextBox()
        Me.TextBox_i2 = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Text_Time = New System.Windows.Forms.TextBox()
        Me.cmdHelp = New System.Windows.Forms.Button()
        Me.TextBox_Answ = New System.Windows.Forms.TextBox()
        Me.Button_Answer = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cmdStart_All = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBox_q
        '
        Me.TextBox_q.Location = New System.Drawing.Point(240, 29)
        Me.TextBox_q.Name = "TextBox_q"
        Me.TextBox_q.Size = New System.Drawing.Size(38, 20)
        Me.TextBox_q.TabIndex = 1
        Me.TextBox_q.Text = "5"
        Me.TextBox_q.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label2.Location = New System.Drawing.Point(180, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Questions تعداد سوال"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton5)
        Me.GroupBox1.Controls.Add(Me.RadioButton4)
        Me.GroupBox1.Controls.Add(Me.RadioButton3)
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(38, 31)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(129, 151)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Game: نوع بازي"
        '
        'RadioButton5
        '
        Me.RadioButton5.AutoSize = True
        Me.RadioButton5.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.RadioButton5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.RadioButton5.Location = New System.Drawing.Point(9, 120)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.Size = New System.Drawing.Size(104, 18)
        Me.RadioButton5.TabIndex = 11
        Me.RadioButton5.Text = "Random مختلف"
        Me.RadioButton5.UseVisualStyleBackColor = True
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.RadioButton4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.RadioButton4.Location = New System.Drawing.Point(9, 96)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(96, 18)
        Me.RadioButton4.TabIndex = 10
        Me.RadioButton4.Text = "Divide تقسيم"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.RadioButton3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.RadioButton3.Location = New System.Drawing.Point(9, 74)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(93, 18)
        Me.RadioButton3.TabIndex = 9
        Me.RadioButton3.Text = "Multiply ضرب"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.RadioButton2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.RadioButton2.Location = New System.Drawing.Point(9, 51)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(102, 18)
        Me.RadioButton2.TabIndex = 8
        Me.RadioButton2.Text = "Subtract تفريق"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Checked = True
        Me.RadioButton1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.RadioButton1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.RadioButton1.Location = New System.Drawing.Point(9, 28)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(73, 18)
        Me.RadioButton1.TabIndex = 7
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Add جمع"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'cmdExit
        '
        Me.cmdExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdExit.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.cmdExit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmdExit.Location = New System.Drawing.Point(321, 158)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(85, 22)
        Me.cmdExit.TabIndex = 13
        Me.cmdExit.Text = "Exit خروج"
        Me.cmdExit.UseVisualStyleBackColor = True
        '
        'cmdStart
        '
        Me.cmdStart.DialogResult = System.Windows.Forms.DialogResult.Yes
        Me.cmdStart.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.cmdStart.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmdStart.Location = New System.Drawing.Point(321, 122)
        Me.cmdStart.Name = "cmdStart"
        Me.cmdStart.Size = New System.Drawing.Size(85, 22)
        Me.cmdStart.TabIndex = 12
        Me.cmdStart.Text = "Start شروع"
        Me.cmdStart.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label3.Location = New System.Drawing.Point(38, 232)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(368, 63)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Operators"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label3.UseMnemonic = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label4.Location = New System.Drawing.Point(318, 50)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Integers"
        '
        'TextBox_i1
        '
        Me.TextBox_i1.Location = New System.Drawing.Point(323, 29)
        Me.TextBox_i1.Name = "TextBox_i1"
        Me.TextBox_i1.Size = New System.Drawing.Size(36, 20)
        Me.TextBox_i1.TabIndex = 3
        Me.TextBox_i1.Text = "2"
        Me.TextBox_i1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label5.Location = New System.Drawing.Point(366, 50)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Decimals"
        '
        'TextBox_d1
        '
        Me.TextBox_d1.Location = New System.Drawing.Point(370, 29)
        Me.TextBox_d1.Name = "TextBox_d1"
        Me.TextBox_d1.Size = New System.Drawing.Size(36, 20)
        Me.TextBox_d1.TabIndex = 4
        Me.TextBox_d1.Text = "0"
        Me.TextBox_d1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(28, 306)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 38)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "."
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBox_d2
        '
        Me.TextBox_d2.Location = New System.Drawing.Point(370, 81)
        Me.TextBox_d2.Name = "TextBox_d2"
        Me.TextBox_d2.Size = New System.Drawing.Size(36, 20)
        Me.TextBox_d2.TabIndex = 6
        Me.TextBox_d2.Text = "0"
        Me.TextBox_d2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox_i2
        '
        Me.TextBox_i2.Location = New System.Drawing.Point(323, 81)
        Me.TextBox_i2.Name = "TextBox_i2"
        Me.TextBox_i2.Size = New System.Drawing.Size(36, 20)
        Me.TextBox_i2.TabIndex = 5
        Me.TextBox_i2.Text = "1"
        Me.TextBox_i2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(73, 306)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(57, 38)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "."
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label9.Location = New System.Drawing.Point(194, 66)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(95, 13)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Total Time زمان کل"
        '
        'Text_Time
        '
        Me.Text_Time.Location = New System.Drawing.Point(240, 81)
        Me.Text_Time.Name = "Text_Time"
        Me.Text_Time.Size = New System.Drawing.Size(38, 20)
        Me.Text_Time.TabIndex = 2
        Me.Text_Time.Text = "0"
        Me.Text_Time.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmdHelp
        '
        Me.cmdHelp.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.cmdHelp.ForeColor = System.Drawing.Color.Green
        Me.cmdHelp.Location = New System.Drawing.Point(193, 158)
        Me.cmdHelp.Name = "cmdHelp"
        Me.cmdHelp.Size = New System.Drawing.Size(122, 22)
        Me.cmdHelp.TabIndex = 20
        Me.cmdHelp.Text = "Help"
        Me.cmdHelp.UseVisualStyleBackColor = True
        '
        'TextBox_Answ
        '
        Me.TextBox_Answ.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.TextBox_Answ.ForeColor = System.Drawing.Color.Blue
        Me.TextBox_Answ.Location = New System.Drawing.Point(136, 306)
        Me.TextBox_Answ.Name = "TextBox_Answ"
        Me.TextBox_Answ.Size = New System.Drawing.Size(166, 38)
        Me.TextBox_Answ.TabIndex = 21
        Me.TextBox_Answ.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button_Answer
        '
        Me.Button_Answer.BackColor = System.Drawing.Color.Transparent
        Me.Button_Answer.ForeColor = System.Drawing.Color.Transparent
        Me.Button_Answer.Location = New System.Drawing.Point(314, 333)
        Me.Button_Answer.Name = "Button_Answer"
        Me.Button_Answer.Size = New System.Drawing.Size(1, 1)
        Me.Button_Answer.TabIndex = 22
        Me.Button_Answer.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(308, 33)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(14, 13)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "A"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label10.Location = New System.Drawing.Point(373, 65)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(36, 13)
        Me.Label10.TabIndex = 25
        Me.Label10.Text = "اعشار"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label11.Location = New System.Drawing.Point(324, 65)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(35, 13)
        Me.Label11.TabIndex = 24
        Me.Label11.Text = "صحيح"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(308, 85)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(14, 13)
        Me.Label12.TabIndex = 26
        Me.Label12.Text = "B"
        '
        'cmdStart_All
        '
        Me.cmdStart_All.DialogResult = System.Windows.Forms.DialogResult.Yes
        Me.cmdStart_All.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.cmdStart_All.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmdStart_All.Location = New System.Drawing.Point(193, 120)
        Me.cmdStart_All.Name = "cmdStart_All"
        Me.cmdStart_All.Size = New System.Drawing.Size(122, 22)
        Me.cmdStart_All.TabIndex = 27
        Me.cmdStart_All.Text = "ShowAll نمايش همه"
        Me.cmdStart_All.UseVisualStyleBackColor = True
        '
        'GM1
        '
        Me.AcceptButton = Me.cmdStart
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdExit
        Me.ClientSize = New System.Drawing.Size(455, 369)
        Me.ControlBox = False
        Me.Controls.Add(Me.cmdStart_All)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Button_Answer)
        Me.Controls.Add(Me.TextBox_Answ)
        Me.Controls.Add(Me.cmdHelp)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Text_Time)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TextBox_d2)
        Me.Controls.Add(Me.TextBox_i2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBox_d1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox_i1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmdStart)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox_q)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "GM1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Operators"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox_q As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents cmdExit As Button
    Friend WithEvents cmdStart As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox_i1 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox_d1 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents TextBox_d2 As TextBox
    Friend WithEvents TextBox_i2 As TextBox
    Friend WithEvents RadioButton5 As RadioButton
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Text_Time As TextBox
    Friend WithEvents cmdHelp As Button
    Friend WithEvents TextBox_Answ As TextBox
    Friend WithEvents Button_Answer As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents cmdStart_All As Button
End Class
