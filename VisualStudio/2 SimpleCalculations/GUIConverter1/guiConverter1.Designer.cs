namespace GUIConverter1
{
    partial class guiconverter1
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
            this.Convert = new System.Windows.Forms.Label();
            this.numericUpDownAmount = new System.Windows.Forms.NumericUpDown();
            this.bgntoeur = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // Convert
            // 
            this.Convert.AutoSize = true;
            this.Convert.Location = new System.Drawing.Point(24, 34);
            this.Convert.Name = "Convert";
            this.Convert.Size = new System.Drawing.Size(44, 13);
            this.Convert.TabIndex = 0;
            this.Convert.Text = "Convert";
            this.Convert.Click += new System.EventHandler(this.label1_Click);
            // 
            // numericUpDownAmount
            // 
            this.numericUpDownAmount.DecimalPlaces = 2;
            this.numericUpDownAmount.Location = new System.Drawing.Point(87, 32);
            this.numericUpDownAmount.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numericUpDownAmount.Name = "numericUpDownAmount";
            this.numericUpDownAmount.Size = new System.Drawing.Size(82, 20);
            this.numericUpDownAmount.TabIndex = 1;
            this.numericUpDownAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownAmount.ValueChanged += new System.EventHandler(this.numericUpDownAmount_ValueChanged_1);
            // 
            // bgntoeur
            // 
            this.bgntoeur.AutoSize = true;
            this.bgntoeur.Location = new System.Drawing.Point(187, 34);
            this.bgntoeur.Name = "bgntoeur";
            this.bgntoeur.Size = new System.Drawing.Size(68, 13);
            this.bgntoeur.TabIndex = 2;
            this.bgntoeur.Text = "BGN to EUR";
            this.bgntoeur.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelResult
            // 
            this.labelResult.BackColor = System.Drawing.Color.PaleGreen;
            this.labelResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelResult.Location = new System.Drawing.Point(47, 73);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(249, 28);
            this.labelResult.TabIndex = 3;
            this.labelResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelResult.Click += new System.EventHandler(this.label3_Click);
            // 
            // guiconverter1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 122);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.bgntoeur);
            this.Controls.Add(this.numericUpDownAmount);
            this.Controls.Add(this.Convert);
            this.Name = "guiconverter1";
            this.Text = "GUI Converter";
            this.Load += new System.EventHandler(this.Converter1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Convert;
        private System.Windows.Forms.NumericUpDown numericUpDownAmount;
        private System.Windows.Forms.Label bgntoeur;
        private System.Windows.Forms.Label labelResult;
    }
}

