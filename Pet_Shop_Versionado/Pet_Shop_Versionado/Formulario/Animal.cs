using Pet_Shop_Versionado.Dao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pet_Shop_Versionado.Formulario
{
    public partial class Painel_Animal : UserControl
    {
        public Painel_Animal()
        {
            InitializeComponent();
        }

        private void btnCadastrarPet_Click(object sender, EventArgs e)
        {
            Animal_Dao cadAnimal = new Animal_Dao();
            cadAnimal.insere_Animal(txtNomePet.Text);
            MessageBox.Show("Pet " + txtNomePet.Text + " cadastrado com sucesso!!!");
        }
    }
}
