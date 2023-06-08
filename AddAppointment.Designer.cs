namespace HealthWorksApp
{
    partial class AddAppointment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddAppointment));
            this.TLPAppointment = new System.Windows.Forms.TableLayoutPanel();
            this.GBAppointment = new System.Windows.Forms.GroupBox();
            this.TLPAppointmentDetails = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.CBSelectDoc = new System.Windows.Forms.ComboBox();
            this.DTAppointmentDate = new System.Windows.Forms.DateTimePicker();
            this.DTAppointmentTime = new System.Windows.Forms.DateTimePicker();
            this.GBPatient = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMobileNo = new System.Windows.Forms.TextBox();
            this.txtPatientName = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.CBGender = new System.Windows.Forms.ComboBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.TLPAppointment.SuspendLayout();
            this.GBAppointment.SuspendLayout();
            this.TLPAppointmentDetails.SuspendLayout();
            this.GBPatient.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TLPAppointment
            // 
            this.TLPAppointment.ColumnCount = 1;
            this.TLPAppointment.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TLPAppointment.Controls.Add(this.GBAppointment, 0, 1);
            this.TLPAppointment.Controls.Add(this.GBPatient, 3, 0);
            this.TLPAppointment.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.TLPAppointment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLPAppointment.Location = new System.Drawing.Point(0, 0);
            this.TLPAppointment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TLPAppointment.Name = "TLPAppointment";
            this.TLPAppointment.RowCount = 3;
            this.TLPAppointment.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.62025F));
            this.TLPAppointment.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.37975F));
            this.TLPAppointment.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.TLPAppointment.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.TLPAppointment.Size = new System.Drawing.Size(663, 423);
            this.TLPAppointment.TabIndex = 0;
            // 
            // GBAppointment
            // 
            this.GBAppointment.Controls.Add(this.TLPAppointmentDetails);
            this.GBAppointment.Location = new System.Drawing.Point(3, 185);
            this.GBAppointment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GBAppointment.Name = "GBAppointment";
            this.GBAppointment.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GBAppointment.Size = new System.Drawing.Size(657, 181);
            this.GBAppointment.TabIndex = 1;
            this.GBAppointment.TabStop = false;
            this.GBAppointment.Text = "Appointment";
            this.GBAppointment.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // TLPAppointmentDetails
            // 
            this.TLPAppointmentDetails.ColumnCount = 3;
            this.TLPAppointmentDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.83471F));
            this.TLPAppointmentDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.16529F));
            this.TLPAppointmentDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 186F));
            this.TLPAppointmentDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.TLPAppointmentDetails.Controls.Add(this.label5, 0, 1);
            this.TLPAppointmentDetails.Controls.Add(this.label6, 0, 3);
            this.TLPAppointmentDetails.Controls.Add(this.label7, 0, 2);
            this.TLPAppointmentDetails.Controls.Add(this.label8, 0, 0);
            this.TLPAppointmentDetails.Controls.Add(this.txtAmount, 1, 3);
            this.TLPAppointmentDetails.Controls.Add(this.CBSelectDoc, 1, 0);
            this.TLPAppointmentDetails.Controls.Add(this.DTAppointmentDate, 1, 1);
            this.TLPAppointmentDetails.Controls.Add(this.DTAppointmentTime, 1, 2);
            this.TLPAppointmentDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLPAppointmentDetails.Location = new System.Drawing.Point(3, 17);
            this.TLPAppointmentDetails.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TLPAppointmentDetails.Name = "TLPAppointmentDetails";
            this.TLPAppointmentDetails.RowCount = 4;
            this.TLPAppointmentDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.00062F));
            this.TLPAppointmentDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.00063F));
            this.TLPAppointmentDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.00063F));
            this.TLPAppointmentDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.99813F));
            this.TLPAppointmentDetails.Size = new System.Drawing.Size(651, 162);
            this.TLPAppointmentDetails.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "Appointment Date";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(42, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 25);
            this.label6.TabIndex = 3;
            this.label6.Text = "Amount Paid";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(18, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(171, 25);
            this.label7.TabIndex = 2;
            this.label7.Text = "Appointment Time";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(39, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 25);
            this.label8.TabIndex = 0;
            this.label8.Text = "Select Doctor";
            // 
            // txtAmount
            // 
            this.txtAmount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.Location = new System.Drawing.Point(248, 126);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(175, 30);
            this.txtAmount.TabIndex = 7;
            // 
            // CBSelectDoc
            // 
            this.CBSelectDoc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CBSelectDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBSelectDoc.FormattingEnabled = true;
            this.CBSelectDoc.Location = new System.Drawing.Point(240, 6);
            this.CBSelectDoc.Margin = new System.Windows.Forms.Padding(4);
            this.CBSelectDoc.Name = "CBSelectDoc";
            this.CBSelectDoc.Size = new System.Drawing.Size(191, 28);
            this.CBSelectDoc.TabIndex = 9;
            // 
            // DTAppointmentDate
            // 
            this.DTAppointmentDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DTAppointmentDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTAppointmentDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTAppointmentDate.Location = new System.Drawing.Point(271, 48);
            this.DTAppointmentDate.Margin = new System.Windows.Forms.Padding(4);
            this.DTAppointmentDate.Name = "DTAppointmentDate";
            this.DTAppointmentDate.Size = new System.Drawing.Size(129, 23);
            this.DTAppointmentDate.TabIndex = 10;
            this.DTAppointmentDate.FormatChanged += new System.EventHandler(this.DTAppointmentDate_FormatChanged);
            // 
            // DTAppointmentTime
            // 
            this.DTAppointmentTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DTAppointmentTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTAppointmentTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.DTAppointmentTime.Location = new System.Drawing.Point(272, 88);
            this.DTAppointmentTime.Margin = new System.Windows.Forms.Padding(4);
            this.DTAppointmentTime.Name = "DTAppointmentTime";
            this.DTAppointmentTime.Size = new System.Drawing.Size(127, 23);
            this.DTAppointmentTime.TabIndex = 11;
            this.DTAppointmentTime.ValueChanged += new System.EventHandler(this.DTAppointmentTime_ValueChanged);
            // 
            // GBPatient
            // 
            this.GBPatient.Controls.Add(this.tableLayoutPanel1);
            this.GBPatient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GBPatient.Location = new System.Drawing.Point(3, 2);
            this.GBPatient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GBPatient.Name = "GBPatient";
            this.GBPatient.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GBPatient.Size = new System.Drawing.Size(657, 179);
            this.GBPatient.TabIndex = 0;
            this.GBPatient.TabStop = false;
            this.GBPatient.Text = "Patient Details";
            this.GBPatient.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.02771F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.97229F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 187F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtMobileNo, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtPatientName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtAge, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.CBGender, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnFind, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 17);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.00062F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.00063F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.00063F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.99813F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(651, 160);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(59, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Age";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Gender";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mobile No";
            // 
            // txtMobileNo
            // 
            this.txtMobileNo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMobileNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMobileNo.Location = new System.Drawing.Point(175, 5);
            this.txtMobileNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMobileNo.Name = "txtMobileNo";
            this.txtMobileNo.Size = new System.Drawing.Size(279, 30);
            this.txtMobileNo.TabIndex = 4;
            this.txtMobileNo.TextChanged += new System.EventHandler(this.txtMobileNo_TextChanged);
            // 
            // txtPatientName
            // 
            this.txtPatientName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPatientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPatientName.Location = new System.Drawing.Point(175, 45);
            this.txtPatientName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPatientName.Name = "txtPatientName";
            this.txtPatientName.Size = new System.Drawing.Size(279, 30);
            this.txtPatientName.TabIndex = 5;
            // 
            // txtAge
            // 
            this.txtAge.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAge.Location = new System.Drawing.Point(255, 125);
            this.txtAge.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(119, 30);
            this.txtAge.TabIndex = 7;
            // 
            // CBGender
            // 
            this.CBGender.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.CBGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBGender.FormattingEnabled = true;
            this.CBGender.Items.AddRange(new object[] {
            "M",
            "F"});
            this.CBGender.Location = new System.Drawing.Point(254, 82);
            this.CBGender.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CBGender.Name = "CBGender";
            this.CBGender.Size = new System.Drawing.Size(121, 33);
            this.CBGender.TabIndex = 8;
            // 
            // btnFind
            // 
            this.btnFind.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnFind.Enabled = false;
            this.btnFind.Location = new System.Drawing.Point(467, 6);
            this.btnFind.Margin = new System.Windows.Forms.Padding(4);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(100, 28);
            this.btnFind.TabIndex = 9;
            this.btnFind.Text = "FIND";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 95.42168F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.578313F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 131F));
            this.tableLayoutPanel2.Controls.Add(this.btnCancel, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnSubmit, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 372);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(655, 47);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.Location = new System.Drawing.Point(539, 9);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 28);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSubmit.Location = new System.Drawing.Point(396, 9);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(4);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(100, 28);
            this.btnSubmit.TabIndex = 0;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // AddAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 423);
            this.Controls.Add(this.TLPAppointment);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddAppointment";
            this.Text = "Add Patient";
            this.Load += new System.EventHandler(this.AddAppointment_Load);
            this.TLPAppointment.ResumeLayout(false);
            this.GBAppointment.ResumeLayout(false);
            this.TLPAppointmentDetails.ResumeLayout(false);
            this.TLPAppointmentDetails.PerformLayout();
            this.GBPatient.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TLPAppointment;
        private System.Windows.Forms.GroupBox GBAppointment;
        private System.Windows.Forms.GroupBox GBPatient;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMobileNo;
        private System.Windows.Forms.TextBox txtPatientName;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.ComboBox CBGender;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TableLayoutPanel TLPAppointmentDetails;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.ComboBox CBSelectDoc;
        private System.Windows.Forms.DateTimePicker DTAppointmentDate;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.DateTimePicker DTAppointmentTime;
    }
}