<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class basededados
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(basededados))
        DataGridView1 = New DataGridView()
        TextBox1 = New TextBox()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        Button5 = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(28, 125)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowTemplate.Height = 25
        DataGridView1.Size = New Size(726, 265)
        DataGridView1.TabIndex = 0
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(28, 53)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(726, 66)
        TextBox1.TabIndex = 1
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(252, 406)
        Button1.Name = "Button1"
        Button1.Size = New Size(306, 92)
        Button1.TabIndex = 2
        Button1.Text = "&Query"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(585, 406)
        Button2.Name = "Button2"
        Button2.Size = New Size(169, 27)
        Button2.TabIndex = 3
        Button2.Text = "erro1"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(585, 439)
        Button3.Name = "Button3"
        Button3.Size = New Size(169, 27)
        Button3.TabIndex = 4
        Button3.Text = "erro2"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(585, 472)
        Button4.Name = "Button4"
        Button4.Size = New Size(169, 27)
        Button4.TabIndex = 5
        Button4.Text = "erro3"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button5
        ' 
        Button5.Location = New Point(678, 12)
        Button5.Name = "Button5"
        Button5.Size = New Size(110, 34)
        Button5.TabIndex = 6
        Button5.Text = "Reset"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' basededados
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 510)
        Controls.Add(Button5)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(TextBox1)
        Controls.Add(DataGridView1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "basededados"
        Text = "basededados"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
End Class
