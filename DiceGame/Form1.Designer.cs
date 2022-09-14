namespace DiceGame
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
            this.DiceTextBox1 = new System.Windows.Forms.TextBox();
            this.DiceButton1 = new System.Windows.Forms.Button();
            this.Dice1Box = new System.Windows.Forms.GroupBox();
            this.Dice2Box = new System.Windows.Forms.GroupBox();
            this.DicetextBox2 = new System.Windows.Forms.TextBox();
            this.DiceButton2 = new System.Windows.Forms.Button();
            this.Dice1Box.SuspendLayout();
            this.Dice2Box.SuspendLayout();
            this.SuspendLayout();
            // 
            // DiceTextBox1
            // 
            this.DiceTextBox1.Location = new System.Drawing.Point(49, 22);
            this.DiceTextBox1.Name = "DiceTextBox1";
            this.DiceTextBox1.ReadOnly = true;
            this.DiceTextBox1.Size = new System.Drawing.Size(100, 23);
            this.DiceTextBox1.TabIndex = 0;
            this.DiceTextBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // DiceButton1
            // 
            this.DiceButton1.Location = new System.Drawing.Point(49, 71);
            this.DiceButton1.Name = "DiceButton1";
            this.DiceButton1.Size = new System.Drawing.Size(75, 23);
            this.DiceButton1.TabIndex = 1;
            this.DiceButton1.Text = "Roll 6";
            this.DiceButton1.UseVisualStyleBackColor = true;
            this.DiceButton1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Dice1Box
            // 
            this.Dice1Box.Controls.Add(this.DiceTextBox1);
            this.Dice1Box.Controls.Add(this.DiceButton1);
            this.Dice1Box.Location = new System.Drawing.Point(12, 12);
            this.Dice1Box.Name = "Dice1Box";
            this.Dice1Box.Size = new System.Drawing.Size(200, 100);
            this.Dice1Box.TabIndex = 2;
            this.Dice1Box.TabStop = false;
            this.Dice1Box.Text = "Dice 1";
            this.Dice1Box.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Dice2Box
            // 
            this.Dice2Box.Controls.Add(this.DiceButton2);
            this.Dice2Box.Controls.Add(this.DicetextBox2);
            this.Dice2Box.Location = new System.Drawing.Point(218, 12);
            this.Dice2Box.Name = "Dice2Box";
            this.Dice2Box.Size = new System.Drawing.Size(200, 100);
            this.Dice2Box.TabIndex = 3;
            this.Dice2Box.TabStop = false;
            this.Dice2Box.Text = "Dice 2";
            this.Dice2Box.Enter += new System.EventHandler(this.Dice2Box_Enter);
            // 
            // DicetextBox2
            // 
            this.DicetextBox2.Location = new System.Drawing.Point(50, 22);
            this.DicetextBox2.Name = "DicetextBox2";
            this.DicetextBox2.ReadOnly = true;
            this.DicetextBox2.Size = new System.Drawing.Size(100, 23);
            this.DicetextBox2.TabIndex = 0;
            this.DicetextBox2.TextChanged += new System.EventHandler(this.DicetextBox2_TextChanged);
            // 
            // DiceButton2
            // 
            this.DiceButton2.Location = new System.Drawing.Point(50, 71);
            this.DiceButton2.Name = "DiceButton2";
            this.DiceButton2.Size = new System.Drawing.Size(75, 23);
            this.DiceButton2.TabIndex = 1;
            this.DiceButton2.Text = "Roll 10";
            this.DiceButton2.UseVisualStyleBackColor = true;
            this.DiceButton2.Click += new System.EventHandler(this.DiceButton2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Dice2Box);
            this.Controls.Add(this.Dice1Box);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Dice1Box.ResumeLayout(false);
            this.Dice1Box.PerformLayout();
            this.Dice2Box.ResumeLayout(false);
            this.Dice2Box.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TextBox DiceTextBox1;
        private Button DiceButton1;
        private GroupBox Dice1Box;
        private GroupBox Dice2Box;
        private Button DiceButton2;
        private TextBox DicetextBox2;
    }
}