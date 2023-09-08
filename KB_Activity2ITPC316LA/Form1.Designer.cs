namespace KB_Activity2ITPC316LA
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
            this.EmployeeNameLbl = new System.Windows.Forms.Label();
            this.employeenametextbox = new System.Windows.Forms.TextBox();
            this.DaysofWorklbl = new System.Windows.Forms.Label();
            this.Employeetypelbl = new System.Windows.Forms.Label();
            this.submit = new System.Windows.Forms.Button();
            this.Daysofworkcombobox = new System.Windows.Forms.ComboBox();
            this.Employeetypecombobox = new System.Windows.Forms.ComboBox();
            this.ComputedRichTextbox = new System.Windows.Forms.RichTextBox();
            this.clear_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EmployeeNameLbl
            // 
            this.EmployeeNameLbl.AutoSize = true;
            this.EmployeeNameLbl.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeNameLbl.Location = new System.Drawing.Point(38, 54);
            this.EmployeeNameLbl.Name = "EmployeeNameLbl";
            this.EmployeeNameLbl.Size = new System.Drawing.Size(166, 22);
            this.EmployeeNameLbl.TabIndex = 0;
            this.EmployeeNameLbl.Text = "Employee Name:";
            // 
            // employeenametextbox
            // 
            this.employeenametextbox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeenametextbox.Location = new System.Drawing.Point(210, 54);
            this.employeenametextbox.Name = "employeenametextbox";
            this.employeenametextbox.Size = new System.Drawing.Size(240, 26);
            this.employeenametextbox.TabIndex = 0;
            // 
            // DaysofWorklbl
            // 
            this.DaysofWorklbl.AutoSize = true;
            this.DaysofWorklbl.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DaysofWorklbl.Location = new System.Drawing.Point(72, 109);
            this.DaysofWorklbl.Name = "DaysofWorklbl";
            this.DaysofWorklbl.Size = new System.Drawing.Size(117, 22);
            this.DaysofWorklbl.TabIndex = 2;
            this.DaysofWorklbl.Text = "Work Days:";
            // 
            // Employeetypelbl
            // 
            this.Employeetypelbl.AutoSize = true;
            this.Employeetypelbl.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Employeetypelbl.Location = new System.Drawing.Point(38, 162);
            this.Employeetypelbl.Name = "Employeetypelbl";
            this.Employeetypelbl.Size = new System.Drawing.Size(154, 22);
            this.Employeetypelbl.TabIndex = 3;
            this.Employeetypelbl.Text = "Employee type:";
            // 
            // submit
            // 
            this.submit.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit.Location = new System.Drawing.Point(212, 218);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(147, 39);
            this.submit.TabIndex = 4;
            this.submit.Text = "Submit";
            this.submit.UseMnemonic = false;
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.button1_Click);
            // 
            // Daysofworkcombobox
            // 
            this.Daysofworkcombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Daysofworkcombobox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Daysofworkcombobox.FormattingEnabled = true;
            this.Daysofworkcombobox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.Daysofworkcombobox.Location = new System.Drawing.Point(210, 105);
            this.Daysofworkcombobox.Name = "Daysofworkcombobox";
            this.Daysofworkcombobox.Size = new System.Drawing.Size(49, 26);
            this.Daysofworkcombobox.TabIndex = 5;
            // 
            // Employeetypecombobox
            // 
            this.Employeetypecombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Employeetypecombobox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Employeetypecombobox.FormattingEnabled = true;
            this.Employeetypecombobox.Items.AddRange(new object[] {
            "Permanent",
            "Probationary",
            "Contractual"});
            this.Employeetypecombobox.Location = new System.Drawing.Point(210, 159);
            this.Employeetypecombobox.Name = "Employeetypecombobox";
            this.Employeetypecombobox.Size = new System.Drawing.Size(240, 26);
            this.Employeetypecombobox.TabIndex = 6;
            // 
            // ComputedRichTextbox
            // 
            this.ComputedRichTextbox.BackColor = System.Drawing.Color.Khaki;
            this.ComputedRichTextbox.Location = new System.Drawing.Point(12, 291);
            this.ComputedRichTextbox.Name = "ComputedRichTextbox";
            this.ComputedRichTextbox.ReadOnly = true;
            this.ComputedRichTextbox.Size = new System.Drawing.Size(462, 214);
            this.ComputedRichTextbox.TabIndex = 7;
            this.ComputedRichTextbox.Text = "";
            // 
            // clear_button
            // 
            this.clear_button.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear_button.Location = new System.Drawing.Point(365, 219);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(96, 38);
            this.clear_button.TabIndex = 8;
            this.clear_button.Text = "Clear";
            this.clear_button.UseVisualStyleBackColor = true;
            this.clear_button.Click += new System.EventHandler(this.clear_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(490, 517);
            this.Controls.Add(this.clear_button);
            this.Controls.Add(this.ComputedRichTextbox);
            this.Controls.Add(this.Employeetypecombobox);
            this.Controls.Add(this.Daysofworkcombobox);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.Employeetypelbl);
            this.Controls.Add(this.DaysofWorklbl);
            this.Controls.Add(this.employeenametextbox);
            this.Controls.Add(this.EmployeeNameLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Payroll System";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EmployeeNameLbl;
        private System.Windows.Forms.TextBox employeenametextbox;
        private System.Windows.Forms.Label DaysofWorklbl;
        private System.Windows.Forms.Label Employeetypelbl;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.ComboBox Daysofworkcombobox;
        private System.Windows.Forms.ComboBox Employeetypecombobox;
        private System.Windows.Forms.RichTextBox ComputedRichTextbox;
        private System.Windows.Forms.Button clear_button;
    }
}

