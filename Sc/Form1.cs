using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Diagnostics;
using PortStatus;

namespace Sc
{
    public partial class Scanner : Form
	{

		#region var
		public static ManualResetEvent connectDone = new ManualResetEvent(false);
		IPAddress ip = Dns.GetHostByName(Dns.GetHostName()).AddressList[0];
		int TekIndex;
        bool OnlyOpenPorts = true;
		PortList portram = new PortList();
        
        public Scanner()
        {
            InitializeComponent();
            StartInitialize();
		}

        public void StartInitialize()
        {
			comboBoxBeetw.SelectedIndex = 0;
			txtBoxIP.Text = ip.ToString();
        }

		#endregion

		#region interface

		private void button1_Click(object sender, EventArgs e) //сканировать
		{
			btnScan.Enabled = false;
			lstPorts.Items.Clear();
			PortList portlist = new PortList();
			try
			{
				IPAddress ip2 = IPAddress.Parse(txtBoxIP.Text);

				if (chBoxTcp.Checked || chBoxUdp.Checked) 
			{
				switch (comboBoxBeetw.SelectedIndex)
				{
					case (0):
						{
							int index2 = (int)numList2.Value;
							int index1 = (int)numList1.Value;
							if (ip.ToString() == ip2.ToString()) //если текущая ЭВМ
							{

								portlist.GenFile();
								PortList portlistcopy = new PortList();
								for (int i = index1; i <= index2; i++)
									foreach (PortStatus.PortStatus port in portlist.FindPort(i).GetPortList())
										portlistcopy.AddPort(port);
								portlistcopy = portlistcopy.DelIns();
								foreach (PortStatus.PortStatus port in portlistcopy.GetPortList())
								{
									if (port.Link == "TCP" && chBoxTcp.Checked)				PortToWinList(port);
									if (port.Link == "UDP" && chBoxUdp.Checked)				PortToWinList(port);
								}
							}
							else								//если другая ЭВМ
							{
								for (int i = index1; i <= index2; i++) 
								{
									if (chBoxTcp.Checked)			CheckPort(i, "tcp", ip2);
									if (chBoxUdp.Checked)			Logic(i);
								}
							}
							
							break;
						}
					case (1):
						{
							int index1 = (int)numList1.Value;
							if (ip.ToString() == ip2.ToString())		//если текущая ЭВМ
							{
								portlist.GenFile();
								PortList portlistcopy = new PortList();
								foreach (PortStatus.PortStatus port in portlist.FindPort(index1).GetPortList())
										portlistcopy.AddPort(port);
								portlistcopy = portlistcopy.DelIns();
								foreach (PortStatus.PortStatus port in portlistcopy.GetPortList())
								{
										if (port.Link == "TCP" && chBoxTcp.Checked) PortToWinList(port);
										if (port.Link == "UDP" && chBoxUdp.Checked) PortToWinList(port);
								}
							}
							else										//если другая ЭВМ
							{
								if (chBoxTcp.Checked)		CheckPort(index1, "tcp", ip2);
								if (chBoxUdp.Checked)		Logic(index1);
							}
							break;
						}
					default: break;
				}

			}
			else
			{
				MessageBox.Show("Выберите порты для отображения.", "Ошибка");
			}
			portram = portlist;
			btnScan.Enabled = true;
			Cursor.Current = Cursors.Arrow;
			}
			catch (FormatException ex) { MessageBox.Show(ex.Message, "Ошибка"); }
		}


		private void buttonClear_Click(object sender, EventArgs e)
		{
			portram.ClearPortList();
			lstPorts.Items.Clear();
		}
		
		int selDropBoxIndex = 0; 
		private void comboBoxBeetw_SelectedIndexChanged(object sender, EventArgs e)
		{
			switch (comboBoxBeetw.SelectedIndex)
			{
				case (0):
					{
						lblMin.Text = "Диапазон:";
						numList2.Show();
						label1.Show();
						selDropBoxIndex = 0; 
						break;
					}
				case (1):
					{
						lblMin.Text = "Поиск порта:";
						numList2.Hide();
						label1.Hide();
						selDropBoxIndex = 1; 
						break;
					}
				default: break;
			}
		}


		private void comboBoxBeetw_TextUpdate(object sender, EventArgs e)
		{
			comboBoxBeetw.SelectedIndex = selDropBoxIndex;
		}
		#endregion

		#region menu Strip

		private void выходToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void сохранитьТаблицуToolStripMenuItem_Click(object sender, EventArgs e)
		{
			saveFileDialog1 = new SaveFileDialog();
			saveFileDialog1.InitialDirectory = @"c:\MyFolder\Default\";
			saveFileDialog1.Filter = "Text Files (*.txt)|*.txt|"
			+ "Comma-Delimited Files (*.csv)|*.csv|All Files (*.*)|*.*";
			DialogResult result = saveFileDialog1.ShowDialog();
			if (result == DialogResult.OK)
			{
				portram.SaveTheFile(saveFileDialog1.FileName);
			}
		}

		private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
		{

			openFileDialog1 = new OpenFileDialog();
			openFileDialog1.InitialDirectory = @"c:\MyFolder\Default\";
			openFileDialog1.Filter = "Text Files (*.txt)|*.txt|"
			+ "Comma-Delimited Files (*.csv)|*.csv|All Files (*.*)|*.*";
			openFileDialog1.CheckFileExists = true;
			openFileDialog1.CheckPathExists = false;
			DialogResult result = openFileDialog1.ShowDialog();
			if (result == DialogResult.OK)
			{
				lstPorts.Items.Clear();
				portram.LoadSomeFile(openFileDialog1.FileName);
				foreach (PortStatus.PortStatus port in portram.GetPortList())
					PortToWinList(port);
			}
		}

		#endregion
		
		#region subSystems
		private static void ConnectCallback(IAsyncResult ar)
		{
			try
			{
				Socket SockClient = (Socket)ar.AsyncState;
				SockClient.EndConnect(ar);
				connectDone.Set();
			}
			catch (Exception ex)
			{
			}
		}

		public void Logic(int index) //проверка порта (udp)
		{
			var isPortBusy = System.Net.NetworkInformation.IPGlobalProperties.GetIPGlobalProperties()
		   .GetActiveUdpListeners().Any(l => l.Port == index);

			if (isPortBusy)
			{
				TekIndex = lstPorts.Items.Add(index.ToString()).Index;
				lstPorts.Items[TekIndex].SubItems.Add("UDP");
				lstPorts.Items[TekIndex].SubItems.Add("ОТКРЫТ");
				lstPorts.Items[TekIndex].BackColor = Color.LightGreen;
			}
			else
			{
				if (!OnlyOpenPorts)
				{
					TekIndex = lstPorts.Items.Add(index.ToString()).Index;
					lstPorts.Items[TekIndex].SubItems.Add("UDP");
					lstPorts.Items[TekIndex].SubItems.Add("ЗАКРЫТ");
					lstPorts.Items[TekIndex].BackColor = Color.Bisque;
				}
			}
		}

		//-----------------------------------//



		public void CheckPort(int port, string _type, IPAddress IpAddr) //проверка порта по скету (tcp)
		{
			try
			{
				Socket MySoc;
				IPEndPoint IpEndP = new IPEndPoint(IpAddr, port);
				if (_type == "tcp")
				{
					MySoc = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
				}
				else
				{
					MySoc = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Udp);
				}
				IAsyncResult asyncResult = MySoc.BeginConnect(IpEndP, new AsyncCallback(ConnectCallback), MySoc);

				if (!asyncResult.AsyncWaitHandle.WaitOne(30, false))
				{
					MySoc.Close();
					if (!OnlyOpenPorts)
					{
						TekIndex = lstPorts.Items.Add(port.ToString()).Index;
						if (_type == "tcp")
							lstPorts.Items[TekIndex].SubItems.Add("TCP");
						else
							lstPorts.Items[TekIndex].SubItems.Add("UDP");
						lstPorts.Items[TekIndex].SubItems.Add("ЗАКРЫТ");
						lstPorts.Items[TekIndex].BackColor = Color.Bisque;
					}
				}
				else
				{
					MySoc.Close();
					TekIndex = lstPorts.Items.Add(port.ToString()).Index;
					if (_type == "tcp")
						lstPorts.Items[TekIndex].SubItems.Add("TCP");
					else
						lstPorts.Items[TekIndex].SubItems.Add("UDP");
					lstPorts.Items[TekIndex].SubItems.Add("ОТКРЫТ");
					lstPorts.Items[TekIndex].BackColor = Color.LightGreen;
				}
			}
			catch (SocketException ex)
			{
				MessageBox.Show(ex.ErrorCode + ex.Message);
			}
		}

		private void PortToWinList(PortStatus.PortStatus port) //заполнение строки в таблице
		{
			TekIndex = lstPorts.Items.Add(port.Port.ToString()).Index;
			lstPorts.Items[TekIndex].SubItems.Add(port.Link);
			lstPorts.Items[TekIndex].SubItems.Add(port.Conf);
			if (port.Name == "Can not obtain ownership information") lstPorts.Items[TekIndex].SubItems.Add("Нет данных");
			else													 lstPorts.Items[TekIndex].SubItems.Add(port.Name + " [" + port.Process + "]");
			lstPorts.Items[TekIndex].BackColor = Color.LightGreen;
		}

		#endregion
	}
}
