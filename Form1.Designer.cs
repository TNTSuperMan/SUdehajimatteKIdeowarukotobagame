namespace SU_First_KI_last_word_game
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.xmozi = new System.Windows.Forms.Label();
            this.inp = new System.Windows.Forms.TextBox();
            this.btn = new System.Windows.Forms.Button();
            this.su = new System.Windows.Forms.Label();
            this.ki = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // xmozi
            // 
            this.xmozi.AutoSize = true;
            this.xmozi.Location = new System.Drawing.Point(12, 9);
            this.xmozi.Name = "xmozi";
            this.xmozi.Size = new System.Drawing.Size(0, 12);
            this.xmozi.TabIndex = 1;
            // 
            // inp
            // 
            this.inp.Location = new System.Drawing.Point(27, 24);
            this.inp.MaxLength = 1;
            this.inp.Name = "inp";
            this.inp.Size = new System.Drawing.Size(41, 19);
            this.inp.TabIndex = 2;
            this.inp.TextChanged += new System.EventHandler(this.inp_TextChanged);
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(88, 24);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(52, 19);
            this.btn.TabIndex = 3;
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // su
            // 
            this.su.AutoSize = true;
            this.su.Location = new System.Drawing.Point(12, 27);
            this.su.Name = "su";
            this.su.Size = new System.Drawing.Size(15, 12);
            this.su.TabIndex = 4;
            this.su.Text = "す";
            // 
            // ki
            // 
            this.ki.AutoSize = true;
            this.ki.Location = new System.Drawing.Point(68, 27);
            this.ki.Name = "ki";
            this.ki.Size = new System.Drawing.Size(14, 12);
            this.ki.TabIndex = 5;
            this.ki.Text = "き";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(144, 46);
            this.Controls.Add(this.ki);
            this.Controls.Add(this.su);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.inp);
            this.Controls.Add(this.xmozi);
            this.Name = "Form1";
            this.Text = "\"す\"で始まって\"き\"で終わる言葉ゲーム";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label xmozi;
        private System.Windows.Forms.TextBox inp;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Label su;
        private System.Windows.Forms.Label ki;
    }
}

