
namespace Calcuator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtresult = new System.Windows.Forms.TextBox();
            this.btncong = new System.Windows.Forms.Button();
            this.btntru = new System.Windows.Forms.Button();
            this.btnnhan = new System.Windows.Forms.Button();
            this.btnchia = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnresult = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btngiaithua = new System.Windows.Forms.Button();
            this.txtgtn = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtresultgt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtresult
            // 
            this.txtresult.Location = new System.Drawing.Point(33, 37);
            this.txtresult.Multiline = true;
            this.txtresult.Name = "txtresult";
            this.txtresult.Size = new System.Drawing.Size(397, 55);
            this.txtresult.TabIndex = 0;
            this.txtresult.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtresult_KeyPress);
            // 
            // btncong
            // 
            this.btncong.Location = new System.Drawing.Point(33, 98);
            this.btncong.Name = "btncong";
            this.btncong.Size = new System.Drawing.Size(75, 23);
            this.btncong.TabIndex = 1;
            this.btncong.Text = "+";
            this.btncong.UseVisualStyleBackColor = true;
            this.btncong.Click += new System.EventHandler(this.btncong_Click);
            // 
            // btntru
            // 
            this.btntru.Location = new System.Drawing.Point(137, 98);
            this.btntru.Name = "btntru";
            this.btntru.Size = new System.Drawing.Size(75, 23);
            this.btntru.TabIndex = 2;
            this.btntru.Text = "-";
            this.btntru.UseVisualStyleBackColor = true;
            this.btntru.Click += new System.EventHandler(this.btntru_Click);
            // 
            // btnnhan
            // 
            this.btnnhan.Location = new System.Drawing.Point(233, 98);
            this.btnnhan.Name = "btnnhan";
            this.btnnhan.Size = new System.Drawing.Size(75, 23);
            this.btnnhan.TabIndex = 3;
            this.btnnhan.Text = "x";
            this.btnnhan.UseVisualStyleBackColor = true;
            this.btnnhan.Click += new System.EventHandler(this.btnnhan_Click);
            // 
            // btnchia
            // 
            this.btnchia.Location = new System.Drawing.Point(337, 98);
            this.btnchia.Name = "btnchia";
            this.btnchia.Size = new System.Drawing.Size(75, 23);
            this.btnchia.TabIndex = 4;
            this.btnchia.Text = "/";
            this.btnchia.UseVisualStyleBackColor = true;
            this.btnchia.Click += new System.EventHandler(this.btnchia_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(438, 175);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(8, 8);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnresult
            // 
            this.btnresult.Location = new System.Drawing.Point(137, 141);
            this.btnresult.Name = "btnresult";
            this.btnresult.Size = new System.Drawing.Size(158, 76);
            this.btnresult.TabIndex = 6;
            this.btnresult.Text = "Enter";
            this.btnresult.UseVisualStyleBackColor = true;
            this.btnresult.Click += new System.EventHandler(this.btnresult_Click);
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(357, 168);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(75, 23);
            this.btnclear.TabIndex = 7;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btngiaithua
            // 
            this.btngiaithua.Location = new System.Drawing.Point(298, 310);
            this.btngiaithua.Name = "btngiaithua";
            this.btngiaithua.Size = new System.Drawing.Size(134, 45);
            this.btngiaithua.TabIndex = 8;
            this.btngiaithua.Text = "Giai Thừa";
            this.btngiaithua.UseVisualStyleBackColor = true;
            this.btngiaithua.Click += new System.EventHandler(this.btngiaithua_Click);
            // 
            // txtgtn
            // 
            this.txtgtn.Location = new System.Drawing.Point(152, 322);
            this.txtgtn.Multiline = true;
            this.txtgtn.Name = "txtgtn";
            this.txtgtn.Size = new System.Drawing.Size(125, 31);
            this.txtgtn.TabIndex = 9;
            this.txtgtn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtgtn_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 338);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nhập giai thừa n";
            // 
            // txtresultgt
            // 
            this.txtresultgt.Location = new System.Drawing.Point(35, 383);
            this.txtresultgt.Multiline = true;
            this.txtresultgt.Name = "txtresultgt";
            this.txtresultgt.Size = new System.Drawing.Size(397, 55);
            this.txtresultgt.TabIndex = 11;
            this.txtresultgt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtresultgt_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 450);
            this.Controls.Add(this.txtresultgt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtgtn);
            this.Controls.Add(this.btngiaithua);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnresult);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnchia);
            this.Controls.Add(this.btnnhan);
            this.Controls.Add(this.btntru);
            this.Controls.Add(this.btncong);
            this.Controls.Add(this.txtresult);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtresult;
        private System.Windows.Forms.Button btncong;
        private System.Windows.Forms.Button btntru;
        private System.Windows.Forms.Button btnnhan;
        private System.Windows.Forms.Button btnchia;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnresult;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btngiaithua;
        private System.Windows.Forms.TextBox txtgtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtresultgt;
    }
}

