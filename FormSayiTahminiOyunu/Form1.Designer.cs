
namespace FormSayiTahminiOyunu
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
            this.btnbasla = new System.Windows.Forms.Button();
            this.btntahminet = new System.Windows.Forms.Button();
            this.txttahmin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblskor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnbasla
            // 
            this.btnbasla.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnbasla.Location = new System.Drawing.Point(231, 35);
            this.btnbasla.Name = "btnbasla";
            this.btnbasla.Size = new System.Drawing.Size(145, 49);
            this.btnbasla.TabIndex = 0;
            this.btnbasla.Text = "Başla";
            this.btnbasla.UseVisualStyleBackColor = true;
            this.btnbasla.Click += new System.EventHandler(this.btnbasla_Click);
            // 
            // btntahminet
            // 
            this.btntahminet.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btntahminet.Location = new System.Drawing.Point(231, 321);
            this.btntahminet.Name = "btntahminet";
            this.btntahminet.Size = new System.Drawing.Size(121, 40);
            this.btntahminet.TabIndex = 1;
            this.btntahminet.Text = "Tahmin Et";
            this.btntahminet.UseVisualStyleBackColor = true;
            this.btntahminet.Click += new System.EventHandler(this.btntahminet_Click);
            // 
            // txttahmin
            // 
            this.txttahmin.Location = new System.Drawing.Point(231, 272);
            this.txttahmin.Name = "txttahmin";
            this.txttahmin.Size = new System.Drawing.Size(121, 20);
            this.txttahmin.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(199, 233);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "TAHMİNİN NEDİR?";
            // 
            // lblskor
            // 
            this.lblskor.AutoSize = true;
            this.lblskor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblskor.Location = new System.Drawing.Point(272, 145);
            this.lblskor.Name = "lblskor";
            this.lblskor.Size = new System.Drawing.Size(0, 24);
            this.lblskor.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(653, 387);
            this.Controls.Add(this.lblskor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txttahmin);
            this.Controls.Add(this.btntahminet);
            this.Controls.Add(this.btnbasla);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnbasla;
        private System.Windows.Forms.Button btntahminet;
        private System.Windows.Forms.TextBox txttahmin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblskor;
    }
}

