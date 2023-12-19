<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form2))
        lbl_nome = New Label()
        txt_nome = New TextBox()
        txt_morada = New TextBox()
        Label1 = New Label()
        txt_tlf = New TextBox()
        Label2 = New Label()
        txt_email = New TextBox()
        Label3 = New Label()
        txt_user = New TextBox()
        Label4 = New Label()
        txt_pwd = New TextBox()
        Label5 = New Label()
        Roundbutton1 = New Roundbutton()
        Label6 = New Label()
        SuspendLayout()
        ' 
        ' lbl_nome
        ' 
        lbl_nome.AutoSize = True
        lbl_nome.BackColor = Color.Transparent
        lbl_nome.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        lbl_nome.Location = New Point(34, 74)
        lbl_nome.Name = "lbl_nome"
        lbl_nome.Size = New Size(66, 25)
        lbl_nome.TabIndex = 0
        lbl_nome.Text = "Nome"
        ' 
        ' txt_nome
        ' 
        txt_nome.Location = New Point(39, 105)
        txt_nome.Name = "txt_nome"
        txt_nome.Size = New Size(458, 23)
        txt_nome.TabIndex = 1
        ' 
        ' txt_morada
        ' 
        txt_morada.Location = New Point(39, 177)
        txt_morada.Name = "txt_morada"
        txt_morada.Size = New Size(458, 23)
        txt_morada.TabIndex = 3
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(34, 146)
        Label1.Name = "Label1"
        Label1.Size = New Size(82, 25)
        Label1.TabIndex = 2
        Label1.Text = "Morada"
        ' 
        ' txt_tlf
        ' 
        txt_tlf.Location = New Point(39, 255)
        txt_tlf.Name = "txt_tlf"
        txt_tlf.Size = New Size(173, 23)
        txt_tlf.TabIndex = 5
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(34, 224)
        Label2.Name = "Label2"
        Label2.Size = New Size(121, 25)
        Label2.TabIndex = 4
        Label2.Text = "Contacto Tlf"
        ' 
        ' txt_email
        ' 
        txt_email.Location = New Point(265, 255)
        txt_email.Name = "txt_email"
        txt_email.Size = New Size(227, 23)
        txt_email.TabIndex = 7
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(260, 224)
        Label3.Name = "Label3"
        Label3.Size = New Size(67, 25)
        Label3.TabIndex = 6
        Label3.Text = "E-mail"
        ' 
        ' txt_user
        ' 
        txt_user.Location = New Point(39, 342)
        txt_user.Name = "txt_user"
        txt_user.Size = New Size(173, 23)
        txt_user.TabIndex = 9
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(34, 311)
        Label4.Name = "Label4"
        Label4.Size = New Size(101, 25)
        Label4.TabIndex = 8
        Label4.Text = "Username"
        ' 
        ' txt_pwd
        ' 
        txt_pwd.Location = New Point(44, 420)
        txt_pwd.Name = "txt_pwd"
        txt_pwd.Size = New Size(173, 23)
        txt_pwd.TabIndex = 11
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(39, 389)
        Label5.Name = "Label5"
        Label5.Size = New Size(97, 25)
        Label5.TabIndex = 10
        Label5.Text = "Password"
        ' 
        ' Roundbutton1
        ' 
        Roundbutton1.BackColor = Color.Goldenrod
        Roundbutton1.FlatAppearance.BorderSize = 0
        Roundbutton1.FlatStyle = FlatStyle.Flat
        Roundbutton1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Roundbutton1.ForeColor = Color.DarkSlateGray
        Roundbutton1.Location = New Point(596, 420)
        Roundbutton1.Name = "Roundbutton1"
        Roundbutton1.Size = New Size(67, 64)
        Roundbutton1.TabIndex = 12
        Roundbutton1.Text = "Registar"
        Roundbutton1.UseVisualStyleBackColor = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Cursor = Cursors.Hand
        Label6.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.ForeColor = SystemColors.ControlLight
        Label6.Location = New Point(940, 7)
        Label6.Name = "Label6"
        Label6.Size = New Size(24, 25)
        Label6.TabIndex = 13
        Label6.Text = "X"
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(976, 508)
        Controls.Add(Label6)
        Controls.Add(Roundbutton1)
        Controls.Add(txt_pwd)
        Controls.Add(Label5)
        Controls.Add(txt_user)
        Controls.Add(Label4)
        Controls.Add(txt_email)
        Controls.Add(Label3)
        Controls.Add(txt_tlf)
        Controls.Add(Label2)
        Controls.Add(txt_morada)
        Controls.Add(Label1)
        Controls.Add(txt_nome)
        Controls.Add(lbl_nome)
        DoubleBuffered = True
        Name = "Form2"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form2"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lbl_nome As Label
    Friend WithEvents txt_nome As TextBox
    Friend WithEvents txt_morada As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_tlf As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_email As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_user As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_pwd As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Roundbutton1 As Roundbutton
    Friend WithEvents Label6 As Label
End Class
