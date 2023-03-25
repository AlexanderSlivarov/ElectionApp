namespace ElectionApp
{
    partial class AdminForm
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
            this.electionResultsGrid = new System.Windows.Forms.DataGridView();
            this.sumButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.electionResultsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // electionResultsGrid
            // 
            this.electionResultsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.electionResultsGrid.Location = new System.Drawing.Point(0, 0);
            this.electionResultsGrid.Name = "electionResultsGrid";
            this.electionResultsGrid.Size = new System.Drawing.Size(801, 218);
            this.electionResultsGrid.TabIndex = 0;
            // 
            // sumButton
            // 
            this.sumButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.sumButton.Location = new System.Drawing.Point(12, 389);
            this.sumButton.Name = "sumButton";
            this.sumButton.Size = new System.Drawing.Size(191, 49);
            this.sumButton.TabIndex = 1;
            this.sumButton.Text = "Сумирай";
            this.sumButton.UseVisualStyleBackColor = true;
            this.sumButton.Click += new System.EventHandler(this.sumButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.resetButton.Location = new System.Drawing.Point(579, 391);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(209, 47);
            this.resetButton.TabIndex = 2;
            this.resetButton.Text = "Нулирай";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.sumButton);
            this.Controls.Add(this.electionResultsGrid);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            ((System.ComponentModel.ISupportInitialize)(this.electionResultsGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView electionResultsGrid;
        private System.Windows.Forms.Button sumButton;
        private System.Windows.Forms.Button resetButton;
    }
}