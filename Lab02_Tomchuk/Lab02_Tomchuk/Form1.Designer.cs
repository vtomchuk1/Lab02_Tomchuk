namespace Lab02_Tomchuk
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
            this.lable_key_P = new System.Windows.Forms.Label();
            this.key_Key = new System.Windows.Forms.Label();
            this.key_C = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button_Clear = new System.Windows.Forms.Button();
            this.button_Xor = new System.Windows.Forms.Button();
            this.group_crypted = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.group_crypted.SuspendLayout();
            this.SuspendLayout();
            // 
            // lable_key_P
            // 
            this.lable_key_P.AutoSize = true;
            this.lable_key_P.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lable_key_P.Location = new System.Drawing.Point(39, 34);
            this.lable_key_P.Name = "lable_key_P";
            this.lable_key_P.Size = new System.Drawing.Size(31, 19);
            this.lable_key_P.TabIndex = 0;
            this.lable_key_P.Text = "P=";
            // 
            // key_Key
            // 
            this.key_Key.AutoSize = true;
            this.key_Key.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.key_Key.Location = new System.Drawing.Point(17, 107);
            this.key_Key.Name = "key_Key";
            this.key_Key.Size = new System.Drawing.Size(53, 19);
            this.key_Key.TabIndex = 1;
            this.key_Key.Text = "Key=";
            // 
            // key_C
            // 
            this.key_C.AutoSize = true;
            this.key_C.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.key_C.Location = new System.Drawing.Point(39, 188);
            this.key_C.Name = "key_C";
            this.key_C.Size = new System.Drawing.Size(31, 19);
            this.key_C.TabIndex = 2;
            this.key_C.Text = "C=";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(76, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(76, 108);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(76, 189);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 5;
            // 
            // button_Clear
            // 
            this.button_Clear.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Clear.Location = new System.Drawing.Point(76, 216);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(100, 33);
            this.button_Clear.TabIndex = 6;
            this.button_Clear.Text = "button1";
            this.button_Clear.UseVisualStyleBackColor = true;
            // 
            // button_Xor
            // 
            this.button_Xor.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Xor.Location = new System.Drawing.Point(196, 245);
            this.button_Xor.Name = "button_Xor";
            this.button_Xor.Size = new System.Drawing.Size(62, 43);
            this.button_Xor.TabIndex = 7;
            this.button_Xor.Text = "XOR";
            this.button_Xor.UseVisualStyleBackColor = true;
            // 
            // group_crypted
            // 
            this.group_crypted.Controls.Add(this.label9);
            this.group_crypted.Controls.Add(this.label8);
            this.group_crypted.Controls.Add(this.button_Clear);
            this.group_crypted.Controls.Add(this.label7);
            this.group_crypted.Controls.Add(this.button_Xor);
            this.group_crypted.Controls.Add(this.textBox1);
            this.group_crypted.Controls.Add(this.lable_key_P);
            this.group_crypted.Controls.Add(this.key_Key);
            this.group_crypted.Controls.Add(this.textBox3);
            this.group_crypted.Controls.Add(this.key_C);
            this.group_crypted.Controls.Add(this.textBox2);
            this.group_crypted.Location = new System.Drawing.Point(12, 12);
            this.group_crypted.Name = "group_crypted";
            this.group_crypted.Size = new System.Drawing.Size(339, 325);
            this.group_crypted.TabIndex = 8;
            this.group_crypted.TabStop = false;
            this.group_crypted.Text = "Шифрування";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(480, 180);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(561, 180);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(446, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Розшифрування";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(190, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 71);
            this.label7.TabIndex = 12;
            this.label7.Text = "перше";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(190, 110);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 16);
            this.label8.TabIndex = 13;
            this.label8.Text = "label8";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(193, 205);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 16);
            this.label9.TabIndex = 14;
            this.label9.Text = "label9";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.group_crypted);
            this.Name = "Form1";
            this.Text = "Form1";
            this.group_crypted.ResumeLayout(false);
            this.group_crypted.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lable_key_P;
        private System.Windows.Forms.Label key_Key;
        private System.Windows.Forms.Label key_C;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button_Clear;
        private System.Windows.Forms.Button button_Xor;
        private System.Windows.Forms.GroupBox group_crypted;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

