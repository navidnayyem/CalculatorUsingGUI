namespace GUI_Calculator
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
            this.display = new System.Windows.Forms.TextBox();
            this.bac = new System.Windows.Forms.Button();
            this.bsin = new System.Windows.Forms.Button();
            this.bcos = new System.Windows.Forms.Button();
            this.bpow = new System.Windows.Forms.Button();
            this.b7 = new System.Windows.Forms.Button();
            this.b8 = new System.Windows.Forms.Button();
            this.b9 = new System.Windows.Forms.Button();
            this.bdiv = new System.Windows.Forms.Button();
            this.b4 = new System.Windows.Forms.Button();
            this.b5 = new System.Windows.Forms.Button();
            this.b6 = new System.Windows.Forms.Button();
            this.bmul = new System.Windows.Forms.Button();
            this.b1 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.bmin = new System.Windows.Forms.Button();
            this.bdot = new System.Windows.Forms.Button();
            this.b0 = new System.Windows.Forms.Button();
            this.badd = new System.Windows.Forms.Button();
            this.beq = new System.Windows.Forms.Button();
            this.bmod = new System.Windows.Forms.Button();
            this.bsqrt = new System.Windows.Forms.Button();
            this.blog = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // display
            // 
            this.display.BackColor = System.Drawing.Color.SeaShell;
            this.display.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.display.Location = new System.Drawing.Point(25, 12);
            this.display.Multiline = true;
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(321, 34);
            this.display.TabIndex = 0;
            this.display.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.display.TextChanged += new System.EventHandler(this.display_TextChanged);
            // 
            // bac
            // 
            this.bac.BackColor = System.Drawing.Color.Yellow;
            this.bac.Location = new System.Drawing.Point(25, 52);
            this.bac.Name = "bac";
            this.bac.Size = new System.Drawing.Size(156, 23);
            this.bac.TabIndex = 1;
            this.bac.Text = "AC";
            this.bac.UseVisualStyleBackColor = false;
            this.bac.Click += new System.EventHandler(this.bac_Click);
            // 
            // bsin
            // 
            this.bsin.BackColor = System.Drawing.Color.Cornsilk;
            this.bsin.Location = new System.Drawing.Point(188, 52);
            this.bsin.Name = "bsin";
            this.bsin.Size = new System.Drawing.Size(75, 23);
            this.bsin.TabIndex = 2;
            this.bsin.Text = "SIN";
            this.bsin.UseVisualStyleBackColor = false;
            this.bsin.Click += new System.EventHandler(this.bsin_Click);
            // 
            // bcos
            // 
            this.bcos.BackColor = System.Drawing.Color.Cornsilk;
            this.bcos.Location = new System.Drawing.Point(269, 52);
            this.bcos.Name = "bcos";
            this.bcos.Size = new System.Drawing.Size(75, 23);
            this.bcos.TabIndex = 3;
            this.bcos.Text = "COS";
            this.bcos.UseVisualStyleBackColor = false;
            this.bcos.Click += new System.EventHandler(this.bcos_Click);
            // 
            // bpow
            // 
            this.bpow.BackColor = System.Drawing.Color.Cornsilk;
            this.bpow.Location = new System.Drawing.Point(270, 81);
            this.bpow.Name = "bpow";
            this.bpow.Size = new System.Drawing.Size(75, 23);
            this.bpow.TabIndex = 4;
            this.bpow.Text = "POW";
            this.bpow.UseVisualStyleBackColor = false;
            this.bpow.Click += new System.EventHandler(this.bpow_Click_1);
            // 
            // b7
            // 
            this.b7.BackColor = System.Drawing.Color.Silver;
            this.b7.Location = new System.Drawing.Point(24, 110);
            this.b7.Name = "b7";
            this.b7.Size = new System.Drawing.Size(75, 23);
            this.b7.TabIndex = 5;
            this.b7.Text = "7";
            this.b7.UseVisualStyleBackColor = false;
            this.b7.Click += new System.EventHandler(this.b7_Click);
            // 
            // b8
            // 
            this.b8.BackColor = System.Drawing.Color.Silver;
            this.b8.Location = new System.Drawing.Point(106, 110);
            this.b8.Name = "b8";
            this.b8.Size = new System.Drawing.Size(75, 23);
            this.b8.TabIndex = 6;
            this.b8.Text = "8";
            this.b8.UseVisualStyleBackColor = false;
            this.b8.Click += new System.EventHandler(this.b8_Click);
            // 
            // b9
            // 
            this.b9.BackColor = System.Drawing.Color.Silver;
            this.b9.Location = new System.Drawing.Point(188, 110);
            this.b9.Name = "b9";
            this.b9.Size = new System.Drawing.Size(75, 23);
            this.b9.TabIndex = 7;
            this.b9.Text = "9";
            this.b9.UseVisualStyleBackColor = false;
            this.b9.Click += new System.EventHandler(this.b9_Click);
            // 
            // bdiv
            // 
            this.bdiv.BackColor = System.Drawing.Color.Orange;
            this.bdiv.Location = new System.Drawing.Point(270, 110);
            this.bdiv.Name = "bdiv";
            this.bdiv.Size = new System.Drawing.Size(75, 23);
            this.bdiv.TabIndex = 8;
            this.bdiv.Text = "/";
            this.bdiv.UseVisualStyleBackColor = false;
            this.bdiv.Click += new System.EventHandler(this.bdiv_Click);
            // 
            // b4
            // 
            this.b4.BackColor = System.Drawing.Color.Silver;
            this.b4.Location = new System.Drawing.Point(24, 140);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(75, 23);
            this.b4.TabIndex = 9;
            this.b4.Text = "4";
            this.b4.UseVisualStyleBackColor = false;
            this.b4.Click += new System.EventHandler(this.b4_Click);
            // 
            // b5
            // 
            this.b5.BackColor = System.Drawing.Color.Silver;
            this.b5.Location = new System.Drawing.Point(106, 140);
            this.b5.Name = "b5";
            this.b5.Size = new System.Drawing.Size(75, 23);
            this.b5.TabIndex = 10;
            this.b5.Text = "5";
            this.b5.UseVisualStyleBackColor = false;
            this.b5.Click += new System.EventHandler(this.b5_Click);
            // 
            // b6
            // 
            this.b6.BackColor = System.Drawing.Color.Silver;
            this.b6.Location = new System.Drawing.Point(188, 140);
            this.b6.Name = "b6";
            this.b6.Size = new System.Drawing.Size(75, 23);
            this.b6.TabIndex = 11;
            this.b6.Text = "6";
            this.b6.UseVisualStyleBackColor = false;
            this.b6.Click += new System.EventHandler(this.b6_Click);
            // 
            // bmul
            // 
            this.bmul.BackColor = System.Drawing.Color.Orange;
            this.bmul.Location = new System.Drawing.Point(270, 140);
            this.bmul.Name = "bmul";
            this.bmul.Size = new System.Drawing.Size(75, 23);
            this.bmul.TabIndex = 12;
            this.bmul.Text = "*";
            this.bmul.UseVisualStyleBackColor = false;
            this.bmul.Click += new System.EventHandler(this.bmul_Click);
            // 
            // b1
            // 
            this.b1.BackColor = System.Drawing.Color.Silver;
            this.b1.Location = new System.Drawing.Point(24, 170);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(75, 23);
            this.b1.TabIndex = 13;
            this.b1.Text = "1";
            this.b1.UseVisualStyleBackColor = false;
            this.b1.Click += new System.EventHandler(this.b1_Click);
            // 
            // b2
            // 
            this.b2.BackColor = System.Drawing.Color.Silver;
            this.b2.Location = new System.Drawing.Point(106, 170);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(75, 23);
            this.b2.TabIndex = 14;
            this.b2.Text = "2";
            this.b2.UseVisualStyleBackColor = false;
            this.b2.Click += new System.EventHandler(this.b2_Click);
            // 
            // b3
            // 
            this.b3.BackColor = System.Drawing.Color.Silver;
            this.b3.Location = new System.Drawing.Point(188, 170);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(75, 23);
            this.b3.TabIndex = 15;
            this.b3.Text = "3";
            this.b3.UseVisualStyleBackColor = false;
            this.b3.Click += new System.EventHandler(this.b3_Click);
            // 
            // bmin
            // 
            this.bmin.BackColor = System.Drawing.Color.Orange;
            this.bmin.Location = new System.Drawing.Point(270, 170);
            this.bmin.Name = "bmin";
            this.bmin.Size = new System.Drawing.Size(75, 23);
            this.bmin.TabIndex = 16;
            this.bmin.Text = "-";
            this.bmin.UseVisualStyleBackColor = false;
            this.bmin.Click += new System.EventHandler(this.bmin_Click);
            // 
            // bdot
            // 
            this.bdot.BackColor = System.Drawing.Color.Silver;
            this.bdot.Location = new System.Drawing.Point(24, 200);
            this.bdot.Name = "bdot";
            this.bdot.Size = new System.Drawing.Size(75, 23);
            this.bdot.TabIndex = 17;
            this.bdot.Text = ".";
            this.bdot.UseVisualStyleBackColor = false;
            this.bdot.Click += new System.EventHandler(this.bdot_Click);
            // 
            // b0
            // 
            this.b0.BackColor = System.Drawing.Color.Silver;
            this.b0.Location = new System.Drawing.Point(106, 200);
            this.b0.Name = "b0";
            this.b0.Size = new System.Drawing.Size(157, 23);
            this.b0.TabIndex = 18;
            this.b0.Text = "0";
            this.b0.UseVisualStyleBackColor = false;
            this.b0.Click += new System.EventHandler(this.b0_Click);
            // 
            // badd
            // 
            this.badd.BackColor = System.Drawing.Color.Orange;
            this.badd.Location = new System.Drawing.Point(270, 200);
            this.badd.Name = "badd";
            this.badd.Size = new System.Drawing.Size(75, 23);
            this.badd.TabIndex = 19;
            this.badd.Text = "+";
            this.badd.UseVisualStyleBackColor = false;
            this.badd.Click += new System.EventHandler(this.badd_Click);
            // 
            // beq
            // 
            this.beq.BackColor = System.Drawing.Color.Orange;
            this.beq.Location = new System.Drawing.Point(24, 230);
            this.beq.Name = "beq";
            this.beq.Size = new System.Drawing.Size(321, 23);
            this.beq.TabIndex = 20;
            this.beq.Text = "=";
            this.beq.UseVisualStyleBackColor = false;
            this.beq.Click += new System.EventHandler(this.beq_Click);
            // 
            // bmod
            // 
            this.bmod.BackColor = System.Drawing.Color.Cornsilk;
            this.bmod.Location = new System.Drawing.Point(188, 81);
            this.bmod.Name = "bmod";
            this.bmod.Size = new System.Drawing.Size(75, 23);
            this.bmod.TabIndex = 21;
            this.bmod.Text = "MOD(%)";
            this.bmod.UseVisualStyleBackColor = false;
            this.bmod.Click += new System.EventHandler(this.bmod_Click);
            // 
            // bsqrt
            // 
            this.bsqrt.BackColor = System.Drawing.Color.Cornsilk;
            this.bsqrt.Location = new System.Drawing.Point(24, 81);
            this.bsqrt.Name = "bsqrt";
            this.bsqrt.Size = new System.Drawing.Size(75, 23);
            this.bsqrt.TabIndex = 22;
            this.bsqrt.Text = "SQRT";
            this.bsqrt.UseVisualStyleBackColor = false;
            this.bsqrt.Click += new System.EventHandler(this.bsqrt_Click);
            // 
            // blog
            // 
            this.blog.BackColor = System.Drawing.Color.Cornsilk;
            this.blog.Location = new System.Drawing.Point(106, 81);
            this.blog.Name = "blog";
            this.blog.Size = new System.Drawing.Size(75, 23);
            this.blog.TabIndex = 23;
            this.blog.Text = "LOG";
            this.blog.UseVisualStyleBackColor = false;
            this.blog.Click += new System.EventHandler(this.blog_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(368, 271);
            this.Controls.Add(this.blog);
            this.Controls.Add(this.bsqrt);
            this.Controls.Add(this.bmod);
            this.Controls.Add(this.beq);
            this.Controls.Add(this.badd);
            this.Controls.Add(this.b0);
            this.Controls.Add(this.bdot);
            this.Controls.Add(this.bmin);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.bmul);
            this.Controls.Add(this.b6);
            this.Controls.Add(this.b5);
            this.Controls.Add(this.b4);
            this.Controls.Add(this.bdiv);
            this.Controls.Add(this.b9);
            this.Controls.Add(this.b8);
            this.Controls.Add(this.b7);
            this.Controls.Add(this.bpow);
            this.Controls.Add(this.bcos);
            this.Controls.Add(this.bsin);
            this.Controls.Add(this.bac);
            this.Controls.Add(this.display);
            this.Name = "Form1";
            this.Text = "GUI Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox display;
        private System.Windows.Forms.Button bac;
        private System.Windows.Forms.Button bsin;
        private System.Windows.Forms.Button bcos;
        private System.Windows.Forms.Button bpow;
        private System.Windows.Forms.Button b7;
        private System.Windows.Forms.Button b8;
        private System.Windows.Forms.Button b9;
        private System.Windows.Forms.Button bdiv;
        private System.Windows.Forms.Button b4;
        private System.Windows.Forms.Button b5;
        private System.Windows.Forms.Button b6;
        private System.Windows.Forms.Button bmul;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.Button bmin;
        private System.Windows.Forms.Button bdot;
        private System.Windows.Forms.Button b0;
        private System.Windows.Forms.Button badd;
        private System.Windows.Forms.Button beq;
        private System.Windows.Forms.Button bmod;
        private System.Windows.Forms.Button bsqrt;
        private System.Windows.Forms.Button blog;
    }
}

