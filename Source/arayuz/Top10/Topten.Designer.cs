
namespace arayuz.Top10
{
    partial class Topten
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Topten));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonexit = new System.Windows.Forms.Button();
            this.buttonpop = new System.Windows.Forms.Button();
            this.buttonjazz = new System.Windows.Forms.Button();
            this.buttonclassic = new System.Windows.Forms.Button();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(769, 600);
            this.dataGridView1.TabIndex = 0;
            // 
            // buttonexit
            // 
            this.buttonexit.BackColor = System.Drawing.Color.Red;
            this.buttonexit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonexit.BackgroundImage")));
            this.buttonexit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonexit.Font = new System.Drawing.Font("Orbitron", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonexit.Location = new System.Drawing.Point(1012, 511);
            this.buttonexit.Name = "buttonexit";
            this.buttonexit.Size = new System.Drawing.Size(78, 77);
            this.buttonexit.TabIndex = 1;
            this.buttonexit.UseVisualStyleBackColor = false;
            this.buttonexit.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonpop
            // 
            this.buttonpop.BackColor = System.Drawing.Color.Orange;
            this.buttonpop.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonpop.Location = new System.Drawing.Point(851, 150);
            this.buttonpop.Name = "buttonpop";
            this.buttonpop.Size = new System.Drawing.Size(174, 74);
            this.buttonpop.TabIndex = 2;
            this.buttonpop.Text = "Pop Top 10";
            this.buttonpop.UseVisualStyleBackColor = false;
            this.buttonpop.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // buttonjazz
            // 
            this.buttonjazz.BackColor = System.Drawing.Color.BlueViolet;
            this.buttonjazz.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonjazz.Location = new System.Drawing.Point(851, 230);
            this.buttonjazz.Name = "buttonjazz";
            this.buttonjazz.Size = new System.Drawing.Size(174, 74);
            this.buttonjazz.TabIndex = 3;
            this.buttonjazz.Text = "Jazz Top 10";
            this.buttonjazz.UseVisualStyleBackColor = false;
            this.buttonjazz.Click += new System.EventHandler(this.buttonjazz_Click);
            // 
            // buttonclassic
            // 
            this.buttonclassic.BackColor = System.Drawing.Color.YellowGreen;
            this.buttonclassic.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonclassic.Location = new System.Drawing.Point(851, 310);
            this.buttonclassic.Name = "buttonclassic";
            this.buttonclassic.Size = new System.Drawing.Size(174, 74);
            this.buttonclassic.TabIndex = 4;
            this.buttonclassic.Text = "Classic Top 10 ";
            this.buttonclassic.UseVisualStyleBackColor = false;
            this.buttonclassic.Click += new System.EventHandler(this.button3_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 25;
            this.bunifuElipse1.TargetControl = this;
            // 
            // Topten
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.ClientSize = new System.Drawing.Size(1102, 600);
            this.Controls.Add(this.buttonclassic);
            this.Controls.Add(this.buttonjazz);
            this.Controls.Add(this.buttonpop);
            this.Controls.Add(this.buttonexit);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Topten";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Top10";
            this.Load += new System.EventHandler(this.Topon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonexit;
        private System.Windows.Forms.Button buttonpop;
        private System.Windows.Forms.Button buttonjazz;
        private System.Windows.Forms.Button buttonclassic;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}