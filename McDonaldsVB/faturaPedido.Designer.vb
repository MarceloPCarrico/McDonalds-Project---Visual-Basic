<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class faturaPedido
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(faturaPedido))
        txtboxPreco = New TextBox()
        Label1 = New Label()
        lbl_total = New Label()
        TextBox1 = New TextBox()
        txtBoxQuantidade = New TextBox()
        txtboxNome = New TextBox()
        MenuStrip1 = New MenuStrip()
        FicheiroToolStripMenuItem = New ToolStripMenuItem()
        cmd_open = New ToolStripMenuItem()
        cmd_save = New ToolStripMenuItem()
        cmd_print = New ToolStripMenuItem()
        cmd_sair = New ToolStripMenuItem()
        EditarToolStripMenuItem = New ToolStripMenuItem()
        SelecionarTudoToolStripMenuItem = New ToolStripMenuItem()
        CopiarToolStripMenuItem = New ToolStripMenuItem()
        PrintPreviewDialog1 = New PrintPreviewDialog()
        PrintDocument1 = New Printing.PrintDocument()
        Label2 = New Label()
        PictureBox1 = New PictureBox()
        Label3 = New Label()
        MenuStrip1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtboxPreco
        ' 
        txtboxPreco.Location = New Point(313, 274)
        txtboxPreco.Margin = New Padding(3, 4, 3, 4)
        txtboxPreco.Multiline = True
        txtboxPreco.Name = "txtboxPreco"
        txtboxPreco.Size = New Size(117, 413)
        txtboxPreco.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(190, 687)
        Label1.Name = "Label1"
        Label1.Size = New Size(89, 37)
        Label1.TabIndex = 1
        Label1.Text = "Total:"
        ' 
        ' lbl_total
        ' 
        lbl_total.AutoSize = True
        lbl_total.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        lbl_total.Location = New Point(313, 696)
        lbl_total.Name = "lbl_total"
        lbl_total.Size = New Size(54, 25)
        lbl_total.TabIndex = 2
        lbl_total.Text = "--,--€"
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = Color.Black
        TextBox1.Font = New Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox1.ForeColor = SystemColors.Window
        TextBox1.Location = New Point(11, 48)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(419, 87)
        TextBox1.TabIndex = 3
        TextBox1.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtBoxQuantidade
        ' 
        txtBoxQuantidade.Location = New Point(190, 274)
        txtBoxQuantidade.Margin = New Padding(3, 4, 3, 4)
        txtBoxQuantidade.Multiline = True
        txtBoxQuantidade.Name = "txtBoxQuantidade"
        txtBoxQuantidade.Size = New Size(117, 413)
        txtBoxQuantidade.TabIndex = 4
        ' 
        ' txtboxNome
        ' 
        txtboxNome.Location = New Point(11, 274)
        txtboxNome.Margin = New Padding(3, 4, 3, 4)
        txtboxNome.Multiline = True
        txtboxNome.Name = "txtboxNome"
        txtboxNome.Size = New Size(170, 413)
        txtboxNome.TabIndex = 5
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {FicheiroToolStripMenuItem, EditarToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Padding = New Padding(6, 3, 0, 3)
        MenuStrip1.Size = New Size(443, 30)
        MenuStrip1.TabIndex = 6
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' FicheiroToolStripMenuItem
        ' 
        FicheiroToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {cmd_open, cmd_save, cmd_print, cmd_sair})
        FicheiroToolStripMenuItem.Name = "FicheiroToolStripMenuItem"
        FicheiroToolStripMenuItem.Size = New Size(75, 24)
        FicheiroToolStripMenuItem.Text = "Ficheiro"
        ' 
        ' cmd_open
        ' 
        cmd_open.Name = "cmd_open"
        cmd_open.Size = New Size(149, 26)
        cmd_open.Text = "Abrir"
        ' 
        ' cmd_save
        ' 
        cmd_save.Name = "cmd_save"
        cmd_save.Size = New Size(149, 26)
        cmd_save.Text = "Guardar"
        ' 
        ' cmd_print
        ' 
        cmd_print.Name = "cmd_print"
        cmd_print.Size = New Size(149, 26)
        cmd_print.Text = "Imprimir"
        ' 
        ' cmd_sair
        ' 
        cmd_sair.Name = "cmd_sair"
        cmd_sair.Size = New Size(149, 26)
        cmd_sair.Text = "Sair"
        ' 
        ' EditarToolStripMenuItem
        ' 
        EditarToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {SelecionarTudoToolStripMenuItem, CopiarToolStripMenuItem})
        EditarToolStripMenuItem.Name = "EditarToolStripMenuItem"
        EditarToolStripMenuItem.Size = New Size(62, 24)
        EditarToolStripMenuItem.Text = "Editar"
        ' 
        ' SelecionarTudoToolStripMenuItem
        ' 
        SelecionarTudoToolStripMenuItem.Name = "SelecionarTudoToolStripMenuItem"
        SelecionarTudoToolStripMenuItem.Size = New Size(199, 26)
        SelecionarTudoToolStripMenuItem.Text = "Selecionar Tudo"
        ' 
        ' CopiarToolStripMenuItem
        ' 
        CopiarToolStripMenuItem.Name = "CopiarToolStripMenuItem"
        CopiarToolStripMenuItem.Size = New Size(199, 26)
        CopiarToolStripMenuItem.Text = "Copiar"
        ' 
        ' PrintPreviewDialog1
        ' 
        PrintPreviewDialog1.AutoScrollMargin = New Size(0, 0)
        PrintPreviewDialog1.AutoScrollMinSize = New Size(0, 0)
        PrintPreviewDialog1.ClientSize = New Size(400, 300)
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.Enabled = True
        PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), Icon)
        PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        PrintPreviewDialog1.Visible = False
        ' 
        ' PrintDocument1
        ' 
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(139, 148)
        Label2.Name = "Label2"
        Label2.Size = New Size(168, 100)
        Label2.TabIndex = 7
        Label2.Text = "McDonlad's Imperial" & vbCrLf & "Praça da Liberdade, 126" & vbCrLf & "4000-322 Porto" & vbCrLf & vbCrLf & "CS: 100.00,00 EUR" & vbCrLf
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(128, 754)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(179, 166)
        PictureBox1.TabIndex = 8
        PictureBox1.TabStop = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(128, 940)
        Label3.Name = "Label3"
        Label3.Size = New Size(193, 20)
        Label3.TabIndex = 9
        Label3.Text = "Código Acesso W.C.:  2455#" & vbCrLf
        ' 
        ' faturaPedido
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImageLayout = ImageLayout.None
        ClientSize = New Size(443, 969)
        Controls.Add(Label3)
        Controls.Add(PictureBox1)
        Controls.Add(Label2)
        Controls.Add(txtboxNome)
        Controls.Add(txtBoxQuantidade)
        Controls.Add(TextBox1)
        Controls.Add(lbl_total)
        Controls.Add(Label1)
        Controls.Add(txtboxPreco)
        Controls.Add(MenuStrip1)
        Margin = New Padding(3, 4, 3, 4)
        Name = "faturaPedido"
        StartPosition = FormStartPosition.CenterScreen
        Text = "faturaPedido"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtboxPreco As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_total As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents txtBoxQuantidade As TextBox
    Friend WithEvents txtboxNome As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FicheiroToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents cmd_open As ToolStripMenuItem
    Friend WithEvents cmd_save As ToolStripMenuItem
    Friend WithEvents cmd_print As ToolStripMenuItem
    Friend WithEvents cmd_sair As ToolStripMenuItem
    Friend WithEvents SelecionarTudoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopiarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
End Class
