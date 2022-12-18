<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.txtbox2 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.ImageMagnifier1 = New ImageMagnifier.ImageMagnifier()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.ImageMagnifier = New ImageMagnifier.ImageMagnifier()
        Me.txtboxOut = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.TextBox1.ForeColor = System.Drawing.SystemColors.Info
        Me.TextBox1.Location = New System.Drawing.Point(175, 59)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(291, 137)
        Me.TextBox1.TabIndex = 75
        Me.TextBox1.Text = "FILE MUST BE:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "BMP" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "16x8 Pixels" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "1-Bit MonoChrome" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Only Black and White Colors"
        '
        'txtbox2
        '
        Me.txtbox2.BackColor = System.Drawing.Color.Black
        Me.txtbox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbox2.ForeColor = System.Drawing.Color.LightGreen
        Me.txtbox2.Location = New System.Drawing.Point(11, 13)
        Me.txtbox2.Margin = New System.Windows.Forms.Padding(4)
        Me.txtbox2.Name = "txtbox2"
        Me.txtbox2.ReadOnly = True
        Me.txtbox2.Size = New System.Drawing.Size(928, 39)
        Me.txtbox2.TabIndex = 76
        Me.txtbox2.Text = "C:\"
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.Black
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.ForeColor = System.Drawing.Color.LimeGreen
        Me.TextBox2.Location = New System.Drawing.Point(1142, 760)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(94, 16)
        Me.TextBox2.TabIndex = 79
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Snow
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Location = New System.Drawing.Point(165, 698)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(141, 66)
        Me.Button4.TabIndex = 81
        Me.Button4.Text = "Clear"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'TextBox5
        '
        Me.TextBox5.BackColor = System.Drawing.Color.Black
        Me.TextBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.14286!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.ForeColor = System.Drawing.Color.GreenYellow
        Me.TextBox5.Location = New System.Drawing.Point(19, 232)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(366, 77)
        Me.TextBox5.TabIndex = 86
        '
        'ImageMagnifier1
        '
        Me.ImageMagnifier1.BackColor = System.Drawing.Color.Black
        Me.ImageMagnifier1.ForeColor = System.Drawing.Color.Black
        Me.ImageMagnifier1.ImageToMagnify = Nothing
        Me.ImageMagnifier1.Location = New System.Drawing.Point(19, 59)
        Me.ImageMagnifier1.MagnificationCoefficient = 5
        Me.ImageMagnifier1.Name = "ImageMagnifier1"
        Me.ImageMagnifier1.Size = New System.Drawing.Size(149, 144)
        Me.ImageMagnifier1.TabIndex = 87
        Me.ImageMagnifier1.Text = "ImageMagnifier1"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.SteelBlue
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(946, 8)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(143, 49)
        Me.Button2.TabIndex = 88
        Me.Button2.Text = "Open BMP"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button3.Location = New System.Drawing.Point(946, 74)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(143, 55)
        Me.Button3.TabIndex = 89
        Me.Button3.Text = "Save BMP"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.DimGray
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button6.Location = New System.Drawing.Point(325, 698)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(141, 66)
        Me.Button6.TabIndex = 90
        Me.Button6.Text = "Fill"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Orange
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(1038, 653)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(192, 49)
        Me.Button1.TabIndex = 91
        Me.Button1.Text = "Copy to Clipboard"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.857143!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.ForeColor = System.Drawing.Color.DarkOrange
        Me.TextBox3.Location = New System.Drawing.Point(651, 286)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(169, 34)
        Me.TextBox3.TabIndex = 92
        Me.TextBox3.Text = "Bitmap"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(646, 258)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 25)
        Me.Label1.TabIndex = 93
        Me.Label1.Text = "Array Name"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Checked = True
        Me.CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox1.Location = New System.Drawing.Point(498, 74)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(269, 29)
        Me.CheckBox1.TabIndex = 94
        Me.CheckBox1.Text = "Starios Dense Panel Mask"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'ImageMagnifier
        '
        Me.ImageMagnifier.BackColor = System.Drawing.Color.SlateBlue
        Me.ImageMagnifier.Cursor = System.Windows.Forms.Cursors.Cross
        Me.ImageMagnifier.ImageToMagnify = Global.bitmapperdraw.My.Resources.Resources.asset1
        Me.ImageMagnifier.Location = New System.Drawing.Point(19, 338)
        Me.ImageMagnifier.MagnificationCoefficient = 20
        Me.ImageMagnifier.Name = "ImageMagnifier"
        Me.ImageMagnifier.Size = New System.Drawing.Size(320, 160)
        Me.ImageMagnifier.TabIndex = 85
        Me.ImageMagnifier.Text = "ImageMagnifier1"
        '
        'txtboxOut
        '
        Me.txtboxOut.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txtboxOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.857143!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtboxOut.ForeColor = System.Drawing.Color.DarkOrange
        Me.txtboxOut.Location = New System.Drawing.Point(651, 344)
        Me.txtboxOut.Margin = New System.Windows.Forms.Padding(4)
        Me.txtboxOut.Multiline = True
        Me.txtboxOut.Name = "txtboxOut"
        Me.txtboxOut.Size = New System.Drawing.Size(585, 293)
        Me.txtboxOut.TabIndex = 95
        Me.txtboxOut.Text = "OUTPUT HEX"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.DarkMagenta
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1245, 801)
        Me.Controls.Add(Me.txtboxOut)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.ImageMagnifier1)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.ImageMagnifier)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.txtbox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.Name = "Form1"
        Me.Text = "Starios Dense (8x16 bitmap to Hex + Draw)"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents txtbox2 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button4 As Button
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents ImageMagnifier1 As ImageMagnifier.ImageMagnifier
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents ImageMagnifier As ImageMagnifier.ImageMagnifier
    Friend WithEvents txtboxOut As TextBox
End Class
