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
            this.btnViewDoctor = new System.Windows.Forms.Button();
            this.btnAddPatient = new System.Windows.Forms.Button();
            this.btnViewApp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnViewDoctor
            // 
            this.btnViewDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewDoctor.Location = new System.Drawing.Point(205, 101);
            this.btnViewDoctor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnViewDoctor.Name = "btnViewDoctor";
            this.btnViewDoctor.Size = new System.Drawing.Size(137, 32);
            this.btnViewDoctor.TabIndex = 0;
            this.btnViewDoctor.Text = "View Doctor";
            this.btnViewDoctor.UseVisualStyleBackColor = true;
            this.btnViewDoctor.Click += new System.EventHandler(this.btnViewDoctor_Click);
            // 
            // btnAddPatient
            // 
            this.btnAddPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPatient.Location = new System.Drawing.Point(205, 151);
            this.btnAddPatient.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddPatient.Name = "btnAddPatient";
            this.btnAddPatient.Size = new System.Drawing.Size(137, 31);
            this.btnAddPatient.TabIndex = 1;
            this.btnAddPatient.Text = "Add Patient";
            this.btnAddPatient.UseVisualStyleBackColor = true;
            this.btnAddPatient.Click += new System.EventHandler(this.btnAddPatient_Click);
            // 
            // btnViewApp
            // 
            this.btnViewApp.Location = new System.Drawing.Point(438, 65);
            this.btnViewApp.Name = "btnViewApp";
            this.btnViewApp.Size = new System.Drawing.Size(100, 67);
            this.btnViewApp.TabIndex = 2;
            this.btnViewApp.Text = "View Appointment";
            this.btnViewApp.UseVisualStyleBackColor = true;
            this.btnViewApp.Click += new System.EventHandler(this.btnViewApp_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 466);
            this.Controls.Add(this.btnViewApp);
            this.Controls.Add(this.btnAddPatient);
            this.Controls.Add(this.btnViewDoctor);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnViewDoctor;
        private System.Windows.Forms.Button btnAddPatient;
        private System.Windows.Forms.Button btnViewApp;
    }
}