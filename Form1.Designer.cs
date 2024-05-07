namespace scale
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
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
            this.valider = new System.Windows.Forms.Button();
            this.frCode = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.nonUsinable = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.Ecart = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.dechets = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.PoidCaisse = new System.Windows.Forms.TextBox();
            this.tareAvecCaisse = new System.Windows.Forms.RadioButton();
            this.tareSansCaisse = new System.Windows.Forms.RadioButton();
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
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_inf)).BeginInit();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(973, 109);
            this.panel1.TabIndex = 0;
            // 
            // tare
            // 
            this.tare.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tare.AutoSize = true;
            this.tare.Location = new System.Drawing.Point(665, 64);
            this.tare.Name = "tare";
            this.tare.Size = new System.Drawing.Size(102, 42);
            this.tare.TabIndex = 4;
            this.tare.Text = "Tare";
            this.tare.UseVisualStyleBackColor = true;
            this.tare.Click += new System.EventHandler(this.tare_Click);
            // 
            // tareBox
            // 
            this.tareBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tareBox.BackColor = System.Drawing.SystemColors.ControlText;
            this.tareBox.ForeColor = System.Drawing.SystemColors.Info;
            this.tareBox.Location = new System.Drawing.Point(773, 66);
            this.tareBox.Multiline = true;
            this.tareBox.Name = "tareBox";
            this.tareBox.ReadOnly = true;
            this.tareBox.Size = new System.Drawing.Size(174, 33);
            this.tareBox.TabIndex = 3;
            this.tareBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // brut
            // 
            this.brut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.brut.AutoSize = true;
            this.brut.Location = new System.Drawing.Point(206, 64);
            this.brut.Name = "brut";
            this.brut.Size = new System.Drawing.Size(109, 42);
            this.brut.TabIndex = 2;
            this.brut.Text = "Brut";
            this.brut.UseVisualStyleBackColor = true;
            this.brut.Click += new System.EventHandler(this.brut_Click);
            // 
            // brutBox
            // 
            this.brutBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.brutBox.BackColor = System.Drawing.SystemColors.ControlText;
            this.brutBox.ForeColor = System.Drawing.SystemColors.Info;
            this.brutBox.Location = new System.Drawing.Point(25, 66);
            this.brutBox.Multiline = true;
            this.brutBox.Name = "brutBox";
            this.brutBox.ReadOnly = true;
            this.brutBox.Size = new System.Drawing.Size(175, 33);
            this.brutBox.TabIndex = 1;
            this.brutBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pesee
            // 
            this.pesee.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pesee.BackColor = System.Drawing.SystemColors.ControlText;
            this.pesee.ForeColor = System.Drawing.SystemColors.Info;
            this.pesee.Location = new System.Drawing.Point(321, 3);
            this.pesee.Multiline = true;
            this.pesee.Name = "pesee";
            this.pesee.Size = new System.Drawing.Size(338, 60);
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
            this.hour.ForeColor = System.Drawing.SystemColors.Info;
            this.hour.Location = new System.Drawing.Point(43, 69);
            this.hour.Name = "hour";
            this.hour.ReadOnly = true;
            this.hour.Size = new System.Drawing.Size(209, 26);
            this.hour.TabIndex = 1;
            this.hour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // date
            // 
            this.date.BackColor = System.Drawing.SystemColors.ControlText;
            this.date.ForeColor = System.Drawing.SystemColors.Info;
            this.date.Location = new System.Drawing.Point(43, 13);
            this.date.Name = "date";
            this.date.ReadOnly = true;
            this.date.Size = new System.Drawing.Size(209, 26);
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
            this.panel3.Location = new System.Drawing.Point(12, 127);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(300, 388);
            this.panel3.TabIndex = 2;
            // 
            // label21
            // 
            this.label21.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(3, 25);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(110, 20);
            this.label21.TabIndex = 4;
            this.label21.Text = "N Bon Pesee :";
            // 
            // impremer
            // 
            this.impremer.AutoSize = true;
            this.impremer.Location = new System.Drawing.Point(65, 337);
            this.impremer.Name = "impremer";
            this.impremer.Size = new System.Drawing.Size(154, 40);
            this.impremer.TabIndex = 3;
            this.impremer.Text = "Impremer Autre";
            this.impremer.UseVisualStyleBackColor = true;
            // 
            // lstPesee
            // 
            this.lstPesee.FormattingEnabled = true;
            this.lstPesee.ItemHeight = 20;
            this.lstPesee.Location = new System.Drawing.Point(23, 76);
            this.lstPesee.Name = "lstPesee";
            this.lstPesee.Size = new System.Drawing.Size(248, 224);
            this.lstPesee.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 1;
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.SystemColors.InfoText;
            this.search.ForeColor = System.Drawing.SystemColors.Info;
            this.search.Location = new System.Drawing.Point(114, 22);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(157, 26);
            this.search.TabIndex = 0;
            this.search.TextChanged += new System.EventHandler(this.search_TextChanged);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.typePesee);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.acceuil);
            this.panel4.Location = new System.Drawing.Point(318, 127);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(973, 48);
            this.panel4.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(552, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "TYPE PESEE :";
            // 
            // typePesee
            // 
            this.typePesee.FormattingEnabled = true;
            this.typePesee.Items.AddRange(new object[] {
            "ENTREE",
            "SORTIE",
            "TRANSFER"});
            this.typePesee.Location = new System.Drawing.Point(689, 10);
            this.typePesee.Name = "typePesee";
            this.typePesee.Size = new System.Drawing.Size(214, 28);
            this.typePesee.Sorted = true;
            this.typePesee.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "ACCEUIL :";
            // 
            // acceuil
            // 
            this.acceuil.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.acceuil.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.acceuil.FormattingEnabled = true;
            this.acceuil.Location = new System.Drawing.Point(151, 10);
            this.acceuil.Name = "acceuil";
            this.acceuil.Size = new System.Drawing.Size(214, 28);
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
            this.panel5.Controls.Add(this.valider);
            this.panel5.Controls.Add(this.frCode);
            this.panel5.Controls.Add(this.label18);
            this.panel5.Controls.Add(this.textBox13);
            this.panel5.Controls.Add(this.label20);
            this.panel5.Controls.Add(this.textBox15);
            this.panel5.Controls.Add(this.label19);
            this.panel5.Controls.Add(this.textBox14);
            this.panel5.Controls.Add(this.label17);
            this.panel5.Controls.Add(this.textBox12);
            this.panel5.Controls.Add(this.label16);
            this.panel5.Controls.Add(this.nonUsinable);
            this.panel5.Controls.Add(this.label15);
            this.panel5.Controls.Add(this.Ecart);
            this.panel5.Controls.Add(this.label14);
            this.panel5.Controls.Add(this.dechets);
            this.panel5.Controls.Add(this.label13);
            this.panel5.Controls.Add(this.PoidCaisse);
            this.panel5.Controls.Add(this.tareAvecCaisse);
            this.panel5.Controls.Add(this.tareSansCaisse);
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
            this.panel5.Location = new System.Drawing.Point(318, 181);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(973, 334);
            this.panel5.TabIndex = 4;
            // 
            // valider
            // 
            this.valider.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.valider.Location = new System.Drawing.Point(377, 273);
            this.valider.Name = "valider";
            this.valider.Size = new System.Drawing.Size(114, 50);
            this.valider.TabIndex = 42;
            this.valider.Text = "Valider";
            this.valider.UseVisualStyleBackColor = true;
            this.valider.Visible = false;
            this.valider.Click += new System.EventHandler(this.valider_Click);
            // 
            // frCode
            // 
            this.frCode.BackColor = System.Drawing.SystemColors.InfoText;
            this.frCode.ForeColor = System.Drawing.SystemColors.Info;
            this.frCode.Location = new System.Drawing.Point(134, 128);
            this.frCode.Name = "frCode";
            this.frCode.Size = new System.Drawing.Size(58, 26);
            this.frCode.TabIndex = 41;
            this.frCode.TextChanged += new System.EventHandler(this.frCode_TextChanged);
            // 
            // label18
            // 
            this.label18.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(769, 143);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(69, 20);
            this.label18.TabIndex = 40;
            this.label18.Text = "Net MP :";
            // 
            // textBox13
            // 
            this.textBox13.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.textBox13.Enabled = false;
            this.textBox13.Location = new System.Drawing.Point(847, 143);
            this.textBox13.Name = "textBox13";
            this.textBox13.ReadOnly = true;
            this.textBox13.Size = new System.Drawing.Size(100, 26);
            this.textBox13.TabIndex = 39;
            // 
            // label20
            // 
            this.label20.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(769, 106);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(77, 20);
            this.label20.TabIndex = 38;
            this.label20.Text = "Dechets :";
            // 
            // textBox15
            // 
            this.textBox15.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.textBox15.Location = new System.Drawing.Point(847, 106);
            this.textBox15.Name = "textBox15";
            this.textBox15.ReadOnly = true;
            this.textBox15.Size = new System.Drawing.Size(100, 26);
            this.textBox15.TabIndex = 37;
            // 
            // label19
            // 
            this.label19.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(769, 71);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(51, 20);
            this.label19.TabIndex = 36;
            this.label19.Text = "Net1 :";
            // 
            // textBox14
            // 
            this.textBox14.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.textBox14.Location = new System.Drawing.Point(847, 71);
            this.textBox14.Name = "textBox14";
            this.textBox14.ReadOnly = true;
            this.textBox14.Size = new System.Drawing.Size(100, 26);
            this.textBox14.TabIndex = 35;
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(769, 35);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(47, 20);
            this.label17.TabIndex = 32;
            this.label17.Text = "Brut :";
            // 
            // textBox12
            // 
            this.textBox12.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.textBox12.Location = new System.Drawing.Point(847, 35);
            this.textBox12.Name = "textBox12";
            this.textBox12.ReadOnly = true;
            this.textBox12.Size = new System.Drawing.Size(100, 26);
            this.textBox12.TabIndex = 31;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(655, 233);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(112, 20);
            this.label16.TabIndex = 30;
            this.label16.Text = "Non Usinable :";
            this.label16.Visible = false;
            // 
            // nonUsinable
            // 
            this.nonUsinable.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.nonUsinable.ForeColor = System.Drawing.SystemColors.Info;
            this.nonUsinable.Location = new System.Drawing.Point(773, 226);
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
            this.label15.Location = new System.Drawing.Point(658, 200);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(55, 20);
            this.label15.TabIndex = 28;
            this.label15.Text = "Ecart :";
            this.label15.Visible = false;
            // 
            // Ecart
            // 
            this.Ecart.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Ecart.ForeColor = System.Drawing.SystemColors.Info;
            this.Ecart.Location = new System.Drawing.Point(773, 194);
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
            this.label14.Location = new System.Drawing.Point(402, 229);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(103, 20);
            this.label14.TabIndex = 26;
            this.label14.Text = "Dechets FR :";
            this.label14.Visible = false;
            // 
            // dechets
            // 
            this.dechets.BackColor = System.Drawing.SystemColors.InfoText;
            this.dechets.ForeColor = System.Drawing.SystemColors.Info;
            this.dechets.Location = new System.Drawing.Point(535, 227);
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
            this.label13.Location = new System.Drawing.Point(402, 197);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 20);
            this.label13.TabIndex = 24;
            this.label13.Text = "Poid Caisse :";
            this.label13.Visible = false;
            // 
            // PoidCaisse
            // 
            this.PoidCaisse.BackColor = System.Drawing.SystemColors.InfoText;
            this.PoidCaisse.ForeColor = System.Drawing.SystemColors.Info;
            this.PoidCaisse.Location = new System.Drawing.Point(535, 197);
            this.PoidCaisse.Name = "PoidCaisse";
            this.PoidCaisse.Size = new System.Drawing.Size(100, 26);
            this.PoidCaisse.TabIndex = 23;
            this.PoidCaisse.Text = "0";
            this.PoidCaisse.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PoidCaisse.Visible = false;
            // 
            // tareAvecCaisse
            // 
            this.tareAvecCaisse.AutoSize = true;
            this.tareAvecCaisse.Location = new System.Drawing.Point(206, 252);
            this.tareAvecCaisse.Name = "tareAvecCaisse";
            this.tareAvecCaisse.Size = new System.Drawing.Size(165, 24);
            this.tareAvecCaisse.TabIndex = 22;
            this.tareAvecCaisse.TabStop = true;
            this.tareAvecCaisse.Text = "Tare Avec Caisses";
            this.tareAvecCaisse.UseVisualStyleBackColor = true;
            this.tareAvecCaisse.Visible = false;
            // 
            // tareSansCaisse
            // 
            this.tareSansCaisse.AutoSize = true;
            this.tareSansCaisse.Location = new System.Drawing.Point(25, 252);
            this.tareSansCaisse.Name = "tareSansCaisse";
            this.tareSansCaisse.Size = new System.Drawing.Size(167, 24);
            this.tareSansCaisse.TabIndex = 21;
            this.tareSansCaisse.TabStop = true;
            this.tareSansCaisse.Text = "Tare Sans Caisses";
            this.tareSansCaisse.UseVisualStyleBackColor = true;
            this.tareSansCaisse.Visible = false;
            // 
            // Plateaux
            // 
            this.Plateaux.AutoSize = true;
            this.Plateaux.Location = new System.Drawing.Point(239, 222);
            this.Plateaux.Name = "Plateaux";
            this.Plateaux.Size = new System.Drawing.Size(95, 24);
            this.Plateaux.TabIndex = 20;
            this.Plateaux.TabStop = true;
            this.Plateaux.Text = "Plateaux";
            this.Plateaux.UseVisualStyleBackColor = true;
            this.Plateaux.Visible = false;
            // 
            // caisseNormale
            // 
            this.caisseNormale.AutoSize = true;
            this.caisseNormale.Location = new System.Drawing.Point(239, 193);
            this.caisseNormale.Name = "caisseNormale";
            this.caisseNormale.Size = new System.Drawing.Size(153, 24);
            this.caisseNormale.TabIndex = 19;
            this.caisseNormale.TabStop = true;
            this.caisseNormale.Text = "Caisse Normales";
            this.caisseNormale.UseVisualStyleBackColor = true;
            this.caisseNormale.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 207);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(103, 20);
            this.label12.TabIndex = 12;
            this.label12.Text = "Nbre Caisse :";
            this.label12.Visible = false;
            // 
            // nbreCaisse
            // 
            this.nbreCaisse.BackColor = System.Drawing.SystemColors.InfoText;
            this.nbreCaisse.ForeColor = System.Drawing.SystemColors.Info;
            this.nbreCaisse.Location = new System.Drawing.Point(121, 204);
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
            this.annuler.Location = new System.Drawing.Point(576, 273);
            this.annuler.Name = "annuler";
            this.annuler.Size = new System.Drawing.Size(114, 50);
            this.annuler.TabIndex = 16;
            this.annuler.Text = "Annuler";
            this.annuler.UseVisualStyleBackColor = true;
            this.annuler.Click += new System.EventHandler(this.annuler_Click);
            // 
            // categorie
            // 
            this.categorie.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.categorie.FormattingEnabled = true;
            this.categorie.Location = new System.Drawing.Point(535, 14);
            this.categorie.Name = "categorie";
            this.categorie.Size = new System.Drawing.Size(214, 28);
            this.categorie.TabIndex = 14;
            this.categorie.DropDown += new System.EventHandler(this.categorie_DropDown);
            // 
            // produit1
            // 
            this.produit1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.produit1.FormattingEnabled = true;
            this.produit1.Location = new System.Drawing.Point(535, 71);
            this.produit1.Name = "produit1";
            this.produit1.Size = new System.Drawing.Size(214, 28);
            this.produit1.TabIndex = 12;
            this.produit1.DropDown += new System.EventHandler(this.produit1_DropDown);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(450, 71);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 20);
            this.label9.TabIndex = 11;
            this.label9.Text = "Article :";
            // 
            // fournisseurBox
            // 
            this.fournisseurBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.fournisseurBox.FormattingEnabled = true;
            this.fournisseurBox.Location = new System.Drawing.Point(199, 128);
            this.fournisseurBox.Name = "fournisseurBox";
            this.fournisseurBox.Size = new System.Drawing.Size(214, 28);
            this.fournisseurBox.TabIndex = 10;
            this.fournisseurBox.DropDown += new System.EventHandler(this.fournisseurBox_DropDown);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(430, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 20);
            this.label8.TabIndex = 9;
            this.label8.Text = "Type Article :";
            // 
            // provenance
            // 
            this.provenance.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.provenance.FormattingEnabled = true;
            this.provenance.Location = new System.Drawing.Point(157, 71);
            this.provenance.Name = "provenance";
            this.provenance.Size = new System.Drawing.Size(214, 28);
            this.provenance.TabIndex = 8;
            this.provenance.DropDown += new System.EventHandler(this.provenance_DropDown);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(431, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Destination :";
            // 
            // destination
            // 
            this.destination.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.destination.FormattingEnabled = true;
            this.destination.Location = new System.Drawing.Point(535, 136);
            this.destination.Name = "destination";
            this.destination.Size = new System.Drawing.Size(214, 28);
            this.destination.TabIndex = 6;
            this.destination.DropDown += new System.EventHandler(this.destination_DropDown);
            this.destination.TextChanged += new System.EventHandler(this.destination_TextChanged);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Fournisseur :";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Provenance :";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Matricule :";
            // 
            // camion
            // 
            this.camion.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.camion.FormattingEnabled = true;
            this.camion.Location = new System.Drawing.Point(151, 13);
            this.camion.Name = "camion";
            this.camion.Size = new System.Drawing.Size(214, 28);
            this.camion.TabIndex = 0;
            this.camion.DropDown += new System.EventHandler(this.camion_DropDown);
            // 
            // panel7
            // 
            this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel7.AutoSize = true;
            this.panel7.Controls.Add(this.tbl_inf);
            this.panel7.Location = new System.Drawing.Point(12, 521);
            this.panel7.MinimumSize = new System.Drawing.Size(1200, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1279, 367);
            this.panel7.TabIndex = 7;
            // 
            // tbl_inf
            // 
            this.tbl_inf.AllowUserToAddRows = false;
            this.tbl_inf.AllowUserToDeleteRows = false;
            this.tbl_inf.AllowUserToOrderColumns = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Red;
            this.tbl_inf.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
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
            this.tbl_inf.Location = new System.Drawing.Point(0, 0);
            this.tbl_inf.MinimumSize = new System.Drawing.Size(100, 0);
            this.tbl_inf.MultiSelect = false;
            this.tbl_inf.Name = "tbl_inf";
            this.tbl_inf.ReadOnly = true;
            this.tbl_inf.RowHeadersWidth = 62;
            this.tbl_inf.RowTemplate.Height = 28;
            this.tbl_inf.Size = new System.Drawing.Size(1273, 364);
            this.tbl_inf.TabIndex = 6;
            // 
            // NPesee
            // 
            this.NPesee.HeaderText = "N Pesee";
            this.NPesee.MinimumWidth = 8;
            this.NPesee.Name = "NPesee";
            this.NPesee.ReadOnly = true;
            this.NPesee.Width = 150;
            // 
            // Matricule
            // 
            this.Matricule.HeaderText = "Matricule Vehicule";
            this.Matricule.MinimumWidth = 8;
            this.Matricule.Name = "Matricule";
            this.Matricule.ReadOnly = true;
            this.Matricule.Width = 150;
            // 
            // Type
            // 
            this.Type.HeaderText = "Type";
            this.Type.MinimumWidth = 8;
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            this.Type.Width = 150;
            // 
            // Fournisseur
            // 
            this.Fournisseur.HeaderText = "Fournisseur";
            this.Fournisseur.MinimumWidth = 8;
            this.Fournisseur.Name = "Fournisseur";
            this.Fournisseur.ReadOnly = true;
            this.Fournisseur.Width = 150;
            // 
            // Produit
            // 
            this.Produit.HeaderText = "Produit";
            this.Produit.MinimumWidth = 8;
            this.Produit.Name = "Produit";
            this.Produit.ReadOnly = true;
            this.Produit.Width = 150;
            // 
            // DDebut
            // 
            this.DDebut.HeaderText = "Date Debut";
            this.DDebut.MinimumWidth = 8;
            this.DDebut.Name = "DDebut";
            this.DDebut.ReadOnly = true;
            this.DDebut.Width = 150;
            // 
            // HDebut
            // 
            this.HDebut.HeaderText = "Heure Debut";
            this.HDebut.MinimumWidth = 8;
            this.HDebut.Name = "HDebut";
            this.HDebut.ReadOnly = true;
            this.HDebut.Width = 150;
            // 
            // DFin
            // 
            this.DFin.HeaderText = "Date Fin";
            this.DFin.MinimumWidth = 8;
            this.DFin.Name = "DFin";
            this.DFin.ReadOnly = true;
            this.DFin.Width = 150;
            // 
            // HFin
            // 
            this.HFin.HeaderText = "Heure Fin";
            this.HFin.MinimumWidth = 8;
            this.HFin.Name = "HFin";
            this.HFin.ReadOnly = true;
            this.HFin.Width = 150;
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel6.Controls.Add(this.annulerPesee);
            this.panel6.Controls.Add(this.synthese);
            this.panel6.Location = new System.Drawing.Point(12, 894);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1286, 65);
            this.panel6.TabIndex = 8;
            // 
            // annulerPesee
            // 
            this.annulerPesee.AutoSize = true;
            this.annulerPesee.BackColor = System.Drawing.SystemColors.GrayText;
            this.annulerPesee.ForeColor = System.Drawing.SystemColors.Window;
            this.annulerPesee.Location = new System.Drawing.Point(165, 3);
            this.annulerPesee.Name = "annulerPesee";
            this.annulerPesee.Size = new System.Drawing.Size(166, 59);
            this.annulerPesee.TabIndex = 1;
            this.annulerPesee.Text = "Annuler Pesee";
            this.annulerPesee.UseVisualStyleBackColor = false;
            // 
            // synthese
            // 
            this.synthese.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.synthese.AutoSize = true;
            this.synthese.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.synthese.ForeColor = System.Drawing.SystemColors.Window;
            this.synthese.Location = new System.Drawing.Point(978, 3);
            this.synthese.Name = "synthese";
            this.synthese.Size = new System.Drawing.Size(166, 59);
            this.synthese.TabIndex = 0;
            this.synthese.Text = "Synthese";
            this.synthese.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1303, 955);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
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
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbl_inf)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
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
        private System.Windows.Forms.ComboBox acceuil;
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
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox nonUsinable;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox Ecart;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox dechets;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox PoidCaisse;
        private System.Windows.Forms.RadioButton tareAvecCaisse;
        private System.Windows.Forms.RadioButton tareSansCaisse;
        private System.Windows.Forms.RadioButton Plateaux;
        private System.Windows.Forms.RadioButton caisseNormale;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox nbreCaisse;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.DataGridView tbl_inf;
        private System.Windows.Forms.TextBox frCode;
        private System.Windows.Forms.Button valider;
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
    }
}

