using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tulpep.NotificationWindow;
namespace TCP_CLIENT
{
    public partial class frmPopup : Form
    {
        public frmPopup()
        {
            InitializeComponent();
        }

        private void frmPopup_Load(object sender, EventArgs e)
        {
           PopupNotifier popup = new PopupNotifier();
            popup.Image = Properties.Resources.yellow_alert;
            popup.TitleText = "FIRAT";
            popup.ContentText = "SOn BEŞ DAKİKAA";
        }

        
    }
}
