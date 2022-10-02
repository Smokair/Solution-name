namespace Oefening5
{
    partial class Form5
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ctof = new System.Windows.Forms.Button();
            this.textC = new System.Windows.Forms.TextBox();
            this.textF = new System.Windows.Forms.TextBox();
            this.ftoc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Celsius";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fahrenheit";
            // 
            // ctof
            // 
            this.ctof.Location = new System.Drawing.Point(94, 100);
            this.ctof.Name = "ctof";
            this.ctof.Size = new System.Drawing.Size(100, 23);
            this.ctof.TabIndex = 2;
            this.ctof.Text = "Convert C to F";
            this.ctof.UseVisualStyleBackColor = true;
            this.ctof.Click += new System.EventHandler(this.ctof_Click);
            // 
            // textC
            // 
            this.textC.Location = new System.Drawing.Point(94, 71);
            this.textC.Name = "textC";
            this.textC.Size = new System.Drawing.Size(100, 23);
            this.textC.TabIndex = 3;
            // 
            // textF
            // 
            this.textF.Location = new System.Drawing.Point(94, 164);
            this.textF.Name = "textF";
            this.textF.Size = new System.Drawing.Size(100, 23);
            this.textF.TabIndex = 4;
            // 
            // ftoc
            // 
            this.ftoc.Location = new System.Drawing.Point(94, 135);
            this.ftoc.Name = "ftoc";
            this.ftoc.Size = new System.Drawing.Size(100, 23);
            this.ftoc.TabIndex = 5;
            this.ftoc.Text = "Convert F to C";
            this.ftoc.UseVisualStyleBackColor = true;
            this.ftoc.Click += new System.EventHandler(this.ftoc_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ftoc);
            this.Controls.Add(this.textF);
            this.Controls.Add(this.textC);
            this.Controls.Add(this.ctof);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form5";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Button ctof;
        private TextBox textC;
        private TextBox textF;
        private Button ftoc;
    }
}