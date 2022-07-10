
namespace Ola_cabs
{
    partial class sms
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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.verify1 = new System.Windows.Forms.Button();
            this.send = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(171, 255);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(458, 20);
            this.textBox2.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(196, 89);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(369, 20);
            this.textBox1.TabIndex = 6;
            // 
            // verify1
            // 
            this.verify1.Location = new System.Drawing.Point(282, 314);
            this.verify1.Name = "verify1";
            this.verify1.Size = new System.Drawing.Size(224, 48);
            this.verify1.TabIndex = 5;
            this.verify1.Text = "verify";
            this.verify1.UseVisualStyleBackColor = true;
            this.verify1.Click += new System.EventHandler(this.verify1_Click);
            // 
            // send
            // 
            this.send.Location = new System.Drawing.Point(282, 159);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(224, 63);
            this.send.TabIndex = 4;
            this.send.Text = "send";
            this.send.UseVisualStyleBackColor = true;
            this.send.Click += new System.EventHandler(this.send_Click);
            // 
            // sms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.verify1);
            this.Controls.Add(this.send);
            this.Name = "sms";
            this.Text = "sms";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button verify1;
        private System.Windows.Forms.Button send;
    }
}