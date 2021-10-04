
namespace arayuz.Top10
{
    partial class PopTen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PopTen));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonexit = new System.Windows.Forms.Button();
            this.buttontopten = new System.Windows.Forms.Button();
            this.buttonklasik = new System.Windows.Forms.Button();
            this.buttonJazz = new System.Windows.Forms.Button();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(769, 600);
            this.dataGridView1.TabIndex = 0;
            // 
            // buttonexit
            // 
            this.buttonexit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonexit.BackColor = System.Drawing.Color.Red;
            this.buttonexit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonexit.BackgroundImage")));
            this.buttonexit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonexit.Font = new System.Drawing.Font("Orbitron", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonexit.Location = new System.Drawing.Point(1012, 511);
            this.buttonexit.Name = "buttonexit";
            this.buttonexit.Size = new System.Drawing.Size(78, 77);
            this.buttonexit.TabIndex = 2;
            this.buttonexit.UseVisualStyleBackColor = false;
            this.buttonexit.Click += new System.EventHandler(this.buttonexit_Click);
            // 
            // buttontopten
            // 
            this.buttontopten.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.buttontopten.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttontopten.Location = new System.Drawing.Point(852, 310);
            this.buttontopten.Name = "buttontopten";
            this.buttontopten.Size = new System.Drawing.Size(174, 74);
            this.buttontopten.TabIndex = 13;
            this.buttontopten.Text = "Top 10 ";
            this.buttontopten.UseVisualStyleBackColor = false;
            this.buttontopten.Click += new System.EventHandler(this.buttontopten_Click);
            // 
            // buttonklasik
            // 
            this.buttonklasik.BackColor = System.Drawing.Color.YellowGreen;
            this.buttonklasik.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonklasik.Location = new System.Drawing.Point(851, 230);
            this.buttonklasik.Name = "buttonklasik";
            this.buttonklasik.Size = new System.Drawing.Size(174, 74);
            this.buttonklasik.TabIndex = 12;
            this.buttonklasik.Text = "Classic Top 10";
            this.buttonklasik.UseVisualStyleBackColor = false;
            this.buttonklasik.Click += new System.EventHandler(this.buttonklasik_Click);
            // 
            // buttonJazz
            // 
            this.buttonJazz.BackColor = System.Drawing.Color.BlueViolet;
            this.buttonJazz.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonJazz.Location = new System.Drawing.Point(852, 150);
            this.buttonJazz.Name = "buttonJazz";
            this.buttonJazz.Size = new System.Drawing.Size(174, 74);
            this.buttonJazz.TabIndex = 11;
            this.buttonJazz.Text = "Jazz Top 10";
            this.buttonJazz.UseVisualStyleBackColor = false;
            this.buttonJazz.Click += new System.EventHandler(this.buttonJazz_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 25;
            this.bunifuElipse1.TargetControl = this;
            // 
            // PopTen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(1102, 600);
            this.Controls.Add(this.buttontopten);
            this.Controls.Add(this.buttonklasik);
            this.Controls.Add(this.buttonJazz);
            this.Controls.Add(this.buttonexit);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PopTen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "toppop";
            this.Load += new System.EventHandler(this.toppop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonexit;
        private System.Windows.Forms.Button buttontopten;
        private System.Windows.Forms.Button buttonklasik;
        private System.Windows.Forms.Button buttonJazz;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}