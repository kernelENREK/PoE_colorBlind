<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UC_S6
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TXT_2X = New System.Windows.Forms.MaskedTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TXT_2Y = New System.Windows.Forms.MaskedTextBox()
        Me.TXT_1Y = New System.Windows.Forms.MaskedTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TXT_1X = New System.Windows.Forms.MaskedTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TXT_3Y = New System.Windows.Forms.MaskedTextBox()
        Me.TXT_3X = New System.Windows.Forms.MaskedTextBox()
        Me.TXT_4Y = New System.Windows.Forms.MaskedTextBox()
        Me.TXT_4X = New System.Windows.Forms.MaskedTextBox()
        Me.TXT_5Y = New System.Windows.Forms.MaskedTextBox()
        Me.TXT_5X = New System.Windows.Forms.MaskedTextBox()
        Me.TXT_6Y = New System.Windows.Forms.MaskedTextBox()
        Me.TXT_6X = New System.Windows.Forms.MaskedTextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.PoE_colorBlind.My.Resources.Resources.S6
        Me.PictureBox1.Location = New System.Drawing.Point(74, 18)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(69, 109)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(149, -4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(19, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "X"
        '
        'TXT_2X
        '
        Me.TXT_2X.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TXT_2X.Font = New System.Drawing.Font("Cambria", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_2X.ForeColor = System.Drawing.Color.White
        Me.TXT_2X.Location = New System.Drawing.Point(149, 22)
        Me.TXT_2X.Mask = "999"
        Me.TXT_2X.Name = "TXT_2X"
        Me.TXT_2X.Size = New System.Drawing.Size(30, 20)
        Me.TXT_2X.TabIndex = 2
        Me.TXT_2X.Text = "999"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(185, -4)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(19, 19)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Y"
        '
        'TXT_2Y
        '
        Me.TXT_2Y.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TXT_2Y.Font = New System.Drawing.Font("Cambria", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_2Y.ForeColor = System.Drawing.Color.White
        Me.TXT_2Y.Location = New System.Drawing.Point(185, 22)
        Me.TXT_2Y.Mask = "999"
        Me.TXT_2Y.Name = "TXT_2Y"
        Me.TXT_2Y.Size = New System.Drawing.Size(30, 20)
        Me.TXT_2Y.TabIndex = 3
        Me.TXT_2Y.Text = "999"
        '
        'TXT_1Y
        '
        Me.TXT_1Y.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TXT_1Y.Font = New System.Drawing.Font("Cambria", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_1Y.ForeColor = System.Drawing.Color.White
        Me.TXT_1Y.Location = New System.Drawing.Point(38, 22)
        Me.TXT_1Y.Mask = "999"
        Me.TXT_1Y.Name = "TXT_1Y"
        Me.TXT_1Y.Size = New System.Drawing.Size(30, 20)
        Me.TXT_1Y.TabIndex = 1
        Me.TXT_1Y.Text = "999"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(38, -4)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(19, 19)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Y"
        '
        'TXT_1X
        '
        Me.TXT_1X.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TXT_1X.Font = New System.Drawing.Font("Cambria", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_1X.ForeColor = System.Drawing.Color.White
        Me.TXT_1X.Location = New System.Drawing.Point(2, 22)
        Me.TXT_1X.Mask = "999"
        Me.TXT_1X.Name = "TXT_1X"
        Me.TXT_1X.Size = New System.Drawing.Size(30, 20)
        Me.TXT_1X.TabIndex = 0
        Me.TXT_1X.Text = "999"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(2, -4)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(19, 19)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "X"
        '
        'TXT_3Y
        '
        Me.TXT_3Y.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TXT_3Y.Font = New System.Drawing.Font("Cambria", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_3Y.ForeColor = System.Drawing.Color.White
        Me.TXT_3Y.Location = New System.Drawing.Point(185, 63)
        Me.TXT_3Y.Mask = "999"
        Me.TXT_3Y.Name = "TXT_3Y"
        Me.TXT_3Y.Size = New System.Drawing.Size(30, 20)
        Me.TXT_3Y.TabIndex = 9
        Me.TXT_3Y.Text = "999"
        '
        'TXT_3X
        '
        Me.TXT_3X.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TXT_3X.Font = New System.Drawing.Font("Cambria", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_3X.ForeColor = System.Drawing.Color.White
        Me.TXT_3X.Location = New System.Drawing.Point(149, 63)
        Me.TXT_3X.Mask = "999"
        Me.TXT_3X.Name = "TXT_3X"
        Me.TXT_3X.Size = New System.Drawing.Size(30, 20)
        Me.TXT_3X.TabIndex = 8
        Me.TXT_3X.Text = "999"
        '
        'TXT_4Y
        '
        Me.TXT_4Y.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TXT_4Y.Font = New System.Drawing.Font("Cambria", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_4Y.ForeColor = System.Drawing.Color.White
        Me.TXT_4Y.Location = New System.Drawing.Point(38, 63)
        Me.TXT_4Y.Mask = "999"
        Me.TXT_4Y.Name = "TXT_4Y"
        Me.TXT_4Y.Size = New System.Drawing.Size(30, 20)
        Me.TXT_4Y.TabIndex = 11
        Me.TXT_4Y.Text = "999"
        '
        'TXT_4X
        '
        Me.TXT_4X.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TXT_4X.Font = New System.Drawing.Font("Cambria", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_4X.ForeColor = System.Drawing.Color.White
        Me.TXT_4X.Location = New System.Drawing.Point(2, 63)
        Me.TXT_4X.Mask = "999"
        Me.TXT_4X.Name = "TXT_4X"
        Me.TXT_4X.Size = New System.Drawing.Size(30, 20)
        Me.TXT_4X.TabIndex = 10
        Me.TXT_4X.Text = "999"
        '
        'TXT_5Y
        '
        Me.TXT_5Y.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TXT_5Y.Font = New System.Drawing.Font("Cambria", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_5Y.ForeColor = System.Drawing.Color.White
        Me.TXT_5Y.Location = New System.Drawing.Point(38, 103)
        Me.TXT_5Y.Mask = "999"
        Me.TXT_5Y.Name = "TXT_5Y"
        Me.TXT_5Y.Size = New System.Drawing.Size(30, 20)
        Me.TXT_5Y.TabIndex = 13
        Me.TXT_5Y.Text = "999"
        '
        'TXT_5X
        '
        Me.TXT_5X.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TXT_5X.Font = New System.Drawing.Font("Cambria", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_5X.ForeColor = System.Drawing.Color.White
        Me.TXT_5X.Location = New System.Drawing.Point(2, 103)
        Me.TXT_5X.Mask = "999"
        Me.TXT_5X.Name = "TXT_5X"
        Me.TXT_5X.Size = New System.Drawing.Size(30, 20)
        Me.TXT_5X.TabIndex = 12
        Me.TXT_5X.Text = "999"
        '
        'TXT_6Y
        '
        Me.TXT_6Y.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TXT_6Y.Font = New System.Drawing.Font("Cambria", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_6Y.ForeColor = System.Drawing.Color.White
        Me.TXT_6Y.Location = New System.Drawing.Point(185, 103)
        Me.TXT_6Y.Mask = "999"
        Me.TXT_6Y.Name = "TXT_6Y"
        Me.TXT_6Y.Size = New System.Drawing.Size(30, 20)
        Me.TXT_6Y.TabIndex = 15
        Me.TXT_6Y.Text = "999"
        '
        'TXT_6X
        '
        Me.TXT_6X.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TXT_6X.Font = New System.Drawing.Font("Cambria", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_6X.ForeColor = System.Drawing.Color.White
        Me.TXT_6X.Location = New System.Drawing.Point(149, 103)
        Me.TXT_6X.Mask = "999"
        Me.TXT_6X.Name = "TXT_6X"
        Me.TXT_6X.Size = New System.Drawing.Size(30, 20)
        Me.TXT_6X.TabIndex = 14
        Me.TXT_6X.Text = "999"
        '
        'UC_S6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.TXT_6Y)
        Me.Controls.Add(Me.TXT_6X)
        Me.Controls.Add(Me.TXT_5Y)
        Me.Controls.Add(Me.TXT_5X)
        Me.Controls.Add(Me.TXT_4Y)
        Me.Controls.Add(Me.TXT_4X)
        Me.Controls.Add(Me.TXT_3Y)
        Me.Controls.Add(Me.TXT_3X)
        Me.Controls.Add(Me.TXT_1Y)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TXT_1X)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TXT_2Y)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TXT_2X)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "UC_S6"
        Me.Size = New System.Drawing.Size(222, 131)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TXT_2X As MaskedTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TXT_2Y As MaskedTextBox
    Friend WithEvents TXT_1Y As MaskedTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TXT_1X As MaskedTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TXT_3Y As MaskedTextBox
    Friend WithEvents TXT_3X As MaskedTextBox
    Friend WithEvents TXT_4Y As MaskedTextBox
    Friend WithEvents TXT_4X As MaskedTextBox
    Friend WithEvents TXT_5Y As MaskedTextBox
    Friend WithEvents TXT_5X As MaskedTextBox
    Friend WithEvents TXT_6Y As MaskedTextBox
    Friend WithEvents TXT_6X As MaskedTextBox
End Class
