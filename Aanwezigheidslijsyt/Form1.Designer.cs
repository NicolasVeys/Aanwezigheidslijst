namespace Aanwezigheidslijst
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AddStudentMain = new System.Windows.Forms.Button();
            this.AddDocentMain = new System.Windows.Forms.Button();
            this.StudentPanel = new System.Windows.Forms.Panel();
            this.StudentDataGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.naamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.geboortedatumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.woonplaatsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.badgeNummerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deelnemersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._Aanwezigheidslijst_AanwezigheidsContextDataSet = new Aanwezigheidslijsyt._Aanwezigheidslijst_AanwezigheidsContextDataSet();
            this.button1 = new System.Windows.Forms.Button();
            this.ChangeStudentBtn = new System.Windows.Forms.Button();
            this.StudentenBtn = new System.Windows.Forms.Button();
            this.DocentenPanel = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.naamDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bedrijfDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.docentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._Aanwezigheidslijst_AanwezigheidsContextDataSet1 = new Aanwezigheidslijsyt._Aanwezigheidslijst_AanwezigheidsContextDataSet1();
            this.TijdsPanel = new System.Windows.Forms.Panel();
            this.OpleidingsPanel = new System.Windows.Forms.Panel();
            this.deelnemersTableAdapter = new Aanwezigheidslijsyt._Aanwezigheidslijst_AanwezigheidsContextDataSetTableAdapters.DeelnemersTableAdapter();
            this.docentsTableAdapter = new Aanwezigheidslijsyt._Aanwezigheidslijst_AanwezigheidsContextDataSet1TableAdapters.DocentsTableAdapter();
            this.DocentenBtn = new System.Windows.Forms.Button();
            this.OpleidingenBtn = new System.Windows.Forms.Button();
            this.TijdsBtn = new System.Windows.Forms.Button();
            this.StudentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StudentDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deelnemersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._Aanwezigheidslijst_AanwezigheidsContextDataSet)).BeginInit();
            this.DocentenPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.docentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._Aanwezigheidslijst_AanwezigheidsContextDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // AddStudentMain
            // 
            this.AddStudentMain.BackColor = System.Drawing.SystemColors.ControlLight;
            this.AddStudentMain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddStudentMain.Location = new System.Drawing.Point(17, 15);
            this.AddStudentMain.Name = "AddStudentMain";
            this.AddStudentMain.Size = new System.Drawing.Size(190, 66);
            this.AddStudentMain.TabIndex = 0;
            this.AddStudentMain.Text = "Student toevoegen";
            this.AddStudentMain.UseVisualStyleBackColor = false;
            this.AddStudentMain.Click += new System.EventHandler(this.AddStudentMain_Click);
            // 
            // AddDocentMain
            // 
            this.AddDocentMain.Location = new System.Drawing.Point(12, 15);
            this.AddDocentMain.Name = "AddDocentMain";
            this.AddDocentMain.Size = new System.Drawing.Size(190, 66);
            this.AddDocentMain.TabIndex = 1;
            this.AddDocentMain.Text = "Docent toevoegen";
            this.AddDocentMain.UseVisualStyleBackColor = true;
            this.AddDocentMain.Click += new System.EventHandler(this.AddDocentMain_Click);
            // 
            // StudentPanel
            // 
            this.StudentPanel.BackColor = System.Drawing.SystemColors.Control;
            this.StudentPanel.Controls.Add(this.StudentDataGridView);
            this.StudentPanel.Controls.Add(this.button1);
            this.StudentPanel.Controls.Add(this.ChangeStudentBtn);
            this.StudentPanel.Controls.Add(this.AddStudentMain);
            this.StudentPanel.Location = new System.Drawing.Point(160, 12);
            this.StudentPanel.Name = "StudentPanel";
            this.StudentPanel.Size = new System.Drawing.Size(628, 426);
            this.StudentPanel.TabIndex = 4;
            // 
            // StudentDataGridView
            // 
            this.StudentDataGridView.AllowUserToAddRows = false;
            this.StudentDataGridView.AllowUserToDeleteRows = false;
            this.StudentDataGridView.AutoGenerateColumns = false;
            this.StudentDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.StudentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.naamDataGridViewTextBoxColumn,
            this.geboortedatumDataGridViewTextBoxColumn,
            this.woonplaatsDataGridViewTextBoxColumn,
            this.badgeNummerDataGridViewTextBoxColumn});
            this.StudentDataGridView.DataSource = this.deelnemersBindingSource;
            this.StudentDataGridView.Location = new System.Drawing.Point(17, 102);
            this.StudentDataGridView.Name = "StudentDataGridView";
            this.StudentDataGridView.ReadOnly = true;
            this.StudentDataGridView.Size = new System.Drawing.Size(593, 305);
            this.StudentDataGridView.TabIndex = 2;
            this.StudentDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // naamDataGridViewTextBoxColumn
            // 
            this.naamDataGridViewTextBoxColumn.DataPropertyName = "Naam";
            this.naamDataGridViewTextBoxColumn.HeaderText = "Naam";
            this.naamDataGridViewTextBoxColumn.Name = "naamDataGridViewTextBoxColumn";
            this.naamDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // geboortedatumDataGridViewTextBoxColumn
            // 
            this.geboortedatumDataGridViewTextBoxColumn.DataPropertyName = "Geboortedatum";
            this.geboortedatumDataGridViewTextBoxColumn.HeaderText = "Geboortedatum";
            this.geboortedatumDataGridViewTextBoxColumn.Name = "geboortedatumDataGridViewTextBoxColumn";
            this.geboortedatumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // woonplaatsDataGridViewTextBoxColumn
            // 
            this.woonplaatsDataGridViewTextBoxColumn.DataPropertyName = "Woonplaats";
            this.woonplaatsDataGridViewTextBoxColumn.HeaderText = "Woonplaats";
            this.woonplaatsDataGridViewTextBoxColumn.Name = "woonplaatsDataGridViewTextBoxColumn";
            this.woonplaatsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // badgeNummerDataGridViewTextBoxColumn
            // 
            this.badgeNummerDataGridViewTextBoxColumn.DataPropertyName = "BadgeNummer";
            this.badgeNummerDataGridViewTextBoxColumn.HeaderText = "BadgeNummer";
            this.badgeNummerDataGridViewTextBoxColumn.Name = "badgeNummerDataGridViewTextBoxColumn";
            this.badgeNummerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // deelnemersBindingSource
            // 
            this.deelnemersBindingSource.DataMember = "Deelnemers";
            this.deelnemersBindingSource.DataSource = this._Aanwezigheidslijst_AanwezigheidsContextDataSet;
            // 
            // _Aanwezigheidslijst_AanwezigheidsContextDataSet
            // 
            this._Aanwezigheidslijst_AanwezigheidsContextDataSet.DataSetName = "_Aanwezigheidslijst_AanwezigheidsContextDataSet";
            this._Aanwezigheidslijst_AanwezigheidsContextDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(420, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(190, 66);
            this.button1.TabIndex = 3;
            this.button1.Text = "Student verwijderen";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ChangeStudentBtn
            // 
            this.ChangeStudentBtn.Location = new System.Drawing.Point(219, 15);
            this.ChangeStudentBtn.Margin = new System.Windows.Forms.Padding(9, 3, 8, 3);
            this.ChangeStudentBtn.Name = "ChangeStudentBtn";
            this.ChangeStudentBtn.Size = new System.Drawing.Size(190, 66);
            this.ChangeStudentBtn.TabIndex = 2;
            this.ChangeStudentBtn.Text = "Student aanpassen";
            this.ChangeStudentBtn.UseVisualStyleBackColor = true;
            // 
            // StudentenBtn
            // 
            this.StudentenBtn.BackColor = System.Drawing.Color.Transparent;
            this.StudentenBtn.Location = new System.Drawing.Point(12, 27);
            this.StudentenBtn.Name = "StudentenBtn";
            this.StudentenBtn.Size = new System.Drawing.Size(142, 52);
            this.StudentenBtn.TabIndex = 0;
            this.StudentenBtn.Text = "Studenten";
            this.StudentenBtn.UseVisualStyleBackColor = false;
            this.StudentenBtn.Click += new System.EventHandler(this.StudentenBtn_Click);
            // 
            // DocentenPanel
            // 
            this.DocentenPanel.BackColor = System.Drawing.SystemColors.Control;
            this.DocentenPanel.Controls.Add(this.button2);
            this.DocentenPanel.Controls.Add(this.button3);
            this.DocentenPanel.Controls.Add(this.dataGridView2);
            this.DocentenPanel.Controls.Add(this.AddDocentMain);
            this.DocentenPanel.Location = new System.Drawing.Point(794, 12);
            this.DocentenPanel.Name = "DocentenPanel";
            this.DocentenPanel.Size = new System.Drawing.Size(628, 426);
            this.DocentenPanel.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(418, 15);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(190, 66);
            this.button2.TabIndex = 5;
            this.button2.Text = "docent verwijderen";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(217, 15);
            this.button3.Margin = new System.Windows.Forms.Padding(9, 3, 8, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(190, 66);
            this.button3.TabIndex = 4;
            this.button3.Text = "Docent aanpassen";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.naamDataGridViewTextBoxColumn1,
            this.bedrijfDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.docentsBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(12, 102);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(593, 305);
            this.dataGridView2.TabIndex = 2;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // naamDataGridViewTextBoxColumn1
            // 
            this.naamDataGridViewTextBoxColumn1.DataPropertyName = "Naam";
            this.naamDataGridViewTextBoxColumn1.HeaderText = "Naam";
            this.naamDataGridViewTextBoxColumn1.Name = "naamDataGridViewTextBoxColumn1";
            this.naamDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // bedrijfDataGridViewTextBoxColumn
            // 
            this.bedrijfDataGridViewTextBoxColumn.DataPropertyName = "Bedrijf";
            this.bedrijfDataGridViewTextBoxColumn.HeaderText = "Bedrijf";
            this.bedrijfDataGridViewTextBoxColumn.Name = "bedrijfDataGridViewTextBoxColumn";
            this.bedrijfDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // docentsBindingSource
            // 
            this.docentsBindingSource.DataMember = "Docents";
            this.docentsBindingSource.DataSource = this._Aanwezigheidslijst_AanwezigheidsContextDataSet1;
            // 
            // _Aanwezigheidslijst_AanwezigheidsContextDataSet1
            // 
            this._Aanwezigheidslijst_AanwezigheidsContextDataSet1.DataSetName = "_Aanwezigheidslijst_AanwezigheidsContextDataSet1";
            this._Aanwezigheidslijst_AanwezigheidsContextDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TijdsPanel
            // 
            this.TijdsPanel.BackColor = System.Drawing.SystemColors.Control;
            this.TijdsPanel.Location = new System.Drawing.Point(794, 444);
            this.TijdsPanel.Name = "TijdsPanel";
            this.TijdsPanel.Size = new System.Drawing.Size(628, 426);
            this.TijdsPanel.TabIndex = 7;
            // 
            // OpleidingsPanel
            // 
            this.OpleidingsPanel.BackColor = System.Drawing.SystemColors.Control;
            this.OpleidingsPanel.Location = new System.Drawing.Point(160, 444);
            this.OpleidingsPanel.Name = "OpleidingsPanel";
            this.OpleidingsPanel.Size = new System.Drawing.Size(628, 426);
            this.OpleidingsPanel.TabIndex = 6;
            // 
            // deelnemersTableAdapter
            // 
            this.deelnemersTableAdapter.ClearBeforeFill = true;
            // 
            // docentsTableAdapter
            // 
            this.docentsTableAdapter.ClearBeforeFill = true;
            // 
            // DocentenBtn
            // 
            this.DocentenBtn.Location = new System.Drawing.Point(12, 114);
            this.DocentenBtn.Name = "DocentenBtn";
            this.DocentenBtn.Size = new System.Drawing.Size(142, 52);
            this.DocentenBtn.TabIndex = 8;
            this.DocentenBtn.Text = "Docenten";
            this.DocentenBtn.UseVisualStyleBackColor = true;
            this.DocentenBtn.Click += new System.EventHandler(this.DocentenBtn_Click);
            // 
            // OpleidingenBtn
            // 
            this.OpleidingenBtn.Location = new System.Drawing.Point(12, 208);
            this.OpleidingenBtn.Name = "OpleidingenBtn";
            this.OpleidingenBtn.Size = new System.Drawing.Size(142, 52);
            this.OpleidingenBtn.TabIndex = 9;
            this.OpleidingenBtn.Text = "Opleidingen";
            this.OpleidingenBtn.UseVisualStyleBackColor = true;
            this.OpleidingenBtn.Click += new System.EventHandler(this.OpleidingenBtn_Click);
            // 
            // TijdsBtn
            // 
            this.TijdsBtn.Location = new System.Drawing.Point(12, 299);
            this.TijdsBtn.Name = "TijdsBtn";
            this.TijdsBtn.Size = new System.Drawing.Size(142, 52);
            this.TijdsBtn.TabIndex = 10;
            this.TijdsBtn.Text = "Tijdsregistratie";
            this.TijdsBtn.UseVisualStyleBackColor = true;
            this.TijdsBtn.Click += new System.EventHandler(this.TijdsBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1448, 890);
            this.Controls.Add(this.TijdsBtn);
            this.Controls.Add(this.OpleidingenBtn);
            this.Controls.Add(this.DocentenBtn);
            this.Controls.Add(this.TijdsPanel);
            this.Controls.Add(this.OpleidingsPanel);
            this.Controls.Add(this.DocentenPanel);
            this.Controls.Add(this.StudentenBtn);
            this.Controls.Add(this.StudentPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.StudentPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.StudentDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deelnemersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._Aanwezigheidslijst_AanwezigheidsContextDataSet)).EndInit();
            this.DocentenPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.docentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._Aanwezigheidslijst_AanwezigheidsContextDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddStudentMain;
        private System.Windows.Forms.Button AddDocentMain;
        private System.Windows.Forms.Panel StudentPanel;
        private System.Windows.Forms.Button StudentenBtn;
        private System.Windows.Forms.Panel DocentenPanel;
        private System.Windows.Forms.Panel TijdsPanel;
        private System.Windows.Forms.Panel OpleidingsPanel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button ChangeStudentBtn;
        private System.Windows.Forms.DataGridView StudentDataGridView;
        private Aanwezigheidslijsyt._Aanwezigheidslijst_AanwezigheidsContextDataSet _Aanwezigheidslijst_AanwezigheidsContextDataSet;
        private System.Windows.Forms.BindingSource deelnemersBindingSource;
        private Aanwezigheidslijsyt._Aanwezigheidslijst_AanwezigheidsContextDataSetTableAdapters.DeelnemersTableAdapter deelnemersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn naamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn geboortedatumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn woonplaatsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn badgeNummerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private Aanwezigheidslijsyt._Aanwezigheidslijst_AanwezigheidsContextDataSet1 _Aanwezigheidslijst_AanwezigheidsContextDataSet1;
        private System.Windows.Forms.BindingSource docentsBindingSource;
        private Aanwezigheidslijsyt._Aanwezigheidslijst_AanwezigheidsContextDataSet1TableAdapters.DocentsTableAdapter docentsTableAdapter;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn naamDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn bedrijfDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button DocentenBtn;
        private System.Windows.Forms.Button OpleidingenBtn;
        private System.Windows.Forms.Button TijdsBtn;
    }
}

