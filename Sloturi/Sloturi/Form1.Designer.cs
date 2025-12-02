namespace Sloturi
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
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.pb2 = new System.Windows.Forms.PictureBox();
            this.pb3 = new System.Windows.Forms.PictureBox();
            this.numCycles = new System.Windows.Forms.NumericUpDown();
            this.btnTrage = new System.Windows.Forms.Button();
            this.lblRezultat = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCycles)).BeginInit();
            this.SuspendLayout();
            // 
            // pb1
            // 
            this.pb1.Location = new System.Drawing.Point(119, 88);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(161, 177);
            this.pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb1.TabIndex = 0;
            this.pb1.TabStop = false;
            this.pb1.Click += new System.EventHandler(this.pb1_Click);
            // 
            // pb2
            // 
            this.pb2.Location = new System.Drawing.Point(323, 88);
            this.pb2.Name = "pb2";
            this.pb2.Size = new System.Drawing.Size(161, 177);
            this.pb2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb2.TabIndex = 1;
            this.pb2.TabStop = false;
            // 
            // pb3
            // 
            this.pb3.Location = new System.Drawing.Point(531, 88);
            this.pb3.Name = "pb3";
            this.pb3.Size = new System.Drawing.Size(161, 177);
            this.pb3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb3.TabIndex = 2;
            this.pb3.TabStop = false;
            // 
            // numCycles
            // 
            this.numCycles.Location = new System.Drawing.Point(119, 310);
            this.numCycles.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numCycles.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCycles.Name = "numCycles";
            this.numCycles.Size = new System.Drawing.Size(161, 22);
            this.numCycles.TabIndex = 3;
            this.numCycles.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // btnTrage
            // 
            this.btnTrage.Location = new System.Drawing.Point(531, 308);
            this.btnTrage.Name = "btnTrage";
            this.btnTrage.Size = new System.Drawing.Size(161, 31);
            this.btnTrage.TabIndex = 4;
            this.btnTrage.Text = "Trage";
            this.btnTrage.UseVisualStyleBackColor = true;
            this.btnTrage.Click += new System.EventHandler(this.btnTrage_Click);
            // 
            // lblRezultat
            // 
            this.lblRezultat.AutoSize = true;
            this.lblRezultat.Location = new System.Drawing.Point(377, 378);
            this.lblRezultat.Name = "lblRezultat";
            this.lblRezultat.Size = new System.Drawing.Size(17, 16);
            this.lblRezultat.TabIndex = 5;
            this.lblRezultat.Text = "\"\"";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblRezultat);
            this.Controls.Add(this.btnTrage);
            this.Controls.Add(this.numCycles);
            this.Controls.Add(this.pb3);
            this.Controls.Add(this.pb2);
            this.Controls.Add(this.pb1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCycles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.PictureBox pb2;
        private System.Windows.Forms.PictureBox pb3;
        private System.Windows.Forms.NumericUpDown numCycles;
        private System.Windows.Forms.Button btnTrage;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblRezultat;
    }
}

