namespace ElectionApp
{
    partial class WelcomeForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.voteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(215, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(479, 55);
            this.label1.TabIndex = 1;
            this.label1.Text = "ИЗБОРИ 02.04.2023";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.label2.Location = new System.Drawing.Point(298, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(289, 46);
            this.label2.TabIndex = 2;
            this.label2.Text = "Добре дошли!";
            // 
            // voteButton
            // 
            this.voteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.voteButton.Location = new System.Drawing.Point(306, 292);
            this.voteButton.Name = "voteButton";
            this.voteButton.Size = new System.Drawing.Size(269, 99);
            this.voteButton.TabIndex = 3;
            this.voteButton.Text = "Гласувай!";
            this.voteButton.UseVisualStyleBackColor = true;
            this.voteButton.Click += new System.EventHandler(this.voteButton_Click);
            // 
            // WelcomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 522);
            this.Controls.Add(this.voteButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "WelcomeForm";
            this.Text = "WelcomeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button voteButton;
    }
}