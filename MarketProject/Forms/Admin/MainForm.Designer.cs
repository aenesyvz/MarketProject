using System.Windows.Forms;

namespace MarketProject.Forms.Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panelLeft = new System.Windows.Forms.Panel();
            this.btnBorc = new System.Windows.Forms.Button();
            this.btnRapor = new System.Windows.Forms.Button();
            this.btnTedarikci = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnMusteri = new System.Windows.Forms.Button();
            this.btnUrunStok = new System.Windows.Forms.Button();
            this.btnMarketSatis = new System.Windows.Forms.Button();
            this.panelTopLeft = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnHome = new System.Windows.Forms.Button();
            this.panelTopMid = new System.Windows.Forms.Panel();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.labelBaslik = new System.Windows.Forms.Label();
            this.labelTarih = new System.Windows.Forms.Label();
            this.labelSaat = new System.Windows.Forms.Label();
            this.panelBeyaz = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelHosgeldiniz = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelLeft.SuspendLayout();
            this.panelTopLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panelTopMid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.panelBeyaz.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelLeft.Controls.Add(this.btnBorc);
            this.panelLeft.Controls.Add(this.btnRapor);
            this.panelLeft.Controls.Add(this.btnTedarikci);
            this.panelLeft.Controls.Add(this.btnExit);
            this.panelLeft.Controls.Add(this.btnMusteri);
            this.panelLeft.Controls.Add(this.btnUrunStok);
            this.panelLeft.Controls.Add(this.btnMarketSatis);
            this.panelLeft.Controls.Add(this.panelTopLeft);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Margin = new System.Windows.Forms.Padding(4);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(287, 911);
            this.panelLeft.TabIndex = 0;
            // 
            // btnBorc
            // 
            this.btnBorc.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBorc.FlatAppearance.BorderSize = 0;
            this.btnBorc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorc.ForeColor = System.Drawing.Color.White;
            this.btnBorc.Image = ((System.Drawing.Image)(resources.GetObject("btnBorc.Image")));
            this.btnBorc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBorc.Location = new System.Drawing.Point(0, 612);
            this.btnBorc.Name = "btnBorc";
            this.btnBorc.Size = new System.Drawing.Size(287, 100);
            this.btnBorc.TabIndex = 8;
            this.btnBorc.Text = "  Borç İşlemleri";
            this.btnBorc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBorc.UseVisualStyleBackColor = true;
            this.btnBorc.Click += new System.EventHandler(this.btnBorc_Click);
            // 
            // btnRapor
            // 
            this.btnRapor.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRapor.FlatAppearance.BorderSize = 0;
            this.btnRapor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRapor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRapor.ForeColor = System.Drawing.Color.White;
            this.btnRapor.Image = ((System.Drawing.Image)(resources.GetObject("btnRapor.Image")));
            this.btnRapor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRapor.Location = new System.Drawing.Point(0, 506);
            this.btnRapor.Name = "btnRapor";
            this.btnRapor.Size = new System.Drawing.Size(287, 100);
            this.btnRapor.TabIndex = 7;
            this.btnRapor.Text = "  Rapor Alım";
            this.btnRapor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRapor.UseVisualStyleBackColor = true;
            this.btnRapor.Click += new System.EventHandler(this.btnRapor_Click);
            // 
            // btnTedarikci
            // 
            this.btnTedarikci.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnTedarikci.FlatAppearance.BorderSize = 0;
            this.btnTedarikci.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTedarikci.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTedarikci.ForeColor = System.Drawing.Color.White;
            this.btnTedarikci.Image = ((System.Drawing.Image)(resources.GetObject("btnTedarikci.Image")));
            this.btnTedarikci.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTedarikci.Location = new System.Drawing.Point(0, 400);
            this.btnTedarikci.Name = "btnTedarikci";
            this.btnTedarikci.Size = new System.Drawing.Size(287, 100);
            this.btnTedarikci.TabIndex = 6;
            this.btnTedarikci.Text = "  Tedarikçi İşlemleri";
            this.btnTedarikci.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTedarikci.UseVisualStyleBackColor = true;
            this.btnTedarikci.Click += new System.EventHandler(this.btnTedarikci_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(0, 815);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(287, 96);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "  Çıkış Yap";
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnMusteri
            // 
            this.btnMusteri.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMusteri.FlatAppearance.BorderSize = 0;
            this.btnMusteri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMusteri.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMusteri.ForeColor = System.Drawing.Color.White;
            this.btnMusteri.Image = ((System.Drawing.Image)(resources.GetObject("btnMusteri.Image")));
            this.btnMusteri.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMusteri.Location = new System.Drawing.Point(0, 294);
            this.btnMusteri.Name = "btnMusteri";
            this.btnMusteri.Size = new System.Drawing.Size(287, 100);
            this.btnMusteri.TabIndex = 3;
            this.btnMusteri.Text = "  Müşteri İşlemleri";
            this.btnMusteri.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMusteri.UseVisualStyleBackColor = true;
            this.btnMusteri.Click += new System.EventHandler(this.btnMusteri_Click);
            // 
            // btnUrunStok
            // 
            this.btnUrunStok.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnUrunStok.FlatAppearance.BorderSize = 0;
            this.btnUrunStok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUrunStok.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUrunStok.ForeColor = System.Drawing.Color.White;
            this.btnUrunStok.Image = ((System.Drawing.Image)(resources.GetObject("btnUrunStok.Image")));
            this.btnUrunStok.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUrunStok.Location = new System.Drawing.Point(0, 200);
            this.btnUrunStok.Name = "btnUrunStok";
            this.btnUrunStok.Size = new System.Drawing.Size(287, 94);
            this.btnUrunStok.TabIndex = 2;
            this.btnUrunStok.Text = "  Ürün İşlemleri";
            this.btnUrunStok.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUrunStok.UseVisualStyleBackColor = true;
            this.btnUrunStok.Click += new System.EventHandler(this.btnUrunStok_Click_1);
            // 
            // btnMarketSatis
            // 
            this.btnMarketSatis.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMarketSatis.FlatAppearance.BorderSize = 0;
            this.btnMarketSatis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMarketSatis.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMarketSatis.ForeColor = System.Drawing.Color.White;
            this.btnMarketSatis.Image = ((System.Drawing.Image)(resources.GetObject("btnMarketSatis.Image")));
            this.btnMarketSatis.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMarketSatis.Location = new System.Drawing.Point(0, 100);
            this.btnMarketSatis.Name = "btnMarketSatis";
            this.btnMarketSatis.Size = new System.Drawing.Size(287, 100);
            this.btnMarketSatis.TabIndex = 1;
            this.btnMarketSatis.Text = "  Market Satışları";
            this.btnMarketSatis.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMarketSatis.UseVisualStyleBackColor = true;
            this.btnMarketSatis.Click += new System.EventHandler(this.btnMarketSatis_Click_1);
            // 
            // panelTopLeft
            // 
            this.panelTopLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.panelTopLeft.Controls.Add(this.pictureBox4);
            this.panelTopLeft.Controls.Add(this.pictureBox3);
            this.panelTopLeft.Controls.Add(this.btnHome);
            this.panelTopLeft.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopLeft.Location = new System.Drawing.Point(0, 0);
            this.panelTopLeft.Margin = new System.Windows.Forms.Padding(4);
            this.panelTopLeft.Name = "panelTopLeft";
            this.panelTopLeft.Size = new System.Drawing.Size(287, 100);
            this.panelTopLeft.TabIndex = 0;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(194, 25);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(50, 50);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(28, 25);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(50, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnHome.Location = new System.Drawing.Point(84, 3);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(104, 97);
            this.btnHome.TabIndex = 1;
            this.btnHome.Text = "Ana Sayfa";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panelTopMid
            // 
            this.panelTopMid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(122)))));
            this.panelTopMid.Controls.Add(this.pictureBox6);
            this.panelTopMid.Controls.Add(this.pictureBox7);
            this.panelTopMid.Controls.Add(this.labelBaslik);
            this.panelTopMid.Controls.Add(this.labelTarih);
            this.panelTopMid.Controls.Add(this.labelSaat);
            this.panelTopMid.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopMid.Location = new System.Drawing.Point(287, 0);
            this.panelTopMid.Name = "panelTopMid";
            this.panelTopMid.Size = new System.Drawing.Size(1090, 100);
            this.panelTopMid.TabIndex = 1;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(949, 12);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(45, 45);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 12;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(55, 13);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(45, 45);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 13;
            this.pictureBox7.TabStop = false;
            // 
            // labelBaslik
            // 
            this.labelBaslik.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelBaslik.AutoSize = true;
            this.labelBaslik.Font = new System.Drawing.Font("Sans Serif Collection", 20.25F, System.Drawing.FontStyle.Bold);
            this.labelBaslik.ForeColor = System.Drawing.Color.White;
            this.labelBaslik.Location = new System.Drawing.Point(373, 25);
            this.labelBaslik.Name = "labelBaslik";
            this.labelBaslik.Size = new System.Drawing.Size(292, 67);
            this.labelBaslik.TabIndex = 0;
            this.labelBaslik.Text = "ANA SAYFA";
            // 
            // labelTarih
            // 
            this.labelTarih.AutoSize = true;
            this.labelTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTarih.ForeColor = System.Drawing.Color.White;
            this.labelTarih.Location = new System.Drawing.Point(869, 65);
            this.labelTarih.Name = "labelTarih";
            this.labelTarih.Size = new System.Drawing.Size(53, 24);
            this.labelTarih.TabIndex = 8;
            this.labelTarih.Text = "Tarih";
            // 
            // labelSaat
            // 
            this.labelSaat.AutoSize = true;
            this.labelSaat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSaat.ForeColor = System.Drawing.Color.White;
            this.labelSaat.Location = new System.Drawing.Point(39, 60);
            this.labelSaat.Name = "labelSaat";
            this.labelSaat.Size = new System.Drawing.Size(46, 24);
            this.labelSaat.TabIndex = 9;
            this.labelSaat.Text = "Saat";
            // 
            // panelBeyaz
            // 
            this.panelBeyaz.Controls.Add(this.pictureBox5);
            this.panelBeyaz.Controls.Add(this.pictureBox2);
            this.panelBeyaz.Controls.Add(this.pictureBox1);
            this.panelBeyaz.Controls.Add(this.label1);
            this.panelBeyaz.Controls.Add(this.labelHosgeldiniz);
            this.panelBeyaz.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBeyaz.Location = new System.Drawing.Point(287, 100);
            this.panelBeyaz.Name = "panelBeyaz";
            this.panelBeyaz.Size = new System.Drawing.Size(1090, 811);
            this.panelBeyaz.TabIndex = 3;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(435, 85);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(230, 230);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 7;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(792, 410);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(286, 410);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(122)))));
            this.label1.Location = new System.Drawing.Point(394, 322);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 42);
            this.label1.TabIndex = 4;
            this.label1.Text = "ÇİÇEK MARKET";
            // 
            // labelHosgeldiniz
            // 
            this.labelHosgeldiniz.AutoSize = true;
            this.labelHosgeldiniz.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHosgeldiniz.Location = new System.Drawing.Point(342, 421);
            this.labelHosgeldiniz.Name = "labelHosgeldiniz";
            this.labelHosgeldiniz.Size = new System.Drawing.Size(444, 31);
            this.labelHosgeldiniz.TabIndex = 0;
            this.labelHosgeldiniz.Text = "Market sistemine hoşgeldiniz... :)";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1377, 911);
            this.Controls.Add(this.panelBeyaz);
            this.Controls.Add(this.panelTopMid);
            this.Controls.Add(this.panelLeft);
            this.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ÇİÇEK MARKET";
            this.Load += new System.EventHandler(this.YoneticiForm_Load);
            this.panelLeft.ResumeLayout(false);
            this.panelTopLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panelTopMid.ResumeLayout(false);
            this.panelTopMid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.panelBeyaz.ResumeLayout(false);
            this.panelBeyaz.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelLeft;
        private Panel panelTopLeft;
        private Button btnMarketSatis;
        private Button btnExit;
        private Button btnMusteri;
        private Button btnUrunStok;
        private Panel panelTopMid;
        private Label labelBaslik;
        private Button btnHome;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private Panel panelBeyaz;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label label1;
        private Label labelHosgeldiniz;
        private Button btnTedarikci;
        private Button btnBorc;
        private Button btnRapor;
        private PictureBox pictureBox5;
        private Label labelSaat;
        private Label labelTarih;
        private System.Windows.Forms.Timer timer1;
        private PictureBox pictureBox7;
        private PictureBox pictureBox6;
    }
}