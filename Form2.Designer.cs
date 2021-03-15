
namespace Lab3_repaso
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textDPI = new System.Windows.Forms.TextBox();
            this.textName = new System.Windows.Forms.TextBox();
            this.textLast = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textNumber = new System.Windows.Forms.TextBox();
            this.textMantainance = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.buttonPerson = new System.Windows.Forms.Button();
            this.buttonProperty = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Agregar personas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(452, 22);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Agregar propiedad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 84);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "DPI";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 140);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "primer nombre ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 217);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "segundo nombre";
            // 
            // textDPI
            // 
            this.textDPI.Location = new System.Drawing.Point(81, 81);
            this.textDPI.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textDPI.Name = "textDPI";
            this.textDPI.Size = new System.Drawing.Size(184, 20);
            this.textDPI.TabIndex = 5;
            this.textDPI.TextChanged += new System.EventHandler(this.textDPI_TextChanged);
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(98, 140);
            this.textName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(184, 20);
            this.textName.TabIndex = 6;
            this.textName.TextChanged += new System.EventHandler(this.textName_TextChanged);
            // 
            // textLast
            // 
            this.textLast.Location = new System.Drawing.Point(114, 210);
            this.textLast.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textLast.Name = "textLast";
            this.textLast.Size = new System.Drawing.Size(184, 20);
            this.textLast.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(425, 84);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = " DPI";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(393, 147);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "numero de casa";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(393, 217);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Mantenimiento";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // textNumber
            // 
            this.textNumber.Location = new System.Drawing.Point(480, 144);
            this.textNumber.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textNumber.Name = "textNumber";
            this.textNumber.Size = new System.Drawing.Size(186, 20);
            this.textNumber.TabIndex = 11;
            // 
            // textMantainance
            // 
            this.textMantainance.Location = new System.Drawing.Point(480, 210);
            this.textMantainance.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textMantainance.Name = "textMantainance";
            this.textMantainance.Size = new System.Drawing.Size(186, 20);
            this.textMantainance.TabIndex = 12;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(467, 84);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(198, 21);
            this.comboBox1.TabIndex = 13;
            // 
            // buttonPerson
            // 
            this.buttonPerson.Font = new System.Drawing.Font("Lucida Fax", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPerson.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonPerson.Location = new System.Drawing.Point(98, 361);
            this.buttonPerson.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonPerson.Name = "buttonPerson";
            this.buttonPerson.Size = new System.Drawing.Size(92, 53);
            this.buttonPerson.TabIndex = 14;
            this.buttonPerson.Text = "Add person";
            this.buttonPerson.UseVisualStyleBackColor = true;
            this.buttonPerson.Click += new System.EventHandler(this.buttonPerson_Click);
            // 
            // buttonProperty
            // 
            this.buttonProperty.Font = new System.Drawing.Font("Lucida Fax", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonProperty.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonProperty.Location = new System.Drawing.Point(508, 361);
            this.buttonProperty.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonProperty.Name = "buttonProperty";
            this.buttonProperty.Size = new System.Drawing.Size(92, 53);
            this.buttonProperty.TabIndex = 15;
            this.buttonProperty.Text = "Add property";
            this.buttonProperty.UseVisualStyleBackColor = true;
            this.buttonProperty.Click += new System.EventHandler(this.buttonProperty_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 447);
            this.Controls.Add(this.buttonProperty);
            this.Controls.Add(this.buttonPerson);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textMantainance);
            this.Controls.Add(this.textNumber);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textLast);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.textDPI);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form2";
            this.Text = "Agregar";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textDPI;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textLast;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textNumber;
        private System.Windows.Forms.TextBox textMantainance;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button buttonPerson;
        private System.Windows.Forms.Button buttonProperty;
    }
}