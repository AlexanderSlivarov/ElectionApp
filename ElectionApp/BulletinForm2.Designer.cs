namespace ElectionApp
{
    partial class BulletinForm2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BulletinForm2));
            this.label1 = new System.Windows.Forms.Label();
            this.settingsButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.previousPage = new System.Windows.Forms.Button();
            this.reviewButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 40);
            this.label1.TabIndex = 2;
            this.label1.Text = "РАЙОН СМОЛЯН\r\nИзбори за народни представители\r\n";
            // 
            // settingsButton
            // 
            this.settingsButton.AutoSize = true;
            this.settingsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.settingsButton.Location = new System.Drawing.Point(766, 12);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(206, 38);
            this.settingsButton.TabIndex = 3;
            this.settingsButton.Text = "Настройки на екрана";
            this.settingsButton.UseVisualStyleBackColor = true;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(622, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(350, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Предпочитание (преференция) за кандидат";
            // 
            // previousPage
            // 
            this.previousPage.AutoSize = true;
            this.previousPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.previousPage.Location = new System.Drawing.Point(186, 599);
            this.previousPage.Name = "previousPage";
            this.previousPage.Size = new System.Drawing.Size(166, 42);
            this.previousPage.TabIndex = 5;
            this.previousPage.Text = "Предишен";
            this.previousPage.UseVisualStyleBackColor = true;
            this.previousPage.Click += new System.EventHandler(this.previousPage_Click);
            // 
            // reviewButton
            // 
            this.reviewButton.AutoSize = true;
            this.reviewButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.reviewButton.Location = new System.Drawing.Point(783, 599);
            this.reviewButton.Name = "reviewButton";
            this.reviewButton.Size = new System.Drawing.Size(166, 42);
            this.reviewButton.TabIndex = 6;
            this.reviewButton.Text = "Преглед";
            this.reviewButton.UseVisualStyleBackColor = true;
            this.reviewButton.Click += new System.EventHandler(this.reviewButton_Click);
            // 
            // BulletinForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 653);
            this.Controls.Add(this.reviewButton);
            this.Controls.Add(this.previousPage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BulletinForm2";
            this.Text = "Втора страница";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button previousPage;
        private System.Windows.Forms.Button reviewButton;
    }
}