using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace MusicAppService
{
    public class Tung_ArtistData
    {
        private string connectionString;
        private readonly string urlFirst = "/Image/Singer/";

        public List<ArtistInfo> LoadAllArtist()
        {
            List<ArtistInfo> artistList = new List<ArtistInfo>();
             connectionString = ConfigurationManager.AppSettings["connectionString"]; ;
            SqlConnection cnn = new SqlConnection(connectionString);
            String sql = "select ID, FullName, URLImage, Information from Singer";
            SqlCommand cmd = new SqlCommand(sql, cnn);

            try
            {
                if (cnn.State == ConnectionState.Closed)
                    cnn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    ArtistInfo artist;
                    while (reader.Read())
                    {
                        artist = new ArtistInfo();
                        artist.ID = (int)reader["ID"];
                        artist.FullName = reader["FullName"].ToString();
                        artist.URLImage = urlFirst + reader["URLImage"].ToString();
                        artist.Information = reader["Information"].ToString();
                        artistList.Add(artist);
                    }
                }
               
            }
            catch (SqlException se)
            {
                throw new Exception(se.Message);
            } finally
            {
                cnn.Close();
            }
            
            return artistList;
        }
    }
}