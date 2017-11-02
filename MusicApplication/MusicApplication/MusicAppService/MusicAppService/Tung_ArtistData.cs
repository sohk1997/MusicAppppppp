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
        public List<Tung_Artist> loadAllArtist()
        {
            List<Tung_Artist> artistList = new List<Tung_Artist>();
            connectionString = ConfigurationManager.AppSettings["connectionString"]; ;
            SqlConnection cnn = new SqlConnection(connectionString);
            String sql = "select ID, FullName, URLImage from Singer";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            SqlDataReader reader;
            try
            {
                if (cnn.State == ConnectionState.Closed)
                    cnn.Open();
                reader = cmd.ExecuteReader();
                Tung_Artist artist;
                while (reader.HasRows)
                {
                    artist = new Tung_Artist();
                    artist.ID = reader.GetInt32(1);
                    artist.FullName = reader.GetString(2);
                    artist.URLImage = reader.GetString(3);
                    artistList.Add(artist);
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