namespace Pizzaria.Visao
{
    partial class FormEstoque
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
            this.btnBebidas = new System.Windows.Forms.Button();
            this.btnIngredientes = new System.Windows.Forms.Button();
            this.btnLimpeza = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBebidas
            // 
            this.btnBebidas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBebidas.Location = new System.Drawing.Point(36, 71);
            this.btnBebidas.Name = "btnBebidas";
            this.btnBebidas.Size = new System.Drawing.Size(147, 40);
            this.btnBebidas.TabIndex = 0;
            this.btnBebidas.Text = "Bebidas";
            this.btnBebidas.UseVisualStyleBackColor = true;
            this.btnBebidas.Click += new System.EventHandler(this.BtnBebidas_Click);
            // 
            // btnIngredientes
            // 
            this.btnIngredientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngredientes.Location = new System.Drawing.Point(212, 71);
            this.btnIngredientes.Name = "btnIngredientes";
            this.btnIngredientes.Size = new System.Drawing.Size(188, 40);
            this.btnIngredientes.TabIndex = 1;
            this.btnIngredientes.Text = "Ingredientes";
            this.btnIngredientes.UseVisualStyleBackColor = true;
            this.btnIngredientes.Click += new System.EventHandler(this.BtnIngredientes_Click);
            // 
            // btnLimpeza
            // 
            this.btnLimpeza.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpeza.Location = new System.Drawing.Point(430, 72);
            this.btnLimpeza.Name = "btnLimpeza";
            this.btnLimpeza.Size = new System.Drawing.Size(182, 39);
            this.btnLimpeza.TabIndex = 2;
            this.btnLimpeza.Text = "Limpeza";
            this.btnLimpeza.UseVisualStyleBackColor = true;
            this.btnLimpeza.Click += new System.EventHandler(this.BtnLimpeza_Click);
            // 
            // FormEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 183);
            this.Controls.Add(this.btnLimpeza);
            this.Controls.Add(this.btnIngredientes);
            this.Controls.Add(this.btnBebidas);
            this.Name = "FormEstoque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estoque";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBebidas;
        private System.Windows.Forms.Button btnIngredientes;
        private System.Windows.Forms.Button btnLimpeza;
    }
}