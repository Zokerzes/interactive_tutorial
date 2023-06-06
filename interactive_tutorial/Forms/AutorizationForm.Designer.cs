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
            login_TextBox=new TextBox();
            password_TextBox=new TextBox();
            label1=new Label();
            label2=new Label();
            entranceButton=new Button();
            autorizationButton=new Button();
            Email_TextBox=new TextBox();
            label3=new Label();
            PhoneNumber_TextBox=new TextBox();
            label4=new Label();
            userRole_ComboBox=new ComboBox();
            LastName_TextBox=new TextBox();
            FirstName_TextBox=new TextBox();
            label5=new Label();
            label6=new Label();
            SuspendLayout();
            // 
            // login_TextBox
            // 
            login_TextBox.Location=new Point(2, 148);
            login_TextBox.Name="login_TextBox";
            login_TextBox.Size=new Size(212, 23);
            login_TextBox.TabIndex=0;
            // 
            // password_TextBox
            // 
            password_TextBox.Location=new Point(2, 192);
            password_TextBox.Name="password_TextBox";
            password_TextBox.Size=new Size(212, 23);
            password_TextBox.TabIndex=1;
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.Location=new Point(2, 117);
            label1.Name="label1";
            label1.Size=new Size(37, 15);
            label1.TabIndex=2;
            label1.Text="Login";
            // 
            // label2
            // 
            label2.AutoSize=true;
            label2.Location=new Point(2, 174);
            label2.Name="label2";
            label2.Size=new Size(57, 15);
            label2.TabIndex=3;
            label2.Text="Password";
            // 
            // entranceButton
            // 
            entranceButton.Location=new Point(12, 393);
            entranceButton.Name="entranceButton";
            entranceButton.Size=new Size(119, 97);
            entranceButton.TabIndex=4;
            entranceButton.Text="Вход";
            entranceButton.UseVisualStyleBackColor=true;
            entranceButton.Click+=EntranceButton_Click;
            // 
            // autorizationButton
            // 
            autorizationButton.Location=new Point(193, 393);
            autorizationButton.Name="autorizationButton";
            autorizationButton.Size=new Size(119, 97);
            autorizationButton.TabIndex=5;
            autorizationButton.Text="Авторизация";
            autorizationButton.UseVisualStyleBackColor=true;
            // 
            // Email_TextBox
            // 
            Email_TextBox.Location=new Point(3, 249);
            Email_TextBox.Name="Email_TextBox";
            Email_TextBox.Size=new Size(212, 23);
            Email_TextBox.TabIndex=6;
            // 
            // label3
            // 
            label3.AutoSize=true;
            label3.Location=new Point(12, 218);
            label3.Name="label3";
            label3.Size=new Size(41, 15);
            label3.TabIndex=7;
            label3.Text="E-mail";
            // 
            // PhoneNumber_TextBox
            // 
            PhoneNumber_TextBox.Location=new Point(3, 332);
            PhoneNumber_TextBox.Name="PhoneNumber_TextBox";
            PhoneNumber_TextBox.Size=new Size(212, 23);
            PhoneNumber_TextBox.TabIndex=8;
            // 
            // label4
            // 
            label4.AutoSize=true;
            label4.Location=new Point(3, 291);
            label4.Name="label4";
            label4.Size=new Size(101, 15);
            label4.TabIndex=9;
            label4.Text="Номер телефона";
            // 
            // userRole_ComboBox
            // 
            userRole_ComboBox.DropDownStyle=ComboBoxStyle.DropDownList;
            userRole_ComboBox.FormattingEnabled=true;
            userRole_ComboBox.Items.AddRange(new object[] { "Admin,", "Manager,", "Student" });
            userRole_ComboBox.Location=new Point(265, 39);
            userRole_ComboBox.Name="userRole_ComboBox";
            userRole_ComboBox.Size=new Size(134, 23);
            userRole_ComboBox.TabIndex=10;
            // 
            // LastName_TextBox
            // 
            LastName_TextBox.Location=new Point(2, 91);
            LastName_TextBox.Name="LastName_TextBox";
            LastName_TextBox.Size=new Size(212, 23);
            LastName_TextBox.TabIndex=11;
            // 
            // FirstName_TextBox
            // 
            FirstName_TextBox.Location=new Point(2, 38);
            FirstName_TextBox.Name="FirstName_TextBox";
            FirstName_TextBox.Size=new Size(212, 23);
            FirstName_TextBox.TabIndex=12;
            // 
            // label5
            // 
            label5.AutoSize=true;
            label5.Location=new Point(0, 20);
            label5.Name="label5";
            label5.Size=new Size(39, 15);
            label5.TabIndex=13;
            label5.Text="Name";
            // 
            // label6
            // 
            label6.AutoSize=true;
            label6.Location=new Point(2, 64);
            label6.Name="label6";
            label6.Size=new Size(28, 15);
            label6.TabIndex=14;
            label6.Text="Last";
            // 
            // AutorizationForm
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(520, 565);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(FirstName_TextBox);
            Controls.Add(LastName_TextBox);
            Controls.Add(userRole_ComboBox);
            Controls.Add(label4);
            Controls.Add(PhoneNumber_TextBox);
            Controls.Add(label3);
            Controls.Add(Email_TextBox);
            Controls.Add(autorizationButton);
            Controls.Add(entranceButton);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(password_TextBox);
            Controls.Add(login_TextBox);
            Name="AutorizationForm";
            Text="AutorizationForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox login_TextBox;
        private TextBox password_TextBox;
        private Label label1;
        private Label label2;
        private Button entranceButton;
        private Button autorizationButton;
        private TextBox Email_TextBox;
        private Label label3;
        private TextBox PhoneNumber_TextBox;
        private Label label4;
        private ComboBox userRole_ComboBox;
        private TextBox LastName_TextBox;
        private TextBox FirstName_TextBox;
        private Label label5;
        private Label label6;
    }
}