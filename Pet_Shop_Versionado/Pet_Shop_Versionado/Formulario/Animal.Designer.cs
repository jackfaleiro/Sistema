
namespace Pet_Shop_Versionado.Formulario
{
    partial class Painel_Animal
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNomePet = new System.Windows.Forms.Label();
            this.txtNomePet = new System.Windows.Forms.TextBox();
            this.btnCadastrarPet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNomePet
            // 
            this.lblNomePet.AutoSize = true;
            this.lblNomePet.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomePet.Location = new System.Drawing.Point(138, 105);
            this.lblNomePet.Name = "lblNomePet";
            this.lblNomePet.Size = new System.Drawing.Size(111, 29);
            this.lblNomePet.TabIndex = 0;
            this.lblNomePet.Text = "Nome PET";
            // 
            // txtNomePet
            // 
            this.txtNomePet.Location = new System.Drawing.Point(285, 94);
            this.txtNomePet.Multiline = true;
            this.txtNomePet.Name = "txtNomePet";
            this.txtNomePet.Size = new System.Drawing.Size(425, 40);
            this.txtNomePet.TabIndex = 1;
            // 
            // btnCadastrarPet
            // 
            this.btnCadastrarPet.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarPet.Location = new System.Drawing.Point(839, 549);
            this.btnCadastrarPet.Name = "btnCadastrarPet";
            this.btnCadastrarPet.Size = new System.Drawing.Size(200, 100);
            this.btnCadastrarPet.TabIndex = 2;
            this.btnCadastrarPet.Text = "Cadastrar PET";
            this.btnCadastrarPet.UseVisualStyleBackColor = true;
            this.btnCadastrarPet.Click += new System.EventHandler(this.btnCadastrarPet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(512, 337);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome PET";
            // 
            // Painel_Animal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCadastrarPet);
            this.Controls.Add(this.txtNomePet);
            this.Controls.Add(this.lblNomePet);
            this.Name = "Painel_Animal";
            this.Size = new System.Drawing.Size(1134, 702);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomePet;
        private System.Windows.Forms.TextBox txtNomePet;
        private System.Windows.Forms.Button btnCadastrarPet;
        private System.Windows.Forms.Label label1;
    }
}
