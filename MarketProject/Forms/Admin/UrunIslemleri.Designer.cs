using System.Windows.Forms;

namespace MarketProject.Forms.Admin
{
    partial class UrunIslemleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UrunIslemleri));
            this.btnStokEkle = new System.Windows.Forms.Button();
            this.btnStokGor = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStokEkle
            // 
            this.btnStokEkle.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnStokEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStokEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStokEkle.ForeColor = System.Drawing.Color.White;
            this.btnStokEkle.Image = ((System.Drawing.Image)(resources.GetObject("btnStokEkle.Image")));
            this.btnStokEkle.Location = new System.Drawing.Point(60, 269);
            this.btnStokEkle.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnStokEkle.Name = "btnStokEkle";
            this.btnStokEkle.Size = new System.Drawing.Size(275, 190);
            this.btnStokEkle.TabIndex = 1;
            this.btnStokEkle.Text = "\r\nStok ekleme işlemleri için tıklayınız";
            this.btnStokEkle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnStokEkle.UseVisualStyleBackColor = false;
            this.btnStokEkle.Click += new System.EventHandler(this.btnStokEkle_Click);
            // 
            // btnStokGor
            // 
            this.btnStokGor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(200)))), ((int)(((byte)(188)))));
            this.btnStokGor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStokGor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStokGor.ForeColor = System.Drawing.Color.White;
            this.btnStokGor.Image = ((System.Drawing.Image)(resources.GetObject("btnStokGor.Image")));
            this.btnStokGor.Location = new System.Drawing.Point(406, 269);
            this.btnStokGor.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnStokGor.Name = "btnStokGor";
            this.btnStokGor.Size = new System.Drawing.Size(275, 190);
            this.btnStokGor.TabIndex = 2;
            this.btnStokGor.Text = "\r\nStok görüntüleme işlemlerine gitmek için tıklayınız";
            this.btnStokGor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnStokGor.UseVisualStyleBackColor = false;
            this.btnStokGor.Click += new System.EventHandler(this.btnStokGor_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(204)))), ((int)(((byte)(51)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(752, 269);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(275, 190);
            this.button1.TabIndex = 16;
            this.button1.Text = "\r\nStok sayısı azalan ürünleri görüntülemek için tıklayınız";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UrunIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1067, 520);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnStokGor);
            this.Controls.Add(this.btnStokEkle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "UrunIslemleri";
            this.Text = "Ürün İşlemleri";
            this.ResumeLayout(false);

        }

        #endregion
        private Button btnStokEkle;
        private Button btnStokGor;
        private Button button1;
    }
}