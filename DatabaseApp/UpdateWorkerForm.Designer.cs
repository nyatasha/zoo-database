namespace DatabaseApp
{
    partial class UpdateWorkerForm
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
            this.updateWorkerDataGridView = new System.Windows.Forms.DataGridView();
            this.btnSaveUpdated = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.updateWorkerDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // updateWorkerDataGridView
            // 
            this.updateWorkerDataGridView.AllowUserToAddRows = false;
            this.updateWorkerDataGridView.AllowUserToDeleteRows = false;
            this.updateWorkerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.updateWorkerDataGridView.Location = new System.Drawing.Point(12, 90);
            this.updateWorkerDataGridView.Name = "updateWorkerDataGridView";
            this.updateWorkerDataGridView.RowTemplate.Height = 24;
            this.updateWorkerDataGridView.Size = new System.Drawing.Size(925, 111);
            this.updateWorkerDataGridView.TabIndex = 0;
            this.updateWorkerDataGridView.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.updateWorkerDataGridView_EditingControlShowing);
            // 
            // btnSaveUpdated
            // 
            this.btnSaveUpdated.Location = new System.Drawing.Point(410, 243);
            this.btnSaveUpdated.Name = "btnSaveUpdated";
            this.btnSaveUpdated.Size = new System.Drawing.Size(144, 66);
            this.btnSaveUpdated.TabIndex = 1;
            this.btnSaveUpdated.Text = "Save";
            this.btnSaveUpdated.UseVisualStyleBackColor = true;
            this.btnSaveUpdated.Click += new System.EventHandler(this.btnSaveUpdated_Click);
            // 
            // UpdateWorkerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 351);
            this.Controls.Add(this.btnSaveUpdated);
            this.Controls.Add(this.updateWorkerDataGridView);
            this.Name = "UpdateWorkerForm";
            this.Text = "UpdateWorkerForm";
            this.Load += new System.EventHandler(this.UpdateWorkerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.updateWorkerDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView updateWorkerDataGridView;
        private System.Windows.Forms.Button btnSaveUpdated;
    }
}