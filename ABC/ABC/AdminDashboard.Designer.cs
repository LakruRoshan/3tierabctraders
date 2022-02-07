
namespace ABC
{
    partial class frmAdminDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdminDashboard));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAdminManageCustomers = new System.Windows.Forms.Button();
            this.btnAdminManageAdmins = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnAdminGenReports = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnAdminManageCustomerCarOrder = new System.Windows.Forms.Button();
            this.btnAdminManageCustomerCarPartsOrder = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAdminManageCar = new System.Windows.Forms.Button();
            this.btnAdminManageCarParts = new System.Windows.Forms.Button();
            this.lbldatetime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(502, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Admin DashBoard";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAdminManageCustomers);
            this.groupBox1.Controls.Add(this.btnAdminManageAdmins);
            this.groupBox1.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(274, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(302, 198);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Account Management";
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
            this.btnAdminManageCustomers.Text = "Manage Customers";
            this.btnAdminManageCustomers.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAdminManageCustomers.UseVisualStyleBackColor = true;
            this.btnAdminManageCustomers.Click += new System.EventHandler(this.btnAdminManageCustomers_Click);
            // 
            // btnAdminManageAdmins
            // 
            this.btnAdminManageAdmins.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnAdminManageAdmins.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminManageAdmins.Font = new System.Drawing.Font("Bahnschrift Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminManageAdmins.Image = global::ABC.Properties.Resources._8468097_agent_halloween_japanese_man_ninja_icon;
            this.btnAdminManageAdmins.Location = new System.Drawing.Point(154, 38);
            this.btnAdminManageAdmins.Name = "btnAdminManageAdmins";
            this.btnAdminManageAdmins.Size = new System.Drawing.Size(128, 128);
            this.btnAdminManageAdmins.TabIndex = 1;
            this.btnAdminManageAdmins.Text = "Manage Users";
            this.btnAdminManageAdmins.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAdminManageAdmins.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnAdminGenReports);
            this.groupBox4.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(604, 335);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(190, 198);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Reports";
            // 
            // btnAdminGenReports
            // 
            this.btnAdminGenReports.BackColor = System.Drawing.Color.Transparent;
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
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnAdminManageCustomerCarOrder);
            this.groupBox3.Controls.Add(this.btnAdminManageCustomerCarPartsOrder);
            this.groupBox3.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(631, 70);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(302, 198);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Order Management";
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
            this.btnAdminManageCustomerCarOrder.Text = "Manage Car Orders";
            this.btnAdminManageCustomerCarOrder.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAdminManageCustomerCarOrder.UseVisualStyleBackColor = true;
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
            this.btnAdminManageCustomerCarPartsOrder.Text = "Manage Car Parts Orders";
            this.btnAdminManageCustomerCarPartsOrder.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAdminManageCustomerCarPartsOrder.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAdminManageCar);
            this.groupBox2.Controls.Add(this.btnAdminManageCarParts);
            this.groupBox2.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(280, 335);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(302, 198);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Manage Item Master";
            // 
            // btnAdminManageCar
            // 
            this.btnAdminManageCar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnAdminManageCar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminManageCar.Font = new System.Drawing.Font("Bahnschrift Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminManageCar.Image = global::ABC.Properties.Resources._2730378_car_flash_furious_inkcontober_icon__1_;
            this.btnAdminManageCar.Location = new System.Drawing.Point(20, 38);
            this.btnAdminManageCar.Name = "btnAdminManageCar";
            this.btnAdminManageCar.Size = new System.Drawing.Size(128, 128);
            this.btnAdminManageCar.TabIndex = 0;
            this.btnAdminManageCar.Text = "Manage Cars Details";
            this.btnAdminManageCar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAdminManageCar.UseVisualStyleBackColor = true;
            // 
            // btnAdminManageCarParts
            // 
            this.btnAdminManageCarParts.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnAdminManageCarParts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminManageCarParts.Font = new System.Drawing.Font("Bahnschrift Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminManageCarParts.Image = global::ABC.Properties.Resources._5422819_car_electric_electrocar_truck_vehicle_icon;
            this.btnAdminManageCarParts.Location = new System.Drawing.Point(154, 38);
            this.btnAdminManageCarParts.Name = "btnAdminManageCarParts";
            this.btnAdminManageCarParts.Size = new System.Drawing.Size(128, 128);
            this.btnAdminManageCarParts.TabIndex = 1;
            this.btnAdminManageCarParts.Text = "Manage Car Parts Details";
            this.btnAdminManageCarParts.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAdminManageCarParts.UseVisualStyleBackColor = true;
            // 
            // lbldatetime
            // 
            this.lbldatetime.AutoSize = true;
            this.lbldatetime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldatetime.ForeColor = System.Drawing.Color.White;
            this.lbldatetime.Location = new System.Drawing.Point(735, 536);
            this.lbldatetime.Name = "lbldatetime";
            this.lbldatetime.Size = new System.Drawing.Size(91, 20);
            this.lbldatetime.TabIndex = 13;
            this.lbldatetime.Text = "Date Time";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmAdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(1238, 570);
            this.Controls.Add(this.lbldatetime);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAdminDashboard";
            this.Text = "AdminDashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmAdminDashboard_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAdminManageCustomers;
        private System.Windows.Forms.Button btnAdminManageAdmins;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnAdminGenReports;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnAdminManageCustomerCarOrder;
        private System.Windows.Forms.Button btnAdminManageCustomerCarPartsOrder;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAdminManageCar;
        private System.Windows.Forms.Button btnAdminManageCarParts;
        private System.Windows.Forms.Label lbldatetime;
        private System.Windows.Forms.Timer timer1;
    }
}