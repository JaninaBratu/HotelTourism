namespace HotelTourism
{
    partial class RezervationForm
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
            this.UsernameLabelMsg = new System.Windows.Forms.Label();
            this.PasswordLabelMsg = new System.Windows.Forms.Label();
            this.countyComboBox = new System.Windows.Forms.ComboBox();
            this.rezervBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cityComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pageTextBox = new System.Windows.Forms.TextBox();
            this.previousButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.errorMessageLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // UsernameLabelMsg
            // 
            this.UsernameLabelMsg.AutoSize = true;
            this.UsernameLabelMsg.Location = new System.Drawing.Point(267, 75);
            this.UsernameLabelMsg.Name = "UsernameLabelMsg";
            this.UsernameLabelMsg.Size = new System.Drawing.Size(0, 13);
            this.UsernameLabelMsg.TabIndex = 5;
            // 
            // PasswordLabelMsg
            // 
            this.PasswordLabelMsg.AutoSize = true;
            this.PasswordLabelMsg.Location = new System.Drawing.Point(267, 121);
            this.PasswordLabelMsg.Name = "PasswordLabelMsg";
            this.PasswordLabelMsg.Size = new System.Drawing.Size(0, 13);
            this.PasswordLabelMsg.TabIndex = 6;
            // 
            // countyComboBox
            // 
            this.countyComboBox.FormattingEnabled = true;
            this.countyComboBox.Location = new System.Drawing.Point(17, 70);
            this.countyComboBox.Name = "countyComboBox";
            this.countyComboBox.Size = new System.Drawing.Size(121, 21);
            this.countyComboBox.TabIndex = 7;
            this.countyComboBox.SelectedIndexChanged += new System.EventHandler(this.countyComboBox_SelectedIndexChanged);
            // 
            // rezervBtn
            // 
            this.rezervBtn.Location = new System.Drawing.Point(192, 231);
            this.rezervBtn.Name = "rezervBtn";
            this.rezervBtn.Size = new System.Drawing.Size(75, 23);
            this.rezervBtn.TabIndex = 16;
            this.rezervBtn.Text = "Rezerv";
            this.rezervBtn.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "County";
            // 
            // cityComboBox
            // 
            this.cityComboBox.FormattingEnabled = true;
            this.cityComboBox.Location = new System.Drawing.Point(17, 118);
            this.cityComboBox.Name = "cityComboBox";
            this.cityComboBox.Size = new System.Drawing.Size(121, 21);
            this.cityComboBox.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "City";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(273, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(315, 150);
            this.dataGridView1.TabIndex = 25;
            // 
            // pageTextBox
            // 
            this.pageTextBox.Location = new System.Drawing.Point(405, 178);
            this.pageTextBox.Name = "pageTextBox";
            this.pageTextBox.Size = new System.Drawing.Size(50, 20);
            this.pageTextBox.TabIndex = 26;
            // 
            // previousButton
            // 
            this.previousButton.Location = new System.Drawing.Point(339, 187);
            this.previousButton.Name = "previousButton";
            this.previousButton.Size = new System.Drawing.Size(60, 23);
            this.previousButton.TabIndex = 27;
            this.previousButton.Text = "Previous";
            this.previousButton.UseVisualStyleBackColor = true;
            this.previousButton.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(461, 187);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(54, 23);
            this.nextButton.TabIndex = 28;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // errorMessageLabel
            // 
            this.errorMessageLabel.AutoSize = true;
            this.errorMessageLabel.Location = new System.Drawing.Point(421, 231);
            this.errorMessageLabel.Name = "errorMessageLabel";
            this.errorMessageLabel.Size = new System.Drawing.Size(0, 13);
            this.errorMessageLabel.TabIndex = 29;
            // 
            // RezervationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 266);
            this.Controls.Add(this.errorMessageLabel);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.previousButton);
            this.Controls.Add(this.pageTextBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cityComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rezervBtn);
            this.Controls.Add(this.countyComboBox);
            this.Controls.Add(this.PasswordLabelMsg);
            this.Controls.Add(this.UsernameLabelMsg);
            this.Name = "RezervationForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label UsernameLabelMsg;
        private System.Windows.Forms.Label PasswordLabelMsg;
        private System.Windows.Forms.ComboBox countyComboBox;
        private System.Windows.Forms.Button rezervBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cityComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox pageTextBox;
        private System.Windows.Forms.Button previousButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Label errorMessageLabel;
    }
}

