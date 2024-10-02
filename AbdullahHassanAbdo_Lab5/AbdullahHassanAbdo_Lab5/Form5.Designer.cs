namespace AbdullahHassanAbdo_Lab5
{
    partial class Form5
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCloseMinus = new System.Windows.Forms.Button();
            this.btnCalcMinus = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ResultMinus = new System.Windows.Forms.TextBox();
            this.txtMinus2 = new System.Windows.Forms.TextBox();
            this.txtMinus1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnMult = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnsumation = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.btnCloseMinus);
            this.panel1.Controls.Add(this.btnCalcMinus);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.ResultMinus);
            this.panel1.Controls.Add(this.txtMinus2);
            this.panel1.Controls.Add(this.txtMinus1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(23, 75);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(798, 252);
            this.panel1.TabIndex = 9;
            // 
            // btnCloseMinus
            // 
            this.btnCloseMinus.Location = new System.Drawing.Point(51, 167);
            this.btnCloseMinus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCloseMinus.Name = "btnCloseMinus";
            this.btnCloseMinus.Size = new System.Drawing.Size(185, 46);
            this.btnCloseMinus.TabIndex = 9;
            this.btnCloseMinus.Text = "اغلاق";
            this.btnCloseMinus.UseVisualStyleBackColor = true;
            this.btnCloseMinus.Click += new System.EventHandler(this.btnCloseMinus_Click);
            // 
            // btnCalcMinus
            // 
            this.btnCalcMinus.Location = new System.Drawing.Point(594, 167);
            this.btnCalcMinus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCalcMinus.Name = "btnCalcMinus";
            this.btnCalcMinus.Size = new System.Drawing.Size(185, 46);
            this.btnCalcMinus.TabIndex = 8;
            this.btnCalcMinus.Text = "حساب";
            this.btnCalcMinus.UseVisualStyleBackColor = true;
            this.btnCalcMinus.Click += new System.EventHandler(this.btnCalcMinus_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 34);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "الناتج";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(204, 95);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 31);
            this.label4.TabIndex = 6;
            this.label4.Text = "=";
            // 
            // ResultMinus
            // 
            this.ResultMinus.Location = new System.Drawing.Point(6, 95);
            this.ResultMinus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ResultMinus.Multiline = true;
            this.ResultMinus.Name = "ResultMinus";
            this.ResultMinus.ReadOnly = true;
            this.ResultMinus.Size = new System.Drawing.Size(170, 46);
            this.ResultMinus.TabIndex = 5;
            // 
            // txtMinus2
            // 
            this.txtMinus2.Location = new System.Drawing.Point(272, 95);
            this.txtMinus2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMinus2.Multiline = true;
            this.txtMinus2.Name = "txtMinus2";
            this.txtMinus2.Size = new System.Drawing.Size(219, 46);
            this.txtMinus2.TabIndex = 4;
            this.txtMinus2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMinus1_KeyPress);
            // 
            // txtMinus1
            // 
            this.txtMinus1.Location = new System.Drawing.Point(558, 95);
            this.txtMinus1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMinus1.Multiline = true;
            this.txtMinus1.Name = "txtMinus1";
            this.txtMinus1.Size = new System.Drawing.Size(221, 46);
            this.txtMinus1.TabIndex = 3;
            this.txtMinus1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMinus1_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(513, 95);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 31);
            this.label3.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(348, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "العدد الثاني";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(609, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "العدد الأول";
            // 
            // btnDivide
            // 
            this.btnDivide.BackColor = System.Drawing.Color.Silver;
            this.btnDivide.Location = new System.Drawing.Point(664, 22);
            this.btnDivide.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(157, 40);
            this.btnDivide.TabIndex = 8;
            this.btnDivide.Text = "قسمة";
            this.btnDivide.UseVisualStyleBackColor = false;
            this.btnDivide.Click += new System.EventHandler(this.btnDivide_Click);
            // 
            // btnMult
            // 
            this.btnMult.BackColor = System.Drawing.Color.Silver;
            this.btnMult.Location = new System.Drawing.Point(447, 22);
            this.btnMult.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnMult.Name = "btnMult";
            this.btnMult.Size = new System.Drawing.Size(163, 40);
            this.btnMult.TabIndex = 7;
            this.btnMult.Text = "ضرب";
            this.btnMult.UseVisualStyleBackColor = false;
            this.btnMult.Click += new System.EventHandler(this.btnMult_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.BackColor = System.Drawing.Color.Silver;
            this.btnMinus.Location = new System.Drawing.Point(233, 22);
            this.btnMinus.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(173, 40);
            this.btnMinus.TabIndex = 6;
            this.btnMinus.Text = "طرح";
            this.btnMinus.UseVisualStyleBackColor = false;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btnsumation
            // 
            this.btnsumation.BackColor = System.Drawing.Color.Silver;
            this.btnsumation.Location = new System.Drawing.Point(23, 22);
            this.btnsumation.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnsumation.Name = "btnsumation";
            this.btnsumation.Size = new System.Drawing.Size(157, 40);
            this.btnsumation.TabIndex = 5;
            this.btnsumation.Text = "جمع";
            this.btnsumation.UseVisualStyleBackColor = false;
            this.btnsumation.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(852, 353);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnMult);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnsumation);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCloseMinus;
        private System.Windows.Forms.Button btnCalcMinus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ResultMinus;
        private System.Windows.Forms.TextBox txtMinus2;
        private System.Windows.Forms.TextBox txtMinus1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnMult;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnsumation;
    }
}