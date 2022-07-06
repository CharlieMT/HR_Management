
namespace HR_Management
{
    partial class Main
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEddit = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.dgvEmployeeInfo = new System.Windows.Forms.DataGridView();
            this.lbFilterBy = new System.Windows.Forms.Label();
            this.cbxDepartmentFilter = new System.Windows.Forms.ComboBox();
            this.lbDepartment = new System.Windows.Forms.Label();
            this.lbWorking = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxWorkingFilter = new System.Windows.Forms.ComboBox();
            this.cbxSickFilter = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.LimeGreen;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAdd.FlatAppearance.BorderSize = 2;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAdd.Location = new System.Drawing.Point(30, 20);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 30);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Dodaj";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEddit
            // 
            this.btnEddit.BackColor = System.Drawing.Color.Orange;
            this.btnEddit.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnEddit.FlatAppearance.BorderSize = 4;
            this.btnEddit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEddit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnEddit.Location = new System.Drawing.Point(170, 20);
            this.btnEddit.Name = "btnEddit";
            this.btnEddit.Size = new System.Drawing.Size(100, 30);
            this.btnEddit.TabIndex = 1;
            this.btnEddit.Text = "Edytuj";
            this.btnEddit.UseVisualStyleBackColor = false;
            this.btnEddit.Click += new System.EventHandler(this.btnEddit_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnRefresh.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnRefresh.FlatAppearance.BorderSize = 4;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRefresh.Location = new System.Drawing.Point(310, 20);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(100, 30);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "Odswiez";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // dgvEmployeeInfo
            // 
            this.dgvEmployeeInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEmployeeInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmployeeInfo.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvEmployeeInfo.Location = new System.Drawing.Point(40, 140);
            this.dgvEmployeeInfo.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.dgvEmployeeInfo.MinimumSize = new System.Drawing.Size(600, 400);
            this.dgvEmployeeInfo.MultiSelect = false;
            this.dgvEmployeeInfo.Name = "dgvEmployeeInfo";
            this.dgvEmployeeInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmployeeInfo.Size = new System.Drawing.Size(800, 500);
            this.dgvEmployeeInfo.TabIndex = 3;
            // 
            // lbFilterBy
            // 
            this.lbFilterBy.AutoSize = true;
            this.lbFilterBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbFilterBy.Location = new System.Drawing.Point(26, 71);
            this.lbFilterBy.Name = "lbFilterBy";
            this.lbFilterBy.Size = new System.Drawing.Size(65, 20);
            this.lbFilterBy.TabIndex = 4;
            this.lbFilterBy.Text = "Filter : ";
            // 
            // cbxDepartmentFilter
            // 
            this.cbxDepartmentFilter.FormattingEnabled = true;
            this.cbxDepartmentFilter.Location = new System.Drawing.Point(100, 104);
            this.cbxDepartmentFilter.Name = "cbxDepartmentFilter";
            this.cbxDepartmentFilter.Size = new System.Drawing.Size(121, 21);
            this.cbxDepartmentFilter.TabIndex = 5;
            this.cbxDepartmentFilter.SelectionChangeCommitted += new System.EventHandler(this.cbxDepartmentFilter_SelectionChangeCommitted);
            // 
            // lbDepartment
            // 
            this.lbDepartment.AutoSize = true;
            this.lbDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbDepartment.Location = new System.Drawing.Point(131, 71);
            this.lbDepartment.Name = "lbDepartment";
            this.lbDepartment.Size = new System.Drawing.Size(50, 20);
            this.lbDepartment.TabIndex = 6;
            this.lbDepartment.Text = "Dział";
            // 
            // lbWorking
            // 
            this.lbWorking.AutoSize = true;
            this.lbWorking.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbWorking.Location = new System.Drawing.Point(300, 71);
            this.lbWorking.Name = "lbWorking";
            this.lbWorking.Size = new System.Drawing.Size(110, 20);
            this.lbWorking.TabIndex = 7;
            this.lbWorking.Text = "Zatrudnienie";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(525, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Chorobowe";
            // 
            // cbxWorkingFilter
            // 
            this.cbxWorkingFilter.FormattingEnabled = true;
            this.cbxWorkingFilter.Location = new System.Drawing.Point(290, 104);
            this.cbxWorkingFilter.Name = "cbxWorkingFilter";
            this.cbxWorkingFilter.Size = new System.Drawing.Size(135, 21);
            this.cbxWorkingFilter.TabIndex = 9;
            this.cbxWorkingFilter.SelectionChangeCommitted += new System.EventHandler(this.cbxWorkingFilter_SelectionChangeCommitted);
            // 
            // cbxSickFilter
            // 
            this.cbxSickFilter.FormattingEnabled = true;
            this.cbxSickFilter.Location = new System.Drawing.Point(518, 104);
            this.cbxSickFilter.Name = "cbxSickFilter";
            this.cbxSickFilter.Size = new System.Drawing.Size(121, 21);
            this.cbxSickFilter.TabIndex = 10;
            this.cbxSickFilter.SelectionChangeCommitted += new System.EventHandler(this.cbxSickFilter_SelectionChangeCommitted);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(884, 661);
            this.Controls.Add(this.cbxSickFilter);
            this.Controls.Add(this.cbxWorkingFilter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbWorking);
            this.Controls.Add(this.lbDepartment);
            this.Controls.Add(this.cbxDepartmentFilter);
            this.Controls.Add(this.lbFilterBy);
            this.Controls.Add(this.dgvEmployeeInfo);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnEddit);
            this.Controls.Add(this.btnAdd);
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HR_Management";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEddit;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView dgvEmployeeInfo;
        private System.Windows.Forms.Label lbFilterBy;
        private System.Windows.Forms.ComboBox cbxDepartmentFilter;
        private System.Windows.Forms.Label lbDepartment;
        private System.Windows.Forms.Label lbWorking;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxWorkingFilter;
        private System.Windows.Forms.ComboBox cbxSickFilter;
    }
}

