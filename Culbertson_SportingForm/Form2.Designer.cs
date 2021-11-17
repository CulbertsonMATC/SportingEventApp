
namespace Culbertson_SportingForm
{
    partial class Form2
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
            this.lstbxName = new System.Windows.Forms.ListBox();
            this.lstbxSport = new System.Windows.Forms.ListBox();
            this.childName = new System.Windows.Forms.Label();
            this.childSport = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(275, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registered Children";
            // 
            // lstbxName
            // 
            this.lstbxName.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstbxName.FormattingEnabled = true;
            this.lstbxName.ItemHeight = 24;
            this.lstbxName.Location = new System.Drawing.Point(98, 125);
            this.lstbxName.Name = "lstbxName";
            this.lstbxName.Size = new System.Drawing.Size(256, 244);
            this.lstbxName.TabIndex = 1;
            // 
            // lstbxSport
            // 
            this.lstbxSport.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstbxSport.FormattingEnabled = true;
            this.lstbxSport.ItemHeight = 24;
            this.lstbxSport.Location = new System.Drawing.Point(475, 125);
            this.lstbxSport.Name = "lstbxSport";
            this.lstbxSport.Size = new System.Drawing.Size(256, 244);
            this.lstbxSport.TabIndex = 2;
            // 
            // childName
            // 
            this.childName.AutoSize = true;
            this.childName.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.childName.Location = new System.Drawing.Point(94, 98);
            this.childName.Name = "childName";
            this.childName.Size = new System.Drawing.Size(75, 24);
            this.childName.TabIndex = 3;
            this.childName.Text = "Name";
            // 
            // childSport
            // 
            this.childSport.AutoSize = true;
            this.childSport.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.childSport.Location = new System.Drawing.Point(471, 98);
            this.childSport.Name = "childSport";
            this.childSport.Size = new System.Drawing.Size(61, 24);
            this.childSport.TabIndex = 4;
            this.childSport.Text = "Sport";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 395);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "label2";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(824, 477);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.childSport);
            this.Controls.Add(this.childName);
            this.Controls.Add(this.lstbxSport);
            this.Controls.Add(this.lstbxName);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstbxName;
        private System.Windows.Forms.ListBox lstbxSport;
        private System.Windows.Forms.Label childName;
        private System.Windows.Forms.Label childSport;
        private System.Windows.Forms.Label label2;
    }
}