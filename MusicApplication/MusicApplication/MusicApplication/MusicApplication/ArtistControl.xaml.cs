﻿using System;
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
    /// Interaction logic for ArtistControl.xaml
    /// </summary>
    public partial class ArtistControl : UserControl
    {
        List<ServiceReference.ArtistInfo> items = new List<ServiceReference.ArtistInfo>();
        public ArtistControl()
        {
            InitializeComponent();
            ServiceReference.ITransfer service = new ServiceReference.TransferClient();
            items = service.LoadAllArtist().ToList();

            //items.Add(new Artist() { TextImage = @"Image/Singer/s1.jpg", ArtistName = "Noo Phước Thịnh" });
            //items.Add(new Artist() { TextImage = @"Image/Singer/s1.jpg", ArtistName = "Noo Phước Thịnh" });
            //items.Add(new Artist() { TextImage = @"Image/Singer/s1.jpg", ArtistName = "Noo Phước Thịnh" });
            //items.Add(new Artist() { TextImage = @"Image/Singer/s1.jpg", ArtistName = "Noo Phước Thịnh" });
            //items.Add(new Artist() { TextImage = @"Image/Singer/s1.jpg", ArtistName = "Noo Phước Thịnh" });
            //items.Add(new Artist() { TextImage = @"Image/Singer/s1.jpg", ArtistName = "Noo Phước Thịnh" });
            //items.Add(new Artist() { TextImage = @"Image/Singer/s1.jpg", ArtistName = "Noo Phước Thịnh" });
            //items.Add(new Artist() { TextImage = @"Image/Singer/s1.jpg", ArtistName = "Noo Phước Thịnh" });
            //items.Add(new Artist() { TextImage = @"Image/Singer/s1.jpg", ArtistName = "Noo Phước Thịnh" });
            //items.Add(new Artist() { TextImage = @"Image/Singer/s1.jpg", ArtistName = "Noo Phước Thịnh" });
            //items.Add(new Artist() { TextImage = @"Image/Singer/s1.jpg", ArtistName = "Noo Phước Thịnh" });
            //items.Add(new Artist() { TextImage = @"Image/Singer/s1.jpg", ArtistName = "Noo Phước Thịnh" });

            //items.Add(new Artist() { TextImage = @"Image/Singer/s1.jpg", ArtistName = "Noo Phước Thịnh" });
            //items.Add(new Artist() { TextImage = @"Image/Singer/s1.jpg", ArtistName = "Noo Phước Thịnh" });
            //items.Add(new Artist() { TextImage = @"Image/Singer/s1.jpg", ArtistName = "Noo Phước Thịnh" });
            //items.Add(new Artist() { TextImage = @"Image/Singer/s1.jpg", ArtistName = "Noo Phước Thịnh" });
            //items.Add(new Artist() { TextImage = @"Image/Singer/s1.jpg", ArtistName = "Noo Phước Thịnh" });

            //items.Add(new Artist() { TextImage = @"Image/Singer/s1.jpg", ArtistName = "Noo Phước Thịnh" });
            //items.Add(new Artist() { TextImage = @"Image/Singer/s1.jpg", ArtistName = "Noo Phước Thịnh" });
            //items.Add(new Artist() { TextImage = @"Image/Singer/s1.jpg", ArtistName = "Noo Phước Thịnh" });
            //items.Add(new Artist() { TextImage = @"Image/Singer/s1.jpg", ArtistName = "Noo Phước Thịnh" });
            //items.Add(new Artist() { TextImage = @"Image/Singer/s1.jpg", ArtistName = "Noo Phước Thịnh" });

            lvArtists.ItemsSource = items;
        }
    }
}
