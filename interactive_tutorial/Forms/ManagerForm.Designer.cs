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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerForm));
            TextElement_NumericUpDown=new NumericUpDown();
            button1=new Button();
            label4=new Label();
            textBox1=new TextBox();
            ((System.ComponentModel.ISupportInitialize)TextElement_NumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // TextElement_NumericUpDown
            // 
            TextElement_NumericUpDown.Location=new Point(12, 41);
            TextElement_NumericUpDown.Name="TextElement_NumericUpDown";
            TextElement_NumericUpDown.Size=new Size(157, 23);
            TextElement_NumericUpDown.TabIndex=5;
            TextElement_NumericUpDown.ValueChanged+=employeeRate_NumericUpDown_ValueChanged;
            // 
            // button1
            // 
            button1.Location=new Point(321, 456);
            button1.Name="button1";
            button1.Size=new Size(593, 113);
            button1.TabIndex=6;
            button1.Text="TestForm";
            button1.UseVisualStyleBackColor=true;
            // 
            // label4
            // 
            label4.AutoSize=true;
            label4.Location=new Point(12, 12);
            label4.Name="label4";
            label4.Size=new Size(102, 15);
            label4.TabIndex=13;
            label4.Text="Номер страницы";
            // 
            // textBox1
            // 
            textBox1.Location=new Point(321, 41);
            textBox1.Multiline=true;
            textBox1.Name="textBox1";
            textBox1.Size=new Size(593, 395);
            textBox1.TabIndex=14;
            textBox1.Text=resources.GetString("textBox1.Text");
            // 
            // ManagerForm
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(983, 597);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(TextElement_NumericUpDown);
            Name="ManagerForm";
            Text="ManagerForm";
            ((System.ComponentModel.ISupportInitialize)TextElement_NumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private NumericUpDown TextElement_NumericUpDown;
        private Button button1;
        private Label label4;
        private TextBox textBox1;
    }
}