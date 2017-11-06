namespace CRUD_MongoDB
{
    partial class VistaDueños
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
            this.dataGridViewDueños = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDueños)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDueños
            // 
            this.dataGridViewDueños.AccessibleDescription = "dataGridViewDueños";
            this.dataGridViewDueños.AccessibleName = "dataGridViewDueños";
            this.dataGridViewDueños.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDueños.Location = new System.Drawing.Point(12, 41);
            this.dataGridViewDueños.Name = "dataGridViewDueños";
            this.dataGridViewDueños.Size = new System.Drawing.Size(547, 242);
            this.dataGridViewDueños.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(241, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "LISTA DE DUEÑOS";
            // 
            // VistaDueños
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 295);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewDueños);
            this.Name = "VistaDueños";
            this.Text = "VistaDueños";
            this.Load += new System.EventHandler(this.VistaDueños_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDueños)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewDueños;
        private System.Windows.Forms.Label label1;
    }
}