
namespace Pet_Shop_Versionado
{
    partial class Home
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
            this.Menu_Lateral = new System.Windows.Forms.Panel();
            this.painel_Animal1 = new Pet_Shop_Versionado.Formulario.Painel_Animal();
            this.SuspendLayout();
            // 
            // Menu_Lateral
            // 
            this.Menu_Lateral.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Menu_Lateral.Location = new System.Drawing.Point(2, 1);
            this.Menu_Lateral.Name = "Menu_Lateral";
            this.Menu_Lateral.Size = new System.Drawing.Size(225, 702);
            this.Menu_Lateral.TabIndex = 0;
            // 
            // painel_Animal1
            // 
            this.painel_Animal1.Location = new System.Drawing.Point(233, 1);
            this.painel_Animal1.Name = "painel_Animal1";
            this.painel_Animal1.Size = new System.Drawing.Size(1134, 702);
            this.painel_Animal1.TabIndex = 1;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1368, 706);
            this.Controls.Add(this.painel_Animal1);
            this.Controls.Add(this.Menu_Lateral);
            this.Name = "Home";
            this.Text = "Pagina Principal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Menu_Lateral;
        private Formulario.Painel_Animal painel_Animal1;
    }
}

