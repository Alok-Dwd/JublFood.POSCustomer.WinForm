namespace JublFood.POSCustomer.WinForm
{
    partial class Form1
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
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.lblExt = new System.Windows.Forms.Label();
            this.txtExt = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblDOB = new System.Windows.Forms.Label();
            this.lblAnniversary = new System.Windows.Forms.Label();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.txtStreetNumber1 = new System.Windows.Forms.TextBox();
            this.lblStreetNumber = new System.Windows.Forms.Label();
            this.txtStreetNumber2 = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSuite = new System.Windows.Forms.TextBox();
            this.lblSuite = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.txtGSTIN = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPostalCode = new System.Windows.Forms.TextBox();
            this.lblPostalCode = new System.Windows.Forms.Label();
            this.txtDOB = new System.Windows.Forms.MaskedTextBox();
            this.txtAnniversary = new System.Windows.Forms.MaskedTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbCallerID = new System.Windows.Forms.TabPage();
            this.tbNotes = new System.Windows.Forms.TabPage();
            this.tbProfile = new System.Windows.Forms.TabPage();
            this.btnSaveCustomer = new System.Windows.Forms.Button();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.panelOrder = new System.Windows.Forms.Panel();
            this.lblMenuItem = new System.Windows.Forms.Label();
            this.btnSide = new System.Windows.Forms.Button();
            this.btnBread = new System.Windows.Forms.Button();
            this.btnBeverages = new System.Windows.Forms.Button();
            this.btnPizza = new System.Windows.Forms.Button();
            this.btnMISC = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.listBoxOrder = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.panelOrder.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(576, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Location = new System.Drawing.Point(363, 120);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(78, 13);
            this.lblPhoneNumber.TabIndex = 1;
            this.lblPhoneNumber.Text = "Phone Number";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(448, 118);
            this.txtPhoneNumber.MaxLength = 10;
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(100, 20);
            this.txtPhoneNumber.TabIndex = 2;
            this.txtPhoneNumber.TextChanged += new System.EventHandler(this.txtPhoneNumber_TextChanged);
            // 
            // lblExt
            // 
            this.lblExt.AutoSize = true;
            this.lblExt.Location = new System.Drawing.Point(671, 120);
            this.lblExt.Name = "lblExt";
            this.lblExt.Size = new System.Drawing.Size(25, 13);
            this.lblExt.TabIndex = 3;
            this.lblExt.Text = "Ext.";
            // 
            // txtExt
            // 
            this.txtExt.Location = new System.Drawing.Point(713, 120);
            this.txtExt.Name = "txtExt";
            this.txtExt.Size = new System.Drawing.Size(100, 20);
            this.txtExt.TabIndex = 4;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(406, 157);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(448, 156);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(365, 20);
            this.txtName.TabIndex = 6;
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Location = new System.Drawing.Point(406, 199);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(30, 13);
            this.lblDOB.TabIndex = 7;
            this.lblDOB.Text = "DOB";
            // 
            // lblAnniversary
            // 
            this.lblAnniversary.AutoSize = true;
            this.lblAnniversary.Location = new System.Drawing.Point(634, 205);
            this.lblAnniversary.Name = "lblAnniversary";
            this.lblAnniversary.Size = new System.Drawing.Size(62, 13);
            this.lblAnniversary.TabIndex = 9;
            this.lblAnniversary.Text = "Anniversary";
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Location = new System.Drawing.Point(448, 238);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(365, 20);
            this.txtCompanyName.TabIndex = 12;
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.Location = new System.Drawing.Point(363, 240);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(82, 13);
            this.lblCompanyName.TabIndex = 11;
            this.lblCompanyName.Text = "Company Name";
            // 
            // txtStreetNumber1
            // 
            this.txtStreetNumber1.Location = new System.Drawing.Point(448, 280);
            this.txtStreetNumber1.Name = "txtStreetNumber1";
            this.txtStreetNumber1.Size = new System.Drawing.Size(60, 20);
            this.txtStreetNumber1.TabIndex = 14;
            // 
            // lblStreetNumber
            // 
            this.lblStreetNumber.AutoSize = true;
            this.lblStreetNumber.Location = new System.Drawing.Point(366, 281);
            this.lblStreetNumber.Name = "lblStreetNumber";
            this.lblStreetNumber.Size = new System.Drawing.Size(75, 13);
            this.lblStreetNumber.TabIndex = 13;
            this.lblStreetNumber.Text = "Street Number";
            // 
            // txtStreetNumber2
            // 
            this.txtStreetNumber2.Location = new System.Drawing.Point(518, 281);
            this.txtStreetNumber2.Name = "txtStreetNumber2";
            this.txtStreetNumber2.Size = new System.Drawing.Size(295, 20);
            this.txtStreetNumber2.TabIndex = 15;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(448, 324);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(188, 20);
            this.txtAddress.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(396, 324);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Address";
            // 
            // txtSuite
            // 
            this.txtSuite.Location = new System.Drawing.Point(713, 327);
            this.txtSuite.Name = "txtSuite";
            this.txtSuite.Size = new System.Drawing.Size(100, 20);
            this.txtSuite.TabIndex = 19;
            // 
            // lblSuite
            // 
            this.lblSuite.AutoSize = true;
            this.lblSuite.Location = new System.Drawing.Point(671, 330);
            this.lblSuite.Name = "lblSuite";
            this.lblSuite.Size = new System.Drawing.Size(31, 13);
            this.lblSuite.TabIndex = 18;
            this.lblSuite.Text = "Suite";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(448, 367);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(153, 20);
            this.txtCity.TabIndex = 21;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(417, 370);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(24, 13);
            this.lblCity.TabIndex = 20;
            this.lblCity.Text = "City";
            // 
            // txtGSTIN
            // 
            this.txtGSTIN.Location = new System.Drawing.Point(448, 407);
            this.txtGSTIN.Name = "txtGSTIN";
            this.txtGSTIN.Size = new System.Drawing.Size(115, 20);
            this.txtGSTIN.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(366, 410);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "GSTIN Number";
            // 
            // txtPostalCode
            // 
            this.txtPostalCode.Location = new System.Drawing.Point(713, 407);
            this.txtPostalCode.Name = "txtPostalCode";
            this.txtPostalCode.Size = new System.Drawing.Size(100, 20);
            this.txtPostalCode.TabIndex = 25;
            // 
            // lblPostalCode
            // 
            this.lblPostalCode.AutoSize = true;
            this.lblPostalCode.Location = new System.Drawing.Point(638, 410);
            this.lblPostalCode.Name = "lblPostalCode";
            this.lblPostalCode.Size = new System.Drawing.Size(64, 13);
            this.lblPostalCode.TabIndex = 24;
            this.lblPostalCode.Text = "Postal Code";
            // 
            // txtDOB
            // 
            this.txtDOB.Location = new System.Drawing.Point(448, 199);
            this.txtDOB.Mask = "00/00/0000";
            this.txtDOB.Name = "txtDOB";
            this.txtDOB.Size = new System.Drawing.Size(100, 20);
            this.txtDOB.TabIndex = 26;
            this.txtDOB.ValidatingType = typeof(System.DateTime);
            // 
            // txtAnniversary
            // 
            this.txtAnniversary.Location = new System.Drawing.Point(713, 198);
            this.txtAnniversary.Mask = "00/00/0000";
            this.txtAnniversary.Name = "txtAnniversary";
            this.txtAnniversary.Size = new System.Drawing.Size(100, 20);
            this.txtAnniversary.TabIndex = 27;
            this.txtAnniversary.ValidatingType = typeof(System.DateTime);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Location = new System.Drawing.Point(71, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(268, 372);
            this.panel1.TabIndex = 28;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbCallerID);
            this.tabControl1.Controls.Add(this.tbNotes);
            this.tabControl1.Controls.Add(this.tbProfile);
            this.tabControl1.ItemSize = new System.Drawing.Size(0, 50);
            this.tabControl1.Location = new System.Drawing.Point(4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(261, 365);
            this.tabControl1.TabIndex = 0;
            // 
            // tbCallerID
            // 
            this.tbCallerID.Location = new System.Drawing.Point(4, 54);
            this.tbCallerID.Name = "tbCallerID";
            this.tbCallerID.Padding = new System.Windows.Forms.Padding(3);
            this.tbCallerID.Size = new System.Drawing.Size(253, 307);
            this.tbCallerID.TabIndex = 0;
            this.tbCallerID.Text = "Caller ID             ";
            this.tbCallerID.UseVisualStyleBackColor = true;
            // 
            // tbNotes
            // 
            this.tbNotes.Location = new System.Drawing.Point(4, 54);
            this.tbNotes.Name = "tbNotes";
            this.tbNotes.Padding = new System.Windows.Forms.Padding(3);
            this.tbNotes.Size = new System.Drawing.Size(253, 307);
            this.tbNotes.TabIndex = 1;
            this.tbNotes.Text = "Notes              ";
            this.tbNotes.UseVisualStyleBackColor = true;
            // 
            // tbProfile
            // 
            this.tbProfile.Location = new System.Drawing.Point(4, 54);
            this.tbProfile.Name = "tbProfile";
            this.tbProfile.Padding = new System.Windows.Forms.Padding(3);
            this.tbProfile.Size = new System.Drawing.Size(253, 307);
            this.tbProfile.TabIndex = 2;
            this.tbProfile.Text = "Profile              ";
            this.tbProfile.UseVisualStyleBackColor = true;
            // 
            // btnSaveCustomer
            // 
            this.btnSaveCustomer.Location = new System.Drawing.Point(579, 458);
            this.btnSaveCustomer.Name = "btnSaveCustomer";
            this.btnSaveCustomer.Size = new System.Drawing.Size(75, 23);
            this.btnSaveCustomer.TabIndex = 29;
            this.btnSaveCustomer.Text = "Submit";
            this.btnSaveCustomer.UseVisualStyleBackColor = true;
            this.btnSaveCustomer.Click += new System.EventHandler(this.btnSaveCustomer_Click);
            // 
            // btnCustomer
            // 
            this.btnCustomer.Location = new System.Drawing.Point(577, 5);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(75, 46);
            this.btnCustomer.TabIndex = 30;
            this.btnCustomer.Text = "Customer";
            this.btnCustomer.UseVisualStyleBackColor = true;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // panelOrder
            // 
            this.panelOrder.Controls.Add(this.lblMenuItem);
            this.panelOrder.Controls.Add(this.btnSide);
            this.panelOrder.Controls.Add(this.btnBread);
            this.panelOrder.Controls.Add(this.btnBeverages);
            this.panelOrder.Controls.Add(this.btnPizza);
            this.panelOrder.Controls.Add(this.btnMISC);
            this.panelOrder.Location = new System.Drawing.Point(366, 65);
            this.panelOrder.Name = "panelOrder";
            this.panelOrder.Size = new System.Drawing.Size(473, 372);
            this.panelOrder.TabIndex = 31;
            this.panelOrder.Visible = false;
            // 
            // lblMenuItem
            // 
            this.lblMenuItem.AutoSize = true;
            this.lblMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenuItem.Location = new System.Drawing.Point(210, 8);
            this.lblMenuItem.Name = "lblMenuItem";
            this.lblMenuItem.Size = new System.Drawing.Size(90, 17);
            this.lblMenuItem.TabIndex = 5;
            this.lblMenuItem.Text = "Menu Items";
            // 
            // btnSide
            // 
            this.btnSide.Location = new System.Drawing.Point(370, 42);
            this.btnSide.Name = "btnSide";
            this.btnSide.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSide.Size = new System.Drawing.Size(91, 60);
            this.btnSide.TabIndex = 4;
            this.btnSide.Text = "SIDES";
            this.btnSide.UseVisualStyleBackColor = true;
            // 
            // btnBread
            // 
            this.btnBread.Location = new System.Drawing.Point(273, 42);
            this.btnBread.Name = "btnBread";
            this.btnBread.Size = new System.Drawing.Size(91, 60);
            this.btnBread.TabIndex = 3;
            this.btnBread.Text = "BREADS";
            this.btnBread.UseVisualStyleBackColor = true;
            // 
            // btnBeverages
            // 
            this.btnBeverages.Location = new System.Drawing.Point(176, 44);
            this.btnBeverages.Name = "btnBeverages";
            this.btnBeverages.Size = new System.Drawing.Size(91, 60);
            this.btnBeverages.TabIndex = 2;
            this.btnBeverages.Text = "BEVERAGES";
            this.btnBeverages.UseVisualStyleBackColor = true;
            // 
            // btnPizza
            // 
            this.btnPizza.Location = new System.Drawing.Point(92, 44);
            this.btnPizza.Name = "btnPizza";
            this.btnPizza.Size = new System.Drawing.Size(78, 60);
            this.btnPizza.TabIndex = 1;
            this.btnPizza.Text = "PIZZA";
            this.btnPizza.UseVisualStyleBackColor = true;
            // 
            // btnMISC
            // 
            this.btnMISC.Location = new System.Drawing.Point(11, 44);
            this.btnMISC.Name = "btnMISC";
            this.btnMISC.Size = new System.Drawing.Size(75, 60);
            this.btnMISC.TabIndex = 0;
            this.btnMISC.Text = "MISC";
            this.btnMISC.UseVisualStyleBackColor = true;
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(578, 6);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(75, 46);
            this.btnOrder.TabIndex = 32;
            this.btnOrder.Text = "Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Visible = false;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // listBoxOrder
            // 
            this.listBoxOrder.FormattingEnabled = true;
            this.listBoxOrder.Items.AddRange(new object[] {
            "Item",
            "",
            "",
            "Price"});
            this.listBoxOrder.Location = new System.Drawing.Point(71, 66);
            this.listBoxOrder.Name = "listBoxOrder";
            this.listBoxOrder.Size = new System.Drawing.Size(268, 368);
            this.listBoxOrder.TabIndex = 33;
            this.listBoxOrder.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(851, 525);
            this.Controls.Add(this.listBoxOrder);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.panelOrder);
            this.Controls.Add(this.btnCustomer);
            this.Controls.Add(this.btnSaveCustomer);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtAnniversary);
            this.Controls.Add(this.txtDOB);
            this.Controls.Add(this.txtPostalCode);
            this.Controls.Add(this.lblPostalCode);
            this.Controls.Add(this.txtGSTIN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.txtSuite);
            this.Controls.Add(this.lblSuite);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtStreetNumber2);
            this.Controls.Add(this.txtStreetNumber1);
            this.Controls.Add(this.lblStreetNumber);
            this.Controls.Add(this.txtCompanyName);
            this.Controls.Add(this.lblCompanyName);
            this.Controls.Add(this.lblAnniversary);
            this.Controls.Add(this.lblDOB);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtExt);
            this.Controls.Add(this.lblExt);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "POS";
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.panelOrder.ResumeLayout(false);
            this.panelOrder.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label lblExt;
        private System.Windows.Forms.TextBox txtExt;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.Label lblAnniversary;
        private System.Windows.Forms.TextBox txtCompanyName;
        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.TextBox txtStreetNumber1;
        private System.Windows.Forms.Label lblStreetNumber;
        private System.Windows.Forms.TextBox txtStreetNumber2;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSuite;
        private System.Windows.Forms.Label lblSuite;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox txtGSTIN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPostalCode;
        private System.Windows.Forms.Label lblPostalCode;
        private System.Windows.Forms.MaskedTextBox txtDOB;
        private System.Windows.Forms.MaskedTextBox txtAnniversary;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbCallerID;
        private System.Windows.Forms.TabPage tbNotes;
        private System.Windows.Forms.TabPage tbProfile;
        private System.Windows.Forms.Button btnSaveCustomer;
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.Panel panelOrder;
        private System.Windows.Forms.Button btnMISC;
        private System.Windows.Forms.Button btnPizza;
        private System.Windows.Forms.Button btnBeverages;
        private System.Windows.Forms.Button btnBread;
        private System.Windows.Forms.Button btnSide;
        private System.Windows.Forms.Label lblMenuItem;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.ListBox listBoxOrder;
    }
}

