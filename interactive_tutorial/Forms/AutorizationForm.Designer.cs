namespace interactive_tutorial
{
    partial class AutorizationForm
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
            loginTextBox = new TextBox();
            passwordTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            entranceButton = new Button();
            autorizationButton = new Button();
            SuspendLayout();
            // 
            // loginTextBox
            // 
            loginTextBox.Location = new Point(12, 57);
            loginTextBox.Name = "loginTextBox";
            loginTextBox.Size = new Size(212, 23);
            loginTextBox.TabIndex = 0;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(12, 138);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(212, 23);
            passwordTextBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 29);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 2;
            label1.Text = "Login";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 110);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // entranceButton
            // 
            entranceButton.Location = new Point(15, 231);
            entranceButton.Name = "entranceButton";
            entranceButton.Size = new Size(119, 97);
            entranceButton.TabIndex = 4;
            entranceButton.Text = "Вход";
            entranceButton.UseVisualStyleBackColor = true;
            entranceButton.Click += EntranceButton_Click;
            // 
            // autorizationButton
            // 
            autorizationButton.Location = new Point(195, 231);
            autorizationButton.Name = "autorizationButton";
            autorizationButton.Size = new Size(119, 97);
            autorizationButton.TabIndex = 5;
            autorizationButton.Text = "Авторизация";
            autorizationButton.UseVisualStyleBackColor = true;
            autorizationButton.Click += AutorizationButton_Click;
            // 
            // AutorizationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(411, 407);
            Controls.Add(autorizationButton);
            Controls.Add(entranceButton);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(passwordTextBox);
            Controls.Add(loginTextBox);
            Name = "AutorizationForm";
            Text = "AutorizationForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox loginTextBox;
        private TextBox passwordTextBox;
        private Label label1;
        private Label label2;
        private Button entranceButton;
        private Button autorizationButton;
    }
}