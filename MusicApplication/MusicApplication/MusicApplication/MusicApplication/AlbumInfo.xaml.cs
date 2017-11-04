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
    /// Interaction logic for AlbumInfo.xaml
    /// </summary>
    public partial class AlbumInfo : UserControl
    {
        List<ListViewItem> lvItems = new List<ListViewItem>();
        public AlbumInfo()
        {
            InitializeComponent();
            ListViewItem item;
            Song s;
            for (int i = 0; i < 10; i++)
            {
                item = new ListViewItem();
                s = new Song("Ahihi", "Ahohohohohoh");
                item.ContentTemplate = (DataTemplate) this.FindResource("listViewSong");
                item.Content = s;
                lvItems.Add(item);
            }
            lvAlbumSong.ItemsSource = lvItems;
           
            

        }
    }
}
