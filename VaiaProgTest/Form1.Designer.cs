namespace VaiaProgTest
{
    partial class form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabelLabel = new System.Windows.Forms.Label();
            this.dataEntriesGrid = new System.Windows.Forms.DataGridView();
            this.tableEntryID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableReadings = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableDateModified = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loadBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.addDataLabel = new System.Windows.Forms.Label();
            this.dataValue = new System.Windows.Forms.TextBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.averageLabel = new System.Windows.Forms.Label();
            this.averageVariable = new System.Windows.Forms.Label();
            this.exitBtn = new System.Windows.Forms.Button();
            this.addErrorLabel = new System.Windows.Forms.Label();
            this.loadErrorLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataEntriesGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // tabelLabel
            // 
            this.tabelLabel.AutoSize = true;
            this.tabelLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabelLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tabelLabel.Location = new System.Drawing.Point(12, 9);
            this.tabelLabel.Name = "tabelLabel";
            this.tabelLabel.Padding = new System.Windows.Forms.Padding(105, 0, 105, 0);
            this.tabelLabel.Size = new System.Drawing.Size(390, 30);
            this.tabelLabel.TabIndex = 0;
            this.tabelLabel.Text = "Gauge Readings\r\n";
            // 
            // dataEntriesGrid
            // 
            this.dataEntriesGrid.AllowUserToAddRows = false;
            this.dataEntriesGrid.AllowUserToDeleteRows = false;
            this.dataEntriesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataEntriesGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tableEntryID,
            this.tableReadings,
            this.tableDateModified});
            this.dataEntriesGrid.Location = new System.Drawing.Point(12, 42);
            this.dataEntriesGrid.Name = "dataEntriesGrid";
            this.dataEntriesGrid.RowTemplate.Height = 25;
            this.dataEntriesGrid.Size = new System.Drawing.Size(390, 350);
            this.dataEntriesGrid.TabIndex = 1;
            this.dataEntriesGrid.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataEntriesGrid_CellValueChanged);
            // 
            // tableEntryID
            // 
            this.tableEntryID.Frozen = true;
            this.tableEntryID.HeaderText = "Entry ID";
            this.tableEntryID.Name = "tableEntryID";
            this.tableEntryID.ReadOnly = true;
            this.tableEntryID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.tableEntryID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // tableReadings
            // 
            this.tableReadings.Frozen = true;
            this.tableReadings.HeaderText = "Readings";
            this.tableReadings.Name = "tableReadings";
            this.tableReadings.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.tableReadings.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // tableDateModified
            // 
            this.tableDateModified.Frozen = true;
            this.tableDateModified.HeaderText = "Date Modified";
            this.tableDateModified.Name = "tableDateModified";
            this.tableDateModified.ReadOnly = true;
            this.tableDateModified.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.tableDateModified.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.tableDateModified.Width = 150;
            // 
            // loadBtn
            // 
            this.loadBtn.Location = new System.Drawing.Point(12, 398);
            this.loadBtn.Name = "loadBtn";
            this.loadBtn.Size = new System.Drawing.Size(80, 40);
            this.loadBtn.TabIndex = 2;
            this.loadBtn.Text = "Load";
            this.loadBtn.UseVisualStyleBackColor = true;
            this.loadBtn.Click += new System.EventHandler(this.loadBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(98, 398);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(80, 40);
            this.saveBtn.TabIndex = 3;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // addDataLabel
            // 
            this.addDataLabel.AutoSize = true;
            this.addDataLabel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.addDataLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addDataLabel.Location = new System.Drawing.Point(408, 53);
            this.addDataLabel.Name = "addDataLabel";
            this.addDataLabel.Padding = new System.Windows.Forms.Padding(60, 0, 80, 65);
            this.addDataLabel.Size = new System.Drawing.Size(313, 95);
            this.addDataLabel.TabIndex = 4;
            this.addDataLabel.Text = "Add Data Entry";
            // 
            // dataValue
            // 
            this.dataValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dataValue.Location = new System.Drawing.Point(464, 96);
            this.dataValue.Name = "dataValue";
            this.dataValue.Size = new System.Drawing.Size(75, 29);
            this.dataValue.TabIndex = 5;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(586, 97);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(60, 29);
            this.addBtn.TabIndex = 6;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // averageLabel
            // 
            this.averageLabel.AutoSize = true;
            this.averageLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.averageLabel.Location = new System.Drawing.Point(408, 228);
            this.averageLabel.Name = "averageLabel";
            this.averageLabel.Size = new System.Drawing.Size(168, 30);
            this.averageLabel.TabIndex = 7;
            this.averageLabel.Text = "Gauge Average:";
            // 
            // averageVariable
            // 
            this.averageVariable.AutoSize = true;
            this.averageVariable.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.averageVariable.Location = new System.Drawing.Point(569, 229);
            this.averageVariable.Name = "averageVariable";
            this.averageVariable.Size = new System.Drawing.Size(26, 30);
            this.averageVariable.TabIndex = 8;
            this.averageVariable.Text = "0";
            this.averageVariable.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.Red;
            this.exitBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.exitBtn.ForeColor = System.Drawing.Color.White;
            this.exitBtn.Location = new System.Drawing.Point(620, 418);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(101, 44);
            this.exitBtn.TabIndex = 9;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // addErrorLabel
            // 
            this.addErrorLabel.AutoSize = true;
            this.addErrorLabel.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.addErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.addErrorLabel.Location = new System.Drawing.Point(464, 128);
            this.addErrorLabel.Name = "addErrorLabel";
            this.addErrorLabel.Size = new System.Drawing.Size(0, 15);
            this.addErrorLabel.TabIndex = 10;
            // 
            // loadErrorLabel
            // 
            this.loadErrorLabel.AutoSize = true;
            this.loadErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.loadErrorLabel.Location = new System.Drawing.Point(54, 447);
            this.loadErrorLabel.Name = "loadErrorLabel";
            this.loadErrorLabel.Size = new System.Drawing.Size(0, 15);
            this.loadErrorLabel.TabIndex = 11;
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 474);
            this.Controls.Add(this.loadErrorLabel);
            this.Controls.Add(this.addErrorLabel);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.averageVariable);
            this.Controls.Add(this.averageLabel);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.dataValue);
            this.Controls.Add(this.addDataLabel);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.loadBtn);
            this.Controls.Add(this.dataEntriesGrid);
            this.Controls.Add(this.tabelLabel);
            this.Name = "form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataEntriesGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label tabelLabel;
        private DataGridView dataEntriesGrid;
        private Button loadBtn;
        private Button saveBtn;
        private Label addDataLabel;
        private TextBox dataValue;
        private Button addBtn;
        private Label averageLabel;
        private Label averageVariable;
        private Button exitBtn;
        private Label addErrorLabel;
        private DataGridViewTextBoxColumn tableEntryID;
        private DataGridViewTextBoxColumn tableReadings;
        private DataGridViewTextBoxColumn tableDateModified;
        private Label loadErrorLabel;
    }
}