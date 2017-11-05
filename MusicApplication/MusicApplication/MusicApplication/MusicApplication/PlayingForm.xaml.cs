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
using MusicApplication.ServiceReference;
using WMPLib;

namespace MusicApplication
{
    /// <summary>
    /// Interaction logic for PlayingForm.xaml
    /// </summary>
    public partial class PlayingForm : Window
    {
        string songID;
        MusicPlayer player;
        Timer timer;
        List<ServiceReference.SongInfo> items;
        int selectedIndex;
        bool byTimer = false;
        double duration;
        string durationString;
        public string SongID { get => songID; set => songID = value; }
        public List<SongInfo> Items { get => items; set => items = value; }
        public Frame Parent1 { get => parent; set => parent = value; }
        public int SelectedIndex { get => selectedIndex; set => selectedIndex = value; }

        Frame parent;
        public PlayingForm()
        {
            InitializeComponent();
            player = new MusicPlayer(songID);
            timer = new Timer();
            timer.Interval = 1000;
            timer.Elapsed += Timer_Tick;
            timer.Enabled = true;
            timer.AutoReset = true;
            lbLength.Content = "00:00";
            lbCurrent.Content = "00:00";
            this.Closing += PlayingForm_Closing;
        }



        private void PlayerClass_PlayStateChange(int NewState)
        {
            if (player.PlayerClass.playState == WMPPlayState.wmppsMediaEnded)
            {
                selectedIndex = (selectedIndex + 1) % items.Count;
                ChangeSelectedIndex();
            }
            if (player.PlayerClass.playState == WMPPlayState.wmppsPlaying)
            {
                durationString = player.PlayerClass.currentMedia.durationString;
                duration = player.PlayerClass.currentMedia.duration;
            }
        }

        public void LoadData()
        {
            if(items == null)
            {
                return;
            }
            lbSongs.ItemsSource = Items;
            lbSinger.Content = items.ElementAt(SelectedIndex).Singer;
            lbSong.Content = items.ElementAt(SelectedIndex).Name;
        }
        public void SetRenderEvent()
        {
            parent.ContentRendered += Parent1_ContentRendered;
        }
        private void Parent1_ContentRendered(object sender, EventArgs e)
        {
            if (Parent1.Content == null || !Parent1.Content.Equals(this.Content))
            {
                player.Stop();
                this.Close();
            }
        }

        private void PlayingForm_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            player.Stop();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (player.PlayerClass != null)
            {
                if (player.PlayerClass.playState == WMPPlayState.wmppsPlaying)
                {
                    this.Dispatcher.Invoke(() =>
                    {
                        byTimer = true;
                        double fraction = player.PlayerClass.currentPosition;
                        fraction = fraction / duration;
                        if (duration > 0)
                        {
                            slPlay.Value = slPlay.Maximum * fraction;
                        }
                        lbCurrent.Content = player.PlayerClass.currentPositionString;
                        lbLength.Content = player.PlayerClass.currentMedia.durationString;
                    });

                }
            }
            else
            {
                this.Dispatcher.Invoke(() =>
                {
                    slPlay.Value = 0;
                    lbLength.Content = "0:00";
                    lbCurrent.Content = "0:00";
                });
            }
        }


        private void btnPlay_Click(object sender, RoutedEventArgs e)
        {
            btnPlay.Width = 0;
            btnPlay.Margin = new Thickness(0);
            btnStop.Width = 70;
            btnStop.Margin = new Thickness(15, 0, 15, 0);
            player.SongID = songID;
            if (player.PlayerClass.playState != WMPPlayState.wmppsPaused)
            {
                player.CreateNew();
                player.PlayerClass.PlayStateChange += PlayerClass_PlayStateChange;
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            player.PlayerClass.currentPosition = 0;
        }
        

        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            selectedIndex = (selectedIndex + 1) % items.Count;
            ChangeSelectedIndex();
        }

        private void lbSongs_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            selectedIndex = lbSongs.SelectedIndex;
            ChangeSelectedIndex();
        }
        private void ChangeSelectedIndex()
        {
            lbSinger.Content = items.ElementAt(SelectedIndex).Singer;
            lbSong.Content = items.ElementAt(SelectedIndex).Name;
            player.Stop();
            SongID = "S" + items.ElementAt(selectedIndex).ID;
            player.SongID = SongID;
            player.CreateNew();
            player.PlayerClass.PlayStateChange += PlayerClass_PlayStateChange;
            player.Play();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            selectedIndex = (items.Count + selectedIndex - 1) % items.Count;
            ChangeSelectedIndex();
        }

        private void slPlay_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (byTimer)
            {
                byTimer = false;
                return;
            }
            if (player.PlayerClass.URL.Length > 0)
            {
                double fraction = player.PlayerClass.currentPosition;
                fraction = fraction / duration;
                if (slPlay.Value != slPlay.Maximum * fraction)
                {
                    player.PlayerClass.currentPosition = slPlay.Value / slPlay.Maximum * duration;
                }
            }
            else
            {
                slPlay.Value = 0;
            }
        }

    }
}
