namespace ElectionApp
{
    partial class StartUpForm
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
            this.voteButton = new System.Windows.Forms.Button();
            this.adminButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // voteButton
            // 
            this.voteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.voteButton.Location = new System.Drawing.Point(209, 136);
            this.voteButton.Name = "voteButton";
            this.voteButton.Size = new System.Drawing.Size(361, 49);
            this.voteButton.TabIndex = 0;
            this.voteButton.Text = "Влез като гласуващ";
            this.voteButton.UseVisualStyleBackColor = true;
            this.voteButton.Click += new System.EventHandler(this.voteButton_Click);
            // 
            // adminButton
            // 
            this.adminButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.adminButton.Location = new System.Drawing.Point(209, 264);
            this.adminButton.Name = "adminButton";
            this.adminButton.Size = new System.Drawing.Size(361, 50);
            this.adminButton.TabIndex = 1;
            this.adminButton.Text = "Влез като администратор";
            this.adminButton.UseVisualStyleBackColor = true;
            this.adminButton.Click += new System.EventHandler(this.adminButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.label1.Location = new System.Drawing.Point(185, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(428, 46);
            this.label1.TabIndex = 2;
            this.label1.Text = "Избори за Парламент";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(139, 405);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(523, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Купуването и продаването на гласове е престъпление!\r\n";
            // 
            // StartUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.adminButton);
            this.Controls.Add(this.voteButton);
            this.Name = "StartUpForm";
            this.Text = "StartUpForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button voteButton;
        private System.Windows.Forms.Button adminButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}