namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNomePaciente = new System.Windows.Forms.TextBox();
            this.txtNomeSolicitante = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRgSolicitante = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRgPaciente = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtMotivo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomedaMae = new System.Windows.Forms.TextBox();
            this.txtLocalFato = new System.Windows.Forms.TextBox();
            this.lblfato = new System.Windows.Forms.Label();
            this.txtDtFato = new System.Windows.Forms.TextBox();
            this.lbldatafato = new System.Windows.Forms.Label();
            this.txtDtAtend = new System.Windows.Forms.MaskedTextBox();
            this.txtObs = new System.Windows.Forms.RichTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDtNasc = new System.Windows.Forms.MaskedTextBox();
            this.txtTele = new System.Windows.Forms.TextBox();
            this.CbUnid = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDias = new System.Windows.Forms.TextBox();
            this.RbSim = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.RbNao = new System.Windows.Forms.RadioButton();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.txtUpa = new System.Windows.Forms.TextBox();
            this.txtDataSolicitacao = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btOk = new System.Windows.Forms.Button();
            this.BtnVortar = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1330, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "SISTEMA DE SOLICITAÇÃO DE PRONTUÁRIOS";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(13, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nome do Paciente:";
            // 
            // txtNomePaciente
            // 
            this.txtNomePaciente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNomePaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomePaciente.Location = new System.Drawing.Point(227, 43);
            this.txtNomePaciente.Name = "txtNomePaciente";
            this.txtNomePaciente.Size = new System.Drawing.Size(205, 26);
            this.txtNomePaciente.TabIndex = 2;
            this.txtNomePaciente.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtNomePaciente_KeyUp);
            // 
            // txtNomeSolicitante
            // 
            this.txtNomeSolicitante.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNomeSolicitante.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeSolicitante.Location = new System.Drawing.Point(996, 79);
            this.txtNomeSolicitante.Name = "txtNomeSolicitante";
            this.txtNomeSolicitante.Size = new System.Drawing.Size(158, 26);
            this.txtNomeSolicitante.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(833, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nome do Solicitante:";
            // 
            // txtRgSolicitante
            // 
            this.txtRgSolicitante.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtRgSolicitante.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRgSolicitante.Location = new System.Drawing.Point(996, 38);
            this.txtRgSolicitante.Name = "txtRgSolicitante";
            this.txtRgSolicitante.Size = new System.Drawing.Size(158, 26);
            this.txtRgSolicitante.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(833, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "RG do Solicitante:";
            // 
            // txtRgPaciente
            // 
            this.txtRgPaciente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtRgPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRgPaciente.Location = new System.Drawing.Point(227, 118);
            this.txtRgPaciente.Name = "txtRgPaciente";
            this.txtRgPaciente.Size = new System.Drawing.Size(205, 26);
            this.txtRgPaciente.TabIndex = 3;
            this.txtRgPaciente.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtRgPaciente_KeyUp);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(15, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "RG do Paciente";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.AutoSize = true;
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.txtNomeSolicitante);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.txtMotivo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtNomedaMae);
            this.groupBox1.Controls.Add(this.txtLocalFato);
            this.groupBox1.Controls.Add(this.lblfato);
            this.groupBox1.Controls.Add(this.txtRgSolicitante);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtDtFato);
            this.groupBox1.Controls.Add(this.txtRgPaciente);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lbldatafato);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtNomePaciente);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtDtAtend);
            this.groupBox1.Controls.Add(this.txtObs);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtDtNasc);
            this.groupBox1.Controls.Add(this.txtTele);
            this.groupBox1.Controls.Add(this.CbUnid);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtDias);
            this.groupBox1.Controls.Add(this.RbSim);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.RbNao);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(22, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1164, 652);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ficha de Cadastro";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.White;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(15, 159);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(162, 20);
            this.label14.TabIndex = 59;
            this.label14.Text = "Motivo da Solicitação:";
            // 
            // txtMotivo
            // 
            this.txtMotivo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMotivo.AutoCompleteCustomSource.AddRange(new string[] {
            "Não existe"});
            this.txtMotivo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtMotivo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtMotivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMotivo.Location = new System.Drawing.Point(227, 158);
            this.txtMotivo.Name = "txtMotivo";
            this.txtMotivo.Size = new System.Drawing.Size(205, 26);
            this.txtMotivo.TabIndex = 58;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(13, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 20);
            this.label1.TabIndex = 57;
            this.label1.Text = "Nome da Mãe do Paciente:";
            // 
            // txtNomedaMae
            // 
            this.txtNomedaMae.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNomedaMae.AutoCompleteCustomSource.AddRange(new string[] {
            "Não existe"});
            this.txtNomedaMae.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtNomedaMae.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtNomedaMae.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomedaMae.Location = new System.Drawing.Point(227, 84);
            this.txtNomedaMae.Name = "txtNomedaMae";
            this.txtNomedaMae.Size = new System.Drawing.Size(205, 26);
            this.txtNomedaMae.TabIndex = 56;
            // 
            // txtLocalFato
            // 
            this.txtLocalFato.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLocalFato.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocalFato.Location = new System.Drawing.Point(601, 81);
            this.txtLocalFato.Name = "txtLocalFato";
            this.txtLocalFato.Size = new System.Drawing.Size(205, 26);
            this.txtLocalFato.TabIndex = 54;
            this.txtLocalFato.Visible = false;
            // 
            // lblfato
            // 
            this.lblfato.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblfato.AutoSize = true;
            this.lblfato.BackColor = System.Drawing.Color.White;
            this.lblfato.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfato.ForeColor = System.Drawing.Color.Black;
            this.lblfato.Location = new System.Drawing.Point(471, 84);
            this.lblfato.Name = "lblfato";
            this.lblfato.Size = new System.Drawing.Size(110, 20);
            this.lblfato.TabIndex = 55;
            this.lblfato.Text = "Local do Fato:";
            this.lblfato.Visible = false;
            // 
            // txtDtFato
            // 
            this.txtDtFato.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDtFato.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDtFato.Location = new System.Drawing.Point(601, 40);
            this.txtDtFato.Name = "txtDtFato";
            this.txtDtFato.Size = new System.Drawing.Size(205, 26);
            this.txtDtFato.TabIndex = 52;
            this.txtDtFato.Visible = false;
            // 
            // lbldatafato
            // 
            this.lbldatafato.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbldatafato.AutoSize = true;
            this.lbldatafato.BackColor = System.Drawing.Color.White;
            this.lbldatafato.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldatafato.ForeColor = System.Drawing.Color.Black;
            this.lbldatafato.Location = new System.Drawing.Point(471, 43);
            this.lbldatafato.Name = "lbldatafato";
            this.lbldatafato.Size = new System.Drawing.Size(124, 20);
            this.lbldatafato.TabIndex = 53;
            this.lbldatafato.Text = "Horario do Fato:";
            this.lbldatafato.Visible = false;
            // 
            // txtDtAtend
            // 
            this.txtDtAtend.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDtAtend.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDtAtend.Location = new System.Drawing.Point(227, 238);
            this.txtDtAtend.Mask = "00/00/0000";
            this.txtDtAtend.Name = "txtDtAtend";
            this.txtDtAtend.Size = new System.Drawing.Size(205, 26);
            this.txtDtAtend.TabIndex = 8;
            this.txtDtAtend.ValidatingType = typeof(System.DateTime);
            // 
            // txtObs
            // 
            this.txtObs.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtObs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtObs.Location = new System.Drawing.Point(17, 335);
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(1033, 199);
            this.txtObs.TabIndex = 12;
            this.txtObs.Text = "";
            this.txtObs.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtObs_KeyPress);
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(471, 128);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 20);
            this.label10.TabIndex = 17;
            this.label10.Text = "Unidade:";
            // 
            // txtDtNasc
            // 
            this.txtDtNasc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDtNasc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDtNasc.Location = new System.Drawing.Point(227, 196);
            this.txtDtNasc.Mask = "00/00/0000";
            this.txtDtNasc.Name = "txtDtNasc";
            this.txtDtNasc.Size = new System.Drawing.Size(205, 26);
            this.txtDtNasc.TabIndex = 6;
            this.txtDtNasc.ValidatingType = typeof(System.DateTime);
            // 
            // txtTele
            // 
            this.txtTele.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTele.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTele.Location = new System.Drawing.Point(601, 168);
            this.txtTele.Name = "txtTele";
            this.txtTele.Size = new System.Drawing.Size(205, 26);
            this.txtTele.TabIndex = 7;
            // 
            // CbUnid
            // 
            this.CbUnid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CbUnid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbUnid.Enabled = false;
            this.CbUnid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CbUnid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbUnid.ForeColor = System.Drawing.Color.Black;
            this.CbUnid.FormattingEnabled = true;
            this.CbUnid.Items.AddRange(new object[] {
            "",
            "ALVES DIAS",
            "BAETA NEVES",
            "DEMARCHI",
            "PAULICÉIA",
            "RIACHO GRANDE",
            "RUDGE RAMOS",
            "SÃO PEDRO",
            "SILVINA",
            "UNIÃO",
            "SAMU"});
            this.CbUnid.Location = new System.Drawing.Point(600, 125);
            this.CbUnid.Name = "CbUnid";
            this.CbUnid.Size = new System.Drawing.Size(206, 28);
            this.CbUnid.TabIndex = 9;
            this.CbUnid.SelectedIndexChanged += new System.EventHandler(this.CbUnid_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(471, 171);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 20);
            this.label9.TabIndex = 15;
            this.label9.Text = "Telefone:";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(13, 301);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(98, 20);
            this.label13.TabIndex = 24;
            this.label13.Text = "Observação:";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(471, 211);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 20);
            this.label11.TabIndex = 19;
            this.label11.Text = "Internação:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(15, 197);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(158, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Data de Nascimento:";
            // 
            // txtDias
            // 
            this.txtDias.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDias.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDias.Location = new System.Drawing.Point(736, 209);
            this.txtDias.Name = "txtDias";
            this.txtDias.Size = new System.Drawing.Size(43, 26);
            this.txtDias.TabIndex = 50;
            this.txtDias.Visible = false;
            // 
            // RbSim
            // 
            this.RbSim.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RbSim.AutoSize = true;
            this.RbSim.BackColor = System.Drawing.Color.White;
            this.RbSim.ForeColor = System.Drawing.Color.Black;
            this.RbSim.Location = new System.Drawing.Point(567, 211);
            this.RbSim.Name = "RbSim";
            this.RbSim.Size = new System.Drawing.Size(52, 22);
            this.RbSim.TabIndex = 10;
            this.RbSim.Text = "Sim";
            this.RbSim.UseVisualStyleBackColor = false;
            this.RbSim.CheckedChanged += new System.EventHandler(this.RbSim_CheckedChanged);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(15, 239);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(165, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = "Data de Atendimento:";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(685, 212);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 20);
            this.label12.TabIndex = 22;
            this.label12.Text = "Dias:";
            this.label12.Visible = false;
            // 
            // RbNao
            // 
            this.RbNao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RbNao.AutoSize = true;
            this.RbNao.BackColor = System.Drawing.Color.White;
            this.RbNao.ForeColor = System.Drawing.Color.Black;
            this.RbNao.Location = new System.Drawing.Point(625, 211);
            this.RbNao.Name = "RbNao";
            this.RbNao.Size = new System.Drawing.Size(54, 22);
            this.RbNao.TabIndex = 11;
            this.RbNao.Text = "Não";
            this.RbNao.UseVisualStyleBackColor = false;
            this.RbNao.CheckedChanged += new System.EventHandler(this.RbNao_CheckedChanged);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            this.printPreviewDialog1.Load += new System.EventHandler(this.printPreviewDialog1_Load);
            // 
            // txtUpa
            // 
            this.txtUpa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUpa.ForeColor = System.Drawing.Color.White;
            this.txtUpa.Location = new System.Drawing.Point(303, 815);
            this.txtUpa.Name = "txtUpa";
            this.txtUpa.Size = new System.Drawing.Size(100, 13);
            this.txtUpa.TabIndex = 19;
            // 
            // txtDataSolicitacao
            // 
            this.txtDataSolicitacao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDataSolicitacao.ForeColor = System.Drawing.Color.White;
            this.txtDataSolicitacao.Location = new System.Drawing.Point(427, 815);
            this.txtDataSolicitacao.Name = "txtDataSolicitacao";
            this.txtDataSolicitacao.Size = new System.Drawing.Size(100, 13);
            this.txtDataSolicitacao.TabIndex = 20;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.LOGO;
            this.pictureBox1.Location = new System.Drawing.Point(22, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(119, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Image = global::WindowsFormsApplication1.Properties.Resources.upa24hpq;
            this.pictureBox2.Location = new System.Drawing.Point(1186, 608);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(165, 113);
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnLimpar.AutoSize = true;
            this.btnLimpar.BackColor = System.Drawing.Color.Red;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.Color.White;
            this.btnLimpar.Image = global::WindowsFormsApplication1.Properties.Resources.eraser8;
            this.btnLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpar.Location = new System.Drawing.Point(1192, 184);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(138, 40);
            this.btnLimpar.TabIndex = 14;
            this.btnLimpar.Text = " LIMPAR";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btOk
            // 
            this.btOk.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btOk.AutoSize = true;
            this.btOk.BackColor = System.Drawing.SystemColors.Highlight;
            this.btOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOk.ForeColor = System.Drawing.Color.White;
            this.btOk.Image = global::WindowsFormsApplication1.Properties.Resources.verification51;
            this.btOk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btOk.Location = new System.Drawing.Point(1192, 138);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(138, 40);
            this.btOk.TabIndex = 13;
            this.btOk.Text = "OK";
            this.btOk.UseVisualStyleBackColor = false;
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // BtnVortar
            // 
            this.BtnVortar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BtnVortar.AutoSize = true;
            this.BtnVortar.BackColor = System.Drawing.Color.Gray;
            this.BtnVortar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnVortar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVortar.ForeColor = System.Drawing.Color.White;
            this.BtnVortar.Image = global::WindowsFormsApplication1.Properties.Resources.seta;
            this.BtnVortar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnVortar.Location = new System.Drawing.Point(1192, 230);
            this.BtnVortar.Name = "BtnVortar";
            this.BtnVortar.Size = new System.Drawing.Size(138, 40);
            this.BtnVortar.TabIndex = 21;
            this.BtnVortar.Text = "VOLTAR";
            this.BtnVortar.UseVisualStyleBackColor = false;
            this.BtnVortar.Click += new System.EventHandler(this.BtnVortar_Click_1);
            // 
            // txtID
            // 
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtID.ForeColor = System.Drawing.Color.White;
            this.txtID.Location = new System.Drawing.Point(166, 815);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 13);
            this.txtID.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.BtnVortar;
            this.ClientSize = new System.Drawing.Size(1354, 733);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.BtnVortar);
            this.Controls.Add(this.txtDataSolicitacao);
            this.Controls.Add(this.txtUpa);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btOk);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Prontuário";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNomePaciente;
        private System.Windows.Forms.TextBox txtNomeSolicitante;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRgSolicitante;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRgPaciente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RadioButton RbNao;
        private System.Windows.Forms.RadioButton RbSim;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTele;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtDias;
        private System.Windows.Forms.RichTextBox txtObs;
        private System.Windows.Forms.Button btOk;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.ComboBox CbUnid;
        private System.Windows.Forms.MaskedTextBox txtDtAtend;
        private System.Windows.Forms.MaskedTextBox txtDtNasc;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtUpa;
        private System.Windows.Forms.TextBox txtDataSolicitacao;
        private System.Windows.Forms.Button BtnVortar;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtLocalFato;
        private System.Windows.Forms.Label lblfato;
        private System.Windows.Forms.TextBox txtDtFato;
        private System.Windows.Forms.Label lbldatafato;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomedaMae;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtMotivo;
    }
}

