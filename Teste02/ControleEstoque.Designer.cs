namespace Teste02
{
    partial class ControleEstoque
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControleEstoque));
            this.label_equipamentos = new System.Windows.Forms.Label();
            this.label_chamados = new System.Windows.Forms.Label();
            this.listView_Equip = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView_Chamados = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label_NSerieA = new System.Windows.Forms.Label();
            this.label_FabricanteA = new System.Windows.Forms.Label();
            this.label_ValorA = new System.Windows.Forms.Label();
            this.label_DataFabricacaoA = new System.Windows.Forms.Label();
            this.label_NomeA = new System.Windows.Forms.Label();
            this.textBox_ValorA = new System.Windows.Forms.TextBox();
            this.button_CancelarA = new System.Windows.Forms.Button();
            this.button_AddAb = new System.Windows.Forms.Button();
            this.textBox_NSerieA = new System.Windows.Forms.TextBox();
            this.textBox_FabricanteA = new System.Windows.Forms.TextBox();
            this.textBox_NomeA = new System.Windows.Forms.TextBox();
            this.label_EquipB = new System.Windows.Forms.Label();
            this.label_DescricaoB = new System.Windows.Forms.Label();
            this.label_DataAberB = new System.Windows.Forms.Label();
            this.label_TituloB = new System.Windows.Forms.Label();
            this.textBox_DescricaoB = new System.Windows.Forms.TextBox();
            this.textBox_EquipB = new System.Windows.Forms.TextBox();
            this.textBox_TituloBb = new System.Windows.Forms.TextBox();
            this.button_CancelarB = new System.Windows.Forms.Button();
            this.button_AddB = new System.Windows.Forms.Button();
            this.button_ExcluirB = new System.Windows.Forms.Button();
            this.button_EditarB = new System.Windows.Forms.Button();
            this.button_ExcluirA = new System.Windows.Forms.Button();
            this.button_EditarA = new System.Windows.Forms.Button();
            this.masktextBox_DataAberBb = new System.Windows.Forms.MaskedTextBox();
            this.maskTextBox_DataFabricacaoA = new System.Windows.Forms.MaskedTextBox();
            this.button_aceitarA = new System.Windows.Forms.Button();
            this.button_cancelarAb = new System.Windows.Forms.Button();
            this.button_cancelarBb = new System.Windows.Forms.Button();
            this.button_aceitarB = new System.Windows.Forms.Button();
            this.listView_EquipHide = new System.Windows.Forms.ListView();
            this.ValorOculto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DataOculta = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label_aviso = new System.Windows.Forms.Label();
            this.label_AvisoA = new System.Windows.Forms.Label();
            this.label_AvisoB = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_equipamentos
            // 
            this.label_equipamentos.AutoSize = true;
            this.label_equipamentos.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_equipamentos.Location = new System.Drawing.Point(8, 18);
            this.label_equipamentos.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.label_equipamentos.Name = "label_equipamentos";
            this.label_equipamentos.Size = new System.Drawing.Size(113, 19);
            this.label_equipamentos.TabIndex = 7;
            this.label_equipamentos.Text = "Equipamentos";
            // 
            // label_chamados
            // 
            this.label_chamados.AutoSize = true;
            this.label_chamados.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_chamados.Location = new System.Drawing.Point(501, 18);
            this.label_chamados.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.label_chamados.Name = "label_chamados";
            this.label_chamados.Size = new System.Drawing.Size(85, 19);
            this.label_chamados.TabIndex = 8;
            this.label_chamados.Text = "Chamados";
            // 
            // listView_Equip
            // 
            this.listView_Equip.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listView_Equip.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView_Equip.FullRowSelect = true;
            this.listView_Equip.GridLines = true;
            this.listView_Equip.HideSelection = false;
            this.listView_Equip.LabelEdit = true;
            this.listView_Equip.Location = new System.Drawing.Point(12, 43);
            this.listView_Equip.Name = "listView_Equip";
            this.listView_Equip.Size = new System.Drawing.Size(487, 362);
            this.listView_Equip.TabIndex = 9;
            this.listView_Equip.TabStop = false;
            this.listView_Equip.Tag = "";
            this.listView_Equip.UseCompatibleStateImageBehavior = false;
            this.listView_Equip.View = System.Windows.Forms.View.Details;
            this.listView_Equip.SelectedIndexChanged += new System.EventHandler(this.listView_Equip_SelectedIndexChanged_1);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nome";
            this.columnHeader1.Width = 154;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Número de Série";
            this.columnHeader2.Width = 193;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Fabricante";
            this.columnHeader3.Width = 136;
            // 
            // listView_Chamados
            // 
            this.listView_Chamados.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listView_Chamados.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.listView_Chamados.FullRowSelect = true;
            this.listView_Chamados.GridLines = true;
            this.listView_Chamados.HideSelection = false;
            this.listView_Chamados.LabelEdit = true;
            this.listView_Chamados.Location = new System.Drawing.Point(505, 43);
            this.listView_Chamados.Name = "listView_Chamados";
            this.listView_Chamados.Size = new System.Drawing.Size(664, 362);
            this.listView_Chamados.TabIndex = 10;
            this.listView_Chamados.TabStop = false;
            this.listView_Chamados.Tag = "";
            this.listView_Chamados.UseCompatibleStateImageBehavior = false;
            this.listView_Chamados.View = System.Windows.Forms.View.Details;
            this.listView_Chamados.SelectedIndexChanged += new System.EventHandler(this.listView_Chamados_SelectedIndexChanged);
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Título";
            this.columnHeader4.Width = 107;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Equipamento";
            this.columnHeader5.Width = 107;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Data de Abertura";
            this.columnHeader6.Width = 93;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Descrição";
            this.columnHeader7.Width = 353;
            // 
            // label_NSerieA
            // 
            this.label_NSerieA.AutoSize = true;
            this.label_NSerieA.Location = new System.Drawing.Point(48, 617);
            this.label_NSerieA.Name = "label_NSerieA";
            this.label_NSerieA.Size = new System.Drawing.Size(53, 13);
            this.label_NSerieA.TabIndex = 25;
            this.label_NSerieA.Text = "* N° Série";
            // 
            // label_FabricanteA
            // 
            this.label_FabricanteA.AutoSize = true;
            this.label_FabricanteA.Location = new System.Drawing.Point(48, 537);
            this.label_FabricanteA.Name = "label_FabricanteA";
            this.label_FabricanteA.Size = new System.Drawing.Size(64, 13);
            this.label_FabricanteA.TabIndex = 24;
            this.label_FabricanteA.Text = "* Fabricante";
            // 
            // label_ValorA
            // 
            this.label_ValorA.AutoSize = true;
            this.label_ValorA.Location = new System.Drawing.Point(209, 460);
            this.label_ValorA.Name = "label_ValorA";
            this.label_ValorA.Size = new System.Drawing.Size(87, 13);
            this.label_ValorA.TabIndex = 23;
            this.label_ValorA.Text = "* Valor Aquisição";
            // 
            // label_DataFabricacaoA
            // 
            this.label_DataFabricacaoA.AutoSize = true;
            this.label_DataFabricacaoA.Location = new System.Drawing.Point(211, 537);
            this.label_DataFabricacaoA.Name = "label_DataFabricacaoA";
            this.label_DataFabricacaoA.Size = new System.Drawing.Size(108, 13);
            this.label_DataFabricacaoA.TabIndex = 22;
            this.label_DataFabricacaoA.Text = "* Data de Fabricação";
            // 
            // label_NomeA
            // 
            this.label_NomeA.AutoSize = true;
            this.label_NomeA.Location = new System.Drawing.Point(48, 461);
            this.label_NomeA.Name = "label_NomeA";
            this.label_NomeA.Size = new System.Drawing.Size(42, 13);
            this.label_NomeA.TabIndex = 21;
            this.label_NomeA.Text = "* Nome";
            // 
            // textBox_ValorA
            // 
            this.textBox_ValorA.Location = new System.Drawing.Point(217, 477);
            this.textBox_ValorA.Name = "textBox_ValorA";
            this.textBox_ValorA.Size = new System.Drawing.Size(123, 20);
            this.textBox_ValorA.TabIndex = 2;
            // 
            // button_CancelarA
            // 
            this.button_CancelarA.Location = new System.Drawing.Point(356, 507);
            this.button_CancelarA.Name = "button_CancelarA";
            this.button_CancelarA.Size = new System.Drawing.Size(99, 23);
            this.button_CancelarA.TabIndex = 20;
            this.button_CancelarA.TabStop = false;
            this.button_CancelarA.Text = "&Cancelar";
            this.button_CancelarA.UseVisualStyleBackColor = true;
            this.button_CancelarA.Click += new System.EventHandler(this.button_CancelarA_Click);
            // 
            // button_AddAb
            // 
            this.button_AddAb.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button_AddAb.Location = new System.Drawing.Point(356, 475);
            this.button_AddAb.Name = "button_AddAb";
            this.button_AddAb.Size = new System.Drawing.Size(99, 23);
            this.button_AddAb.TabIndex = 6;
            this.button_AddAb.Text = "&Adicionar";
            this.button_AddAb.UseVisualStyleBackColor = true;
            this.button_AddAb.Click += new System.EventHandler(this.button_addAb_Click);
            // 
            // textBox_NSerieA
            // 
            this.textBox_NSerieA.Location = new System.Drawing.Point(59, 633);
            this.textBox_NSerieA.Name = "textBox_NSerieA";
            this.textBox_NSerieA.Size = new System.Drawing.Size(123, 20);
            this.textBox_NSerieA.TabIndex = 5;
            // 
            // textBox_FabricanteA
            // 
            this.textBox_FabricanteA.Location = new System.Drawing.Point(56, 553);
            this.textBox_FabricanteA.Name = "textBox_FabricanteA";
            this.textBox_FabricanteA.Size = new System.Drawing.Size(123, 20);
            this.textBox_FabricanteA.TabIndex = 3;
            // 
            // textBox_NomeA
            // 
            this.textBox_NomeA.BackColor = System.Drawing.SystemColors.Window;
            this.textBox_NomeA.Location = new System.Drawing.Point(56, 477);
            this.textBox_NomeA.Name = "textBox_NomeA";
            this.textBox_NomeA.Size = new System.Drawing.Size(123, 20);
            this.textBox_NomeA.TabIndex = 0;
            // 
            // label_EquipB
            // 
            this.label_EquipB.AutoSize = true;
            this.label_EquipB.Location = new System.Drawing.Point(602, 537);
            this.label_EquipB.Name = "label_EquipB";
            this.label_EquipB.Size = new System.Drawing.Size(76, 13);
            this.label_EquipB.TabIndex = 33;
            this.label_EquipB.Text = "* Equipamento";
            // 
            // label_DescricaoB
            // 
            this.label_DescricaoB.AutoSize = true;
            this.label_DescricaoB.Location = new System.Drawing.Point(746, 461);
            this.label_DescricaoB.Name = "label_DescricaoB";
            this.label_DescricaoB.Size = new System.Drawing.Size(62, 13);
            this.label_DescricaoB.TabIndex = 32;
            this.label_DescricaoB.Text = "* Descrição";
            // 
            // label_DataAberB
            // 
            this.label_DataAberB.AutoSize = true;
            this.label_DataAberB.Location = new System.Drawing.Point(602, 617);
            this.label_DataAberB.Name = "label_DataAberB";
            this.label_DataAberB.Size = new System.Drawing.Size(95, 13);
            this.label_DataAberB.TabIndex = 31;
            this.label_DataAberB.Text = "* Data de Abertura";
            // 
            // label_TituloB
            // 
            this.label_TituloB.AutoSize = true;
            this.label_TituloB.Location = new System.Drawing.Point(602, 461);
            this.label_TituloB.Name = "label_TituloB";
            this.label_TituloB.Size = new System.Drawing.Size(42, 13);
            this.label_TituloB.TabIndex = 30;
            this.label_TituloB.Text = "* Título";
            // 
            // textBox_DescricaoB
            // 
            this.textBox_DescricaoB.Location = new System.Drawing.Point(755, 477);
            this.textBox_DescricaoB.Multiline = true;
            this.textBox_DescricaoB.Name = "textBox_DescricaoB";
            this.textBox_DescricaoB.Size = new System.Drawing.Size(188, 176);
            this.textBox_DescricaoB.TabIndex = 10;
            // 
            // textBox_EquipB
            // 
            this.textBox_EquipB.BackColor = System.Drawing.SystemColors.Window;
            this.textBox_EquipB.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox_EquipB.Location = new System.Drawing.Point(609, 553);
            this.textBox_EquipB.Name = "textBox_EquipB";
            this.textBox_EquipB.Size = new System.Drawing.Size(123, 20);
            this.textBox_EquipB.TabIndex = 8;
            // 
            // textBox_TituloBb
            // 
            this.textBox_TituloBb.Location = new System.Drawing.Point(609, 477);
            this.textBox_TituloBb.Name = "textBox_TituloBb";
            this.textBox_TituloBb.Size = new System.Drawing.Size(123, 20);
            this.textBox_TituloBb.TabIndex = 7;
            // 
            // button_CancelarB
            // 
            this.button_CancelarB.Location = new System.Drawing.Point(966, 509);
            this.button_CancelarB.Name = "button_CancelarB";
            this.button_CancelarB.Size = new System.Drawing.Size(99, 23);
            this.button_CancelarB.TabIndex = 35;
            this.button_CancelarB.TabStop = false;
            this.button_CancelarB.Text = "&Cancelar";
            this.button_CancelarB.UseVisualStyleBackColor = true;
            this.button_CancelarB.Click += new System.EventHandler(this.button_CancelarB_Click);
            // 
            // button_AddB
            // 
            this.button_AddB.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button_AddB.Location = new System.Drawing.Point(966, 477);
            this.button_AddB.Name = "button_AddB";
            this.button_AddB.Size = new System.Drawing.Size(99, 23);
            this.button_AddB.TabIndex = 11;
            this.button_AddB.Text = "&Adicionar";
            this.button_AddB.UseVisualStyleBackColor = true;
            this.button_AddB.Click += new System.EventHandler(this.button_addB_Click);
            // 
            // button_ExcluirB
            // 
            this.button_ExcluirB.Location = new System.Drawing.Point(966, 630);
            this.button_ExcluirB.Name = "button_ExcluirB";
            this.button_ExcluirB.Size = new System.Drawing.Size(99, 23);
            this.button_ExcluirB.TabIndex = 37;
            this.button_ExcluirB.TabStop = false;
            this.button_ExcluirB.Text = "&Excluir";
            this.button_ExcluirB.UseVisualStyleBackColor = true;
            this.button_ExcluirB.Click += new System.EventHandler(this.button_ExcluirB_Click);
            // 
            // button_EditarB
            // 
            this.button_EditarB.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button_EditarB.Enabled = false;
            this.button_EditarB.Location = new System.Drawing.Point(966, 598);
            this.button_EditarB.Name = "button_EditarB";
            this.button_EditarB.Size = new System.Drawing.Size(99, 23);
            this.button_EditarB.TabIndex = 36;
            this.button_EditarB.TabStop = false;
            this.button_EditarB.Text = "&Editar";
            this.button_EditarB.UseVisualStyleBackColor = true;
            this.button_EditarB.Click += new System.EventHandler(this.button_editarB_Click);
            // 
            // button_ExcluirA
            // 
            this.button_ExcluirA.Location = new System.Drawing.Point(356, 630);
            this.button_ExcluirA.Name = "button_ExcluirA";
            this.button_ExcluirA.Size = new System.Drawing.Size(99, 23);
            this.button_ExcluirA.TabIndex = 39;
            this.button_ExcluirA.TabStop = false;
            this.button_ExcluirA.Text = "&Excluir";
            this.button_ExcluirA.UseVisualStyleBackColor = true;
            this.button_ExcluirA.Click += new System.EventHandler(this.button_ExcluirA_Click);
            // 
            // button_EditarA
            // 
            this.button_EditarA.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button_EditarA.Enabled = false;
            this.button_EditarA.Location = new System.Drawing.Point(356, 598);
            this.button_EditarA.Name = "button_EditarA";
            this.button_EditarA.Size = new System.Drawing.Size(99, 23);
            this.button_EditarA.TabIndex = 38;
            this.button_EditarA.TabStop = false;
            this.button_EditarA.Text = "&Editar";
            this.button_EditarA.UseVisualStyleBackColor = true;
            this.button_EditarA.Click += new System.EventHandler(this.button_EditarA_Click);
            // 
            // masktextBox_DataAberBb
            // 
            this.masktextBox_DataAberBb.Location = new System.Drawing.Point(609, 633);
            this.masktextBox_DataAberBb.Mask = "00/00/0000";
            this.masktextBox_DataAberBb.Name = "masktextBox_DataAberBb";
            this.masktextBox_DataAberBb.Size = new System.Drawing.Size(123, 20);
            this.masktextBox_DataAberBb.TabIndex = 9;
            this.masktextBox_DataAberBb.ValidatingType = typeof(System.DateTime);
            // 
            // maskTextBox_DataFabricacaoA
            // 
            this.maskTextBox_DataFabricacaoA.Location = new System.Drawing.Point(217, 553);
            this.maskTextBox_DataFabricacaoA.Mask = "00/00/0000";
            this.maskTextBox_DataFabricacaoA.Name = "maskTextBox_DataFabricacaoA";
            this.maskTextBox_DataFabricacaoA.Size = new System.Drawing.Size(123, 20);
            this.maskTextBox_DataFabricacaoA.TabIndex = 4;
            this.maskTextBox_DataFabricacaoA.ValidatingType = typeof(System.DateTime);
            // 
            // button_aceitarA
            // 
            this.button_aceitarA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button_aceitarA.ForeColor = System.Drawing.Color.Green;
            this.button_aceitarA.Location = new System.Drawing.Point(461, 630);
            this.button_aceitarA.Name = "button_aceitarA";
            this.button_aceitarA.Size = new System.Drawing.Size(23, 23);
            this.button_aceitarA.TabIndex = 41;
            this.button_aceitarA.TabStop = false;
            this.button_aceitarA.Text = "✔️";
            this.button_aceitarA.UseVisualStyleBackColor = false;
            this.button_aceitarA.Visible = false;
            this.button_aceitarA.Click += new System.EventHandler(this.button_aceitar_Click);
            // 
            // button_cancelarAb
            // 
            this.button_cancelarAb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button_cancelarAb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button_cancelarAb.Location = new System.Drawing.Point(490, 630);
            this.button_cancelarAb.Name = "button_cancelarAb";
            this.button_cancelarAb.Size = new System.Drawing.Size(23, 23);
            this.button_cancelarAb.TabIndex = 42;
            this.button_cancelarAb.TabStop = false;
            this.button_cancelarAb.Text = "❌";
            this.button_cancelarAb.UseVisualStyleBackColor = false;
            this.button_cancelarAb.Visible = false;
            this.button_cancelarAb.Click += new System.EventHandler(this.button_cancelar_Click);
            // 
            // button_cancelarBb
            // 
            this.button_cancelarBb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button_cancelarBb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button_cancelarBb.Location = new System.Drawing.Point(1100, 631);
            this.button_cancelarBb.Name = "button_cancelarBb";
            this.button_cancelarBb.Size = new System.Drawing.Size(23, 23);
            this.button_cancelarBb.TabIndex = 44;
            this.button_cancelarBb.TabStop = false;
            this.button_cancelarBb.Text = "❌";
            this.button_cancelarBb.UseVisualStyleBackColor = false;
            this.button_cancelarBb.Visible = false;
            this.button_cancelarBb.Click += new System.EventHandler(this.button_cancelarBb_Click);
            // 
            // button_aceitarB
            // 
            this.button_aceitarB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button_aceitarB.ForeColor = System.Drawing.Color.Green;
            this.button_aceitarB.Location = new System.Drawing.Point(1071, 631);
            this.button_aceitarB.Name = "button_aceitarB";
            this.button_aceitarB.Size = new System.Drawing.Size(23, 23);
            this.button_aceitarB.TabIndex = 43;
            this.button_aceitarB.TabStop = false;
            this.button_aceitarB.Text = "✔️";
            this.button_aceitarB.UseVisualStyleBackColor = false;
            this.button_aceitarB.Visible = false;
            this.button_aceitarB.Click += new System.EventHandler(this.button_aceitarB_Click);
            // 
            // listView_EquipHide
            // 
            this.listView_EquipHide.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listView_EquipHide.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ValorOculto,
            this.DataOculta});
            this.listView_EquipHide.FullRowSelect = true;
            this.listView_EquipHide.GridLines = true;
            this.listView_EquipHide.HideSelection = false;
            this.listView_EquipHide.LabelEdit = true;
            this.listView_EquipHide.Location = new System.Drawing.Point(127, 18);
            this.listView_EquipHide.Name = "listView_EquipHide";
            this.listView_EquipHide.Size = new System.Drawing.Size(19, 19);
            this.listView_EquipHide.TabIndex = 45;
            this.listView_EquipHide.TabStop = false;
            this.listView_EquipHide.Tag = "";
            this.listView_EquipHide.UseCompatibleStateImageBehavior = false;
            this.listView_EquipHide.View = System.Windows.Forms.View.Details;
            this.listView_EquipHide.Visible = false;
            // 
            // ValorOculto
            // 
            this.ValorOculto.Text = "Valor Aquisição";
            this.ValorOculto.Width = 100;
            // 
            // DataOculta
            // 
            this.DataOculta.Text = "Data de Fabricação";
            this.DataOculta.Width = 100;
            // 
            // label_aviso
            // 
            this.label_aviso.AutoSize = true;
            this.label_aviso.ForeColor = System.Drawing.Color.Red;
            this.label_aviso.Location = new System.Drawing.Point(56, 500);
            this.label_aviso.Name = "label_aviso";
            this.label_aviso.Size = new System.Drawing.Size(122, 13);
            this.label_aviso.TabIndex = 46;
            this.label_aviso.Text = "*mínimo de 6 caracteres";
            this.label_aviso.Visible = false;
            // 
            // label_AvisoA
            // 
            this.label_AvisoA.AutoSize = true;
            this.label_AvisoA.ForeColor = System.Drawing.Color.Red;
            this.label_AvisoA.Location = new System.Drawing.Point(214, 612);
            this.label_AvisoA.Name = "label_AvisoA";
            this.label_AvisoA.Size = new System.Drawing.Size(130, 26);
            this.label_AvisoA.TabIndex = 48;
            this.label_AvisoA.Text = "*Todos os campos devem\r\n        ser preenchidos!       ";
            this.label_AvisoA.Visible = false;
            // 
            // label_AvisoB
            // 
            this.label_AvisoB.AutoSize = true;
            this.label_AvisoB.ForeColor = System.Drawing.Color.Red;
            this.label_AvisoB.Location = new System.Drawing.Point(963, 553);
            this.label_AvisoB.Name = "label_AvisoB";
            this.label_AvisoB.Size = new System.Drawing.Size(130, 26);
            this.label_AvisoB.TabIndex = 49;
            this.label_AvisoB.Text = "*Todos os campos devem\r\n        ser preenchidos!       ";
            this.label_AvisoB.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(152, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 50;
            this.label1.Text = "<= ListViewHide!";
            this.label1.Visible = false;
            // 
            // ControleEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1181, 708);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_AvisoB);
            this.Controls.Add(this.label_AvisoA);
            this.Controls.Add(this.label_aviso);
            this.Controls.Add(this.listView_EquipHide);
            this.Controls.Add(this.button_cancelarBb);
            this.Controls.Add(this.button_aceitarB);
            this.Controls.Add(this.button_cancelarAb);
            this.Controls.Add(this.button_aceitarA);
            this.Controls.Add(this.maskTextBox_DataFabricacaoA);
            this.Controls.Add(this.masktextBox_DataAberBb);
            this.Controls.Add(this.button_ExcluirA);
            this.Controls.Add(this.button_EditarA);
            this.Controls.Add(this.button_ExcluirB);
            this.Controls.Add(this.button_EditarB);
            this.Controls.Add(this.button_CancelarB);
            this.Controls.Add(this.button_AddB);
            this.Controls.Add(this.label_EquipB);
            this.Controls.Add(this.label_DescricaoB);
            this.Controls.Add(this.label_DataAberB);
            this.Controls.Add(this.label_TituloB);
            this.Controls.Add(this.textBox_DescricaoB);
            this.Controls.Add(this.textBox_EquipB);
            this.Controls.Add(this.textBox_TituloBb);
            this.Controls.Add(this.label_NSerieA);
            this.Controls.Add(this.label_FabricanteA);
            this.Controls.Add(this.label_ValorA);
            this.Controls.Add(this.label_DataFabricacaoA);
            this.Controls.Add(this.label_NomeA);
            this.Controls.Add(this.textBox_ValorA);
            this.Controls.Add(this.button_CancelarA);
            this.Controls.Add(this.button_AddAb);
            this.Controls.Add(this.textBox_NSerieA);
            this.Controls.Add(this.textBox_FabricanteA);
            this.Controls.Add(this.textBox_NomeA);
            this.Controls.Add(this.listView_Chamados);
            this.Controls.Add(this.listView_Equip);
            this.Controls.Add(this.label_chamados);
            this.Controls.Add(this.label_equipamentos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ControleEstoque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle de Estoque";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_equipamentos;
        private System.Windows.Forms.Label label_chamados;
        public System.Windows.Forms.ListView listView_Equip;
        public System.Windows.Forms.ColumnHeader columnHeader1;
        public System.Windows.Forms.ColumnHeader columnHeader2;
        public System.Windows.Forms.ColumnHeader columnHeader3;
        public System.Windows.Forms.ListView listView_Chamados;
        public System.Windows.Forms.ColumnHeader columnHeader4;
        public System.Windows.Forms.ColumnHeader columnHeader5;
        public System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Label label_NSerieA;
        private System.Windows.Forms.Label label_FabricanteA;
        private System.Windows.Forms.Label label_ValorA;
        private System.Windows.Forms.Label label_DataFabricacaoA;
        private System.Windows.Forms.Label label_NomeA;
        private System.Windows.Forms.TextBox textBox_ValorA;
        private System.Windows.Forms.Button button_CancelarA;
        public System.Windows.Forms.Button button_AddAb;
        private System.Windows.Forms.TextBox textBox_NSerieA;
        private System.Windows.Forms.TextBox textBox_FabricanteA;
        private System.Windows.Forms.TextBox textBox_NomeA;
        private System.Windows.Forms.Label label_EquipB;
        private System.Windows.Forms.Label label_DescricaoB;
        private System.Windows.Forms.Label label_DataAberB;
        private System.Windows.Forms.Label label_TituloB;
        private System.Windows.Forms.TextBox textBox_DescricaoB;
        private System.Windows.Forms.TextBox textBox_EquipB;
        private System.Windows.Forms.TextBox textBox_TituloBb;
        private System.Windows.Forms.Button button_CancelarB;
        public System.Windows.Forms.Button button_AddB;
        private System.Windows.Forms.Button button_ExcluirB;
        public System.Windows.Forms.Button button_EditarB;
        private System.Windows.Forms.Button button_ExcluirA;
        public System.Windows.Forms.Button button_EditarA;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.MaskedTextBox masktextBox_DataAberBb;
        private System.Windows.Forms.MaskedTextBox maskTextBox_DataFabricacaoA;
        public System.Windows.Forms.Button button_aceitarA;
        public System.Windows.Forms.Button button_cancelarAb;
        public System.Windows.Forms.Button button_cancelarBb;
        public System.Windows.Forms.Button button_aceitarB;
        public System.Windows.Forms.ListView listView_EquipHide;
        public System.Windows.Forms.ColumnHeader ValorOculto;
        public System.Windows.Forms.ColumnHeader DataOculta;
        private System.Windows.Forms.Label label_aviso;
        private System.Windows.Forms.Label label_AvisoA;
        private System.Windows.Forms.Label label_AvisoB;
        private System.Windows.Forms.Label label1;
    }
}

