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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
        txt_user = New TextBox()
        txt_password = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Button1 = New Button()
        LinkLabel1 = New LinkLabel()
        Label3 = New Label()
        Label4 = New Label()
        SuspendLayout()
        ' 
        ' txt_user
        ' 
        txt_user.Location = New Point(27, 152)
        txt_user.Name = "txt_user"
        txt_user.Size = New Size(274, 23)
        txt_user.TabIndex = 0
        ' 
        ' txt_password
        ' 
        txt_password.Location = New Point(27, 219)
        txt_password.Name = "txt_password"
        txt_password.PasswordChar = "*"c
        txt_password.Size = New Size(274, 23)
        txt_password.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(27, 122)
        Label1.Name = "Label1"
        Label1.Size = New Size(87, 21)
        Label1.TabIndex = 2
        Label1.Text = "&Username"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(27, 189)
        Label2.Name = "Label2"
        Label2.Size = New Size(82, 21)
        Label2.TabIndex = 3
        Label2.Text = "&Password"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.DarkGreen
        Button1.Cursor = Cursors.Hand
        Button1.FlatStyle = FlatStyle.System
        Button1.Location = New Point(27, 269)
        Button1.Name = "Button1"
        Button1.Size = New Size(113, 27)
        Button1.TabIndex = 4
        Button1.Text = "&Entrar"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.AutoSize = True
        LinkLabel1.BackColor = Color.Transparent
        LinkLabel1.LinkColor = Color.Green
        LinkLabel1.Location = New Point(29, 247)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(78, 15)
        LinkLabel1.TabIndex = 5
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "Novo Registo"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Cursor = Cursors.Hand
        Label3.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.ForeColor = SystemColors.ControlLight
        Label3.Location = New Point(566, 11)
        Label3.Name = "Label3"
        Label3.Size = New Size(24, 25)
        Label3.TabIndex = 7
        Label3.Text = "X"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Cursor = Cursors.Hand
        Label4.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.ForeColor = SystemColors.ControlLight
        Label4.Location = New Point(540, 11)
        Label4.Name = "Label4"
        Label4.Size = New Size(20, 25)
        Label4.TabIndex = 8
        Label4.Text = "?"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(613, 308)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(LinkLabel1)
        Controls.Add(Button1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txt_password)
        Controls.Add(txt_user)
        DoubleBuffered = True
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txt_user As TextBox
    Friend WithEvents txt_password As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
