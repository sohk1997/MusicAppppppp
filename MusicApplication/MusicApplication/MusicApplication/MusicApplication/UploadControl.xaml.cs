using System;
using System.Collections.Generic;
using System.IO;
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
    /// Interaction logic for UploadControl.xaml
    /// </summary>
    public partial class UploadControl : UserControl
    {
        int userID;
        List<Song> items = new List<Song>();
 
        public UploadControl()
        {
            InitializeComponent();
            items.Add(new Song("Ahihi", "Ahuhu"));
            items.Add(new Song("Ahihi", "Ahuhu"));
            items.Add(new Song("Ahihi", "Ahuhu"));
            items.Add(new Song("Ahihi", "Ahuhu"));
            items.Add(new Song("Ahihi", "Ahuhu"));
            items.Add(new Song("Ahihi", "Ahuhu"));
            items.Add(new Song("Ahihi", "Ahuhu"));
            items.Add(new Song("Ahihi", "Ahuhu"));
            lvUpSongs.ItemsSource = items;
        }

        public int UserID { get => userID; set => userID = value; }

        private void btnChooseFile_Click(object sender, RoutedEventArgs e)
        {
            var fileDialog = new System.Windows.Forms.OpenFileDialog();
            var result = fileDialog.ShowDialog();
            if (!System.IO.Path.GetExtension(fileDialog.FileName).Equals(".mp3"))
            {
                MessageBox.Show("Please choose a .mp3 type file");
                return;
            }
            txtURL.Text = fileDialog.FileName;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            userID = 1;
            if(txtSinger.Text.Length == 0)
            {
                MessageBox.Show("Please enter at least one name for the singer");
                return;
            }
            if(txtURL.Text.Length == 0)
            {
                MessageBox.Show("Please choose a file of the song");
                return;
            }
            if (txtName.Text.Length == 0)
            {
                MessageBox.Show("Please choose a name of the song");
                return;
            }
            if(txtWriter.Text.Length == 0)
            {
                MessageBox.Show("Please enter writter of song");
                return;
            }
            
            ServiceReference.SongInfo song = new ServiceReference.SongInfo();
            song.Name = txtName.Text;
            song.Writter = txtWriter.Text;
            song.Singer = txtSinger.Text;
            song.Uploader = "" + userID;
            ServiceReference.ITransfer transfer = new ServiceReference.TransferClient();
            int id = transfer.InsertSongInfo(song);
            UploadSong uploader = new UploadSong();
            uploader.UploadFile(" " + id, txtURL.Text);

            txtName.Clear();
            txtSinger.Clear();
            txtURL.Clear();
            txtWriter.Clear();
            txtLyric.Clear();

            MessageBox.Show("Ban da tai bai hat len thanh cong");
        }
    }
}
