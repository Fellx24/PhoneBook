
namespace PhoneBook
{
    partial class tableForm
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.citynumberTB = new System.Windows.Forms.TextBox();
            this.cabTB = new System.Windows.Forms.TextBox();
            this.postTB = new System.Windows.Forms.TextBox();
            this.adressTB = new System.Windows.Forms.TextBox();
            this.surnameTB = new System.Windows.Forms.TextBox();
            this.fathernameTB = new System.Windows.Forms.TextBox();
            this.nameTB = new System.Windows.Forms.TextBox();
            this.greetingsText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(22, 27);
            this.listBox1.Margin = new System.Windows.Forms.Padding(0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(332, 303);
            this.listBox1.TabIndex = 0;
            // 
            // citynumberTB
            // 
            this.citynumberTB.Location = new System.Drawing.Point(378, 258);
            this.citynumberTB.Name = "citynumberTB";
            this.citynumberTB.ReadOnly = true;
            this.citynumberTB.Size = new System.Drawing.Size(319, 20);
            this.citynumberTB.TabIndex = 6;
            // 
            // cabTB
            // 
            this.cabTB.Location = new System.Drawing.Point(378, 218);
            this.cabTB.Name = "cabTB";
            this.cabTB.ReadOnly = true;
            this.cabTB.Size = new System.Drawing.Size(319, 20);
            this.cabTB.TabIndex = 5;
            // 
            // postTB
            // 
            this.postTB.Location = new System.Drawing.Point(378, 297);
            this.postTB.Name = "postTB";
            this.postTB.ReadOnly = true;
            this.postTB.Size = new System.Drawing.Size(319, 20);
            this.postTB.TabIndex = 7;
            // 
            // adressTB
            // 
            this.adressTB.Location = new System.Drawing.Point(378, 178);
            this.adressTB.Name = "adressTB";
            this.adressTB.ReadOnly = true;
            this.adressTB.Size = new System.Drawing.Size(319, 20);
            this.adressTB.TabIndex = 4;
            // 
            // surnameTB
            // 
            this.surnameTB.Location = new System.Drawing.Point(378, 98);
            this.surnameTB.Name = "surnameTB";
            this.surnameTB.ReadOnly = true;
            this.surnameTB.Size = new System.Drawing.Size(319, 20);
            this.surnameTB.TabIndex = 2;
            // 
            // fathernameTB
            // 
            this.fathernameTB.Location = new System.Drawing.Point(378, 138);
            this.fathernameTB.Name = "fathernameTB";
            this.fathernameTB.ReadOnly = true;
            this.fathernameTB.Size = new System.Drawing.Size(319, 20);
            this.fathernameTB.TabIndex = 3;
            // 
            // nameTB
            // 
            this.nameTB.Location = new System.Drawing.Point(378, 58);
            this.nameTB.Name = "nameTB";
            this.nameTB.ReadOnly = true;
            this.nameTB.Size = new System.Drawing.Size(319, 20);
            this.nameTB.TabIndex = 1;
            // 
            // greetingsText
            // 
            this.greetingsText.AutoSize = true;
            this.greetingsText.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.greetingsText.Location = new System.Drawing.Point(496, 22);
            this.greetingsText.Name = "greetingsText";
            this.greetingsText.Size = new System.Drawing.Size(90, 20);
            this.greetingsText.TabIndex = 8;
            this.greetingsText.Text = "greetingsText";
            // 
            // tableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 354);
            this.Controls.Add(this.greetingsText);
            this.Controls.Add(this.nameTB);
            this.Controls.Add(this.fathernameTB);
            this.Controls.Add(this.surnameTB);
            this.Controls.Add(this.adressTB);
            this.Controls.Add(this.postTB);
            this.Controls.Add(this.cabTB);
            this.Controls.Add(this.citynumberTB);
            this.Controls.Add(this.listBox1);
            this.Name = "tableForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.tableForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox citynumberTB;
        private System.Windows.Forms.TextBox cabTB;
        private System.Windows.Forms.TextBox postTB;
        private System.Windows.Forms.TextBox adressTB;
        private System.Windows.Forms.TextBox surnameTB;
        private System.Windows.Forms.TextBox fathernameTB;
        private System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.Label greetingsText;
    }
}