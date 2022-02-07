
namespace ABC
{
    partial class frmCustomerDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustomerDashboard));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAdminGenReports = new System.Windows.Forms.Button();
            this.btnAdminManageCustomerCarOrder = new System.Windows.Forms.Button();
            this.btnAdminManageAdmins = new System.Windows.Forms.Button();
            this.btnAdminManageCustomerCarPartsOrder = new System.Windows.Forms.Button();
            this.btnAdminManageCustomers = new System.Windows.Forms.Button();
            this.lbldatetime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(286, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Dashboard";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnAdminGenReports);
            this.groupBox4.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(81, 316);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(302, 198);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Reports";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnAdminManageCustomerCarOrder);
            this.groupBox3.Controls.Add(this.btnAdminManageAdmins);
            this.groupBox3.Controls.Add(this.btnAdminManageCustomerCarPartsOrder);
            this.groupBox3.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(438, 78);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(315, 330);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Order Management";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAdminManageCustomers);
            this.groupBox1.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(81, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(302, 198);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Account Management";
            // 
            // btnAdminGenReports
            // 
            this.btnAdminGenReports.BackColor = System.Drawing.Color.White;
            this.btnAdminGenReports.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnAdminGenReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminGenReports.Font = new System.Drawing.Font("Bahnschrift Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminGenReports.Image = global::ABC.Properties.Resources._4288598_analysis_analytics_chart_data_pie_icon;
            this.btnAdminGenReports.Location = new System.Drawing.Point(20, 38);
            this.btnAdminGenReports.Name = "btnAdminGenReports";
            this.btnAdminGenReports.Size = new System.Drawing.Size(128, 128);
            this.btnAdminGenReports.TabIndex = 0;
            this.btnAdminGenReports.Text = "Reports";
            this.btnAdminGenReports.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAdminGenReports.UseVisualStyleBackColor = false;
            // 
            // btnAdminManageCustomerCarOrder
            // 
            this.btnAdminManageCustomerCarOrder.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnAdminManageCustomerCarOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminManageCustomerCarOrder.Font = new System.Drawing.Font("Bahnschrift Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminManageCustomerCarOrder.Image = global::ABC.Properties.Resources._49616_bill_invoice_method_payment_sales_icon;
            this.btnAdminManageCustomerCarOrder.Location = new System.Drawing.Point(20, 38);
            this.btnAdminManageCustomerCarOrder.Name = "btnAdminManageCustomerCarOrder";
            this.btnAdminManageCustomerCarOrder.Size = new System.Drawing.Size(128, 128);
            this.btnAdminManageCustomerCarOrder.TabIndex = 0;
            this.btnAdminManageCustomerCarOrder.Text = "Search Car Orders";
            this.btnAdminManageCustomerCarOrder.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAdminManageCustomerCarOrder.UseVisualStyleBackColor = true;
            // 
            // btnAdminManageAdmins
            // 
            this.btnAdminManageAdmins.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnAdminManageAdmins.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminManageAdmins.Font = new System.Drawing.Font("Bahnschrift Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminManageAdmins.Image = global::ABC.Properties.Resources._4016104_watch_cart_smartwatch_icon;
            this.btnAdminManageAdmins.Location = new System.Drawing.Point(89, 186);
            this.btnAdminManageAdmins.Name = "btnAdminManageAdmins";
            this.btnAdminManageAdmins.Size = new System.Drawing.Size(128, 128);
            this.btnAdminManageAdmins.TabIndex = 1;
            this.btnAdminManageAdmins.Text = "My Orders";
            this.btnAdminManageAdmins.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAdminManageAdmins.UseVisualStyleBackColor = true;
            // 
            // btnAdminManageCustomerCarPartsOrder
            // 
            this.btnAdminManageCustomerCarPartsOrder.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnAdminManageCustomerCarPartsOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminManageCustomerCarPartsOrder.Font = new System.Drawing.Font("Bahnschrift Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminManageCustomerCarPartsOrder.Image = global::ABC.Properties.Resources._49616_bill_invoice_method_payment_sales_icon;
            this.btnAdminManageCustomerCarPartsOrder.Location = new System.Drawing.Point(154, 38);
            this.btnAdminManageCustomerCarPartsOrder.Name = "btnAdminManageCustomerCarPartsOrder";
            this.btnAdminManageCustomerCarPartsOrder.Size = new System.Drawing.Size(128, 128);
            this.btnAdminManageCustomerCarPartsOrder.TabIndex = 1;
            this.btnAdminManageCustomerCarPartsOrder.Text = "Search Car Parts Orders";
            this.btnAdminManageCustomerCarPartsOrder.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAdminManageCustomerCarPartsOrder.UseVisualStyleBackColor = true;
            // 
            // btnAdminManageCustomers
            // 
            this.btnAdminManageCustomers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdminManageCustomers.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnAdminManageCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminManageCustomers.Font = new System.Drawing.Font("Bahnschrift Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminManageCustomers.Image = global::ABC.Properties.Resources._5998360_adult_asian_avatar_elder_male_icon;
            this.btnAdminManageCustomers.Location = new System.Drawing.Point(20, 38);
            this.btnAdminManageCustomers.Name = "btnAdminManageCustomers";
            this.btnAdminManageCustomers.Size = new System.Drawing.Size(128, 128);
            this.btnAdminManageCustomers.TabIndex = 0;
            this.btnAdminManageCustomers.Text = "My Acount";
            this.btnAdminManageCustomers.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAdminManageCustomers.UseVisualStyleBackColor = true;
            // 
            // lbldatetime
            // 
            this.lbldatetime.AutoSize = true;
            this.lbldatetime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldatetime.ForeColor = System.Drawing.Color.White;
            this.lbldatetime.Location = new System.Drawing.Point(428, 494);
            this.lbldatetime.Name = "lbldatetime";
            this.lbldatetime.Size = new System.Drawing.Size(91, 20);
            this.lbldatetime.TabIndex = 12;
            this.lbldatetime.Text = "Date Time";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmCustomerDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(856, 557);
            this.Controls.Add(this.lbldatetime);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCustomerDashboard";
            this.Text = "CustomerDashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmCustomerDashboard_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnAdminGenReports;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnAdminManageCustomerCarOrder;
        private System.Windows.Forms.Button btnAdminManageAdmins;
        private System.Windows.Forms.Button btnAdminManageCustomerCarPartsOrder;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAdminManageCustomers;
        private System.Windows.Forms.Label lbldatetime;
        private System.Windows.Forms.Timer timer1;
    }
}