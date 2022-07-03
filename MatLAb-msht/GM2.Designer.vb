<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GM2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GM2))
        Me.cmd_Answ = New System.Windows.Forms.Button()
        Me.cmdHelp = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Text_Time = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.L1 = New System.Windows.Forms.Label()
        Me.cmdStart = New System.Windows.Forms.Button()
        Me.cmdExit = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtQ = New System.Windows.Forms.TextBox()
        Me.L2 = New System.Windows.Forms.Label()
        Me.L3 = New System.Windows.Forms.Label()
        Me.L4 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtLevel = New System.Windows.Forms.TextBox()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.TxtAnsw = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cmd_Answ
        '
        Me.cmd_Answ.BackColor = System.Drawing.Color.Transparent
        Me.cmd_Answ.CausesValidation = False
        Me.cmd_Answ.DialogResult = System.Windows.Forms.DialogResult.Yes
        Me.cmd_Answ.ForeColor = System.Drawing.Color.Transparent
        Me.cmd_Answ.Location = New System.Drawing.Point(621, 146)
        Me.cmd_Answ.Margin = New System.Windows.Forms.Padding(1)
        Me.cmd_Answ.Name = "cmd_Answ"
        Me.cmd_Answ.Size = New System.Drawing.Size(10, 10)
        Me.cmd_Answ.TabIndex = 47
        Me.cmd_Answ.UseVisualStyleBackColor = False
        '
        'cmdHelp
        '
        Me.cmdHelp.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.cmdHelp.ForeColor = System.Drawing.Color.Green
        Me.cmdHelp.Location = New System.Drawing.Point(512, 46)
        Me.cmdHelp.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdHelp.Name = "cmdHelp"
        Me.cmdHelp.Size = New System.Drawing.Size(119, 27)
        Me.cmdHelp.TabIndex = 45
        Me.cmdHelp.Text = "Help کمک"
        Me.cmdHelp.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(313, 88)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(109, 13)
        Me.Label9.TabIndex = 44
        Me.Label9.Text = "Time/Q زمان هر سوال"
        '
        'Text_Time
        '
        Me.Text_Time.Location = New System.Drawing.Point(428, 83)
        Me.Text_Time.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Text_Time.Name = "Text_Time"
        Me.Text_Time.Size = New System.Drawing.Size(44, 23)
        Me.Text_Time.TabIndex = 30
        Me.Text_Time.Text = "60"
        Me.Text_Time.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(208, 38)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 41)
        Me.Label8.TabIndex = 43
        Me.Label8.Text = "."
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(91, 39)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 38)
        Me.Label7.TabIndex = 42
        Me.Label7.Text = "."
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'L1
        '
        Me.L1.BackColor = System.Drawing.Color.White
        Me.L1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.L1.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.L1.ForeColor = System.Drawing.Color.Black
        Me.L1.Location = New System.Drawing.Point(9, 146)
        Me.L1.Name = "L1"
        Me.L1.Size = New System.Drawing.Size(119, 33)
        Me.L1.TabIndex = 37
        Me.L1.Text = "-"
        Me.L1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.L1.UseMnemonic = False
        '
        'cmdStart
        '
        Me.cmdStart.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.cmdStart.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmdStart.Location = New System.Drawing.Point(512, 11)
        Me.cmdStart.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdStart.Name = "cmdStart"
        Me.cmdStart.Size = New System.Drawing.Size(119, 27)
        Me.cmdStart.TabIndex = 39
        Me.cmdStart.Text = "Start شروع"
        Me.cmdStart.UseVisualStyleBackColor = True
        '
        'cmdExit
        '
        Me.cmdExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdExit.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.cmdExit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmdExit.Location = New System.Drawing.Point(512, 81)
        Me.cmdExit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(119, 27)
        Me.cmdExit.TabIndex = 41
        Me.cmdExit.Text = "Exit خروج"
        Me.cmdExit.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(312, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 13)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Questions تعداد سوال"
        '
        'txtQ
        '
        Me.txtQ.Location = New System.Drawing.Point(428, 48)
        Me.txtQ.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtQ.Name = "txtQ"
        Me.txtQ.Size = New System.Drawing.Size(44, 23)
        Me.txtQ.TabIndex = 28
        Me.txtQ.Text = "10"
        Me.txtQ.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'L2
        '
        Me.L2.BackColor = System.Drawing.Color.White
        Me.L2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.L2.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.L2.ForeColor = System.Drawing.Color.Black
        Me.L2.Location = New System.Drawing.Point(135, 146)
        Me.L2.Name = "L2"
        Me.L2.Size = New System.Drawing.Size(119, 33)
        Me.L2.TabIndex = 52
        Me.L2.Text = "-"
        Me.L2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.L2.UseMnemonic = False
        '
        'L3
        '
        Me.L3.BackColor = System.Drawing.Color.White
        Me.L3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.L3.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.L3.ForeColor = System.Drawing.Color.Black
        Me.L3.Location = New System.Drawing.Point(261, 146)
        Me.L3.Name = "L3"
        Me.L3.Size = New System.Drawing.Size(119, 33)
        Me.L3.TabIndex = 53
        Me.L3.Text = "-"
        Me.L3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.L3.UseMnemonic = False
        '
        'L4
        '
        Me.L4.BackColor = System.Drawing.Color.White
        Me.L4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.L4.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.L4.ForeColor = System.Drawing.Color.Black
        Me.L4.Location = New System.Drawing.Point(387, 146)
        Me.L4.Name = "L4"
        Me.L4.Size = New System.Drawing.Size(119, 33)
        Me.L4.TabIndex = 54
        Me.L4.Text = "-"
        Me.L4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.L4.UseMnemonic = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(360, 18)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 13)
        Me.Label4.TabIndex = 61
        Me.Label4.Text = "Level سطح"
        '
        'txtLevel
        '
        Me.txtLevel.Location = New System.Drawing.Point(428, 13)
        Me.txtLevel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtLevel.Name = "txtLevel"
        Me.txtLevel.Size = New System.Drawing.Size(44, 23)
        Me.txtLevel.TabIndex = 59
        Me.txtLevel.Text = "1"
        Me.txtLevel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Timer2
        '
        Me.Timer2.Interval = 1000
        '
        'TxtAnsw
        '
        Me.TxtAnsw.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.TxtAnsw.Location = New System.Drawing.Point(512, 146)
        Me.TxtAnsw.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtAnsw.Name = "TxtAnsw"
        Me.TxtAnsw.Size = New System.Drawing.Size(120, 33)
        Me.TxtAnsw.TabIndex = 62
        Me.TxtAnsw.Text = "-"
        Me.TxtAnsw.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(150, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 63
        Me.Label3.Text = "Time زمان"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(6, 51)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 13)
        Me.Label5.TabIndex = 64
        Me.Label5.Text = "Question سوال"
        '
        'GM2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(659, 206)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtAnsw)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtLevel)
        Me.Controls.Add(Me.L4)
        Me.Controls.Add(Me.L3)
        Me.Controls.Add(Me.L2)
        Me.Controls.Add(Me.cmd_Answ)
        Me.Controls.Add(Me.cmdHelp)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Text_Time)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.L1)
        Me.Controls.Add(Me.cmdStart)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtQ)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.ForeColor = System.Drawing.Color.Transparent
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "GM2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Patterns"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmd_Answ As Button
    Friend WithEvents cmdHelp As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Text_Time As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents L1 As Label
    Friend WithEvents cmdStart As Button
    Friend WithEvents cmdExit As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtQ As TextBox
    Friend WithEvents L2 As Label
    Friend WithEvents L3 As Label
    Friend WithEvents L4 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtLevel As TextBox
    Friend WithEvents Timer2 As Timer
    Friend WithEvents TxtAnsw As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
End Class
