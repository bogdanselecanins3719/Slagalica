namespace Slagalica
{
    partial class Form7
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
            label1 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            button3 = new Button();
            button2 = new Button();
            button4 = new Button();
            button5 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(300, 9);
            label1.Name = "label1";
            label1.Size = new Size(215, 46);
            label1.TabIndex = 0;
            label1.Text = "KO ZNA ZNA";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ButtonFace;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(72, 68);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(648, 104);
            textBox1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(72, 221);
            button1.Name = "button1";
            button1.Size = new Size(259, 39);
            button1.TabIndex = 2;
            button1.Text = "ODG 1";
            button1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(72, 297);
            button3.Name = "button3";
            button3.Size = new Size(259, 41);
            button3.TabIndex = 4;
            button3.Text = "ODG 3";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(461, 221);
            button2.Name = "button2";
            button2.Size = new Size(259, 39);
            button2.TabIndex = 5;
            button2.Text = "ODG 2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(461, 297);
            button4.Name = "button4";
            button4.Size = new Size(259, 39);
            button4.TabIndex = 6;
            button4.Text = "ODG 4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(658, 394);
            button5.Name = "button5";
            button5.Size = new Size(130, 44);
            button5.TabIndex = 17;
            button5.Text = "SLEDECA IGRA";
            button5.UseVisualStyleBackColor = true;
            // 
            // Form7
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Highlight;
            ClientSize = new Size(800, 450);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form7";
            Text = "Ko Zna Zna";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private Button button3;
        private Button button2;
        private Button button4;
        private Button button5;
    }
}