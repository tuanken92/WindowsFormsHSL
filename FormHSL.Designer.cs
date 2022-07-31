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
            this.IP_Txt = new System.Windows.Forms.TextBox();
            this.Port_Txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Octal_Txt = new System.Windows.Forms.TextBox();
            this.Hex_Txt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Oct2Hex_Btn = new System.Windows.Forms.Button();
            this.Hex2Oct_Btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Connect_Btn
            // 
            this.Connect_Btn.Location = new System.Drawing.Point(85, 67);
            this.Connect_Btn.Name = "Connect_Btn";
            this.Connect_Btn.Size = new System.Drawing.Size(103, 42);
            this.Connect_Btn.TabIndex = 0;
            this.Connect_Btn.Text = "Connect";
            this.Connect_Btn.UseVisualStyleBackColor = true;
            this.Connect_Btn.Click += new System.EventHandler(this.Connect_Btn_Click);
            // 
            // Disconnect_Btn
            // 
            this.Disconnect_Btn.Location = new System.Drawing.Point(209, 67);
            this.Disconnect_Btn.Name = "Disconnect_Btn";
            this.Disconnect_Btn.Size = new System.Drawing.Size(103, 42);
            this.Disconnect_Btn.TabIndex = 0;
            this.Disconnect_Btn.Text = "Disconnect";
            this.Disconnect_Btn.UseVisualStyleBackColor = true;
            this.Disconnect_Btn.Click += new System.EventHandler(this.Disconnect_Btn_Click);
            // 
            // PLCAdress_Text
            // 
            this.PLCAdress_Text.Location = new System.Drawing.Point(85, 159);
            this.PLCAdress_Text.Name = "PLCAdress_Text";
            this.PLCAdress_Text.Size = new System.Drawing.Size(225, 20);
            this.PLCAdress_Text.TabIndex = 1;
            this.PLCAdress_Text.Text = "1000";
            this.PLCAdress_Text.TextChanged += new System.EventHandler(this.PLCAdress_Text_TextChanged);
            // 
            // Read_Btn
            // 
            this.Read_Btn.Location = new System.Drawing.Point(83, 225);
            this.Read_Btn.Name = "Read_Btn";
            this.Read_Btn.Size = new System.Drawing.Size(103, 42);
            this.Read_Btn.TabIndex = 0;
            this.Read_Btn.Text = "Read";
            this.Read_Btn.UseVisualStyleBackColor = true;
            this.Read_Btn.Click += new System.EventHandler(this.Read_Btn_Click);
            // 
            // Write_Btn
            // 
            this.Write_Btn.Location = new System.Drawing.Point(207, 225);
            this.Write_Btn.Name = "Write_Btn";
            this.Write_Btn.Size = new System.Drawing.Size(103, 42);
            this.Write_Btn.TabIndex = 0;
            this.Write_Btn.Text = "Write";
            this.Write_Btn.UseVisualStyleBackColor = true;
            this.Write_Btn.Click += new System.EventHandler(this.Write_Btn_Click);
            // 
            // Value_Text
            // 
            this.Value_Text.Location = new System.Drawing.Point(85, 193);
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
            this.PLCType_Cbb.Location = new System.Drawing.Point(85, 124);
            this.PLCType_Cbb.Name = "PLCType_Cbb";
            this.PLCType_Cbb.Size = new System.Drawing.Size(227, 21);
            this.PLCType_Cbb.TabIndex = 2;
            this.PLCType_Cbb.Text = "M";
            this.PLCType_Cbb.SelectedIndexChanged += new System.EventHandler(this.PLCType_Cbb_SelectedIndexChanged);
            // 
            // IP_Txt
            // 
            this.IP_Txt.Location = new System.Drawing.Point(88, 12);
            this.IP_Txt.Name = "IP_Txt";
            this.IP_Txt.Size = new System.Drawing.Size(225, 20);
            this.IP_Txt.TabIndex = 1;
            this.IP_Txt.Text = "192.168.1.115";
            // 
            // Port_Txt
            // 
            this.Port_Txt.Location = new System.Drawing.Point(87, 38);
            this.Port_Txt.Name = "Port_Txt";
            this.Port_Txt.Size = new System.Drawing.Size(225, 20);
            this.Port_Txt.TabIndex = 1;
            this.Port_Txt.Text = "12289";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "IP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Port";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "PLC Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "PLC Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "PLC Value";
            // 
            // Octal_Txt
            // 
            this.Octal_Txt.Location = new System.Drawing.Point(389, 13);
            this.Octal_Txt.Name = "Octal_Txt";
            this.Octal_Txt.Size = new System.Drawing.Size(129, 20);
            this.Octal_Txt.TabIndex = 1;
            // 
            // Hex_Txt
            // 
            this.Hex_Txt.Location = new System.Drawing.Point(388, 39);
            this.Hex_Txt.Name = "Hex_Txt";
            this.Hex_Txt.Size = new System.Drawing.Size(129, 20);
            this.Hex_Txt.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(354, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Octal";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(354, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Hex";
            // 
            // Oct2Hex_Btn
            // 
            this.Oct2Hex_Btn.Location = new System.Drawing.Point(390, 65);
            this.Oct2Hex_Btn.Name = "Oct2Hex_Btn";
            this.Oct2Hex_Btn.Size = new System.Drawing.Size(57, 29);
            this.Oct2Hex_Btn.TabIndex = 0;
            this.Oct2Hex_Btn.Text = "Oct2Hex";
            this.Oct2Hex_Btn.UseVisualStyleBackColor = true;
            this.Oct2Hex_Btn.Click += new System.EventHandler(this.Oct2Hex_Btn_Click);
            // 
            // Hex2Oct_Btn
            // 
            this.Hex2Oct_Btn.Location = new System.Drawing.Point(461, 65);
            this.Hex2Oct_Btn.Name = "Hex2Oct_Btn";
            this.Hex2Oct_Btn.Size = new System.Drawing.Size(57, 29);
            this.Hex2Oct_Btn.TabIndex = 0;
            this.Hex2Oct_Btn.Text = "Hex2Oct";
            this.Hex2Oct_Btn.UseVisualStyleBackColor = true;
            this.Hex2Oct_Btn.Click += new System.EventHandler(this.Hex2Oct_Btn_Click);
            // 
            // FormHSL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 288);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PLCType_Cbb);
            this.Controls.Add(this.PLCAdress_Text);
            this.Controls.Add(this.Hex_Txt);
            this.Controls.Add(this.Port_Txt);
            this.Controls.Add(this.Octal_Txt);
            this.Controls.Add(this.IP_Txt);
            this.Controls.Add(this.Value_Text);
            this.Controls.Add(this.Write_Btn);
            this.Controls.Add(this.Read_Btn);
            this.Controls.Add(this.Hex2Oct_Btn);
            this.Controls.Add(this.Oct2Hex_Btn);
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
        private System.Windows.Forms.TextBox IP_Txt;
        private System.Windows.Forms.TextBox Port_Txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Octal_Txt;
        private System.Windows.Forms.TextBox Hex_Txt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Oct2Hex_Btn;
        private System.Windows.Forms.Button Hex2Oct_Btn;
    }
}