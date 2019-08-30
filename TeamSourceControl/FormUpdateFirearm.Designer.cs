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
            this.SuspendLayout();
            // 
            // btnUpdateFirearm
            // 
            this.btnUpdateFirearm.Location = new System.Drawing.Point(219, 292);
            this.btnUpdateFirearm.Name = "btnUpdateFirearm";
            this.btnUpdateFirearm.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateFirearm.TabIndex = 0;
            this.btnUpdateFirearm.Text = "Update";
            this.btnUpdateFirearm.UseVisualStyleBackColor = true;
            this.btnUpdateFirearm.Click += new System.EventHandler(this.btnUpdateFirearm_Click);
            // 
            // FormUpdateFirearm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUpdateFirearm);
            this.Name = "FormUpdateFirearm";
            this.Text = "formUpdateFirearm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUpdateFirearm;
    }
}