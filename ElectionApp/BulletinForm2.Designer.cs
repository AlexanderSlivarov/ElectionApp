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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.previousPage = new System.Windows.Forms.Button();
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
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.Location = new System.Drawing.Point(746, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(206, 38);
            this.button1.TabIndex = 3;
            this.button1.Text = "Настройки на екрана";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(602, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(350, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Предпочитание (преференция) за кандидат";
            // 
            // previousPage
            // 
            this.previousPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.previousPage.Location = new System.Drawing.Point(222, 562);
            this.previousPage.Name = "previousPage";
            this.previousPage.Size = new System.Drawing.Size(166, 42);
            this.previousPage.TabIndex = 5;
            this.previousPage.Text = "Предишен";
            this.previousPage.UseVisualStyleBackColor = true;
            this.previousPage.Click += new System.EventHandler(this.previousPage_Click);
            // 
            // BulletinForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 630);
            this.Controls.Add(this.previousPage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "BulletinForm2";
            this.Text = "BulletinForm2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button previousPage;
    }
}