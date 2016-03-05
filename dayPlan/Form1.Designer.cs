﻿namespace dayPlan
{
    partial class Form1
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
            this.locationBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox = new System.Windows.Forms.ComboBox();
            this.activityBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.budgetBox = new System.Windows.Forms.ComboBox();
            this.errorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(229, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vanmera";
            // 
            // locationBox
            // 
            this.locationBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.locationBox.Location = new System.Drawing.Point(177, 57);
            this.locationBox.Name = "locationBox";
            this.locationBox.Size = new System.Drawing.Size(221, 30);
            this.locationBox.TabIndex = 1;
            this.locationBox.Text = "1110 Hamilton St #140, Vancouver, BC";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(45, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Location";
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.startButton.Location = new System.Drawing.Point(177, 270);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(201, 43);
            this.startButton.TabIndex = 3;
            this.startButton.Text = "Generate activities";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.Location = new System.Drawing.Point(45, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Group type";
            // 
            // groupBox
            // 
            this.groupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.groupBox.FormattingEnabled = true;
            this.groupBox.Items.AddRange(new object[] {
            "Family",
            "Family with children",
            "Singles",
            "Date"});
            this.groupBox.Location = new System.Drawing.Point(177, 98);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(221, 33);
            this.groupBox.TabIndex = 6;
            // 
            // activityBox
            // 
            this.activityBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.activityBox.FormattingEnabled = true;
            this.activityBox.Items.AddRange(new object[] {
            "Low",
            "Medium",
            "High"});
            this.activityBox.Location = new System.Drawing.Point(177, 140);
            this.activityBox.Name = "activityBox";
            this.activityBox.Size = new System.Drawing.Size(221, 33);
            this.activityBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label4.Location = new System.Drawing.Point(45, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Activity Level";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label5.Location = new System.Drawing.Point(45, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Budget";
            // 
            // budgetBox
            // 
            this.budgetBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.budgetBox.FormattingEnabled = true;
            this.budgetBox.Items.AddRange(new object[] {
            "Low        $",
            "Medium $$",
            "High       $$$"});
            this.budgetBox.Location = new System.Drawing.Point(177, 179);
            this.budgetBox.Name = "budgetBox";
            this.budgetBox.Size = new System.Drawing.Size(221, 33);
            this.budgetBox.TabIndex = 10;
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.errorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.errorLabel.Location = new System.Drawing.Point(231, 234);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(95, 20);
            this.errorLabel.TabIndex = 11;
            this.errorLabel.Text = "Invalid Input";
            this.errorLabel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 348);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.budgetBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.activityBox);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.locationBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox locationBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox groupBox;
        private System.Windows.Forms.ComboBox activityBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox budgetBox;
        private System.Windows.Forms.Label errorLabel;
    }
}

