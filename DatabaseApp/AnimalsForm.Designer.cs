namespace DatabaseApp
{
    partial class AnimalsForm
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
            this.animalsDataGridView = new System.Windows.Forms.DataGridView();
            this.btnAddAnimal = new System.Windows.Forms.Button();
            this.btnDeleteAnimal = new System.Windows.Forms.Button();
            this.btnUpdateAnimal = new System.Windows.Forms.Button();
            this.btnShowFood = new System.Windows.Forms.Button();
            this.btnShowWorkers = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.animalsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // animalsDataGridView
            // 
            this.animalsDataGridView.AllowUserToAddRows = false;
            this.animalsDataGridView.AllowUserToDeleteRows = false;
            this.animalsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.animalsDataGridView.Location = new System.Drawing.Point(12, 133);
            this.animalsDataGridView.Name = "animalsDataGridView";
            this.animalsDataGridView.ReadOnly = true;
            this.animalsDataGridView.RowTemplate.Height = 24;
            this.animalsDataGridView.Size = new System.Drawing.Size(852, 482);
            this.animalsDataGridView.TabIndex = 1;
            this.animalsDataGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.animalsDataGridView_RowHeaderMouseClick);
            this.animalsDataGridView.SelectionChanged += new System.EventHandler(this.animalsDataGridView_SelectionChanged);
            // 
            // btnAddAnimal
            // 
            this.btnAddAnimal.Location = new System.Drawing.Point(13, 39);
            this.btnAddAnimal.Name = "btnAddAnimal";
            this.btnAddAnimal.Size = new System.Drawing.Size(144, 66);
            this.btnAddAnimal.TabIndex = 2;
            this.btnAddAnimal.Text = "Add an animal";
            this.btnAddAnimal.UseVisualStyleBackColor = true;
            this.btnAddAnimal.Click += new System.EventHandler(this.btnAddAnimal_Click);
            // 
            // btnDeleteAnimal
            // 
            this.btnDeleteAnimal.Location = new System.Drawing.Point(163, 39);
            this.btnDeleteAnimal.Name = "btnDeleteAnimal";
            this.btnDeleteAnimal.Size = new System.Drawing.Size(144, 66);
            this.btnDeleteAnimal.TabIndex = 3;
            this.btnDeleteAnimal.Text = "Delete an animal";
            this.btnDeleteAnimal.UseVisualStyleBackColor = true;
            this.btnDeleteAnimal.Click += new System.EventHandler(this.btnDeleteAnimal_Click);
            // 
            // btnUpdateAnimal
            // 
            this.btnUpdateAnimal.Location = new System.Drawing.Point(313, 39);
            this.btnUpdateAnimal.Name = "btnUpdateAnimal";
            this.btnUpdateAnimal.Size = new System.Drawing.Size(144, 66);
            this.btnUpdateAnimal.TabIndex = 4;
            this.btnUpdateAnimal.Text = "Update selected animal";
            this.btnUpdateAnimal.UseVisualStyleBackColor = true;
            this.btnUpdateAnimal.Click += new System.EventHandler(this.btnUpdateAnimal_Click);
            // 
            // btnShowFood
            // 
            this.btnShowFood.Location = new System.Drawing.Point(463, 39);
            this.btnShowFood.Name = "btnShowFood";
            this.btnShowFood.Size = new System.Drawing.Size(144, 66);
            this.btnShowFood.TabIndex = 5;
            this.btnShowFood.Text = "Show all available food";
            this.btnShowFood.UseVisualStyleBackColor = true;
            this.btnShowFood.Click += new System.EventHandler(this.btnShowFood_Click);
            // 
            // btnShowWorkers
            // 
            this.btnShowWorkers.Location = new System.Drawing.Point(613, 39);
            this.btnShowWorkers.Name = "btnShowWorkers";
            this.btnShowWorkers.Size = new System.Drawing.Size(144, 66);
            this.btnShowWorkers.TabIndex = 6;
            this.btnShowWorkers.Text = "Show all workers";
            this.btnShowWorkers.UseVisualStyleBackColor = true;
            this.btnShowWorkers.Click += new System.EventHandler(this.btnShowWorkers_Click);
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(763, 39);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(144, 66);
            this.btnReport.TabIndex = 7;
            this.btnReport.Text = "Show Report";
            this.btnReport.UseVisualStyleBackColor = true;
            // 
            // AnimalsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 627);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnShowWorkers);
            this.Controls.Add(this.btnShowFood);
            this.Controls.Add(this.btnUpdateAnimal);
            this.Controls.Add(this.btnDeleteAnimal);
            this.Controls.Add(this.btnAddAnimal);
            this.Controls.Add(this.animalsDataGridView);
            this.Name = "AnimalsForm";
            this.Text = "AnimalsForm";
            this.Load += new System.EventHandler(this.AnimalsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.animalsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView animalsDataGridView;
        private System.Windows.Forms.Button btnAddAnimal;
        private System.Windows.Forms.Button btnDeleteAnimal;
        private System.Windows.Forms.Button btnUpdateAnimal;
        private System.Windows.Forms.Button btnShowFood;
        private System.Windows.Forms.Button btnShowWorkers;
        private System.Windows.Forms.Button btnReport;
    }
}