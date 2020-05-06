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
    public partial class AddStudentForm : Form
    {
        public string naam => NaamTextBox.Text;
        public string Adres => AdresTextBox.Text;
        public DateTime Geboortedatum => BirthdayPicker.Value;
        public AddStudentForm()
        {
            InitializeComponent();
        }

        private void AddStudentForm_Load(object sender, EventArgs e)
        {

        }

        private void AddStudentBtn_Click(object sender, EventArgs e)
        {
            if (NaamTextBox.Text != "" && !System.Text.RegularExpressions.Regex.IsMatch(NaamTextBox.Text, "^[1-9 ]"))
            {
            }
            else
            {
                AddStudentNameError.SetError(NaamTextBox, "Verkeerde input");
            }
            if (AdresTextBox.Text != "" && !System.Text.RegularExpressions.Regex.IsMatch(AdresTextBox.Text, "^[1-9 ]"))
            {
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                AddStudentAdresError.SetError(AdresTextBox, "Verkeerde adres");
            }
        }

    }
}
