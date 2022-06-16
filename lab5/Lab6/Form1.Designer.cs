
namespace Lab6
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
            this.addMovieLabel = new System.Windows.Forms.Label();
            this.GoodTypeComboBox = new System.Windows.Forms.ComboBox();
            this.movieCategoryLabel = new System.Windows.Forms.Label();
            this.movieNameLabel = new System.Windows.Forms.Label();
            this.NameAndSurnameTextBox = new System.Windows.Forms.TextBox();
            this.addMovieButton = new System.Windows.Forms.Button();
            this.carDataGridView = new System.Windows.Forms.DataGridView();
            this.saveToFileButton = new System.Windows.Forms.Button();
            this.loadFromFileButton = new System.Windows.Forms.Button();
            this.fileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.movieDescriptionLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ModelTextBox = new System.Windows.Forms.TextBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.success = new System.Windows.Forms.RadioButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.model1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.executionTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.result = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameAndSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.carDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // addMovieLabel
            // 
            this.addMovieLabel.AutoSize = true;
            this.addMovieLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMovieLabel.Location = new System.Drawing.Point(403, 30);
            this.addMovieLabel.Name = "addMovieLabel";
            this.addMovieLabel.Size = new System.Drawing.Size(99, 32);
            this.addMovieLabel.TabIndex = 0;
            this.addMovieLabel.Text = "Goods";
            this.addMovieLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GoodTypeComboBox
            // 
            this.GoodTypeComboBox.FormattingEnabled = true;
            this.GoodTypeComboBox.Location = new System.Drawing.Point(255, 183);
            this.GoodTypeComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GoodTypeComboBox.Name = "GoodTypeComboBox";
            this.GoodTypeComboBox.Size = new System.Drawing.Size(286, 28);
            this.GoodTypeComboBox.TabIndex = 1;
            // 
            // movieCategoryLabel
            // 
            this.movieCategoryLabel.AutoSize = true;
            this.movieCategoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movieCategoryLabel.Location = new System.Drawing.Point(45, 130);
            this.movieCategoryLabel.Name = "movieCategoryLabel";
            this.movieCategoryLabel.Size = new System.Drawing.Size(204, 26);
            this.movieCategoryLabel.TabIndex = 2;
            this.movieCategoryLabel.Text = "Name and surname";
            this.movieCategoryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // movieNameLabel
            // 
            this.movieNameLabel.AutoSize = true;
            this.movieNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movieNameLabel.Location = new System.Drawing.Point(45, 185);
            this.movieNameLabel.Name = "movieNameLabel";
            this.movieNameLabel.Size = new System.Drawing.Size(112, 26);
            this.movieNameLabel.TabIndex = 3;
            this.movieNameLabel.Text = "Good type";
            this.movieNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.movieNameLabel.Click += new System.EventHandler(this.movieNameLabel_Click);
            // 
            // NameAndSurnameTextBox
            // 
            this.NameAndSurnameTextBox.Location = new System.Drawing.Point(255, 132);
            this.NameAndSurnameTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NameAndSurnameTextBox.Name = "NameAndSurnameTextBox";
            this.NameAndSurnameTextBox.Size = new System.Drawing.Size(286, 26);
            this.NameAndSurnameTextBox.TabIndex = 4;
            // 
            // addMovieButton
            // 
            this.addMovieButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMovieButton.Location = new System.Drawing.Point(562, 104);
            this.addMovieButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addMovieButton.Name = "addMovieButton";
            this.addMovieButton.Size = new System.Drawing.Size(274, 75);
            this.addMovieButton.TabIndex = 5;
            this.addMovieButton.Text = "Add Good";
            this.addMovieButton.UseVisualStyleBackColor = true;
            this.addMovieButton.Click += new System.EventHandler(this.addMovieButton_Click);
            // 
            // carDataGridView
            // 
            this.carDataGridView.AllowUserToAddRows = false;
            this.carDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.carDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Type,
            this.model1,
            this.date,
            this.executionTime,
            this.result,
            this.nameAndSurname});
            this.carDataGridView.Location = new System.Drawing.Point(50, 480);
            this.carDataGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.carDataGridView.Name = "carDataGridView";
            this.carDataGridView.RowHeadersVisible = false;
            this.carDataGridView.RowHeadersWidth = 51;
            this.carDataGridView.RowTemplate.Height = 24;
            this.carDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.carDataGridView.Size = new System.Drawing.Size(878, 270);
            this.carDataGridView.TabIndex = 6;
            this.carDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.carDataGridView_CellContentClick);
            // 
            // saveToFileButton
            // 
            this.saveToFileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveToFileButton.Location = new System.Drawing.Point(562, 205);
            this.saveToFileButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.saveToFileButton.Name = "saveToFileButton";
            this.saveToFileButton.Size = new System.Drawing.Size(274, 75);
            this.saveToFileButton.TabIndex = 7;
            this.saveToFileButton.Text = "Save To File";
            this.saveToFileButton.UseVisualStyleBackColor = true;
            this.saveToFileButton.Click += new System.EventHandler(this.saveToFileButton_Click);
            // 
            // loadFromFileButton
            // 
            this.loadFromFileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadFromFileButton.Location = new System.Drawing.Point(562, 309);
            this.loadFromFileButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.loadFromFileButton.Name = "loadFromFileButton";
            this.loadFromFileButton.Size = new System.Drawing.Size(274, 80);
            this.loadFromFileButton.TabIndex = 8;
            this.loadFromFileButton.Text = "Load From File";
            this.loadFromFileButton.UseVisualStyleBackColor = true;
            this.loadFromFileButton.Click += new System.EventHandler(this.loadFromFileButton_Click);
            // 
            // fileDialog
            // 
            this.fileDialog.FileName = "openFileDialog1";
            // 
            // movieDescriptionLabel
            // 
            this.movieDescriptionLabel.AutoSize = true;
            this.movieDescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movieDescriptionLabel.Location = new System.Drawing.Point(45, 232);
            this.movieDescriptionLabel.Name = "movieDescriptionLabel";
            this.movieDescriptionLabel.Size = new System.Drawing.Size(72, 26);
            this.movieDescriptionLabel.TabIndex = 9;
            this.movieDescriptionLabel.Text = "model";
            this.movieDescriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 284);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 26);
            this.label1.TabIndex = 11;
            this.label1.Text = "date";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 332);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 26);
            this.label2.TabIndex = 12;
            this.label2.Text = "result";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 375);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 26);
            this.label3.TabIndex = 13;
            this.label3.Text = "execution time";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ModelTextBox
            // 
            this.ModelTextBox.Location = new System.Drawing.Point(255, 232);
            this.ModelTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ModelTextBox.Name = "ModelTextBox";
            this.ModelTextBox.Size = new System.Drawing.Size(286, 26);
            this.ModelTextBox.TabIndex = 15;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(255, 375);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker2.TabIndex = 21;
            // 
            // success
            // 
            this.success.AutoSize = true;
            this.success.Location = new System.Drawing.Point(255, 332);
            this.success.Name = "success";
            this.success.Size = new System.Drawing.Size(95, 24);
            this.success.TabIndex = 22;
            this.success.TabStop = true;
            this.success.Text = "Success";
            this.success.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(255, 284);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker1.TabIndex = 20;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.Width = 125;
            // 
            // Type
            // 
            this.Type.HeaderText = "Type";
            this.Type.MinimumWidth = 6;
            this.Type.Name = "Type";
            this.Type.Width = 125;
            // 
            // model1
            // 
            this.model1.HeaderText = "model";
            this.model1.MinimumWidth = 6;
            this.model1.Name = "model1";
            this.model1.Width = 125;
            // 
            // date
            // 
            this.date.HeaderText = "date";
            this.date.MinimumWidth = 6;
            this.date.Name = "date";
            this.date.Width = 125;
            // 
            // executionTime
            // 
            this.executionTime.HeaderText = "execution date";
            this.executionTime.MinimumWidth = 6;
            this.executionTime.Name = "executionTime";
            this.executionTime.Width = 125;
            // 
            // result
            // 
            this.result.HeaderText = "Result";
            this.result.MinimumWidth = 6;
            this.result.Name = "result";
            this.result.Width = 125;
            // 
            // nameAndSurname
            // 
            this.nameAndSurname.HeaderText = "Name and surname";
            this.nameAndSurname.MinimumWidth = 6;
            this.nameAndSurname.Name = "nameAndSurname";
            this.nameAndSurname.Width = 125;
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker3.Location = new System.Drawing.Point(978, 216);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker3.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(974, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 20);
            this.label4.TabIndex = 24;
            this.label4.Text = "Select date";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(978, 263);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 72);
            this.button1.TabIndex = 25;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(974, 353);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 20);
            this.label5.TabIndex = 26;
            this.label5.Text = "Result:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1233, 785);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker3);
            this.Controls.Add(this.success);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.ModelTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NameAndSurnameTextBox);
            this.Controls.Add(this.GoodTypeComboBox);
            this.Controls.Add(this.movieCategoryLabel);
            this.Controls.Add(this.saveToFileButton);
            this.Controls.Add(this.movieNameLabel);
            this.Controls.Add(this.addMovieLabel);
            this.Controls.Add(this.addMovieButton);
            this.Controls.Add(this.movieDescriptionLabel);
            this.Controls.Add(this.loadFromFileButton);
            this.Controls.Add(this.carDataGridView);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Movie Creator";
            ((System.ComponentModel.ISupportInitialize)(this.carDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label addMovieLabel;
        private System.Windows.Forms.ComboBox GoodTypeComboBox;
        private System.Windows.Forms.Label movieCategoryLabel;
        private System.Windows.Forms.Label movieNameLabel;
        private System.Windows.Forms.TextBox NameAndSurnameTextBox;
        private System.Windows.Forms.Button addMovieButton;
        private System.Windows.Forms.DataGridView carDataGridView;
        private System.Windows.Forms.Button saveToFileButton;
        private System.Windows.Forms.Button loadFromFileButton;
        private System.Windows.Forms.OpenFileDialog fileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Label movieDescriptionLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ModelTextBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.RadioButton success;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn model1;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn executionTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn result;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameAndSurname;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
    }
}

