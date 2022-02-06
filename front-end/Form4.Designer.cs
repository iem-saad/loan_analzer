namespace PROB
{
    partial class ShowRecords
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
            this.Deleterecord = new System.Windows.Forms.Button();
            this.BACK = new System.Windows.Forms.Button();
            this.EXIT = new System.Windows.Forms.Button();
            this.csvView = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.csvView)).BeginInit();
            this.SuspendLayout();
            // 
            // Deleterecord
            // 
            this.Deleterecord.BackColor = System.Drawing.Color.Black;
            this.Deleterecord.Font = new System.Drawing.Font("Forte", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deleterecord.ForeColor = System.Drawing.SystemColors.Control;
            this.Deleterecord.Location = new System.Drawing.Point(475, 332);
            this.Deleterecord.Name = "Deleterecord";
            this.Deleterecord.Size = new System.Drawing.Size(127, 51);
            this.Deleterecord.TabIndex = 0;
            this.Deleterecord.Text = "Delete Record";
            this.Deleterecord.UseVisualStyleBackColor = false;
            this.Deleterecord.Click += new System.EventHandler(this.Deleterecord_Click);
            // 
            // BACK
            // 
            this.BACK.BackColor = System.Drawing.Color.Black;
            this.BACK.Font = new System.Drawing.Font("Forte", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BACK.ForeColor = System.Drawing.SystemColors.Control;
            this.BACK.Location = new System.Drawing.Point(12, 407);
            this.BACK.Name = "BACK";
            this.BACK.Size = new System.Drawing.Size(85, 31);
            this.BACK.TabIndex = 1;
            this.BACK.Text = "BACK";
            this.BACK.UseVisualStyleBackColor = false;
            this.BACK.Click += new System.EventHandler(this.BACK_Click);
            // 
            // EXIT
            // 
            this.EXIT.BackColor = System.Drawing.Color.Red;
            this.EXIT.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EXIT.Location = new System.Drawing.Point(755, 12);
            this.EXIT.Name = "EXIT";
            this.EXIT.Size = new System.Drawing.Size(33, 29);
            this.EXIT.TabIndex = 2;
            this.EXIT.Text = "X";
            this.EXIT.UseVisualStyleBackColor = false;
            this.EXIT.Click += new System.EventHandler(this.EXIT_Click);
            // 
            // csvView
            // 
            this.csvView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.csvView.Location = new System.Drawing.Point(182, 53);
            this.csvView.Name = "csvView";
            this.csvView.Size = new System.Drawing.Size(493, 255);
            this.csvView.TabIndex = 3;
            this.csvView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.csvView_CellContentClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Font = new System.Drawing.Font("Forte", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(257, 332);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 51);
            this.button1.TabIndex = 4;
            this.button1.Text = "Insert Record";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ShowRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PROB.Properties.Resources._1500_0____Copy;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.csvView);
            this.Controls.Add(this.EXIT);
            this.Controls.Add(this.BACK);
            this.Controls.Add(this.Deleterecord);
            this.Name = "ShowRecords";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Show Record";
            ((System.ComponentModel.ISupportInitialize)(this.csvView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Deleterecord;
        private System.Windows.Forms.Button BACK;
        private System.Windows.Forms.Button EXIT;
        private System.Windows.Forms.DataGridView csvView;
        private System.Windows.Forms.Button button1;
    }
}