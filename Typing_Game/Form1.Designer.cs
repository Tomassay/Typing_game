namespace Typing_Game
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt = new System.Windows.Forms.Label();
            this.errorsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(95, 395);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(228, 39);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.playGame);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Type the word below in the box";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "00";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txt
            // 
            this.txt.AutoSize = true;
            this.txt.Font = new System.Drawing.Font("Segoe UI", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt.ForeColor = System.Drawing.Color.SlateBlue;
            this.txt.Location = new System.Drawing.Point(95, 167);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(72, 42);
            this.txt.TabIndex = 3;
            this.txt.Text = "Text";
            this.txt.Click += new System.EventHandler(this.label3_Click);
            // 
            // errorsLabel
            // 
            this.errorsLabel.AutoSize = true;
            this.errorsLabel.Location = new System.Drawing.Point(343, 18);
            this.errorsLabel.Name = "errorsLabel";
            this.errorsLabel.Size = new System.Drawing.Size(19, 15);
            this.errorsLabel.TabIndex = 4;
            this.errorsLabel.Text = "00";
            this.errorsLabel.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(417, 502);
            this.Controls.Add(this.errorsLabel);
            this.Controls.Add(this.txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Typing Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private Label txt;
        private Label errorsLabel;
    }
}