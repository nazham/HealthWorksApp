namespace HealthWorksApp
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnViewDoctor = new System.Windows.Forms.Button();
            this.btnAddPatient = new System.Windows.Forms.Button();
            this.btnViewApp = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnViewDoctor
            // 
            this.btnViewDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewDoctor.Location = new System.Drawing.Point(39, 148);
            this.btnViewDoctor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnViewDoctor.Name = "btnViewDoctor";
            this.btnViewDoctor.Size = new System.Drawing.Size(109, 32);
            this.btnViewDoctor.TabIndex = 0;
            this.btnViewDoctor.Text = "View Doctor";
            this.btnViewDoctor.UseVisualStyleBackColor = true;
            this.btnViewDoctor.Click += new System.EventHandler(this.btnViewDoctor_Click);
            // 
            // btnAddPatient
            // 
            this.btnAddPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPatient.Location = new System.Drawing.Point(39, 215);
            this.btnAddPatient.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddPatient.Name = "btnAddPatient";
            this.btnAddPatient.Size = new System.Drawing.Size(109, 31);
            this.btnAddPatient.TabIndex = 1;
            this.btnAddPatient.Text = "Add Patient";
            this.btnAddPatient.UseVisualStyleBackColor = true;
            this.btnAddPatient.Click += new System.EventHandler(this.btnAddPatient_Click);
            // 
            // btnViewApp
            // 
            this.btnViewApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewApp.Location = new System.Drawing.Point(39, 283);
            this.btnViewApp.Name = "btnViewApp";
            this.btnViewApp.Size = new System.Drawing.Size(153, 31);
            this.btnViewApp.TabIndex = 2;
            this.btnViewApp.Text = "View Appointment";
            this.btnViewApp.UseVisualStyleBackColor = true;
            this.btnViewApp.Click += new System.EventHandler(this.btnViewApp_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(174, 215);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 31);
            this.button1.TabIndex = 3;
            this.button1.Text = "View Patients";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 466);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnViewApp);
            this.Controls.Add(this.btnAddPatient);
            this.Controls.Add(this.btnViewDoctor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnViewDoctor;
        private System.Windows.Forms.Button btnAddPatient;
        private System.Windows.Forms.Button btnViewApp;
        private System.Windows.Forms.Button button1;
    }
}