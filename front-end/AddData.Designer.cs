namespace PROB
{
    partial class AddData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddData));
            this.gender = new System.Windows.Forms.ComboBox();
            this.martial = new System.Windows.Forms.ComboBox();
            this.dependents = new System.Windows.Forms.ComboBox();
            this.education = new System.Windows.Forms.ComboBox();
            this.area = new System.Windows.Forms.ComboBox();
            this.loan_status = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.income = new System.Windows.Forms.TextBox();
            this.loan_amount = new System.Windows.Forms.TextBox();
            this.term = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.EXIT = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gender
            // 
            this.gender.FormattingEnabled = true;
            this.gender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.gender.Location = new System.Drawing.Point(125, 100);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(121, 21);
            this.gender.TabIndex = 0;
            // 
            // martial
            // 
            this.martial.FormattingEnabled = true;
            this.martial.Items.AddRange(new object[] {
            "No",
            "Yes"});
            this.martial.Location = new System.Drawing.Point(125, 182);
            this.martial.Name = "martial";
            this.martial.Size = new System.Drawing.Size(121, 21);
            this.martial.TabIndex = 1;
            // 
            // dependents
            // 
            this.dependents.FormattingEnabled = true;
            this.dependents.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3+"});
            this.dependents.Location = new System.Drawing.Point(125, 263);
            this.dependents.Name = "dependents";
            this.dependents.Size = new System.Drawing.Size(121, 21);
            this.dependents.TabIndex = 2;
            // 
            // education
            // 
            this.education.FormattingEnabled = true;
            this.education.Items.AddRange(new object[] {
            "Graduate",
            "Not Graduate"});
            this.education.Location = new System.Drawing.Point(125, 339);
            this.education.Name = "education";
            this.education.Size = new System.Drawing.Size(121, 21);
            this.education.TabIndex = 3;
            // 
            // area
            // 
            this.area.FormattingEnabled = true;
            this.area.Items.AddRange(new object[] {
            "Urban",
            "Semiurban",
            "Rural"});
            this.area.Location = new System.Drawing.Point(354, 100);
            this.area.Name = "area";
            this.area.Size = new System.Drawing.Size(121, 21);
            this.area.TabIndex = 4;
            // 
            // loan_status
            // 
            this.loan_status.FormattingEnabled = true;
            this.loan_status.Items.AddRange(new object[] {
            "Y",
            "N"});
            this.loan_status.Location = new System.Drawing.Point(354, 182);
            this.loan_status.Name = "loan_status";
            this.loan_status.Size = new System.Drawing.Size(121, 21);
            this.loan_status.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(122, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Gender";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(122, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Married";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(123, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Dependents";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(122, 319);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Education";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(351, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Property Area";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(351, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Loan Status";
            // 
            // income
            // 
            this.income.Location = new System.Drawing.Point(354, 263);
            this.income.Name = "income";
            this.income.Size = new System.Drawing.Size(121, 20);
            this.income.TabIndex = 12;
            // 
            // loan_amount
            // 
            this.loan_amount.Location = new System.Drawing.Point(354, 339);
            this.loan_amount.Name = "loan_amount";
            this.loan_amount.Size = new System.Drawing.Size(121, 20);
            this.loan_amount.TabIndex = 13;
            // 
            // term
            // 
            this.term.Location = new System.Drawing.Point(551, 101);
            this.term.Name = "term";
            this.term.Size = new System.Drawing.Size(121, 20);
            this.term.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(351, 243);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "Applicant Income";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(351, 319);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 17);
            this.label9.TabIndex = 16;
            this.label9.Text = "Loan Amount";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(548, 80);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(129, 17);
            this.label10.TabIndex = 17;
            this.label10.Text = "Loan Amount Term";
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Black;
            this.button7.Font = new System.Drawing.Font("Forte", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.SystemColors.Control;
            this.button7.Location = new System.Drawing.Point(551, 171);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(107, 32);
            this.button7.TabIndex = 18;
            this.button7.Text = "Add Data";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Font = new System.Drawing.Font("Forte", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(12, 406);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 32);
            this.button1.TabIndex = 19;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // EXIT
            // 
            this.EXIT.BackColor = System.Drawing.Color.Red;
            this.EXIT.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EXIT.Location = new System.Drawing.Point(755, 12);
            this.EXIT.Name = "EXIT";
            this.EXIT.Size = new System.Drawing.Size(33, 29);
            this.EXIT.TabIndex = 20;
            this.EXIT.Text = "X";
            this.EXIT.UseVisualStyleBackColor = false;
            this.EXIT.Click += new System.EventHandler(this.EXIT_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Forte", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(181, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(425, 44);
            this.label8.TabIndex = 21;
            this.label8.Text = "Data Entry Dashboard";
            // 
            // AddData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.EXIT);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.term);
            this.Controls.Add(this.loan_amount);
            this.Controls.Add(this.income);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loan_status);
            this.Controls.Add(this.area);
            this.Controls.Add(this.education);
            this.Controls.Add(this.dependents);
            this.Controls.Add(this.martial);
            this.Controls.Add(this.gender);
            this.Name = "AddData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddData";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox gender;
        private System.Windows.Forms.ComboBox martial;
        private System.Windows.Forms.ComboBox dependents;
        private System.Windows.Forms.ComboBox education;
        private System.Windows.Forms.ComboBox area;
        private System.Windows.Forms.ComboBox loan_status;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox income;
        private System.Windows.Forms.TextBox loan_amount;
        private System.Windows.Forms.TextBox term;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button EXIT;
        private System.Windows.Forms.Label label8;
    }
}