namespace PROB
{
    partial class DeleteRecord
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteRecord));
            this.DELETE = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.Label();
            this.BACK = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DELETE
            // 
            this.DELETE.BackColor = System.Drawing.Color.Black;
            this.DELETE.Font = new System.Drawing.Font("Forte", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DELETE.ForeColor = System.Drawing.SystemColors.Control;
            this.DELETE.Location = new System.Drawing.Point(138, 124);
            this.DELETE.Name = "DELETE";
            this.DELETE.Size = new System.Drawing.Size(114, 47);
            this.DELETE.TabIndex = 0;
            this.DELETE.Text = "DELETE RECORD";
            this.DELETE.UseVisualStyleBackColor = false;
            this.DELETE.Click += new System.EventHandler(this.DELETE_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Font = new System.Drawing.Font("Forte", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.Control;
            this.button2.Location = new System.Drawing.Point(325, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(37, 29);
            this.button2.TabIndex = 1;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.BackColor = System.Drawing.Color.Black;
            this.ID.Font = new System.Drawing.Font("Forte", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.ForeColor = System.Drawing.SystemColors.Control;
            this.ID.Location = new System.Drawing.Point(12, 80);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(91, 17);
            this.ID.TabIndex = 3;
            this.ID.Text = "ENTER ID";
            // 
            // BACK
            // 
            this.BACK.BackColor = System.Drawing.Color.Black;
            this.BACK.Font = new System.Drawing.Font("Forte", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BACK.ForeColor = System.Drawing.SystemColors.Control;
            this.BACK.Location = new System.Drawing.Point(12, 207);
            this.BACK.Name = "BACK";
            this.BACK.Size = new System.Drawing.Size(75, 27);
            this.BACK.TabIndex = 4;
            this.BACK.Text = "BACK";
            this.BACK.UseVisualStyleBackColor = false;
            this.BACK.Click += new System.EventHandler(this.BACK_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(109, 77);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(166, 20);
            this.textBox2.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Forte", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(120, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Record Deletion";
            // 
            // DeleteRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(372, 246);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.BACK);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.DELETE);
            this.Name = "DeleteRecord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeleteRecord";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DELETE;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Button BACK;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
    }
}