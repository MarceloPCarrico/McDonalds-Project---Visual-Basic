<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form3))
        Label1 = New Label()
        lbl_dia = New Label()
        ComboBox1 = New ComboBox()
        pic_cbo = New PictureBox()
        pic_bigmac = New PictureBox()
        pic_crispy = New PictureBox()
        Label2 = New Label()
        Label3 = New Label()
        pic_wrap = New PictureBox()
        pic_royal = New PictureBox()
        pic_happy = New PictureBox()
        lbl_pwrap = New Label()
        lbl_prpyal = New Label()
        lbl_phmeal = New Label()
        lbl_pcrispy = New Label()
        lbl_pbigmac = New Label()
        lbl_pcbo = New Label()
        Label4 = New Label()
        Roundbutton2 = New Roundbutton()
        Button1 = New Button()
        CType(pic_cbo, ComponentModel.ISupportInitialize).BeginInit()
        CType(pic_bigmac, ComponentModel.ISupportInitialize).BeginInit()
        CType(pic_crispy, ComponentModel.ISupportInitialize).BeginInit()
        CType(pic_wrap, ComponentModel.ISupportInitialize).BeginInit()
        CType(pic_royal, ComponentModel.ISupportInitialize).BeginInit()
        CType(pic_happy, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Cursor = Cursors.Hand
        Label1.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = SystemColors.ControlLight
        Label1.Location = New Point(729, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(24, 25)
        Label1.TabIndex = 1
        Label1.Text = "X"
        ' 
        ' lbl_dia
        ' 
        lbl_dia.AutoSize = True
        lbl_dia.BackColor = Color.Transparent
        lbl_dia.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        lbl_dia.ForeColor = SystemColors.ControlLightLight
        lbl_dia.Location = New Point(12, 26)
        lbl_dia.Name = "lbl_dia"
        lbl_dia.Size = New Size(248, 25)
        lbl_dia.TabIndex = 6
        lbl_dia.Text = "Escolha um dia da semana!"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Segunda", "Terça", "Quarta", "Quinta", "Sexta", "Sábado", "Domingo"})
        ComboBox1.Location = New Point(12, 65)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(116, 23)
        ComboBox1.TabIndex = 7
        ' 
        ' pic_cbo
        ' 
        pic_cbo.BorderStyle = BorderStyle.Fixed3D
        pic_cbo.Image = CType(resources.GetObject("pic_cbo.Image"), Image)
        pic_cbo.Location = New Point(12, 137)
        pic_cbo.Margin = New Padding(3, 2, 3, 2)
        pic_cbo.Name = "pic_cbo"
        pic_cbo.Size = New Size(234, 182)
        pic_cbo.SizeMode = PictureBoxSizeMode.StretchImage
        pic_cbo.TabIndex = 8
        pic_cbo.TabStop = False
        ' 
        ' pic_bigmac
        ' 
        pic_bigmac.BorderStyle = BorderStyle.Fixed3D
        pic_bigmac.Image = CType(resources.GetObject("pic_bigmac.Image"), Image)
        pic_bigmac.Location = New Point(264, 137)
        pic_bigmac.Margin = New Padding(3, 2, 3, 2)
        pic_bigmac.Name = "pic_bigmac"
        pic_bigmac.Size = New Size(242, 182)
        pic_bigmac.SizeMode = PictureBoxSizeMode.StretchImage
        pic_bigmac.TabIndex = 9
        pic_bigmac.TabStop = False
        ' 
        ' pic_crispy
        ' 
        pic_crispy.BorderStyle = BorderStyle.Fixed3D
        pic_crispy.Image = CType(resources.GetObject("pic_crispy.Image"), Image)
        pic_crispy.Location = New Point(523, 137)
        pic_crispy.Margin = New Padding(3, 2, 3, 2)
        pic_crispy.Name = "pic_crispy"
        pic_crispy.Size = New Size(238, 182)
        pic_crispy.SizeMode = PictureBoxSizeMode.StretchImage
        pic_crispy.TabIndex = 10
        pic_crispy.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Cursor = Cursors.Hand
        Label2.Font = New Font("Wingdings", 36F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.ForeColor = Color.Yellow
        Label2.Location = New Point(523, 358)
        Label2.Name = "Label2"
        Label2.Size = New Size(74, 53)
        Label2.TabIndex = 11
        Label2.Text = ""
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Cursor = Cursors.Hand
        Label3.Font = New Font("Wingdings", 36F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.ForeColor = Color.Yellow
        Label3.Location = New Point(152, 358)
        Label3.Name = "Label3"
        Label3.Size = New Size(74, 53)
        Label3.TabIndex = 12
        Label3.Text = ""
        Label3.Visible = False
        ' 
        ' pic_wrap
        ' 
        pic_wrap.BorderStyle = BorderStyle.Fixed3D
        pic_wrap.Cursor = Cursors.Hand
        pic_wrap.Image = CType(resources.GetObject("pic_wrap.Image"), Image)
        pic_wrap.Location = New Point(12, 137)
        pic_wrap.Margin = New Padding(3, 2, 3, 2)
        pic_wrap.Name = "pic_wrap"
        pic_wrap.Size = New Size(234, 182)
        pic_wrap.SizeMode = PictureBoxSizeMode.StretchImage
        pic_wrap.TabIndex = 13
        pic_wrap.TabStop = False
        pic_wrap.Visible = False
        ' 
        ' pic_royal
        ' 
        pic_royal.BorderStyle = BorderStyle.Fixed3D
        pic_royal.Image = CType(resources.GetObject("pic_royal.Image"), Image)
        pic_royal.Location = New Point(264, 137)
        pic_royal.Margin = New Padding(3, 2, 3, 2)
        pic_royal.Name = "pic_royal"
        pic_royal.Size = New Size(242, 182)
        pic_royal.SizeMode = PictureBoxSizeMode.StretchImage
        pic_royal.TabIndex = 14
        pic_royal.TabStop = False
        pic_royal.Visible = False
        ' 
        ' pic_happy
        ' 
        pic_happy.BorderStyle = BorderStyle.Fixed3D
        pic_happy.Image = CType(resources.GetObject("pic_happy.Image"), Image)
        pic_happy.Location = New Point(523, 137)
        pic_happy.Margin = New Padding(3, 2, 3, 2)
        pic_happy.Name = "pic_happy"
        pic_happy.Size = New Size(238, 182)
        pic_happy.SizeMode = PictureBoxSizeMode.StretchImage
        pic_happy.TabIndex = 15
        pic_happy.TabStop = False
        pic_happy.Visible = False
        ' 
        ' lbl_pwrap
        ' 
        lbl_pwrap.AutoSize = True
        lbl_pwrap.BackColor = Color.White
        lbl_pwrap.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        lbl_pwrap.ForeColor = SystemColors.ActiveCaptionText
        lbl_pwrap.Location = New Point(176, 284)
        lbl_pwrap.Name = "lbl_pwrap"
        lbl_pwrap.Size = New Size(50, 25)
        lbl_pwrap.TabIndex = 16
        lbl_pwrap.Text = "3,20"
        ' 
        ' lbl_prpyal
        ' 
        lbl_prpyal.AutoSize = True
        lbl_prpyal.BackColor = Color.White
        lbl_prpyal.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        lbl_prpyal.ForeColor = SystemColors.ActiveCaptionText
        lbl_prpyal.Location = New Point(446, 284)
        lbl_prpyal.Name = "lbl_prpyal"
        lbl_prpyal.Size = New Size(50, 25)
        lbl_prpyal.TabIndex = 17
        lbl_prpyal.Text = "6,50"
        ' 
        ' lbl_phmeal
        ' 
        lbl_phmeal.AutoSize = True
        lbl_phmeal.BackColor = Color.White
        lbl_phmeal.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        lbl_phmeal.ForeColor = SystemColors.ActiveCaptionText
        lbl_phmeal.Location = New Point(710, 284)
        lbl_phmeal.Name = "lbl_phmeal"
        lbl_phmeal.Size = New Size(50, 25)
        lbl_phmeal.TabIndex = 18
        lbl_phmeal.Text = "4.95"
        ' 
        ' lbl_pcrispy
        ' 
        lbl_pcrispy.AutoSize = True
        lbl_pcrispy.BackColor = Color.White
        lbl_pcrispy.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        lbl_pcrispy.ForeColor = SystemColors.ActiveCaptionText
        lbl_pcrispy.Location = New Point(709, 282)
        lbl_pcrispy.Name = "lbl_pcrispy"
        lbl_pcrispy.Size = New Size(50, 25)
        lbl_pcrispy.TabIndex = 21
        lbl_pcrispy.Text = "8,30"
        ' 
        ' lbl_pbigmac
        ' 
        lbl_pbigmac.AutoSize = True
        lbl_pbigmac.BackColor = Color.White
        lbl_pbigmac.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        lbl_pbigmac.ForeColor = SystemColors.ActiveCaptionText
        lbl_pbigmac.Location = New Point(446, 286)
        lbl_pbigmac.Name = "lbl_pbigmac"
        lbl_pbigmac.Size = New Size(50, 25)
        lbl_pbigmac.TabIndex = 20
        lbl_pbigmac.Text = "5,70"
        ' 
        ' lbl_pcbo
        ' 
        lbl_pcbo.AutoSize = True
        lbl_pcbo.BackColor = Color.White
        lbl_pcbo.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        lbl_pcbo.ForeColor = SystemColors.ActiveCaptionText
        lbl_pcbo.Location = New Point(176, 284)
        lbl_pcbo.Name = "lbl_pcbo"
        lbl_pcbo.Size = New Size(50, 25)
        lbl_pcbo.TabIndex = 19
        lbl_pcbo.Text = "7,60"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Cursor = Cursors.Hand
        Label4.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.ForeColor = SystemColors.ControlLight
        Label4.Location = New Point(699, 9)
        Label4.Name = "Label4"
        Label4.Size = New Size(20, 25)
        Label4.TabIndex = 22
        Label4.Text = "?"
        ' 
        ' Roundbutton2
        ' 
        Roundbutton2.BackColor = Color.Transparent
        Roundbutton2.Cursor = Cursors.Hand
        Roundbutton2.FlatAppearance.BorderSize = 0
        Roundbutton2.FlatStyle = FlatStyle.Flat
        Roundbutton2.Font = New Font("Segoe MDL2 Assets", 21.75F, FontStyle.Bold, GraphicsUnit.Point)
        Roundbutton2.ForeColor = Color.WhiteSmoke
        Roundbutton2.Location = New Point(165, 58)
        Roundbutton2.Name = "Roundbutton2"
        Roundbutton2.Size = New Size(35, 33)
        Roundbutton2.TabIndex = 23
        Roundbutton2.Text = ""
        Roundbutton2.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(12, 94)
        Button1.Name = "Button1"
        Button1.Size = New Size(116, 23)
        Button1.TabIndex = 24
        Button1.Text = "Novo Pedido"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(772, 451)
        Controls.Add(Button1)
        Controls.Add(lbl_pcrispy)
        Controls.Add(lbl_pbigmac)
        Controls.Add(lbl_pcbo)
        Controls.Add(Roundbutton2)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(pic_crispy)
        Controls.Add(pic_bigmac)
        Controls.Add(pic_cbo)
        Controls.Add(ComboBox1)
        Controls.Add(lbl_dia)
        Controls.Add(Label1)
        Controls.Add(lbl_phmeal)
        Controls.Add(pic_happy)
        Controls.Add(lbl_prpyal)
        Controls.Add(pic_royal)
        Controls.Add(lbl_pwrap)
        Controls.Add(pic_wrap)
        DoubleBuffered = True
        Name = "Form3"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form3"
        CType(pic_cbo, ComponentModel.ISupportInitialize).EndInit()
        CType(pic_bigmac, ComponentModel.ISupportInitialize).EndInit()
        CType(pic_crispy, ComponentModel.ISupportInitialize).EndInit()
        CType(pic_wrap, ComponentModel.ISupportInitialize).EndInit()
        CType(pic_royal, ComponentModel.ISupportInitialize).EndInit()
        CType(pic_happy, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_dia As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents pic_cbo As PictureBox
    Friend WithEvents pic_bigmac As PictureBox
    Friend WithEvents pic_crispy As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents pic_wrap As PictureBox
    Friend WithEvents pic_royal As PictureBox
    Friend WithEvents pic_happy As PictureBox
    Friend WithEvents lbl_pwrap As Label
    Friend WithEvents lbl_prpyal As Label
    Friend WithEvents lbl_phmeal As Label
    Friend WithEvents lbl_pcrispy As Label
    Friend WithEvents lbl_pbigmac As Label
    Friend WithEvents lbl_pcbo As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Roundbutton2 As Roundbutton
    Friend WithEvents Button1 As Button
End Class
