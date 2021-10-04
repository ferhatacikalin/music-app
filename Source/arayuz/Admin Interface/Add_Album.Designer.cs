
namespace arayuz
{
    partial class AlbumEkleme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlbumEkleme));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textSAnatciad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textalbumtur = new System.Windows.Forms.TextBox();
            this.textalbumtarih = new System.Windows.Forms.TextBox();
            this.textAlbumad = new System.Windows.Forms.TextBox();
            this.textAlbumid = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.EkleToolBar = new System.Windows.Forms.ToolStripMenuItem();
            this.sanatciEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.albumEkleToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.Lime;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(67, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(248, 72);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Adobe Kaiti Std R", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(19, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Add Album";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.Lime;
            this.panel3.Controls.Add(this.button5);
            this.panel3.Controls.Add(this.button4);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Location = new System.Drawing.Point(712, 150);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(289, 570);
            this.panel3.TabIndex = 4;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.Window;
            this.button5.Font = new System.Drawing.Font("Yu Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button5.Location = new System.Drawing.Point(61, 325);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(159, 73);
            this.button5.TabIndex = 4;
            this.button5.Text = "Reset";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.Window;
            this.button4.Font = new System.Drawing.Font("Yu Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.Location = new System.Drawing.Point(61, 424);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(159, 73);
            this.button4.TabIndex = 3;
            this.button4.Text = "Exit";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Window;
            this.button3.Font = new System.Drawing.Font("Yu Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(61, 222);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(159, 73);
            this.button3.TabIndex = 2;
            this.button3.Text = "Update";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Window;
            this.button2.Font = new System.Drawing.Font("Yu Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(61, 122);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(159, 73);
            this.button2.TabIndex = 1;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Window;
            this.button1.Font = new System.Drawing.Font("Yu Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(61, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 73);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.BackColor = System.Drawing.Color.Lime;
            this.panel2.Controls.Add(this.textSAnatciad);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.textalbumtur);
            this.panel2.Controls.Add(this.textalbumtarih);
            this.panel2.Controls.Add(this.textAlbumad);
            this.panel2.Controls.Add(this.textAlbumid);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Location = new System.Drawing.Point(67, 150);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(536, 570);
            this.panel2.TabIndex = 3;
            // 
            // textSAnatciad
            // 
            this.textSAnatciad.Location = new System.Drawing.Point(191, 147);
            this.textSAnatciad.Multiline = true;
            this.textSAnatciad.Name = "textSAnatciad";
            this.textSAnatciad.Size = new System.Drawing.Size(337, 34);
            this.textSAnatciad.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Lime;
            this.label5.Font = new System.Drawing.Font("Sitka Text", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(19, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 35);
            this.label5.TabIndex = 27;
            this.label5.Text = "Artist Name";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(22, 340);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(506, 193);
            this.dataGridView1.TabIndex = 26;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // textalbumtur
            // 
            this.textalbumtur.Location = new System.Drawing.Point(191, 277);
            this.textalbumtur.Multiline = true;
            this.textalbumtur.Name = "textalbumtur";
            this.textalbumtur.Size = new System.Drawing.Size(337, 34);
            this.textalbumtur.TabIndex = 25;
            // 
            // textalbumtarih
            // 
            this.textalbumtarih.Location = new System.Drawing.Point(191, 210);
            this.textalbumtarih.Multiline = true;
            this.textalbumtarih.Name = "textalbumtarih";
            this.textalbumtarih.Size = new System.Drawing.Size(337, 34);
            this.textalbumtarih.TabIndex = 24;
            // 
            // textAlbumad
            // 
            this.textAlbumad.Location = new System.Drawing.Point(191, 80);
            this.textAlbumad.Multiline = true;
            this.textAlbumad.Name = "textAlbumad";
            this.textAlbumad.Size = new System.Drawing.Size(337, 34);
            this.textAlbumad.TabIndex = 23;
            // 
            // textAlbumid
            // 
            this.textAlbumid.Location = new System.Drawing.Point(191, 22);
            this.textAlbumid.Multiline = true;
            this.textAlbumid.Name = "textAlbumid";
            this.textAlbumid.Size = new System.Drawing.Size(337, 34);
            this.textAlbumid.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Lime;
            this.label4.Font = new System.Drawing.Font("Sitka Text", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(16, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 35);
            this.label4.TabIndex = 21;
            this.label4.Text = "Album Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Lime;
            this.label3.Font = new System.Drawing.Font("Sitka Text", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(19, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 35);
            this.label3.TabIndex = 20;
            this.label3.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Lime;
            this.label2.Font = new System.Drawing.Font("Sitka Text", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(19, 277);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 35);
            this.label2.TabIndex = 19;
            this.label2.Text = "Genre";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Lime;
            this.label9.Font = new System.Drawing.Font("Sitka Text", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(19, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 35);
            this.label9.TabIndex = 18;
            this.label9.Text = "Album ID";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Lime;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EkleToolBar});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1049, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // EkleToolBar
            // 
            this.EkleToolBar.BackColor = System.Drawing.Color.White;
            this.EkleToolBar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sanatciEkleToolStripMenuItem,
            this.albumEkleToolStripMenuItem1});
            this.EkleToolBar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.EkleToolBar.Name = "EkleToolBar";
            this.EkleToolBar.Size = new System.Drawing.Size(43, 20);
            this.EkleToolBar.Text = "ADD";
            // 
            // sanatciEkleToolStripMenuItem
            // 
            this.sanatciEkleToolStripMenuItem.BackColor = System.Drawing.Color.Red;
            this.sanatciEkleToolStripMenuItem.Name = "sanatciEkleToolStripMenuItem";
            this.sanatciEkleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sanatciEkleToolStripMenuItem.Text = "Artist ";
            this.sanatciEkleToolStripMenuItem.Click += new System.EventHandler(this.sanatciEkleToolStripMenuItem_Click);
            // 
            // albumEkleToolStripMenuItem1
            // 
            this.albumEkleToolStripMenuItem1.BackColor = System.Drawing.Color.DarkOrchid;
            this.albumEkleToolStripMenuItem1.Name = "albumEkleToolStripMenuItem1";
            this.albumEkleToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.albumEkleToolStripMenuItem1.Text = "Song ";
            this.albumEkleToolStripMenuItem1.Click += new System.EventHandler(this.albumEkleToolStripMenuItem1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(874, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(127, 105);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 25;
            this.bunifuElipse1.TargetControl = this;
            // 
            // AlbumEkleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1049, 732);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AlbumEkleme";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AlbumEkleme";
            this.Load += new System.EventHandler(this.AlbumEkleme_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem EkleToolBar;
        private System.Windows.Forms.ToolStripMenuItem sanatciEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem albumEkleToolStripMenuItem1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textalbumtur;
        private System.Windows.Forms.TextBox textalbumtarih;
        private System.Windows.Forms.TextBox textAlbumad;
        private System.Windows.Forms.TextBox textAlbumid;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textSAnatciad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}