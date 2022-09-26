
namespace _451_Database_UI
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
            this.stateBox = new System.Windows.Forms.ListBox();
            this.stateSearch = new System.Windows.Forms.TextBox();
            this.selectedState = new System.Windows.Forms.Label();
            this.cityBox = new System.Windows.Forms.ListBox();
            this.selectedCity = new System.Windows.Forms.Label();
            this.citySearch = new System.Windows.Forms.TextBox();
            this.zipBox = new System.Windows.Forms.ListBox();
            this.zipSearch = new System.Windows.Forms.TextBox();
            this.selectedZip = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.stateHeading = new System.Windows.Forms.Label();
            this.categoryHeading = new System.Windows.Forms.Label();
            this.cityHeading = new System.Windows.Forms.Label();
            this.zipHeading = new System.Windows.Forms.Label();
            this.businessTable = new System.Windows.Forms.DataGridView();
            this.businessTableName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stars = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.businessID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipBox = new System.Windows.Forms.TextBox();
            this.tipHeading = new System.Windows.Forms.Label();
            this.tipText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tipUserID = new System.Windows.Forms.TextBox();
            this.tipUser = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.debugBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.businessTable)).BeginInit();
            this.SuspendLayout();
            // 
            // stateBox
            // 
            this.stateBox.FormattingEnabled = true;
            this.stateBox.ItemHeight = 16;
            this.stateBox.Location = new System.Drawing.Point(13, 38);
            this.stateBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.stateBox.Name = "stateBox";
            this.stateBox.Size = new System.Drawing.Size(120, 84);
            this.stateBox.TabIndex = 0;
            this.stateBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // stateSearch
            // 
            this.stateSearch.Location = new System.Drawing.Point(13, 127);
            this.stateSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.stateSearch.Name = "stateSearch";
            this.stateSearch.Size = new System.Drawing.Size(120, 22);
            this.stateSearch.TabIndex = 1;
            this.stateSearch.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // selectedState
            // 
            this.selectedState.AutoSize = true;
            this.selectedState.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedState.Location = new System.Drawing.Point(9, 151);
            this.selectedState.Name = "selectedState";
            this.selectedState.Size = new System.Drawing.Size(100, 17);
            this.selectedState.TabIndex = 2;
            this.selectedState.Text = "Selected State";
            // 
            // cityBox
            // 
            this.cityBox.FormattingEnabled = true;
            this.cityBox.ItemHeight = 16;
            this.cityBox.Location = new System.Drawing.Point(162, 38);
            this.cityBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cityBox.Name = "cityBox";
            this.cityBox.Size = new System.Drawing.Size(120, 84);
            this.cityBox.TabIndex = 3;
            this.cityBox.SelectedIndexChanged += new System.EventHandler(this.cityBox_SelectedIndexChanged);
            // 
            // selectedCity
            // 
            this.selectedCity.AutoSize = true;
            this.selectedCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedCity.Location = new System.Drawing.Point(158, 151);
            this.selectedCity.Name = "selectedCity";
            this.selectedCity.Size = new System.Drawing.Size(90, 17);
            this.selectedCity.TabIndex = 4;
            this.selectedCity.Text = "Selected City";
            // 
            // citySearch
            // 
            this.citySearch.Location = new System.Drawing.Point(162, 127);
            this.citySearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.citySearch.Name = "citySearch";
            this.citySearch.Size = new System.Drawing.Size(120, 22);
            this.citySearch.TabIndex = 5;
            this.citySearch.TextChanged += new System.EventHandler(this.citySearch_TextChanged);
            // 
            // zipBox
            // 
            this.zipBox.FormattingEnabled = true;
            this.zipBox.ItemHeight = 16;
            this.zipBox.Location = new System.Drawing.Point(310, 38);
            this.zipBox.Margin = new System.Windows.Forms.Padding(4);
            this.zipBox.Name = "zipBox";
            this.zipBox.Size = new System.Drawing.Size(120, 84);
            this.zipBox.TabIndex = 6;
            this.zipBox.SelectedValueChanged += new System.EventHandler(this.zipBox_SelectedValueChanged);
            // 
            // zipSearch
            // 
            this.zipSearch.Location = new System.Drawing.Point(310, 127);
            this.zipSearch.Margin = new System.Windows.Forms.Padding(4);
            this.zipSearch.Name = "zipSearch";
            this.zipSearch.Size = new System.Drawing.Size(120, 22);
            this.zipSearch.TabIndex = 7;
            this.zipSearch.TextChanged += new System.EventHandler(this.zipSearch_TextChanged);
            // 
            // selectedZip
            // 
            this.selectedZip.AutoSize = true;
            this.selectedZip.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedZip.Location = new System.Drawing.Point(306, 151);
            this.selectedZip.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.selectedZip.Name = "selectedZip";
            this.selectedZip.Size = new System.Drawing.Size(87, 17);
            this.selectedZip.TabIndex = 8;
            this.selectedZip.Text = "Selected Zip";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(458, 38);
            this.checkedListBox1.Margin = new System.Windows.Forms.Padding(4);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(157, 123);
            this.checkedListBox1.TabIndex = 11;
            this.checkedListBox1.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBox1_ItemCheck);
            // 
            // stateHeading
            // 
            this.stateHeading.AutoSize = true;
            this.stateHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stateHeading.Location = new System.Drawing.Point(9, 15);
            this.stateHeading.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.stateHeading.Name = "stateHeading";
            this.stateHeading.Size = new System.Drawing.Size(46, 17);
            this.stateHeading.TabIndex = 12;
            this.stateHeading.Text = "State";
            // 
            // categoryHeading
            // 
            this.categoryHeading.AutoSize = true;
            this.categoryHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryHeading.Location = new System.Drawing.Point(454, 18);
            this.categoryHeading.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.categoryHeading.Name = "categoryHeading";
            this.categoryHeading.Size = new System.Drawing.Size(73, 17);
            this.categoryHeading.TabIndex = 13;
            this.categoryHeading.Text = "Category";
            // 
            // cityHeading
            // 
            this.cityHeading.AutoSize = true;
            this.cityHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityHeading.Location = new System.Drawing.Point(158, 15);
            this.cityHeading.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cityHeading.Name = "cityHeading";
            this.cityHeading.Size = new System.Drawing.Size(35, 17);
            this.cityHeading.TabIndex = 14;
            this.cityHeading.Text = "City";
            // 
            // zipHeading
            // 
            this.zipHeading.AutoSize = true;
            this.zipHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zipHeading.Location = new System.Drawing.Point(306, 15);
            this.zipHeading.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.zipHeading.Name = "zipHeading";
            this.zipHeading.Size = new System.Drawing.Size(31, 17);
            this.zipHeading.TabIndex = 15;
            this.zipHeading.Text = "Zip";
            // 
            // businessTable
            // 
            this.businessTable.AllowUserToAddRows = false;
            this.businessTable.AllowUserToDeleteRows = false;
            this.businessTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.businessTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.businessTableName,
            this.Address,
            this.Stars,
            this.businessID});
            this.businessTable.Location = new System.Drawing.Point(13, 208);
            this.businessTable.MultiSelect = false;
            this.businessTable.Name = "businessTable";
            this.businessTable.ReadOnly = true;
            this.businessTable.RowHeadersWidth = 51;
            this.businessTable.RowTemplate.Height = 24;
            this.businessTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.businessTable.Size = new System.Drawing.Size(602, 230);
            this.businessTable.TabIndex = 16;
            this.businessTable.SelectionChanged += new System.EventHandler(this.businessTable_SelectionChanged);
            // 
            // businessTableName
            // 
            this.businessTableName.HeaderText = "Name";
            this.businessTableName.MinimumWidth = 6;
            this.businessTableName.Name = "businessTableName";
            this.businessTableName.ReadOnly = true;
            this.businessTableName.Width = 125;
            // 
            // Address
            // 
            this.Address.HeaderText = "Address";
            this.Address.MinimumWidth = 6;
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            this.Address.Width = 125;
            // 
            // Stars
            // 
            this.Stars.HeaderText = "Stars";
            this.Stars.MinimumWidth = 6;
            this.Stars.Name = "Stars";
            this.Stars.ReadOnly = true;
            this.Stars.Width = 125;
            // 
            // businessID
            // 
            this.businessID.HeaderText = "businessID";
            this.businessID.MinimumWidth = 6;
            this.businessID.Name = "businessID";
            this.businessID.ReadOnly = true;
            this.businessID.Visible = false;
            this.businessID.Width = 125;
            // 
            // tipBox
            // 
            this.tipBox.Location = new System.Drawing.Point(636, 38);
            this.tipBox.Multiline = true;
            this.tipBox.Name = "tipBox";
            this.tipBox.ReadOnly = true;
            this.tipBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tipBox.Size = new System.Drawing.Size(397, 140);
            this.tipBox.TabIndex = 17;
            // 
            // tipHeading
            // 
            this.tipHeading.AutoSize = true;
            this.tipHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipHeading.Location = new System.Drawing.Point(633, 18);
            this.tipHeading.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tipHeading.Name = "tipHeading";
            this.tipHeading.Size = new System.Drawing.Size(39, 17);
            this.tipHeading.TabIndex = 18;
            this.tipHeading.Text = "Tips";
            // 
            // tipText
            // 
            this.tipText.Location = new System.Drawing.Point(636, 265);
            this.tipText.Multiline = true;
            this.tipText.Name = "tipText";
            this.tipText.Size = new System.Drawing.Size(400, 173);
            this.tipText.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(633, 208);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "Write a new Tip";
            // 
            // tipUserID
            // 
            this.tipUserID.Location = new System.Drawing.Point(697, 237);
            this.tipUserID.Name = "tipUserID";
            this.tipUserID.Size = new System.Drawing.Size(92, 22);
            this.tipUserID.TabIndex = 21;
            // 
            // tipUser
            // 
            this.tipUser.AutoSize = true;
            this.tipUser.Location = new System.Drawing.Point(633, 240);
            this.tipUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tipUser.Name = "tipUser";
            this.tipUser.Size = new System.Drawing.Size(57, 17);
            this.tipUser.TabIndex = 22;
            this.tipUser.Text = "User id:";
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(946, 208);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(90, 23);
            this.submitButton.TabIndex = 23;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(796, 240);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 25;
            this.label2.Text = "Date:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd hh:mm:ss";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(848, 237);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(188, 22);
            this.dateTimePicker1.TabIndex = 26;
            // 
            // debugBox
            // 
            this.debugBox.Location = new System.Drawing.Point(623, 60);
            this.debugBox.Multiline = true;
            this.debugBox.Name = "debugBox";
            this.debugBox.Size = new System.Drawing.Size(281, 255);
            this.debugBox.TabIndex = 27;
            this.debugBox.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 451);
            this.Controls.Add(this.debugBox);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.tipUser);
            this.Controls.Add(this.tipUserID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tipText);
            this.Controls.Add(this.tipHeading);
            this.Controls.Add(this.tipBox);
            this.Controls.Add(this.businessTable);
            this.Controls.Add(this.zipHeading);
            this.Controls.Add(this.cityHeading);
            this.Controls.Add(this.categoryHeading);
            this.Controls.Add(this.stateHeading);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.selectedZip);
            this.Controls.Add(this.zipSearch);
            this.Controls.Add(this.zipBox);
            this.Controls.Add(this.citySearch);
            this.Controls.Add(this.selectedCity);
            this.Controls.Add(this.cityBox);
            this.Controls.Add(this.selectedState);
            this.Controls.Add(this.stateSearch);
            this.Controls.Add(this.stateBox);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.businessTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox stateBox;
        private System.Windows.Forms.TextBox stateSearch;
        private System.Windows.Forms.Label selectedState;
        private System.Windows.Forms.ListBox cityBox;
        private System.Windows.Forms.Label selectedCity;
        private System.Windows.Forms.TextBox citySearch;
        private System.Windows.Forms.ListBox zipBox;
        private System.Windows.Forms.TextBox zipSearch;
        private System.Windows.Forms.Label selectedZip;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label stateHeading;
        private System.Windows.Forms.Label categoryHeading;
        private System.Windows.Forms.Label cityHeading;
        private System.Windows.Forms.Label zipHeading;
        private System.Windows.Forms.DataGridView businessTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn businessTableName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stars;
        private System.Windows.Forms.DataGridViewTextBoxColumn businessID;
        private System.Windows.Forms.TextBox tipBox;
        private System.Windows.Forms.Label tipHeading;
        private System.Windows.Forms.TextBox tipText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tipUserID;
        private System.Windows.Forms.Label tipUser;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox debugBox;
    }
}

