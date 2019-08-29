namespace TeamSourceControl
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
            this.lstFirearms = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtSerialNum = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtCaliber = new System.Windows.Forms.TextBox();
            this.txtManufacturer = new System.Windows.Forms.TextBox();
            this.lblSerialNum = new System.Windows.Forms.Label();
            this.lblManufacturer = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblCaliber = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstFirearms
            // 
            this.lstFirearms.FormattingEnabled = true;
            this.lstFirearms.Location = new System.Drawing.Point(554, 58);
            this.lstFirearms.Name = "lstFirearms";
            this.lstFirearms.Size = new System.Drawing.Size(120, 95);
            this.lstFirearms.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(168, 267);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtSerialNum
            // 
            this.txtSerialNum.Location = new System.Drawing.Point(168, 70);
            this.txtSerialNum.Name = "txtSerialNum";
            this.txtSerialNum.Size = new System.Drawing.Size(164, 20);
            this.txtSerialNum.TabIndex = 2;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(168, 145);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(164, 20);
            this.txtModel.TabIndex = 3;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(168, 221);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(164, 20);
            this.txtPrice.TabIndex = 4;
            // 
            // txtCaliber
            // 
            this.txtCaliber.Location = new System.Drawing.Point(168, 182);
            this.txtCaliber.Name = "txtCaliber";
            this.txtCaliber.Size = new System.Drawing.Size(164, 20);
            this.txtCaliber.TabIndex = 5;
            // 
            // txtManufacturer
            // 
            this.txtManufacturer.Location = new System.Drawing.Point(168, 107);
            this.txtManufacturer.Name = "txtManufacturer";
            this.txtManufacturer.Size = new System.Drawing.Size(164, 20);
            this.txtManufacturer.TabIndex = 6;
            // 
            // lblSerialNum
            // 
            this.lblSerialNum.AutoSize = true;
            this.lblSerialNum.Location = new System.Drawing.Point(86, 77);
            this.lblSerialNum.Name = "lblSerialNum";
            this.lblSerialNum.Size = new System.Drawing.Size(76, 13);
            this.lblSerialNum.TabIndex = 7;
            this.lblSerialNum.Text = "Serial Number:";
            // 
            // lblManufacturer
            // 
            this.lblManufacturer.AutoSize = true;
            this.lblManufacturer.Location = new System.Drawing.Point(86, 114);
            this.lblManufacturer.Name = "lblManufacturer";
            this.lblManufacturer.Size = new System.Drawing.Size(73, 13);
            this.lblManufacturer.TabIndex = 8;
            this.lblManufacturer.Text = "Manufacturer:";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(86, 152);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(39, 13);
            this.lblModel.TabIndex = 9;
            this.lblModel.Text = "Model:";
            // 
            // lblCaliber
            // 
            this.lblCaliber.AutoSize = true;
            this.lblCaliber.Location = new System.Drawing.Point(86, 189);
            this.lblCaliber.Name = "lblCaliber";
            this.lblCaliber.Size = new System.Drawing.Size(42, 13);
            this.lblCaliber.TabIndex = 10;
            this.lblCaliber.Text = "Caliber:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(86, 228);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(34, 13);
            this.lblPrice.TabIndex = 11;
            this.lblPrice.Text = "Price:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblCaliber);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.lblManufacturer);
            this.Controls.Add(this.lblSerialNum);
            this.Controls.Add(this.txtManufacturer);
            this.Controls.Add(this.txtCaliber);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.txtSerialNum);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lstFirearms);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstFirearms;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtSerialNum;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtCaliber;
        private System.Windows.Forms.TextBox txtManufacturer;
        private System.Windows.Forms.Label lblSerialNum;
        private System.Windows.Forms.Label lblManufacturer;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblCaliber;
        private System.Windows.Forms.Label lblPrice;
    }
}

