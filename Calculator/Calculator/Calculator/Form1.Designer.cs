namespace Calculator
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
            this.btn_ac = new System.Windows.Forms.Button();
            this.txt_result = new System.Windows.Forms.TextBox();
            this.btn_del = new System.Windows.Forms.Button();
            this.btn_plus = new System.Windows.Forms.Button();
            this.btn_7 = new System.Windows.Forms.Button();
            this.btn_8 = new System.Windows.Forms.Button();
            this.btn_9 = new System.Windows.Forms.Button();
            this.btn_sub = new System.Windows.Forms.Button();
            this.btn_6 = new System.Windows.Forms.Button();
            this.btn_5 = new System.Windows.Forms.Button();
            this.btn_4 = new System.Windows.Forms.Button();
            this.btn_mul = new System.Windows.Forms.Button();
            this.btn_1 = new System.Windows.Forms.Button();
            this.btn_2 = new System.Windows.Forms.Button();
            this.btn_3 = new System.Windows.Forms.Button();
            this.btn_div = new System.Windows.Forms.Button();
            this.btn_0 = new System.Windows.Forms.Button();
            this.btn_point = new System.Windows.Forms.Button();
            this.btn_eql = new System.Windows.Forms.Button();
            this.lbl_displayValue = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_ac
            // 
            this.btn_ac.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(210)))));
            this.btn_ac.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ac.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ac.Location = new System.Drawing.Point(41, 128);
            this.btn_ac.Name = "btn_ac";
            this.btn_ac.Size = new System.Drawing.Size(102, 45);
            this.btn_ac.TabIndex = 0;
            this.btn_ac.Text = "AC";
            this.btn_ac.UseVisualStyleBackColor = false;
            this.btn_ac.Click += new System.EventHandler(this.btn_ac_Click);
            // 
            // txt_result
            // 
            this.txt_result.BackColor = System.Drawing.Color.Silver;
            this.txt_result.Font = new System.Drawing.Font("Microsoft Tai Le", 15F);
            this.txt_result.Location = new System.Drawing.Point(41, 61);
            this.txt_result.Multiline = true;
            this.txt_result.Name = "txt_result";
            this.txt_result.Size = new System.Drawing.Size(210, 48);
            this.txt_result.TabIndex = 20;
            this.txt_result.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn_del
            // 
            this.btn_del.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(210)))));
            this.btn_del.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_del.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_del.Location = new System.Drawing.Point(149, 128);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(48, 45);
            this.btn_del.TabIndex = 21;
            this.btn_del.Text = "Del";
            this.btn_del.UseVisualStyleBackColor = false;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // btn_plus
            // 
            this.btn_plus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(149)))), ((int)(((byte)(0)))));
            this.btn_plus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_plus.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_plus.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.btn_plus.Location = new System.Drawing.Point(203, 128);
            this.btn_plus.Name = "btn_plus";
            this.btn_plus.Size = new System.Drawing.Size(48, 45);
            this.btn_plus.TabIndex = 23;
            this.btn_plus.Text = "+";
            this.btn_plus.UseVisualStyleBackColor = false;
            this.btn_plus.Click += new System.EventHandler(this.click_operations);
            // 
            // btn_7
            // 
            this.btn_7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btn_7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_7.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_7.ForeColor = System.Drawing.Color.White;
            this.btn_7.Location = new System.Drawing.Point(41, 178);
            this.btn_7.Name = "btn_7";
            this.btn_7.Size = new System.Drawing.Size(48, 45);
            this.btn_7.TabIndex = 24;
            this.btn_7.Text = "7";
            this.btn_7.UseVisualStyleBackColor = false;
            this.btn_7.Click += new System.EventHandler(this.button_click);
            // 
            // btn_8
            // 
            this.btn_8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btn_8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_8.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_8.ForeColor = System.Drawing.Color.White;
            this.btn_8.Location = new System.Drawing.Point(95, 178);
            this.btn_8.Name = "btn_8";
            this.btn_8.Size = new System.Drawing.Size(48, 45);
            this.btn_8.TabIndex = 25;
            this.btn_8.Text = "8";
            this.btn_8.UseVisualStyleBackColor = false;
            this.btn_8.Click += new System.EventHandler(this.button_click);
            // 
            // btn_9
            // 
            this.btn_9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btn_9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_9.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_9.ForeColor = System.Drawing.Color.White;
            this.btn_9.Location = new System.Drawing.Point(149, 178);
            this.btn_9.Name = "btn_9";
            this.btn_9.Size = new System.Drawing.Size(48, 45);
            this.btn_9.TabIndex = 26;
            this.btn_9.Text = "9";
            this.btn_9.UseVisualStyleBackColor = false;
            this.btn_9.Click += new System.EventHandler(this.button_click);
            // 
            // btn_sub
            // 
            this.btn_sub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(149)))), ((int)(((byte)(0)))));
            this.btn_sub.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_sub.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sub.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.btn_sub.Location = new System.Drawing.Point(203, 178);
            this.btn_sub.Name = "btn_sub";
            this.btn_sub.Size = new System.Drawing.Size(48, 45);
            this.btn_sub.TabIndex = 27;
            this.btn_sub.Text = "-";
            this.btn_sub.UseVisualStyleBackColor = false;
            this.btn_sub.Click += new System.EventHandler(this.click_operations);
            // 
            // btn_6
            // 
            this.btn_6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btn_6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_6.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_6.ForeColor = System.Drawing.Color.White;
            this.btn_6.Location = new System.Drawing.Point(41, 229);
            this.btn_6.Name = "btn_6";
            this.btn_6.Size = new System.Drawing.Size(48, 45);
            this.btn_6.TabIndex = 28;
            this.btn_6.Text = "6";
            this.btn_6.UseVisualStyleBackColor = false;
            this.btn_6.Click += new System.EventHandler(this.button_click);
            // 
            // btn_5
            // 
            this.btn_5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btn_5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_5.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_5.ForeColor = System.Drawing.Color.White;
            this.btn_5.Location = new System.Drawing.Point(95, 229);
            this.btn_5.Name = "btn_5";
            this.btn_5.Size = new System.Drawing.Size(48, 45);
            this.btn_5.TabIndex = 29;
            this.btn_5.Text = "5";
            this.btn_5.UseVisualStyleBackColor = false;
            this.btn_5.Click += new System.EventHandler(this.button_click);
            // 
            // btn_4
            // 
            this.btn_4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btn_4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_4.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_4.ForeColor = System.Drawing.Color.White;
            this.btn_4.Location = new System.Drawing.Point(149, 229);
            this.btn_4.Name = "btn_4";
            this.btn_4.Size = new System.Drawing.Size(48, 45);
            this.btn_4.TabIndex = 30;
            this.btn_4.Text = "4";
            this.btn_4.UseVisualStyleBackColor = false;
            this.btn_4.Click += new System.EventHandler(this.button_click);
            // 
            // btn_mul
            // 
            this.btn_mul.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(149)))), ((int)(((byte)(0)))));
            this.btn_mul.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_mul.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mul.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.btn_mul.Location = new System.Drawing.Point(203, 229);
            this.btn_mul.Name = "btn_mul";
            this.btn_mul.Size = new System.Drawing.Size(48, 45);
            this.btn_mul.TabIndex = 31;
            this.btn_mul.Text = "x";
            this.btn_mul.UseVisualStyleBackColor = false;
            this.btn_mul.Click += new System.EventHandler(this.click_operations);
            // 
            // btn_1
            // 
            this.btn_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btn_1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_1.ForeColor = System.Drawing.Color.White;
            this.btn_1.Location = new System.Drawing.Point(41, 280);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(48, 45);
            this.btn_1.TabIndex = 32;
            this.btn_1.Text = "1";
            this.btn_1.UseVisualStyleBackColor = false;
            this.btn_1.Click += new System.EventHandler(this.button_click);
            // 
            // btn_2
            // 
            this.btn_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btn_2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_2.ForeColor = System.Drawing.Color.White;
            this.btn_2.Location = new System.Drawing.Point(95, 280);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(48, 45);
            this.btn_2.TabIndex = 34;
            this.btn_2.Text = "2";
            this.btn_2.UseVisualStyleBackColor = false;
            this.btn_2.Click += new System.EventHandler(this.button_click);
            // 
            // btn_3
            // 
            this.btn_3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btn_3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_3.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_3.ForeColor = System.Drawing.Color.White;
            this.btn_3.Location = new System.Drawing.Point(149, 280);
            this.btn_3.Name = "btn_3";
            this.btn_3.Size = new System.Drawing.Size(48, 45);
            this.btn_3.TabIndex = 35;
            this.btn_3.Text = "3";
            this.btn_3.UseVisualStyleBackColor = false;
            this.btn_3.Click += new System.EventHandler(this.button_click);
            // 
            // btn_div
            // 
            this.btn_div.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(149)))), ((int)(((byte)(0)))));
            this.btn_div.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_div.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_div.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.btn_div.Location = new System.Drawing.Point(203, 280);
            this.btn_div.Name = "btn_div";
            this.btn_div.Size = new System.Drawing.Size(48, 45);
            this.btn_div.TabIndex = 36;
            this.btn_div.Text = "/";
            this.btn_div.UseVisualStyleBackColor = false;
            this.btn_div.Click += new System.EventHandler(this.click_operations);
            // 
            // btn_0
            // 
            this.btn_0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btn_0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_0.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_0.ForeColor = System.Drawing.Color.White;
            this.btn_0.Location = new System.Drawing.Point(41, 331);
            this.btn_0.Name = "btn_0";
            this.btn_0.Size = new System.Drawing.Size(102, 45);
            this.btn_0.TabIndex = 37;
            this.btn_0.Text = "0";
            this.btn_0.UseVisualStyleBackColor = false;
            this.btn_0.Click += new System.EventHandler(this.button_click);
            // 
            // btn_point
            // 
            this.btn_point.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btn_point.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_point.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_point.ForeColor = System.Drawing.Color.White;
            this.btn_point.Location = new System.Drawing.Point(149, 331);
            this.btn_point.Name = "btn_point";
            this.btn_point.Size = new System.Drawing.Size(48, 45);
            this.btn_point.TabIndex = 38;
            this.btn_point.Text = ".";
            this.btn_point.UseVisualStyleBackColor = false;
            this.btn_point.Click += new System.EventHandler(this.button_click);
            // 
            // btn_eql
            // 
            this.btn_eql.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(149)))), ((int)(((byte)(0)))));
            this.btn_eql.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_eql.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eql.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.btn_eql.Location = new System.Drawing.Point(203, 331);
            this.btn_eql.Name = "btn_eql";
            this.btn_eql.Size = new System.Drawing.Size(48, 45);
            this.btn_eql.TabIndex = 39;
            this.btn_eql.Text = "=";
            this.btn_eql.UseVisualStyleBackColor = false;
            this.btn_eql.Click += new System.EventHandler(this.btn_eql_Click);
            // 
            // lbl_displayValue
            // 
            this.lbl_displayValue.AutoSize = true;
            this.lbl_displayValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_displayValue.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.lbl_displayValue.Location = new System.Drawing.Point(48, 32);
            this.lbl_displayValue.Name = "lbl_displayValue";
            this.lbl_displayValue.Size = new System.Drawing.Size(16, 17);
            this.lbl_displayValue.TabIndex = 40;
            this.lbl_displayValue.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(110, 396);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 16);
            this.label1.TabIndex = 41;
            this.label1.Text = "Copyright © 2023 Suganth";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(290, 433);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_displayValue);
            this.Controls.Add(this.btn_eql);
            this.Controls.Add(this.btn_point);
            this.Controls.Add(this.btn_0);
            this.Controls.Add(this.btn_div);
            this.Controls.Add(this.btn_3);
            this.Controls.Add(this.btn_2);
            this.Controls.Add(this.btn_1);
            this.Controls.Add(this.btn_mul);
            this.Controls.Add(this.btn_4);
            this.Controls.Add(this.btn_5);
            this.Controls.Add(this.btn_6);
            this.Controls.Add(this.btn_sub);
            this.Controls.Add(this.btn_9);
            this.Controls.Add(this.btn_8);
            this.Controls.Add(this.btn_7);
            this.Controls.Add(this.btn_plus);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.txt_result);
            this.Controls.Add(this.btn_ac);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Calculator App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ac;
        private System.Windows.Forms.TextBox txt_result;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Button btn_plus;
        private System.Windows.Forms.Button btn_7;
        private System.Windows.Forms.Button btn_8;
        private System.Windows.Forms.Button btn_9;
        private System.Windows.Forms.Button btn_sub;
        private System.Windows.Forms.Button btn_6;
        private System.Windows.Forms.Button btn_5;
        private System.Windows.Forms.Button btn_4;
        private System.Windows.Forms.Button btn_mul;
        private System.Windows.Forms.Button btn_1;
        private System.Windows.Forms.Button btn_2;
        private System.Windows.Forms.Button btn_3;
        private System.Windows.Forms.Button btn_div;
        private System.Windows.Forms.Button btn_0;
        private System.Windows.Forms.Button btn_point;
        private System.Windows.Forms.Button btn_eql;
        private System.Windows.Forms.Label lbl_displayValue;
        private System.Windows.Forms.Label label1;
    }
}

