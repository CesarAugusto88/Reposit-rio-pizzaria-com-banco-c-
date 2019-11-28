namespace Pizzaria.Visao
{
    partial class FormFazerPedido
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
            this.txbCliente = new System.Windows.Forms.TextBox();
            this.txbPizza = new System.Windows.Forms.TextBox();
            this.txbTempo = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblPizza = new System.Windows.Forms.Label();
            this.lblTempo = new System.Windows.Forms.Label();
            this.lblvalorpedido = new System.Windows.Forms.Label();
            this.btnFazerPedido = new System.Windows.Forms.Button();
            this.txbEndereco = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txbCliente
            // 
            this.txbCliente.Location = new System.Drawing.Point(136, 30);
            this.txbCliente.Name = "txbCliente";
            this.txbCliente.Size = new System.Drawing.Size(100, 20);
            this.txbCliente.TabIndex = 0;
            // 
            // txbPizza
            // 
            this.txbPizza.Location = new System.Drawing.Point(136, 70);
            this.txbPizza.Name = "txbPizza";
            this.txbPizza.Size = new System.Drawing.Size(100, 20);
            this.txbPizza.TabIndex = 1;
            // 
            // txbTempo
            // 
            this.txbTempo.Location = new System.Drawing.Point(314, 70);
            this.txbTempo.Name = "txbTempo";
            this.txbTempo.Size = new System.Drawing.Size(126, 20);
            this.txbTempo.TabIndex = 2;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(136, 149);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 3;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(75, 33);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(39, 13);
            this.lblCliente.TabIndex = 4;
            this.lblCliente.Text = "Cliente";
            // 
            // lblPizza
            // 
            this.lblPizza.AutoSize = true;
            this.lblPizza.Location = new System.Drawing.Point(75, 76);
            this.lblPizza.Name = "lblPizza";
            this.lblPizza.Size = new System.Drawing.Size(32, 13);
            this.lblPizza.TabIndex = 5;
            this.lblPizza.Text = "Pizza";
            // 
            // lblTempo
            // 
            this.lblTempo.AutoSize = true;
            this.lblTempo.Location = new System.Drawing.Point(255, 73);
            this.lblTempo.Name = "lblTempo";
            this.lblTempo.Size = new System.Drawing.Size(40, 13);
            this.lblTempo.TabIndex = 6;
            this.lblTempo.Text = "Tempo";
            // 
            // lblvalorpedido
            // 
            this.lblvalorpedido.AutoSize = true;
            this.lblvalorpedido.Location = new System.Drawing.Point(75, 155);
            this.lblvalorpedido.Name = "lblvalorpedido";
            this.lblvalorpedido.Size = new System.Drawing.Size(31, 13);
            this.lblvalorpedido.TabIndex = 7;
            this.lblvalorpedido.Text = "Valor";
            // 
            // btnFazerPedido
            // 
            this.btnFazerPedido.Location = new System.Drawing.Point(289, 201);
            this.btnFazerPedido.Name = "btnFazerPedido";
            this.btnFazerPedido.Size = new System.Drawing.Size(151, 35);
            this.btnFazerPedido.TabIndex = 8;
            this.btnFazerPedido.Text = "Fazer Pedido";
            this.btnFazerPedido.UseVisualStyleBackColor = true;
            // 
            // txbEndereco
            // 
            this.txbEndereco.Location = new System.Drawing.Point(314, 30);
            this.txbEndereco.Name = "txbEndereco";
            this.txbEndereco.Size = new System.Drawing.Size(126, 20);
            this.txbEndereco.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(255, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Endereço";
            // 
            // FormFazerPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 262);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbEndereco);
            this.Controls.Add(this.btnFazerPedido);
            this.Controls.Add(this.lblvalorpedido);
            this.Controls.Add(this.lblTempo);
            this.Controls.Add(this.lblPizza);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.txbTempo);
            this.Controls.Add(this.txbPizza);
            this.Controls.Add(this.txbCliente);
            this.Name = "FormFazerPedido";
            this.Text = "Pedido";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbCliente;
        private System.Windows.Forms.TextBox txbPizza;
        private System.Windows.Forms.TextBox txbTempo;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblPizza;
        private System.Windows.Forms.Label lblTempo;
        private System.Windows.Forms.Label lblvalorpedido;
        private System.Windows.Forms.Button btnFazerPedido;
        private System.Windows.Forms.TextBox txbEndereco;
        private System.Windows.Forms.Label label1;
    }
}