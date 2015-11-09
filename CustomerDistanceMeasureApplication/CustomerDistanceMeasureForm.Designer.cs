namespace CustomerDistanceMeasureApplication
{
    partial class CustomerDistanceMeasureForm
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
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.ofdFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.btnCalculateDistance = new System.Windows.Forms.Button();
            this.dgvNearCustomers = new System.Windows.Forms.DataGridView();
            this.clm_user_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_latitude = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_longitude = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNearCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(12, 12);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(320, 20);
            this.txtFilePath.TabIndex = 0;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(338, 10);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(27, 23);
            this.btnBrowse.TabIndex = 1;
            this.btnBrowse.Text = "...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // ofdFileDialog
            // 
            this.ofdFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            this.ofdFileDialog.Title = "Choose a file";
            // 
            // btnCalculateDistance
            // 
            this.btnCalculateDistance.Location = new System.Drawing.Point(402, 10);
            this.btnCalculateDistance.Name = "btnCalculateDistance";
            this.btnCalculateDistance.Size = new System.Drawing.Size(123, 23);
            this.btnCalculateDistance.TabIndex = 2;
            this.btnCalculateDistance.Text = "Get Near Customers";
            this.btnCalculateDistance.UseVisualStyleBackColor = true;
            this.btnCalculateDistance.Click += new System.EventHandler(this.btnCalculateDistance_Click);
            // 
            // dgvNearCustomers
            // 
            this.dgvNearCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNearCustomers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clm_user_id,
            this.clm_name,
            this.clm_latitude,
            this.clm_longitude});
            this.dgvNearCustomers.Location = new System.Drawing.Point(12, 49);
            this.dgvNearCustomers.Name = "dgvNearCustomers";
            this.dgvNearCustomers.Size = new System.Drawing.Size(687, 254);
            this.dgvNearCustomers.TabIndex = 3;
            // 
            // clm_user_id
            // 
            this.clm_user_id.DataPropertyName = "user_id";
            this.clm_user_id.HeaderText = "ID";
            this.clm_user_id.Name = "clm_user_id";
            // 
            // clm_name
            // 
            this.clm_name.DataPropertyName = "name";
            this.clm_name.HeaderText = "Name";
            this.clm_name.Name = "clm_name";
            // 
            // clm_latitude
            // 
            this.clm_latitude.DataPropertyName = "latitude";
            this.clm_latitude.HeaderText = "Latitude";
            this.clm_latitude.Name = "clm_latitude";
            // 
            // clm_longitude
            // 
            this.clm_longitude.DataPropertyName = "longitude";
            this.clm_longitude.HeaderText = "Longitude";
            this.clm_longitude.Name = "clm_longitude";
            // 
            // CustomerDistanceMeasureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 315);
            this.Controls.Add(this.dgvNearCustomers);
            this.Controls.Add(this.btnCalculateDistance);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtFilePath);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "CustomerDistanceMeasureForm";
            this.Text = "Get Near Customers";
            ((System.ComponentModel.ISupportInitialize)(this.dgvNearCustomers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.OpenFileDialog ofdFileDialog;
        private System.Windows.Forms.Button btnCalculateDistance;
        private System.Windows.Forms.DataGridView dgvNearCustomers;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_user_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_latitude;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_longitude;
    }
}

