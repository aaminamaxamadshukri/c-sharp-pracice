namespace assignmt
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
            this.txtfood1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtpricefood1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtfood2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtpricefood2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtamountip = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblNetAmount = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblTotalAmount = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lblTipAmount = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lblsalartext = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lblfullpay = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtfood1
            // 
            this.txtfood1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfood1.Location = new System.Drawing.Point(270, 12);
            this.txtfood1.Name = "txtfood1";
            this.txtfood1.Size = new System.Drawing.Size(192, 28);
            this.txtfood1.TabIndex = 0;
            this.txtfood1.Text = "66";
            this.txtfood1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "EnterName Food 1:";
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(56, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter Price Food 1:";
            // 
            // txtpricefood1
            // 
            this.txtpricefood1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpricefood1.Location = new System.Drawing.Point(270, 62);
            this.txtpricefood1.Name = "txtpricefood1";
            this.txtpricefood1.Size = new System.Drawing.Size(192, 28);
            this.txtpricefood1.TabIndex = 2;
            this.txtpricefood1.Text = "10";
            this.txtpricefood1.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(56, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Enter Name Food 2:";
            // 
            // txtfood2
            // 
            this.txtfood2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfood2.Location = new System.Drawing.Point(270, 120);
            this.txtfood2.Name = "txtfood2";
            this.txtfood2.Size = new System.Drawing.Size(192, 28);
            this.txtfood2.TabIndex = 4;
            this.txtfood2.Text = "1";
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(56, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(193, 28);
            this.label4.TabIndex = 7;
            this.label4.Text = "Enter Price Food 2:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtpricefood2
            // 
            this.txtpricefood2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpricefood2.Location = new System.Drawing.Point(270, 163);
            this.txtpricefood2.Name = "txtpricefood2";
            this.txtpricefood2.Size = new System.Drawing.Size(192, 28);
            this.txtpricefood2.TabIndex = 6;
            this.txtpricefood2.Text = "13";
            this.txtpricefood2.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(56, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(193, 28);
            this.label5.TabIndex = 9;
            this.label5.Text = "Ener Tips Amount :";
            // 
            // txtamountip
            // 
            this.txtamountip.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtamountip.Location = new System.Drawing.Point(270, 220);
            this.txtamountip.Name = "txtamountip";
            this.txtamountip.Size = new System.Drawing.Size(192, 28);
            this.txtamountip.TabIndex = 8;
            this.txtamountip.Text = "50";
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(19, 525);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(193, 28);
            this.label7.TabIndex = 17;
            this.label7.Text = "Total Net Amount:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // lblNetAmount
            // 
            this.lblNetAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNetAmount.Location = new System.Drawing.Point(233, 525);
            this.lblNetAmount.Name = "lblNetAmount";
            this.lblNetAmount.Size = new System.Drawing.Size(192, 28);
            this.lblNetAmount.TabIndex = 16;
            this.lblNetAmount.TextChanged += new System.EventHandler(this.textBox2_TextChanged_1);
            // 
            // label8
            // 
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(19, 473);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(193, 24);
            this.label8.TabIndex = 15;
            this.label8.Text = "Total Amount:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmount.Location = new System.Drawing.Point(233, 482);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(192, 28);
            this.lblTotalAmount.TabIndex = 14;
            this.lblTotalAmount.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label9
            // 
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(19, 424);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(193, 28);
            this.label9.TabIndex = 13;
            this.label9.Text = "Tips Amount:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // lblTipAmount
            // 
            this.lblTipAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipAmount.Location = new System.Drawing.Point(233, 424);
            this.lblTipAmount.Name = "lblTipAmount";
            this.lblTipAmount.Size = new System.Drawing.Size(192, 28);
            this.lblTipAmount.TabIndex = 12;
            this.lblTipAmount.TextChanged += new System.EventHandler(this.textBox4_TextChanged_1);
            // 
            // label10
            // 
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(19, 374);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(167, 28);
            this.label10.TabIndex = 11;
            this.label10.Text = "Salex Text is:";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // lblsalartext
            // 
            this.lblsalartext.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsalartext.Location = new System.Drawing.Point(233, 374);
            this.lblsalartext.Name = "lblsalartext";
            this.lblsalartext.Size = new System.Drawing.Size(192, 28);
            this.lblsalartext.TabIndex = 10;
            this.lblsalartext.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(473, 264);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 70);
            this.button1.TabIndex = 19;
            this.button1.Text = "close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(270, 264);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(170, 70);
            this.button2.TabIndex = 20;
            this.button2.Text = "clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(42, 264);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(207, 70);
            this.button3.TabIndex = 21;
            this.button3.Text = "Calculate Amount";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 571);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(167, 28);
            this.label6.TabIndex = 23;
            this.label6.Text = "Full pay";
            this.label6.Click += new System.EventHandler(this.label6_Click_1);
            // 
            // lblfullpay
            // 
            this.lblfullpay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfullpay.Location = new System.Drawing.Point(233, 571);
            this.lblfullpay.Name = "lblfullpay";
            this.lblfullpay.Size = new System.Drawing.Size(192, 28);
            this.lblfullpay.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 619);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblfullpay);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblNetAmount);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblTotalAmount);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblTipAmount);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblsalartext);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtamountip);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtpricefood2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtfood2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtpricefood1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtfood1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtfood1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtpricefood1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtfood2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtpricefood2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtamountip;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox lblNetAmount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox lblTotalAmount;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox lblTipAmount;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox lblsalartext;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox lblfullpay;
    }
}

