﻿namespace Project_HR_Management
{
    partial class frmDepartment
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDepName = new System.Windows.Forms.TextBox();
            this.btnDepInsert = new System.Windows.Forms.Button();
            this.lblMsgShow = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Aqua;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(101, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Department";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(2, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Department Name:";
            // 
            // txtDepName
            // 
            this.txtDepName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDepName.Location = new System.Drawing.Point(168, 47);
            this.txtDepName.Name = "txtDepName";
            this.txtDepName.Size = new System.Drawing.Size(172, 26);
            this.txtDepName.TabIndex = 2;
            // 
            // btnDepInsert
            // 
            this.btnDepInsert.BackColor = System.Drawing.Color.Lime;
            this.btnDepInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDepInsert.Location = new System.Drawing.Point(246, 96);
            this.btnDepInsert.Name = "btnDepInsert";
            this.btnDepInsert.Size = new System.Drawing.Size(80, 30);
            this.btnDepInsert.TabIndex = 3;
            this.btnDepInsert.Text = "Insert";
            this.btnDepInsert.UseVisualStyleBackColor = false;
            this.btnDepInsert.Click += new System.EventHandler(this.btnDepInsert_Click);
            // 
            // lblMsgShow
            // 
            this.lblMsgShow.AutoSize = true;
            this.lblMsgShow.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblMsgShow.Location = new System.Drawing.Point(275, 96);
            this.lblMsgShow.Name = "lblMsgShow";
            this.lblMsgShow.Size = new System.Drawing.Size(0, 20);
            this.lblMsgShow.TabIndex = 4;
            // 
            // frmDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(352, 148);
            this.Controls.Add(this.lblMsgShow);
            this.Controls.Add(this.btnDepInsert);
            this.Controls.Add(this.txtDepName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmDepartment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Department";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDepName;
        private System.Windows.Forms.Button btnDepInsert;
        private System.Windows.Forms.Label lblMsgShow;
    }
}