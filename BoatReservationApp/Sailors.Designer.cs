namespace BoatReservationApp
{
    partial class Sailors
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.ratingTextBox = new System.Windows.Forms.TextBox();
            this.ageTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.reserveButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.sailorButton = new System.Windows.Forms.Button();
            this.boatButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.sailorGridView = new System.Windows.Forms.DataGridView();
            this.outputlabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sailorGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sailor Name :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Rating :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Age :";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(139, 31);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(163, 20);
            this.nameTextBox.TabIndex = 3;
            // 
            // ratingTextBox
            // 
            this.ratingTextBox.Location = new System.Drawing.Point(139, 64);
            this.ratingTextBox.Name = "ratingTextBox";
            this.ratingTextBox.Size = new System.Drawing.Size(163, 20);
            this.ratingTextBox.TabIndex = 4;
            // 
            // ageTextBox
            // 
            this.ageTextBox.Location = new System.Drawing.Point(139, 97);
            this.ageTextBox.Name = "ageTextBox";
            this.ageTextBox.Size = new System.Drawing.Size(163, 20);
            this.ageTextBox.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.outputlabel);
            this.groupBox1.Controls.Add(this.saveButton);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ageTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ratingTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.nameTextBox);
            this.groupBox1.Location = new System.Drawing.Point(104, 104);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(332, 201);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Save Sailor";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(226, 133);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 6;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // reserveButton
            // 
            this.reserveButton.Location = new System.Drawing.Point(331, 14);
            this.reserveButton.Name = "reserveButton";
            this.reserveButton.Size = new System.Drawing.Size(156, 23);
            this.reserveButton.TabIndex = 8;
            this.reserveButton.Text = "Reserve Boat";
            this.reserveButton.UseVisualStyleBackColor = true;
            this.reserveButton.Click += new System.EventHandler(this.reserveButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.OliveDrab;
            this.groupBox2.Controls.Add(this.sailorButton);
            this.groupBox2.Controls.Add(this.boatButton);
            this.groupBox2.Controls.Add(this.reserveButton);
            this.groupBox2.Location = new System.Drawing.Point(13, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(505, 46);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            // 
            // sailorButton
            // 
            this.sailorButton.BackColor = System.Drawing.Color.Gray;
            this.sailorButton.Location = new System.Drawing.Point(19, 14);
            this.sailorButton.Name = "sailorButton";
            this.sailorButton.Size = new System.Drawing.Size(156, 23);
            this.sailorButton.TabIndex = 10;
            this.sailorButton.Text = "Save Sailor";
            this.sailorButton.UseVisualStyleBackColor = false;
            // 
            // boatButton
            // 
            this.boatButton.Location = new System.Drawing.Point(175, 14);
            this.boatButton.Name = "boatButton";
            this.boatButton.Size = new System.Drawing.Size(156, 23);
            this.boatButton.TabIndex = 9;
            this.boatButton.Text = "Save Boat";
            this.boatButton.UseVisualStyleBackColor = true;
            this.boatButton.Click += new System.EventHandler(this.boatButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(213, 61);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(10, 4, 10, 4);
            this.label4.Size = new System.Drawing.Size(109, 28);
            this.label4.TabIndex = 12;
            this.label4.Text = "Save Sailor";
            // 
            // sailorGridView
            // 
            this.sailorGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sailorGridView.Location = new System.Drawing.Point(32, 329);
            this.sailorGridView.Name = "sailorGridView";
            this.sailorGridView.Size = new System.Drawing.Size(468, 217);
            this.sailorGridView.TabIndex = 13;
            // 
            // outputlabel
            // 
            this.outputlabel.AutoSize = true;
            this.outputlabel.ForeColor = System.Drawing.Color.DarkRed;
            this.outputlabel.Location = new System.Drawing.Point(112, 165);
            this.outputlabel.Name = "outputlabel";
            this.outputlabel.Size = new System.Drawing.Size(39, 13);
            this.outputlabel.TabIndex = 7;
            this.outputlabel.Text = "Output";
            // 
            // Sailors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 558);
            this.Controls.Add(this.sailorGridView);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Sailors";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Boat Reservation Management";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sailorGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox ratingTextBox;
        private System.Windows.Forms.TextBox ageTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button reserveButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button sailorButton;
        private System.Windows.Forms.Button boatButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView sailorGridView;
        private System.Windows.Forms.Label outputlabel;
    }
}

