namespace projetoAtleta
{
    partial class Pessoa
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
            this.dtNascimento = new System.Windows.Forms.DateTimePicker();
            this.lblIdade = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblAltura = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // dtNascimento
            // 
            this.dtNascimento.Location = new System.Drawing.Point(334, 79);
            this.dtNascimento.Margin = new System.Windows.Forms.Padding(4);
            this.dtNascimento.Name = "dtNascimento";
            this.dtNascimento.Size = new System.Drawing.Size(288, 22);
            this.dtNascimento.TabIndex = 19;
            this.dtNascimento.ValueChanged += new System.EventHandler(this.dtNascimento_ValueChanged);
            // 
            // lblIdade
            // 
            this.lblIdade.AutoSize = true;
            this.lblIdade.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.lblIdade.Location = new System.Drawing.Point(341, 390);
            this.lblIdade.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.Size = new System.Drawing.Size(111, 35);
            this.lblIdade.TabIndex = 18;
            this.lblIdade.Text = "0 Anos";
            this.lblIdade.Click += new System.EventHandler(this.lblIdade_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(375, 345);
            this.lblInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(51, 17);
            this.lblInfo.TabIndex = 17;
            this.lblInfo.Text = "Idade: ";
            this.lblInfo.Click += new System.EventHandler(this.lblInfo_Click);
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Location = new System.Drawing.Point(178, 135);
            this.lblAltura.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(53, 17);
            this.lblAltura.TabIndex = 16;
            this.lblAltura.Text = "Altura: ";
            this.lblAltura.Click += new System.EventHandler(this.lblAltura_Click);
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(178, 85);
            this.lblData.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(144, 17);
            this.lblData.TabIndex = 15;
            this.lblData.Text = "Data de Nascimento: ";
            this.lblData.Click += new System.EventHandler(this.lblData_Click);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(178, 34);
            this.lblNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(53, 17);
            this.lblNome.TabIndex = 14;
            this.lblNome.Text = "Nome: ";
            this.lblNome.Click += new System.EventHandler(this.lblNome_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(182, 267);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(4);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(441, 63);
            this.btnCalcular.TabIndex = 13;
            this.btnCalcular.Text = "Calcular idade";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(182, 181);
            this.btnEnviar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(441, 63);
            this.btnEnviar.TabIndex = 12;
            this.btnEnviar.Text = "Enviar dados";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(334, 132);
            this.txtAltura.Margin = new System.Windows.Forms.Padding(4);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(288, 22);
            this.txtAltura.TabIndex = 11;
            this.txtAltura.TextChanged += new System.EventHandler(this.txtAltura_TextChanged);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(334, 26);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(288, 22);
            this.txtNome.TabIndex = 10;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // Pessoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtNascimento);
            this.Controls.Add(this.lblIdade);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lblAltura);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.txtNome);
            this.Name = "Pessoa";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtNascimento;
        private System.Windows.Forms.Label lblIdade;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.TextBox txtNome;
    }
}

