namespace DatabaseApp
{
    partial class UpdateAnimalForm
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
            this.updateAnimalsDataGridView = new System.Windows.Forms.DataGridView();
            this.btnSaveAnimal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.updateAnimalsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // updateAnimalsDataGridView
            // 
            this.updateAnimalsDataGridView.AllowUserToAddRows = false;
            this.updateAnimalsDataGridView.AllowUserToDeleteRows = false;
            this.updateAnimalsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.updateAnimalsDataGridView.Location = new System.Drawing.Point(13, 48);
            this.updateAnimalsDataGridView.Name = "updateAnimalsDataGridView";
            this.updateAnimalsDataGridView.RowTemplate.Height = 24;
            this.updateAnimalsDataGridView.Size = new System.Drawing.Size(821, 98);
            this.updateAnimalsDataGridView.TabIndex = 0;
            // 
            // btnSaveAnimal
            // 
            this.btnSaveAnimal.Location = new System.Drawing.Point(374, 161);
            this.btnSaveAnimal.Name = "btnSaveAnimal";
            this.btnSaveAnimal.Size = new System.Drawing.Size(144, 66);
            this.btnSaveAnimal.TabIndex = 1;
            this.btnSaveAnimal.Text = "Save";
            this.btnSaveAnimal.UseVisualStyleBackColor = true;
            this.btnSaveAnimal.Click += new System.EventHandler(this.btnSaveAnimal_Click);
            // 
            // UpdateAnimalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 228);
            this.Controls.Add(this.btnSaveAnimal);
            this.Controls.Add(this.updateAnimalsDataGridView);
            this.Name = "UpdateAnimalForm";
            this.Text = "UpdateAnimalForm";
            ((System.ComponentModel.ISupportInitialize)(this.updateAnimalsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView updateAnimalsDataGridView;
        private System.Windows.Forms.Button btnSaveAnimal;
    }
}