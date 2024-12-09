using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace QuanLiBanVeXemPhim
{
    public partial class frmBuyTicket : UserControl
    {
        //string conn = @""; // xem lai doan dau :(((
        string conn = @"Data Source=TUANANH-LOQ\SQLEXPRESS;Integrated Security=True;Connect Timeout=30";

        public frmBuyTicket()
        {
            InitializeComponent();
            displayAvailableMovies();

            displayAvailableSeats();
        }
        public void displayAvailableMovies()
        {
            MovieData movieData = new MovieData();
            List<MovieData> listData = movieData.movieAvailableListData();

            dgvAvailableMovies.DataSource = listData;
        }
        private int id = 0;
        private void dgvAvailableMovies_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dgvAvailableMovies.Rows[e.RowIndex];

                id = (int)row.Cells[0].Value;
                lbMovieID_BuyTicket.Text = row.Cells[1].Value.ToString();
                lbMovieName_BuyTicket.Text = row.Cells[2].Value.ToString();
                lbMovieGenre_BuyTicket.Text = row.Cells[3].Value.ToString();
                lbRegularPrice_BuyTicket.Text = row.Cells[4].Value.ToString();

                pbAvailableMovies.ImageLocation = row.Cells[7].Value.ToString();
            }
        }

        string movie_id;
        private void btnSelectMovie_BuyTicket_Click(object sender, EventArgs e)
        {
            movie_id = lbMovieID_BuyTicket.Text.Trim();
        }
        public void displayAvailableSeats()
        {
            string conn = @""; // COPY DUONG LINK SQL
            using (SqlConnection connection = new SqlConnection(conn))
            {
                connection.Open();

                string selectAvailableSeat = "SELECT capacity FROM movies WHERE delete_date IS NULL and status != 'Delete' WHERE movie_id = '" + movie_id + "'";
                int setAvailable = 0;

                using (SqlCommand cmd = new SqlCommand(selectAvailableSeat, connection))
                {
                    SqlDataReader sqlDataReader = cmd.ExecuteReader();

                    if (sqlDataReader.Read())
                    {
                        setAvailable = (int)sqlDataReader["capacity"];
                    }
                    sqlDataReader.Close();
                }
                if (setAvailable > 0)
                {
                    string selectBookSeats = $"SELECT seat_number FROM movie_id = @movie_id";

                    List<int> bookSeat = new List<int>();

                    using (SqlCommand sql = new SqlCommand(selectBookSeats, connection))
                    {
                        sql.Parameters.AddWithValue("movie_id", movie_id);

                        SqlDataReader sqlDataReader = sql.ExecuteReader();

                        while (sqlDataReader.Read())
                        {
                            bookSeat.Add((int)sqlDataReader["seat_number"]);
                        }
                        sqlDataReader.Close();

                        List<int> allSeats = Enumerable.Range(1, setAvailable).ToList();

                        List<int> availableSeats = allSeats.Except(bookSeat).ToList();

                        DataTable table = new DataTable();
                        table.Columns.Add("seat_number", typeof(int));
                        foreach (int seat in availableSeats)
                        {
                            table.Rows.Add(seat);
                        }

                        if (table.Rows.Count > 0)
                        {
                            cbAvailableChairs.DataSource = table;
                            cbAvailableChairs.DisplayMember = "seat_number";
                            cbAvailableChairs.ValueMember = "seat_number";
                        }
                        else
                        {
                            cbAvailableChairs.DataSource = null;
                        }
                    }
                }
                else
                {
                    cbAvailableChairs.DataSource = null;
                }
            }
        }

        double getTotal = 0;
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(conn))
            {
                connection.Open();
                string selectPrice = "SELECT movie_id, price FROM movies WHERE movie_id = '" + movie_id + "'";

                double getPrice = 0;
                using (SqlCommand cmd = new SqlCommand(selectPrice, connection))
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        getPrice = Convert.ToDouble((reader["price"].Equals(null)) ? 0 : reader["price"]);
                    }

                    reader.Close();
                }

                double getFoodPrice = (cbFoods.SelectedIndex == -1) ? 0 : 100;
                double getDrinkPrice = (cbDrinks.SelectedIndex == -1) ? 0 : 50;

                getTotal = (getFoodPrice + getDrinkPrice + getPrice);

                lbTotalPrice.Text = "$" + getTotal.ToString("0.00");
            }
        }

        public void clearSelected()
        {
            id = 0;
            lbMovieID_BuyTicket.Text = "";
            lbMovieName_BuyTicket.Text = "";
            lbMovieGenre_BuyTicket.Text = "";
            lbRegularPrice_BuyTicket.Text = "";

            pbAvailableMovies.Image = null;
        }
        private void btnClear_BuyTicket_Click(object sender, EventArgs e)
        {
            clearSelected();
        }

        double getChange = 0;
        double getAmount = 0;

        private void txtAmount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (id == 0 && getTotal == 0)
                {
                    MessageBox.Show("Please select movie and foods first", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                        if (Convert.ToDouble(txtAmount.Text) >= getTotal)
                        {
                            getChange = Convert.ToDouble(txtAmount.Text) - getTotal;
                            getAmount = Convert.ToDouble(txtAmount.Text);
                        }
                        else
                        {
                            MessageBox.Show("Error :3 should > total", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            getChange = 0;
                        }

                        lbChange.Text = "$" + getChange.ToString("0.00");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Please enter number only", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtAmount.Text = "";
                        getAmount = 0;
                    }
                }
            }
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            if(movie_id == null || getTotal == 0)
            {
                MessageBox.Show("Please enter movie first", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (SqlConnection connection = new SqlConnection(conn))
                {
                    connection.Open();

                    string insertData = "INSERT INTO buy_tickets (movie_id, seat_number, price, amount, change, status, created_at) "
                                                   + "VALUES(@movieID, @seat_number, @amount, @change, @status, @date)";

                    using (SqlCommand command = new SqlCommand(insertData, connection))
                    {
                        command.Parameters.AddWithValue("@movieID", movie_id);
                        command.Parameters.AddWithValue("@seatNum", cbAvailableChairs.Text);
                        command.Parameters.AddWithValue("@price", getTotal);
                        command.Parameters.AddWithValue("@amount", getAmount);
                        command.Parameters.AddWithValue("@change", getChange);
                        command.Parameters.AddWithValue("@status", "PAID");

                        DateTime today = DateTime.Now;
                        command.Parameters.AddWithValue(@"date", today);

                        command.ExecuteNonQuery();

                        MessageBox.Show($"Successful ! occupied: {cbAvailableChairs.Text}"
                            , "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        //clearSelected();
                        //clearField();
                    }
                }
            }
        }
        public void clearField()
        {
            cbAvailableChairs.SelectedIndex = -1;
            cbFoods.SelectedIndex = -1;
            cbDrinks.SelectedIndex = -1;
            lbTotalPrice.Text = "$0.00";
            txtAmount.Text = "";
            lbChange.Text = "$0.00";
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            clearField();
        }

        private void btnReceipt_Click(object sender, EventArgs e)
        {
            printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(printDocument1_PrintPage);
            printDocument1.BeginPrint += new System.Drawing.Printing.PrintEventHandler(printDocument1_BeginPrint);

            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();

        }
        private int rowIndex = 0;

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            float y = 0;
            int count = 0;
            int colWidth = 100;
            int headerMargin = 10;
            int tableMargin = 10;

            Font font = new Font("Arial", 12);
            Font bold = new Font("Arial", 12, FontStyle.Bold);
            Font headerFont = new Font("Arial", 16, FontStyle.Bold);
            Font labelFont = new Font("Arial", 14, FontStyle.Bold);

            float margin = e.MarginBounds.Top;

            StringFormat stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Center;
            stringFormat.LineAlignment = StringAlignment.Center;

            string headerText = "MarcoMan's Cinema";
            y = (margin + count * headerFont.GetHeight(e.Graphics) + headerMargin);
            e.Graphics.DrawString(headerText, headerFont, Brushes.Black, e.MarginBounds.Left
                + (dgvAvailableMovies.Columns.Count / 6) * colWidth, y, stringFormat);
            
            count++;

            y += tableMargin;

            string[] header = {"ID","MovieID", "MovieName"};

            for(int i = 0; i < header.Length; i++)
            {
                y = margin + count * bold.GetHeight(e.Graphics) + tableMargin;
                e.Graphics.DrawString(header[i],bold, Brushes.Black, e.MarginBounds.Left
                    + i * colWidth, y, stringFormat);
            }

            count++;

            float rSpace = e.MarginBounds.Bottom - y;
            while( rowIndex < dgvAvailableMovies.Rows.Count)
            {
                DataGridViewRow dataGridViewRow = dgvAvailableMovies.Rows[rowIndex];

                for (int i = 0; i < dgvAvailableMovies.Columns.Count - 6; i++)
                {
                    object cellValue = dataGridViewRow.Cells[i].Value;
                    string cell = (cellValue != null) ? cellValue.ToString() : string.Empty;
                    
                    y = margin + count * font.GetHeight(e.Graphics) + tableMargin;
                    e.Graphics.DrawString(cell, font, Brushes.Black, e.MarginBounds.Left + id * colWidth, y, stringFormat);
                }

                count++;
                rowIndex++;

                if(y + font.GetHeight(e.Graphics) > e.MarginBounds.Bottom)
                {
                    e.HasMorePages = true;
                    return;
                }

                int labelMargin = (int)Math.Min(rSpace, 100);

                DateTime today = DateTime.Now;

                float lableX = e.MarginBounds.Right - e.Graphics
                    .MeasureString("-----------------", labelFont).Width;
                y = e.MarginBounds.Bottom - labelMargin - labelFont.GetHeight(e.Graphics);
                e.Graphics.DrawString("Total Price: \t$" + getTotal.ToString("0.00") + "\nAmount: \t$"
                    + txtAmount.Text + "\n\t\t--------------\nChange:\t" 
                    + lbChange.Text, labelFont, Brushes.Black, lableX, y);

                labelMargin = (int)Math.Min(rSpace, -40);

                string labelText = today.ToString();
                y = e.MarginBounds.Bottom - labelMargin -labelFont.GetHeight(e.Graphics);
                e.Graphics.DrawString(labelText, labelFont, Brushes.Black,
                    e.MarginBounds.Right - e.Graphics.MeasureString("------------------------------", labelFont).Width, y);

            }
        }

        private void printDocument1_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            rowIndex = 0;
        }
    }
}
