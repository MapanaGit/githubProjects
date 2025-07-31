namespace viva_finance
{
    partial class adminDashboard
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
            this.components = new System.ComponentModel.Container();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblViva = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.Timer(this.components);
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnCust = new System.Windows.Forms.Button();
            this.btnTrans = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(160, 275);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(246, 47);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblViva
            // 
            this.lblViva.AutoSize = true;
            this.lblViva.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViva.Location = new System.Drawing.Point(172, 33);
            this.lblViva.Name = "lblViva";
            this.lblViva.Size = new System.Drawing.Size(221, 13);
            this.lblViva.TabIndex = 2;
            this.lblViva.Text = "Welcome to XXXX Financial Solutions";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(157, 68);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(77, 13);
            this.lblTime.TabIndex = 3;
            this.lblTime.Text = "Time and Date";
            // 
            // time
            // 
            this.time.Enabled = true;
            this.time.Tick += new System.EventHandler(this.time_Tick);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(160, 95);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(246, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // btnCust
            // 
            this.btnCust.Location = new System.Drawing.Point(160, 150);
            this.btnCust.Name = "btnCust";
            this.btnCust.Size = new System.Drawing.Size(246, 47);
            this.btnCust.TabIndex = 5;
            this.btnCust.Text = "Customer";
            this.btnCust.UseVisualStyleBackColor = true;
            this.btnCust.Click += new System.EventHandler(this.btnCust_Click);
            // 
            // btnTrans
            // 
            this.btnTrans.Location = new System.Drawing.Point(160, 212);
            this.btnTrans.Name = "btnTrans";
            this.btnTrans.Size = new System.Drawing.Size(246, 47);
            this.btnTrans.TabIndex = 6;
            this.btnTrans.Text = "Transaction";
            this.btnTrans.UseVisualStyleBackColor = true;
            this.btnTrans.Click += new System.EventHandler(this.btnTrans_Click);
            // 
            // adminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 419);
            this.Controls.Add(this.btnTrans);
            this.Controls.Add(this.btnCust);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblViva);
            this.Controls.Add(this.btnLogout);
            this.Name = "adminDashboard";
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblViva;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer time;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnCust;
        private System.Windows.Forms.Button btnTrans;
    }
}