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
<<<<<<< HEAD
            List<ArtistInfo> artistList = new List<ArtistInfo>();
             connectionString = ConfigurationManager.AppSettings["connectionString"]; ;
=======
            List<Tung_Artist> artistList = new List<Tung_Artist>();
            connectionString = ConfigurationManager.AppSettings["connectionString"]; ;
>>>>>>> cded52c5289dbd130ab583528eab28bacd25bd3b
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
            }
            finally
            {
                cnn.Close();
            }

            return artistList;
        }

        public int AddSinger(string name)
        {
            int ans = 0;
            connectionString = ConfigurationManager.AppSettings["connectionString"];
            SqlConnection cnn = new SqlConnection(connectionString);
            string sql = "INSERT INTO Singer(FullName) " +
                         "VALUES(@FullName)";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            cmd.Parameters.AddWithValue("@FullName", name);
            try
            {
                cnn.Open();
                ans = cmd.ExecuteNonQuery();
            }
            catch (SqlException se)
            {
                throw new Exception(se.Message);
            }
            finally
            {
                cnn.Close();
            }
            return FindSingerByName(name);
        }
        public int FindSingerByName(string name)
        {
            int ans = 0;
            connectionString = ConfigurationManager.AppSettings["connectionString"]; ;
            SqlConnection cnn = new SqlConnection(connectionString);
            String sql = "SELECT * FROM SINGER WHERE FULLNAME = @name";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            cmd.Parameters.AddWithValue("@name", name);
            SqlDataReader reader;
            try
            {
                if (cnn.State == ConnectionState.Closed)
                {
                    cnn.Open();
                }
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    int.TryParse(reader["ID"].ToString(), out ans);
                }
            }
            catch (SqlException se)
            {
                throw new Exception(se.Message);
            }
            finally
            {
                cnn.Close();
            }
            return ans;
        }

        public int AddSongWithSinger(int singerID, int songID)
        {
            int ans = 0;
            connectionString = ConfigurationManager.AppSettings["connectionString"];
            SqlConnection cnn = new SqlConnection(connectionString);
            string sql = "INSERT INTO SingersOfSong([SingerID], [SongID]) " +
                         "VALUES(@SingerID, @SongID)";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            cmd.Parameters.AddWithValue("@SingerID", singerID);
            cmd.Parameters.AddWithValue("@SongID", songID);
            try
            {
                cnn.Open();
                ans = cmd.ExecuteNonQuery();
            }
            catch (SqlException se)
            {
                throw new Exception(se.Message);
            }
            finally
            {
                cnn.Close();
            }
            return ans;
        }
    }
}