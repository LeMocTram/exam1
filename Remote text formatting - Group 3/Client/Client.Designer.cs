namespace Client
{
    partial class Client
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.IPbox = new System.Windows.Forms.TextBox();
            this.Portbox = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SelectBut = new System.Windows.Forms.Button();
            this.SendBut = new System.Windows.Forms.Button();
            this.DownBut = new System.Windows.Forms.Button();
            this.ConnectBut = new System.Windows.Forms.Button();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ClearBut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 94);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Port:";
            // 
            // IPbox
            // 
            this.IPbox.Location = new System.Drawing.Point(80, 38);
            this.IPbox.Margin = new System.Windows.Forms.Padding(4);
            this.IPbox.Name = "IPbox";
            this.IPbox.Size = new System.Drawing.Size(161, 22);
            this.IPbox.TabIndex = 3;
            // 
            // Portbox
            // 
            this.Portbox.Location = new System.Drawing.Point(80, 96);
            this.Portbox.Margin = new System.Windows.Forms.Padding(4);
            this.Portbox.Name = "Portbox";
            this.Portbox.Size = new System.Drawing.Size(135, 22);
            this.Portbox.TabIndex = 4;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(421, 15);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(628, 244);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            // 
            // SelectBut
            // 
            this.SelectBut.Location = new System.Drawing.Point(313, 12);
            this.SelectBut.Margin = new System.Windows.Forms.Padding(4);
            this.SelectBut.Name = "SelectBut";
            this.SelectBut.Size = new System.Drawing.Size(100, 28);
            this.SelectBut.TabIndex = 6;
            this.SelectBut.Text = "Select";
            this.SelectBut.UseVisualStyleBackColor = true;
            this.SelectBut.Click += new System.EventHandler(this.SelectBut_Click);
            // 
            // SendBut
            // 
            this.SendBut.Location = new System.Drawing.Point(53, 210);
            this.SendBut.Margin = new System.Windows.Forms.Padding(4);
            this.SendBut.Name = "SendBut";
            this.SendBut.Size = new System.Drawing.Size(100, 28);
            this.SendBut.TabIndex = 7;
            this.SendBut.Text = "Send";
            this.SendBut.UseVisualStyleBackColor = true;
            this.SendBut.Click += new System.EventHandler(this.SendBut_Click);
            // 
            // DownBut
            // 
            this.DownBut.Location = new System.Drawing.Point(53, 286);
            this.DownBut.Margin = new System.Windows.Forms.Padding(4);
            this.DownBut.Name = "DownBut";
            this.DownBut.Size = new System.Drawing.Size(100, 28);
            this.DownBut.TabIndex = 8;
            this.DownBut.Text = "Save";
            this.DownBut.UseVisualStyleBackColor = true;
            this.DownBut.Click += new System.EventHandler(this.DownBut_Click);
            // 
            // ConnectBut
            // 
            this.ConnectBut.Location = new System.Drawing.Point(53, 145);
            this.ConnectBut.Margin = new System.Windows.Forms.Padding(4);
            this.ConnectBut.Name = "ConnectBut";
            this.ConnectBut.Size = new System.Drawing.Size(100, 28);
            this.ConnectBut.TabIndex = 9;
            this.ConnectBut.Text = "Connect";
            this.ConnectBut.UseVisualStyleBackColor = true;
            this.ConnectBut.Click += new System.EventHandler(this.ConnectBut_Click);
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(421, 267);
            this.richTextBox2.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(628, 271);
            this.richTextBox2.TabIndex = 11;
            this.richTextBox2.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(331, 267);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 24);
            this.label3.TabIndex = 12;
            this.label3.Text = "Receive";
            // 
            // ClearBut
            // 
            this.ClearBut.Location = new System.Drawing.Point(53, 366);
            this.ClearBut.Margin = new System.Windows.Forms.Padding(4);
            this.ClearBut.Name = "ClearBut";
            this.ClearBut.Size = new System.Drawing.Size(100, 28);
            this.ClearBut.TabIndex = 14;
            this.ClearBut.Text = "Clear";
            this.ClearBut.UseVisualStyleBackColor = true;
            this.ClearBut.Click += new System.EventHandler(this.ClearBut_Click);
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(1068, 553);
            this.Controls.Add(this.ClearBut);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.ConnectBut);
            this.Controls.Add(this.DownBut);
            this.Controls.Add(this.SendBut);
            this.Controls.Add(this.SelectBut);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.Portbox);
            this.Controls.Add(this.IPbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox IPbox;
        private System.Windows.Forms.TextBox Portbox;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button SelectBut;
        private System.Windows.Forms.Button SendBut;
        private System.Windows.Forms.Button DownBut;
        private System.Windows.Forms.Button ConnectBut;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ClearBut;
    }
}

