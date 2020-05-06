using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aanwezigheidslijst
{
    public partial class AddDocent : Form
    {
        public string Naam => DocentNaamTextBox.Text;
        public string Bedrijf => DocentBedrijfTextBox.Text;
        public AddDocent()
        {
            InitializeComponent();
        }

        private void AddDocent_Load(object sender, EventArgs e)
        {

        }

        private void AddDocentBtn_Click(object sender, EventArgs e)
        {
            if (DocentNaamTextBox.Text != "" && !System.Text.RegularExpressions.Regex.IsMatch(DocentNaamTextBox.Text, "^[1-9 ]"))
            {
                DialogResult = DialogResult.OK;
                Close();

            }
            else
            {
                DocentNaamErrorProvider.SetError(DocentNaamTextBox, "Verkeerde naam input");
            }
        }
    }
}

