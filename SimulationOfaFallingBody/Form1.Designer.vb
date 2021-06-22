<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
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

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.hEnd_text = New System.Windows.Forms.Label()
        Me.vEnd_text = New System.Windows.Forms.Label()
        Me.tEnd_text = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.k2_text = New System.Windows.Forms.Label()
        Me.mg_text = New System.Windows.Forms.Label()
        Me.enter_S = New System.Windows.Forms.TextBox()
        Me.enter_c = New System.Windows.Forms.TextBox()
        Me.enter_p = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.enter_step_time = New System.Windows.Forms.TextBox()
        Me.enter_m = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.hEnd_text)
        Me.GroupBox2.Controls.Add(Me.vEnd_text)
        Me.GroupBox2.Controls.Add(Me.tEnd_text)
        Me.GroupBox2.Location = New System.Drawing.Point(254, 93)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(294, 57)
        Me.GroupBox2.TabIndex = 44
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Найти"
        '
        'hEnd_text
        '
        Me.hEnd_text.AutoSize = True
        Me.hEnd_text.Location = New System.Drawing.Point(185, 26)
        Me.hEnd_text.Name = "hEnd_text"
        Me.hEnd_text.Size = New System.Drawing.Size(65, 17)
        Me.hEnd_text.TabIndex = 5
        Me.hEnd_text.Text = "hEnd = ?"
        '
        'vEnd_text
        '
        Me.vEnd_text.AutoSize = True
        Me.vEnd_text.Location = New System.Drawing.Point(94, 26)
        Me.vEnd_text.Name = "vEnd_text"
        Me.vEnd_text.Size = New System.Drawing.Size(64, 17)
        Me.vEnd_text.TabIndex = 4
        Me.vEnd_text.Text = "vEnd = ?"
        '
        'tEnd_text
        '
        Me.tEnd_text.AutoSize = True
        Me.tEnd_text.Location = New System.Drawing.Point(10, 26)
        Me.tEnd_text.Name = "tEnd_text"
        Me.tEnd_text.Size = New System.Drawing.Size(61, 17)
        Me.tEnd_text.TabIndex = 3
        Me.tEnd_text.Text = "tEnd = ?"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.k2_text)
        Me.GroupBox1.Controls.Add(Me.mg_text)
        Me.GroupBox1.Location = New System.Drawing.Point(254, 15)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 57)
        Me.GroupBox1.TabIndex = 43
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Промежуточные расчёты"
        '
        'k2_text
        '
        Me.k2_text.AutoSize = True
        Me.k2_text.Location = New System.Drawing.Point(94, 26)
        Me.k2_text.Name = "k2_text"
        Me.k2_text.Size = New System.Drawing.Size(23, 17)
        Me.k2_text.TabIndex = 9
        Me.k2_text.Text = "k2"
        '
        'mg_text
        '
        Me.mg_text.AutoSize = True
        Me.mg_text.Location = New System.Drawing.Point(10, 26)
        Me.mg_text.Name = "mg_text"
        Me.mg_text.Size = New System.Drawing.Size(27, 17)
        Me.mg_text.TabIndex = 5
        Me.mg_text.Text = "mg"
        '
        'enter_S
        '
        Me.enter_S.Location = New System.Drawing.Point(136, 128)
        Me.enter_S.Name = "enter_S"
        Me.enter_S.Size = New System.Drawing.Size(100, 22)
        Me.enter_S.TabIndex = 42
        '
        'enter_c
        '
        Me.enter_c.Location = New System.Drawing.Point(136, 100)
        Me.enter_c.Name = "enter_c"
        Me.enter_c.Size = New System.Drawing.Size(100, 22)
        Me.enter_c.TabIndex = 41
        '
        'enter_p
        '
        Me.enter_p.Location = New System.Drawing.Point(136, 70)
        Me.enter_p.Name = "enter_p"
        Me.enter_p.Size = New System.Drawing.Size(100, 22)
        Me.enter_p.TabIndex = 40
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 34)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "Шаг по " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "времени"
        '
        'enter_step_time
        '
        Me.enter_step_time.Location = New System.Drawing.Point(136, 42)
        Me.enter_step_time.Name = "enter_step_time"
        Me.enter_step_time.Size = New System.Drawing.Size(100, 22)
        Me.enter_step_time.TabIndex = 38
        '
        'enter_m
        '
        Me.enter_m.Location = New System.Drawing.Point(136, 12)
        Me.enter_m.Name = "enter_m"
        Me.enter_m.Size = New System.Drawing.Size(100, 22)
        Me.enter_m.TabIndex = 37
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(33, 131)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(17, 17)
        Me.Label9.TabIndex = 36
        Me.Label9.Text = "S"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(33, 103)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(15, 17)
        Me.Label8.TabIndex = 35
        Me.Label8.Text = "c"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(33, 75)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(16, 17)
        Me.Label7.TabIndex = 34
        Me.Label7.Text = "p"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(33, 15)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(19, 17)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "m"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(597, 173)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.enter_S)
        Me.Controls.Add(Me.enter_c)
        Me.Controls.Add(Me.enter_p)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.enter_step_time)
        Me.Controls.Add(Me.enter_m)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.MaximumSize = New System.Drawing.Size(615, 220)
        Me.MinimumSize = New System.Drawing.Size(615, 220)
        Me.Name = "Form1"
        Me.Text = "Калькулятор"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents hEnd_text As Label
    Friend WithEvents vEnd_text As Label
    Friend WithEvents tEnd_text As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents k2_text As Label
    Friend WithEvents mg_text As Label
    Friend WithEvents enter_S As TextBox
    Friend WithEvents enter_c As TextBox
    Friend WithEvents enter_p As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents enter_step_time As TextBox
    Friend WithEvents enter_m As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
End Class
