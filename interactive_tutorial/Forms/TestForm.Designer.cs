namespace interactive_tutorial
{
    partial class TestForm
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
            groupBox_q1 = new GroupBox();
            q1 = new Label();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            btn_test = new Button();
            groupBox_q1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox_q1
            // 
            groupBox_q1.Controls.Add(q1);
            groupBox_q1.Controls.Add(radioButton3);
            groupBox_q1.Controls.Add(radioButton2);
            groupBox_q1.Controls.Add(radioButton1);
            groupBox_q1.Location = new Point(12, 12);
            groupBox_q1.Name = "groupBox_q1";
            groupBox_q1.Size = new Size(239, 168);
            groupBox_q1.TabIndex = 0;
            groupBox_q1.TabStop = false;
            // 
            // q1
            // 
            q1.AutoSize = true;
            q1.Location = new Point(15, 19);
            q1.Name = "q1";
            q1.Size = new Size(56, 15);
            q1.TabIndex = 2;
            q1.Text = "вопрос 1";
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(15, 134);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(65, 19);
            radioButton3.TabIndex = 1;
            radioButton3.TabStop = true;
            radioButton3.Text = "ответ_3";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(15, 109);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(65, 19);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "ответ_2";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(15, 84);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(65, 19);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "ответ_1";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // btn_test
            // 
            btn_test.BackgroundImageLayout = ImageLayout.None;
            btn_test.Location = new Point(15, 195);
            btn_test.Name = "btn_test";
            btn_test.Size = new Size(75, 23);
            btn_test.TabIndex = 1;
            btn_test.Text = "test";
            btn_test.UseVisualStyleBackColor = true;
            btn_test.Click += btn_test_Click;
            // 
            // TestForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_test);
            Controls.Add(groupBox_q1);
            Name = "TestForm";
            Text = "TestForm";
            Load += TestForm_Load;
            groupBox_q1.ResumeLayout(false);
            groupBox_q1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox_q1;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Label q1;
        private Button btn_test;
    }
}