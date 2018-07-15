using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Diagnostics;

namespace PortStatus
{
    public class PortStatus
    {
        public int Port { get; set; }
        public string Ip { get; set; }
        public string Name { get; set; }
        public string Process { get; set; }
        public string Link { get; set; }
        public string Conf { get; set; }

        //Конструкторы
        public PortStatus()
        {
            this.Port = 0;
            this.Ip = "";
            this.Name = "";
            this.Process = "-";
            this.Link = "";
            this.Conf = "-";
        }

        public PortStatus(PortStatus inPort)
        {
            this.Port = inPort.Port;
            this.Ip = inPort.Ip;
            this.Name = inPort.Name;
            this.Process = inPort.Process;
            this.Link = inPort.Link;
            this.Conf = inPort.Conf;
        }

        public PortStatus(int port, string ip, string name, string process, string link, string conf)
        {
            this.Port = port;
            this.Ip = ip;
            this.Name = name;
            this.Process = process;
            this.Link = link;
            this.Conf = conf;
        }

        //Форматирование в строку
        public override string ToString()
        {
            return this.Link + "  "+this.Ip +":" + this.Port.ToString()+ "   " + this.Conf+    "\n"+
						this.Name + "\n" + "[" + this.Process + "]" ;
        }

        //Очистка класса	
        public void Clear()
        {
            this.Port = 0;
            this.Ip = "";
            this.Name = "";
            this.Process = "-";
            this.Link = "";
            this.Conf = "-";
        }
    }


    //Контейнер класса
    public class PortList
    {
        private List<PortStatus> portList = new List<PortStatus>();
        private char[] lat = {'1','2','3','4','5','6','7','8','9','0'
                             ,'a','b','c','d','e','f','g','h','j','k','l','m','n','v','p','o','i','u','y','t','s','r','q','w','x','z'
                             ,'A','B','C','D','E','F','G','H','J','K','L','M','N','V','P','O','I','U','Y','T','D','R','Q','W','X','Z'   };
		int rep = 0;

		//Свойство - список портов
		public List<PortStatus> GetPortList()
		{
			return portList;
		}

		#region Конструкторы
        public PortList()
        {
            this.portList = new List<PortStatus>();
        }

        public PortList(List<PortStatus> newlist)
        {
            this.portList = newlist;
        }

		public PortList(PortList newlist)
		{
			this.portList = newlist.portList;
		}
		
		//Конструктор с подгрузкой из файла
		public PortList(string path)
		{
			this.LoadSomeFile(path);
		}
		#endregion
		//подгрузка портов из командной строки
		public void GenList()
		{
			ProcessStartInfo psi = new ProcessStartInfo
			{
				FileName = "cmd.exe",
				Arguments = "/c netstat -ba",
				Verb = "runas",
				StandardOutputEncoding = Encoding.ASCII,
				RedirectStandardOutput = true,
				UseShellExecute = false,
				CreateNoWindow = true

			};
			try
			{
				Process p = Process.Start(psi);
				List<string> req = new List<string>();
				while (true)
				{
					string result = p.StandardOutput.ReadLine();
					if (result == null) break;
					req.Add(result);
				}
				foreach (string l in req)
					this.Pars(l);
			}
			catch (Exception ex) {  }
			
		}

		//создание файла
		public void GenFile()
		{
			ProcessStartInfo psi = new ProcessStartInfo
			{
				FileName = "scan.bat",
				UseShellExecute = false,
				CreateNoWindow = true
			};
			try
			{
				Process p = Process.Start(psi);
				this.LoadSomeFile("1.txt");
			}
			catch (Exception ex) { }

		}


		PortStatus port = new PortStatus();
		//парсинг строки формата netstat
		public PortStatus Pars(string line)
		{
			
			char[] ad = {'?'};
			if ((line.LastIndexOfAny(lat) != -1) || (line.LastIndexOfAny(ad) != -1))
			{
				line = line.TrimStart(' ');
				if (line.StartsWith("[") && rep == 2)
				{
					port.Process = line.Trim('[', ']');
					rep = 0;
					this.AddPort(port);
					port.Clear();
				}
				string sd = line.Split()[0];
				if (rep == 2 && (sd != "TCP" && sd != "UDP"))
				{
					if (port.Process == "-")
					{
						if (line.LastIndexOfAny(ad) == -1)
							port.Name = line;
						else rep = 0;
					}
					else
						rep++;
				}
				List<string> splline = line.Split().ToList();
				splline.RemoveAll("".Equals);
				foreach (string l in splline)
				{
					if (l == "LISTENING") port.Conf = "ОТКРЫТ";
					if (rep == 1)
					{
						rep++;
						string[] pl = l.Split(':');
						if (pl.Count() == 2) // 0.0.0.0
						{
							port.Ip = pl[0];
							port.Port = Convert.ToInt32(pl[1]);
						}
						else                 // [::]
						{
							port.Ip = pl[0] + ':' + pl[1] + ':' + pl[2];
							port.Port = Convert.ToInt32(pl[3]);
						}
					}
					if ((l == "TCP" || l == "UDP") && rep == 0) { port.Link = l; rep++; }
				}
			}
			
			return port;
		}

		//Загрузка файла
		public void LoadSomeFile(string path)
		{
			StreamReader reader = new StreamReader(path);
			PortStatus port = new PortStatus();
			rep = 0;
			while (!reader.EndOfStream)
			{
				string line = reader.ReadLine();
				this.Pars(line);
			}
		}

		//сохранение в файл
		public void SaveTheFile(string fileName)
		{
			StreamWriter writer = new StreamWriter(fileName);
			rep = 0;
			foreach (PortStatus port in this.DelIns().GetPortList())
			{
				writer.WriteLine(port.ToString());
			}
			writer.Close();
		}
		
		//Удаление повторов
		public PortList DelIns()
		{
			PortList newlist = new PortList();
			foreach (PortStatus port in this.GetPortList())
				if (!newlist.FindPort(port.Port).GetPortList().Any(x => x.Link == port.Link))
					newlist.AddPort(port);
			return newlist;
		}

        //Добавление в список
        public void AddPort(PortStatus newPort)
        {
            this.portList.Add(new PortStatus(newPort));
        }

        //Очистка контейнера
        public void ClearPortList()
        {
            this.portList.Clear();
        }
        
        //Поиск элементов по номеру порта
        public PortList FindPort(int port)
        {
            return new PortList(this.portList.FindAll(s => s.Port == port));
        }

        //Формирование списка строк
        public List<string> ListString()
        {
            List<string> list = new List<string>();
            foreach (PortStatus str in this.portList)
            {
                list.Add(str.ToString());
            }
            return list;
        }
		
    }
}
