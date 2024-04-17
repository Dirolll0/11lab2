namespace _11alb2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button6 = new Button();
            destinationTextBox = new TextBox();
            trainsTextBox = new RichTextBox();
            sortedTrainsTextBox = new RichTextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 372);
            button1.Name = "button1";
            button1.Size = new Size(107, 37);
            button1.TabIndex = 0;
            button1.Text = "Открыть";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(125, 372);
            button2.Name = "button2";
            button2.Size = new Size(107, 37);
            button2.TabIndex = 1;
            button2.Text = "Генерация";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(238, 372);
            button3.Name = "button3";
            button3.Size = new Size(107, 37);
            button3.TabIndex = 2;
            button3.Text = "Очистить";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(683, 372);
            button4.Name = "button4";
            button4.Size = new Size(107, 37);
            button4.TabIndex = 3;
            button4.Text = "Фильтрация";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button6
            // 
            button6.Location = new Point(351, 372);
            button6.Name = "button6";
            button6.Size = new Size(107, 37);
            button6.TabIndex = 5;
            button6.Text = "Сортировать";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // destinationTextBox
            // 
            destinationTextBox.Location = new Point(471, 372);
            destinationTextBox.Multiline = true;
            destinationTextBox.Name = "destinationTextBox";
            destinationTextBox.Size = new Size(206, 37);
            destinationTextBox.TabIndex = 6;
            destinationTextBox.TextChanged += destinationTextBox_TextChanged;
            // 
            // trainsTextBox
            // 
            trainsTextBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            trainsTextBox.Location = new Point(12, 12);
            trainsTextBox.Name = "trainsTextBox";
            trainsTextBox.ScrollBars = RichTextBoxScrollBars.Vertical;
            trainsTextBox.Size = new Size(446, 345);
            trainsTextBox.TabIndex = 7;
            trainsTextBox.Text = "";
            trainsTextBox.TextChanged += trainsTextBox_TextChanged;
            // 
            // sortedTrainsTextBox
            // 
            sortedTrainsTextBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            sortedTrainsTextBox.Location = new Point(471, 12);
            sortedTrainsTextBox.Name = "sortedTrainsTextBox";
            sortedTrainsTextBox.ScrollBars = RichTextBoxScrollBars.Vertical;
            sortedTrainsTextBox.Size = new Size(317, 345);
            sortedTrainsTextBox.TabIndex = 8;
            sortedTrainsTextBox.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(sortedTrainsTextBox);
            Controls.Add(trainsTextBox);
            Controls.Add(destinationTextBox);
            Controls.Add(button6);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Поезда";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button6;
        private TextBox destinationTextBox;
        private RichTextBox trainsTextBox;
        private RichTextBox sortedTrainsTextBox;
    }
}
