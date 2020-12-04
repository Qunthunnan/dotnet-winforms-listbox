
namespace WinFormsLists
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.employeesListBox = new System.Windows.Forms.ListBox();
            this.SelectedEmployeeLabel = new System.Windows.Forms.Label();
            this.selectedEmployeeValueLabel = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.addButton = new System.Windows.Forms.Button();
            this.salaryLabel = new System.Windows.Forms.Label();
            this.salaryTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.removeButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // employeesListBox
            // 
            this.employeesListBox.FormattingEnabled = true;
            this.employeesListBox.Location = new System.Drawing.Point(6, 39);
            this.employeesListBox.Name = "employeesListBox";
            this.employeesListBox.Size = new System.Drawing.Size(512, 407);
            this.employeesListBox.TabIndex = 0;
            this.employeesListBox.SelectedIndexChanged += new System.EventHandler(this.employeesListBox_SelectedIndexChanged);
            this.employeesListBox.SelectedValueChanged += new System.EventHandler(this.employeesListBox_SelectedValueChanged);
            // 
            // SelectedEmployeeLabel
            // 
            this.SelectedEmployeeLabel.AutoSize = true;
            this.SelectedEmployeeLabel.Location = new System.Drawing.Point(6, 9);
            this.SelectedEmployeeLabel.Name = "SelectedEmployeeLabel";
            this.SelectedEmployeeLabel.Size = new System.Drawing.Size(101, 13);
            this.SelectedEmployeeLabel.TabIndex = 1;
            this.SelectedEmployeeLabel.Text = "Selected Employee:";
            // 
            // selectedEmployeeValueLabel
            // 
            this.selectedEmployeeValueLabel.AutoSize = true;
            this.selectedEmployeeValueLabel.Location = new System.Drawing.Point(113, 9);
            this.selectedEmployeeValueLabel.Name = "selectedEmployeeValueLabel";
            this.selectedEmployeeValueLabel.Size = new System.Drawing.Size(0, 13);
            this.selectedEmployeeValueLabel.TabIndex = 2;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.editButton);
            this.splitContainer1.Panel1.Controls.Add(this.addButton);
            this.splitContainer1.Panel1.Controls.Add(this.salaryLabel);
            this.splitContainer1.Panel1.Controls.Add(this.salaryTextBox);
            this.splitContainer1.Panel1.Controls.Add(this.nameLabel);
            this.splitContainer1.Panel1.Controls.Add(this.nameTextBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.progressBar);
            this.splitContainer1.Panel2.Controls.Add(this.removeButton);
            this.splitContainer1.Panel2.Controls.Add(this.employeesListBox);
            this.splitContainer1.Panel2.Controls.Add(this.selectedEmployeeValueLabel);
            this.splitContainer1.Panel2.Controls.Add(this.SelectedEmployeeLabel);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 266;
            this.splitContainer1.TabIndex = 3;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(15, 77);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 6;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // salaryLabel
            // 
            this.salaryLabel.AutoSize = true;
            this.salaryLabel.Location = new System.Drawing.Point(12, 42);
            this.salaryLabel.Name = "salaryLabel";
            this.salaryLabel.Size = new System.Drawing.Size(39, 13);
            this.salaryLabel.TabIndex = 5;
            this.salaryLabel.Text = "Salary:";
            // 
            // salaryTextBox
            // 
            this.salaryTextBox.Location = new System.Drawing.Point(56, 39);
            this.salaryTextBox.Name = "salaryTextBox";
            this.salaryTextBox.Size = new System.Drawing.Size(200, 20);
            this.salaryTextBox.TabIndex = 4;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(12, 12);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(38, 13);
            this.nameLabel.TabIndex = 3;
            this.nameLabel.Text = "Name:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(56, 9);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(200, 20);
            this.nameTextBox.TabIndex = 0;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(150, 10);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(287, 23);
            this.progressBar.TabIndex = 4;
            this.progressBar.Visible = false;
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(443, 9);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(75, 23);
            this.removeButton.TabIndex = 3;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Visible = false;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(116, 76);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(75, 23);
            this.editButton.TabIndex = 7;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox employeesListBox;
        private System.Windows.Forms.Label SelectedEmployeeLabel;
        private System.Windows.Forms.Label selectedEmployeeValueLabel;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label salaryLabel;
        private System.Windows.Forms.TextBox salaryTextBox;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button editButton;
    }
}

