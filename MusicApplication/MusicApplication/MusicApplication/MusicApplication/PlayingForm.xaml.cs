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
    /// Interaction logic for PlayingForm.xaml
    /// </summary>
    public partial class PlayingForm : Window
    {
        string songID;
        List<String> listData;
        MusicPlayer player;
        Timer timer;

        public string SongID { get => songID; set => songID = value; }

        public PlayingForm()
        {
            InitializeComponent();
            listData = new List<string>();
            for (int i = 0; i < 5; i++)
            {
                listData.Add(i.ToString());
            }
            lbSongs.ItemsSource = listData;
            player = new MusicPlayer(songID, slPlay);
            timer = new Timer();
            timer.Interval = 1000;
            timer.Elapsed += Timer_Tick;
            timer.Enabled = true;
            timer.AutoReset = true;
            lbLength.Content = "0:00";
            lbCurrent.Content = "0:00";
            
            //MessageBox.Show("Hello herer");
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
                        //MessageBox.Show(fraction + " " + slPlay.Value);
                        lbLength.Content = media.durationString;
                        lbCurrent.Content = player.PlayerClass.currentPositionString;
                    });
                }

            }
            else
            {
                MessageBox.Show("Here");
                this.Dispatcher.Invoke(() =>
                {
                    slPlay.Value = 0;
                    lbLength.Content = "0:00";
                    lbCurrent.Content = "0:00";
                });
            }
        }

        public PlayingForm(WindowsMediaPlayerClass playerClass, string SongID)
        {
            this.songID = SongID;
        }



        private void btnPlay_Click(object sender, RoutedEventArgs e)
        {
            btnPlay.Width = 0;
            btnPlay.Margin = new Thickness(0);
            btnStop.Width = 70;
            btnStop.Margin = new Thickness(15, 0, 15, 0);
            //MessageBox.Show("" + player.PlayerClass.playState);
            if (player.PlayerClass.playState != WMPPlayState.wmppsPaused)
            {
                //MessageBox.Show("Get in");
                songID = "S1";
                player.SongID = songID;
                player.Play();
            }
            else
            {
                player.PlayerClass.play();
            }
        }

        private void btnStop_Click(object sender, RoutedEventArgs e)
        {
            btnPlay.Width = 70;
            btnPlay.Margin = new Thickness(15, 0, 15, 0);
            btnStop.Width = 0;
            btnStop.Margin = new Thickness(0);
            player.PlayerClass.pause();
        }
    }
}
