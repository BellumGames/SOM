
namespace SOM
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.nV = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.nAlpha = new System.Windows.Forms.NumericUpDown();
            this.btnContinue = new System.Windows.Forms.Button();
            this.btnDrawInit = new System.Windows.Forms.Button();
            this.pGraphic = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nAlpha)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.nV);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.nAlpha);
            this.panel1.Controls.Add(this.btnContinue);
            this.panel1.Controls.Add(this.btnDrawInit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(74, 450);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.Location = new System.Drawing.Point(0, 372);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "V(t)";
            // 
            // nV
            // 
            this.nV.DecimalPlaces = 5;
            this.nV.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.nV.Increment = new decimal(new int[] {
            1,
            0,
            0,
            262144});
            this.nV.Location = new System.Drawing.Point(0, 387);
            this.nV.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nV.Name = "nV";
            this.nV.Size = new System.Drawing.Size(72, 23);
            this.nV.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Location = new System.Drawing.Point(0, 410);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alpha(t)";
            // 
            // nAlpha
            // 
            this.nAlpha.DecimalPlaces = 5;
            this.nAlpha.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.nAlpha.Increment = new decimal(new int[] {
            1,
            0,
            0,
            262144});
            this.nAlpha.Location = new System.Drawing.Point(0, 425);
            this.nAlpha.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nAlpha.Name = "nAlpha";
            this.nAlpha.Size = new System.Drawing.Size(72, 23);
            this.nAlpha.TabIndex = 0;
            // 
            // btnContinue
            // 
            this.btnContinue.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnContinue.Location = new System.Drawing.Point(0, 30);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(72, 30);
            this.btnContinue.TabIndex = 1;
            this.btnContinue.Text = "Continue";
            this.btnContinue.UseVisualStyleBackColor = true;
            this.btnContinue.Click += new System.EventHandler(this.BtnContinue_Click);
            // 
            // btnDrawInit
            // 
            this.btnDrawInit.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDrawInit.Location = new System.Drawing.Point(0, 0);
            this.btnDrawInit.Name = "btnDrawInit";
            this.btnDrawInit.Size = new System.Drawing.Size(72, 30);
            this.btnDrawInit.TabIndex = 0;
            this.btnDrawInit.Text = "Init";
            this.btnDrawInit.UseVisualStyleBackColor = true;
            this.btnDrawInit.Click += new System.EventHandler(this.BtnDrawInit);
            // 
            // pGraphic
            // 
            this.pGraphic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pGraphic.Location = new System.Drawing.Point(74, 0);
            this.pGraphic.Name = "pGraphic";
            this.pGraphic.Size = new System.Drawing.Size(726, 450);
            this.pGraphic.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pGraphic);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nAlpha)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pGraphic;
        private System.Windows.Forms.Button btnDrawInit;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.NumericUpDown nAlpha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nV;
        private System.Windows.Forms.Label label1;
    }
}

