namespace Aula1Exercicio04
{
    partial class form1
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
            this.Red = new System.Windows.Forms.Button();
            this.lime = new System.Windows.Forms.Button();
            this.Blue = new System.Windows.Forms.Button();
            this.Msg1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Red
            // 
            this.Red.BackColor = System.Drawing.Color.Red;
            this.Red.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Red.Location = new System.Drawing.Point(79, 59);
            this.Red.Name = "Red";
            this.Red.Size = new System.Drawing.Size(129, 43);
            this.Red.TabIndex = 0;
            this.Red.Text = "Vermelho";
            this.Red.UseVisualStyleBackColor = false;
            this.Red.Click += new System.EventHandler(this.Red_Click);
            // 
            // lime
            // 
            this.lime.BackColor = System.Drawing.Color.Lime;
            this.lime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lime.Location = new System.Drawing.Point(324, 58);
            this.lime.Name = "lime";
            this.lime.Size = new System.Drawing.Size(112, 44);
            this.lime.TabIndex = 1;
            this.lime.Text = "Verde";
            this.lime.UseVisualStyleBackColor = false;
            this.lime.Click += new System.EventHandler(this.lime_Click);
            // 
            // Blue
            // 
            this.Blue.BackColor = System.Drawing.Color.Aqua;
            this.Blue.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Blue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Blue.Location = new System.Drawing.Point(561, 59);
            this.Blue.Name = "Blue";
            this.Blue.Size = new System.Drawing.Size(103, 43);
            this.Blue.TabIndex = 2;
            this.Blue.Text = "Azul";
            this.Blue.UseVisualStyleBackColor = false;
            this.Blue.Click += new System.EventHandler(this.Blue_Click);
            // 
            // Msg1
            // 
            this.Msg1.AutoSize = true;
            this.Msg1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Msg1.Location = new System.Drawing.Point(335, 140);
            this.Msg1.Name = "Msg1";
            this.Msg1.Size = new System.Drawing.Size(87, 25);
            this.Msg1.TabIndex = 4;
            this.Msg1.Text = "A cor é";
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Msg1);
            this.Controls.Add(this.Blue);
            this.Controls.Add(this.lime);
            this.Controls.Add(this.Red);
            this.Name = "form1";
            this.Text = "form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Red;
        private System.Windows.Forms.Button lime;
        private System.Windows.Forms.Button Blue;
        private System.Windows.Forms.Label Msg1;
    }
}

