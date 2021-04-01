using AxAcroPDFLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YourProject_winForms
{
    public partial class PDF_Reader_View : Form
    {

        #region Variables

        private string imgPath;

        #endregion

        #region Constructors
        public PDF_Reader_View(string path) // added path to link to file path from receipt.
        {
            InitializeComponent();
            imgPath = path;
            
        }

        #endregion

        #region Form Events
        private void PDF_Reader_View_Load(object sender, EventArgs e)
        {
            AddPDFToViewer();
            CenterScreen();
            CollectGarbage();
        }

        private void CenterScreen()
        {
            // center form to middle of working area
            Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - Width) / 2,
                          (Screen.PrimaryScreen.WorkingArea.Height - Height) / 2);
        }

        private void AddPDFToViewer()
        {
            axAcroPDF_Viewer.src = imgPath;
            
        }

        private void PDF_Reader_View_Paint(object sender, PaintEventArgs e)
        {
            // read the new Property settings of the ColorTheme
            this.BackColor = Properties.Settings.Default.ColorTheme;
        }

        #endregion

        #region Cleaner Methods

        /// <summary>
        /// This method will call for garbage collection.
        /// </summary>
        private void CollectGarbage()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
        #endregion

        #region NOT IN USE
        /// <summary>
        /// on button press event open file dialog will allow users to select and,
        /// open PDF file in rich text box.
        /// 
        /// Uses ->     Adobe Acrobat reader component.
        /// Requires -> Adobe Acrobat reader to be installed.
        /// </summary>

        private void btnOpen_Click(object sender, EventArgs e)
        {
            //OpenPDF();
        }

        /// <summary>
        /// 
        /// Will load the PDF File via open file dialog.
        /// 
        /// Uses     ->     Adobe Acrobat reader component.
        /// Requires ->     Adobe Acrobat reader to be installed.
        /// </summary>
        private void OpenPDF()
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { ValidateNames = true, Multiselect = false, Filter = "PDF files|*.pdf" })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        axAcroPDF_Viewer.src = ofd.FileName;
                    }
                    catch (Exception pdf_Read_Exception)
                    {
                        MessageBox.Show(pdf_Read_Exception.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        #endregion
        
    }
}
