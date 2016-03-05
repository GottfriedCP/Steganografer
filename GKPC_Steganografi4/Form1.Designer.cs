namespace GKPC_Steganografi4
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
            this.lblNama = new System.Windows.Forms.Label();
            this.picBox1 = new System.Windows.Forms.PictureBox();
            this.txtInOut = new System.Windows.Forms.TextBox();
            this.lblInOut = new System.Windows.Forms.Label();
            this.btnEnc = new System.Windows.Forms.Button();
            this.btnClr = new System.Windows.Forms.Button();
            this.Box1 = new System.Windows.Forms.GroupBox();
            this.lblVres = new System.Windows.Forms.Label();
            this.lblHres = new System.Windows.Forms.Label();
            this.lblHei = new System.Windows.Forms.Label();
            this.lblWid = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnEkprt = new System.Windows.Forms.Button();
            this.btnDec = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBox1)).BeginInit();
            this.Box1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNama
            // 
            this.lblNama.AutoSize = true;
            this.lblNama.Location = new System.Drawing.Point(12, 9);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new System.Drawing.Size(12, 16);
            this.lblNama.TabIndex = 0;
            this.lblNama.Text = "-";
            // 
            // picBox1
            // 
            this.picBox1.Location = new System.Drawing.Point(12, 28);
            this.picBox1.Name = "picBox1";
            this.picBox1.Size = new System.Drawing.Size(480, 320);
            this.picBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox1.TabIndex = 1;
            this.picBox1.TabStop = false;
            // 
            // txtInOut
            // 
            this.txtInOut.AllowDrop = true;
            this.txtInOut.Location = new System.Drawing.Point(12, 370);
            this.txtInOut.MaxLength = 20000;
            this.txtInOut.Multiline = true;
            this.txtInOut.Name = "txtInOut";
            this.txtInOut.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtInOut.Size = new System.Drawing.Size(480, 77);
            this.txtInOut.TabIndex = 1;
            // 
            // lblInOut
            // 
            this.lblInOut.AutoSize = true;
            this.lblInOut.Location = new System.Drawing.Point(12, 351);
            this.lblInOut.Name = "lblInOut";
            this.lblInOut.Size = new System.Drawing.Size(12, 16);
            this.lblInOut.TabIndex = 3;
            this.lblInOut.Text = "-";
            // 
            // btnEnc
            // 
            this.btnEnc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnc.Location = new System.Drawing.Point(498, 405);
            this.btnEnc.Name = "btnEnc";
            this.btnEnc.Size = new System.Drawing.Size(156, 42);
            this.btnEnc.TabIndex = 2;
            this.btnEnc.Text = "HIDE";
            this.btnEnc.UseVisualStyleBackColor = true;
            this.btnEnc.Click += new System.EventHandler(this.btnHide_Click);
            // 
            // btnClr
            // 
            this.btnClr.Location = new System.Drawing.Point(498, 370);
            this.btnClr.Name = "btnClr";
            this.btnClr.Size = new System.Drawing.Size(156, 23);
            this.btnClr.TabIndex = 4;
            this.btnClr.Text = "CLEAR";
            this.btnClr.UseVisualStyleBackColor = true;
            this.btnClr.Click += new System.EventHandler(this.btnClr_Click);
            // 
            // Box1
            // 
            this.Box1.Controls.Add(this.lblVres);
            this.Box1.Controls.Add(this.lblHres);
            this.Box1.Controls.Add(this.lblHei);
            this.Box1.Controls.Add(this.lblWid);
            this.Box1.Controls.Add(this.label4);
            this.Box1.Controls.Add(this.label3);
            this.Box1.Controls.Add(this.label2);
            this.Box1.Controls.Add(this.label1);
            this.Box1.Location = new System.Drawing.Point(498, 76);
            this.Box1.Name = "Box1";
            this.Box1.Size = new System.Drawing.Size(156, 159);
            this.Box1.TabIndex = 6;
            this.Box1.TabStop = false;
            this.Box1.Text = "DETAIL";
            // 
            // lblVres
            // 
            this.lblVres.AutoSize = true;
            this.lblVres.Location = new System.Drawing.Point(20, 127);
            this.lblVres.Name = "lblVres";
            this.lblVres.Size = new System.Drawing.Size(12, 16);
            this.lblVres.TabIndex = 7;
            this.lblVres.Text = "-";
            // 
            // lblHres
            // 
            this.lblHres.AutoSize = true;
            this.lblHres.Location = new System.Drawing.Point(20, 84);
            this.lblHres.Name = "lblHres";
            this.lblHres.Size = new System.Drawing.Size(12, 16);
            this.lblHres.TabIndex = 6;
            this.lblHres.Text = "-";
            // 
            // lblHei
            // 
            this.lblHei.AutoSize = true;
            this.lblHei.Location = new System.Drawing.Point(71, 43);
            this.lblHei.Name = "lblHei";
            this.lblHei.Size = new System.Drawing.Size(12, 16);
            this.lblHei.TabIndex = 5;
            this.lblHei.Text = "-";
            // 
            // lblWid
            // 
            this.lblWid.AutoSize = true;
            this.lblWid.Location = new System.Drawing.Point(71, 21);
            this.lblWid.Name = "lblWid";
            this.lblWid.Size = new System.Drawing.Size(12, 16);
            this.lblWid.TabIndex = 4;
            this.lblWid.Text = "-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 108);
            this.label4.Margin = new System.Windows.Forms.Padding(3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "VRES";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 65);
            this.label3.Margin = new System.Windows.Forms.Padding(3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "HRES";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 43);
            this.label2.Margin = new System.Windows.Forms.Padding(3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "HEIGHT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "WIDTH";
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(498, 28);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(156, 42);
            this.btnLoad.TabIndex = 0;
            this.btnLoad.Text = "MUAT GAMBAR";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnEkprt
            // 
            this.btnEkprt.Location = new System.Drawing.Point(498, 289);
            this.btnEkprt.Name = "btnEkprt";
            this.btnEkprt.Size = new System.Drawing.Size(156, 42);
            this.btnEkprt.TabIndex = 5;
            this.btnEkprt.Text = "EKSPOR KE .TXT";
            this.btnEkprt.UseVisualStyleBackColor = true;
            this.btnEkprt.Click += new System.EventHandler(this.btnEkprt_Click);
            // 
            // btnDec
            // 
            this.btnDec.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDec.Location = new System.Drawing.Point(498, 241);
            this.btnDec.Name = "btnDec";
            this.btnDec.Size = new System.Drawing.Size(156, 42);
            this.btnDec.TabIndex = 3;
            this.btnDec.Text = "EKSTRAK";
            this.btnDec.UseVisualStyleBackColor = true;
            this.btnDec.Click += new System.EventHandler(this.btnEkstrak_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 450);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "rev2 By AO, ARU, DD, GP";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 466);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnDec);
            this.Controls.Add(this.btnEkprt);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.Box1);
            this.Controls.Add(this.btnClr);
            this.Controls.Add(this.btnEnc);
            this.Controls.Add(this.lblInOut);
            this.Controls.Add(this.txtInOut);
            this.Controls.Add(this.picBox1);
            this.Controls.Add(this.lblNama);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "STEGANOGRAFER";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBox1)).EndInit();
            this.Box1.ResumeLayout(false);
            this.Box1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNama;
        private System.Windows.Forms.PictureBox picBox1;
        private System.Windows.Forms.TextBox txtInOut;
        private System.Windows.Forms.Label lblInOut;
        private System.Windows.Forms.Button btnEnc;
        private System.Windows.Forms.Button btnClr;
        private System.Windows.Forms.GroupBox Box1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblVres;
        private System.Windows.Forms.Label lblHres;
        private System.Windows.Forms.Label lblHei;
        private System.Windows.Forms.Label lblWid;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnEkprt;
        private System.Windows.Forms.Button btnDec;
        private System.Windows.Forms.Label label5;
    }
}

