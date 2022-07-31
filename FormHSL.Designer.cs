namespace WindowsFormsHSL
{
    partial class FormHSL
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
            this.Connect_Btn = new System.Windows.Forms.Button();
            this.Disconnect_Btn = new System.Windows.Forms.Button();
            this.PLCAdress_Text = new System.Windows.Forms.TextBox();
            this.Read_Btn = new System.Windows.Forms.Button();
            this.Write_Btn = new System.Windows.Forms.Button();
            this.Value_Text = new System.Windows.Forms.TextBox();
            this.PLCType_Cbb = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Connect_Btn
            // 
            this.Connect_Btn.Location = new System.Drawing.Point(25, 22);
            this.Connect_Btn.Name = "Connect_Btn";
            this.Connect_Btn.Size = new System.Drawing.Size(103, 42);
            this.Connect_Btn.TabIndex = 0;
            this.Connect_Btn.Text = "Connect";
            this.Connect_Btn.UseVisualStyleBackColor = true;
            this.Connect_Btn.Click += new System.EventHandler(this.Connect_Btn_Click);
            // 
            // Disconnect_Btn
            // 
            this.Disconnect_Btn.Location = new System.Drawing.Point(149, 22);
            this.Disconnect_Btn.Name = "Disconnect_Btn";
            this.Disconnect_Btn.Size = new System.Drawing.Size(103, 42);
            this.Disconnect_Btn.TabIndex = 0;
            this.Disconnect_Btn.Text = "Disconnect";
            this.Disconnect_Btn.UseVisualStyleBackColor = true;
            this.Disconnect_Btn.Click += new System.EventHandler(this.Disconnect_Btn_Click);
            // 
            // PLCAdress_Text
            // 
            this.PLCAdress_Text.Location = new System.Drawing.Point(27, 156);
            this.PLCAdress_Text.Name = "PLCAdress_Text";
            this.PLCAdress_Text.Size = new System.Drawing.Size(225, 20);
            this.PLCAdress_Text.TabIndex = 1;
            this.PLCAdress_Text.Text = "1000";
            this.PLCAdress_Text.TextChanged += new System.EventHandler(this.PLCAdress_Text_TextChanged);
            // 
            // Read_Btn
            // 
            this.Read_Btn.Location = new System.Drawing.Point(25, 192);
            this.Read_Btn.Name = "Read_Btn";
            this.Read_Btn.Size = new System.Drawing.Size(103, 42);
            this.Read_Btn.TabIndex = 0;
            this.Read_Btn.Text = "Read";
            this.Read_Btn.UseVisualStyleBackColor = true;
            this.Read_Btn.Click += new System.EventHandler(this.Read_Btn_Click);
            // 
            // Write_Btn
            // 
            this.Write_Btn.Location = new System.Drawing.Point(149, 192);
            this.Write_Btn.Name = "Write_Btn";
            this.Write_Btn.Size = new System.Drawing.Size(103, 42);
            this.Write_Btn.TabIndex = 0;
            this.Write_Btn.Text = "Write";
            this.Write_Btn.UseVisualStyleBackColor = true;
            this.Write_Btn.Click += new System.EventHandler(this.Write_Btn_Click);
            // 
            // Value_Text
            // 
            this.Value_Text.Location = new System.Drawing.Point(275, 156);
            this.Value_Text.Name = "Value_Text";
            this.Value_Text.Size = new System.Drawing.Size(225, 20);
            this.Value_Text.TabIndex = 1;
            // 
            // PLCType_Cbb
            // 
            this.PLCType_Cbb.FormattingEnabled = true;
            this.PLCType_Cbb.Items.AddRange(new object[] {
            "M",
            "D",
            "X",
            "Y",
            "SD"});
            this.PLCType_Cbb.Location = new System.Drawing.Point(24, 124);
            this.PLCType_Cbb.Name = "PLCType_Cbb";
            this.PLCType_Cbb.Size = new System.Drawing.Size(227, 21);
            this.PLCType_Cbb.TabIndex = 2;
            this.PLCType_Cbb.Text = "M";
            this.PLCType_Cbb.SelectedIndexChanged += new System.EventHandler(this.PLCType_Cbb_SelectedIndexChanged);
            // 
            // FormHSL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PLCType_Cbb);
            this.Controls.Add(this.PLCAdress_Text);
            this.Controls.Add(this.Value_Text);
            this.Controls.Add(this.Write_Btn);
            this.Controls.Add(this.Read_Btn);
            this.Controls.Add(this.Disconnect_Btn);
            this.Controls.Add(this.Connect_Btn);
            this.Name = "FormHSL";
            this.Text = "FormHSL";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Connect_Btn;
        private System.Windows.Forms.Button Disconnect_Btn;
        private System.Windows.Forms.TextBox PLCAdress_Text;
        private System.Windows.Forms.Button Read_Btn;
        private System.Windows.Forms.Button Write_Btn;
        private System.Windows.Forms.TextBox Value_Text;
        private System.Windows.Forms.ComboBox PLCType_Cbb;
    }
}