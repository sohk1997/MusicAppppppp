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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MusicApplication
{
    /// <summary>
    /// Interaction logic for PersonalPlaylist.xaml
    /// </summary>
    public partial class PersonalPlaylist : UserControl
    {
        List<Playlist> items = new List<Playlist>();
        public PersonalPlaylist()
        {
            InitializeComponent();
            items.Add(new Playlist("hehe", "/Image/image1.png", "0 bài hát"));
            items.Add(new Playlist("haha", "/Image/image1.png", "4 bài hát"));
            items.Add(new Playlist("hoho", "/Image/image1.png", "12 bài hát"));
            items.Add(new Playlist("hihi", "/Image/image1.png", "12 bài hát"));
   
            lvPlaylists.ItemsSource = items;
        }
    }
}
