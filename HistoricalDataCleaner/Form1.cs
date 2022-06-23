using CsvHelper;
using System;
using System.Data;
using System.Globalization;

namespace HistoricalDataCleaner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class record
        {
            public long unix { get; set; }
            public DateTime date { get; set; }
            public string symbol { get; set; }
            public float open { get; set; }
            public float high { get; set; }
            public float low { get; set; }
            public float volume_asset { get; set; }
            public float volume_base { get; set; }
            public float trade_count { get; set; }

        }

        private void btnSrcFolderBrowse_Click(object sender, EventArgs e)
        {
            try
            {
                if (dlgSrcFolder.ShowDialog() == DialogResult.OK)
                {
                    string srcFolder = dlgSrcFolder.SelectedPath;
                    lblInputFolderPath.Text = srcFolder;
                    var folder = new DirectoryInfo(srcFolder);
                    var srcCsvFilePaths = folder.GetFiles("*.csv", SearchOption.TopDirectoryOnly);

                    chkListInputFiles.Items.Clear();
                    foreach (FileInfo s in srcCsvFilePaths)
                    {
                        //if (s.Name.EndsWith("-output.csv")) continue; //skip the output files
                        chkListInputFiles.Items.Add(s.Name, true);

                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public static void ToCSV(DataTable dtDataTable, string strFilePath)
        {
            StreamWriter sw = new StreamWriter(strFilePath, false);
            //headers    
            for (int i = 0; i < dtDataTable.Columns.Count; i++)
            {
                sw.Write(dtDataTable.Columns[i]);
                if (i < dtDataTable.Columns.Count - 1)
                {
                    sw.Write(",");
                }
            }
            sw.Write(sw.NewLine);
            foreach (DataRow dr in dtDataTable.Rows)
            {
                for (int i = 0; i < dtDataTable.Columns.Count; i++)
                {
                    if (!Convert.IsDBNull(dr[i]))
                    {
                        string value = dr[i].ToString();
                        if (value.Contains(','))
                        {
                            value = String.Format("\"{0}\"", value);
                            sw.Write(value);
                        }
                        else
                        {
                            sw.Write(dr[i].ToString());
                        }
                    }
                    if (i < dtDataTable.Columns.Count - 1)
                    {
                        sw.Write(",");
                    }
                }
                sw.Write(sw.NewLine);
            }
            sw.Close();
        }

        private void btcStartCleaning_Click(object sender, EventArgs e)
        {
            try
            {


                string tempFolder = dlgSrcFolder.SelectedPath + "\\Temp";
                string destFolder = dlgSrcFolder.SelectedPath + "\\Outputs";
                lblOutputFolderPath.Text = destFolder;
                Directory.CreateDirectory(tempFolder);
                Directory.CreateDirectory(destFolder);
                //var config = new CsvHelper.Configuration.CsvConfiguration { };
                //config.

                for (int i = 0; i < chkListInputFiles.Items.Count; i++)
                {
                    CheckState st = chkListInputFiles.GetItemCheckState(i);
                    if (st == CheckState.Unchecked)
                        continue;

                    string fileName = chkListInputFiles.GetItemText(i);
                    FileInfo f_input = new FileInfo(dlgSrcFolder.SelectedPath + "\\" + chkListInputFiles.Items[i].ToString());
                    FileInfo f_temp = new FileInfo(tempFolder + "\\" + chkListInputFiles.Items[i].ToString().Replace(".csv", "") + "-temp.csv"); // Intermediate version
                    FileInfo f_output = new FileInfo(destFolder + "\\" + chkListInputFiles.Items[i].ToString().Replace(".csv", "") + "-output.csv"); // Final version

                    StreamReader sr_input = new StreamReader(f_input.FullName);
                    StreamWriter sw_temp = new StreamWriter(f_temp.FullName);

                    while (sr_input.Peek() >= 0)
                    {
                        string? line_in = sr_input.ReadLine();
                        if (String.IsNullOrEmpty(line_in)) continue; // skip blank lines
                        if (!line_in.Contains(",")) continue;// skip non comma lines
                        string line_out = line_in;
                        ///////////////////////////////////////////////////////////
                        // make the dates format consistent
                        string date_orig = line_out.Split(",")[1];
                        line_out = line_out.Replace(date_orig, "fillnewdatehere");
                        string date_out = date_orig.Replace("-AM", ":00:00");
                        if (date_orig.Contains("-PM"))
                        {
                            date_out = date_orig.Replace("-PM", ":00:00");
                            DateTime outDt = DateTime.Parse(date_out).AddHours(12);
                            date_out = outDt.ToString("yyyy-MM-dd HH:mm:ss");
                        }
                        line_out = line_out.Replace("fillnewdatehere", date_out);
                        ////////////////////////////////////////////////////////////

                        // make the tradecount format consistent
                        string tradecount_orig = line_out.Split(",")[9];
                        line_out = line_out.Replace("NULL", "0");
                        ///////////////////////////////////////////////////////////

                        /// make the unix date format consistent
                        string unixdate = line_out.Split(",")[0];
                        line_out = line_out.Replace(".0", "");
                        ///////////////////////////////////////////////////////////

                        sw_temp.WriteLine(line_out);
                    }
                    //sr_input.Close();
                    sw_temp.Close();

                    // After initial cleaning pass on to csv parser for data conversions

                    var dt = new DataTable();

                    using (var sr_temp = new StreamReader(f_temp.FullName))
                    using (var csv = new CsvReader(sr_temp, CultureInfo.InvariantCulture))
                    {
                        // Do any configuration to `CsvReader` before creating CsvDataReader.
                        using (var dr = new CsvDataReader(csv))
                        {

                            dt.Columns.Add("unix", typeof(long));
                            dt.Columns.Add("Date", typeof(DateTime));
                            dt.Columns.Add("symbol", typeof(string));
                            dt.Columns.Add("open", typeof(float));
                            dt.Columns.Add("high", typeof(float));
                            dt.Columns.Add("low", typeof(float));
                            dt.Columns.Add("close", typeof(float));
                            dt.Columns.Add("Volume BTC", typeof(decimal));
                            dt.Columns.Add("Volume USDT", typeof(decimal));
                            dt.Columns.Add("tradecount", typeof(long));

                            dt.Load(dr);
                        }
                    }

                    // var finalDt = dt.DefaultView.ToTable(true, "Date");
                    //var finalDt = dt.AsEnumerable()
                    // .GroupBy(x => x.Field<int>("ColumnName"))
                    // .Select(y => y.First())
                    // .CopyToDataTable();
                    DataTable distinctDT = (from rows in dt.AsEnumerable()
                                            group rows by new { ColA = rows["Date"] } into grp
                                            select grp.First()).CopyToDataTable();

                    ToCSV(distinctDT, f_output.FullName);
                    chkListOutputFiles.Items.Add(f_output.Name, true);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

    }

}


