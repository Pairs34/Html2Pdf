namespace Html2Pdf
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void btnSelectFolder_Click(object sender, EventArgs e)
        {
            var selectFolder = folderBrowser.ShowDialog();
            if (selectFolder == DialogResult.OK)
            {
                txtFolderPath.Text = folderBrowser.SelectedPath;

                MessageBox.Show("Pdflerin olu�turulaca�� klas�r� se�iniz.");

                var saveFolderSelect = folderBrowser.ShowDialog();
                if (saveFolderSelect == DialogResult.OK)
                {
                    var outputPath = folderBrowser.SelectedPath;
                    var htmlFiles = Directory.GetFiles(txtFolderPath.Text, "*.html");

                    var htmlToPdf = new NReco.PdfGenerator.HtmlToPdfConverter();

                    progressConvert.Maximum = htmlFiles.Length;

                    stepText.Text = $"0/{htmlFiles.Length}";

                    Task.Factory.StartNew(() =>
                    {
                        foreach (var htmlFile in htmlFiles)
                        {
                            string fileName = Path.GetFileNameWithoutExtension(htmlFile);
                            htmlToPdf.GeneratePdfFromFile(htmlFile, null, $"{Path.Combine(outputPath, fileName + ".pdf")}");

                            progressConvert.Value += 1;
                            stepText.Text = $"{progressConvert.Value}/{htmlFiles.Length}";
                        }
                    });
                }
            }
        }
    }
}