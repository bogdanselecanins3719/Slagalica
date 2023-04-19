namespace Slagalica
{
    partial class Form3
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(257, 9);
            label1.Name = "label1";
            label1.Size = new Size(254, 46);
            label1.TabIndex = 0;
            label1.Text = "IZABERITE IGRU";
            // 
            // button1
            // 
            button1.Location = new Point(267, 91);
            button1.Name = "button1";
            button1.Size = new Size(225, 41);
            button1.TabIndex = 1;
            button1.Text = "SLAGALICA";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(267, 160);
            button2.Name = "button2";
            button2.Size = new Size(225, 43);
            button2.TabIndex = 2;
            button2.Text = "MOJ BROJ";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(267, 235);
            button3.Name = "button3";
            button3.Size = new Size(225, 44);
            button3.TabIndex = 3;
            button3.Text = "SKOCKO";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(267, 310);
            button4.Name = "button4";
            button4.Size = new Size(225, 40);
            button4.TabIndex = 4;
            button4.Text = "KO ZNA ZNA";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(267, 383);
            button5.Name = "button5";
            button5.Size = new Size(225, 41);
            button5.TabIndex = 5;
            button5.Text = "ASOCIJACIJE";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(12, 392);
            button6.Name = "button6";
            button6.Size = new Size(71, 32);
            button6.TabIndex = 6;
            button6.Text = "Nazad";
            button6.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Highlight;
            ClientSize = new Size(800, 450);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Lista igara";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
    }
}