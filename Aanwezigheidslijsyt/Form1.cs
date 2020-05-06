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
            StudentPanel.Visible = true;
            DocentenPanel.Visible = false;
            OpleidingsPanel.Visible = false;
            TijdsPanel.Visible = false;
            StudentenBtn.BackColor = Color.DarkGray;
            // TODO: This line of code loads data into the '_Aanwezigheidslijst_AanwezigheidsContextDataSet1.Docents' table. You can move, or remove it, as needed.
            this.docentsTableAdapter.Fill(this._Aanwezigheidslijst_AanwezigheidsContextDataSet1.Docents);
            // TODO: This line of code loads data into the '_Aanwezigheidslijst_AanwezigheidsContextDataSet.Deelnemers' table. You can move, or remove it, as needed.
            this.deelnemersTableAdapter.Fill(this._Aanwezigheidslijst_AanwezigheidsContextDataSet.Deelnemers);

        }

        private void AddStudentMain_Click(object sender, EventArgs e)
        {
            using (var addStudentForm = new AddStudentForm())
            {
                var dialogresult = addStudentForm.ShowDialog();

                if (DialogResult.OK == dialogresult)
                {
                    using (AanwezigheidsContext ctx = new AanwezigheidsContext())
                    {
                        ctx.Deelnemers.Add(new Deelnemer()
                        {
                            Naam = addStudentForm.naam,
                            Woonplaats = addStudentForm.Adres,
                            Geboortedatum = addStudentForm.Geboortedatum
                        });
                        ctx.SaveChanges();
                        StudentDataGridView.Update();
                        StudentDataGridView.Refresh();
                    }
                }
            }
        }

        private void AddDocentMain_Click(object sender, EventArgs e)
        {
            using (var addDocentForm = new AddDocent())
            {
                var dialogresult = addDocentForm.ShowDialog();
                if (DialogResult.OK == dialogresult)
                {
                    using (AanwezigheidsContext ctx = new AanwezigheidsContext())
                    {
                        ctx.Docenten.Add(new Docent()
                        {
                            Naam = addDocentForm.Naam,
                            Bedrijf = addDocentForm.Bedrijf
                        });
                        ctx.SaveChanges();
                    }
                }
            }
        }

        private void ShowStudentPanelBtn_Click(object sender, EventArgs e)
        {
            using (var Mainform = new Form1())
            {
                StudentPanel.Visible = true;
            }
        }

        private void HideStudentPanelBtn_Click(object sender, EventArgs e)
        {
            using (var Mainform = new Form1())
            {
                StudentPanel.Visible = false;
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void StudentenBtn_Click(object sender, EventArgs e)
        {
            using (var Mainform = new Form1())
            {
                StudentPanel.Visible = true;
                DocentenPanel.Visible = false;
                OpleidingsPanel.Visible = false;
                TijdsPanel.Visible = false;
                StudentenBtn.BackColor = Color.DarkGray;
                DocentenBtn.BackColor = Color.Transparent;
                OpleidingenBtn.BackColor = Color.Transparent;
                TijdsBtn.BackColor = Color.Transparent;

            }

        }
        private void DocentenBtn_Click(object sender, EventArgs e)
        {
            using (var Mainform = new Form1())
            {
                StudentPanel.Visible = false;
                DocentenPanel.Visible = true;
                OpleidingsPanel.Visible = false;
                TijdsPanel.Visible = false;
                StudentenBtn.BackColor = Color.Transparent;
                DocentenBtn.BackColor = Color.DarkGray;
                OpleidingenBtn.BackColor = Color.Transparent;
                TijdsBtn.BackColor = Color.Transparent;
            }
        }

        private void OpleidingenBtn_Click(object sender, EventArgs e)
        {
            using (var Mainform = new Form1())
            {
                StudentPanel.Visible = false;
                DocentenPanel.Visible = false;
                OpleidingsPanel.Visible = true;
                TijdsPanel.Visible = false;
                StudentenBtn.BackColor = Color.Transparent;
                DocentenBtn.BackColor = Color.Transparent;
                OpleidingenBtn.BackColor = Color.DarkGray;
                TijdsBtn.BackColor = Color.Transparent;

            }
        }

        private void TijdsBtn_Click(object sender, EventArgs e)
        {
            StudentPanel.Visible = false;
            DocentenPanel.Visible = false;
            OpleidingsPanel.Visible = false;
            TijdsPanel.Visible = true;
            StudentenBtn.BackColor = Color.Transparent;
            DocentenBtn.BackColor = Color.Transparent;
            OpleidingenBtn.BackColor = Color.Transparent;
            TijdsBtn.BackColor = Color.DarkGray;


        }
    }
}

