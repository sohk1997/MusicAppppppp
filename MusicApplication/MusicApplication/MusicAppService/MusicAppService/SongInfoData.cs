using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Text;

namespace MusicAppService
{
    public class SongInfoData
    {

        private string connectionString;


        public SongInfo GetSongInformation(string id)
        {
            SongInfo ans = new SongInfo();
            connectionString = ConfigurationManager.AppSettings["connectionString"];
            SqlConnection cnn = new SqlConnection(connectionString);
            string query = "SELECT SONG.NAME AS @SongLabel,SINGER.NAME AS @SingerLabel" +
            " FROM((SONG INNER JOIN  SINGERSOFSONG ON SONG.ID = SINGERSOFSONG.SONGID) " +
            " INNER JOIN SINGER ON SINGERSOFSONG.SINGERID = SINGER.ID) " +
            " WHERE SONG.ID = @SongID";
            SqlCommand cmd = new SqlCommand(query, cnn);
            cmd.Parameters.AddWithValue("@SongLabel", "Song");
            cmd.Parameters.AddWithValue("@SingerLabel", "Singer");
            cmd.Parameters.AddWithValue("@SongID", id);
            try
            {
                cnn.Open();
                cmd.ExecuteReader();

            }
            catch
            {
                throw new Exception("Error");
            }
            finally
            {
                cnn.Close();
            }
            return ans;
        }

        public string GetURL(string ID)
        {
            string ans = "";
            connectionString = ConfigurationManager.AppSettings["connectionString"];
            SqlConnection cnn = new SqlConnection(connectionString);
            string query = "SELECT URL FROM Song WHERE ID = @ID";
            SqlCommand cmd = new SqlCommand(query, cnn);
            cmd.Parameters.AddWithValue("@ID", ID);
            try
            {
                cnn.Open();
                using (SqlDataReader dr = cmd.ExecuteReader())
                {

                    if (dr.Read())
                    {
                        ans = dr["URL"].ToString();
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
            return ans;
        }

        public List<SongInfo> GetAllSong()
        {
            List<SongInfo> ans = new List<SongInfo>();
            connectionString = ConfigurationManager.AppSettings["connectionString"];
            SqlConnection cnn = new SqlConnection(connectionString);
            string query = "SELECT TOP 100 Song.[ID],Song.[NAME], SONG.[URL],Song.Writter,SINGER.FULLNAME,[User].[Username],Song.Lyric,Song.CountingPlay,Song.CountingLike " +
                           "FROM((Song INNER JOIN SingersOfSong ON SONG.[ID] = SingersOfSong.SongID) " +
                           "INNER JOIN Singer ON Singer.[ID] = SingersOfSong.SingerID) " +
                           "INNER JOIN[User] ON Song.UploaderID = [User].[ID] " +
                           "ORDER BY Song.[ID] DESC";
            SqlCommand cmd = new SqlCommand(query, cnn);
            int a = 0;
            try
            {
                cnn.Open();
                SongInfo currentSong = new SongInfo();
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        string songid = dr[0 + a].ToString();
                        if (songid.Equals(currentSong.ID))
                        {
                            currentSong.Singer += (", " + dr[4 + a].ToString());
                        }
                        else
                        {
                            ans.Add(currentSong);
                            currentSong = new SongInfo();
                            currentSong.ID = dr[0 + a].ToString();
                            currentSong.Name = dr[1 + a].ToString();
                            currentSong.URL = dr[2 + a].ToString();
                            currentSong.Writter = dr[3 + a].ToString();
                            currentSong.Singer = dr[4 + a].ToString();
                            currentSong.Uploader = dr[5 + a].ToString();
                        }
                    }
                    ans.Add(currentSong);
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
            ans.RemoveAt(0);
            return ans;
        }

        public int InsertSong(SongInfo song)
        {
            int ans = 0;
            connectionString = ConfigurationManager.AppSettings["connectionString"];
            SqlConnection cnn = new SqlConnection(connectionString);
            string sql = "INSERT INTO Song([Name],UploaderID,Writter,[URL],[LastModified]) " +
                         "VALUES(@Name, @Upload, @Writter, @URL, @LastModified)";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            cmd.Parameters.AddWithValue("@Name", song.Name);
            cmd.Parameters.AddWithValue("@Upload", song.Uploader);
            cmd.Parameters.AddWithValue("@Writter", song.Writter);
            cmd.Parameters.AddWithValue("@URL", song.URL);
            cmd.Parameters.AddWithValue("@LastModified", DateTime.Now);
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
            return getNewestSong();
        }

        private int getNewestSong()
        {
            int ans = 0;
            connectionString = ConfigurationManager.AppSettings["connectionString"];
            SqlConnection cnn = new SqlConnection(connectionString);
            string query = "SELECT TOP 1 * "+
                           "From Song " +
                           "ORDER BY Song.[ID] DESC";
            SqlCommand cmd = new SqlCommand(query, cnn);

            try
            {
                cnn.Open();
                SongInfo currentSong = new SongInfo();
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        int.TryParse(dr[0].ToString(), out ans);
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

            return ans;
        }
        public List<SongInfo> FindSongLikeName(string name)
        {
            List<SongInfo> ans = new List<SongInfo>();
            connectionString = ConfigurationManager.AppSettings["connectionString"];
            SqlConnection cnn = new SqlConnection(connectionString);
            string query = "SELECT TOP 100 Song.[ID],Song.[NAME], SONG.[URL],Song.Writter,SINGER.FULLNAME,[User].[Username],Song.Lyric,Song.CountingPlay,Song.CountingLike " +
                           "FROM((Song INNER JOIN SingersOfSong ON SONG.[ID] = SingersOfSong.SongID) " +
                           "INNER JOIN Singer ON Singer.[ID] = SingersOfSong.SingerID) " +
                           "INNER JOIN[User] ON Song.UploaderID = [User].[ID] " +
                           "WHERE [Song].[NAME] like @Name " +
                           "ORDER BY Song.[ID] DESC";
            SqlCommand cmd = new SqlCommand(query, cnn);
            cmd.Parameters.AddWithValue("@Name","%"+name+"%");
            int a = 0;
            try
            {
                cnn.Open();
                SongInfo currentSong = new SongInfo();
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        string songid = dr[0 + a].ToString();
                        if (songid.Equals(currentSong.ID))
                        {
                            currentSong.Singer += (", " + dr[4 + a].ToString());
                        }
                        else
                        {
                            ans.Add(currentSong);
                            currentSong = new SongInfo();
                            currentSong.ID = dr[0 + a].ToString();
                            currentSong.Name = dr[1 + a].ToString();
                            currentSong.URL = dr[2 + a].ToString();
                            currentSong.Writter = dr[3 + a].ToString();
                            currentSong.Singer = dr[4 + a].ToString();
                            currentSong.Uploader = dr[5 + a].ToString();
                        }
                    }
                    ans.Add(currentSong);
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
            ans.RemoveAt(0);
            return ans;
        }
        public List<SongInfo> GetSongOfSinger(string singerName)
        {
            List<SongInfo> ans = new List<SongInfo>();
            connectionString = ConfigurationManager.AppSettings["connectionString"];
            SqlConnection cnn = new SqlConnection(connectionString);
            string query = "SELECT TOP 100 Song.[ID],Song.[NAME], SONG.[URL],Song.Writter,SINGER.FULLNAME,[User].[Username],Song.Lyric,Song.CountingPlay,Song.CountingLike " +
                           "FROM((Song INNER JOIN SingersOfSong ON SONG.[ID] = SingersOfSong.SongID) " +
                           "INNER JOIN Singer ON Singer.[ID] = SingersOfSong.SingerID) " +
                           "INNER JOIN[User] ON Song.UploaderID = [User].[ID] " +
                           "WHERE Singer.Fullname = @Fullname " +
                           "ORDER BY Song.[ID] DESC";
            SqlCommand cmd = new SqlCommand(query, cnn);
            cmd.Parameters.AddWithValue("@FullName", singerName);
            int a = 0;
            try
            {
                cnn.Open();
                SongInfo currentSong = new SongInfo();
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        string songid = dr[0 + a].ToString();
                        if (songid.Equals(currentSong.ID))
                        {
                            currentSong.Singer += (", " + dr[4 + a].ToString());
                        }
                        else
                        {
                            ans.Add(currentSong);
                            currentSong = new SongInfo();
                            currentSong.ID = dr[0 + a].ToString();
                            currentSong.Name = dr[1 + a].ToString();
                            currentSong.URL = dr[2 + a].ToString();
                            currentSong.Writter = dr[3 + a].ToString();
                            currentSong.Singer = dr[4 + a].ToString();
                            currentSong.Uploader = dr[5 + a].ToString();
                        }
                    }
                    ans.Add(currentSong);
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
            ans.RemoveAt(0);
            return ans;
        }
    }


}