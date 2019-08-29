namespace TeamSourceControl
{
    partial class FrmAddFirearm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSerialNumber = new System.Windows.Forms.TextBox();
            this.txtManufacturer = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtCaliper = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.btnAddFirearm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Serial Number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Manufacturer:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Model Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Caliber:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Price:";
            // 
            // txtSerialNumber
            // 
            this.txtSerialNumber.Location = new System.Drawing.Point(170, 70);
            this.txtSerialNumber.Name = "txtSerialNumber";
            this.txtSerialNumber.Size = new System.Drawing.Size(204, 20);
            this.txtSerialNumber.TabIndex = 5;
            // 
            // txtManufacturer
            // 
            this.txtManufacturer.Location = new System.Drawing.Point(170, 108);
            this.txtManufacturer.Name = "txtManufacturer";
            this.txtManufacturer.Size = new System.Drawing.Size(204, 20);
            this.txtManufacturer.TabIndex = 6;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(170, 211);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(204, 20);
            this.txtPrice.TabIndex = 7;
            // 
            // txtCaliper
            // 
            this.txtCaliper.Location = new System.Drawing.Point(170, 177);
            this.txtCaliper.Name = "txtCaliper";
            this.txtCaliper.Size = new System.Drawing.Size(204, 20);
            this.txtCaliper.TabIndex = 8;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(170, 142);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(204, 20);
            this.txtModel.TabIndex = 9;
            // 
            // btnAddFirearm
            // 
            this.btnAddFirearm.Location = new System.Drawing.Point(170, 279);
            this.btnAddFirearm.Name = "btnAddFirearm";
            this.btnAddFirearm.Size = new System.Drawing.Size(116, 23);
            this.btnAddFirearm.TabIndex = 10;
            this.btnAddFirearm.Text = "Add Firearm";
            this.btnAddFirearm.UseVisualStyleBackColor = true;
            this.btnAddFirearm.Click += new System.EventHandler(this.btnAddFirearm_Click);
            // 
            // frmAddFirearm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAddFirearm);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.txtCaliper);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtManufacturer);
            this.Controls.Add(this.txtSerialNumber);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmAddFirearm";
            this.Text = "frmAddFirearm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSerialNumber;
        private System.Windows.Forms.TextBox txtManufacturer;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtCaliper;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Button btnAddFirearm;
    }
}