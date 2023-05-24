namespace HealthWorksApp
{
    partial class ViewAppointments
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddAppointment = new System.Windows.Forms.Button();
            this.btnDltAppointment = new System.Windows.Forms.Button();
            this.btnEditAppointment = new System.Windows.Forms.Button();
            this.lstAppointments = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.SearchAppointment = new System.Windows.Forms.Button();
            this.txtSearchApp = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.56818F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.43182F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lstAppointments, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.43737F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.56263F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(719, 376);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.btnAddAppointment);
            this.flowLayoutPanel2.Controls.Add(this.btnDltAppointment);
            this.flowLayoutPanel2.Controls.Add(this.btnEditAppointment);
            this.flowLayoutPanel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(365, 2);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(352, 50);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // btnAddAppointment
            // 
            this.btnAddAppointment.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddAppointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAppointment.Location = new System.Drawing.Point(2, 2);
            this.btnAddAppointment.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddAppointment.Name = "btnAddAppointment";
            this.btnAddAppointment.Size = new System.Drawing.Size(76, 24);
            this.btnAddAppointment.TabIndex = 2;
            this.btnAddAppointment.Text = "Add";
            this.btnAddAppointment.UseVisualStyleBackColor = true;
            // 
            // btnDltAppointment
            // 
            this.btnDltAppointment.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDltAppointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDltAppointment.Location = new System.Drawing.Point(82, 2);
            this.btnDltAppointment.Margin = new System.Windows.Forms.Padding(2);
            this.btnDltAppointment.Name = "btnDltAppointment";
            this.btnDltAppointment.Size = new System.Drawing.Size(100, 24);
            this.btnDltAppointment.TabIndex = 3;
            this.btnDltAppointment.Text = "Delete";
            this.btnDltAppointment.UseVisualStyleBackColor = true;
            // 
            // btnEditAppointment
            // 
            this.btnEditAppointment.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEditAppointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditAppointment.Location = new System.Drawing.Point(186, 2);
            this.btnEditAppointment.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditAppointment.Name = "btnEditAppointment";
            this.btnEditAppointment.Size = new System.Drawing.Size(95, 24);
            this.btnEditAppointment.TabIndex = 4;
            this.btnEditAppointment.Text = "Edit";
            this.btnEditAppointment.UseVisualStyleBackColor = true;
            // 
            // lstAppointments
            // 
            this.lstAppointments.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.lstAppointments.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.tableLayoutPanel1.SetColumnSpan(this.lstAppointments, 2);
            this.lstAppointments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstAppointments.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstAppointments.GridLines = true;
            this.lstAppointments.HideSelection = false;
            this.lstAppointments.Location = new System.Drawing.Point(2, 56);
            this.lstAppointments.Margin = new System.Windows.Forms.Padding(2);
            this.lstAppointments.Name = "lstAppointments";
            this.lstAppointments.Size = new System.Drawing.Size(715, 318);
            this.lstAppointments.TabIndex = 2;
            this.lstAppointments.UseCompatibleStateImageBehavior = false;
            this.lstAppointments.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 203;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Mobile No";
            this.columnHeader2.Width = 154;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Age";
            this.columnHeader3.Width = 62;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Date";
            this.columnHeader4.Width = 92;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Time";
            this.columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Amout";
            this.columnHeader6.Width = 97;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.26893F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.73107F));
            this.tableLayoutPanel2.Controls.Add(this.SearchAppointment, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtSearchApp, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(357, 48);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // SearchAppointment
            // 
            this.SearchAppointment.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SearchAppointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchAppointment.Location = new System.Drawing.Point(235, 11);
            this.SearchAppointment.Margin = new System.Windows.Forms.Padding(2);
            this.SearchAppointment.Name = "SearchAppointment";
            this.SearchAppointment.Size = new System.Drawing.Size(98, 25);
            this.SearchAppointment.TabIndex = 7;
            this.SearchAppointment.Text = "SEARCH";
            this.SearchAppointment.UseVisualStyleBackColor = true;
            // 
            // txtSearchApp
            // 
            this.txtSearchApp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSearchApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchApp.Location = new System.Drawing.Point(2, 11);
            this.txtSearchApp.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearchApp.Name = "txtSearchApp";
            this.txtSearchApp.Size = new System.Drawing.Size(207, 26);
            this.txtSearchApp.TabIndex = 6;
            // 
            // ViewAppointments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 376);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ViewAppointments";
            this.Text = "View Appointments";
            this.Load += new System.EventHandler(this.ViewAppointments_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button btnAddAppointment;
        private System.Windows.Forms.Button btnDltAppointment;
        private System.Windows.Forms.Button btnEditAppointment;
        private System.Windows.Forms.ListView lstAppointments;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button SearchAppointment;
        private System.Windows.Forms.TextBox txtSearchApp;
    }
}