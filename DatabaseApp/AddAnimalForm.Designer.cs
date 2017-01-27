namespace DatabaseApp
{
    partial class AddAnimalForm
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
            this.btnConfirm = new System.Windows.Forms.Button();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblNickname = new System.Windows.Forms.Label();
            this.lblSpecies = new System.Windows.Forms.Label();
            this.lblClass = new System.Windows.Forms.Label();
            this.textAge = new System.Windows.Forms.TextBox();
            this.textGender = new System.Windows.Forms.TextBox();
            this.textNickname = new System.Windows.Forms.TextBox();
            this.textSpecies = new System.Windows.Forms.TextBox();
            this.textClass = new System.Windows.Forms.TextBox();
            this.lblFood = new System.Windows.Forms.Label();
            this.textFood = new System.Windows.Forms.TextBox();
            this.lblZookeeper = new System.Windows.Forms.Label();
            this.textZookeeper = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(143, 243);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(96, 29);
            this.btnConfirm.TabIndex = 22;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(93, 148);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(37, 17);
            this.lblAge.TabIndex = 21;
            this.lblAge.Text = "Age:";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(73, 120);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(60, 17);
            this.lblGender.TabIndex = 20;
            this.lblGender.Text = "Gender:";
            // 
            // lblNickname
            // 
            this.lblNickname.AutoSize = true;
            this.lblNickname.Location = new System.Drawing.Point(59, 94);
            this.lblNickname.Name = "lblNickname";
            this.lblNickname.Size = new System.Drawing.Size(74, 17);
            this.lblNickname.TabIndex = 19;
            this.lblNickname.Text = "Nickname:";
            // 
            // lblSpecies
            // 
            this.lblSpecies.AutoSize = true;
            this.lblSpecies.Location = new System.Drawing.Point(68, 64);
            this.lblSpecies.Name = "lblSpecies";
            this.lblSpecies.Size = new System.Drawing.Size(62, 17);
            this.lblSpecies.TabIndex = 18;
            this.lblSpecies.Text = "Species:";
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Location = new System.Drawing.Point(87, 36);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(46, 17);
            this.lblClass.TabIndex = 17;
            this.lblClass.Text = "Class:";
            // 
            // textAge
            // 
            this.textAge.Location = new System.Drawing.Point(139, 145);
            this.textAge.Name = "textAge";
            this.textAge.Size = new System.Drawing.Size(100, 22);
            this.textAge.TabIndex = 16;
            // 
            // textGender
            // 
            this.textGender.Location = new System.Drawing.Point(139, 117);
            this.textGender.Name = "textGender";
            this.textGender.Size = new System.Drawing.Size(100, 22);
            this.textGender.TabIndex = 15;
            // 
            // textNickname
            // 
            this.textNickname.Location = new System.Drawing.Point(139, 89);
            this.textNickname.Name = "textNickname";
            this.textNickname.Size = new System.Drawing.Size(100, 22);
            this.textNickname.TabIndex = 14;
            // 
            // textSpecies
            // 
            this.textSpecies.Location = new System.Drawing.Point(139, 61);
            this.textSpecies.Name = "textSpecies";
            this.textSpecies.Size = new System.Drawing.Size(100, 22);
            this.textSpecies.TabIndex = 13;
            // 
            // textClass
            // 
            this.textClass.Location = new System.Drawing.Point(139, 33);
            this.textClass.Name = "textClass";
            this.textClass.Size = new System.Drawing.Size(100, 22);
            this.textClass.TabIndex = 12;
            // 
            // lblFood
            // 
            this.lblFood.AutoSize = true;
            this.lblFood.Location = new System.Drawing.Point(55, 176);
            this.lblFood.Name = "lblFood";
            this.lblFood.Size = new System.Drawing.Size(75, 17);
            this.lblFood.TabIndex = 24;
            this.lblFood.Text = "Food type:";
            // 
            // textFood
            // 
            this.textFood.Location = new System.Drawing.Point(139, 173);
            this.textFood.Name = "textFood";
            this.textFood.Size = new System.Drawing.Size(100, 22);
            this.textFood.TabIndex = 23;
            // 
            // lblZookeeper
            // 
            this.lblZookeeper.AutoSize = true;
            this.lblZookeeper.Location = new System.Drawing.Point(52, 207);
            this.lblZookeeper.Name = "lblZookeeper";
            this.lblZookeeper.Size = new System.Drawing.Size(81, 17);
            this.lblZookeeper.TabIndex = 26;
            this.lblZookeeper.Text = "Zookeeper:";
            // 
            // textZookeeper
            // 
            this.textZookeeper.Location = new System.Drawing.Point(139, 204);
            this.textZookeeper.Name = "textZookeeper";
            this.textZookeeper.Size = new System.Drawing.Size(100, 22);
            this.textZookeeper.TabIndex = 25;
            // 
            // AddAnimalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 293);
            this.Controls.Add(this.lblZookeeper);
            this.Controls.Add(this.textZookeeper);
            this.Controls.Add(this.lblFood);
            this.Controls.Add(this.textFood);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblNickname);
            this.Controls.Add(this.lblSpecies);
            this.Controls.Add(this.lblClass);
            this.Controls.Add(this.textAge);
            this.Controls.Add(this.textGender);
            this.Controls.Add(this.textNickname);
            this.Controls.Add(this.textSpecies);
            this.Controls.Add(this.textClass);
            this.Name = "AddAnimalForm";
            this.Text = "AddAnimalForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblNickname;
        private System.Windows.Forms.Label lblSpecies;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.TextBox textAge;
        private System.Windows.Forms.TextBox textGender;
        private System.Windows.Forms.TextBox textNickname;
        private System.Windows.Forms.TextBox textSpecies;
        private System.Windows.Forms.TextBox textClass;
        private System.Windows.Forms.Label lblFood;
        private System.Windows.Forms.TextBox textFood;
        private System.Windows.Forms.Label lblZookeeper;
        private System.Windows.Forms.TextBox textZookeeper;
    }
}