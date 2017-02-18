namespace aplusb
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
            this.button1 = new System.Windows.Forms.Button();
            this.n1 = new System.Windows.Forms.TextBox();
            this.n2 = new System.Windows.Forms.TextBox();
            this.plus = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.TextBox();
            this.equals = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(62, 171);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 39);
            this.button1.TabIndex = 0;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // n1
            // 
            this.n1.Location = new System.Drawing.Point(11, 25);
            this.n1.Name = "n1";
            this.n1.Size = new System.Drawing.Size(98, 21);
            this.n1.TabIndex = 1;
            // 
            // n2
            // 
            this.n2.Location = new System.Drawing.Point(176, 25);
            this.n2.Name = "n2";
            this.n2.Size = new System.Drawing.Size(96, 21);
            this.n2.TabIndex = 2;
            // 
            // plus
            // 
            this.plus.AutoSize = true;
            this.plus.Font = new System.Drawing.Font("Tahoma", 11F);
            this.plus.Location = new System.Drawing.Point(133, 28);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(19, 18);
            this.plus.TabIndex = 3;
            this.plus.Text = "+";
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(52, 110);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(179, 21);
            this.result.TabIndex = 4;
            // 
            // equals
            // 
            this.equals.AutoSize = true;
            this.equals.Location = new System.Drawing.Point(119, 94);
            this.equals.Name = "equals";
            this.equals.Size = new System.Drawing.Size(42, 13);
            this.equals.TabIndex = 5;
            this.equals.Text = "Equals:";
            this.equals.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.equals);
            this.Controls.Add(this.result);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.n2);
            this.Controls.Add(this.n1);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Sumator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox n1;
        private System.Windows.Forms.TextBox n2;
        private System.Windows.Forms.Label plus;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.Label equals;
    }
}

