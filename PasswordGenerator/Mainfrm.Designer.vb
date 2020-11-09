Imports PasswordGenerator

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Mainfrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Mainfrm))
        Me.Passwordbtn = New MaterialSkin.Controls.MaterialFlatButton()
        Me.Mincharacterlengthtxt = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.dontincludenumradio = New MaterialSkin.Controls.MaterialRadioButton()
        Me.includenumradio = New MaterialSkin.Controls.MaterialRadioButton()
        Me.MaterialLabel4 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel5 = New MaterialSkin.Controls.MaterialLabel()
        Me.Maxcharacterlengthtxt = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.IncludeNumbersGroup = New System.Windows.Forms.GroupBox()
        Me.LetterCaseGroup = New System.Windows.Forms.GroupBox()
        Me.Lowercaseletterchk = New MaterialSkin.Controls.MaterialCheckBox()
        Me.Uppercaseletterchk = New MaterialSkin.Controls.MaterialCheckBox()
        Me.PasswordLengthGroup = New System.Windows.Forms.GroupBox()
        Me.Passwordlbl = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.IncludeNumbersGroup.SuspendLayout()
        Me.LetterCaseGroup.SuspendLayout()
        Me.PasswordLengthGroup.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Passwordbtn
        '
        Me.Passwordbtn.AutoSize = True
        Me.Passwordbtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Passwordbtn.Depth = 0
        Me.Passwordbtn.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Passwordbtn.Location = New System.Drawing.Point(0, 373)
        Me.Passwordbtn.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.Passwordbtn.MouseState = MaterialSkin.MouseState.HOVER
        Me.Passwordbtn.Name = "Passwordbtn"
        Me.Passwordbtn.Primary = False
        Me.Passwordbtn.Size = New System.Drawing.Size(375, 36)
        Me.Passwordbtn.TabIndex = 1
        Me.Passwordbtn.Text = "Generate Password"
        Me.Passwordbtn.UseVisualStyleBackColor = True
        '
        'Mincharacterlengthtxt
        '
        Me.Mincharacterlengthtxt.Depth = 0
        Me.Mincharacterlengthtxt.Hint = ""
        Me.Mincharacterlengthtxt.Location = New System.Drawing.Point(121, 23)
        Me.Mincharacterlengthtxt.Margin = New System.Windows.Forms.Padding(4)
        Me.Mincharacterlengthtxt.MouseState = MaterialSkin.MouseState.HOVER
        Me.Mincharacterlengthtxt.Name = "Mincharacterlengthtxt"
        Me.Mincharacterlengthtxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Mincharacterlengthtxt.SelectedText = ""
        Me.Mincharacterlengthtxt.SelectionLength = 0
        Me.Mincharacterlengthtxt.SelectionStart = 0
        Me.Mincharacterlengthtxt.Size = New System.Drawing.Size(40, 28)
        Me.Mincharacterlengthtxt.TabIndex = 4
        Me.Mincharacterlengthtxt.Text = "5"
        Me.Mincharacterlengthtxt.UseSystemPasswordChar = False
        '
        'dontincludenumradio
        '
        Me.dontincludenumradio.AutoSize = True
        Me.dontincludenumradio.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.dontincludenumradio.Depth = 0
        Me.dontincludenumradio.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.dontincludenumradio.Location = New System.Drawing.Point(201, 23)
        Me.dontincludenumradio.Margin = New System.Windows.Forms.Padding(0)
        Me.dontincludenumradio.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.dontincludenumradio.MouseState = MaterialSkin.MouseState.HOVER
        Me.dontincludenumradio.Name = "dontincludenumradio"
        Me.dontincludenumradio.Ripple = True
        Me.dontincludenumradio.Size = New System.Drawing.Size(52, 30)
        Me.dontincludenumradio.TabIndex = 11
        Me.dontincludenumradio.Text = "No"
        Me.dontincludenumradio.UseVisualStyleBackColor = False
        '
        'includenumradio
        '
        Me.includenumradio.AutoSize = True
        Me.includenumradio.BackColor = System.Drawing.Color.Transparent
        Me.includenumradio.Checked = True
        Me.includenumradio.Depth = 0
        Me.includenumradio.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.includenumradio.Location = New System.Drawing.Point(102, 23)
        Me.includenumradio.Margin = New System.Windows.Forms.Padding(0)
        Me.includenumradio.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.includenumradio.MouseState = MaterialSkin.MouseState.HOVER
        Me.includenumradio.Name = "includenumradio"
        Me.includenumradio.Ripple = True
        Me.includenumradio.Size = New System.Drawing.Size(59, 30)
        Me.includenumradio.TabIndex = 9
        Me.includenumradio.TabStop = True
        Me.includenumradio.Text = "Yes"
        Me.includenumradio.UseVisualStyleBackColor = False
        '
        'MaterialLabel4
        '
        Me.MaterialLabel4.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.MaterialLabel4.BackColor = System.Drawing.Color.Transparent
        Me.MaterialLabel4.Depth = 0
        Me.MaterialLabel4.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel4.Location = New System.Drawing.Point(8, 23)
        Me.MaterialLabel4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MaterialLabel4.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel4.Name = "MaterialLabel4"
        Me.MaterialLabel4.Size = New System.Drawing.Size(105, 26)
        Me.MaterialLabel4.TabIndex = 12
        Me.MaterialLabel4.Text = "Minimum:"
        '
        'MaterialLabel5
        '
        Me.MaterialLabel5.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.MaterialLabel5.BackColor = System.Drawing.Color.Transparent
        Me.MaterialLabel5.Depth = 0
        Me.MaterialLabel5.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel5.Location = New System.Drawing.Point(197, 25)
        Me.MaterialLabel5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MaterialLabel5.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel5.Name = "MaterialLabel5"
        Me.MaterialLabel5.Size = New System.Drawing.Size(105, 26)
        Me.MaterialLabel5.TabIndex = 14
        Me.MaterialLabel5.Text = "Maximum:"
        '
        'Maxcharacterlengthtxt
        '
        Me.Maxcharacterlengthtxt.Depth = 0
        Me.Maxcharacterlengthtxt.Hint = ""
        Me.Maxcharacterlengthtxt.Location = New System.Drawing.Point(310, 23)
        Me.Maxcharacterlengthtxt.Margin = New System.Windows.Forms.Padding(4)
        Me.Maxcharacterlengthtxt.MouseState = MaterialSkin.MouseState.HOVER
        Me.Maxcharacterlengthtxt.Name = "Maxcharacterlengthtxt"
        Me.Maxcharacterlengthtxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Maxcharacterlengthtxt.SelectedText = ""
        Me.Maxcharacterlengthtxt.SelectionLength = 0
        Me.Maxcharacterlengthtxt.SelectionStart = 0
        Me.Maxcharacterlengthtxt.Size = New System.Drawing.Size(41, 28)
        Me.Maxcharacterlengthtxt.TabIndex = 13
        Me.Maxcharacterlengthtxt.Text = "10"
        Me.Maxcharacterlengthtxt.UseSystemPasswordChar = False
        '
        'IncludeNumbersGroup
        '
        Me.IncludeNumbersGroup.BackgroundImage = Global.PasswordGenerator.My.Resources.Resources.background_ornament_red_by_dereque
        Me.IncludeNumbersGroup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.IncludeNumbersGroup.Controls.Add(Me.dontincludenumradio)
        Me.IncludeNumbersGroup.Controls.Add(Me.includenumradio)
        Me.IncludeNumbersGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IncludeNumbersGroup.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IncludeNumbersGroup.ForeColor = System.Drawing.Color.Lime
        Me.IncludeNumbersGroup.Location = New System.Drawing.Point(0, 157)
        Me.IncludeNumbersGroup.Margin = New System.Windows.Forms.Padding(4)
        Me.IncludeNumbersGroup.Name = "IncludeNumbersGroup"
        Me.IncludeNumbersGroup.Padding = New System.Windows.Forms.Padding(4)
        Me.IncludeNumbersGroup.Size = New System.Drawing.Size(379, 72)
        Me.IncludeNumbersGroup.TabIndex = 15
        Me.IncludeNumbersGroup.TabStop = False
        Me.IncludeNumbersGroup.Text = "Include Numers?"
        '
        'LetterCaseGroup
        '
        Me.LetterCaseGroup.BackgroundImage = Global.PasswordGenerator.My.Resources.Resources.background_ornament_red_by_dereque
        Me.LetterCaseGroup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.LetterCaseGroup.Controls.Add(Me.Lowercaseletterchk)
        Me.LetterCaseGroup.Controls.Add(Me.Uppercaseletterchk)
        Me.LetterCaseGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LetterCaseGroup.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LetterCaseGroup.ForeColor = System.Drawing.Color.Lime
        Me.LetterCaseGroup.Location = New System.Drawing.Point(0, 228)
        Me.LetterCaseGroup.Margin = New System.Windows.Forms.Padding(4)
        Me.LetterCaseGroup.Name = "LetterCaseGroup"
        Me.LetterCaseGroup.Padding = New System.Windows.Forms.Padding(4)
        Me.LetterCaseGroup.Size = New System.Drawing.Size(379, 69)
        Me.LetterCaseGroup.TabIndex = 16
        Me.LetterCaseGroup.TabStop = False
        Me.LetterCaseGroup.Text = "Letter Case(s)"
        '
        'Lowercaseletterchk
        '
        Me.Lowercaseletterchk.AutoSize = True
        Me.Lowercaseletterchk.BackColor = System.Drawing.Color.White
        Me.Lowercaseletterchk.Depth = 0
        Me.Lowercaseletterchk.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.Lowercaseletterchk.Location = New System.Drawing.Point(201, 22)
        Me.Lowercaseletterchk.Margin = New System.Windows.Forms.Padding(0)
        Me.Lowercaseletterchk.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.Lowercaseletterchk.MouseState = MaterialSkin.MouseState.HOVER
        Me.Lowercaseletterchk.Name = "Lowercaseletterchk"
        Me.Lowercaseletterchk.Ripple = True
        Me.Lowercaseletterchk.Size = New System.Drawing.Size(121, 30)
        Me.Lowercaseletterchk.TabIndex = 1
        Me.Lowercaseletterchk.Text = "Lower Case"
        Me.Lowercaseletterchk.UseVisualStyleBackColor = False
        '
        'Uppercaseletterchk
        '
        Me.Uppercaseletterchk.AutoSize = True
        Me.Uppercaseletterchk.Depth = 0
        Me.Uppercaseletterchk.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.Uppercaseletterchk.Location = New System.Drawing.Point(41, 22)
        Me.Uppercaseletterchk.Margin = New System.Windows.Forms.Padding(0)
        Me.Uppercaseletterchk.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.Uppercaseletterchk.MouseState = MaterialSkin.MouseState.HOVER
        Me.Uppercaseletterchk.Name = "Uppercaseletterchk"
        Me.Uppercaseletterchk.Ripple = True
        Me.Uppercaseletterchk.Size = New System.Drawing.Size(120, 30)
        Me.Uppercaseletterchk.TabIndex = 0
        Me.Uppercaseletterchk.Text = "Upper Case"
        Me.Uppercaseletterchk.UseVisualStyleBackColor = True
        '
        'PasswordLengthGroup
        '
        Me.PasswordLengthGroup.BackgroundImage = Global.PasswordGenerator.My.Resources.Resources.background_ornament_red_by_dereque
        Me.PasswordLengthGroup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PasswordLengthGroup.Controls.Add(Me.MaterialLabel5)
        Me.PasswordLengthGroup.Controls.Add(Me.Mincharacterlengthtxt)
        Me.PasswordLengthGroup.Controls.Add(Me.MaterialLabel4)
        Me.PasswordLengthGroup.Controls.Add(Me.Maxcharacterlengthtxt)
        Me.PasswordLengthGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PasswordLengthGroup.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordLengthGroup.ForeColor = System.Drawing.Color.Lime
        Me.PasswordLengthGroup.Location = New System.Drawing.Point(0, 89)
        Me.PasswordLengthGroup.Margin = New System.Windows.Forms.Padding(4)
        Me.PasswordLengthGroup.Name = "PasswordLengthGroup"
        Me.PasswordLengthGroup.Padding = New System.Windows.Forms.Padding(4)
        Me.PasswordLengthGroup.Size = New System.Drawing.Size(379, 71)
        Me.PasswordLengthGroup.TabIndex = 17
        Me.PasswordLengthGroup.TabStop = False
        Me.PasswordLengthGroup.Text = "Password Length"
        '
        'Passwordlbl
        '
        Me.Passwordlbl.BackColor = System.Drawing.SystemColors.Control
        Me.Passwordlbl.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Passwordlbl.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Passwordlbl.Location = New System.Drawing.Point(0, 315)
        Me.Passwordlbl.Margin = New System.Windows.Forms.Padding(4)
        Me.Passwordlbl.Name = "Passwordlbl"
        Me.Passwordlbl.ReadOnly = True
        Me.Passwordlbl.Size = New System.Drawing.Size(379, 23)
        Me.Passwordlbl.TabIndex = 18
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.PasswordGenerator.My.Resources.Resources.extit
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(48, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(113, 42)
        Me.PictureBox1.TabIndex = 19
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.PasswordGenerator.My.Resources.Resources.info
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(201, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(121, 42)
        Me.PictureBox2.TabIndex = 20
        Me.PictureBox2.TabStop = False
        '
        'Mainfrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PasswordGenerator.My.Resources.Resources._80s_Retro_Sci_Fi_Background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(375, 409)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Passwordlbl)
        Me.Controls.Add(Me.LetterCaseGroup)
        Me.Controls.Add(Me.PasswordLengthGroup)
        Me.Controls.Add(Me.IncludeNumbersGroup)
        Me.Controls.Add(Me.Passwordbtn)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Mainfrm"
        Me.Opacity = 0.85R
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.IncludeNumbersGroup.ResumeLayout(False)
        Me.IncludeNumbersGroup.PerformLayout()
        Me.LetterCaseGroup.ResumeLayout(False)
        Me.LetterCaseGroup.PerformLayout()
        Me.PasswordLengthGroup.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Passwordbtn As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents Mincharacterlengthtxt As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents dontincludenumradio As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents includenumradio As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents MaterialLabel4 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel5 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents Maxcharacterlengthtxt As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents IncludeNumbersGroup As GroupBox
    Friend WithEvents LetterCaseGroup As GroupBox
    Friend WithEvents PasswordLengthGroup As GroupBox
    Friend WithEvents Lowercaseletterchk As MaterialSkin.Controls.MaterialCheckBox
    Friend WithEvents Uppercaseletterchk As MaterialSkin.Controls.MaterialCheckBox
    Friend WithEvents Passwordlbl As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
End Class
