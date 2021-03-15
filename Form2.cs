using Lab3_repaso.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3_repaso
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            textDPI.Focus();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private bool validateFieldstoPerson()
        {
            //Validate people's textFields
            return !textDPI.Text.Equals("") &&
                !textName.Text.Equals("") &&
                !textLast.Text.Equals("");
        }

        private bool validateFilestoPropertys()
        {
            //Validate the textFields and the comboBox of the condominiums
            return !comboBox1.Text.Equals("") &&
                !textNumber.Text.Equals("") &&
                !textMantainance.Text.Equals("");
        }

        private void clearTextFiles()
        {
            textDPI.Text = "";
            textName.Text = "";
            textLast.Text = "";
            comboBox1.SelectedIndex = 0;
            textNumber.Text = "";
            textMantainance.Text = "";
        }
        private void buttonPerson_Click(object sender, EventArgs e)
        {
            if( validateFieldstoPerson())
            {
                Data.Datos.personals.Add(
                    new Classs.DatosPersona(
                        textDPI.Text,
                        textName.Text,
                        textLast.Text));
                Data.Datos.savePerson();
                Data.Datos.generateReports();
                comboBox1.Items.Add(textDPI.Text);
                clearTextFiles();
            }
        }

        private void buttonProperty_Click(object sender, EventArgs e)
        {
            if( validateFilestoPropertys() )
            {
                Data.Datos.condominia.Add(
                    new Classs.DatosCondominios(
                        comboBox1.Text,
                        int.Parse(textNumber.Text),
                        double.Parse(textMantainance.Text)));
                Data.Datos.saveCondominium();
                Data.Datos.generateReports();
                clearTextFiles();
            }
        }

        private void textDPI_TextChanged(object sender, EventArgs e)
        {

        }

        private void textName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
