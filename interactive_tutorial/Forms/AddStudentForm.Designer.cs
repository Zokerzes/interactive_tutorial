namespace interactive_tutorial.Forms
{
    partial class AddStudentForm
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
            addStudent_Button=new Button();
            addAbswer_Button=new Button();
            estimation_Button=new Button();
            name_TextBox=new TextBox();
            numericUpDown1=new NumericUpDown();
            numericUpDown2=new NumericUpDown();
            numericUpDown3=new NumericUpDown();
            topic_ComboBox=new ComboBox();
            selectedTopic_ListBox=new ListBox();
            label1=new Label();
            label2=new Label();
            label3=new Label();
            label4=new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            SuspendLayout();
            // 
            // addStudent_Button
            // 
            addStudent_Button.Location=new Point(26, 330);
            addStudent_Button.Name="addStudent_Button";
            addStudent_Button.Size=new Size(140, 55);
            addStudent_Button.TabIndex=0;
            addStudent_Button.Text="Добавить";
            addStudent_Button.UseVisualStyleBackColor=true;
            
            // 
            // addAbswer_Button
            // 
            addAbswer_Button.Location=new Point(329, 330);
            addAbswer_Button.Name="addAbswer_Button";
            addAbswer_Button.Size=new Size(140, 55);
            addAbswer_Button.TabIndex=1;
            addAbswer_Button.Text="Добавить ответ";
            addAbswer_Button.UseVisualStyleBackColor=true;
            // 
            // estimation_Button
            // 
            estimation_Button.Location=new Point(577, 330);
            estimation_Button.Name="estimation_Button";
            estimation_Button.Size=new Size(140, 55);
            estimation_Button.TabIndex=2;
            estimation_Button.Text="Оценка";
            estimation_Button.UseVisualStyleBackColor=true;
            // 
            // name_TextBox
            // 
            name_TextBox.Location=new Point(26, 71);
            name_TextBox.Name="name_TextBox";
            name_TextBox.Size=new Size(140, 23);
            name_TextBox.TabIndex=3;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location=new Point(26, 141);
            numericUpDown1.Name="numericUpDown1";
            numericUpDown1.Size=new Size(140, 23);
            numericUpDown1.TabIndex=4;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location=new Point(26, 204);
            numericUpDown2.Name="numericUpDown2";
            numericUpDown2.Size=new Size(140, 23);
            numericUpDown2.TabIndex=5;
            // 
            // numericUpDown3
            // 
            numericUpDown3.Location=new Point(26, 262);
            numericUpDown3.Name="numericUpDown3";
            numericUpDown3.Size=new Size(140, 23);
            numericUpDown3.TabIndex=6;
            // 
            // topic_ComboBox
            // 
            topic_ComboBox.DropDownStyle=ComboBoxStyle.DropDownList;
            topic_ComboBox.FormattingEnabled=true;
            topic_ComboBox.Items.AddRange(new object[] { "Формулы сокращенного умножения", "Логарифмические выражения", "Алгебраические уравнения" });
            topic_ComboBox.Location=new Point(231, 12);
            topic_ComboBox.Name="topic_ComboBox";
            topic_ComboBox.Size=new Size(151, 23);
            topic_ComboBox.TabIndex=7;
            // 
            // selectedTopic_ListBox
            // 
            selectedTopic_ListBox.FormattingEnabled=true;
            selectedTopic_ListBox.ItemHeight=15;
            selectedTopic_ListBox.Location=new Point(231, 75);
            selectedTopic_ListBox.Name="selectedTopic_ListBox";
            selectedTopic_ListBox.Size=new Size(486, 244);
            selectedTopic_ListBox.TabIndex=8;
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.Location=new Point(26, 39);
            label1.Name="label1";
            label1.Size=new Size(37, 15);
            label1.TabIndex=9;
            label1.Text="name";
            // 
            // label2
            // 
            label2.AutoSize=true;
            label2.Location=new Point(27, 123);
            label2.Name="label2";
            label2.Size=new Size(33, 15);
            label2.TabIndex=10;
            label2.Text="Time";
            // 
            // label3
            // 
            label3.AutoSize=true;
            label3.Location=new Point(27, 186);
            label3.Name="label3";
            label3.Size=new Size(94, 15);
            label3.TabIndex=11;
            label3.Text="Номер вопроса";
            // 
            // label4
            // 
            label4.AutoSize=true;
            label4.Location=new Point(27, 244);
            label4.Name="label4";
            label4.Size=new Size(76, 15);
            label4.TabIndex=12;
            label4.Text="Номер теста";
            // 
            // AddStudentForm
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(selectedTopic_ListBox);
            Controls.Add(topic_ComboBox);
            Controls.Add(numericUpDown3);
            Controls.Add(numericUpDown2);
            Controls.Add(numericUpDown1);
            Controls.Add(name_TextBox);
            Controls.Add(estimation_Button);
            Controls.Add(addAbswer_Button);
            Controls.Add(addStudent_Button);
            Name="AddStudentForm";
            Text="AddStudentForm";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button addStudent_Button;
        private Button addAbswer_Button;
        private Button estimation_Button;
        private TextBox name_TextBox;
        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown2;
        private NumericUpDown numericUpDown3;
        private ComboBox topic_ComboBox;
        private ListBox selectedTopic_ListBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}