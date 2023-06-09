﻿namespace ElectionApp
{
    partial class ReviewForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReviewForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.settingsButton = new System.Windows.Forms.Button();
            this.changeDecisionButton = new System.Windows.Forms.Button();
            this.voteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(28, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 100);
            this.label1.TabIndex = 2;
            this.label1.Text = "РАЙОН СМОЛЯН\r\nИзбори 02.04.2023\r\n\r\n\r\n\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(27, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(246, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Преглед на избора";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(28, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(450, 60);
            this.label3.TabIndex = 5;
            this.label3.Text = "Прегледайте избора си.\r\nМоже да го промените, като натиснете \"Промени избора\"\r\nНа" +
    "тиснете \"Гласуване\" и изчакайте\r\n";
            // 
            // settingsButton
            // 
            this.settingsButton.AutoSize = true;
            this.settingsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.settingsButton.Location = new System.Drawing.Point(564, 12);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(206, 38);
            this.settingsButton.TabIndex = 6;
            this.settingsButton.Text = "Настройки на екрана";
            this.settingsButton.UseVisualStyleBackColor = true;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // changeDecisionButton
            // 
            this.changeDecisionButton.AutoSize = true;
            this.changeDecisionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.changeDecisionButton.Location = new System.Drawing.Point(12, 470);
            this.changeDecisionButton.Name = "changeDecisionButton";
            this.changeDecisionButton.Size = new System.Drawing.Size(186, 38);
            this.changeDecisionButton.TabIndex = 7;
            this.changeDecisionButton.Text = "Промени избора";
            this.changeDecisionButton.UseVisualStyleBackColor = true;
            this.changeDecisionButton.Click += new System.EventHandler(this.changeDecisionButton_Click);
            // 
            // voteButton
            // 
            this.voteButton.AutoSize = true;
            this.voteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.voteButton.Location = new System.Drawing.Point(584, 470);
            this.voteButton.Name = "voteButton";
            this.voteButton.Size = new System.Drawing.Size(186, 38);
            this.voteButton.TabIndex = 8;
            this.voteButton.Text = "Гласуване";
            this.voteButton.UseVisualStyleBackColor = true;
            this.voteButton.Click += new System.EventHandler(this.voteButton_Click);
            // 
            // ReviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 520);
            this.Controls.Add(this.voteButton);
            this.Controls.Add(this.changeDecisionButton);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReviewForm";
            this.Text = "Преглед";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.Button changeDecisionButton;
        private System.Windows.Forms.Button voteButton;
    }
}