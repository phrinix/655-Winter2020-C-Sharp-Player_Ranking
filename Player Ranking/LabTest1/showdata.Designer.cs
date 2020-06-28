namespace LabTest1
{
    partial class showdata
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
            this.DGVShowData = new System.Windows.Forms.DataGridView();
            this.BExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVShowData)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(434, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Player Data";
            // 
            // DGVShowData
            // 
            this.DGVShowData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVShowData.Location = new System.Drawing.Point(25, 87);
            this.DGVShowData.Name = "DGVShowData";
            this.DGVShowData.RowHeadersWidth = 51;
            this.DGVShowData.RowTemplate.Height = 24;
            this.DGVShowData.Size = new System.Drawing.Size(1054, 435);
            this.DGVShowData.TabIndex = 1;
            // 
            // BExit
            // 
            this.BExit.Location = new System.Drawing.Point(469, 528);
            this.BExit.Name = "BExit";
            this.BExit.Size = new System.Drawing.Size(151, 45);
            this.BExit.TabIndex = 2;
            this.BExit.Text = "Exit";
            this.BExit.UseVisualStyleBackColor = true;
            this.BExit.Click += new System.EventHandler(this.BExit_Click);
            // 
            // showdata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 595);
            this.Controls.Add(this.BExit);
            this.Controls.Add(this.DGVShowData);
            this.Controls.Add(this.label1);
            this.Name = "showdata";
            this.Text = "Player DATA";
            ((System.ComponentModel.ISupportInitialize)(this.DGVShowData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DGVShowData;
        private System.Windows.Forms.Button BExit;
    }
}