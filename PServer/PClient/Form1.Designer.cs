namespace PClient
{
	partial class Form1
	{
		/// <summary>
		///Gerekli tasarımcı değişkeni.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///Kullanılan tüm kaynakları temizleyin.
		/// </summary>
		///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer üretilen kod

		/// <summary>
		/// Tasarımcı desteği için gerekli metot - bu metodun 
		///içeriğini kod düzenleyici ile değiştirmeyin.
		/// </summary>
		private void InitializeComponent()
		{
			this.txtCommand = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.btnConnect = new System.Windows.Forms.Button();
			this.txtEspIP = new System.Windows.Forms.TextBox();
			this.txtPort = new System.Windows.Forms.TextBox();
			this.txtServerIP = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.btnSend = new System.Windows.Forms.Button();
			this.rtbLog = new System.Windows.Forms.TextBox();
			this.btnClear = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// txtCommand
			// 
			this.txtCommand.Location = new System.Drawing.Point(15, 182);
			this.txtCommand.Multiline = true;
			this.txtCommand.Name = "txtCommand";
			this.txtCommand.Size = new System.Drawing.Size(252, 50);
			this.txtCommand.TabIndex = 17;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 153);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(192, 16);
			this.label4.TabIndex = 16;
			this.label4.Text = "Komut girin (AC, KAPAT, CIKIS):";
			// 
			// btnConnect
			// 
			this.btnConnect.Location = new System.Drawing.Point(192, 107);
			this.btnConnect.Name = "btnConnect";
			this.btnConnect.Size = new System.Drawing.Size(75, 30);
			this.btnConnect.TabIndex = 15;
			this.btnConnect.Text = "Bağlan";
			this.btnConnect.UseVisualStyleBackColor = true;
			this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
			// 
			// txtEspIP
			// 
			this.txtEspIP.Location = new System.Drawing.Point(117, 46);
			this.txtEspIP.Name = "txtEspIP";
			this.txtEspIP.Size = new System.Drawing.Size(150, 22);
			this.txtEspIP.TabIndex = 14;
			// 
			// txtPort
			// 
			this.txtPort.Location = new System.Drawing.Point(117, 79);
			this.txtPort.Name = "txtPort";
			this.txtPort.Size = new System.Drawing.Size(150, 22);
			this.txtPort.TabIndex = 13;
			// 
			// txtServerIP
			// 
			this.txtServerIP.Location = new System.Drawing.Point(117, 18);
			this.txtServerIP.Name = "txtServerIP";
			this.txtServerIP.Size = new System.Drawing.Size(150, 22);
			this.txtServerIP.TabIndex = 12;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(64, 85);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(34, 16);
			this.label3.TabIndex = 11;
			this.label3.Text = "Port:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 53);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(86, 16);
			this.label2.TabIndex = 10;
			this.label2.Text = "EspServerIP:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(36, 21);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(62, 16);
			this.label1.TabIndex = 9;
			this.label1.Text = "ServerIP:";
			// 
			// btnSend
			// 
			this.btnSend.Location = new System.Drawing.Point(192, 238);
			this.btnSend.Name = "btnSend";
			this.btnSend.Size = new System.Drawing.Size(75, 30);
			this.btnSend.TabIndex = 18;
			this.btnSend.Text = "Gönder";
			this.btnSend.UseVisualStyleBackColor = true;
			this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
			// 
			// rtbLog
			// 
			this.rtbLog.Location = new System.Drawing.Point(15, 287);
			this.rtbLog.Multiline = true;
			this.rtbLog.Name = "rtbLog";
			this.rtbLog.Size = new System.Drawing.Size(252, 132);
			this.rtbLog.TabIndex = 19;
			// 
			// btnClear
			// 
			this.btnClear.Location = new System.Drawing.Point(192, 425);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(75, 30);
			this.btnClear.TabIndex = 20;
			this.btnClear.Text = "Temizle";
			this.btnClear.UseVisualStyleBackColor = true;
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(283, 485);
			this.Controls.Add(this.btnClear);
			this.Controls.Add(this.rtbLog);
			this.Controls.Add(this.btnSend);
			this.Controls.Add(this.txtCommand);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.btnConnect);
			this.Controls.Add(this.txtEspIP);
			this.Controls.Add(this.txtPort);
			this.Controls.Add(this.txtServerIP);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Client";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtCommand;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnConnect;
		private System.Windows.Forms.TextBox txtEspIP;
		private System.Windows.Forms.TextBox txtPort;
		private System.Windows.Forms.TextBox txtServerIP;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnSend;
		private System.Windows.Forms.TextBox rtbLog;
		private System.Windows.Forms.Button btnClear;
	}
}

