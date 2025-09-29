namespace WinFormsApp1
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
            openFileDialog1 = new OpenFileDialog();
            button3 = new Button();
            btPaste = new Button();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Highlight;
            button1.Location = new Point(26, 25);
            button1.Margin = new Padding(6);
            button1.Name = "button1";
            button1.Size = new Size(55, 66);
            button1.TabIndex = 1;
            button1.Text = "^";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.Highlight;
            button2.Location = new Point(26, 102);
            button2.Margin = new Padding(6);
            button2.Name = "button2";
            button2.Size = new Size(55, 66);
            button2.TabIndex = 3;
            button2.Text = "v";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // button3
            // 
            button3.BackColor = SystemColors.Highlight;
            button3.Location = new Point(26, 295);
            button3.Margin = new Padding(6);
            button3.Name = "button3";
            button3.Size = new Size(55, 66);
            button3.TabIndex = 4;
            button3.Text = "...";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // btPaste
            // 
            btPaste.BackColor = SystemColors.Highlight;
            btPaste.Location = new Point(26, 405);
            btPaste.Margin = new Padding(6);
            btPaste.Name = "btPaste";
            btPaste.Size = new Size(55, 66);
            btPaste.TabIndex = 5;
            btPaste.Text = "P";
            btPaste.UseVisualStyleBackColor = false;
            btPaste.Click += btPaste_Click;
            // 
            // panel1
            // 
            panel1.Location = new Point(2507, 1298);
            panel1.Name = "panel1";
            panel1.Size = new Size(500, 250);
            panel1.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1746, 1007);
            Controls.Add(panel1);
            Controls.Add(btPaste);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Margin = new Padding(6);
            Name = "Form1";
            Text = "Light Table V2.00";
            Load += Form1_Load;
            Resize += Form1_Resize;
            ResumeLayout(false);

        }

        #endregion
        private Button button1;
        private Button button2;
        private OpenFileDialog openFileDialog1;
        private Button button3;
        private Button btPaste;
        private Panel panel1;
    }
}