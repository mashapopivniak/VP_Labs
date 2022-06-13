
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
            this.movieCategoryLabel = new System.Windows.Forms.Label();
            this.movieNameLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.addMovieButton = new System.Windows.Forms.Button();
            this.carDataGridView = new System.Windows.Forms.DataGridView();
            this.CarId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flightNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departureTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flightDuration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destination = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saveToFileButton = new System.Windows.Forms.Button();
            this.loadFromFileButton = new System.Windows.Forms.Button();
            this.fileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.movieDescriptionLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.weightTextBox = new System.Windows.Forms.TextBox();
            this.flightNumberTextBox = new System.Windows.Forms.TextBox();
            this.departureTimeTextBox = new System.Windows.Forms.TextBox();
            this.flightDurationTextBox = new System.Windows.Forms.TextBox();
            this.destinationTextBox = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Search = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.carDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // addMovieLabel
            // 
            this.addMovieLabel.AutoSize = true;
            this.addMovieLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMovieLabel.Location = new System.Drawing.Point(358, 24);
            this.addMovieLabel.Name = "addMovieLabel";
            this.addMovieLabel.Size = new System.Drawing.Size(128, 29);
            this.addMovieLabel.TabIndex = 0;
            this.addMovieLabel.Text = "Passanger";
            this.addMovieLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // movieCategoryLabel
            // 
            this.movieCategoryLabel.AutoSize = true;
            this.movieCategoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movieCategoryLabel.Location = new System.Drawing.Point(44, 111);
            this.movieCategoryLabel.Name = "movieCategoryLabel";
            this.movieCategoryLabel.Size = new System.Drawing.Size(174, 24);
            this.movieCategoryLabel.TabIndex = 2;
            this.movieCategoryLabel.Text = "name and surname";
            this.movieCategoryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // movieNameLabel
            // 
            this.movieNameLabel.AutoSize = true;
            this.movieNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movieNameLabel.Location = new System.Drawing.Point(44, 191);
            this.movieNameLabel.Name = "movieNameLabel";
            this.movieNameLabel.Size = new System.Drawing.Size(45, 24);
            this.movieNameLabel.TabIndex = 3;
            this.movieNameLabel.Text = "time";
            this.movieNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(228, 111);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(255, 22);
            this.nameTextBox.TabIndex = 4;
            this.nameTextBox.TextChanged += new System.EventHandler(this.carProdYearTextBox_TextChanged);
            // 
            // addMovieButton
            // 
            this.addMovieButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMovieButton.Location = new System.Drawing.Point(500, 83);
            this.addMovieButton.Name = "addMovieButton";
            this.addMovieButton.Size = new System.Drawing.Size(244, 60);
            this.addMovieButton.TabIndex = 5;
            this.addMovieButton.Text = "Add Passanger";
            this.addMovieButton.UseVisualStyleBackColor = true;
            this.addMovieButton.Click += new System.EventHandler(this.addMovieButton_Click);
            // 
            // carDataGridView
            // 
            this.carDataGridView.AllowUserToAddRows = false;
            this.carDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.carDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CarId,
            this.name,
            this.weight,
            this.time,
            this.flightNumber,
            this.departureTime,
            this.flightDuration,
            this.destination});
            this.carDataGridView.Location = new System.Drawing.Point(44, 384);
            this.carDataGridView.Name = "carDataGridView";
            this.carDataGridView.RowHeadersVisible = false;
            this.carDataGridView.RowHeadersWidth = 51;
            this.carDataGridView.RowTemplate.Height = 24;
            this.carDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.carDataGridView.Size = new System.Drawing.Size(1001, 216);
            this.carDataGridView.TabIndex = 6;
            this.carDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.carDataGridView_CellContentClick);
            // 
            // CarId
            // 
            this.CarId.HeaderText = "Id";
            this.CarId.MinimumWidth = 6;
            this.CarId.Name = "CarId";
            this.CarId.Width = 125;
            // 
            // name
            // 
            this.name.HeaderText = "Name and Surname";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.Width = 125;
            // 
            // weight
            // 
            this.weight.HeaderText = "Weight of luggage";
            this.weight.MinimumWidth = 6;
            this.weight.Name = "weight";
            this.weight.Width = 125;
            // 
            // time
            // 
            this.time.HeaderText = "time";
            this.time.MinimumWidth = 6;
            this.time.Name = "time";
            this.time.Width = 125;
            // 
            // flightNumber
            // 
            this.flightNumber.HeaderText = "flight Number";
            this.flightNumber.MinimumWidth = 6;
            this.flightNumber.Name = "flightNumber";
            this.flightNumber.Width = 125;
            // 
            // departureTime
            // 
            this.departureTime.HeaderText = "departure time";
            this.departureTime.MinimumWidth = 6;
            this.departureTime.Name = "departureTime";
            this.departureTime.Width = 125;
            // 
            // flightDuration
            // 
            this.flightDuration.HeaderText = "flight duration";
            this.flightDuration.MinimumWidth = 6;
            this.flightDuration.Name = "flightDuration";
            this.flightDuration.Width = 125;
            // 
            // destination
            // 
            this.destination.HeaderText = "Destination";
            this.destination.MinimumWidth = 6;
            this.destination.Name = "destination";
            this.destination.Width = 125;
            // 
            // saveToFileButton
            // 
            this.saveToFileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveToFileButton.Location = new System.Drawing.Point(500, 164);
            this.saveToFileButton.Name = "saveToFileButton";
            this.saveToFileButton.Size = new System.Drawing.Size(244, 60);
            this.saveToFileButton.TabIndex = 7;
            this.saveToFileButton.Text = "Save To File";
            this.saveToFileButton.UseVisualStyleBackColor = true;
            this.saveToFileButton.Click += new System.EventHandler(this.saveToFileButton_Click);
            // 
            // loadFromFileButton
            // 
            this.loadFromFileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadFromFileButton.Location = new System.Drawing.Point(500, 247);
            this.loadFromFileButton.Name = "loadFromFileButton";
            this.loadFromFileButton.Size = new System.Drawing.Size(244, 64);
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
            this.movieDescriptionLabel.Location = new System.Drawing.Point(44, 152);
            this.movieDescriptionLabel.Name = "movieDescriptionLabel";
            this.movieDescriptionLabel.Size = new System.Drawing.Size(159, 24);
            this.movieDescriptionLabel.TabIndex = 9;
            this.movieDescriptionLabel.Text = "weight of luggage";
            this.movieDescriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.movieDescriptionLabel.Click += new System.EventHandler(this.movieDescriptionLabel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "flight number";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 266);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 24);
            this.label2.TabIndex = 12;
            this.label2.Text = "departure time";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 300);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 24);
            this.label3.TabIndex = 13;
            this.label3.Text = "flight duration";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(40, 336);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 24);
            this.label4.TabIndex = 14;
            this.label4.Text = "destination";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // weightTextBox
            // 
            this.weightTextBox.Location = new System.Drawing.Point(228, 154);
            this.weightTextBox.Name = "weightTextBox";
            this.weightTextBox.Size = new System.Drawing.Size(255, 22);
            this.weightTextBox.TabIndex = 15;
            // 
            // flightNumberTextBox
            // 
            this.flightNumberTextBox.Location = new System.Drawing.Point(228, 227);
            this.flightNumberTextBox.Name = "flightNumberTextBox";
            this.flightNumberTextBox.Size = new System.Drawing.Size(255, 22);
            this.flightNumberTextBox.TabIndex = 16;
            // 
            // departureTimeTextBox
            // 
            this.departureTimeTextBox.Location = new System.Drawing.Point(228, 266);
            this.departureTimeTextBox.Name = "departureTimeTextBox";
            this.departureTimeTextBox.Size = new System.Drawing.Size(255, 22);
            this.departureTimeTextBox.TabIndex = 17;
            // 
            // flightDurationTextBox
            // 
            this.flightDurationTextBox.Location = new System.Drawing.Point(228, 300);
            this.flightDurationTextBox.Name = "flightDurationTextBox";
            this.flightDurationTextBox.Size = new System.Drawing.Size(255, 22);
            this.flightDurationTextBox.TabIndex = 18;
            // 
            // destinationTextBox
            // 
            this.destinationTextBox.Location = new System.Drawing.Point(228, 338);
            this.destinationTextBox.Name = "destinationTextBox";
            this.destinationTextBox.Size = new System.Drawing.Size(255, 22);
            this.destinationTextBox.TabIndex = 19;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(228, 191);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(178, 22);
            this.dateTimePicker1.TabIndex = 20;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(812, 132);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(234, 22);
            this.textBox1.TabIndex = 21;
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(812, 167);
            this.Search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(234, 57);
            this.Search.TabIndex = 22;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(817, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 17);
            this.label5.TabIndex = 23;
            this.label5.Text = "Total weight:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(912, 270);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 17);
            this.label6.TabIndex = 24;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(812, 270);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(234, 51);
            this.button1.TabIndex = 25;
            this.button1.Text = "Full list";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 628);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.destinationTextBox);
            this.Controls.Add(this.flightDurationTextBox);
            this.Controls.Add(this.departureTimeTextBox);
            this.Controls.Add(this.flightNumberTextBox);
            this.Controls.Add(this.weightTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.movieCategoryLabel);
            this.Controls.Add(this.saveToFileButton);
            this.Controls.Add(this.movieNameLabel);
            this.Controls.Add(this.addMovieLabel);
            this.Controls.Add(this.addMovieButton);
            this.Controls.Add(this.movieDescriptionLabel);
            this.Controls.Add(this.loadFromFileButton);
            this.Controls.Add(this.carDataGridView);
            this.Name = "Form1";
            this.Text = "AviaPassanger Creator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.carDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label addMovieLabel;
        private System.Windows.Forms.Label movieCategoryLabel;
        private System.Windows.Forms.Label movieNameLabel;
        private System.Windows.Forms.TextBox nameTextBox;
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox weightTextBox;
        private System.Windows.Forms.TextBox flightNumberTextBox;
        private System.Windows.Forms.TextBox departureTimeTextBox;
        private System.Windows.Forms.TextBox flightDurationTextBox;
        private System.Windows.Forms.TextBox destinationTextBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarId;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn weight;
        private System.Windows.Forms.DataGridViewTextBoxColumn time;
        private System.Windows.Forms.DataGridViewTextBoxColumn flightNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn departureTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn flightDuration;
        private System.Windows.Forms.DataGridViewTextBoxColumn destination;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
    }
}

