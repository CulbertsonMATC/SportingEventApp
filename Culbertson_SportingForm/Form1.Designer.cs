
namespace Culbertson_SportingForm
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtbxName = new System.Windows.Forms.TextBox();
            this.txtbxAddress = new System.Windows.Forms.TextBox();
            this.txtbxCity = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.cmbxState = new System.Windows.Forms.ComboBox();
            this.radBiking = new System.Windows.Forms.RadioButton();
            this.radSnowboarding = new System.Windows.Forms.RadioButton();
            this.radSkiing = new System.Windows.Forms.RadioButton();
            this.radSnowmobiling = new System.Windows.Forms.RadioButton();
            this.radSkating = new System.Windows.Forms.RadioButton();
            this.radHiking = new System.Windows.Forms.RadioButton();
            this.lblState = new System.Windows.Forms.Label();
            this.grpbxWinterSports = new System.Windows.Forms.GroupBox();
            this.lblCaption = new System.Windows.Forms.Label();
            this.previewBox = new System.Windows.Forms.PictureBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.grpbxWinterSports.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.previewBox)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(203, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(414, 36);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Register For Your Sport Here!";
            // 
            // txtbxName
            // 
            this.txtbxName.Location = new System.Drawing.Point(292, 66);
            this.txtbxName.Name = "txtbxName";
            this.txtbxName.Size = new System.Drawing.Size(125, 20);
            this.txtbxName.TabIndex = 1;
            // 
            // txtbxAddress
            // 
            this.txtbxAddress.Location = new System.Drawing.Point(292, 93);
            this.txtbxAddress.Name = "txtbxAddress";
            this.txtbxAddress.Size = new System.Drawing.Size(200, 20);
            this.txtbxAddress.TabIndex = 2;
            // 
            // txtbxCity
            // 
            this.txtbxCity.Location = new System.Drawing.Point(292, 120);
            this.txtbxCity.Name = "txtbxCity";
            this.txtbxCity.Size = new System.Drawing.Size(125, 20);
            this.txtbxCity.TabIndex = 3;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(238, 67);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(48, 17);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Name";
            this.lblName.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(189, 94);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(97, 17);
            this.lblAddress.TabIndex = 5;
            this.lblAddress.Text = "Street Address";
            this.lblAddress.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.Location = new System.Drawing.Point(253, 121);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(33, 17);
            this.lblCity.TabIndex = 6;
            this.lblCity.Text = "City";
            this.lblCity.Click += new System.EventHandler(this.label3_Click);
            // 
            // cmbxState
            // 
            this.cmbxState.FormattingEnabled = true;
            this.cmbxState.Items.AddRange(new object[] {
            "AL",
            "AK",
            "AZ",
            "AR",
            "CA",
            "CO",
            "CT",
            "DE",
            "FL",
            "GA",
            "HI",
            "ID",
            "IL",
            "IN",
            "IA",
            "KS",
            "KY",
            "LA",
            "ME",
            "MD",
            "MA",
            "MI",
            "MN",
            "MS",
            "MO",
            "MT",
            "NE",
            "NV",
            "NH",
            "NJ",
            "NM",
            "NY",
            "NC",
            "ND",
            "OH",
            "OK",
            "OR",
            "PA",
            "RI",
            "SC",
            "SD",
            "TN",
            "TX",
            "UT",
            "VT",
            "VA",
            "WA",
            "WV",
            "WI",
            "WY"});
            this.cmbxState.Location = new System.Drawing.Point(476, 119);
            this.cmbxState.Name = "cmbxState";
            this.cmbxState.Size = new System.Drawing.Size(121, 21);
            this.cmbxState.TabIndex = 7;
            // 
            // radBiking
            // 
            this.radBiking.AutoSize = true;
            this.radBiking.Location = new System.Drawing.Point(24, 17);
            this.radBiking.Name = "radBiking";
            this.radBiking.Size = new System.Drawing.Size(128, 21);
            this.radBiking.TabIndex = 8;
            this.radBiking.TabStop = true;
            this.radBiking.Text = "Mountain Biking";
            this.radBiking.UseVisualStyleBackColor = true;
            this.radBiking.CheckedChanged += new System.EventHandler(this.radBiking_CheckedChanged);
            // 
            // radSnowboarding
            // 
            this.radSnowboarding.AutoSize = true;
            this.radSnowboarding.Location = new System.Drawing.Point(24, 63);
            this.radSnowboarding.Name = "radSnowboarding";
            this.radSnowboarding.Size = new System.Drawing.Size(121, 21);
            this.radSnowboarding.TabIndex = 9;
            this.radSnowboarding.TabStop = true;
            this.radSnowboarding.Text = "Snowboarding";
            this.radSnowboarding.UseVisualStyleBackColor = true;
            this.radSnowboarding.CheckedChanged += new System.EventHandler(this.radSnowboarding_CheckedChanged);
            // 
            // radSkiing
            // 
            this.radSkiing.AutoSize = true;
            this.radSkiing.Location = new System.Drawing.Point(24, 87);
            this.radSkiing.Name = "radSkiing";
            this.radSkiing.Size = new System.Drawing.Size(62, 21);
            this.radSkiing.TabIndex = 10;
            this.radSkiing.TabStop = true;
            this.radSkiing.Text = "Skiing";
            this.radSkiing.UseVisualStyleBackColor = true;
            this.radSkiing.CheckedChanged += new System.EventHandler(this.radSkiing_CheckedChanged);
            // 
            // radSnowmobiling
            // 
            this.radSnowmobiling.AutoSize = true;
            this.radSnowmobiling.Location = new System.Drawing.Point(24, 111);
            this.radSnowmobiling.Name = "radSnowmobiling";
            this.radSnowmobiling.Size = new System.Drawing.Size(118, 21);
            this.radSnowmobiling.TabIndex = 11;
            this.radSnowmobiling.TabStop = true;
            this.radSnowmobiling.Text = "Snowmobiling";
            this.radSnowmobiling.UseVisualStyleBackColor = true;
            this.radSnowmobiling.CheckedChanged += new System.EventHandler(this.radSnowmobiling_CheckedChanged);
            // 
            // radSkating
            // 
            this.radSkating.AutoSize = true;
            this.radSkating.Location = new System.Drawing.Point(24, 40);
            this.radSkating.Name = "radSkating";
            this.radSkating.Size = new System.Drawing.Size(96, 21);
            this.radSkating.TabIndex = 12;
            this.radSkating.TabStop = true;
            this.radSkating.Text = "Ice Skating";
            this.radSkating.UseVisualStyleBackColor = true;
            this.radSkating.CheckedChanged += new System.EventHandler(this.radSkating_CheckedChanged);
            // 
            // radHiking
            // 
            this.radHiking.AutoSize = true;
            this.radHiking.Location = new System.Drawing.Point(24, 134);
            this.radHiking.Name = "radHiking";
            this.radHiking.Size = new System.Drawing.Size(110, 21);
            this.radHiking.TabIndex = 13;
            this.radHiking.TabStop = true;
            this.radHiking.Text = "Winter Hiking";
            this.radHiking.UseVisualStyleBackColor = true;
            this.radHiking.CheckedChanged += new System.EventHandler(this.radHiking_CheckedChanged);
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblState.Location = new System.Drawing.Point(429, 121);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(41, 17);
            this.lblState.TabIndex = 14;
            this.lblState.Text = "State";
            this.lblState.Click += new System.EventHandler(this.label4_Click);
            // 
            // grpbxWinterSports
            // 
            this.grpbxWinterSports.Controls.Add(this.radSkiing);
            this.grpbxWinterSports.Controls.Add(this.radBiking);
            this.grpbxWinterSports.Controls.Add(this.radHiking);
            this.grpbxWinterSports.Controls.Add(this.radSnowboarding);
            this.grpbxWinterSports.Controls.Add(this.radSkating);
            this.grpbxWinterSports.Controls.Add(this.radSnowmobiling);
            this.grpbxWinterSports.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbxWinterSports.Location = new System.Drawing.Point(159, 210);
            this.grpbxWinterSports.Name = "grpbxWinterSports";
            this.grpbxWinterSports.Size = new System.Drawing.Size(200, 161);
            this.grpbxWinterSports.TabIndex = 15;
            this.grpbxWinterSports.TabStop = false;
            this.grpbxWinterSports.Text = "Winter Sports:";
            this.grpbxWinterSports.Enter += new System.EventHandler(this.grpbxWinterSports_Enter);
            // 
            // lblCaption
            // 
            this.lblCaption.AutoSize = true;
            this.lblCaption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblCaption.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCaption.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaption.Location = new System.Drawing.Point(473, 414);
            this.lblCaption.Name = "lblCaption";
            this.lblCaption.Size = new System.Drawing.Size(148, 19);
            this.lblCaption.TabIndex = 17;
            this.lblCaption.Text = "Test Text While Editing";
            this.lblCaption.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // previewBox
            // 
            this.previewBox.Location = new System.Drawing.Point(365, 179);
            this.previewBox.Name = "previewBox";
            this.previewBox.Size = new System.Drawing.Size(368, 232);
            this.previewBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.previewBox.TabIndex = 16;
            this.previewBox.TabStop = false;
            this.previewBox.Visible = false;
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.DarkGreen;
            this.btnRegister.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.Location = new System.Drawing.Point(165, 400);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(172, 55);
            this.btnRegister.TabIndex = 18;
            this.btnRegister.Text = "REGISTER!";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(824, 477);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.lblCaption);
            this.Controls.Add(this.previewBox);
            this.Controls.Add(this.grpbxWinterSports);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.cmbxState);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtbxCity);
            this.Controls.Add(this.txtbxAddress);
            this.Controls.Add(this.txtbxName);
            this.Controls.Add(this.lblTitle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpbxWinterSports.ResumeLayout(false);
            this.grpbxWinterSports.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.previewBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtbxName;
        private System.Windows.Forms.TextBox txtbxAddress;
        private System.Windows.Forms.TextBox txtbxCity;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.ComboBox cmbxState;
        private System.Windows.Forms.RadioButton radBiking;
        private System.Windows.Forms.RadioButton radSnowboarding;
        private System.Windows.Forms.RadioButton radSkiing;
        private System.Windows.Forms.RadioButton radSnowmobiling;
        private System.Windows.Forms.RadioButton radSkating;
        private System.Windows.Forms.RadioButton radHiking;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.GroupBox grpbxWinterSports;
        private System.Windows.Forms.PictureBox previewBox;
        private System.Windows.Forms.Label lblCaption;
        private System.Windows.Forms.Button btnRegister;
    }
}

