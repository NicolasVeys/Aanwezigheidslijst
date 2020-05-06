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
            this.components = new System.ComponentModel.Container();
            this.NaamTextBox = new System.Windows.Forms.TextBox();
            this.AdresTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AddStudentBtn = new System.Windows.Forms.Button();
            this.BirthdayPicker = new System.Windows.Forms.DateTimePicker();
            this.AddStudentNameError = new System.Windows.Forms.ErrorProvider(this.components);
            this.AddStudentAdresError = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.AddStudentNameError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddStudentAdresError)).BeginInit();
            this.SuspendLayout();
            // 
            // NaamTextBox
            // 
            this.NaamTextBox.Location = new System.Drawing.Point(12, 30);
            this.NaamTextBox.Name = "NaamTextBox";
            this.NaamTextBox.Size = new System.Drawing.Size(242, 20);
            this.NaamTextBox.TabIndex = 0;
            // 
            // AdresTextBox
            // 
            this.AdresTextBox.Location = new System.Drawing.Point(12, 85);
            this.AdresTextBox.Name = "AdresTextBox";
            this.AdresTextBox.Size = new System.Drawing.Size(242, 20);
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
            this.AddStudentBtn.Size = new System.Drawing.Size(242, 42);
            this.AddStudentBtn.TabIndex = 6;
            this.AddStudentBtn.Text = "Student Toevoegen";
            this.AddStudentBtn.UseVisualStyleBackColor = true;
            this.AddStudentBtn.Click += new System.EventHandler(this.AddStudentBtn_Click);
            // 
            // BirthdayPicker
            // 
            this.BirthdayPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.BirthdayPicker.Location = new System.Drawing.Point(10, 136);
            this.BirthdayPicker.MaxDate = new System.DateTime(2002, 1, 1, 0, 0, 0, 0);
            this.BirthdayPicker.MinDate = new System.DateTime(1910, 1, 1, 0, 0, 0, 0);
            this.BirthdayPicker.Name = "BirthdayPicker";
            this.BirthdayPicker.Size = new System.Drawing.Size(94, 20);
            this.BirthdayPicker.TabIndex = 7;
            this.BirthdayPicker.Value = new System.DateTime(2002, 1, 1, 0, 0, 0, 0);
            // 
            // AddStudentNameError
            // 
            this.AddStudentNameError.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.AddStudentNameError.ContainerControl = this;
            // 
            // AddStudentAdresError
            // 
            this.AddStudentAdresError.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.AddStudentAdresError.ContainerControl = this;
            // 
            // AddStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 230);
            this.Controls.Add(this.BirthdayPicker);
            this.Controls.Add(this.AddStudentBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AdresTextBox);
            this.Controls.Add(this.NaamTextBox);
            this.MaximumSize = new System.Drawing.Size(295, 269);
            this.MinimumSize = new System.Drawing.Size(295, 269);
            this.Name = "AddStudentForm";
            this.Text = "Student toevoegen";
            this.Load += new System.EventHandler(this.AddStudentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AddStudentNameError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddStudentAdresError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NaamTextBox;
        private System.Windows.Forms.TextBox AdresTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button AddStudentBtn;
        private System.Windows.Forms.DateTimePicker BirthdayPicker;
        private System.Windows.Forms.ErrorProvider AddStudentNameError;
        private System.Windows.Forms.ErrorProvider AddStudentAdresError;
    }
}