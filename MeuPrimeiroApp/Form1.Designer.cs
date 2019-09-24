namespace MeuPrimeiroApp
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Desligar = new System.Windows.Forms.Button();
            this.Ligar = new System.Windows.Forms.Button();
            this.Detalhes = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Desligar
            // 
            this.Desligar.Location = new System.Drawing.Point(382, 75);
            this.Desligar.Name = "Desligar";
            this.Desligar.Size = new System.Drawing.Size(128, 74);
            this.Desligar.TabIndex = 1;
            this.Desligar.Text = "Desligar";
            this.Desligar.UseVisualStyleBackColor = true;
            this.Desligar.Click += new System.EventHandler(this.Desligar_Click);
            // 
            // Ligar
            // 
            this.Ligar.Location = new System.Drawing.Point(155, 75);
            this.Ligar.Name = "Ligar";
            this.Ligar.Size = new System.Drawing.Size(144, 73);
            this.Ligar.TabIndex = 3;
            this.Ligar.Text = "Ligar";
            this.Ligar.UseVisualStyleBackColor = true;
            this.Ligar.Click += new System.EventHandler(this.Ligar_Click);
            // 
            // Detalhes
            // 
            this.Detalhes.Location = new System.Drawing.Point(606, 75);
            this.Detalhes.Name = "Detalhes";
            this.Detalhes.Size = new System.Drawing.Size(132, 74);
            this.Detalhes.TabIndex = 4;
            this.Detalhes.Text = "Detalhes";
            this.Detalhes.UseVisualStyleBackColor = true;
            this.Detalhes.Click += new System.EventHandler(this.Detalhes_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(340, 213);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Detalhes);
            this.Controls.Add(this.Ligar);
            this.Controls.Add(this.Desligar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Desligar;
        private System.Windows.Forms.Button Ligar;
        private System.Windows.Forms.Button Detalhes;
        private System.Windows.Forms.Button button1;
    }
}

