namespace scale
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.tare = new System.Windows.Forms.Button();
            this.tareBox = new System.Windows.Forms.TextBox();
            this.brut = new System.Windows.Forms.Button();
            this.brutBox = new System.Windows.Forms.TextBox();
            this.pesee = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.hour = new System.Windows.Forms.TextBox();
            this.date = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label21 = new System.Windows.Forms.Label();
            this.impremer = new System.Windows.Forms.Button();
            this.lstPesee = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.typePesee = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.acceuil = new System.Windows.Forms.ComboBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tareAvecCaisse = new System.Windows.Forms.RadioButton();
            this.tareSansCaisse = new System.Windows.Forms.RadioButton();
            this.label22 = new System.Windows.Forms.Label();
            this.nbrPalettes = new System.Windows.Forms.TextBox();
            this.pGlace = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.pes_id = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.valider = new System.Windows.Forms.Button();
            this.frCode = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.nonUsinable = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.Ecart = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.dechets = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.PoidCaisse = new System.Windows.Forms.TextBox();
            this.Plateaux = new System.Windows.Forms.RadioButton();
            this.caisseNormale = new System.Windows.Forms.RadioButton();
            this.label12 = new System.Windows.Forms.Label();
            this.nbreCaisse = new System.Windows.Forms.TextBox();
            this.annuler = new System.Windows.Forms.Button();
            this.categorie = new System.Windows.Forms.ComboBox();
            this.produit1 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.fournisseurBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.provenance = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.destination = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.camion = new System.Windows.Forms.ComboBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.tbl_inf = new System.Windows.Forms.DataGridView();
            this.NPesee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Matricule = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fournisseur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Produit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DDebut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HDebut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel6 = new System.Windows.Forms.Panel();
            this.annulerPesee = new System.Windows.Forms.Button();
            this.synthese = new System.Windows.Forms.Button();
            this.rptPesee = new scale.rptPesee();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_inf)).BeginInit();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort
            // 
            this.serialPort.Handshake = System.IO.Ports.Handshake.RequestToSend;
            this.serialPort.PortName = "COM4";
            this.serialPort.ReadBufferSize = 10024;
           
            this.serialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.DataReceivedHandler);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.tare);
            this.panel1.Controls.Add(this.tareBox);
            this.panel1.Controls.Add(this.brut);
            this.panel1.Controls.Add(this.brutBox);
            this.panel1.Controls.Add(this.pesee);
            this.panel1.Location = new System.Drawing.Point(318, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(960, 112);
            this.panel1.TabIndex = 0;
            // 
            // tare
            // 
            this.tare.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tare.AutoSize = true;
            this.tare.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tare.Location = new System.Drawing.Point(661, 53);
            this.tare.Name = "tare";
            this.tare.Size = new System.Drawing.Size(111, 47);
            this.tare.TabIndex = 4;
            this.tare.Text = "Tare";
            this.tare.UseVisualStyleBackColor = true;
            this.tare.Click += new System.EventHandler(this.tare_Click);
            // 
            // tareBox
            // 
            this.tareBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tareBox.BackColor = System.Drawing.SystemColors.ControlText;
            this.tareBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tareBox.ForeColor = System.Drawing.SystemColors.Info;
            this.tareBox.Location = new System.Drawing.Point(778, 53);
            this.tareBox.Multiline = true;
            this.tareBox.Name = "tareBox";
            this.tareBox.ReadOnly = true;
            this.tareBox.Size = new System.Drawing.Size(174, 47);
            this.tareBox.TabIndex = 3;
            this.tareBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // brut
            // 
            this.brut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.brut.AutoSize = true;
            this.brut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brut.Location = new System.Drawing.Point(196, 53);
            this.brut.Name = "brut";
            this.brut.Size = new System.Drawing.Size(110, 47);
            this.brut.TabIndex = 2;
            this.brut.Text = "Brut";
            this.brut.UseVisualStyleBackColor = true;
            this.brut.Click += new System.EventHandler(this.brut_Click);
            // 
            // brutBox
            // 
            this.brutBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.brutBox.BackColor = System.Drawing.SystemColors.ControlText;
            this.brutBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brutBox.ForeColor = System.Drawing.SystemColors.Info;
            this.brutBox.Location = new System.Drawing.Point(16, 52);
            this.brutBox.Multiline = true;
            this.brutBox.Name = "brutBox";
            this.brutBox.ReadOnly = true;
            this.brutBox.Size = new System.Drawing.Size(175, 47);
            this.brutBox.TabIndex = 1;
            this.brutBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pesee
            // 
            this.pesee.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pesee.BackColor = System.Drawing.SystemColors.ControlText;
            this.pesee.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pesee.ForeColor = System.Drawing.SystemColors.Info;
            this.pesee.Location = new System.Drawing.Point(321, 3);
            this.pesee.Name = "pesee";
            this.pesee.Size = new System.Drawing.Size(325, 57);
            this.pesee.TabIndex = 0;
            this.pesee.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel2.Controls.Add(this.hour);
            this.panel2.Controls.Add(this.date);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 109);
            this.panel2.TabIndex = 1;
            // 
            // hour
            // 
            this.hour.BackColor = System.Drawing.SystemColors.ControlText;
            this.hour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hour.ForeColor = System.Drawing.SystemColors.Info;
            this.hour.Location = new System.Drawing.Point(44, 69);
            this.hour.Name = "hour";
            this.hour.ReadOnly = true;
            this.hour.Size = new System.Drawing.Size(210, 35);
            this.hour.TabIndex = 1;
            this.hour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // date
            // 
            this.date.BackColor = System.Drawing.SystemColors.ControlText;
            this.date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.ForeColor = System.Drawing.SystemColors.Info;
            this.date.Location = new System.Drawing.Point(44, 12);
            this.date.Name = "date";
            this.date.ReadOnly = true;
            this.date.Size = new System.Drawing.Size(210, 35);
            this.date.TabIndex = 0;
            this.date.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel3.Controls.Add(this.label21);
            this.panel3.Controls.Add(this.impremer);
            this.panel3.Controls.Add(this.lstPesee);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.search);
            this.panel3.Location = new System.Drawing.Point(12, 128);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(300, 442);
            this.panel3.TabIndex = 2;
            // 
            // label21
            // 
            this.label21.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(-2, 28);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(110, 20);
            this.label21.TabIndex = 4;
            this.label21.Text = "N Bon Pesee :";
            // 
            // impremer
            // 
            this.impremer.AutoSize = true;
            this.impremer.Location = new System.Drawing.Point(64, 372);
            this.impremer.Name = "impremer";
            this.impremer.Size = new System.Drawing.Size(195, 46);
            this.impremer.TabIndex = 3;
            this.impremer.Text = "Impremer Autre";
            this.impremer.UseVisualStyleBackColor = true;
            this.impremer.Click += new System.EventHandler(this.impremer_Click);
            // 
            // lstPesee
            // 
            this.lstPesee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstPesee.FormattingEnabled = true;
            this.lstPesee.ItemHeight = 25;
            this.lstPesee.Location = new System.Drawing.Point(22, 75);
            this.lstPesee.Name = "lstPesee";
            this.lstPesee.Size = new System.Drawing.Size(248, 254);
            this.lstPesee.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 1;
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.SystemColors.InfoText;
            this.search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.ForeColor = System.Drawing.SystemColors.Info;
            this.search.Location = new System.Drawing.Point(114, 22);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(157, 35);
            this.search.TabIndex = 0;
            this.search.TextChanged += new System.EventHandler(this.search_TextUpdated);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.AutoSize = true;
            this.panel4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.typePesee);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.acceuil);
            this.panel4.Location = new System.Drawing.Point(318, 128);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(960, 48);
            this.panel4.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(532, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "TYPE PESEE :";
            // 
            // typePesee
            // 
            this.typePesee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typePesee.FormattingEnabled = true;
            this.typePesee.Items.AddRange(new object[] {
            "ENTREE",
            "SORTIE",
            "TRANSFER"});
            this.typePesee.Location = new System.Drawing.Point(692, 5);
            this.typePesee.Name = "typePesee";
            this.typePesee.Size = new System.Drawing.Size(214, 33);
            this.typePesee.Sorted = true;
            this.typePesee.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "ACCEUIL :";
            // 
            // acceuil
            // 
            this.acceuil.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.acceuil.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acceuil.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.acceuil.FormattingEnabled = true;
            this.acceuil.Location = new System.Drawing.Point(152, 3);
            this.acceuil.Name = "acceuil";
            this.acceuil.Size = new System.Drawing.Size(220, 34);
            this.acceuil.Sorted = true;
            this.acceuil.TabIndex = 0;
            this.acceuil.DropDown += new System.EventHandler(this.acceuil_DropDown);
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.AutoSize = true;
            this.panel5.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel5.Controls.Add(this.groupBox1);
            this.panel5.Controls.Add(this.label22);
            this.panel5.Controls.Add(this.nbrPalettes);
            this.panel5.Controls.Add(this.pGlace);
            this.panel5.Controls.Add(this.label11);
            this.panel5.Controls.Add(this.pes_id);
            this.panel5.Controls.Add(this.label10);
            this.panel5.Controls.Add(this.valider);
            this.panel5.Controls.Add(this.frCode);
            this.panel5.Controls.Add(this.label16);
            this.panel5.Controls.Add(this.nonUsinable);
            this.panel5.Controls.Add(this.label15);
            this.panel5.Controls.Add(this.Ecart);
            this.panel5.Controls.Add(this.label14);
            this.panel5.Controls.Add(this.dechets);
            this.panel5.Controls.Add(this.label13);
            this.panel5.Controls.Add(this.PoidCaisse);
            this.panel5.Controls.Add(this.Plateaux);
            this.panel5.Controls.Add(this.caisseNormale);
            this.panel5.Controls.Add(this.label12);
            this.panel5.Controls.Add(this.nbreCaisse);
            this.panel5.Controls.Add(this.annuler);
            this.panel5.Controls.Add(this.categorie);
            this.panel5.Controls.Add(this.produit1);
            this.panel5.Controls.Add(this.label9);
            this.panel5.Controls.Add(this.fournisseurBox);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.provenance);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.destination);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.camion);
            this.panel5.Location = new System.Drawing.Point(318, 182);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(963, 391);
            this.panel5.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tareAvecCaisse);
            this.groupBox1.Controls.Add(this.tareSansCaisse);
            this.groupBox1.Location = new System.Drawing.Point(26, 283);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(442, 38);
            this.groupBox1.TabIndex = 54;
            this.groupBox1.TabStop = false;
            this.groupBox1.Visible = false;
            // 
            // tareAvecCaisse
            // 
            this.tareAvecCaisse.AutoSize = true;
            this.tareAvecCaisse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tareAvecCaisse.Location = new System.Drawing.Point(219, 14);
            this.tareAvecCaisse.Name = "tareAvecCaisse";
            this.tareAvecCaisse.Size = new System.Drawing.Size(187, 26);
            this.tareAvecCaisse.TabIndex = 24;
            this.tareAvecCaisse.TabStop = true;
            this.tareAvecCaisse.Text = "Tare Avec Caisses";
            this.tareAvecCaisse.UseVisualStyleBackColor = true;
            this.tareAvecCaisse.Visible = false;
            // 
            // tareSansCaisse
            // 
            this.tareSansCaisse.AutoSize = true;
            this.tareSansCaisse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tareSansCaisse.Location = new System.Drawing.Point(16, 12);
            this.tareSansCaisse.Name = "tareSansCaisse";
            this.tareSansCaisse.Size = new System.Drawing.Size(188, 26);
            this.tareSansCaisse.TabIndex = 23;
            this.tareSansCaisse.TabStop = true;
            this.tareSansCaisse.Text = "Tare Sans Caisses";
            this.tareSansCaisse.UseVisualStyleBackColor = true;
            this.tareSansCaisse.Visible = false;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(238, 258);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(124, 22);
            this.label22.TabIndex = 53;
            this.label22.Text = "Nbre Palettes:";
            this.label22.Visible = false;
            // 
            // nbrPalettes
            // 
            this.nbrPalettes.BackColor = System.Drawing.SystemColors.InfoText;
            this.nbrPalettes.ForeColor = System.Drawing.SystemColors.Info;
            this.nbrPalettes.Location = new System.Drawing.Point(369, 258);
            this.nbrPalettes.Name = "nbrPalettes";
            this.nbrPalettes.Size = new System.Drawing.Size(100, 26);
            this.nbrPalettes.TabIndex = 52;
            this.nbrPalettes.Text = "0";
            this.nbrPalettes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nbrPalettes.Visible = false;
            // 
            // pGlace
            // 
            this.pGlace.BackColor = System.Drawing.SystemColors.InfoText;
            this.pGlace.ForeColor = System.Drawing.SystemColors.Info;
            this.pGlace.Location = new System.Drawing.Point(369, 228);
            this.pGlace.Name = "pGlace";
            this.pGlace.Size = new System.Drawing.Size(100, 26);
            this.pGlace.TabIndex = 51;
            this.pGlace.Text = "0";
            this.pGlace.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.pGlace.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(260, 228);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(103, 22);
            this.label11.TabIndex = 50;
            this.label11.Text = "Poid Glace:";
            this.label11.Visible = false;
            // 
            // pes_id
            // 
            this.pes_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pes_id.FormattingEnabled = true;
            this.pes_id.Location = new System.Drawing.Point(166, 15);
            this.pes_id.Name = "pes_id";
            this.pes_id.Size = new System.Drawing.Size(214, 33);
            this.pes_id.TabIndex = 49;
            this.pes_id.Visible = false;
            this.pes_id.DropDown += new System.EventHandler(this.pes_id_DropDown);
            this.pes_id.TextUpdate += new System.EventHandler(this.pes_id_TextUpdated);
            this.pes_id.SelectedValueChanged += new System.EventHandler(this.pes_id_SelectedValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(20, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 22);
            this.label10.TabIndex = 48;
            this.label10.Text = "Nbr Pesee:";
            this.label10.Visible = false;
            // 
            // valider
            // 
            this.valider.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.valider.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valider.Location = new System.Drawing.Point(339, 338);
            this.valider.Name = "valider";
            this.valider.Size = new System.Drawing.Size(114, 49);
            this.valider.TabIndex = 42;
            this.valider.Text = "Valider";
            this.valider.UseVisualStyleBackColor = true;
            this.valider.Visible = false;
            this.valider.Click += new System.EventHandler(this.valider_Click);
            // 
            // frCode
            // 
            this.frCode.BackColor = System.Drawing.SystemColors.InfoText;
            this.frCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frCode.ForeColor = System.Drawing.SystemColors.Info;
            this.frCode.Location = new System.Drawing.Point(134, 168);
            this.frCode.Name = "frCode";
            this.frCode.Size = new System.Drawing.Size(58, 30);
            this.frCode.TabIndex = 41;
            this.frCode.TextChanged += new System.EventHandler(this.frCode_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(724, 262);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(128, 22);
            this.label16.TabIndex = 30;
            this.label16.Text = "Non Usinable :";
            this.label16.Visible = false;
            // 
            // nonUsinable
            // 
            this.nonUsinable.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.nonUsinable.ForeColor = System.Drawing.SystemColors.Info;
            this.nonUsinable.Location = new System.Drawing.Point(858, 257);
            this.nonUsinable.Name = "nonUsinable";
            this.nonUsinable.Size = new System.Drawing.Size(100, 26);
            this.nonUsinable.TabIndex = 29;
            this.nonUsinable.Text = "0";
            this.nonUsinable.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nonUsinable.Visible = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(728, 229);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(62, 22);
            this.label15.TabIndex = 28;
            this.label15.Text = "Ecart :";
            this.label15.Visible = false;
            // 
            // Ecart
            // 
            this.Ecart.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Ecart.ForeColor = System.Drawing.SystemColors.Info;
            this.Ecart.Location = new System.Drawing.Point(858, 225);
            this.Ecart.Name = "Ecart";
            this.Ecart.Size = new System.Drawing.Size(100, 26);
            this.Ecart.TabIndex = 27;
            this.Ecart.Text = "0";
            this.Ecart.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Ecart.Visible = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(472, 258);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(115, 22);
            this.label14.TabIndex = 26;
            this.label14.Text = "Dechets FR :";
            this.label14.Visible = false;
            // 
            // dechets
            // 
            this.dechets.BackColor = System.Drawing.SystemColors.InfoText;
            this.dechets.ForeColor = System.Drawing.SystemColors.Info;
            this.dechets.Location = new System.Drawing.Point(606, 255);
            this.dechets.Name = "dechets";
            this.dechets.Size = new System.Drawing.Size(100, 26);
            this.dechets.TabIndex = 25;
            this.dechets.Text = "0";
            this.dechets.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dechets.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(472, 226);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(116, 22);
            this.label13.TabIndex = 24;
            this.label13.Text = "Poid Caisse :";
            this.label13.Visible = false;
            // 
            // PoidCaisse
            // 
            this.PoidCaisse.BackColor = System.Drawing.SystemColors.InfoText;
            this.PoidCaisse.ForeColor = System.Drawing.SystemColors.Info;
            this.PoidCaisse.Location = new System.Drawing.Point(606, 226);
            this.PoidCaisse.Name = "PoidCaisse";
            this.PoidCaisse.Size = new System.Drawing.Size(100, 26);
            this.PoidCaisse.TabIndex = 23;
            this.PoidCaisse.Text = "0";
            this.PoidCaisse.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PoidCaisse.Visible = false;
            // 
            // Plateaux
            // 
            this.Plateaux.AutoSize = true;
            this.Plateaux.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Plateaux.Location = new System.Drawing.Point(498, 288);
            this.Plateaux.Name = "Plateaux";
            this.Plateaux.Size = new System.Drawing.Size(105, 26);
            this.Plateaux.TabIndex = 20;
            this.Plateaux.TabStop = true;
            this.Plateaux.Text = "Plateaux";
            this.Plateaux.UseVisualStyleBackColor = true;
            this.Plateaux.Visible = false;
            // 
            // caisseNormale
            // 
            this.caisseNormale.AutoSize = true;
            this.caisseNormale.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.caisseNormale.Location = new System.Drawing.Point(608, 291);
            this.caisseNormale.Name = "caisseNormale";
            this.caisseNormale.Size = new System.Drawing.Size(171, 26);
            this.caisseNormale.TabIndex = 19;
            this.caisseNormale.TabStop = true;
            this.caisseNormale.Text = "Caisse Normales";
            this.caisseNormale.UseVisualStyleBackColor = true;
            this.caisseNormale.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(26, 228);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(119, 22);
            this.label12.TabIndex = 12;
            this.label12.Text = "Nbre Caisse :";
            this.label12.Visible = false;
            // 
            // nbreCaisse
            // 
            this.nbreCaisse.BackColor = System.Drawing.SystemColors.InfoText;
            this.nbreCaisse.ForeColor = System.Drawing.SystemColors.Info;
            this.nbreCaisse.Location = new System.Drawing.Point(152, 226);
            this.nbreCaisse.Name = "nbreCaisse";
            this.nbreCaisse.Size = new System.Drawing.Size(100, 26);
            this.nbreCaisse.TabIndex = 17;
            this.nbreCaisse.Text = "0";
            this.nbreCaisse.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nbreCaisse.Visible = false;
            // 
            // annuler
            // 
            this.annuler.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.annuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.annuler.Location = new System.Drawing.Point(543, 338);
            this.annuler.Name = "annuler";
            this.annuler.Size = new System.Drawing.Size(114, 49);
            this.annuler.TabIndex = 16;
            this.annuler.Text = "Annuler";
            this.annuler.UseVisualStyleBackColor = true;
            this.annuler.Click += new System.EventHandler(this.annuler_Click);
            // 
            // categorie
            // 
            this.categorie.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.categorie.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categorie.FormattingEnabled = true;
            this.categorie.Location = new System.Drawing.Point(531, 60);
            this.categorie.Name = "categorie";
            this.categorie.Size = new System.Drawing.Size(214, 33);
            this.categorie.TabIndex = 14;
            this.categorie.DropDown += new System.EventHandler(this.categorie_DropDown);
            // 
            // produit1
            // 
            this.produit1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.produit1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.produit1.FormattingEnabled = true;
            this.produit1.Location = new System.Drawing.Point(531, 109);
            this.produit1.Name = "produit1";
            this.produit1.Size = new System.Drawing.Size(214, 33);
            this.produit1.TabIndex = 12;
            this.produit1.DropDown += new System.EventHandler(this.produit1_DropDown);
            this.produit1.TextUpdate += new System.EventHandler(this.produit1_TextUpdated);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(446, 109);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 22);
            this.label9.TabIndex = 11;
            this.label9.Text = "Article :";
            // 
            // fournisseurBox
            // 
            this.fournisseurBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.fournisseurBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fournisseurBox.FormattingEnabled = true;
            this.fournisseurBox.Location = new System.Drawing.Point(196, 168);
            this.fournisseurBox.Name = "fournisseurBox";
            this.fournisseurBox.Size = new System.Drawing.Size(214, 33);
            this.fournisseurBox.TabIndex = 10;
            this.fournisseurBox.DropDown += new System.EventHandler(this.fournisseurBox_DropDown);
            this.fournisseurBox.TextUpdate += new System.EventHandler(this.fournisseurBox_TextUpdated);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(416, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 22);
            this.label8.TabIndex = 9;
            this.label8.Text = "Type Article :";
            // 
            // provenance
            // 
            this.provenance.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.provenance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.provenance.FormattingEnabled = true;
            this.provenance.Location = new System.Drawing.Point(166, 115);
            this.provenance.Name = "provenance";
            this.provenance.Size = new System.Drawing.Size(214, 33);
            this.provenance.TabIndex = 8;
            this.provenance.DropDown += new System.EventHandler(this.provenance_DropDown);
            this.provenance.TextUpdate += new System.EventHandler(this.provenance_TextUpdated);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(412, 158);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 22);
            this.label7.TabIndex = 7;
            this.label7.Text = "Destination :";
            // 
            // destination
            // 
            this.destination.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.destination.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.destination.FormattingEnabled = true;
            this.destination.Location = new System.Drawing.Point(531, 155);
            this.destination.Name = "destination";
            this.destination.Size = new System.Drawing.Size(214, 33);
            this.destination.TabIndex = 6;
            this.destination.DropDown += new System.EventHandler(this.destination_DropDown);
            this.destination.TextUpdate += new System.EventHandler(this.destination_TextUpdated);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 22);
            this.label6.TabIndex = 5;
            this.label6.Text = "Fournisseur :";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 22);
            this.label5.TabIndex = 3;
            this.label5.Text = "Provenance :";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 22);
            this.label4.TabIndex = 1;
            this.label4.Text = "Matricule :";
            // 
            // camion
            // 
            this.camion.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.camion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.camion.FormattingEnabled = true;
            this.camion.Location = new System.Drawing.Point(166, 65);
            this.camion.Name = "camion";
            this.camion.Size = new System.Drawing.Size(214, 33);
            this.camion.TabIndex = 0;
            this.camion.DropDown += new System.EventHandler(this.camion_DropDown);
            this.camion.TextUpdate += new System.EventHandler(this.camion_TextUpdated);
            // 
            // panel7
            // 
            this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel7.AutoSize = true;
            this.panel7.Controls.Add(this.tbl_inf);
            this.panel7.Location = new System.Drawing.Point(14, 578);
            this.panel7.MinimumSize = new System.Drawing.Size(1200, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1268, 294);
            this.panel7.TabIndex = 7;
            // 
            // tbl_inf
            // 
            this.tbl_inf.AllowUserToAddRows = false;
            this.tbl_inf.AllowUserToDeleteRows = false;
            this.tbl_inf.AllowUserToOrderColumns = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Red;
            this.tbl_inf.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.tbl_inf.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbl_inf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbl_inf.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NPesee,
            this.Matricule,
            this.Type,
            this.Fournisseur,
            this.Produit,
            this.DDebut,
            this.HDebut,
            this.DFin,
            this.HFin});
            this.tbl_inf.Location = new System.Drawing.Point(3, 0);
            this.tbl_inf.MinimumSize = new System.Drawing.Size(100, 0);
            this.tbl_inf.MultiSelect = false;
            this.tbl_inf.Name = "tbl_inf";
            this.tbl_inf.ReadOnly = true;
            this.tbl_inf.RowHeadersWidth = 62;
            this.tbl_inf.RowTemplate.Height = 28;
            this.tbl_inf.Size = new System.Drawing.Size(1263, 294);
            this.tbl_inf.TabIndex = 6;
            // 
            // NPesee
            // 
            this.NPesee.FillWeight = 150F;
            this.NPesee.HeaderText = "N Pesee";
            this.NPesee.MinimumWidth = 150;
            this.NPesee.Name = "NPesee";
            this.NPesee.ReadOnly = true;
            this.NPesee.Width = 150;
            // 
            // Matricule
            // 
            this.Matricule.FillWeight = 150F;
            this.Matricule.HeaderText = "Matricule Vehicule";
            this.Matricule.MinimumWidth = 150;
            this.Matricule.Name = "Matricule";
            this.Matricule.ReadOnly = true;
            this.Matricule.Width = 200;
            // 
            // Type
            // 
            this.Type.FillWeight = 150F;
            this.Type.HeaderText = "Type";
            this.Type.MinimumWidth = 150;
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            this.Type.Width = 200;
            // 
            // Fournisseur
            // 
            this.Fournisseur.FillWeight = 150F;
            this.Fournisseur.HeaderText = "Fournisseur";
            this.Fournisseur.MinimumWidth = 150;
            this.Fournisseur.Name = "Fournisseur";
            this.Fournisseur.ReadOnly = true;
            this.Fournisseur.Width = 200;
            // 
            // Produit
            // 
            this.Produit.FillWeight = 150F;
            this.Produit.HeaderText = "Produit";
            this.Produit.MinimumWidth = 150;
            this.Produit.Name = "Produit";
            this.Produit.ReadOnly = true;
            this.Produit.Width = 200;
            // 
            // DDebut
            // 
            this.DDebut.FillWeight = 150F;
            this.DDebut.HeaderText = "Date Debut";
            this.DDebut.MinimumWidth = 150;
            this.DDebut.Name = "DDebut";
            this.DDebut.ReadOnly = true;
            this.DDebut.Width = 200;
            // 
            // HDebut
            // 
            this.HDebut.FillWeight = 150F;
            this.HDebut.HeaderText = "Heure Debut";
            this.HDebut.MinimumWidth = 150;
            this.HDebut.Name = "HDebut";
            this.HDebut.ReadOnly = true;
            this.HDebut.Width = 200;
            // 
            // DFin
            // 
            this.DFin.FillWeight = 150F;
            this.DFin.HeaderText = "Date Fin";
            this.DFin.MinimumWidth = 150;
            this.DFin.Name = "DFin";
            this.DFin.ReadOnly = true;
            this.DFin.Width = 200;
            // 
            // HFin
            // 
            this.HFin.FillWeight = 150F;
            this.HFin.HeaderText = "Heure Fin";
            this.HFin.MinimumWidth = 150;
            this.HFin.Name = "HFin";
            this.HFin.ReadOnly = true;
            this.HFin.Width = 200;
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel6.Controls.Add(this.annulerPesee);
            this.panel6.Controls.Add(this.synthese);
            this.panel6.Location = new System.Drawing.Point(14, 878);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1266, 89);
            this.panel6.TabIndex = 9;
            // 
            // annulerPesee
            // 
            this.annulerPesee.AutoSize = true;
            this.annulerPesee.BackColor = System.Drawing.SystemColors.GrayText;
            this.annulerPesee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.annulerPesee.ForeColor = System.Drawing.SystemColors.Window;
            this.annulerPesee.Location = new System.Drawing.Point(165, 20);
            this.annulerPesee.Name = "annulerPesee";
            this.annulerPesee.Size = new System.Drawing.Size(226, 58);
            this.annulerPesee.TabIndex = 1;
            this.annulerPesee.Text = "Annuler Pesee";
            this.annulerPesee.UseVisualStyleBackColor = false;
            this.annulerPesee.Click += new System.EventHandler(this.annulerPesee_Click);
            // 
            // synthese
            // 
            this.synthese.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.synthese.AutoSize = true;
            this.synthese.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.synthese.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.synthese.ForeColor = System.Drawing.SystemColors.Window;
            this.synthese.Location = new System.Drawing.Point(940, 20);
            this.synthese.Name = "synthese";
            this.synthese.Size = new System.Drawing.Size(166, 58);
            this.synthese.TabIndex = 0;
            this.synthese.Text = "Synthese";
            this.synthese.UseVisualStyleBackColor = false;
            this.synthese.Click += new System.EventHandler(this.synthese_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1284, 968);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Meezane";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbl_inf)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox pesee;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox brutBox;
        private System.Windows.Forms.Button tare;
        private System.Windows.Forms.TextBox tareBox;
        private System.Windows.Forms.Button brut;
        private System.Windows.Forms.TextBox date;
        private System.Windows.Forms.TextBox hour;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox search;
        private System.Windows.Forms.ListBox lstPesee;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button impremer;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox typePesee;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox categorie;
        private System.Windows.Forms.ComboBox produit1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox fournisseurBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox provenance;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox destination;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox camion;
        private System.Windows.Forms.Button annuler;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox nonUsinable;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox Ecart;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox dechets;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox PoidCaisse;
        private System.Windows.Forms.RadioButton Plateaux;
        private System.Windows.Forms.RadioButton caisseNormale;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox nbreCaisse;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.DataGridView tbl_inf;
        private System.Windows.Forms.TextBox frCode;
        private System.Windows.Forms.Button valider;
        private System.Windows.Forms.ComboBox acceuil;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox pes_id;
        private System.Windows.Forms.TextBox pGlace;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox nbrPalettes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton tareAvecCaisse;
        private System.Windows.Forms.RadioButton tareSansCaisse;
        private System.Windows.Forms.DataGridViewTextBoxColumn NPesee;
        private System.Windows.Forms.DataGridViewTextBoxColumn Matricule;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fournisseur;
        private System.Windows.Forms.DataGridViewTextBoxColumn Produit;
        private System.Windows.Forms.DataGridViewTextBoxColumn DDebut;
        private System.Windows.Forms.DataGridViewTextBoxColumn HDebut;
        private System.Windows.Forms.DataGridViewTextBoxColumn DFin;
        private System.Windows.Forms.DataGridViewTextBoxColumn HFin;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button annulerPesee;
        private System.Windows.Forms.Button synthese;
        private rptPesee rptPesee;
    }
}

