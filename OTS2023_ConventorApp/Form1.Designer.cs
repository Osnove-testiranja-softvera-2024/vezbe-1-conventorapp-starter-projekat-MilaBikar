namespace OTS2023_ConventorApp
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
            this.btnMass = new System.Windows.Forms.RadioButton();
            this.btnlength = new System.Windows.Forms.RadioButton();
            this.lblType = new System.Windows.Forms.Label();
            this.btnConvert = new System.Windows.Forms.Button();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnMass
            // 
            this.btnMass.AutoSize = true;
            this.btnMass.Location = new System.Drawing.Point(22, 63);
            this.btnMass.Name = "btnMass";
            this.btnMass.Size = new System.Drawing.Size(50, 17);
            this.btnMass.TabIndex = 0;
            this.btnMass.TabStop = true;
            this.btnMass.Text = "Mass";
            this.btnMass.UseVisualStyleBackColor = true;
            this.btnMass.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // btnlength
            // 
            this.btnlength.AutoSize = true;
            this.btnlength.Location = new System.Drawing.Point(22, 95);
            this.btnlength.Name = "btnlength";
            this.btnlength.Size = new System.Drawing.Size(58, 17);
            this.btnlength.TabIndex = 1;
            this.btnlength.TabStop = true;
            this.btnlength.Text = "Length";
            this.btnlength.UseVisualStyleBackColor = true;
            this.btnlength.CheckedChanged += new System.EventHandler(this.btnlength_CheckedChanged);
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(19, 35);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(80, 13);
            this.lblType.TabIndex = 2;
            this.lblType.Text = "Converter Type";
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(205, 362);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(75, 23);
            this.btnConvert.TabIndex = 3;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(167, 294);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(161, 20);
            this.txt2.TabIndex = 4;
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(167, 249);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(161, 20);
            this.txt1.TabIndex = 5;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(64, 256);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(35, 13);
            this.lbl1.TabIndex = 6;
            this.lbl1.Text = "label1";
            this.lbl1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(64, 301);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(35, 13);
            this.lbl2.TabIndex = 7;
            this.lbl2.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 582);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.btnlength);
            this.Controls.Add(this.btnMass);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton btnMass;
        private System.Windows.Forms.RadioButton btnlength;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
    }
}

