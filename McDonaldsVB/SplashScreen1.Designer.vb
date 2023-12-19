<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SplashScreen1
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
        components = New ComponentModel.Container()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(SplashScreen1))
        ProgressBar1 = New ProgressBar()
        Timer1 = New Timer(components)
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' ProgressBar1
        ' 
        ProgressBar1.BackColor = SystemColors.ActiveCaption
        ProgressBar1.ForeColor = Color.Gold
        ProgressBar1.Location = New Point(-1, 265)
        ProgressBar1.Name = "ProgressBar1"
        ProgressBar1.Size = New Size(519, 19)
        ProgressBar1.Style = ProgressBarStyle.Continuous
        ProgressBar1.TabIndex = 0
        ProgressBar1.Visible = False
        ' 
        ' Timer1
        ' 
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.ForeColor = Color.Gold
        Label1.Location = New Point(432, 236)
        Label1.Name = "Label1"
        Label1.Size = New Size(72, 15)
        Label1.TabIndex = 1
        Label1.Text = "Version 1.2.5"
        Label1.Visible = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(-1, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(519, 284)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 2
        PictureBox1.TabStop = False
        ' 
        ' SplashScreen1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(515, 284)
        ControlBox = False
        Controls.Add(Label1)
        Controls.Add(ProgressBar1)
        Controls.Add(PictureBox1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        MinimizeBox = False
        Name = "SplashScreen1"
        ShowInTaskbar = False
        StartPosition = FormStartPosition.CenterScreen
        TransparencyKey = Color.White
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
