namespace GUIbutton
{
    partial class catchthebuttonmain
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
            System.Windows.Forms.ErrorProvider congrats;
            this.button = new System.Windows.Forms.Button();
            congrats = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(congrats)).BeginInit();
            this.SuspendLayout();
            // 
            // button
            // 
            this.button.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button.Location = new System.Drawing.Point(66, 57);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(99, 50);
            this.button.TabIndex = 0;
            this.button.Text = "BuTtOn :D";
            this.button.UseVisualStyleBackColor = true;
            this.button.MouseEnter += new System.EventHandler(this.mouse_Enter);
            // 
            // congrats
            // 
            congrats.ContainerControl = this;
            // 
            // catchthebuttonmain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 372);
            this.Controls.Add(this.button);
            this.Name = "catchthebuttonmain";
            this.Text = "Catch the Button!";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mouseclick);
            ((System.ComponentModel.ISupportInitialize)(congrats)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button;
    }
}

