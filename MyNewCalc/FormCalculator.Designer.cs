namespace MyNewCalc
{
    partial class FormCalculator
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
            this.numericUpDownTermen1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownTermen2 = new System.Windows.Forms.NumericUpDown();
            this.butonAdunare = new System.Windows.Forms.Button();
            this.butonScadere = new System.Windows.Forms.Button();
            this.butonInmultire = new System.Windows.Forms.Button();
            this.butonImpartire = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTermen1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTermen2)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDownTermen1
            // 
            this.numericUpDownTermen1.Location = new System.Drawing.Point(78, 39);
            this.numericUpDownTermen1.Name = "numericUpDownTermen1";
            this.numericUpDownTermen1.Size = new System.Drawing.Size(233, 20);
            this.numericUpDownTermen1.TabIndex = 0;
            // 
            // numericUpDownTermen2
            // 
            this.numericUpDownTermen2.Location = new System.Drawing.Point(466, 39);
            this.numericUpDownTermen2.Name = "numericUpDownTermen2";
            this.numericUpDownTermen2.Size = new System.Drawing.Size(233, 20);
            this.numericUpDownTermen2.TabIndex = 1;
            // 
            // butonAdunare
            // 
            this.butonAdunare.Location = new System.Drawing.Point(52, 182);
            this.butonAdunare.Name = "butonAdunare";
            this.butonAdunare.Size = new System.Drawing.Size(134, 52);
            this.butonAdunare.TabIndex = 2;
            this.butonAdunare.Text = "adunare";
            this.butonAdunare.UseVisualStyleBackColor = true;
            // 
            // butonScadere
            // 
            this.butonScadere.Location = new System.Drawing.Point(223, 182);
            this.butonScadere.Name = "butonScadere";
            this.butonScadere.Size = new System.Drawing.Size(134, 52);
            this.butonScadere.TabIndex = 3;
            this.butonScadere.Text = "scadere";
            this.butonScadere.UseVisualStyleBackColor = true;
            // 
            // butonInmultire
            // 
            this.butonInmultire.Location = new System.Drawing.Point(394, 182);
            this.butonInmultire.Name = "butonInmultire";
            this.butonInmultire.Size = new System.Drawing.Size(134, 52);
            this.butonInmultire.TabIndex = 4;
            this.butonInmultire.Text = "inmultire";
            this.butonInmultire.UseVisualStyleBackColor = true;
            // 
            // butonImpartire
            // 
            this.butonImpartire.Location = new System.Drawing.Point(565, 182);
            this.butonImpartire.Name = "butonImpartire";
            this.butonImpartire.Size = new System.Drawing.Size(134, 52);
            this.butonImpartire.TabIndex = 5;
            this.butonImpartire.Text = "impartire";
            this.butonImpartire.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(223, 348);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(305, 20);
            this.textBox1.TabIndex = 6;
            // 
            // FormCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.butonImpartire);
            this.Controls.Add(this.butonInmultire);
            this.Controls.Add(this.butonScadere);
            this.Controls.Add(this.butonAdunare);
            this.Controls.Add(this.numericUpDownTermen2);
            this.Controls.Add(this.numericUpDownTermen1);
            this.Name = "FormCalculator";
            this.Text = "FormCalculator";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTermen1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTermen2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDownTermen1;
        private System.Windows.Forms.NumericUpDown numericUpDownTermen2;
        private System.Windows.Forms.Button butonAdunare;
        private System.Windows.Forms.Button butonScadere;
        private System.Windows.Forms.Button butonInmultire;
        private System.Windows.Forms.Button butonImpartire;
        private System.Windows.Forms.TextBox textBox1;
    }
}