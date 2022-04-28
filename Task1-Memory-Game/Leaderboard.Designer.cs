
namespace Task1_Memory_Game
{
    partial class Leaderboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Leaderboard));
            this.comboBoxBoardSize = new System.Windows.Forms.ComboBox();
            this.comboBoxPName = new System.Windows.Forms.ComboBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxSort = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxBoardSize
            // 
            this.comboBoxBoardSize.BackColor = System.Drawing.SystemColors.Info;
            this.comboBoxBoardSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBoardSize.FormattingEnabled = true;
            this.comboBoxBoardSize.Location = new System.Drawing.Point(88, 114);
            this.comboBoxBoardSize.Name = "comboBoxBoardSize";
            this.comboBoxBoardSize.Size = new System.Drawing.Size(58, 21);
            this.comboBoxBoardSize.Sorted = true;
            this.comboBoxBoardSize.TabIndex = 1;
            this.comboBoxBoardSize.SelectedIndexChanged += new System.EventHandler(this.comboBoxBoardSize_SelectedIndexChanged);
            // 
            // comboBoxPName
            // 
            this.comboBoxPName.BackColor = System.Drawing.SystemColors.Info;
            this.comboBoxPName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPName.FormattingEnabled = true;
            this.comboBoxPName.Location = new System.Drawing.Point(12, 114);
            this.comboBoxPName.Name = "comboBoxPName";
            this.comboBoxPName.Size = new System.Drawing.Size(73, 21);
            this.comboBoxPName.Sorted = true;
            this.comboBoxPName.TabIndex = 2;
            this.comboBoxPName.SelectedIndexChanged += new System.EventHandler(this.comboBoxPName_SelectedIndexChanged);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 141);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(304, 302);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(102, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Leaderboard";
            // 
            // comboBoxSort
            // 
            this.comboBoxSort.BackColor = System.Drawing.SystemColors.Info;
            this.comboBoxSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSort.FormattingEnabled = true;
            this.comboBoxSort.Location = new System.Drawing.Point(220, 114);
            this.comboBoxSort.Name = "comboBoxSort";
            this.comboBoxSort.Size = new System.Drawing.Size(96, 21);
            this.comboBoxSort.TabIndex = 5;
            this.comboBoxSort.SelectedIndexChanged += new System.EventHandler(this.comboBoxSort_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(217, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Sort By:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Board Size:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Player Name:";
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(152, 114);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(22, 21);
            this.button1.TabIndex = 9;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Leaderboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 455);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxSort);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.comboBoxPName);
            this.Controls.Add(this.comboBoxBoardSize);
            this.MaximumSize = new System.Drawing.Size(344, 494);
            this.MinimumSize = new System.Drawing.Size(344, 494);
            this.Name = "Leaderboard";
            this.Text = "Leaderboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBoxBoardSize;
        private System.Windows.Forms.ComboBox comboBoxPName;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxSort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}