using CsvHelper;
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
            if (dlgSrcFolder.ShowDialog() == DialogResult.OK)
            {
                string srcFolder = dlgSrcFolder.SelectedPath;
                lblFolderPath.Text = srcFolder;
                var folder = new DirectoryInfo(srcFolder);
                var srcCsvFilePaths = folder.GetFiles("*.csv", SearchOption.TopDirectoryOnly);
                Directory.CreateDirectory(srcFolder + "\\Outputs");
                chkListInputFiles.Items.Clear();
                foreach (FileInfo s in srcCsvFilePaths)
                {
                    if (s.Name.EndsWith("-output.csv")) continue; //skip the output files
                    chkListInputFiles.Items.Add(s.Name, true);

                }

                ////var config = new CsvHelper.Configuration.CsvConfiguration { };
                ////config.


                //foreach (FileInfo s in srcCsvFilePaths)
                //{
                //    if (s.Name.EndsWith("-output.csv")) continue; //skip the output files
                //    //StreamReader sr = new StreamReader(s.FullName);
                //    StreamWriter sw = new StreamWriter(s.FullName.Replace(".csv", "") + "-output.csv");

                //    var sr = new StreamReader(s.FullName);
                //    //sr.Peek();
                //    string? line = sr.ReadLine();
                //    while (String.IsNullOrEmpty(line)) line = sr.ReadLine();

                //    if (!line.Contains(",")) line = sr.ReadLine(); // skip 1st line
                //    using (var csv = new CsvReader(sr, CultureInfo.InvariantCulture))
                //    {
                //        var records = csv.GetRecords<record>();

                //    }

                //    //while (sr.Peek() >= 0)
                //    //{
                //    //    //perform task related to file 
                //    //    string? line = sr.ReadLine();
                //    //    if (line == null) continue;
                //    //    if (!line.Contains(",")) continue;// skip 1st line


                //    //    sw.WriteLine(line);




                //    //}
                //    sr.Close();
                //    sw.Close();
                //}
            }

        }
    }
}