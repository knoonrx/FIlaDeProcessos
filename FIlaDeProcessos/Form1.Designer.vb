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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.txtTempo = New System.Windows.Forms.TextBox()
        Me.btnNovoProcesso = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Prioridade = New System.Windows.Forms.Label()
        Me.txtPrioridade = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtTrocandoFila = New System.Windows.Forms.Label()
        Me.GroupBox13 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnDistribui = New System.Windows.Forms.Button()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtAutoMaxTempo = New System.Windows.Forms.TextBox()
        Me.btnAutoCriarProcesso = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtAutoQuantidade = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtAutoProcessNome = New System.Windows.Forms.TextBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.rFast = New System.Windows.Forms.RadioButton()
        Me.rAtraso1 = New System.Windows.Forms.RadioButton()
        Me.rAtraso2 = New System.Windows.Forms.RadioButton()
        Me.rAtraso3 = New System.Windows.Forms.RadioButton()
        Me.listProcess = New System.Windows.Forms.ListView()
        Me.PID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Nome = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Tempo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Prioridades = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.listLog = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.lblCurrent = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.listSaida2 = New System.Windows.Forms.ListView()
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.listSaida1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.listSaida4 = New System.Windows.Forms.ListView()
        Me.ColumnHeader13 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader14 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader15 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader16 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox11 = New System.Windows.Forms.GroupBox()
        Me.listSaida3 = New System.Windows.Forms.ListView()
        Me.ColumnHeader17 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader18 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader19 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader20 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox12 = New System.Windows.Forms.GroupBox()
        Me.listSaida5 = New System.Windows.Forms.ListView()
        Me.ColumnHeader21 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader22 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader23 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader24 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnTestefila1 = New System.Windows.Forms.Button()
        Me.btnTestefila2 = New System.Windows.Forms.Button()
        Me.btnTestefila3 = New System.Windows.Forms.Button()
        Me.btnTestefila4 = New System.Windows.Forms.Button()
        Me.btnTestefila5 = New System.Windows.Forms.Button()
        Me.GroupBox14 = New System.Windows.Forms.GroupBox()
        Me.chkAutoAll = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox13.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        Me.GroupBox11.SuspendLayout()
        Me.GroupBox12.SuspendLayout()
        Me.GroupBox14.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtNome
        '
        Me.txtNome.Location = New System.Drawing.Point(6, 50)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(100, 20)
        Me.txtNome.TabIndex = 0
        '
        'txtTempo
        '
        Me.txtTempo.Location = New System.Drawing.Point(6, 89)
        Me.txtTempo.Name = "txtTempo"
        Me.txtTempo.Size = New System.Drawing.Size(100, 20)
        Me.txtTempo.TabIndex = 1
        '
        'btnNovoProcesso
        '
        Me.btnNovoProcesso.Location = New System.Drawing.Point(6, 160)
        Me.btnNovoProcesso.Name = "btnNovoProcesso"
        Me.btnNovoProcesso.Size = New System.Drawing.Size(100, 23)
        Me.btnNovoProcesso.TabIndex = 3
        Me.btnNovoProcesso.Text = "Criar"
        Me.btnNovoProcesso.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Nome"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Tempo"
        '
        'Prioridade
        '
        Me.Prioridade.AutoSize = True
        Me.Prioridade.Location = New System.Drawing.Point(6, 114)
        Me.Prioridade.Name = "Prioridade"
        Me.Prioridade.Size = New System.Drawing.Size(54, 13)
        Me.Prioridade.TabIndex = 6
        Me.Prioridade.Text = "Prioridade"
        '
        'txtPrioridade
        '
        Me.txtPrioridade.Location = New System.Drawing.Point(6, 130)
        Me.txtPrioridade.Name = "txtPrioridade"
        Me.txtPrioridade.Size = New System.Drawing.Size(100, 20)
        Me.txtPrioridade.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtTrocandoFila)
        Me.GroupBox1.Controls.Add(Me.GroupBox13)
        Me.GroupBox1.Controls.Add(Me.btnDistribui)
        Me.GroupBox1.Controls.Add(Me.GroupBox7)
        Me.GroupBox1.Controls.Add(Me.GroupBox6)
        Me.GroupBox1.Controls.Add(Me.GroupBox5)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 20)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(491, 333)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Controles"
        '
        'txtTrocandoFila
        '
        Me.txtTrocandoFila.AutoSize = True
        Me.txtTrocandoFila.Location = New System.Drawing.Point(9, 306)
        Me.txtTrocandoFila.Name = "txtTrocandoFila"
        Me.txtTrocandoFila.Size = New System.Drawing.Size(0, 13)
        Me.txtTrocandoFila.TabIndex = 24
        '
        'GroupBox13
        '
        Me.GroupBox13.Controls.Add(Me.Label7)
        Me.GroupBox13.Controls.Add(Me.Label8)
        Me.GroupBox13.Location = New System.Drawing.Point(240, 143)
        Me.GroupBox13.Name = "GroupBox13"
        Me.GroupBox13.Size = New System.Drawing.Size(245, 110)
        Me.GroupBox13.TabIndex = 15
        Me.GroupBox13.TabStop = False
        Me.GroupBox13.Text = "Observação:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(97, 20)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(0, 13)
        Me.Label7.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 20)
        Me.Label8.MaximumSize = New System.Drawing.Size(220, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(219, 65)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Criar muitos processos ao mesmo tempo pode causar lentidão no sistema , se o prog" &
    "rama deixar de responder, não faça nada, apenas aguarde o fim da operação em and" &
    "amento."
        '
        'btnDistribui
        '
        Me.btnDistribui.Location = New System.Drawing.Point(6, 224)
        Me.btnDistribui.Name = "btnDistribui"
        Me.btnDistribui.Size = New System.Drawing.Size(228, 52)
        Me.btnDistribui.TabIndex = 23
        Me.btnDistribui.Text = "Distribuir Processos"
        Me.btnDistribui.UseVisualStyleBackColor = True
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.Label1)
        Me.GroupBox7.Controls.Add(Me.Label2)
        Me.GroupBox7.Controls.Add(Me.txtPrioridade)
        Me.GroupBox7.Controls.Add(Me.btnNovoProcesso)
        Me.GroupBox7.Controls.Add(Me.Prioridade)
        Me.GroupBox7.Controls.Add(Me.txtNome)
        Me.GroupBox7.Controls.Add(Me.txtTempo)
        Me.GroupBox7.Location = New System.Drawing.Point(6, 29)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(113, 189)
        Me.GroupBox7.TabIndex = 22
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Novo Processo"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.Label6)
        Me.GroupBox6.Controls.Add(Me.txtAutoMaxTempo)
        Me.GroupBox6.Controls.Add(Me.btnAutoCriarProcesso)
        Me.GroupBox6.Controls.Add(Me.Label5)
        Me.GroupBox6.Controls.Add(Me.txtAutoQuantidade)
        Me.GroupBox6.Controls.Add(Me.Label4)
        Me.GroupBox6.Controls.Add(Me.txtAutoProcessNome)
        Me.GroupBox6.Location = New System.Drawing.Point(125, 29)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(109, 189)
        Me.GroupBox6.TabIndex = 17
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Auto Criar Processos"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 115)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Tempo Maximo"
        '
        'txtAutoMaxTempo
        '
        Me.txtAutoMaxTempo.Location = New System.Drawing.Point(6, 131)
        Me.txtAutoMaxTempo.Name = "txtAutoMaxTempo"
        Me.txtAutoMaxTempo.Size = New System.Drawing.Size(97, 20)
        Me.txtAutoMaxTempo.TabIndex = 21
        '
        'btnAutoCriarProcesso
        '
        Me.btnAutoCriarProcesso.Location = New System.Drawing.Point(6, 160)
        Me.btnAutoCriarProcesso.Name = "btnAutoCriarProcesso"
        Me.btnAutoCriarProcesso.Size = New System.Drawing.Size(97, 23)
        Me.btnAutoCriarProcesso.TabIndex = 22
        Me.btnAutoCriarProcesso.Text = "Gerar"
        Me.btnAutoCriarProcesso.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 73)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 13)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Quantidade"
        '
        'txtAutoQuantidade
        '
        Me.txtAutoQuantidade.Location = New System.Drawing.Point(6, 89)
        Me.txtAutoQuantidade.Name = "txtAutoQuantidade"
        Me.txtAutoQuantidade.Size = New System.Drawing.Size(97, 20)
        Me.txtAutoQuantidade.TabIndex = 20
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 34)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Nome"
        '
        'txtAutoProcessNome
        '
        Me.txtAutoProcessNome.Location = New System.Drawing.Point(6, 50)
        Me.txtAutoProcessNome.Name = "txtAutoProcessNome"
        Me.txtAutoProcessNome.Size = New System.Drawing.Size(97, 20)
        Me.txtAutoProcessNome.TabIndex = 18
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.rFast)
        Me.GroupBox5.Controls.Add(Me.rAtraso1)
        Me.GroupBox5.Controls.Add(Me.rAtraso2)
        Me.GroupBox5.Controls.Add(Me.rAtraso3)
        Me.GroupBox5.Location = New System.Drawing.Point(240, 29)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(245, 110)
        Me.GroupBox5.TabIndex = 15
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Atrazo"
        '
        'rFast
        '
        Me.rFast.AutoSize = True
        Me.rFast.Location = New System.Drawing.Point(24, 87)
        Me.rFast.Name = "rFast"
        Me.rFast.Size = New System.Drawing.Size(90, 17)
        Me.rFast.TabIndex = 3
        Me.rFast.Text = "Super Rápido"
        Me.rFast.UseVisualStyleBackColor = True
        '
        'rAtraso1
        '
        Me.rAtraso1.AutoSize = True
        Me.rAtraso1.Location = New System.Drawing.Point(24, 65)
        Me.rAtraso1.Name = "rAtraso1"
        Me.rAtraso1.Size = New System.Drawing.Size(80, 17)
        Me.rAtraso1.TabIndex = 2
        Me.rAtraso1.Text = "1 segundos"
        Me.rAtraso1.UseVisualStyleBackColor = True
        '
        'rAtraso2
        '
        Me.rAtraso2.AutoSize = True
        Me.rAtraso2.Location = New System.Drawing.Point(24, 42)
        Me.rAtraso2.Name = "rAtraso2"
        Me.rAtraso2.Size = New System.Drawing.Size(80, 17)
        Me.rAtraso2.TabIndex = 1
        Me.rAtraso2.Text = "2 segundos"
        Me.rAtraso2.UseVisualStyleBackColor = True
        '
        'rAtraso3
        '
        Me.rAtraso3.AutoSize = True
        Me.rAtraso3.Checked = True
        Me.rAtraso3.Location = New System.Drawing.Point(24, 19)
        Me.rAtraso3.Name = "rAtraso3"
        Me.rAtraso3.Size = New System.Drawing.Size(80, 17)
        Me.rAtraso3.TabIndex = 0
        Me.rAtraso3.TabStop = True
        Me.rAtraso3.Text = "3 segundos"
        Me.rAtraso3.UseVisualStyleBackColor = True
        '
        'listProcess
        '
        Me.listProcess.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.PID, Me.Nome, Me.Tempo, Me.Prioridades})
        Me.listProcess.Location = New System.Drawing.Point(6, 14)
        Me.listProcess.Name = "listProcess"
        Me.listProcess.Size = New System.Drawing.Size(217, 313)
        Me.listProcess.TabIndex = 11
        Me.listProcess.UseCompatibleStateImageBehavior = False
        Me.listProcess.View = System.Windows.Forms.View.Details
        '
        'PID
        '
        Me.PID.Text = "PID"
        Me.PID.Width = 30
        '
        'Nome
        '
        Me.Nome.Text = "Nome"
        Me.Nome.Width = 50
        '
        'Tempo
        '
        Me.Tempo.Text = "Tempo"
        Me.Tempo.Width = 50
        '
        'Prioridades
        '
        Me.Prioridades.Text = "Prioridade"
        Me.Prioridades.Width = 50
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.listProcess)
        Me.GroupBox2.Location = New System.Drawing.Point(729, 20)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(230, 333)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Fila Inicial"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.listLog)
        Me.GroupBox3.Location = New System.Drawing.Point(969, 20)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(230, 333)
        Me.GroupBox3.TabIndex = 13
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Fila Final"
        '
        'listLog
        '
        Me.listLog.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.listLog.Location = New System.Drawing.Point(6, 14)
        Me.listLog.Name = "listLog"
        Me.listLog.Size = New System.Drawing.Size(217, 313)
        Me.listLog.TabIndex = 11
        Me.listLog.UseCompatibleStateImageBehavior = False
        Me.listLog.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "PID"
        Me.ColumnHeader1.Width = 30
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Nome"
        Me.ColumnHeader2.Width = 50
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Tempo"
        Me.ColumnHeader3.Width = 50
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Prioridade"
        Me.ColumnHeader4.Width = 50
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.lblCurrent)
        Me.GroupBox4.Location = New System.Drawing.Point(509, 20)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(214, 100)
        Me.GroupBox4.TabIndex = 14
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Ações"
        '
        'lblCurrent
        '
        Me.lblCurrent.AutoSize = True
        Me.lblCurrent.Location = New System.Drawing.Point(6, 16)
        Me.lblCurrent.Name = "lblCurrent"
        Me.lblCurrent.Size = New System.Drawing.Size(0, 13)
        Me.lblCurrent.TabIndex = 1
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 709)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1217, 22)
        Me.StatusStrip1.TabIndex = 15
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(0, 17)
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(120, 17)
        Me.ToolStripStatusLabel2.Text = "ToolStripStatusLabel2"
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.listSaida2)
        Me.GroupBox8.Location = New System.Drawing.Point(252, 359)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(230, 333)
        Me.GroupBox8.TabIndex = 17
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Fila 2"
        '
        'listSaida2
        '
        Me.listSaida2.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8})
        Me.listSaida2.Location = New System.Drawing.Point(6, 14)
        Me.listSaida2.Name = "listSaida2"
        Me.listSaida2.Size = New System.Drawing.Size(217, 313)
        Me.listSaida2.TabIndex = 11
        Me.listSaida2.UseCompatibleStateImageBehavior = False
        Me.listSaida2.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "PID"
        Me.ColumnHeader5.Width = 30
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Nome"
        Me.ColumnHeader6.Width = 50
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Tempo"
        Me.ColumnHeader7.Width = 50
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Prioridade"
        Me.ColumnHeader8.Width = 50
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.listSaida1)
        Me.GroupBox9.Location = New System.Drawing.Point(12, 359)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(230, 333)
        Me.GroupBox9.TabIndex = 16
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "Fila 1"
        '
        'listSaida1
        '
        Me.listSaida1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader9, Me.ColumnHeader10, Me.ColumnHeader11, Me.ColumnHeader12})
        Me.listSaida1.Location = New System.Drawing.Point(6, 14)
        Me.listSaida1.Name = "listSaida1"
        Me.listSaida1.Size = New System.Drawing.Size(217, 313)
        Me.listSaida1.TabIndex = 11
        Me.listSaida1.UseCompatibleStateImageBehavior = False
        Me.listSaida1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "PID"
        Me.ColumnHeader9.Width = 30
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Nome"
        Me.ColumnHeader10.Width = 50
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "Tempo"
        Me.ColumnHeader11.Width = 50
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "Prioridade"
        Me.ColumnHeader12.Width = 50
        '
        'GroupBox10
        '
        Me.GroupBox10.Controls.Add(Me.listSaida4)
        Me.GroupBox10.Location = New System.Drawing.Point(729, 359)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(230, 333)
        Me.GroupBox10.TabIndex = 19
        Me.GroupBox10.TabStop = False
        Me.GroupBox10.Text = "Fila 4"
        '
        'listSaida4
        '
        Me.listSaida4.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader13, Me.ColumnHeader14, Me.ColumnHeader15, Me.ColumnHeader16})
        Me.listSaida4.Location = New System.Drawing.Point(6, 14)
        Me.listSaida4.Name = "listSaida4"
        Me.listSaida4.Size = New System.Drawing.Size(217, 313)
        Me.listSaida4.TabIndex = 11
        Me.listSaida4.UseCompatibleStateImageBehavior = False
        Me.listSaida4.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader13
        '
        Me.ColumnHeader13.Text = "PID"
        Me.ColumnHeader13.Width = 30
        '
        'ColumnHeader14
        '
        Me.ColumnHeader14.Text = "Nome"
        Me.ColumnHeader14.Width = 50
        '
        'ColumnHeader15
        '
        Me.ColumnHeader15.Text = "Tempo"
        Me.ColumnHeader15.Width = 50
        '
        'ColumnHeader16
        '
        Me.ColumnHeader16.Text = "Prioridade"
        Me.ColumnHeader16.Width = 50
        '
        'GroupBox11
        '
        Me.GroupBox11.Controls.Add(Me.listSaida3)
        Me.GroupBox11.Location = New System.Drawing.Point(488, 359)
        Me.GroupBox11.Name = "GroupBox11"
        Me.GroupBox11.Size = New System.Drawing.Size(230, 333)
        Me.GroupBox11.TabIndex = 18
        Me.GroupBox11.TabStop = False
        Me.GroupBox11.Text = "Fila 3"
        '
        'listSaida3
        '
        Me.listSaida3.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader17, Me.ColumnHeader18, Me.ColumnHeader19, Me.ColumnHeader20})
        Me.listSaida3.Location = New System.Drawing.Point(6, 14)
        Me.listSaida3.Name = "listSaida3"
        Me.listSaida3.Size = New System.Drawing.Size(217, 313)
        Me.listSaida3.TabIndex = 11
        Me.listSaida3.UseCompatibleStateImageBehavior = False
        Me.listSaida3.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader17
        '
        Me.ColumnHeader17.Text = "PID"
        Me.ColumnHeader17.Width = 30
        '
        'ColumnHeader18
        '
        Me.ColumnHeader18.Text = "Nome"
        Me.ColumnHeader18.Width = 50
        '
        'ColumnHeader19
        '
        Me.ColumnHeader19.Text = "Tempo"
        Me.ColumnHeader19.Width = 50
        '
        'ColumnHeader20
        '
        Me.ColumnHeader20.Text = "Prioridade"
        Me.ColumnHeader20.Width = 50
        '
        'GroupBox12
        '
        Me.GroupBox12.Controls.Add(Me.listSaida5)
        Me.GroupBox12.Location = New System.Drawing.Point(969, 359)
        Me.GroupBox12.Name = "GroupBox12"
        Me.GroupBox12.Size = New System.Drawing.Size(230, 333)
        Me.GroupBox12.TabIndex = 20
        Me.GroupBox12.TabStop = False
        Me.GroupBox12.Text = "Fila 5"
        '
        'listSaida5
        '
        Me.listSaida5.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader21, Me.ColumnHeader22, Me.ColumnHeader23, Me.ColumnHeader24})
        Me.listSaida5.Location = New System.Drawing.Point(6, 14)
        Me.listSaida5.Name = "listSaida5"
        Me.listSaida5.Size = New System.Drawing.Size(217, 313)
        Me.listSaida5.TabIndex = 11
        Me.listSaida5.UseCompatibleStateImageBehavior = False
        Me.listSaida5.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader21
        '
        Me.ColumnHeader21.Text = "PID"
        Me.ColumnHeader21.Width = 30
        '
        'ColumnHeader22
        '
        Me.ColumnHeader22.Text = "Nome"
        Me.ColumnHeader22.Width = 50
        '
        'ColumnHeader23
        '
        Me.ColumnHeader23.Text = "Tempo"
        Me.ColumnHeader23.Width = 50
        '
        'ColumnHeader24
        '
        Me.ColumnHeader24.Text = "Prioridade"
        Me.ColumnHeader24.Width = 50
        '
        'btnTestefila1
        '
        Me.btnTestefila1.Location = New System.Drawing.Point(6, 19)
        Me.btnTestefila1.Name = "btnTestefila1"
        Me.btnTestefila1.Size = New System.Drawing.Size(202, 23)
        Me.btnTestefila1.TabIndex = 21
        Me.btnTestefila1.Text = "Processar Fila 1"
        Me.btnTestefila1.UseVisualStyleBackColor = True
        '
        'btnTestefila2
        '
        Me.btnTestefila2.Location = New System.Drawing.Point(5, 48)
        Me.btnTestefila2.Name = "btnTestefila2"
        Me.btnTestefila2.Size = New System.Drawing.Size(203, 23)
        Me.btnTestefila2.TabIndex = 22
        Me.btnTestefila2.Text = "Processar Fila 2"
        Me.btnTestefila2.UseVisualStyleBackColor = True
        '
        'btnTestefila3
        '
        Me.btnTestefila3.Location = New System.Drawing.Point(5, 77)
        Me.btnTestefila3.Name = "btnTestefila3"
        Me.btnTestefila3.Size = New System.Drawing.Size(203, 23)
        Me.btnTestefila3.TabIndex = 23
        Me.btnTestefila3.Text = "Processar Fila 3"
        Me.btnTestefila3.UseVisualStyleBackColor = True
        '
        'btnTestefila4
        '
        Me.btnTestefila4.Location = New System.Drawing.Point(5, 106)
        Me.btnTestefila4.Name = "btnTestefila4"
        Me.btnTestefila4.Size = New System.Drawing.Size(203, 23)
        Me.btnTestefila4.TabIndex = 24
        Me.btnTestefila4.Text = "Processar Fila 4"
        Me.btnTestefila4.UseVisualStyleBackColor = True
        '
        'btnTestefila5
        '
        Me.btnTestefila5.Location = New System.Drawing.Point(6, 135)
        Me.btnTestefila5.Name = "btnTestefila5"
        Me.btnTestefila5.Size = New System.Drawing.Size(202, 23)
        Me.btnTestefila5.TabIndex = 25
        Me.btnTestefila5.Text = "Processar Fila 5"
        Me.btnTestefila5.UseVisualStyleBackColor = True
        '
        'GroupBox14
        '
        Me.GroupBox14.Controls.Add(Me.chkAutoAll)
        Me.GroupBox14.Controls.Add(Me.Button1)
        Me.GroupBox14.Controls.Add(Me.btnTestefila1)
        Me.GroupBox14.Controls.Add(Me.btnTestefila5)
        Me.GroupBox14.Controls.Add(Me.btnTestefila2)
        Me.GroupBox14.Controls.Add(Me.btnTestefila4)
        Me.GroupBox14.Controls.Add(Me.btnTestefila3)
        Me.GroupBox14.Location = New System.Drawing.Point(509, 120)
        Me.GroupBox14.Name = "GroupBox14"
        Me.GroupBox14.Size = New System.Drawing.Size(214, 233)
        Me.GroupBox14.TabIndex = 15
        Me.GroupBox14.TabStop = False
        Me.GroupBox14.Text = "Ações"
        '
        'chkAutoAll
        '
        Me.chkAutoAll.AutoSize = True
        Me.chkAutoAll.Location = New System.Drawing.Point(5, 206)
        Me.chkAutoAll.Name = "chkAutoAll"
        Me.chkAutoAll.Size = New System.Drawing.Size(79, 17)
        Me.chkAutoAll.TabIndex = 24
        Me.chkAutoAll.Text = "Automático"
        Me.chkAutoAll.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.HighlightText
        Me.Button1.Location = New System.Drawing.Point(6, 177)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(202, 23)
        Me.Button1.TabIndex = 26
        Me.Button1.Text = "Processar Todas"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1217, 731)
        Me.Controls.Add(Me.GroupBox14)
        Me.Controls.Add(Me.GroupBox12)
        Me.Controls.Add(Me.GroupBox10)
        Me.Controls.Add(Me.GroupBox11)
        Me.Controls.Add(Me.GroupBox8)
        Me.Controls.Add(Me.GroupBox9)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ProcesSIM"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox13.ResumeLayout(False)
        Me.GroupBox13.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox11.ResumeLayout(False)
        Me.GroupBox12.ResumeLayout(False)
        Me.GroupBox14.ResumeLayout(False)
        Me.GroupBox14.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtNome As System.Windows.Forms.TextBox
    Friend WithEvents txtTempo As System.Windows.Forms.TextBox
    Friend WithEvents btnNovoProcesso As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Prioridade As System.Windows.Forms.Label
    Friend WithEvents txtPrioridade As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents listProcess As ListView
    Friend WithEvents PID As ColumnHeader
    Friend WithEvents Nome As ColumnHeader
    Friend WithEvents Tempo As ColumnHeader
    Friend WithEvents Prioridades As ColumnHeader
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents listLog As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents lblCurrent As Label
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents rAtraso1 As RadioButton
    Friend WithEvents rAtraso2 As RadioButton
    Friend WithEvents rAtraso3 As RadioButton
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents btnAutoCriarProcesso As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents txtAutoQuantidade As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtAutoProcessNome As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtAutoMaxTempo As TextBox
    Friend WithEvents rFast As RadioButton
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As ToolStripStatusLabel
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents listSaida2 As ListView
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents GroupBox9 As GroupBox
    Friend WithEvents listSaida1 As ListView
    Friend WithEvents ColumnHeader9 As ColumnHeader
    Friend WithEvents ColumnHeader10 As ColumnHeader
    Friend WithEvents ColumnHeader11 As ColumnHeader
    Friend WithEvents ColumnHeader12 As ColumnHeader
    Friend WithEvents GroupBox10 As GroupBox
    Friend WithEvents listSaida4 As ListView
    Friend WithEvents ColumnHeader13 As ColumnHeader
    Friend WithEvents ColumnHeader14 As ColumnHeader
    Friend WithEvents ColumnHeader15 As ColumnHeader
    Friend WithEvents ColumnHeader16 As ColumnHeader
    Friend WithEvents GroupBox11 As GroupBox
    Friend WithEvents listSaida3 As ListView
    Friend WithEvents ColumnHeader17 As ColumnHeader
    Friend WithEvents ColumnHeader18 As ColumnHeader
    Friend WithEvents ColumnHeader19 As ColumnHeader
    Friend WithEvents ColumnHeader20 As ColumnHeader
    Friend WithEvents GroupBox12 As GroupBox
    Friend WithEvents listSaida5 As ListView
    Friend WithEvents ColumnHeader21 As ColumnHeader
    Friend WithEvents ColumnHeader22 As ColumnHeader
    Friend WithEvents ColumnHeader23 As ColumnHeader
    Friend WithEvents ColumnHeader24 As ColumnHeader
    Friend WithEvents GroupBox13 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents btnDistribui As Button
    Friend WithEvents btnTestefila1 As Button
    Friend WithEvents btnTestefila2 As Button
    Friend WithEvents btnTestefila3 As Button
    Friend WithEvents btnTestefila4 As Button
    Friend WithEvents btnTestefila5 As Button
    Friend WithEvents GroupBox14 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents chkAutoAll As CheckBox
    Friend WithEvents txtTrocandoFila As Label
End Class
