<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMain
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.dbg_CTRL_A_Hold = New System.Windows.Forms.Label()
        Me.TimerClipboard = New System.Windows.Forms.Timer(Me.components)
        Me.dbg_TxtItemInfo = New System.Windows.Forms.TextBox()
        Me.TimerAutoMode = New System.Windows.Forms.Timer(Me.components)
        Me.dbg_RectAutomode = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PicChkBoxAutoMode = New System.Windows.Forms.PictureBox()
        Me.PicOptions = New System.Windows.Forms.PictureBox()
        Me.PicClosing = New System.Windows.Forms.PictureBox()
        Me.lblVersion = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LblThreadPost = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblNewVersionAvailable = New System.Windows.Forms.Label()
        CType(Me.PicChkBoxAutoMode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicOptions, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicClosing, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dbg_CTRL_A_Hold
        '
        Me.dbg_CTRL_A_Hold.AutoSize = True
        Me.dbg_CTRL_A_Hold.Location = New System.Drawing.Point(564, 9)
        Me.dbg_CTRL_A_Hold.Name = "dbg_CTRL_A_Hold"
        Me.dbg_CTRL_A_Hold.Size = New System.Drawing.Size(100, 13)
        Me.dbg_CTRL_A_Hold.TabIndex = 0
        Me.dbg_CTRL_A_Hold.Text = "dbg_CTRL_A_Hold"
        Me.dbg_CTRL_A_Hold.Visible = False
        '
        'TimerClipboard
        '
        '
        'dbg_TxtItemInfo
        '
        Me.dbg_TxtItemInfo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.dbg_TxtItemInfo.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dbg_TxtItemInfo.Location = New System.Drawing.Point(566, 39)
        Me.dbg_TxtItemInfo.Multiline = True
        Me.dbg_TxtItemInfo.Name = "dbg_TxtItemInfo"
        Me.dbg_TxtItemInfo.ReadOnly = True
        Me.dbg_TxtItemInfo.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.dbg_TxtItemInfo.Size = New System.Drawing.Size(96, 178)
        Me.dbg_TxtItemInfo.TabIndex = 4
        Me.dbg_TxtItemInfo.Visible = False
        '
        'TimerAutoMode
        '
        Me.TimerAutoMode.Interval = 500
        '
        'dbg_RectAutomode
        '
        Me.dbg_RectAutomode.AutoSize = True
        Me.dbg_RectAutomode.Location = New System.Drawing.Point(563, 23)
        Me.dbg_RectAutomode.Name = "dbg_RectAutomode"
        Me.dbg_RectAutomode.Size = New System.Drawing.Size(102, 13)
        Me.dbg_RectAutomode.TabIndex = 6
        Me.dbg_RectAutomode.Text = "dbg_RectAutomode"
        Me.dbg_RectAutomode.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Cambria", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(66, 301)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(438, 28)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Always Show Sockets (colorblind trick)"
        '
        'PicChkBoxAutoMode
        '
        Me.PicChkBoxAutoMode.BackColor = System.Drawing.Color.Transparent
        Me.PicChkBoxAutoMode.Image = Global.PoE_colorBlind.My.Resources.Resources.UnChecked
        Me.PicChkBoxAutoMode.Location = New System.Drawing.Point(25, 298)
        Me.PicChkBoxAutoMode.Name = "PicChkBoxAutoMode"
        Me.PicChkBoxAutoMode.Size = New System.Drawing.Size(35, 35)
        Me.PicChkBoxAutoMode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PicChkBoxAutoMode.TabIndex = 10
        Me.PicChkBoxAutoMode.TabStop = False
        '
        'PicOptions
        '
        Me.PicOptions.Image = Global.PoE_colorBlind.My.Resources.Resources.OptionsDark
        Me.PicOptions.Location = New System.Drawing.Point(25, 232)
        Me.PicOptions.Name = "PicOptions"
        Me.PicOptions.Size = New System.Drawing.Size(303, 38)
        Me.PicOptions.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PicOptions.TabIndex = 9
        Me.PicOptions.TabStop = False
        '
        'PicClosing
        '
        Me.PicClosing.BackColor = System.Drawing.Color.Transparent
        Me.PicClosing.Image = Global.PoE_colorBlind.My.Resources.Resources.ClosingDark
        Me.PicClosing.Location = New System.Drawing.Point(758, 12)
        Me.PicClosing.Name = "PicClosing"
        Me.PicClosing.Size = New System.Drawing.Size(30, 30)
        Me.PicClosing.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PicClosing.TabIndex = 12
        Me.PicClosing.TabStop = False
        '
        'lblVersion
        '
        Me.lblVersion.AutoSize = True
        Me.lblVersion.BackColor = System.Drawing.Color.Transparent
        Me.lblVersion.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVersion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(175, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.lblVersion.Location = New System.Drawing.Point(20, 74)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(85, 15)
        Me.lblVersion.TabIndex = 13
        Me.lblVersion.Text = "version x.x.x.x"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(175, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(20, 376)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 15)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Thread:"
        '
        'LblThreadPost
        '
        Me.LblThreadPost.AutoSize = True
        Me.LblThreadPost.BackColor = System.Drawing.Color.Transparent
        Me.LblThreadPost.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblThreadPost.ForeColor = System.Drawing.Color.FromArgb(CType(CType(175, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.LblThreadPost.Location = New System.Drawing.Point(68, 376)
        Me.LblThreadPost.Name = "LblThreadPost"
        Me.LblThreadPost.Size = New System.Drawing.Size(337, 15)
        Me.LblThreadPost.TabIndex = 15
        Me.LblThreadPost.Text = "https://www.pathofexile.com/forum/view-thread/2050144"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.PoE_colorBlind.My.Resources.Resources.achi36
        Me.PictureBox1.Location = New System.Drawing.Point(642, 331)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(22, 22)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.PoE_colorBlind.My.Resources.Resources.achi40
        Me.PictureBox2.Location = New System.Drawing.Point(642, 369)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(22, 22)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 17
        Me.PictureBox2.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(175, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(670, 331)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 19)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "ollydbg"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(175, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(670, 369)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 19)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Lizenen"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(175, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(638, 309)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 15)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Coded by:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(175, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(638, 351)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(134, 15)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Brainstorm and pizzas:"
        '
        'lblNewVersionAvailable
        '
        Me.lblNewVersionAvailable.AutoSize = True
        Me.lblNewVersionAvailable.BackColor = System.Drawing.Color.Transparent
        Me.lblNewVersionAvailable.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNewVersionAvailable.ForeColor = System.Drawing.Color.FromArgb(CType(CType(175, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.lblNewVersionAvailable.Location = New System.Drawing.Point(120, 74)
        Me.lblNewVersionAvailable.Name = "lblNewVersionAvailable"
        Me.lblNewVersionAvailable.Size = New System.Drawing.Size(140, 15)
        Me.lblNewVersionAvailable.TabIndex = 22
        Me.lblNewVersionAvailable.Text = "lblNewVersionAvailable"
        Me.lblNewVersionAvailable.Visible = False
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(800, 400)
        Me.Controls.Add(Me.lblNewVersionAvailable)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.LblThreadPost)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblVersion)
        Me.Controls.Add(Me.PicClosing)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PicChkBoxAutoMode)
        Me.Controls.Add(Me.PicOptions)
        Me.Controls.Add(Me.dbg_RectAutomode)
        Me.Controls.Add(Me.dbg_TxtItemInfo)
        Me.Controls.Add(Me.dbg_CTRL_A_Hold)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.PicChkBoxAutoMode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicOptions, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicClosing, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dbg_CTRL_A_Hold As Label
    Friend WithEvents TimerClipboard As Timer
    Friend WithEvents dbg_TxtItemInfo As TextBox
    Friend WithEvents TimerAutoMode As Timer
    Friend WithEvents dbg_RectAutomode As Label
    Friend WithEvents PicOptions As PictureBox
    Friend WithEvents PicChkBoxAutoMode As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PicClosing As PictureBox
    Friend WithEvents lblVersion As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents LblThreadPost As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblNewVersionAvailable As Label
End Class
