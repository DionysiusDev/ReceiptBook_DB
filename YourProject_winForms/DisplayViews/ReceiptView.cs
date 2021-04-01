using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Printing;

namespace YourProject_winForms
{
    public partial class ReceiptView : Form
    {
        #region MyLogger
        //  declaration of logger
        private static readonly log4net.ILog myLog4N = log4net.LogManager.GetLogger(
        System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        #endregion

        #region Variables

        PictureBox pbReceiptImage;
        private string imgPath;

        #endregion

        public ReceiptView(string path)
        {
            InitializeComponent();
            imgPath = path;
        }

        private void ReceiptView_Load(object sender, EventArgs e)
        {
            AdjustImageAddScroll();
        }

        private void AdjustImageAddScroll()
        {
            pbReceiptImage = new PictureBox();
            pbReceiptImage.SizeMode = PictureBoxSizeMode.AutoSize;
            pbReceiptImage.ImageLocation = imgPath;

            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Controls.Add(pbReceiptImage);
        }

        private void ReceiptView_Paint(object sender, PaintEventArgs e)
        {
            // read the new Property settings of the ColorTheme
            this.BackColor = Properties.Settings.Default.ColorTheme;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintFile();
        }

        #region Print File
        /// <summary>
        /// Prints Current Receipt Image.
        /// </summary>
        private void PrintFile()
        {
            try
            {
                //instantiate print dialog
                PrintDialog pd = new PrintDialog();
                PrintDocument doc = new PrintDocument();
                doc.PrintPage += DOC_PrintPage;
                pd.Document = doc;

                if (pd.ShowDialog() == DialogResult.OK)
                {
                    doc.Print();
                }
            }
            catch (IOException IOE)
            {
                // display export data error.
                MessageBox.Show("ERROR Printing File." + IOE.Message);
                myLog4N.Debug("ERROR Printing File. " + IOE.StackTrace);
            }
        }

        private void DOC_PrintPage(object sender, PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(pbReceiptImage.Width, pbReceiptImage.Height);
            pbReceiptImage.DrawToBitmap(bm, new Rectangle(0, 0, pbReceiptImage.Width, pbReceiptImage.Height));
            e.Graphics.DrawImage(bm, 0, 0);
            bm.Dispose();
        }

        #endregion
    }
}
