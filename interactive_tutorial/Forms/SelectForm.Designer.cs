namespace interactive_tutorial.Forms
{
    partial class SelectForm
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
            manager_Button=new Button();
            Autorization_Button=new Button();
            Test_Button=new Button();
            SuspendLayout();
            // 
            // manager_Button
            // 
            manager_Button.Location=new Point(86, 12);
            manager_Button.Name="manager_Button";
            manager_Button.Size=new Size(283, 112);
            manager_Button.TabIndex=0;
            manager_Button.Text="Manager";
            manager_Button.UseVisualStyleBackColor=true;
            manager_Button.Click+=manager_Button_Click;
            // 
            // Autorization_Button
            // 
            Autorization_Button.Location=new Point(86, 139);
            Autorization_Button.Name="Autorization_Button";
            Autorization_Button.Size=new Size(283, 112);
            Autorization_Button.TabIndex=1;
            Autorization_Button.Text="Авторизация";
            Autorization_Button.UseVisualStyleBackColor=true;
            Autorization_Button.Click+=Autorization_Button_Click;
            // 
            // Test_Button
            // 
            Test_Button.Location=new Point(86, 257);
            Test_Button.Name="Test_Button";
            Test_Button.Size=new Size(283, 112);
            Test_Button.TabIndex=2;
            Test_Button.Text="Test";
            Test_Button.UseVisualStyleBackColor=true;
            Test_Button.Click+=Test_Button_Click;
            // 
            // SelectForm
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(499, 390);
            Controls.Add(Test_Button);
            Controls.Add(Autorization_Button);
            Controls.Add(manager_Button);
            Name="SelectForm";
            Text="SelectForm";
            ResumeLayout(false);
        }

        #endregion

        private Button manager_Button;
        private Button Autorization_Button;
        private Button Test_Button;
    }
}