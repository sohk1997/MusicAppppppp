using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WMPLib;
namespace MusicApplication
{
    /// <summary>
    /// Interaction logic for Playing.xaml
    /// </summary>
    public partial class Playing : UserControl
    {
        string SongID;
        List<String> listData;
        MusicPlayer player;
        Timer timer;
        bool check = false;
        public Playing()
        {
            InitializeComponent();
            listData = new List<string>();
            for (int i = 0; i < 5; i++)
            {
                listData.Add(i.ToString());
            }
            lbSongs.ItemsSource = listData;
            player = new MusicPlayer(SongID, slPlay);
            timer = new Timer();
            timer.Interval = 1000;
            timer.Elapsed += Timer_Tick;
            timer.Enabled = true;
            timer.AutoReset = true;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            //MessageBox.Show("Hello");
            if (player.PlayerClass != null)
            {
                if (player.PlayerClass.playState == WMPPlayState.wmppsPlaying)
                {
                    this.Dispatcher.Invoke(() =>
                    {
                        double fraction = player.PlayerClass.currentPosition;
                        IWMPMedia media = player.PlayerClass.newMedia(player.PlayerClass.URL);
                        double b = media.duration;
                        fraction = fraction / b;
                        //MessageBox.Show("" + b);
                        slPlay.Value = slPlay.Maximum * fraction;
                        lbLength.Content = media.durationString;
                        lbNow.Content = player.PlayerClass.currentPositionString;
                        //MessageBox.Show(fraction + " " + slPlay.Value);
                    });
                }

            }
            else
            {
                //MessageBox.Show("Here");
                this.Dispatcher.Invoke(() =>
                {
                    slPlay.Value = 0;
                    lbNow.Content = "0:00";
                    lbLength.Content = "0:00";
                });
            }
        }

        public Playing(WindowsMediaPlayerClass playerClass, string SongID)
        {
            this.SongID = SongID;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SongID = "S0001";
            player.SongID = SongID;
            player.Play();
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
        }



    }
}
