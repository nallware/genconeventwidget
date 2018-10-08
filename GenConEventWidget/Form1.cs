using System;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GenConEventWidget
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string FILENAME;
        //private string CONN = @"Data Source=(localdb)\mssqllocaldb; Integrated Security=true; AttachDbFileName = \Data\GenConEvents.mdf";
        //private string CONN = Properties.Settings.Default.GenConEventsConnectionString;




        private void Form1_Load(object sender, EventArgs e)
        {

            //DataSet ds = new GenConEventsDataSet();
            //dgvEvents.AutoGenerateColumns = true;
            //dgvEvents.DataSource = ds;
            //dgvEvents.DataMember = "GenConEvents";
            //MessageBox.Show("CONN is " + CONN);
            //dgvEvents.DataSource = LoadEvents();

        }

        private DataTable LoadEvents()
        {
            var table = new DataTable();
            try
            {
                MessageBox.Show("Attempting to load from DB");
                //using (var da = new SqlDataAdapter("SELECT * FROM GenConEvents", @"Data Source=(localdb)\mssqllocaldb; Integrated Security=true; AttachDbFileName = \Data\GenConEvents.mdf"))
                using (var da = new SqlDataAdapter("SELECT * FROM GenConEvents", @"Data Source=(localdb)\mssqllocaldb; Integrated Security=true; AttachDbFileName = \Data\GenConEvents.mdf")) 
                {
                    da.Fill(table);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            

            return table;
        }

        private void btnUpdateDB_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = openFileDialog1.ShowDialog();
                FILENAME = result == DialogResult.OK ? openFileDialog1.FileName : "";
                if (FILENAME == string.Empty)
                {
                }
                else
                {
                    //making some changes to test git
                    string begin = "this is the beginning of test to git functions.";
                    string only = "this is only a test and can be removed later.";
                    MessageBox.Show(begin + Environment.NewLine + only);

                    /*Read excel sheet*/
                    string excelSheetFilename = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + FILENAME +
                                                ";Extended Properties=\"Excel 12.0 Xml;HDR=Yes;IMEX=2\"";

                    OleDbConnection objcon = new OleDbConnection(excelSheetFilename);
                    string queryForExcel = "Select * from [Basic Worksheet$];";



                    OleDbDataAdapter objda = new OleDbDataAdapter(queryForExcel, objcon);
                    DataSet objds = new DataSet();
                    objda.Fill(objds);
                    if (objds.Tables[0].Rows.Count > 0)
                    {
                        dgvEvents.DataSource = objds.Tables[0];
                        //dgvEvents.DataBind();
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(
                    "Sadly, the manditory MS Access database thingie is not installed on your computer.  You can download and install it for free at https://www.microsoft.com/en-us/download/details.aspx?id=23734");
                throw;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int i = 0;

            string gameid = dgvEvents.Rows[i].Cells[0].Value.ToString();
            string eventgroup = dgvEvents.Rows[i].Cells[1].Value.ToString();
            string title = dgvEvents.Rows[i].Cells[2].Value.ToString();
            string shortdesc = dgvEvents.Rows[i].Cells[3].Value.ToString();
            string longdesc = dgvEvents.Rows[i].Cells[4].Value.ToString();
            string eventtype = dgvEvents.Rows[i].Cells[5].Value.ToString();
            string gamesystem = dgvEvents.Rows[i].Cells[6].Value.ToString();
            string rulesed = dgvEvents.Rows[i].Cells[7].Value.ToString();
            string minplayers = dgvEvents.Rows[i].Cells[8].Value.ToString();
            string maxplayers = dgvEvents.Rows[i].Cells[9].Value.ToString();
            string agerequired = dgvEvents.Rows[i].Cells[10].Value.ToString();
            string exprequired = dgvEvents.Rows[i].Cells[11].Value.ToString();
            string matlprovided = dgvEvents.Rows[i].Cells[12].Value.ToString() == "Yes" ? "1" : "0";
            string start = dgvEvents.Rows[i].Cells[13].Value.ToString();
            string duration = dgvEvents.Rows[i].Cells[14].Value.ToString();
            string end = dgvEvents.Rows[i].Cells[15].Value.ToString();
            string gmnames = dgvEvents.Rows[i].Cells[16].Value.ToString();
            string website = dgvEvents.Rows[i].Cells[17].Value.ToString();
            string email = dgvEvents.Rows[i].Cells[18].Value.ToString();
            string tournament = dgvEvents.Rows[i].Cells[19].Value.ToString() == "Yes" ? "1" : "0";
            string roundnum = dgvEvents.Rows[i].Cells[20].Value.ToString();
            string totalrounds = dgvEvents.Rows[i].Cells[21].Value.ToString();
            string minplaytime = dgvEvents.Rows[i].Cells[22].Value.ToString();
            string attendeeregistration = dgvEvents.Rows[i].Cells[23].Value.ToString();
            string cost = dgvEvents.Rows[i].Cells[24].Value.ToString();
            string location = dgvEvents.Rows[i].Cells[25].Value.ToString();
            string roomname = dgvEvents.Rows[i].Cells[26].Value.ToString();
            string tablenum = dgvEvents.Rows[i].Cells[27].Value.ToString();
            string specialcategory = dgvEvents.Rows[i].Cells[28].Value.ToString();
            string ticketsavailable = dgvEvents.Rows[i].Cells[29].Value.ToString();
            string lastmod = dgvEvents.Rows[i].Cells[30].Value.ToString();

            //string connetionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + fileName +
              //                       ";Extended Properties=\"Excel 12.0 Xml;HDR=Yes;IMEX=2\"";
            //string sql = null;
            //string connetionString =
            //    "Data Source=GenConEventsDataSet;Initial Catalog=AllGenConEvents; Trusted_Connection=True;";
            //string connetionString =
            //    @"Data Source=(localdb)\mssqllocaldb; Integrated Security=true; AttachDbFileName = Data\GenConEvents.mdf";
            using (SqlConnection cnn = new SqlConnection(@"Data Source=(localdb)\mssqllocaldb; Integrated Security=true; AttachDbFileName = Data\GenConEvents.mdf"))
            {
                //sql = "insert into Main ([Firt Name], [Last Name]) values(@first,@last)";
                string sql =
                    "insert into GenConEvents (GameId, EventGroup, Title, ShortDescription, LongDescription, EventType, GameSystem," +
                    "RulesEdition, MinimumPlayers, MaximumPlayers, AgeRequired, ExperienceRequired, MaterialsProvided, StartDateAndTime," +
                    "Duration, EndDateAndTime, GmNames, WebSite, Email, Tournament, RoundNumber, TotalRounds, MinimumPlayTime, AttendeeRegistration," +
                    "Cost, Location, RoomName, TableNumber, SpecialCategory, TicketsAvailable, LastModified) values (@gameid,@eventgroup,@title,@shortdesc," +
                    "@longdesc,@eventtype,@gamesystem,@rulesed,@minplayers,@maxplayers,@agerequired,@exprequired,@matlprovided,@start,@duration,@end,@gmnames," +
                    "@website,@email,@tournament,@roundnum,@totalrounds,@minplaytime,@attendeeregistration,@cost,@location,@roomname,@tablenum,@specialcategory" +
                    ",@ticketsavailable,@lastmod)";
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, cnn))
                {
                    cmd.Parameters.AddWithValue("@gameid", gameid);
                    cmd.Parameters.AddWithValue("@eventgroup", eventgroup);
                    cmd.Parameters.AddWithValue("@title", title);
                    cmd.Parameters.AddWithValue("@shortdesc", shortdesc);
                    cmd.Parameters.AddWithValue("@longdesc", longdesc);
                    cmd.Parameters.AddWithValue("@eventtype", eventtype);
                    cmd.Parameters.AddWithValue("@gamesystem", gamesystem);
                    cmd.Parameters.AddWithValue("@rulesed", rulesed);
                    cmd.Parameters.AddWithValue("@minplayers", minplayers);
                    cmd.Parameters.AddWithValue("@maxplayers", maxplayers);
                    cmd.Parameters.AddWithValue("@agerequired", agerequired);
                    cmd.Parameters.AddWithValue("@exprequired", exprequired);
                    cmd.Parameters.AddWithValue("@matlprovided", matlprovided);
                    cmd.Parameters.AddWithValue("@start", start);
                    cmd.Parameters.AddWithValue("@duration", duration);
                    cmd.Parameters.AddWithValue("@end", end);
                    cmd.Parameters.AddWithValue("@gmnames", gmnames);
                    cmd.Parameters.AddWithValue("@website", website);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@tournament", tournament);
                    cmd.Parameters.AddWithValue("@roundnum", roundnum);
                    cmd.Parameters.AddWithValue("@totalrounds", totalrounds);
                    cmd.Parameters.AddWithValue("@minplaytime", minplaytime);
                    cmd.Parameters.AddWithValue("@attendeeregistration", attendeeregistration);
                    cmd.Parameters.AddWithValue("@cost", cost);
                    cmd.Parameters.AddWithValue("@location", location);
                    cmd.Parameters.AddWithValue("@roomname", roomname);
                    cmd.Parameters.AddWithValue("@tablenum", tablenum);
                    cmd.Parameters.AddWithValue("@specialcategory", specialcategory);
                    cmd.Parameters.AddWithValue("@ticketsavailable", ticketsavailable);
                    cmd.Parameters.AddWithValue("@lastmod", lastmod);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //test connection
            string conny = textBox1.Text;
            using (SqlConnection conn = new SqlConnection(conny))
            {
                try
                {
                    conn.Open();
                    MessageBox.Show("No prob.");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
    }
}