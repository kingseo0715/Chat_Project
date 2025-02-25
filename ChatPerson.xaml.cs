using System;
using System.Collections.Generic;
using System.Linq;
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
    /// ChatPerson.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class ChatPerson : Window
    {
        string message="";
        public ChatPerson()
        {
            InitializeComponent();
        }

        //친구초대, 파일전송 버튼
        private void Btn_func_Click(object sender, RoutedEventArgs e)
        {
            Func cf = new Func();
            Close();
            cf.Show();
        }




        private void Send_btn_Click(object sender, RoutedEventArgs e)
        {
            message = Send_Text_Box.Text;

            Task.Run(Send_txtBox);

            if (VisualTreeHelper.GetChildrenCount(messageListView) > 0)
            {
                Border border = (Border)VisualTreeHelper.GetChild(messageListView, 0);
                ScrollViewer scrollViewer = (ScrollViewer)VisualTreeHelper.GetChild(border, 0);
                scrollViewer.ScrollToBottom();
            }

        }
       
        void Send_txtBox()
        {

            Task.Delay(200).Wait();
            this.Dispatcher.Invoke(()=>
            {
                messageListView.Items.Add("나 : " + message);
                Send_Text_Box.Clear();
            });

        }
        
       
        

    }
}
