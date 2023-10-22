using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimpleTCP;
using System.Threading;
using static System.Net.Mime.MediaTypeNames;

namespace PServer
{
	public partial class Form1 : Form
	{
		private TcpListener listener;
		private TcpClient client;
		private NetworkStream stream;
		private Thread listenThread;
		public Form1()
		{
			InitializeComponent();
		}
		private void buttonBaglan_Click(object sender, EventArgs e)
		{
			string ipAddress = txtServerIP.Text;
			int port = Convert.ToInt32(txtPort.Text);
			// TCP/IP soketi oluştur
			IPAddress serverIP = IPAddress.Parse(ipAddress);
			listener = new TcpListener(serverIP, port);
			// Sunucuyu başlat
			listener.Start();
			WriteLog("Sunucu başlatıldı. Bağlantı bekleniyor...");
			// İstemciden gelen bağlantıyı kabul etmek için dinleme işlemi başlat
			listenThread = new Thread(new ThreadStart(ListenForClient));
			listenThread.Start();
		}
		 private void ListenForClient()
        {
            try
            {
                // İstemciden gelen bağlantıyı kabul et
                client = listener.AcceptTcpClient();
                WriteLog("İstemci bağlandı.");
                // İstemciden gelen verileri okumak için bir ağ akışı oluştur
                stream = client.GetStream();
                // İstemciden gelen verileri işle
                while (true)
                {
                    byte[] buffer = new byte[1024];
                    int bytesRead = stream.Read(buffer, 0, buffer.Length);
                    string data = Encoding.ASCII.GetString(buffer, 0, bytesRead);
                    WriteLog("İstemciden gelen veri: " + data);
					if (data == "AC")
                    {
                        WriteLog("Fiş açılıyor...");
                    }
                    else if (data == "KAPAT")
                    {
                        WriteLog("Fiş kapatılıyor...");
                    }
                    else if (data == "CIKIS")
                    {
                        WriteLog("İstemci bağlantısı kapatılıyor...");
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                WriteLog("Hata: " + ex.Message);
            }
			finally
			{
				// Bağlantıyı temizle
				if (stream != null)
					stream.Close();
				if (client != null)
					client.Close();
				if (listener != null)
					listener.Stop();
			}
		}
		delegate void SetTextCallback(string message);
		private void WriteLog(string message)
		{
			if (this.rtbLog.InvokeRequired)
			{
				SetTextCallback d = new SetTextCallback(WriteLog);
				this.Invoke(d, new object[] { message });
			}
			else
			{
				// Log mesajını RichTextBox'e ekle
				this.rtbLog.Text = message;
			}			
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
