using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiBanVeXemPhim
{
    internal class MovieData
    {
        //string conn = @"";
        string conn = @"Data Source=TUANANH-LOQ\SQLEXPRESS;Integrated Security=True;Connect Timeout=30";

        public int ID { get; set; } //0
        public string MovieID { get; set; } //1
        public string MovieName { get; set; } //2

        public string Genre { get; set; } //3
        public string Price { get; set; } //4
        public string Capacity { get; set; } //5
        public string Status { get; set; } //6
        public string Image { get; set; } //7
        public string Date { get; set; } //8

        public List<MovieData> movieListData()
        {
            List<MovieData> listData = new List<MovieData>();
            using (SqlConnection connect = new SqlConnection(conn))
            {
                connect.Open();
                string selectData = "SELECT * FROM movies WHERE delete_data IS NULL";

                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        MovieData movieData = new MovieData();

                        movieData.ID = Convert.ToInt32(reader["ID"]);
                        movieData.MovieID = reader["movie_id"].ToString();
                        movieData.MovieName = reader["movie_name"].ToString();
                        movieData.Genre = reader["genre"].ToString();
                        movieData.Price = reader["price"].ToString();
                        movieData.Capacity = reader["capacity"].ToString();
                        movieData.Status = reader["status"].ToString();
                        movieData.Image = reader["movie_image"].ToString();
                        movieData.Date = reader["create_at"].ToString();

                        listData.Add(movieData);
                    }
                }
            }
            return listData;
        }

        public List<MovieData> movieAvailableListData()
        {
            List<MovieData> listData = new List<MovieData>();
            using (SqlConnection connect = new SqlConnection(conn))
            {
                connect.Open();
                string selectData = "SELECT * FROM movies WHERE status = 'Available' AND delete_data IS NULL";

                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        MovieData movieData = new MovieData();

                        movieData.ID = Convert.ToInt32(reader["ID"]);
                        movieData.MovieID = reader["movie_id"].ToString();
                        movieData.MovieName = reader["movie_name"].ToString();
                        movieData.Genre = reader["genre"].ToString();
                        movieData.Price = reader["price"].ToString();
                        movieData.Capacity = reader["capacity"].ToString();
                        movieData.Status = reader["status"].ToString();
                        movieData.Image = reader["movie_image"].ToString();
                        movieData.Date = reader["create_at"].ToString();

                        listData.Add(movieData);
                    }
                }
            }
            return listData;
        }
    }
}
