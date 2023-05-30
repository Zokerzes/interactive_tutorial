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
            numberTestNumericUpDown = new NumericUpDown();
            nameTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)numberTestNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // numberTestNumericUpDown
            // 
            numberTestNumericUpDown.Location = new Point(12, 120);
            numberTestNumericUpDown.Name = "numberTestNumericUpDown";
            numberTestNumericUpDown.Size = new Size(168, 23);
            numberTestNumericUpDown.TabIndex = 0;
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(12, 47);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(168, 23);
            nameTextBox.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 29);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 4;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 102);
            label2.Name = "label2";
            label2.Size = new Size(76, 15);
            label2.TabIndex = 5;
            label2.Text = "Номер теста";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(257, 29);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(484, 307);
            dataGridView1.TabIndex = 6;
            // 
            // TestForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(nameTextBox);
            Controls.Add(numberTestNumericUpDown);
            Name = "TestForm";
            Text = "TestForm";
            ((System.ComponentModel.ISupportInitialize)numberTestNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown numberTestNumericUpDown;
        private TextBox nameTextBox;
        private Label label1;
        private Label label2;
        private DataGridView dataGridView1;
    }
}