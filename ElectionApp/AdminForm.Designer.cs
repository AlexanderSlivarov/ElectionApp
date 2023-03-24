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
            this.resetButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.electionResultsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // electionResultsGrid
            // 
            this.electionResultsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.electionResultsGrid.Location = new System.Drawing.Point(0, -4);
            this.electionResultsGrid.Name = "electionResultsGrid";
            this.electionResultsGrid.Size = new System.Drawing.Size(526, 261);
            this.electionResultsGrid.TabIndex = 0;
            // 
            // resetButton
            // 
            this.resetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.resetButton.Location = new System.Drawing.Point(663, 462);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(188, 45);
            this.resetButton.TabIndex = 1;
            this.resetButton.Text = "Нулирай";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 530);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.electionResultsGrid);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            ((System.ComponentModel.ISupportInitialize)(this.electionResultsGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView electionResultsGrid;
        private System.Windows.Forms.Button resetButton;
    }
}