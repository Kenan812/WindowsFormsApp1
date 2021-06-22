namespace WindowsFormsApp1
{
    partial class Form1
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
            this.equationTextBox = new System.Windows.Forms.TextBox();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.num0 = new System.Windows.Forms.Button();
            this.num5 = new System.Windows.Forms.Button();
            this.num4 = new System.Windows.Forms.Button();
            this.num1 = new System.Windows.Forms.Button();
            this.num3 = new System.Windows.Forms.Button();
            this.num2 = new System.Windows.Forms.Button();
            this.num6 = new System.Windows.Forms.Button();
            this.num7 = new System.Windows.Forms.Button();
            this.num8 = new System.Windows.Forms.Button();
            this.num9 = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.sumButton = new System.Windows.Forms.Button();
            this.equalButton = new System.Windows.Forms.Button();
            this.minusButton = new System.Windows.Forms.Button();
            this.multButton = new System.Windows.Forms.Button();
            this.divideButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // equationTextBox
            // 
            this.equationTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.equationTextBox.Location = new System.Drawing.Point(37, 13);
            this.equationTextBox.Name = "equationTextBox";
            this.equationTextBox.Size = new System.Drawing.Size(266, 26);
            this.equationTextBox.TabIndex = 0;
            this.equationTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // resultTextBox
            // 
            this.resultTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resultTextBox.Location = new System.Drawing.Point(173, 56);
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.Size = new System.Drawing.Size(130, 26);
            this.resultTextBox.TabIndex = 1;
            this.resultTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // num0
            // 
            this.num0.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.num0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.num0.Location = new System.Drawing.Point(105, 290);
            this.num0.Name = "num0";
            this.num0.Size = new System.Drawing.Size(62, 59);
            this.num0.TabIndex = 2;
            this.num0.Text = "0";
            this.num0.UseVisualStyleBackColor = false;
            this.num0.Click += new System.EventHandler(this.SomeMethod);
            // 
            // num5
            // 
            this.num5.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.num5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.num5.Location = new System.Drawing.Point(105, 160);
            this.num5.Name = "num5";
            this.num5.Size = new System.Drawing.Size(62, 59);
            this.num5.TabIndex = 3;
            this.num5.Text = "5";
            this.num5.UseVisualStyleBackColor = false;
            this.num5.Click += new System.EventHandler(this.SomeMethod);
            // 
            // num4
            // 
            this.num4.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.num4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.num4.Location = new System.Drawing.Point(37, 160);
            this.num4.Name = "num4";
            this.num4.Size = new System.Drawing.Size(62, 59);
            this.num4.TabIndex = 4;
            this.num4.Text = "4";
            this.num4.UseVisualStyleBackColor = false;
            this.num4.Click += new System.EventHandler(this.SomeMethod);
            // 
            // num1
            // 
            this.num1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.num1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.num1.Location = new System.Drawing.Point(37, 225);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(62, 59);
            this.num1.TabIndex = 5;
            this.num1.Text = "1";
            this.num1.UseVisualStyleBackColor = false;
            this.num1.Click += new System.EventHandler(this.SomeMethod);
            // 
            // num3
            // 
            this.num3.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.num3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.num3.Location = new System.Drawing.Point(173, 225);
            this.num3.Name = "num3";
            this.num3.Size = new System.Drawing.Size(62, 59);
            this.num3.TabIndex = 6;
            this.num3.Text = "3";
            this.num3.UseVisualStyleBackColor = false;
            this.num3.Click += new System.EventHandler(this.SomeMethod);
            // 
            // num2
            // 
            this.num2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.num2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.num2.Location = new System.Drawing.Point(105, 225);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(62, 59);
            this.num2.TabIndex = 7;
            this.num2.Text = "2";
            this.num2.UseVisualStyleBackColor = false;
            this.num2.Click += new System.EventHandler(this.SomeMethod);
            // 
            // num6
            // 
            this.num6.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.num6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.num6.Location = new System.Drawing.Point(173, 160);
            this.num6.Name = "num6";
            this.num6.Size = new System.Drawing.Size(62, 59);
            this.num6.TabIndex = 8;
            this.num6.Text = "6";
            this.num6.UseVisualStyleBackColor = false;
            this.num6.Click += new System.EventHandler(this.SomeMethod);
            // 
            // num7
            // 
            this.num7.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.num7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.num7.Location = new System.Drawing.Point(37, 95);
            this.num7.Name = "num7";
            this.num7.Size = new System.Drawing.Size(62, 59);
            this.num7.TabIndex = 9;
            this.num7.Text = "7";
            this.num7.UseVisualStyleBackColor = false;
            this.num7.Click += new System.EventHandler(this.SomeMethod);
            // 
            // num8
            // 
            this.num8.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.num8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.num8.Location = new System.Drawing.Point(105, 95);
            this.num8.Name = "num8";
            this.num8.Size = new System.Drawing.Size(62, 59);
            this.num8.TabIndex = 10;
            this.num8.Text = "8";
            this.num8.UseVisualStyleBackColor = false;
            this.num8.Click += new System.EventHandler(this.SomeMethod);
            // 
            // num9
            // 
            this.num9.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.num9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.num9.Location = new System.Drawing.Point(173, 95);
            this.num9.Name = "num9";
            this.num9.Size = new System.Drawing.Size(62, 59);
            this.num9.TabIndex = 11;
            this.num9.Text = "9";
            this.num9.UseVisualStyleBackColor = false;
            this.num9.Click += new System.EventHandler(this.SomeMethod);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.MistyRose;
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clearButton.Location = new System.Drawing.Point(37, 290);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(62, 59);
            this.clearButton.TabIndex = 12;
            this.clearButton.Text = "C";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.SomeMethod);
            // 
            // sumButton
            // 
            this.sumButton.BackColor = System.Drawing.SystemColors.Info;
            this.sumButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sumButton.Location = new System.Drawing.Point(241, 290);
            this.sumButton.Name = "sumButton";
            this.sumButton.Size = new System.Drawing.Size(62, 59);
            this.sumButton.TabIndex = 13;
            this.sumButton.Text = "+";
            this.sumButton.UseVisualStyleBackColor = false;
            this.sumButton.Click += new System.EventHandler(this.SomeMethod);
            // 
            // equalButton
            // 
            this.equalButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.equalButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.equalButton.Location = new System.Drawing.Point(173, 290);
            this.equalButton.Name = "equalButton";
            this.equalButton.Size = new System.Drawing.Size(62, 59);
            this.equalButton.TabIndex = 14;
            this.equalButton.Text = "=";
            this.equalButton.UseVisualStyleBackColor = false;
            this.equalButton.Click += new System.EventHandler(this.SomeMethod);
            // 
            // minusButton
            // 
            this.minusButton.BackColor = System.Drawing.SystemColors.Info;
            this.minusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minusButton.Location = new System.Drawing.Point(241, 225);
            this.minusButton.Name = "minusButton";
            this.minusButton.Size = new System.Drawing.Size(62, 59);
            this.minusButton.TabIndex = 15;
            this.minusButton.Text = "-";
            this.minusButton.UseVisualStyleBackColor = false;
            this.minusButton.Click += new System.EventHandler(this.SomeMethod);
            // 
            // multButton
            // 
            this.multButton.BackColor = System.Drawing.SystemColors.Info;
            this.multButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.multButton.Location = new System.Drawing.Point(241, 160);
            this.multButton.Name = "multButton";
            this.multButton.Size = new System.Drawing.Size(62, 59);
            this.multButton.TabIndex = 16;
            this.multButton.Text = "x";
            this.multButton.UseVisualStyleBackColor = false;
            this.multButton.Click += new System.EventHandler(this.SomeMethod);
            // 
            // divideButton
            // 
            this.divideButton.BackColor = System.Drawing.SystemColors.Info;
            this.divideButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.divideButton.Location = new System.Drawing.Point(241, 95);
            this.divideButton.Name = "divideButton";
            this.divideButton.Size = new System.Drawing.Size(62, 59);
            this.divideButton.TabIndex = 17;
            this.divideButton.Text = "/";
            this.divideButton.UseVisualStyleBackColor = false;
            this.divideButton.Click += new System.EventHandler(this.SomeMethod);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 365);
            this.Controls.Add(this.divideButton);
            this.Controls.Add(this.multButton);
            this.Controls.Add(this.minusButton);
            this.Controls.Add(this.equalButton);
            this.Controls.Add(this.sumButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.num9);
            this.Controls.Add(this.num8);
            this.Controls.Add(this.num7);
            this.Controls.Add(this.num6);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.num3);
            this.Controls.Add(this.num1);
            this.Controls.Add(this.num4);
            this.Controls.Add(this.num5);
            this.Controls.Add(this.num0);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.equationTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox equationTextBox;
        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.Button num0;
        private System.Windows.Forms.Button num5;
        private System.Windows.Forms.Button num4;
        private System.Windows.Forms.Button num1;
        private System.Windows.Forms.Button num3;
        private System.Windows.Forms.Button num2;
        private System.Windows.Forms.Button num6;
        private System.Windows.Forms.Button num7;
        private System.Windows.Forms.Button num8;
        private System.Windows.Forms.Button num9;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button sumButton;
        private System.Windows.Forms.Button equalButton;
        private System.Windows.Forms.Button minusButton;
        private System.Windows.Forms.Button multButton;
        private System.Windows.Forms.Button divideButton;
    }
}

