using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace MusicAppService
{
    public class PlaylistControl
    {
        private string connectionString;
        public int AddNewPlaylist(Playlist playlist)
        {
            int ans = 0;
            string sql = "INSERT INTO PlayList([Name],[UserID],LastModified) " +
            "VALUES(@Name,@User,@ModifedDate)";
            connectionString = ConfigurationManager.AppSettings["connectionString"];
            SqlConnection cnn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sql, cnn);
            cmd.Parameters.AddWithValue("@Name", playlist.Name);
            cmd.Parameters.AddWithValue("@User", playlist.Creator);
            cmd.Parameters.AddWithValue("@ModifedDate", DateTime.Now);
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

        public List<Playlist> GetPlaylistOfUser(string userID)
        {
            connectionString = ConfigurationManager.AppSettings["connectionString"];
            List<Playlist> playlists = new List<Playlist>();
            SqlConnection cnn = new SqlConnection(connectionString);
            string sql = "SELECT [ID],[Name] " +
                    "FROM PlayList " +
                    "WHERE UserID = @UserID";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            cmd.Parameters.AddWithValue("@UserID", userID);
            try
            {
                cnn.Open();
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Playlist playlist = new Playlist()
                        {
                            ID = dr["ID"].ToString(),
                            Name = dr["Name"].ToString()
                        };
                        playlists.Add(playlist);
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
            return playlists;
        }

        public int AddSongToPlaylist(string songID, string playlistID)
        {
            string sql = "INSERT INTO SongsInPlayList(SongID, PlaylistID) " +
                         "VALUES(@SongID, @PlaylistID)";
            int ans = 0;
            connectionString = ConfigurationManager.AppSettings["connectionString"];
            SqlConnection cnn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sql, cnn);
            cmd.Parameters.AddWithValue("@SongID", songID);
            cmd.Parameters.AddWithValue("PlaylistID", playlistID);
            try
            {
                cnn.Open();
                ans = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                cnn.Close();
            }
            return ans;
        }
    }
}