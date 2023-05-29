﻿namespace interactive_tutorial
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
            LoginTextBox=new TextBox();
            PasswordTextBox=new TextBox();
            label1=new Label();
            label2=new Label();
            EntranceButton=new Button();
            AutorizationButton=new Button();
            SuspendLayout();
            // 
            // LoginTextBox
            // 
            LoginTextBox.Location=new Point(12, 57);
            LoginTextBox.Name="LoginTextBox";
            LoginTextBox.Size=new Size(212, 23);
            LoginTextBox.TabIndex=0;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Location=new Point(12, 138);
            PasswordTextBox.Name="PasswordTextBox";
            PasswordTextBox.Size=new Size(212, 23);
            PasswordTextBox.TabIndex=1;
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.Location=new Point(12, 29);
            label1.Name="label1";
            label1.Size=new Size(37, 15);
            label1.TabIndex=2;
            label1.Text="Login";
            // 
            // label2
            // 
            label2.AutoSize=true;
            label2.Location=new Point(15, 110);
            label2.Name="label2";
            label2.Size=new Size(57, 15);
            label2.TabIndex=3;
            label2.Text="Password";
            // 
            // EntranceButton
            // 
            EntranceButton.Location=new Point(15, 231);
            EntranceButton.Name="EntranceButton";
            EntranceButton.Size=new Size(119, 97);
            EntranceButton.TabIndex=4;
            EntranceButton.Text="Вход";
            EntranceButton.UseVisualStyleBackColor=true;
            EntranceButton.Click+=EntranceButton_Click;
            // 
            // AutorizationButton
            // 
            AutorizationButton.Location=new Point(195, 231);
            AutorizationButton.Name="AutorizationButton";
            AutorizationButton.Size=new Size(119, 97);
            AutorizationButton.TabIndex=5;
            AutorizationButton.Text="Авторизация";
            AutorizationButton.UseVisualStyleBackColor=true;
            AutorizationButton.Click+=AutorizationButton_Click;
            // 
            // AutorizationForm
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(411, 407);
            Controls.Add(AutorizationButton);
            Controls.Add(EntranceButton);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(PasswordTextBox);
            Controls.Add(LoginTextBox);
            Name="AutorizationForm";
            Text="AutorizationForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox LoginTextBox;
        private TextBox PasswordTextBox;
        private Label label1;
        private Label label2;
        private Button EntranceButton;
        private Button AutorizationButton;
    }
}