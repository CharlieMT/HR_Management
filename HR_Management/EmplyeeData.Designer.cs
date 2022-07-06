
namespace HR_Management
{
    partial class EmplyeeData
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
            this.lbID = new System.Windows.Forms.Label();
            this.lbDepartment = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbLastName = new System.Windows.Forms.Label();
            this.lbSalary = new System.Windows.Forms.Label();
            this.lbNumberOfVacationDays = new System.Windows.Forms.Label();
            this.lbUsedVacationDays = new System.Windows.Forms.Label();
            this.lbRemainingVacationDays = new System.Windows.Forms.Label();
            this.lbHireDay = new System.Windows.Forms.Label();
            this.lbComments = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tbEmployeeNumber = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.tbSalary = new System.Windows.Forms.TextBox();
            this.tbNumberOfVacationDays = new System.Windows.Forms.TextBox();
            this.tbUsedVacationDays = new System.Windows.Forms.TextBox();
            this.tbRemainVacationDays = new System.Windows.Forms.TextBox();
            this.rtbComments = new System.Windows.Forms.RichTextBox();
            this.cbxDepartment = new System.Windows.Forms.ComboBox();
            this.dtpHireDay = new System.Windows.Forms.DateTimePicker();
            this.dtpReleaseDay = new System.Windows.Forms.DateTimePicker();
            this.ckbSickLeave = new System.Windows.Forms.CheckBox();
            this.cbxReleaseWorker = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbID.Location = new System.Drawing.Point(30, 30);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(149, 20);
            this.lbID.TabIndex = 0;
            this.lbID.Text = "Numer Pracownika :";
            // 
            // lbDepartment
            // 
            this.lbDepartment.AutoSize = true;
            this.lbDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbDepartment.Location = new System.Drawing.Point(30, 80);
            this.lbDepartment.Name = "lbDepartment";
            this.lbDepartment.Size = new System.Drawing.Size(53, 20);
            this.lbDepartment.TabIndex = 1;
            this.lbDepartment.Text = "Dział :";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbName.Location = new System.Drawing.Point(30, 120);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(47, 20);
            this.lbName.TabIndex = 2;
            this.lbName.Text = "Imie :";
            // 
            // lbLastName
            // 
            this.lbLastName.AutoSize = true;
            this.lbLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbLastName.Location = new System.Drawing.Point(30, 160);
            this.lbLastName.Name = "lbLastName";
            this.lbLastName.Size = new System.Drawing.Size(84, 20);
            this.lbLastName.TabIndex = 3;
            this.lbLastName.Text = "Nazwisko :";
            // 
            // lbSalary
            // 
            this.lbSalary.AutoSize = true;
            this.lbSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbSalary.Location = new System.Drawing.Point(30, 200);
            this.lbSalary.Name = "lbSalary";
            this.lbSalary.Size = new System.Drawing.Size(127, 20);
            this.lbSalary.TabIndex = 4;
            this.lbSalary.Text = "Wynagrodzenie :";
            // 
            // lbNumberOfVacationDays
            // 
            this.lbNumberOfVacationDays.AutoSize = true;
            this.lbNumberOfVacationDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbNumberOfVacationDays.Location = new System.Drawing.Point(30, 240);
            this.lbNumberOfVacationDays.Name = "lbNumberOfVacationDays";
            this.lbNumberOfVacationDays.Size = new System.Drawing.Size(164, 20);
            this.lbNumberOfVacationDays.TabIndex = 5;
            this.lbNumberOfVacationDays.Text = "Ilość Dni Urlopowych :";
            // 
            // lbUsedVacationDays
            // 
            this.lbUsedVacationDays.AutoSize = true;
            this.lbUsedVacationDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbUsedVacationDays.Location = new System.Drawing.Point(30, 280);
            this.lbUsedVacationDays.Name = "lbUsedVacationDays";
            this.lbUsedVacationDays.Size = new System.Drawing.Size(210, 20);
            this.lbUsedVacationDays.TabIndex = 6;
            this.lbUsedVacationDays.Text = "Wykorzystane Dni Ulopowe :";
            // 
            // lbRemainingVacationDays
            // 
            this.lbRemainingVacationDays.AutoSize = true;
            this.lbRemainingVacationDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbRemainingVacationDays.Location = new System.Drawing.Point(30, 320);
            this.lbRemainingVacationDays.Name = "lbRemainingVacationDays";
            this.lbRemainingVacationDays.Size = new System.Drawing.Size(187, 20);
            this.lbRemainingVacationDays.TabIndex = 7;
            this.lbRemainingVacationDays.Text = "Pozostałe Dni Urlopowe :";
            // 
            // lbHireDay
            // 
            this.lbHireDay.AutoSize = true;
            this.lbHireDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbHireDay.Location = new System.Drawing.Point(30, 360);
            this.lbHireDay.Name = "lbHireDay";
            this.lbHireDay.Size = new System.Drawing.Size(151, 20);
            this.lbHireDay.TabIndex = 8;
            this.lbHireDay.Text = "Dzien Zatrudnienia :";
            // 
            // lbComments
            // 
            this.lbComments.AutoSize = true;
            this.lbComments.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbComments.Location = new System.Drawing.Point(30, 480);
            this.lbComments.Name = "lbComments";
            this.lbComments.Size = new System.Drawing.Size(103, 20);
            this.lbComments.TabIndex = 11;
            this.lbComments.Text = "Komentarze :";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Turquoise;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnSave.FlatAppearance.BorderSize = 2;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSave.Location = new System.Drawing.Point(150, 660);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 30);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Zapisz";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Orange;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnCancel.FlatAppearance.BorderSize = 2;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCancel.Location = new System.Drawing.Point(330, 660);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(120, 30);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Anuluj";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // tbEmployeeNumber
            // 
            this.tbEmployeeNumber.Location = new System.Drawing.Point(251, 30);
            this.tbEmployeeNumber.Name = "tbEmployeeNumber";
            this.tbEmployeeNumber.Size = new System.Drawing.Size(188, 20);
            this.tbEmployeeNumber.TabIndex = 14;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(251, 120);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(188, 20);
            this.tbName.TabIndex = 15;
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(251, 160);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(188, 20);
            this.tbLastName.TabIndex = 16;
            // 
            // tbSalary
            // 
            this.tbSalary.Location = new System.Drawing.Point(251, 200);
            this.tbSalary.Name = "tbSalary";
            this.tbSalary.Size = new System.Drawing.Size(188, 20);
            this.tbSalary.TabIndex = 17;
            // 
            // tbNumberOfVacationDays
            // 
            this.tbNumberOfVacationDays.Location = new System.Drawing.Point(251, 240);
            this.tbNumberOfVacationDays.Name = "tbNumberOfVacationDays";
            this.tbNumberOfVacationDays.Size = new System.Drawing.Size(188, 20);
            this.tbNumberOfVacationDays.TabIndex = 18;
            // 
            // tbUsedVacationDays
            // 
            this.tbUsedVacationDays.Location = new System.Drawing.Point(251, 280);
            this.tbUsedVacationDays.Name = "tbUsedVacationDays";
            this.tbUsedVacationDays.Size = new System.Drawing.Size(188, 20);
            this.tbUsedVacationDays.TabIndex = 19;
            // 
            // tbRemainVacationDays
            // 
            this.tbRemainVacationDays.Location = new System.Drawing.Point(251, 320);
            this.tbRemainVacationDays.Name = "tbRemainVacationDays";
            this.tbRemainVacationDays.Size = new System.Drawing.Size(188, 20);
            this.tbRemainVacationDays.TabIndex = 20;
            // 
            // rtbComments
            // 
            this.rtbComments.Location = new System.Drawing.Point(139, 480);
            this.rtbComments.Name = "rtbComments";
            this.rtbComments.Size = new System.Drawing.Size(381, 140);
            this.rtbComments.TabIndex = 21;
            this.rtbComments.Text = "";
            // 
            // cbxDepartment
            // 
            this.cbxDepartment.FormattingEnabled = true;
            this.cbxDepartment.Location = new System.Drawing.Point(251, 79);
            this.cbxDepartment.Name = "cbxDepartment";
            this.cbxDepartment.Size = new System.Drawing.Size(188, 21);
            this.cbxDepartment.TabIndex = 22;
            // 
            // dtpHireDay
            // 
            this.dtpHireDay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHireDay.Location = new System.Drawing.Point(251, 359);
            this.dtpHireDay.Name = "dtpHireDay";
            this.dtpHireDay.Size = new System.Drawing.Size(188, 20);
            this.dtpHireDay.TabIndex = 23;
            // 
            // dtpReleaseDay
            // 
            this.dtpReleaseDay.CustomFormat = " ";
            this.dtpReleaseDay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpReleaseDay.Location = new System.Drawing.Point(251, 399);
            this.dtpReleaseDay.Name = "dtpReleaseDay";
            this.dtpReleaseDay.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dtpReleaseDay.Size = new System.Drawing.Size(188, 20);
            this.dtpReleaseDay.TabIndex = 24;
            // 
            // ckbSickLeave
            // 
            this.ckbSickLeave.AutoSize = true;
            this.ckbSickLeave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ckbSickLeave.Location = new System.Drawing.Point(23, 437);
            this.ckbSickLeave.Name = "ckbSickLeave";
            this.ckbSickLeave.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ckbSickLeave.Size = new System.Drawing.Size(121, 24);
            this.ckbSickLeave.TabIndex = 25;
            this.ckbSickLeave.Text = ": Chorobowe ";
            this.ckbSickLeave.UseVisualStyleBackColor = true;
            // 
            // cbxReleaseWorker
            // 
            this.cbxReleaseWorker.AutoSize = true;
            this.cbxReleaseWorker.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbxReleaseWorker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbxReleaseWorker.Location = new System.Drawing.Point(17, 394);
            this.cbxReleaseWorker.Name = "cbxReleaseWorker";
            this.cbxReleaseWorker.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbxReleaseWorker.Size = new System.Drawing.Size(116, 25);
            this.cbxReleaseWorker.TabIndex = 26;
            this.cbxReleaseWorker.Text = " : Zwolniony";
            this.cbxReleaseWorker.UseVisualStyleBackColor = true;
            this.cbxReleaseWorker.CheckedChanged += new System.EventHandler(this.cbxReleaseWorker_CheckedChanged);
            // 
            // EmplyeeData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 726);
            this.Controls.Add(this.cbxReleaseWorker);
            this.Controls.Add(this.ckbSickLeave);
            this.Controls.Add(this.dtpReleaseDay);
            this.Controls.Add(this.dtpHireDay);
            this.Controls.Add(this.cbxDepartment);
            this.Controls.Add(this.rtbComments);
            this.Controls.Add(this.tbRemainVacationDays);
            this.Controls.Add(this.tbUsedVacationDays);
            this.Controls.Add(this.tbNumberOfVacationDays);
            this.Controls.Add(this.tbSalary);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbEmployeeNumber);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lbComments);
            this.Controls.Add(this.lbHireDay);
            this.Controls.Add(this.lbRemainingVacationDays);
            this.Controls.Add(this.lbUsedVacationDays);
            this.Controls.Add(this.lbNumberOfVacationDays);
            this.Controls.Add(this.lbSalary);
            this.Controls.Add(this.lbLastName);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.lbDepartment);
            this.Controls.Add(this.lbID);
            this.Name = "EmplyeeData";
            this.Text = "EmplyeeData";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Label lbDepartment;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbLastName;
        private System.Windows.Forms.Label lbSalary;
        private System.Windows.Forms.Label lbNumberOfVacationDays;
        private System.Windows.Forms.Label lbUsedVacationDays;
        private System.Windows.Forms.Label lbRemainingVacationDays;
        private System.Windows.Forms.Label lbHireDay;
        private System.Windows.Forms.Label lbComments;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox tbEmployeeNumber;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.TextBox tbSalary;
        private System.Windows.Forms.TextBox tbNumberOfVacationDays;
        private System.Windows.Forms.TextBox tbUsedVacationDays;
        private System.Windows.Forms.TextBox tbRemainVacationDays;
        private System.Windows.Forms.RichTextBox rtbComments;
        private System.Windows.Forms.ComboBox cbxDepartment;
        private System.Windows.Forms.DateTimePicker dtpHireDay;
        private System.Windows.Forms.DateTimePicker dtpReleaseDay;
        private System.Windows.Forms.CheckBox ckbSickLeave;
        private System.Windows.Forms.CheckBox cbxReleaseWorker;
    }
}