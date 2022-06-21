using System;
using System.Windows.Forms;
using System.Net.Sockets;

namespace Проверка_полтов
{
    public partial class TestPort1 : Form
    {
        public TestPort1(){InitializeComponent();}

        private void connect_Click(object sender, EventArgs r)
        {
            TcpClient tcpClient = new TcpClient();
            string ip = AdresTextBox.Text; string portS = PortTextBox.Text; int portR = int.Parse(PortTextBox.Text);

            if (ip == "" || portS == "")
            {
                MessageBox.Show("Введите ip и порт!", "Предупреждение!");
            }
            else
            {
                try 
                {
                    tcpClient.Connect(ip, portR);
                    MessageBox.Show("Порт "+portS+" открыт", "Порт открыт!");
                    tcpClient.Close();
                }
                catch (Exception e)
                {
                    MessageBox.Show("При подключении к порту "+portS+" произошла ошибка."+"\n"+"Порт недоступен!", "Возникли проблемы с подключением");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TcpClient tcpClientP = new TcpClient();
            string ip = ipp.Text; 
            string portS = portps.Text; int portRS = int.Parse(portps.Text);
            string portK = portpk.Text; int portRK = int.Parse(portpk.Text);

            if (ip == "" || portS == "")
            {
                MessageBox.Show("Введите ip и порт!", "Предупреждение!");
            }
            else
            {
                for (int i = portRS; i < (portRK+1); i++)
                {
                    try
                    {
                        tcpClientP.Connect(ip, i);
                        MessageBox.Show("Порт " + i + " открыт", "Порт открыт!");
                        tcpClientP.Close();
                    }
                    catch (Exception e1){ }
                }
            }
        }
    }
}