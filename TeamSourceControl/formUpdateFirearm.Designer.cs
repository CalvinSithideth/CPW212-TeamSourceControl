namespace TeamSourceControl
{
    partial class FormUpdateFirearm
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
            this.btnUpdateFirearm = new System.Windows.Forms.Button();
            this.txtUpdateSerialNum = new System.Windows.Forms.TextBox();
            this.txtUpdateManufacturer = new System.Windows.Forms.TextBox();
            this.txtUpdateModel = new System.Windows.Forms.TextBox();
            this.txtUpdateCaliber = new System.Windows.Forms.TextBox();
            this.txtUpdatePrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPrimaryKey = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnUpdateFirearm
            // 
            this.btnUpdateFirearm.Location = new System.Drawing.Point(153, 253);
            this.btnUpdateFirearm.Name = "btnUpdateFirearm";
            this.btnUpdateFirearm.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateFirearm.TabIndex = 5;
            this.btnUpdateFirearm.Text = "Update";
            this.btnUpdateFirearm.UseVisualStyleBackColor = true;
            this.btnUpdateFirearm.Click += new System.EventHandler(this.btnUpdateFirearm_Click);
            // 
            // txtUpdateSerialNum
            // 
            this.txtUpdateSerialNum.Location = new System.Drawing.Point(116, 91);
            this.txtUpdateSerialNum.Name = "txtUpdateSerialNum";
            this.txtUpdateSerialNum.Size = new System.Drawing.Size(178, 20);
            this.txtUpdateSerialNum.TabIndex = 0;
            // 
            // txtUpdateManufacturer
            // 
            this.txtUpdateManufacturer.Location = new System.Drawing.Point(116, 117);
            this.txtUpdateManufacturer.Name = "txtUpdateManufacturer";
            this.txtUpdateManufacturer.Size = new System.Drawing.Size(178, 20);
            this.txtUpdateManufacturer.TabIndex = 1;
            // 
            // txtUpdateModel
            // 
            this.txtUpdateModel.Location = new System.Drawing.Point(116, 143);
            this.txtUpdateModel.Name = "txtUpdateModel";
            this.txtUpdateModel.Size = new System.Drawing.Size(178, 20);
            this.txtUpdateModel.TabIndex = 2;
            // 
            // txtUpdateCaliber
            // 
            this.txtUpdateCaliber.Location = new System.Drawing.Point(116, 169);
            this.txtUpdateCaliber.Name = "txtUpdateCaliber";
            this.txtUpdateCaliber.Size = new System.Drawing.Size(178, 20);
            this.txtUpdateCaliber.TabIndex = 3;
            // 
            // txtUpdatePrice
            // 
            this.txtUpdatePrice.Location = new System.Drawing.Point(116, 195);
            this.txtUpdatePrice.Name = "txtUpdatePrice";
            this.txtUpdatePrice.Size = new System.Drawing.Size(178, 20);
            this.txtUpdatePrice.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(76, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Price:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Caliber:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Model Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Manufacturer:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Serial Number:";
            // 
            // txtPrimaryKey
            // 
            this.txtPrimaryKey.Enabled = false;
            this.txtPrimaryKey.Location = new System.Drawing.Point(116, 65);
            this.txtPrimaryKey.Name = "txtPrimaryKey";
            this.txtPrimaryKey.Size = new System.Drawing.Size(178, 20);
            this.txtPrimaryKey.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Primary Key:";
            // 
            // FormUpdateFirearm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPrimaryKey);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUpdatePrice);
            this.Controls.Add(this.txtUpdateCaliber);
            this.Controls.Add(this.txtUpdateModel);
            this.Controls.Add(this.txtUpdateManufacturer);
            this.Controls.Add(this.txtUpdateSerialNum);
            this.Controls.Add(this.btnUpdateFirearm);
            this.Name = "FormUpdateFirearm";
            this.Text = "formUpdateFirearm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdateFirearm;
        private System.Windows.Forms.TextBox txtUpdateSerialNum;
        private System.Windows.Forms.TextBox txtUpdateManufacturer;
        private System.Windows.Forms.TextBox txtUpdateModel;
        private System.Windows.Forms.TextBox txtUpdateCaliber;
        private System.Windows.Forms.TextBox txtUpdatePrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPrimaryKey;
        private System.Windows.Forms.Label label6;
    }
}