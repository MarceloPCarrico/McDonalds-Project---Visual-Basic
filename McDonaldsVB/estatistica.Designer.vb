<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class estatistica
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(estatistica))
        Label1 = New Label()
        txt_vpedidos = New TextBox()
        txt_totalv = New TextBox()
        Label2 = New Label()
        txt_tpedidos = New TextBox()
        Label3 = New Label()
        txt_media = New TextBox()
        Label4 = New Label()
        Button1 = New Button()
        Label5 = New Label()
        Button2 = New Button()
        lbl_maximo = New Label()
        lbl_valormedio = New Label()
        lbl_valor_minimo = New Label()
        cmd_media = New Button()
        Button3 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(24, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(147, 21)
        Label1.TabIndex = 0
        Label1.Text = "Valores mais altos"
        ' 
        ' txt_vpedidos
        ' 
        txt_vpedidos.Location = New Point(24, 163)
        txt_vpedidos.Multiline = True
        txt_vpedidos.Name = "txt_vpedidos"
        txt_vpedidos.Size = New Size(360, 105)
        txt_vpedidos.TabIndex = 1
        ' 
        ' txt_totalv
        ' 
        txt_totalv.Location = New Point(24, 295)
        txt_totalv.Name = "txt_totalv"
        txt_totalv.Size = New Size(360, 23)
        txt_totalv.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(24, 271)
        Label2.Name = "Label2"
        Label2.Size = New Size(130, 21)
        Label2.TabIndex = 2
        Label2.Text = "Total de Vendas"
        ' 
        ' txt_tpedidos
        ' 
        txt_tpedidos.Location = New Point(24, 376)
        txt_tpedidos.Name = "txt_tpedidos"
        txt_tpedidos.Size = New Size(360, 23)
        txt_tpedidos.TabIndex = 5
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(24, 341)
        Label3.Name = "Label3"
        Label3.Size = New Size(140, 21)
        Label3.TabIndex = 4
        Label3.Text = "Total de Pedidos "
        ' 
        ' txt_media
        ' 
        txt_media.Location = New Point(24, 448)
        txt_media.Name = "txt_media"
        txt_media.Size = New Size(360, 23)
        txt_media.TabIndex = 7
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(24, 424)
        Label4.Name = "Label4"
        Label4.Size = New Size(228, 21)
        Label4.TabIndex = 6
        Label4.Text = "Média de valores por pedido"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(24, 477)
        Button1.Name = "Button1"
        Button1.Size = New Size(191, 38)
        Button1.TabIndex = 8
        Button1.Text = "Calcular Total"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(24, 136)
        Label5.Name = "Label5"
        Label5.Size = New Size(131, 21)
        Label5.TabIndex = 9
        Label5.Text = "Valores pedidos"
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(199, 44)
        Button2.Name = "Button2"
        Button2.Size = New Size(97, 80)
        Button2.TabIndex = 10
        Button2.Text = "Calcular Valores"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' lbl_maximo
        ' 
        lbl_maximo.AutoSize = True
        lbl_maximo.Location = New Point(33, 44)
        lbl_maximo.Name = "lbl_maximo"
        lbl_maximo.Size = New Size(17, 15)
        lbl_maximo.TabIndex = 11
        lbl_maximo.Text = "--"
        ' 
        ' lbl_valormedio
        ' 
        lbl_valormedio.AutoSize = True
        lbl_valormedio.Location = New Point(33, 72)
        lbl_valormedio.Name = "lbl_valormedio"
        lbl_valormedio.Size = New Size(17, 15)
        lbl_valormedio.TabIndex = 12
        lbl_valormedio.Text = "--"
        ' 
        ' lbl_valor_minimo
        ' 
        lbl_valor_minimo.AutoSize = True
        lbl_valor_minimo.Location = New Point(33, 98)
        lbl_valor_minimo.Name = "lbl_valor_minimo"
        lbl_valor_minimo.Size = New Size(17, 15)
        lbl_valor_minimo.TabIndex = 13
        lbl_valor_minimo.Text = "--"
        ' 
        ' cmd_media
        ' 
        cmd_media.Location = New Point(221, 477)
        cmd_media.Name = "cmd_media"
        cmd_media.Size = New Size(163, 38)
        cmd_media.TabIndex = 14
        cmd_media.Text = "Calcular Media"
        cmd_media.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(221, 521)
        Button3.Name = "Button3"
        Button3.Size = New Size(163, 38)
        Button3.TabIndex = 15
        Button3.Text = "Base de dados"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' estatistica
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(420, 572)
        Controls.Add(Button3)
        Controls.Add(cmd_media)
        Controls.Add(lbl_valor_minimo)
        Controls.Add(lbl_valormedio)
        Controls.Add(lbl_maximo)
        Controls.Add(Button2)
        Controls.Add(Label5)
        Controls.Add(Button1)
        Controls.Add(txt_media)
        Controls.Add(Label4)
        Controls.Add(txt_tpedidos)
        Controls.Add(Label3)
        Controls.Add(txt_totalv)
        Controls.Add(Label2)
        Controls.Add(txt_vpedidos)
        Controls.Add(Label1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "estatistica"
        Text = "estatistica"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txt_vpedidos As TextBox
    Friend WithEvents txt_totalv As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_tpedidos As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_media As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents lbl_maximo As Label
    Friend WithEvents lbl_valormedio As Label
    Friend WithEvents lbl_valor_minimo As Label
    Friend WithEvents cmd_media As Button
    Friend WithEvents Button3 As Button
End Class
