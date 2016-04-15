namespace FinalProject
{
    partial class CreateExam
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
            this.lblExamName = new System.Windows.Forms.Label();
            this.txtExamName = new System.Windows.Forms.TextBox();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.lblTotalTime = new System.Windows.Forms.Label();
            this.lboxAllStudents = new System.Windows.Forms.ListBox();
            this.lboxSelectedStudents = new System.Windows.Forms.ListBox();
            this.lblSelectClass = new System.Windows.Forms.Label();
            this.cboxClass = new System.Windows.Forms.ComboBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblSelectStudents = new System.Windows.Forms.Label();
            this.lblHeading = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblExamName
            // 
            this.lblExamName.AutoSize = true;
            this.lblExamName.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExamName.Location = new System.Drawing.Point(92, 171);
            this.lblExamName.Name = "lblExamName";
            this.lblExamName.Size = new System.Drawing.Size(246, 29);
            this.lblExamName.TabIndex = 0;
            this.lblExamName.Text = "Enter Exam Name :";
            // 
            // txtExamName
            // 
            this.txtExamName.Location = new System.Drawing.Point(397, 171);
            this.txtExamName.Name = "txtExamName";
            this.txtExamName.Size = new System.Drawing.Size(232, 26);
            this.txtExamName.TabIndex = 1;
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(397, 244);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(108, 26);
            this.txtTime.TabIndex = 3;
            // 
            // lblTotalTime
            // 
            this.lblTotalTime.AutoSize = true;
            this.lblTotalTime.Font = new System.Drawing.Font("Verdana", 12F);
            this.lblTotalTime.Location = new System.Drawing.Point(97, 239);
            this.lblTotalTime.Name = "lblTotalTime";
            this.lblTotalTime.Size = new System.Drawing.Size(148, 29);
            this.lblTotalTime.TabIndex = 2;
            this.lblTotalTime.Text = "Total time :";
            // 
            // lboxAllStudents
            // 
            this.lboxAllStudents.FormattingEnabled = true;
            this.lboxAllStudents.ItemHeight = 20;
            this.lboxAllStudents.Location = new System.Drawing.Point(95, 464);
            this.lboxAllStudents.Name = "lboxAllStudents";
            this.lboxAllStudents.Size = new System.Drawing.Size(234, 204);
            this.lboxAllStudents.TabIndex = 4;
            // 
            // lboxSelectedStudents
            // 
            this.lboxSelectedStudents.FormattingEnabled = true;
            this.lboxSelectedStudents.ItemHeight = 20;
            this.lboxSelectedStudents.Location = new System.Drawing.Point(407, 464);
            this.lboxSelectedStudents.Name = "lboxSelectedStudents";
            this.lboxSelectedStudents.Size = new System.Drawing.Size(222, 204);
            this.lboxSelectedStudents.TabIndex = 5;
            // 
            // lblSelectClass
            // 
            this.lblSelectClass.AutoSize = true;
            this.lblSelectClass.Font = new System.Drawing.Font("Verdana", 12F);
            this.lblSelectClass.Location = new System.Drawing.Point(97, 312);
            this.lblSelectClass.Name = "lblSelectClass";
            this.lblSelectClass.Size = new System.Drawing.Size(175, 29);
            this.lblSelectClass.TabIndex = 6;
            this.lblSelectClass.Text = "Select Class :";
            // 
            // cboxClass
            // 
            this.cboxClass.FormattingEnabled = true;
            this.cboxClass.Location = new System.Drawing.Point(397, 317);
            this.cboxClass.Name = "cboxClass";
            this.cboxClass.Size = new System.Drawing.Size(121, 28);
            this.cboxClass.TabIndex = 7;
            // 
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("Verdana", 12F);
            this.btnCreate.Location = new System.Drawing.Point(112, 691);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(113, 44);
            this.btnCreate.TabIndex = 8;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Verdana", 12F);
            this.btnCancel.Location = new System.Drawing.Point(337, 691);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 45);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // lblSelectStudents
            // 
            this.lblSelectStudents.AutoSize = true;
            this.lblSelectStudents.Font = new System.Drawing.Font("Verdana", 12F);
            this.lblSelectStudents.Location = new System.Drawing.Point(97, 402);
            this.lblSelectStudents.Name = "lblSelectStudents";
            this.lblSelectStudents.Size = new System.Drawing.Size(218, 29);
            this.lblSelectStudents.TabIndex = 10;
            this.lblSelectStudents.Text = "Select Students :";
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Verdana", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.Location = new System.Drawing.Point(250, 62);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(216, 34);
            this.lblHeading.TabIndex = 11;
            this.lblHeading.Text = "Create Exam";
            // 
            // CreateExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 782);
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.lblSelectStudents);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.cboxClass);
            this.Controls.Add(this.lblSelectClass);
            this.Controls.Add(this.lboxSelectedStudents);
            this.Controls.Add(this.lboxAllStudents);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.lblTotalTime);
            this.Controls.Add(this.txtExamName);
            this.Controls.Add(this.lblExamName);
            this.Name = "CreateExam";
            this.Text = "CreateExam";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblExamName;
        private System.Windows.Forms.TextBox txtExamName;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Label lblTotalTime;
        private System.Windows.Forms.ListBox lboxAllStudents;
        private System.Windows.Forms.ListBox lboxSelectedStudents;
        private System.Windows.Forms.Label lblSelectClass;
        private System.Windows.Forms.ComboBox cboxClass;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblSelectStudents;
        private System.Windows.Forms.Label lblHeading;
    }
}