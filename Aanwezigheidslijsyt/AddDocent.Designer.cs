namespace Aanwezigheidslijst
{
    partial class AddDocent
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
            this.DocentNaamTextBox = new System.Windows.Forms.TextBox();
            this.DocentBedrijfTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AddDocentBtn = new System.Windows.Forms.Button();
            this.DocentNaamErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.DocentBrdrijfErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DocentNaamErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DocentBrdrijfErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // DocentNaamTextBox
            // 
            this.DocentNaamTextBox.Location = new System.Drawing.Point(12, 32);
            this.DocentNaamTextBox.Name = "DocentNaamTextBox";
            this.DocentNaamTextBox.Size = new System.Drawing.Size(242, 20);
            this.DocentNaamTextBox.TabIndex = 0;
            // 
            // DocentBedrijfTextBox
            // 
            this.DocentBedrijfTextBox.Location = new System.Drawing.Point(12, 73);
            this.DocentBedrijfTextBox.Name = "DocentBedrijfTextBox";
            this.DocentBedrijfTextBox.Size = new System.Drawing.Size(242, 20);
            this.DocentBedrijfTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Naam:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Bedrijf:";
            // 
            // AddDocentBtn
            // 
            this.AddDocentBtn.Location = new System.Drawing.Point(12, 108);
            this.AddDocentBtn.Name = "AddDocentBtn";
            this.AddDocentBtn.Size = new System.Drawing.Size(242, 50);
            this.AddDocentBtn.TabIndex = 4;
            this.AddDocentBtn.Text = "Docent toevoegen";
            this.AddDocentBtn.UseVisualStyleBackColor = true;
            this.AddDocentBtn.Click += new System.EventHandler(this.AddDocentBtn_Click);
            // 
            // DocentNaamErrorProvider
            // 
            this.DocentNaamErrorProvider.ContainerControl = this;
            // 
            // DocentBrdrijfErrorProvider
            // 
            this.DocentBrdrijfErrorProvider.ContainerControl = this;
            // 
            // AddDocent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AddDocentBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DocentBedrijfTextBox);
            this.Controls.Add(this.DocentNaamTextBox);
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "AddDocent";
            this.Text = "AddDocent";
            this.Load += new System.EventHandler(this.AddDocent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DocentNaamErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DocentBrdrijfErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox DocentNaamTextBox;
        private System.Windows.Forms.TextBox DocentBedrijfTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AddDocentBtn;
        private System.Windows.Forms.ErrorProvider DocentNaamErrorProvider;
        private System.Windows.Forms.ErrorProvider DocentBrdrijfErrorProvider;
    }
}