﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Chat
{
    /// <summary>
    /// ChatOne.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class ChatMain : Window
    {
        public ChatMain()
        {
            InitializeComponent();
        }

        private void Btn_chat1_Click(object sender, RoutedEventArgs e)
        {
            ChatPerson cp = new ChatPerson();
            Close();
            cp.Show();
            TcpClient client = new TcpClient("10.10.21.117", 5000);
        }
    }
}
