using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCP_CLIENT
{
    public partial class frmUserInformation : MaterialForm
    {
        public frmUserInformation()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }
        public string ad, soyad, okulno, svIP, svPort; //  login information

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmUserInformation_Load(object sender, EventArgs e)
        {
            txtID.Text = okulno;
            txtIp.Text = svIP;
            txtName.Text = ad;
            txtport.Text = svPort;
            txtsurname.Text = soyad;


        }
    }
}
