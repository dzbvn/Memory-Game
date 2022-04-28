
namespace Task1_Memory_Game
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownStartVisibility = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDownClickVisibility = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMemorySize = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStartVisibility)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownClickVisibility)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMemorySize)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(69, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Memory Game";
            // 
            // numericUpDownStartVisibility
            // 
            this.numericUpDownStartVisibility.Location = new System.Drawing.Point(183, 210);
            this.numericUpDownStartVisibility.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.numericUpDownStartVisibility.Name = "numericUpDownStartVisibility";
            this.numericUpDownStartVisibility.ReadOnly = true;
            this.numericUpDownStartVisibility.Size = new System.Drawing.Size(49, 20);
            this.numericUpDownStartVisibility.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Amount of cards:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(34, 304);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Start game";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(157, 304);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Leaderbord";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Visibility after start:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Visibility after click:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // numericUpDownClickVisibility
            // 
            this.numericUpDownClickVisibility.DecimalPlaces = 1;
            this.numericUpDownClickVisibility.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numericUpDownClickVisibility.Location = new System.Drawing.Point(183, 244);
            this.numericUpDownClickVisibility.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownClickVisibility.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numericUpDownClickVisibility.Name = "numericUpDownClickVisibility";
            this.numericUpDownClickVisibility.ReadOnly = true;
            this.numericUpDownClickVisibility.Size = new System.Drawing.Size(49, 20);
            this.numericUpDownClickVisibility.TabIndex = 7;
            this.numericUpDownClickVisibility.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // numericUpDownMemorySize
            // 
            this.numericUpDownMemorySize.Increment = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDownMemorySize.Location = new System.Drawing.Point(183, 175);
            this.numericUpDownMemorySize.Maximum = new decimal(new int[] {
            128,
            0,
            0,
            0});
            this.numericUpDownMemorySize.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDownMemorySize.Name = "numericUpDownMemorySize";
            this.numericUpDownMemorySize.ReadOnly = true;
            this.numericUpDownMemorySize.Size = new System.Drawing.Size(49, 20);
            this.numericUpDownMemorySize.TabIndex = 8;
            this.numericUpDownMemorySize.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Your Name:";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(132, 105);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 10;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 387);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numericUpDownMemorySize);
            this.Controls.Add(this.numericUpDownClickVisibility);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDownStartVisibility);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Memory Game";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStartVisibility)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownClickVisibility)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMemorySize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownStartVisibility;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDownClickVisibility;
        private System.Windows.Forms.NumericUpDown numericUpDownMemorySize;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxName;
    }
}