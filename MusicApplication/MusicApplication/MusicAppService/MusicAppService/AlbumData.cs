using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace MusicAppService
{

    public class AlbumData
    {
        String connectionString;
        private readonly string urlFirst = ConfigurationManager.AppSettings["imageURLAlbum"];

        public List<AlbumInfo> Get10Album()
        {
            List<AlbumInfo> albumList = new List<AlbumInfo>();
            connectionString = ConfigurationManager.AppSettings["connectionString"];
            SqlConnection cnn = new SqlConnection(connectionString);
            string query = "SELECT top 10 a.ID, a.Name, a.URLImage, s.FullName " +
            "from Album a, SingersOfAlbum soa, Singer s " +
            "where a.ID = soa.AlbumID and soa.SingerID = s.ID";
            SqlCommand cmd = new SqlCommand(query, cnn);
            try
            {
                cnn.Open();
                AlbumInfo album = new AlbumInfo();
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        album = new AlbumInfo();
                        album.ID = dr[0].ToString();
                        album.Name = dr[1].ToString();
                        album.URLImage = urlFirst + dr[2].ToString();
                        album.Singer = dr[3].ToString();
                        albumList.Add(album);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                cnn.Close();
            }
            return albumList;
        }
    }
}