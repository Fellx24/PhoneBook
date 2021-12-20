
namespace PhoneBook
{
    partial class loginForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.enterAsAdminButton = new System.Windows.Forms.Button();
            this.enterWithoutLoginButton = new System.Windows.Forms.Button();
            this.loginField = new System.Windows.Forms.RichTextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // enterAsAdminButton
            // 
            this.enterAsAdminButton.Location = new System.Drawing.Point(22, 101);
            this.enterAsAdminButton.Name = "enterAsAdminButton";
            this.enterAsAdminButton.Size = new System.Drawing.Size(121, 39);
            this.enterAsAdminButton.TabIndex = 0;
            this.enterAsAdminButton.Text = "Войти";
            this.enterAsAdminButton.UseVisualStyleBackColor = true;
            this.enterAsAdminButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // enterWithoutLoginButton
            // 
            this.enterWithoutLoginButton.Location = new System.Drawing.Point(166, 101);
            this.enterWithoutLoginButton.Name = "enterWithoutLoginButton";
            this.enterWithoutLoginButton.Size = new System.Drawing.Size(122, 39);
            this.enterWithoutLoginButton.TabIndex = 1;
            this.enterWithoutLoginButton.Text = "Просмотреть";
            this.enterWithoutLoginButton.UseVisualStyleBackColor = true;
            this.enterWithoutLoginButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // loginField
            // 
            this.loginField.Location = new System.Drawing.Point(22, 23);
            this.loginField.Name = "loginField";
            this.loginField.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.loginField.Size = new System.Drawing.Size(266, 20);
            this.loginField.TabIndex = 2;
            this.loginField.Text = "";
            this.loginField.Enter += new System.EventHandler(this.loginField_Enter);
            this.loginField.Leave += new System.EventHandler(this.loginField_Leave);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(22, 58);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(266, 20);
            this.maskedTextBox1.TabIndex = 2;
            // 
            // loginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 163);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.loginField);
            this.Controls.Add(this.enterWithoutLoginButton);
            this.Controls.Add(this.enterAsAdminButton);
            this.Name = "loginForm";
            this.Text = "Авторизация";
            this.Load += new System.EventHandler(this.loginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button enterAsAdminButton;
        private System.Windows.Forms.Button enterWithoutLoginButton;
        private System.Windows.Forms.RichTextBox loginField;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
    }
}

