namespace kepekSQL
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImageFileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImageBlob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImageFileSizeBytes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BetöltBTN = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.képnév = new System.Windows.Forms.TextBox();
            this.adatbevitelBTN = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.New = new System.Windows.Forms.ToolStripMenuItem();
            this.Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.Save = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(24, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pic: ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.ImageFileName,
            this.ImageBlob,
            this.ImageFileSizeBytes});
            this.dataGridView1.Location = new System.Drawing.Point(343, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(509, 426);
            this.dataGridView1.TabIndex = 1;
            // 
            // ID
            // 
            this.ID.HeaderText = "Image_id ";
            this.ID.Name = "ID";
            // 
            // ImageFileName
            // 
            this.ImageFileName.HeaderText = "ImageFileName";
            this.ImageFileName.Name = "ImageFileName";
            // 
            // ImageBlob
            // 
            this.ImageBlob.HeaderText = "ImageBlob";
            this.ImageBlob.Name = "ImageBlob";
            // 
            // ImageFileSizeBytes
            // 
            this.ImageFileSizeBytes.HeaderText = "ImageFileSizeBytes";
            this.ImageFileSizeBytes.Name = "ImageFileSizeBytes";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.Location = new System.Drawing.Point(28, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(299, 256);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // BetöltBTN
            // 
            this.BetöltBTN.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BetöltBTN.ForeColor = System.Drawing.Color.Red;
            this.BetöltBTN.Location = new System.Drawing.Point(75, 331);
            this.BetöltBTN.Name = "BetöltBTN";
            this.BetöltBTN.Size = new System.Drawing.Size(165, 45);
            this.BetöltBTN.TabIndex = 3;
            this.BetöltBTN.Text = "Betölt";
            this.BetöltBTN.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // képnév
            // 
            this.képnév.Location = new System.Drawing.Point(877, 185);
            this.képnév.Name = "képnév";
            this.képnév.Size = new System.Drawing.Size(164, 20);
            this.képnév.TabIndex = 4;
            // 
            // adatbevitelBTN
            // 
            this.adatbevitelBTN.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.adatbevitelBTN.ForeColor = System.Drawing.Color.Red;
            this.adatbevitelBTN.Location = new System.Drawing.Point(877, 250);
            this.adatbevitelBTN.Name = "adatbevitelBTN";
            this.adatbevitelBTN.Size = new System.Drawing.Size(165, 45);
            this.adatbevitelBTN.TabIndex = 5;
            this.adatbevitelBTN.Text = "Adatbevitel";
            this.adatbevitelBTN.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            ".Gif",
            ".Jpg",
            ".Jpeg",
            ".BMP ",
            ".IFF ",
            ".TGA ",
            ".RAW ",
            ".JP2 ",
            ".EPS ",
            ".CPT "});
            this.comboBox1.Location = new System.Drawing.Point(877, 87);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(873, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 22);
            this.label2.TabIndex = 7;
            this.label2.Text = "Válaszd ki a képformátumot";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(873, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 22);
            this.label3.TabIndex = 8;
            this.label3.Text = "Add meg a kép nevét";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.New,
            this.Delete,
            this.Save});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(113, 70);
            // 
            // New
            // 
            this.New.Name = "New";
            this.New.Size = new System.Drawing.Size(112, 22);
            this.New.Text = "New";
            // 
            // Delete
            // 
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(112, 22);
            this.Delete.Text = "Delete";
            // 
            // Save
            // 
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(112, 22);
            this.Save.Text = "Save as";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 492);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.adatbevitelBTN);
            this.Controls.Add(this.képnév);
            this.Controls.Add(this.BetöltBTN);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Display Images";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImageFileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImageBlob;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImageFileSizeBytes;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BetöltBTN;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox képnév;
        private System.Windows.Forms.Button adatbevitelBTN;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem New;
        private System.Windows.Forms.ToolStripMenuItem Delete;
        private System.Windows.Forms.ToolStripMenuItem Save;
    }
}

