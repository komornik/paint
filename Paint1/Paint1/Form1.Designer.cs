namespace Paint
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otwórzToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nowyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zapiszToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drukujToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ądWydrukuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operacjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scalowanieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.obróćToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prawoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lewoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.odbicieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.względemOsiXToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.względemOsiYToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.convertToMonochromate1BitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.convertToBlackWhiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.default1 = new System.Windows.Forms.PictureBox();
            this.color1 = new System.Windows.Forms.PictureBox();
            this.color2 = new System.Windows.Forms.PictureBox();
            this.color3 = new System.Windows.Forms.PictureBox();
            this.color4 = new System.Windows.Forms.PictureBox();
            this.linia = new System.Windows.Forms.Button();
            this.kwadrat = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusX = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusTextX = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelY = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusTextY = new System.Windows.Forms.ToolStripStatusLabel();
            this.portLCh = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tekst = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.default2 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.gumka = new System.Windows.Forms.Button();
            this.olowek = new System.Windows.Forms.Button();
            this.elipsa = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rozmiar = new System.Windows.Forms.TrackBar();
            this.drukujDialog = new System.Windows.Forms.PrintDialog();
            this.widokWydrukuDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.wyslijDoUrzadzToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.default1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.color1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.color2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.color3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.color4)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.default2)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rozmiar)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem,
            this.operacjeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(480, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.otwórzToolStripMenuItem,
            this.nowyToolStripMenuItem,
            this.zapiszToolStripMenuItem,
            this.drukujToolStripMenuItem,
            this.ądWydrukuToolStripMenuItem});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.plikToolStripMenuItem.Text = "Plik";
            // 
            // otwórzToolStripMenuItem
            // 
            this.otwórzToolStripMenuItem.Name = "otwórzToolStripMenuItem";
            this.otwórzToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.otwórzToolStripMenuItem.Text = "Otwórz";
            this.otwórzToolStripMenuItem.Click += new System.EventHandler(this.otwórzToolStripMenuItem_Click);
            // 
            // nowyToolStripMenuItem
            // 
            this.nowyToolStripMenuItem.Name = "nowyToolStripMenuItem";
            this.nowyToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.nowyToolStripMenuItem.Text = "Nowy";
            this.nowyToolStripMenuItem.Click += new System.EventHandler(this.nowyToolStripMenuItem_Click);
            // 
            // zapiszToolStripMenuItem
            // 
            this.zapiszToolStripMenuItem.Name = "zapiszToolStripMenuItem";
            this.zapiszToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.zapiszToolStripMenuItem.Text = "Zapisz";
            this.zapiszToolStripMenuItem.Click += new System.EventHandler(this.zapiszToolStripMenuItem_Click);
            // 
            // drukujToolStripMenuItem
            // 
            this.drukujToolStripMenuItem.Name = "drukujToolStripMenuItem";
            this.drukujToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.drukujToolStripMenuItem.Text = "Drukuj";
            this.drukujToolStripMenuItem.Click += new System.EventHandler(this.drukujToolStripMenuItem_Click);
            // 
            // ądWydrukuToolStripMenuItem
            // 
            this.ądWydrukuToolStripMenuItem.Name = "ądWydrukuToolStripMenuItem";
            this.ądWydrukuToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.ądWydrukuToolStripMenuItem.Text = "Podgląd wydruku";
            this.ądWydrukuToolStripMenuItem.Click += new System.EventHandler(this.ądWydrukuToolStripMenuItem_Click);
            // 
            // operacjeToolStripMenuItem
            // 
            this.operacjeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.scalowanieToolStripMenuItem,
            this.obróćToolStripMenuItem,
            this.odbicieToolStripMenuItem,
            this.convertToMonochromate1BitToolStripMenuItem,
            this.convertToBlackWhiteToolStripMenuItem,
            this.wyslijDoUrzadzToolStripMenuItem});
            this.operacjeToolStripMenuItem.Name = "operacjeToolStripMenuItem";
            this.operacjeToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.operacjeToolStripMenuItem.Text = "Operacje";
            // 
            // scalowanieToolStripMenuItem
            // 
            this.scalowanieToolStripMenuItem.Name = "scalowanieToolStripMenuItem";
            this.scalowanieToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.scalowanieToolStripMenuItem.Text = "Scalowanie";
            this.scalowanieToolStripMenuItem.Click += new System.EventHandler(this.scalowanieToolStripMenuItem_Click);
            // 
            // obróćToolStripMenuItem
            // 
            this.obróćToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prawoToolStripMenuItem,
            this.lewoToolStripMenuItem});
            this.obróćToolStripMenuItem.Name = "obróćToolStripMenuItem";
            this.obróćToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.obróćToolStripMenuItem.Text = "Obróć";
            // 
            // prawoToolStripMenuItem
            // 
            this.prawoToolStripMenuItem.Name = "prawoToolStripMenuItem";
            this.prawoToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.prawoToolStripMenuItem.Text = "prawo";
            this.prawoToolStripMenuItem.Click += new System.EventHandler(this.prawoToolStripMenuItem_Click);
            // 
            // lewoToolStripMenuItem
            // 
            this.lewoToolStripMenuItem.Name = "lewoToolStripMenuItem";
            this.lewoToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.lewoToolStripMenuItem.Text = "lewo";
            this.lewoToolStripMenuItem.Click += new System.EventHandler(this.lewoToolStripMenuItem_Click);
            // 
            // odbicieToolStripMenuItem
            // 
            this.odbicieToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.względemOsiXToolStripMenuItem,
            this.względemOsiYToolStripMenuItem});
            this.odbicieToolStripMenuItem.Name = "odbicieToolStripMenuItem";
            this.odbicieToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.odbicieToolStripMenuItem.Text = "Odbicie";
            // 
            // względemOsiXToolStripMenuItem
            // 
            this.względemOsiXToolStripMenuItem.Name = "względemOsiXToolStripMenuItem";
            this.względemOsiXToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.względemOsiXToolStripMenuItem.Text = "Względem osi X";
            this.względemOsiXToolStripMenuItem.Click += new System.EventHandler(this.względemOsiXToolStripMenuItem_Click);
            // 
            // względemOsiYToolStripMenuItem
            // 
            this.względemOsiYToolStripMenuItem.Name = "względemOsiYToolStripMenuItem";
            this.względemOsiYToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.względemOsiYToolStripMenuItem.Text = "Względem osi Y";
            this.względemOsiYToolStripMenuItem.Click += new System.EventHandler(this.względemOsiYToolStripMenuItem_Click);
            // 
            // convertToMonochromate1BitToolStripMenuItem
            // 
            this.convertToMonochromate1BitToolStripMenuItem.Name = "convertToMonochromate1BitToolStripMenuItem";
            this.convertToMonochromate1BitToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.convertToMonochromate1BitToolStripMenuItem.Text = "convert to ";
            this.convertToMonochromate1BitToolStripMenuItem.Click += new System.EventHandler(this.convertToMonochromate1BitToolStripMenuItem_Click);
            // 
            // convertToBlackWhiteToolStripMenuItem
            // 
            this.convertToBlackWhiteToolStripMenuItem.Name = "convertToBlackWhiteToolStripMenuItem";
            this.convertToBlackWhiteToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.convertToBlackWhiteToolStripMenuItem.Text = "Convert to Black-White";
            this.convertToBlackWhiteToolStripMenuItem.Click += new System.EventHandler(this.convertToBlackWhiteToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(3, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(364, 308);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Location = new System.Drawing.Point(0, -3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(0, 0);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseDown);
            this.pictureBox2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseMove);
            this.pictureBox2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseUp);
            // 
            // default1
            // 
            this.default1.BackColor = System.Drawing.Color.Black;
            this.default1.Location = new System.Drawing.Point(0, 12);
            this.default1.Name = "default1";
            this.default1.Size = new System.Drawing.Size(26, 24);
            this.default1.TabIndex = 3;
            this.default1.TabStop = false;
            this.default1.Paint += new System.Windows.Forms.PaintEventHandler(this.defoult1_Paint);
            // 
            // color1
            // 
            this.color1.BackColor = System.Drawing.Color.Red;
            this.color1.Location = new System.Drawing.Point(53, 12);
            this.color1.Name = "color1";
            this.color1.Size = new System.Drawing.Size(16, 16);
            this.color1.TabIndex = 4;
            this.color1.TabStop = false;
            this.color1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.color1_MouseDoubleClick);
            this.color1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.color1_MouseDown);
            // 
            // color2
            // 
            this.color2.BackColor = System.Drawing.Color.Blue;
            this.color2.Location = new System.Drawing.Point(75, 12);
            this.color2.Name = "color2";
            this.color2.Size = new System.Drawing.Size(16, 16);
            this.color2.TabIndex = 5;
            this.color2.TabStop = false;
            this.color2.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.color2_MouseDoubleClick);
            this.color2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.color2_MouseDown);
            // 
            // color3
            // 
            this.color3.BackColor = System.Drawing.Color.Green;
            this.color3.Location = new System.Drawing.Point(53, 34);
            this.color3.Name = "color3";
            this.color3.Size = new System.Drawing.Size(16, 16);
            this.color3.TabIndex = 6;
            this.color3.TabStop = false;
            this.color3.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.color3_MouseDoubleClick);
            this.color3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.color3_MouseDown);
            // 
            // color4
            // 
            this.color4.BackColor = System.Drawing.Color.White;
            this.color4.Location = new System.Drawing.Point(75, 34);
            this.color4.Name = "color4";
            this.color4.Size = new System.Drawing.Size(16, 16);
            this.color4.TabIndex = 7;
            this.color4.TabStop = false;
            this.color4.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.color4_MouseDoubleClick);
            this.color4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.color4_MouseDown);
            // 
            // linia
            // 
            this.linia.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F);
            this.linia.Location = new System.Drawing.Point(15, 71);
            this.linia.Name = "linia";
            this.linia.Size = new System.Drawing.Size(32, 24);
            this.linia.TabIndex = 8;
            this.linia.Text = "linia";
            this.linia.UseVisualStyleBackColor = true;
            this.linia.Click += new System.EventHandler(this.linia_Click);
            // 
            // kwadrat
            // 
            this.kwadrat.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F);
            this.kwadrat.Location = new System.Drawing.Point(59, 71);
            this.kwadrat.Name = "kwadrat";
            this.kwadrat.Size = new System.Drawing.Size(32, 24);
            this.kwadrat.TabIndex = 9;
            this.kwadrat.Text = "kwa";
            this.kwadrat.UseVisualStyleBackColor = true;
            this.kwadrat.Click += new System.EventHandler(this.kwadrat_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusX,
            this.toolStripStatusTextX,
            this.toolStripStatusLabel1,
            this.toolStripStatusLabelY,
            this.toolStripStatusTextY,
            this.portLCh});
            this.statusStrip1.Location = new System.Drawing.Point(0, 340);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(480, 22);
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusX
            // 
            this.toolStripStatusX.Name = "toolStripStatusX";
            this.toolStripStatusX.Size = new System.Drawing.Size(17, 17);
            this.toolStripStatusX.Text = "X:";
            // 
            // toolStripStatusTextX
            // 
            this.toolStripStatusTextX.Name = "toolStripStatusTextX";
            this.toolStripStatusTextX.Size = new System.Drawing.Size(13, 17);
            this.toolStripStatusTextX.Text = "0";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(13, 17);
            this.toolStripStatusLabel1.Text = "  ";
            // 
            // toolStripStatusLabelY
            // 
            this.toolStripStatusLabelY.Name = "toolStripStatusLabelY";
            this.toolStripStatusLabelY.Size = new System.Drawing.Size(17, 17);
            this.toolStripStatusLabelY.Text = "Y:";
            // 
            // toolStripStatusTextY
            // 
            this.toolStripStatusTextY.Name = "toolStripStatusTextY";
            this.toolStripStatusTextY.Size = new System.Drawing.Size(13, 17);
            this.toolStripStatusTextY.Text = "0";
            // 
            // portLCh
            // 
            this.portLCh.Name = "portLCh";
            this.portLCh.Size = new System.Drawing.Size(0, 17);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tekst);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.default1);
            this.panel2.Controls.Add(this.default2);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.gumka);
            this.panel2.Controls.Add(this.olowek);
            this.panel2.Controls.Add(this.elipsa);
            this.panel2.Controls.Add(this.kwadrat);
            this.panel2.Controls.Add(this.color1);
            this.panel2.Controls.Add(this.linia);
            this.panel2.Controls.Add(this.color2);
            this.panel2.Controls.Add(this.color4);
            this.panel2.Controls.Add(this.color3);
            this.panel2.Location = new System.Drawing.Point(370, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(110, 310);
            this.panel2.TabIndex = 1;
            // 
            // tekst
            // 
            this.tekst.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F);
            this.tekst.Location = new System.Drawing.Point(15, 161);
            this.tekst.Name = "tekst";
            this.tekst.Size = new System.Drawing.Size(32, 24);
            this.tekst.TabIndex = 17;
            this.tekst.Text = "teks";
            this.tekst.UseVisualStyleBackColor = true;
            this.tekst.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tekst_MouseClick);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F);
            this.button1.Location = new System.Drawing.Point(60, 131);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 24);
            this.button1.TabIndex = 16;
            this.button1.Text = "wypel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // default2
            // 
            this.default2.BackColor = System.Drawing.Color.Black;
            this.default2.Location = new System.Drawing.Point(21, 26);
            this.default2.Name = "default2";
            this.default2.Size = new System.Drawing.Size(26, 24);
            this.default2.TabIndex = 15;
            this.default2.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(0, 192);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(110, 118);
            this.panel3.TabIndex = 14;
            // 
            // gumka
            // 
            this.gumka.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F);
            this.gumka.Location = new System.Drawing.Point(15, 131);
            this.gumka.Name = "gumka";
            this.gumka.Size = new System.Drawing.Size(32, 24);
            this.gumka.TabIndex = 13;
            this.gumka.Text = "gum";
            this.gumka.UseVisualStyleBackColor = true;
            this.gumka.Click += new System.EventHandler(this.gumka_Click);
            // 
            // olowek
            // 
            this.olowek.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F);
            this.olowek.Location = new System.Drawing.Point(59, 101);
            this.olowek.Name = "olowek";
            this.olowek.Size = new System.Drawing.Size(39, 24);
            this.olowek.TabIndex = 12;
            this.olowek.Text = "olow";
            this.olowek.UseVisualStyleBackColor = true;
            this.olowek.Click += new System.EventHandler(this.olowek_Click);
            // 
            // elipsa
            // 
            this.elipsa.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F);
            this.elipsa.Location = new System.Drawing.Point(15, 101);
            this.elipsa.Name = "elipsa";
            this.elipsa.Size = new System.Drawing.Size(32, 24);
            this.elipsa.TabIndex = 11;
            this.elipsa.Text = "elip";
            this.elipsa.UseVisualStyleBackColor = true;
            this.elipsa.Click += new System.EventHandler(this.elipsa_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.rozmiar);
            this.groupBox1.Location = new System.Drawing.Point(370, 232);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(106, 102);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "(0-50)";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(10, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(41, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "0";
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Rozmiar lini";
            // 
            // rozmiar
            // 
            this.rozmiar.Location = new System.Drawing.Point(0, 55);
            this.rozmiar.Maximum = 50;
            this.rozmiar.Name = "rozmiar";
            this.rozmiar.Size = new System.Drawing.Size(104, 45);
            this.rozmiar.TabIndex = 0;
            this.rozmiar.Tag = "rozmiar";
            this.rozmiar.ValueChanged += new System.EventHandler(this.rozmiar_ValueChanged);
            // 
            // drukujDialog
            // 
            this.drukujDialog.UseEXDialog = true;
            // 
            // widokWydrukuDialog
            // 
            this.widokWydrukuDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.widokWydrukuDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.widokWydrukuDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.widokWydrukuDialog.Enabled = true;
            this.widokWydrukuDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("widokWydrukuDialog.Icon")));
            this.widokWydrukuDialog.Name = "widokWydrukuDialog";
            this.widokWydrukuDialog.Visible = false;
            // 
            // wyslijDoUrzadzToolStripMenuItem
            // 
            this.wyslijDoUrzadzToolStripMenuItem.Name = "wyslijDoUrzadzToolStripMenuItem";
            this.wyslijDoUrzadzToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.wyslijDoUrzadzToolStripMenuItem.Text = "Wyślij do urządzenia";
            this.wyslijDoUrzadzToolStripMenuItem.Click += new System.EventHandler(this.wyslijDoUrzadzToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(480, 362);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.default1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.color1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.color2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.color3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.color4)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.default2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rozmiar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox default1;
        private System.Windows.Forms.PictureBox color1;
        private System.Windows.Forms.PictureBox color2;
        private System.Windows.Forms.PictureBox color3;
        private System.Windows.Forms.PictureBox color4;
        private System.Windows.Forms.Button linia;
        private System.Windows.Forms.Button kwadrat;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusX;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusTextX;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelY;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusTextY;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStripMenuItem otwórzToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zapiszToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operacjeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scalowanieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nowyToolStripMenuItem;
        private System.Windows.Forms.Button elipsa;
        private System.Windows.Forms.Button olowek;
        private System.Windows.Forms.Button gumka;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar rozmiar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox default2;
        private System.Windows.Forms.ToolStripMenuItem obróćToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prawoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lewoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem odbicieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem względemOsiXToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem względemOsiYToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button tekst;
        private System.Windows.Forms.ToolStripMenuItem drukujToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ądWydrukuToolStripMenuItem;
        private System.Windows.Forms.PrintDialog drukujDialog;
        private System.Windows.Forms.PrintPreviewDialog widokWydrukuDialog;
        private System.Windows.Forms.ToolStripMenuItem convertToMonochromate1BitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem convertToBlackWhiteToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel portLCh;
        private System.Windows.Forms.ToolStripMenuItem wyslijDoUrzadzToolStripMenuItem;
    }
}

