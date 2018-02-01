namespace Greenville_Advertisement
{
    partial class greenvilleAd
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
            this.applyLabel = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.genderLabel = new System.Windows.Forms.Label();
            this.genderRadio1 = new System.Windows.Forms.RadioButton();
            this.genderRadio2 = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.addressBox = new System.Windows.Forms.TextBox();
            this.subNameLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.actLabel = new System.Windows.Forms.Label();
            this.actBox = new System.Windows.Forms.ListBox();
            this.subGenderLabel = new System.Windows.Forms.Label();
            this.subAddressLabel = new System.Windows.Forms.Label();
            this.subActLabel = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.subNameLabel2 = new System.Windows.Forms.Label();
            this.subGenderLabel2 = new System.Windows.Forms.Label();
            this.subAddressLabel2 = new System.Windows.Forms.Label();
            this.subActLabel2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // applyLabel
            // 
            this.applyLabel.AutoSize = true;
            this.applyLabel.Location = new System.Drawing.Point(13, 9);
            this.applyLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.applyLabel.Name = "applyLabel";
            this.applyLabel.Size = new System.Drawing.Size(134, 17);
            this.applyLabel.TabIndex = 0;
            this.applyLabel.Text = "Please Apply Today";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(57, 65);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(161, 23);
            this.nameBox.TabIndex = 1;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(117, 36);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(53, 17);
            this.nameLabel.TabIndex = 2;
            this.nameLabel.Text = "Name :";
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.Location = new System.Drawing.Point(68, 13);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(64, 17);
            this.genderLabel.TabIndex = 3;
            this.genderLabel.Text = "Gender :";
            // 
            // genderRadio1
            // 
            this.genderRadio1.AutoSize = true;
            this.genderRadio1.Location = new System.Drawing.Point(21, 45);
            this.genderRadio1.Name = "genderRadio1";
            this.genderRadio1.Size = new System.Drawing.Size(56, 21);
            this.genderRadio1.TabIndex = 4;
            this.genderRadio1.TabStop = true;
            this.genderRadio1.Text = "Male";
            this.genderRadio1.UseVisualStyleBackColor = true;
            // 
            // genderRadio2
            // 
            this.genderRadio2.AutoSize = true;
            this.genderRadio2.Location = new System.Drawing.Point(112, 45);
            this.genderRadio2.Name = "genderRadio2";
            this.genderRadio2.Size = new System.Drawing.Size(72, 21);
            this.genderRadio2.TabIndex = 5;
            this.genderRadio2.TabStop = true;
            this.genderRadio2.Text = "Female";
            this.genderRadio2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.genderRadio1);
            this.panel1.Controls.Add(this.genderLabel);
            this.panel1.Controls.Add(this.genderRadio2);
            this.panel1.Location = new System.Drawing.Point(245, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 75);
            this.panel1.TabIndex = 6;
            // 
            // addressBox
            // 
            this.addressBox.Location = new System.Drawing.Point(57, 150);
            this.addressBox.Multiline = true;
            this.addressBox.Name = "addressBox";
            this.addressBox.Size = new System.Drawing.Size(161, 100);
            this.addressBox.TabIndex = 7;
            // 
            // subNameLabel
            // 
            this.subNameLabel.AutoSize = true;
            this.subNameLabel.Location = new System.Drawing.Point(94, 339);
            this.subNameLabel.Name = "subNameLabel";
            this.subNameLabel.Size = new System.Drawing.Size(53, 17);
            this.subNameLabel.TabIndex = 8;
            this.subNameLabel.Text = "Name :";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(117, 130);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(68, 17);
            this.addressLabel.TabIndex = 9;
            this.addressLabel.Text = "Address :";
            // 
            // actLabel
            // 
            this.actLabel.AutoSize = true;
            this.actLabel.Location = new System.Drawing.Point(313, 130);
            this.actLabel.Name = "actLabel";
            this.actLabel.Size = new System.Drawing.Size(84, 17);
            this.actLabel.TabIndex = 10;
            this.actLabel.Text = "Kind of Act :";
            // 
            // actBox
            // 
            this.actBox.FormattingEnabled = true;
            this.actBox.ItemHeight = 16;
            this.actBox.Items.AddRange(new object[] {
            "Dancer",
            "Singer",
            "Comedian",
            "Performer",
            "Other"});
            this.actBox.Location = new System.Drawing.Point(284, 150);
            this.actBox.Name = "actBox";
            this.actBox.Size = new System.Drawing.Size(161, 100);
            this.actBox.TabIndex = 11;
            // 
            // subGenderLabel
            // 
            this.subGenderLabel.AutoSize = true;
            this.subGenderLabel.Location = new System.Drawing.Point(269, 339);
            this.subGenderLabel.Name = "subGenderLabel";
            this.subGenderLabel.Size = new System.Drawing.Size(64, 17);
            this.subGenderLabel.TabIndex = 12;
            this.subGenderLabel.Text = "Gender :";
            // 
            // subAddressLabel
            // 
            this.subAddressLabel.AutoSize = true;
            this.subAddressLabel.Location = new System.Drawing.Point(94, 401);
            this.subAddressLabel.Name = "subAddressLabel";
            this.subAddressLabel.Size = new System.Drawing.Size(68, 17);
            this.subAddressLabel.TabIndex = 13;
            this.subAddressLabel.Text = "Address :";
            // 
            // subActLabel
            // 
            this.subActLabel.AutoSize = true;
            this.subActLabel.Location = new System.Drawing.Point(269, 401);
            this.subActLabel.Name = "subActLabel";
            this.subActLabel.Size = new System.Drawing.Size(84, 17);
            this.subActLabel.TabIndex = 14;
            this.subActLabel.Text = "Kind of Act :";
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(97, 275);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 15;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // subNameLabel2
            // 
            this.subNameLabel2.AutoSize = true;
            this.subNameLabel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.subNameLabel2.Font = new System.Drawing.Font("Helvetica", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subNameLabel2.Location = new System.Drawing.Point(94, 369);
            this.subNameLabel2.Name = "subNameLabel2";
            this.subNameLabel2.Size = new System.Drawing.Size(0, 16);
            this.subNameLabel2.TabIndex = 16;
            this.subNameLabel2.Visible = false;
            // 
            // subGenderLabel2
            // 
            this.subGenderLabel2.AutoSize = true;
            this.subGenderLabel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.subGenderLabel2.Font = new System.Drawing.Font("Helvetica", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subGenderLabel2.Location = new System.Drawing.Point(269, 369);
            this.subGenderLabel2.Name = "subGenderLabel2";
            this.subGenderLabel2.Size = new System.Drawing.Size(0, 16);
            this.subGenderLabel2.TabIndex = 17;
            this.subGenderLabel2.Visible = false;
            // 
            // subAddressLabel2
            // 
            this.subAddressLabel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.subAddressLabel2.Font = new System.Drawing.Font("Helvetica", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subAddressLabel2.Location = new System.Drawing.Point(54, 434);
            this.subAddressLabel2.Name = "subAddressLabel2";
            this.subAddressLabel2.Size = new System.Drawing.Size(161, 100);
            this.subAddressLabel2.TabIndex = 18;
            this.subAddressLabel2.Visible = false;
            // 
            // subActLabel2
            // 
            this.subActLabel2.AutoSize = true;
            this.subActLabel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.subActLabel2.Font = new System.Drawing.Font("Helvetica", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subActLabel2.Location = new System.Drawing.Point(269, 434);
            this.subActLabel2.Name = "subActLabel2";
            this.subActLabel2.Size = new System.Drawing.Size(0, 16);
            this.subActLabel2.TabIndex = 19;
            this.subActLabel2.Visible = false;
            // 
            // greenvilleAd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(505, 560);
            this.Controls.Add(this.subActLabel2);
            this.Controls.Add(this.subAddressLabel2);
            this.Controls.Add(this.subGenderLabel2);
            this.Controls.Add(this.subNameLabel2);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.subActLabel);
            this.Controls.Add(this.subAddressLabel);
            this.Controls.Add(this.subGenderLabel);
            this.Controls.Add(this.actBox);
            this.Controls.Add(this.actLabel);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.subNameLabel);
            this.Controls.Add(this.addressBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.applyLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "greenvilleAd";
            this.Text = "Greenville Application";
            this.Load += new System.EventHandler(this.greenvilleAd_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label applyLabel;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label genderLabel;
        private System.Windows.Forms.RadioButton genderRadio1;
        private System.Windows.Forms.RadioButton genderRadio2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox addressBox;
        private System.Windows.Forms.Label subNameLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label actLabel;
        private System.Windows.Forms.ListBox actBox;
        private System.Windows.Forms.Label subGenderLabel;
        private System.Windows.Forms.Label subAddressLabel;
        private System.Windows.Forms.Label subActLabel;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Label subNameLabel2;
        private System.Windows.Forms.Label subGenderLabel2;
        private System.Windows.Forms.Label subAddressLabel2;
        private System.Windows.Forms.Label subActLabel2;
    }
}

