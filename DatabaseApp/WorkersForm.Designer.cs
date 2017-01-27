namespace DatabaseApp
{
    partial class WorkersForm
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
            this.workersDataGridView = new System.Windows.Forms.DataGridView();
            this.btnAddWorker = new System.Windows.Forms.Button();
            this.btnDeleteWorker = new System.Windows.Forms.Button();
            this.btnUpdateWorker = new System.Windows.Forms.Button();
            this.btnAverageSalary = new System.Windows.Forms.Button();
            this.btnShowPositions = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.workersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // workersDataGridView
            // 
            this.workersDataGridView.AllowUserToAddRows = false;
            this.workersDataGridView.AllowUserToDeleteRows = false;
            this.workersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.workersDataGridView.Location = new System.Drawing.Point(12, 130);
            this.workersDataGridView.Name = "workersDataGridView";
            this.workersDataGridView.RowTemplate.Height = 24;
            this.workersDataGridView.Size = new System.Drawing.Size(784, 529);
            this.workersDataGridView.TabIndex = 0;
            this.workersDataGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.workersDataGridView_RowHeaderMouseClick);
            this.workersDataGridView.SelectionChanged += new System.EventHandler(this.workersDataGridView_SelectionChanged);
            // 
            // btnAddWorker
            // 
            this.btnAddWorker.Location = new System.Drawing.Point(30, 47);
            this.btnAddWorker.Name = "btnAddWorker";
            this.btnAddWorker.Size = new System.Drawing.Size(144, 66);
            this.btnAddWorker.TabIndex = 1;
            this.btnAddWorker.Text = "Add a worker";
            this.btnAddWorker.UseVisualStyleBackColor = true;
            this.btnAddWorker.Click += new System.EventHandler(this.btnAddWorker_Click);
            // 
            // btnDeleteWorker
            // 
            this.btnDeleteWorker.Location = new System.Drawing.Point(180, 47);
            this.btnDeleteWorker.Name = "btnDeleteWorker";
            this.btnDeleteWorker.Size = new System.Drawing.Size(144, 66);
            this.btnDeleteWorker.TabIndex = 2;
            this.btnDeleteWorker.Text = "Delete a worker";
            this.btnDeleteWorker.UseVisualStyleBackColor = true;
            this.btnDeleteWorker.Click += new System.EventHandler(this.btnDeleteWorker_Click);
            // 
            // btnUpdateWorker
            // 
            this.btnUpdateWorker.Location = new System.Drawing.Point(330, 47);
            this.btnUpdateWorker.Name = "btnUpdateWorker";
            this.btnUpdateWorker.Size = new System.Drawing.Size(144, 66);
            this.btnUpdateWorker.TabIndex = 3;
            this.btnUpdateWorker.Text = "Update a worker";
            this.btnUpdateWorker.UseVisualStyleBackColor = true;
            this.btnUpdateWorker.Click += new System.EventHandler(this.btnUpdateWorker_Click);
            // 
            // btnAverageSalary
            // 
            this.btnAverageSalary.Location = new System.Drawing.Point(480, 47);
            this.btnAverageSalary.Name = "btnAverageSalary";
            this.btnAverageSalary.Size = new System.Drawing.Size(144, 66);
            this.btnAverageSalary.TabIndex = 4;
            this.btnAverageSalary.Text = "Calculate average salary";
            this.btnAverageSalary.UseVisualStyleBackColor = true;
            this.btnAverageSalary.Click += new System.EventHandler(this.btnAverageSalary_Click);
            // 
            // btnShowPositions
            // 
            this.btnShowPositions.Location = new System.Drawing.Point(631, 47);
            this.btnShowPositions.Name = "btnShowPositions";
            this.btnShowPositions.Size = new System.Drawing.Size(144, 66);
            this.btnShowPositions.TabIndex = 5;
            this.btnShowPositions.Text = "Show list of positions";
            this.btnShowPositions.UseVisualStyleBackColor = true;
            this.btnShowPositions.Click += new System.EventHandler(this.btnShowPositions_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(275, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(169, 12);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(100, 22);
            this.textBoxSearch.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(356, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Enter worker\'s name:";
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(502, 12);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(142, 23);
            this.btnReport.TabIndex = 10;
            this.btnReport.Text = "Create report";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // WorkersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 671);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnShowPositions);
            this.Controls.Add(this.btnAverageSalary);
            this.Controls.Add(this.btnUpdateWorker);
            this.Controls.Add(this.btnDeleteWorker);
            this.Controls.Add(this.btnAddWorker);
            this.Controls.Add(this.workersDataGridView);
            this.Name = "WorkersForm";
            this.Text = "WorkersForm";
            ((System.ComponentModel.ISupportInitialize)(this.workersDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView workersDataGridView;
        private System.Windows.Forms.Button btnAddWorker;
        private System.Windows.Forms.Button btnDeleteWorker;
        private System.Windows.Forms.Button btnUpdateWorker;
        private System.Windows.Forms.Button btnAverageSalary;
        private System.Windows.Forms.Button btnShowPositions;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReport;
    }
}