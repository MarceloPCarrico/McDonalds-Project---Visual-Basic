<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AboutBox1
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(AboutBox1))
        cmd_sair = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        SuspendLayout()
        ' 
        ' cmd_sair
        ' 
        cmd_sair.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        cmd_sair.BackColor = SystemColors.ButtonFace
        cmd_sair.DialogResult = DialogResult.Cancel
        cmd_sair.Location = New Point(600, 373)
        cmd_sair.Margin = New Padding(4, 5, 4, 5)
        cmd_sair.Name = "cmd_sair"
        cmd_sair.Size = New Size(100, 33)
        cmd_sair.TabIndex = 1
        cmd_sair.Text = "&OK"
        cmd_sair.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Gill Sans MT Ext Condensed Bold", 36F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(273, 4)
        Label1.Name = "Label1"
        Label1.Size = New Size(163, 75)
        Label1.TabIndex = 2
        Label1.Text = "Sobre Nós"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Gill Sans MT Ext Condensed Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.ForeColor = Color.White
        Label2.Location = New Point(15, 88)
        Label2.Name = "Label2"
        Label2.Size = New Size(686, 210)
        Label2.TabIndex = 3
        Label2.Text = resources.GetString("Label2.Text")
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label3.ForeColor = Color.White
        Label3.Location = New Point(15, 311)
        Label3.Name = "Label3"
        Label3.Size = New Size(158, 100)
        Label3.TabIndex = 4
        Label3.Text = "Version 1.2.5" & vbCrLf & vbCrLf & "Copyright ® " & vbCrLf & vbCrLf & "McDonald's Portugal"
        ' 
        ' AboutBox1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(716, 425)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(cmd_sair)
        FormBorderStyle = FormBorderStyle.FixedDialog
        Margin = New Padding(4, 5, 4, 5)
        MaximizeBox = False
        MinimizeBox = False
        Name = "AboutBox1"
        Padding = New Padding(12, 14, 12, 14)
        ShowInTaskbar = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "About Us!"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents cmd_sair As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
