
namespace Task1_Memory_Game
{
    partial class Settings
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
            this.numericUpDownMemorySize = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownClickVisibility = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownStartVisibility = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMemorySize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownClickVisibility)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStartVisibility)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDownMemorySize
            // 
            this.numericUpDownMemorySize.Increment = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDownMemorySize.Location = new System.Drawing.Point(187, 97);
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
            this.numericUpDownMemorySize.TabIndex = 16;
            this.numericUpDownMemorySize.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // numericUpDownClickVisibility
            // 
            this.numericUpDownClickVisibility.DecimalPlaces = 1;
            this.numericUpDownClickVisibility.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numericUpDownClickVisibility.Location = new System.Drawing.Point(187, 166);
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
            this.numericUpDownClickVisibility.TabIndex = 15;
            this.numericUpDownClickVisibility.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Visibility after click:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Visibility after start:";
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(24, 212);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Save And Start Game";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Amount of cards:";
            // 
            // numericUpDownStartVisibility
            // 
            this.numericUpDownStartVisibility.Location = new System.Drawing.Point(187, 132);
            this.numericUpDownStartVisibility.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.numericUpDownStartVisibility.Name = "numericUpDownStartVisibility";
            this.numericUpDownStartVisibility.ReadOnly = true;
            this.numericUpDownStartVisibility.Size = new System.Drawing.Size(49, 20);
            this.numericUpDownStartVisibility.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(86, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 26);
            this.label1.TabIndex = 17;
            this.label1.Text = "Settings";
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(172, 212);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 18;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 270);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDownMemorySize);
            this.Controls.Add(this.numericUpDownClickVisibility);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDownStartVisibility);
            this.Name = "Settings";
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMemorySize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownClickVisibility)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStartVisibility)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDownMemorySize;
        private System.Windows.Forms.NumericUpDown numericUpDownClickVisibility;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownStartVisibility;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
    }
}