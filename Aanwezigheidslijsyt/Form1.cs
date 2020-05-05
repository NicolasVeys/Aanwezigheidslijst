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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void AddStudentMain_Click(object sender, EventArgs e)
        {
            using (var addStudentForm = new AddStudentForm())

            {
                var dialogresult = addStudentForm.ShowDialog();
                if (DialogResult.OK == DialogResult)
                {
                        using (AanwezigheidsContext ctx = new AanwezigheidsContext())
                        {
                            ctx.Deelnemers.Add(new Deelnemer()
                            {
                                Naam = addStudentForm.naam,
                                Woonplaats = addStudentForm.Adres,
                            });
                            ctx.SaveChanges();
                        }
                    }
                }
            }
        }
    }
}
