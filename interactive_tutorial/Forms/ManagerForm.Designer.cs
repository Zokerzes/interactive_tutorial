namespace interactive_tutorial
{
    partial class ManagerForm
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
            button1=new Button();
            changeRate_Button2=new Button();
            button3=new Button();
            topicMathematik_ListBox=new ListBox();
            listView1=new ListView();
            employeeRate_NumericUpDown=new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)employeeRate_NumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location=new Point(194, 320);
            button1.Name="button1";
            button1.Size=new Size(122, 68);
            button1.TabIndex=0;
            button1.Text="Back";
            button1.UseVisualStyleBackColor=true;
            // 
            // changeRate_Button2
            // 
            changeRate_Button2.Location=new Point(421, 320);
            changeRate_Button2.Name="changeRate_Button2";
            changeRate_Button2.Size=new Size(122, 68);
            changeRate_Button2.TabIndex=1;
            changeRate_Button2.Text="Rate";
            changeRate_Button2.UseVisualStyleBackColor=true;
            changeRate_Button2.Click+=changeRate_Button2_Click;
            // 
            // button3
            // 
            button3.Location=new Point(646, 320);
            button3.Name="button3";
            button3.Size=new Size(122, 68);
            button3.TabIndex=2;
            button3.Text="Save";
            button3.UseVisualStyleBackColor=true;
            // 
            // topicMathematik_ListBox
            // 
            topicMathematik_ListBox.FormattingEnabled=true;
            topicMathematik_ListBox.ItemHeight=15;
            topicMathematik_ListBox.Location=new Point(12, 119);
            topicMathematik_ListBox.Name="topicMathematik_ListBox";
            topicMathematik_ListBox.Size=new Size(143, 289);
            topicMathematik_ListBox.TabIndex=3;
            // 
            // listView1
            // 
            listView1.Location=new Point(194, 12);
            listView1.Name="listView1";
            listView1.Size=new Size(574, 286);
            listView1.TabIndex=4;
            listView1.UseCompatibleStateImageBehavior=false;
            // 
            // employeeRate_NumericUpDown
            // 
            employeeRate_NumericUpDown.Location=new Point(12, 29);
            employeeRate_NumericUpDown.Name="employeeRate_NumericUpDown";
            employeeRate_NumericUpDown.Size=new Size(120, 23);
            employeeRate_NumericUpDown.TabIndex=5;
            // 
            // ManagerForm
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(800, 450);
            Controls.Add(employeeRate_NumericUpDown);
            Controls.Add(listView1);
            Controls.Add(topicMathematik_ListBox);
            Controls.Add(button3);
            Controls.Add(changeRate_Button2);
            Controls.Add(button1);
            Name="ManagerForm";
            Text="ManagerForm";
            ((System.ComponentModel.ISupportInitialize)employeeRate_NumericUpDown).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button changeRate_Button2;
        private Button button3;
        private ListBox topicMathematik_ListBox;
        private ListView listView1;
        private NumericUpDown employeeRate_NumericUpDown;
    }
}