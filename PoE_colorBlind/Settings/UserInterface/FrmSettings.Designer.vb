<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmSettings
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
        Me.TimerMouseCoord = New System.Windows.Forms.Timer(Me.components)
        Me.CboNumberSockets = New System.Windows.Forms.ComboBox()
        Me.TxtPOEProcess = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblMouseCoordinates = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PicSave = New System.Windows.Forms.PictureBox()
        Me.PicClose = New System.Windows.Forms.PictureBox()
        Me.PicChkDefault_S2 = New System.Windows.Forms.PictureBox()
        Me.PicChkDefault_S3 = New System.Windows.Forms.PictureBox()
        Me.LblChkDefault_S3 = New System.Windows.Forms.Label()
        Me.LblChkDefault_S2 = New System.Windows.Forms.Label()
        Me.UC_S11 = New PoE_colorBlind.UC_S1()
        Me.UC_S2H1 = New PoE_colorBlind.UC_S2H()
        Me.UC_S2V1 = New PoE_colorBlind.UC_S2V()
        Me.UC_S3L1 = New PoE_colorBlind.UC_S3L()
        Me.UC_S3V1 = New PoE_colorBlind.UC_S3V()
        Me.UC_S41 = New PoE_colorBlind.UC_S4()
        Me.UC_S51 = New PoE_colorBlind.UC_S5()
        Me.UC_S61 = New PoE_colorBlind.UC_S6()
        Me.UC_Vorici1 = New PoE_colorBlind.UC_Vorici()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicSave, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicChkDefault_S2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicChkDefault_S3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TimerMouseCoord
        '
        '
        'CboNumberSockets
        '
        Me.CboNumberSockets.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CboNumberSockets.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboNumberSockets.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboNumberSockets.ForeColor = System.Drawing.Color.White
        Me.CboNumberSockets.FormattingEnabled = True
        Me.CboNumberSockets.Location = New System.Drawing.Point(50, 195)
        Me.CboNumberSockets.Name = "CboNumberSockets"
        Me.CboNumberSockets.Size = New System.Drawing.Size(222, 27)
        Me.CboNumberSockets.TabIndex = 3
        '
        'TxtPOEProcess
        '
        Me.TxtPOEProcess.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TxtPOEProcess.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPOEProcess.ForeColor = System.Drawing.Color.White
        Me.TxtPOEProcess.Location = New System.Drawing.Point(214, 153)
        Me.TxtPOEProcess.Name = "TxtPOEProcess"
        Me.TxtPOEProcess.Size = New System.Drawing.Size(211, 26)
        Me.TxtPOEProcess.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(47, 156)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(157, 19)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Path of Exile process:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(90, 131)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(114, 19)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Mouse pointer:"
        '
        'lblMouseCoordinates
        '
        Me.lblMouseCoordinates.AutoSize = True
        Me.lblMouseCoordinates.BackColor = System.Drawing.Color.Transparent
        Me.lblMouseCoordinates.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMouseCoordinates.ForeColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.lblMouseCoordinates.Location = New System.Drawing.Point(210, 131)
        Me.lblMouseCoordinates.Name = "lblMouseCoordinates"
        Me.lblMouseCoordinates.Size = New System.Drawing.Size(71, 19)
        Me.lblMouseCoordinates.TabIndex = 9
        Me.lblMouseCoordinates.Text = "500, 134"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.PoE_colorBlind.My.Resources.Resources.MousePointer
        Me.PictureBox1.Location = New System.Drawing.Point(67, 127)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(17, 23)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'PicSave
        '
        Me.PicSave.Image = Global.PoE_colorBlind.My.Resources.Resources.SaveDark
        Me.PicSave.Location = New System.Drawing.Point(44, 372)
        Me.PicSave.Name = "PicSave"
        Me.PicSave.Size = New System.Drawing.Size(167, 35)
        Me.PicSave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PicSave.TabIndex = 1
        Me.PicSave.TabStop = False
        '
        'PicClose
        '
        Me.PicClose.Image = Global.PoE_colorBlind.My.Resources.Resources.CloseDark
        Me.PicClose.Location = New System.Drawing.Point(248, 372)
        Me.PicClose.Name = "PicClose"
        Me.PicClose.Size = New System.Drawing.Size(167, 35)
        Me.PicClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PicClose.TabIndex = 0
        Me.PicClose.TabStop = False
        '
        'PicChkDefault_S2
        '
        Me.PicChkDefault_S2.BackColor = System.Drawing.Color.Transparent
        Me.PicChkDefault_S2.Image = Global.PoE_colorBlind.My.Resources.Resources.UnChecked
        Me.PicChkDefault_S2.Location = New System.Drawing.Point(302, 278)
        Me.PicChkDefault_S2.Name = "PicChkDefault_S2"
        Me.PicChkDefault_S2.Size = New System.Drawing.Size(35, 35)
        Me.PicChkDefault_S2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PicChkDefault_S2.TabIndex = 18
        Me.PicChkDefault_S2.TabStop = False
        Me.PicChkDefault_S2.Visible = False
        '
        'PicChkDefault_S3
        '
        Me.PicChkDefault_S3.BackColor = System.Drawing.Color.Transparent
        Me.PicChkDefault_S3.Image = Global.PoE_colorBlind.My.Resources.Resources.UnChecked
        Me.PicChkDefault_S3.Location = New System.Drawing.Point(200, 324)
        Me.PicChkDefault_S3.Name = "PicChkDefault_S3"
        Me.PicChkDefault_S3.Size = New System.Drawing.Size(35, 35)
        Me.PicChkDefault_S3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PicChkDefault_S3.TabIndex = 19
        Me.PicChkDefault_S3.TabStop = False
        Me.PicChkDefault_S3.Visible = False
        '
        'LblChkDefault_S3
        '
        Me.LblChkDefault_S3.AutoSize = True
        Me.LblChkDefault_S3.BackColor = System.Drawing.Color.Transparent
        Me.LblChkDefault_S3.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblChkDefault_S3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.LblChkDefault_S3.Location = New System.Drawing.Point(244, 334)
        Me.LblChkDefault_S3.Name = "LblChkDefault_S3"
        Me.LblChkDefault_S3.Size = New System.Drawing.Size(304, 19)
        Me.LblChkDefault_S3.TabIndex = 23
        Me.LblChkDefault_S3.Text = "Make this as default for 3 sockets layout"
        Me.LblChkDefault_S3.Visible = False
        '
        'LblChkDefault_S2
        '
        Me.LblChkDefault_S2.AutoSize = True
        Me.LblChkDefault_S2.BackColor = System.Drawing.Color.Transparent
        Me.LblChkDefault_S2.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblChkDefault_S2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.LblChkDefault_S2.Location = New System.Drawing.Point(343, 287)
        Me.LblChkDefault_S2.Name = "LblChkDefault_S2"
        Me.LblChkDefault_S2.Size = New System.Drawing.Size(304, 19)
        Me.LblChkDefault_S2.TabIndex = 24
        Me.LblChkDefault_S2.Text = "Make this as default for 2 sockets layout"
        Me.LblChkDefault_S2.Visible = False
        '
        'UC_S11
        '
        Me.UC_S11.BackColor = System.Drawing.Color.Transparent
        Me.UC_S11.Location = New System.Drawing.Point(338, 91)
        Me.UC_S11.Name = "UC_S11"
        Me.UC_S11.Size = New System.Drawing.Size(222, 131)
        Me.UC_S11.SocketsPositions = Nothing
        Me.UC_S11.TabIndex = 17
        Me.UC_S11.Visible = False
        '
        'UC_S2H1
        '
        Me.UC_S2H1.BackColor = System.Drawing.Color.Transparent
        Me.UC_S2H1.Location = New System.Drawing.Point(302, 228)
        Me.UC_S2H1.Name = "UC_S2H1"
        Me.UC_S2H1.Size = New System.Drawing.Size(222, 131)
        Me.UC_S2H1.SocketsPositions = Nothing
        Me.UC_S2H1.TabIndex = 16
        Me.UC_S2H1.Visible = False
        '
        'UC_S2V1
        '
        Me.UC_S2V1.BackColor = System.Drawing.Color.Transparent
        Me.UC_S2V1.Location = New System.Drawing.Point(110, 3)
        Me.UC_S2V1.Name = "UC_S2V1"
        Me.UC_S2V1.Size = New System.Drawing.Size(222, 131)
        Me.UC_S2V1.SocketsPositions = Nothing
        Me.UC_S2V1.TabIndex = 15
        Me.UC_S2V1.Visible = False
        '
        'UC_S3L1
        '
        Me.UC_S3L1.BackColor = System.Drawing.Color.Transparent
        Me.UC_S3L1.Location = New System.Drawing.Point(338, 3)
        Me.UC_S3L1.Name = "UC_S3L1"
        Me.UC_S3L1.Size = New System.Drawing.Size(222, 131)
        Me.UC_S3L1.SocketsPositions = Nothing
        Me.UC_S3L1.TabIndex = 14
        Me.UC_S3L1.Visible = False
        '
        'UC_S3V1
        '
        Me.UC_S3V1.BackColor = System.Drawing.Color.Transparent
        Me.UC_S3V1.Location = New System.Drawing.Point(566, 290)
        Me.UC_S3V1.Name = "UC_S3V1"
        Me.UC_S3V1.Size = New System.Drawing.Size(222, 131)
        Me.UC_S3V1.SocketsPositions = Nothing
        Me.UC_S3V1.TabIndex = 13
        Me.UC_S3V1.Visible = False
        '
        'UC_S41
        '
        Me.UC_S41.BackColor = System.Drawing.Color.Transparent
        Me.UC_S41.Location = New System.Drawing.Point(566, 153)
        Me.UC_S41.Name = "UC_S41"
        Me.UC_S41.Size = New System.Drawing.Size(222, 131)
        Me.UC_S41.SocketsPositions = Nothing
        Me.UC_S41.TabIndex = 12
        Me.UC_S41.Visible = False
        '
        'UC_S51
        '
        Me.UC_S51.BackColor = System.Drawing.Color.Transparent
        Me.UC_S51.Location = New System.Drawing.Point(566, 3)
        Me.UC_S51.Name = "UC_S51"
        Me.UC_S51.Size = New System.Drawing.Size(222, 131)
        Me.UC_S51.SocketsPositions = Nothing
        Me.UC_S51.TabIndex = 11
        Me.UC_S51.Visible = False
        '
        'UC_S61
        '
        Me.UC_S61.BackColor = System.Drawing.Color.Transparent
        Me.UC_S61.Location = New System.Drawing.Point(48, 228)
        Me.UC_S61.Name = "UC_S61"
        Me.UC_S61.Size = New System.Drawing.Size(222, 131)
        Me.UC_S61.SocketsPositions = Nothing
        Me.UC_S61.TabIndex = 10
        '
        'UC_Vorici1
        '
        Me.UC_Vorici1.BackColor = System.Drawing.Color.Transparent
        Me.UC_Vorici1.Location = New System.Drawing.Point(12, 3)
        Me.UC_Vorici1.Name = "UC_Vorici1"
        Me.UC_Vorici1.Size = New System.Drawing.Size(222, 131)
        Me.UC_Vorici1.SocketsPositions = Nothing
        Me.UC_Vorici1.TabIndex = 25
        '
        'FrmSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.ControlBox = False
        Me.Controls.Add(Me.UC_S2V1)
        Me.Controls.Add(Me.UC_Vorici1)
        Me.Controls.Add(Me.LblChkDefault_S2)
        Me.Controls.Add(Me.LblChkDefault_S3)
        Me.Controls.Add(Me.PicChkDefault_S3)
        Me.Controls.Add(Me.PicChkDefault_S2)
        Me.Controls.Add(Me.UC_S11)
        Me.Controls.Add(Me.UC_S2H1)
        Me.Controls.Add(Me.UC_S3L1)
        Me.Controls.Add(Me.UC_S3V1)
        Me.Controls.Add(Me.UC_S41)
        Me.Controls.Add(Me.UC_S51)
        Me.Controls.Add(Me.UC_S61)
        Me.Controls.Add(Me.lblMouseCoordinates)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtPOEProcess)
        Me.Controls.Add(Me.CboNumberSockets)
        Me.Controls.Add(Me.PicSave)
        Me.Controls.Add(Me.PicClose)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmSettings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmSettings"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicSave, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicChkDefault_S2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicChkDefault_S3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PicClose As PictureBox
    Friend WithEvents PicSave As PictureBox
    Friend WithEvents TimerMouseCoord As Timer
    Friend WithEvents CboNumberSockets As ComboBox
    Friend WithEvents TxtPOEProcess As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents lblMouseCoordinates As Label
    Friend WithEvents UC_S61 As UC_S6
    Friend WithEvents UC_S51 As UC_S5
    Friend WithEvents UC_S41 As UC_S4
    Friend WithEvents UC_S3V1 As UC_S3V
    Friend WithEvents UC_S3L1 As UC_S3L
    Friend WithEvents UC_S2V1 As UC_S2V
    Friend WithEvents UC_S2H1 As UC_S2H
    Friend WithEvents UC_S11 As UC_S1
    Friend WithEvents PicChkDefault_S2 As PictureBox
    Friend WithEvents PicChkDefault_S3 As PictureBox
    Friend WithEvents LblChkDefault_S3 As Label
    Friend WithEvents LblChkDefault_S2 As Label
    Friend WithEvents UC_Vorici1 As UC_Vorici
End Class
