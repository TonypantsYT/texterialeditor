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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MaterialFlatButton6 = New MaterialSkin.Controls.MaterialFlatButton()
        Me.MaterialFlatButton5 = New MaterialSkin.Controls.MaterialFlatButton()
        Me.MaterialFlatButton3 = New MaterialSkin.Controls.MaterialFlatButton()
        Me.MaterialFlatButton4 = New MaterialSkin.Controls.MaterialFlatButton()
        Me.MaterialFlatButton2 = New MaterialSkin.Controls.MaterialFlatButton()
        Me.MaterialFlatButton1 = New MaterialSkin.Controls.MaterialFlatButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel1.Controls.Add(Me.MaterialFlatButton6)
        Me.Panel1.Controls.Add(Me.MaterialFlatButton5)
        Me.Panel1.Controls.Add(Me.MaterialFlatButton3)
        Me.Panel1.Controls.Add(Me.MaterialFlatButton4)
        Me.Panel1.Controls.Add(Me.MaterialFlatButton2)
        Me.Panel1.Controls.Add(Me.MaterialFlatButton1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(824, 105)
        Me.Panel1.TabIndex = 0
        '
        'MaterialFlatButton6
        '
        Me.MaterialFlatButton6.AutoSize = True
        Me.MaterialFlatButton6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MaterialFlatButton6.BackColor = System.Drawing.Color.Red
        Me.MaterialFlatButton6.Depth = 0
        Me.MaterialFlatButton6.Location = New System.Drawing.Point(693, 6)
        Me.MaterialFlatButton6.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.MaterialFlatButton6.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialFlatButton6.Name = "MaterialFlatButton6"
        Me.MaterialFlatButton6.Primary = False
        Me.MaterialFlatButton6.Size = New System.Drawing.Size(73, 36)
        Me.MaterialFlatButton6.TabIndex = 5
        Me.MaterialFlatButton6.Text = "MINIMISE"
        Me.MaterialFlatButton6.UseVisualStyleBackColor = False
        '
        'MaterialFlatButton5
        '
        Me.MaterialFlatButton5.AutoSize = True
        Me.MaterialFlatButton5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MaterialFlatButton5.BackColor = System.Drawing.Color.Red
        Me.MaterialFlatButton5.Depth = 0
        Me.MaterialFlatButton5.Location = New System.Drawing.Point(766, 6)
        Me.MaterialFlatButton5.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.MaterialFlatButton5.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialFlatButton5.Name = "MaterialFlatButton5"
        Me.MaterialFlatButton5.Primary = False
        Me.MaterialFlatButton5.Size = New System.Drawing.Size(54, 36)
        Me.MaterialFlatButton5.TabIndex = 4
        Me.MaterialFlatButton5.Text = "CLOSE"
        Me.MaterialFlatButton5.UseVisualStyleBackColor = False
        '
        'MaterialFlatButton3
        '
        Me.MaterialFlatButton3.AutoSize = True
        Me.MaterialFlatButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MaterialFlatButton3.Depth = 0
        Me.MaterialFlatButton3.Location = New System.Drawing.Point(462, 55)
        Me.MaterialFlatButton3.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.MaterialFlatButton3.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialFlatButton3.Name = "MaterialFlatButton3"
        Me.MaterialFlatButton3.Primary = False
        Me.MaterialFlatButton3.Size = New System.Drawing.Size(65, 36)
        Me.MaterialFlatButton3.TabIndex = 2
        Me.MaterialFlatButton3.Text = "Colour"
        Me.MaterialFlatButton3.UseVisualStyleBackColor = True
        '
        'MaterialFlatButton4
        '
        Me.MaterialFlatButton4.AutoSize = True
        Me.MaterialFlatButton4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MaterialFlatButton4.Depth = 0
        Me.MaterialFlatButton4.Location = New System.Drawing.Point(407, 55)
        Me.MaterialFlatButton4.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.MaterialFlatButton4.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialFlatButton4.Name = "MaterialFlatButton4"
        Me.MaterialFlatButton4.Primary = False
        Me.MaterialFlatButton4.Size = New System.Drawing.Size(47, 36)
        Me.MaterialFlatButton4.TabIndex = 3
        Me.MaterialFlatButton4.Text = "Font"
        Me.MaterialFlatButton4.UseVisualStyleBackColor = True
        '
        'MaterialFlatButton2
        '
        Me.MaterialFlatButton2.AutoSize = True
        Me.MaterialFlatButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MaterialFlatButton2.Depth = 0
        Me.MaterialFlatButton2.Location = New System.Drawing.Point(353, 55)
        Me.MaterialFlatButton2.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.MaterialFlatButton2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialFlatButton2.Name = "MaterialFlatButton2"
        Me.MaterialFlatButton2.Primary = False
        Me.MaterialFlatButton2.Size = New System.Drawing.Size(46, 36)
        Me.MaterialFlatButton2.TabIndex = 1
        Me.MaterialFlatButton2.Text = "Save"
        Me.MaterialFlatButton2.UseVisualStyleBackColor = True
        '
        'MaterialFlatButton1
        '
        Me.MaterialFlatButton1.AutoSize = True
        Me.MaterialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MaterialFlatButton1.Depth = 0
        Me.MaterialFlatButton1.Location = New System.Drawing.Point(297, 55)
        Me.MaterialFlatButton1.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.MaterialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialFlatButton1.Name = "MaterialFlatButton1"
        Me.MaterialFlatButton1.Primary = False
        Me.MaterialFlatButton1.Size = New System.Drawing.Size(48, 36)
        Me.MaterialFlatButton1.TabIndex = 1
        Me.MaterialFlatButton1.Text = "Open"
        Me.MaterialFlatButton1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Roboto Thin", 24.0!)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(346, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 38)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Texterial"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RichTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox1.ForeColor = System.Drawing.Color.White
        Me.RichTextBox1.Location = New System.Drawing.Point(0, 105)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(824, 463)
        Me.RichTextBox1.TabIndex = 1
        Me.RichTextBox1.Text = ""
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Filter = "RTF file|*.rtf|All files|*.*"
        Me.OpenFileDialog1.Title = "Open a file:"
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.Filter = "RTF file|*.rtf|All files|*.*"
        Me.SaveFileDialog1.InitialDirectory = "Desktop"
        Me.SaveFileDialog1.Title = "Save a file:"
        '
        'FontDialog1
        '
        Me.FontDialog1.Color = System.Drawing.Color.White
        Me.FontDialog1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FontDialog1.FontMustExist = True
        Me.FontDialog1.ShowApply = True
        Me.FontDialog1.ShowColor = True
        '
        'ColorDialog1
        '
        Me.ColorDialog1.AnyColor = True
        Me.ColorDialog1.Color = System.Drawing.Color.White
        Me.ColorDialog1.FullOpen = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(824, 568)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Texterial"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents MaterialFlatButton3 As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents MaterialFlatButton4 As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents MaterialFlatButton2 As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents MaterialFlatButton1 As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents MaterialFlatButton6 As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents MaterialFlatButton5 As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents FontDialog1 As FontDialog
    Friend WithEvents ColorDialog1 As ColorDialog
End Class
