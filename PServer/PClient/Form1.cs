using SimpleTCP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;

namespace PClient
{
	public partial class Form1 : Form
	{
		private TcpClient client1;
		private TcpClient client2;
		public Form1()
		{
			InitializeComponent();
		}
		private void btnConnect_Click(object sender, EventArgs e)
		{
			string serverIP1 = txtServerIP.Text;
			string serverIP2 = txtEspIP.Text;
			int port = Convert.ToInt32(txtPort.Text);

			// İlk sunucuya bağlan
			ConnectToServer(serverIP2, port, "Esp");
			// İkinci sunucuya bağlan
			ConnectToServer(serverIP1, port, "C#");
		}
		private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			// Uygulama kapatılırken bağlantıları kapat
			DisconnectFromServer(client1);
			DisconnectFromServer(client2);
		}
		private void ConnectToServer(string serverIP, int port, string serverName)
		{
			try
			{
				// TCP bağlantısını kur
				TcpClient client = new TcpClient();
				client.Connect(serverIP, port);
				if (serverName == "Esp")
				{
					// İlk sunucu için bağlantıyı sakla
					client1 = client;
					WriteLog("Esp server'a bağlanıldı.");
				}
				else if (serverName == "C#")
				{
					// İkinci sunucu için bağlantıyı sakla
					client2 = client;
					WriteLog("C# server'a bağlanıldı.");
				}
			}
			catch (Exception ex)
			{
				WriteLog("Bağlantı hatası: " + ex.Message);
			}
		}
		private void DisconnectFromServer(TcpClient client)
		{
			if (client != null && client.Connected)
			{
				// Bağlantıyı kapat
				client.Close();
			}
		}		
		private void btnSend_Click(object sender, EventArgs e)
		{
			if (client1 != null && client1.Connected)
			{
				// İlk sunucuya komut gönder
				string command = txtCommand.Text;
				SendCommand(client1, command);
			}
			else
			{
				WriteLog("Esp server bağlı değil.");
			}
			if (client2 != null && client2.Connected)
			{
				// İkinci sunucuya komut gönder
				string command = txtCommand.Text;
				SendCommand(client2, command);
			}
			else
			{
				WriteLog("C# server bağlı değil.");
			}
		}
		private void SendCommand(TcpClient client, string command)
		{
			try
			{
				// Komutu sunucuya göndermek için
				NetworkStream stream = client.GetStream();
				byte[] data = Encoding.ASCII.GetBytes(command);
				stream.Write(data, 0, data.Length);
				WriteLog("Komut gönderildi: " + command);
			}
			catch (Exception ex)
			{
				WriteLog("Komut gönderme hatası: " + ex.Message);
			}
		}
		private void WriteLog(string message)
		{
			// RichTextBox'e log mesajını ekle
			rtbLog.AppendText(message + Environment.NewLine);
		}
		private void btnClear_Click(object sender, EventArgs e)
		{
			rtbLog.Clear();
		}
		private void Form1_Load(object sender, EventArgs e)
		{
			
		}
	}
}
