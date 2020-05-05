namespace Aanwezigheidslijst
{
    partial class AddStudentForm
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
            this.NaamTextBox = new System.Windows.Forms.TextBox();
            this.GeboortedatumTextbox = new System.Windows.Forms.TextBox();
            this.AdresTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AddStudentBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NaamTextBox
            // 
            this.NaamTextBox.Location = new System.Drawing.Point(12, 30);
            this.NaamTextBox.Name = "NaamTextBox";
            this.NaamTextBox.Size = new System.Drawing.Size(253, 20);
            this.NaamTextBox.TabIndex = 0;
            // 
            // GeboortedatumTextbox
            // 
            this.GeboortedatumTextbox.Location = new System.Drawing.Point(12, 136);
            this.GeboortedatumTextbox.Name = "GeboortedatumTextbox";
            this.GeboortedatumTextbox.Size = new System.Drawing.Size(253, 20);
            this.GeboortedatumTextbox.TabIndex = 2;
            // 
            // AdresTextBox
            // 
            this.AdresTextBox.Location = new System.Drawing.Point(12, 85);
            this.AdresTextBox.Name = "AdresTextBox";
            this.AdresTextBox.Size = new System.Drawing.Size(253, 20);
            this.AdresTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Naam:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Geboortedatum:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Adres:";
            // 
            // AddStudentBtn
            // 
            this.AddStudentBtn.Location = new System.Drawing.Point(12, 171);
            this.AddStudentBtn.Name = "AddStudentBtn";
            this.AddStudentBtn.Size = new System.Drawing.Size(253, 42);
            this.AddStudentBtn.TabIndex = 6;
            this.AddStudentBtn.Text = "Student Toevoegen";
            this.AddStudentBtn.UseVisualStyleBackColor = true;
            this.AddStudentBtn.Click += new System.EventHandler(this.AddStudentBtn_Click);
            // 
            // AddStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 230);
            this.Controls.Add(this.AddStudentBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AdresTextBox);
            this.Controls.Add(this.GeboortedatumTextbox);
            this.Controls.Add(this.NaamTextBox);
            this.MaximumSize = new System.Drawing.Size(295, 269);
            this.MinimumSize = new System.Drawing.Size(295, 269);
            this.Name = "AddStudentForm";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.AddStudentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NaamTextBox;
        private System.Windows.Forms.TextBox GeboortedatumTextbox;
        private System.Windows.Forms.TextBox AdresTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button AddStudentBtn;
    }
}