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
            this.SuspendLayout();
            // 
            // btnUpdateFirearm
            // 
            this.btnUpdateFirearm.Location = new System.Drawing.Point(153, 253);
            this.btnUpdateFirearm.Name = "btnUpdateFirearm";
            this.btnUpdateFirearm.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateFirearm.TabIndex = 0;
            this.btnUpdateFirearm.Text = "Update";
            this.btnUpdateFirearm.UseVisualStyleBackColor = true;
            this.btnUpdateFirearm.Click += new System.EventHandler(this.btnUpdateFirearm_Click);
            // 
            // txtUpdateSerialNum
            // 
            this.txtUpdateSerialNum.Location = new System.Drawing.Point(116, 91);
            this.txtUpdateSerialNum.Name = "txtUpdateSerialNum";
            this.txtUpdateSerialNum.Size = new System.Drawing.Size(178, 20);
            this.txtUpdateSerialNum.TabIndex = 1;
            // 
            // txtUpdateManufacturer
            // 
            this.txtUpdateManufacturer.Location = new System.Drawing.Point(116, 117);
            this.txtUpdateManufacturer.Name = "txtUpdateManufacturer";
            this.txtUpdateManufacturer.Size = new System.Drawing.Size(178, 20);
            this.txtUpdateManufacturer.TabIndex = 2;
            // 
            // txtUpdateModel
            // 
            this.txtUpdateModel.Location = new System.Drawing.Point(116, 143);
            this.txtUpdateModel.Name = "txtUpdateModel";
            this.txtUpdateModel.Size = new System.Drawing.Size(178, 20);
            this.txtUpdateModel.TabIndex = 3;
            // 
            // txtUpdateCaliber
            // 
            this.txtUpdateCaliber.Location = new System.Drawing.Point(116, 169);
            this.txtUpdateCaliber.Name = "txtUpdateCaliber";
            this.txtUpdateCaliber.Size = new System.Drawing.Size(178, 20);
            this.txtUpdateCaliber.TabIndex = 4;
            // 
            // txtUpdatePrice
            // 
            this.txtUpdatePrice.Location = new System.Drawing.Point(116, 195);
            this.txtUpdatePrice.Name = "txtUpdatePrice";
            this.txtUpdatePrice.Size = new System.Drawing.Size(178, 20);
            this.txtUpdatePrice.TabIndex = 5;
            // 
            // FormUpdateFirearm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}