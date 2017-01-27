namespace DatabaseApp
{
    partial class MainForm
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
            this.btnShowAnimals = new System.Windows.Forms.Button();
            this.btnShowWorkers = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnShowAnimals
            // 
            this.btnShowAnimals.Location = new System.Drawing.Point(212, 72);
            this.btnShowAnimals.Name = "btnShowAnimals";
            this.btnShowAnimals.Size = new System.Drawing.Size(176, 87);
            this.btnShowAnimals.TabIndex = 2;
            this.btnShowAnimals.Text = "Show animals";
            this.btnShowAnimals.UseVisualStyleBackColor = true;
            this.btnShowAnimals.Click += new System.EventHandler(this.btnShowAnimals_Click);
            // 
            // btnShowWorkers
            // 
            this.btnShowWorkers.Location = new System.Drawing.Point(30, 72);
            this.btnShowWorkers.Name = "btnShowWorkers";
            this.btnShowWorkers.Size = new System.Drawing.Size(176, 87);
            this.btnShowWorkers.TabIndex = 1;
            this.btnShowWorkers.Text = "Show workers";
            this.btnShowWorkers.UseVisualStyleBackColor = true;
            this.btnShowWorkers.Click += new System.EventHandler(this.btnShowWorkers_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 253);
            this.Controls.Add(this.btnShowWorkers);
            this.Controls.Add(this.btnShowAnimals);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnShowAnimals;
        private System.Windows.Forms.Button btnShowWorkers;
    }
}

