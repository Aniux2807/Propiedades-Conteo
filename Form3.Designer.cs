
namespace Lab3_repaso
{
    partial class Form3
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonOrder = new System.Windows.Forms.Button();
            this.buttonMost = new System.Windows.Forms.Button();
            this.buttonHigger = new System.Windows.Forms.Button();
            this.buttonLower = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 18);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(498, 361);
            this.dataGridView1.TabIndex = 0;
            // 
            // buttonOrder
            // 
            this.buttonOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOrder.Location = new System.Drawing.Point(520, 41);
            this.buttonOrder.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonOrder.Name = "buttonOrder";
            this.buttonOrder.Size = new System.Drawing.Size(86, 59);
            this.buttonOrder.TabIndex = 1;
            this.buttonOrder.Text = "Ordenar datos";
            this.buttonOrder.UseVisualStyleBackColor = true;
            this.buttonOrder.Click += new System.EventHandler(this.buttonOrder_Click);
            // 
            // buttonMost
            // 
            this.buttonMost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMost.Location = new System.Drawing.Point(610, 41);
            this.buttonMost.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonMost.Name = "buttonMost";
            this.buttonMost.Size = new System.Drawing.Size(76, 82);
            this.buttonMost.TabIndex = 2;
            this.buttonMost.Text = "Mostrar mas propiedades";
            this.buttonMost.UseVisualStyleBackColor = true;
            this.buttonMost.Click += new System.EventHandler(this.buttonMost_Click);
            // 
            // buttonHigger
            // 
            this.buttonHigger.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHigger.Location = new System.Drawing.Point(520, 127);
            this.buttonHigger.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonHigger.Name = "buttonHigger";
            this.buttonHigger.Size = new System.Drawing.Size(86, 79);
            this.buttonHigger.TabIndex = 3;
            this.buttonHigger.Text = "propiedad mayor costo";
            this.buttonHigger.UseVisualStyleBackColor = true;
            this.buttonHigger.Click += new System.EventHandler(this.buttonHigger_Click);
            // 
            // buttonLower
            // 
            this.buttonLower.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLower.Location = new System.Drawing.Point(610, 127);
            this.buttonLower.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonLower.Name = "buttonLower";
            this.buttonLower.Size = new System.Drawing.Size(76, 79);
            this.buttonLower.TabIndex = 4;
            this.buttonLower.Text = "propiedad meno costo";
            this.buttonLower.UseVisualStyleBackColor = true;
            this.buttonLower.Click += new System.EventHandler(this.buttonLower_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(520, 210);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 58);
            this.button1.TabIndex = 5;
            this.button1.Text = "pago del usuario con el condominio";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 386);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonLower);
            this.Controls.Add(this.buttonHigger);
            this.Controls.Add(this.buttonMost);
            this.Controls.Add(this.buttonOrder);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form3";
            this.Text = "Datos";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonOrder;
        private System.Windows.Forms.Button buttonMost;
        private System.Windows.Forms.Button buttonHigger;
        private System.Windows.Forms.Button buttonLower;
        private System.Windows.Forms.Button button1;
    }
}