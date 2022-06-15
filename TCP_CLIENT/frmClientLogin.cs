using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using MaterialSkin.Controls;
using MaterialSkin;

namespace TCP_CLIENT
{
    public partial class frmClientLogin : MaterialForm
    {
        public frmClientLogin()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }
        //girişte alınan bilgilerin stringleri
        string ad, soyad, okulno;
        string svIP, svPort;
        private void btnLogin_Click(object sender, EventArgs e)
        {
            //alınan bilgiler
            ad = TxtName.Text;
            soyad = TxtSurname.Text;
            okulno = txtIDNumber.Text;
            svIP=textBoxIP.Text;
            svPort=textBoxPort.Text;

            
            if (System.Text.RegularExpressions.Regex.IsMatch(txtIDNumber.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                txtIDNumber.Text = txtIDNumber.Text.Remove(txtIDNumber.Text.Length - txtIDNumber.Text.Length);
                
                
                return;
            }
                       

            if (string.IsNullOrEmpty(ad) && String.IsNullOrEmpty(soyad) && String.IsNullOrEmpty(okulno))
            {
                MessageBox.Show("Please Write Id,Name and Surname ");
                return;
            }
              

            if (String.IsNullOrEmpty(ad) == false && String.IsNullOrEmpty(soyad) == false && String.IsNullOrEmpty(okulno) == false)
            {
                //tekrar giriş yapıldığında IP ve port kaydedilmes,
                Properties.Settings.Default.IpPath = textBoxIP.Text;
                Properties.Settings.Default.Save();
                Properties.Settings.Default.Upgrade();
                Properties.Settings.Default.PortPath = textBoxPort.Text;
                Properties.Settings.Default.Save();
                Properties.Settings.Default.Upgrade();

                frmUserInformation muser = new frmUserInformation();
                muser.ad = ad;
                muser.soyad = soyad;
                muser.okulno = okulno;
                muser.svIP = svIP;
                muser.svPort = svPort;
                this.Hide();
              


                //client formuna geçiş ve aktarım
                frmClient mfrm = new frmClient();
                mfrm.ad = ad;
                mfrm.soyad = soyad;
                mfrm.okulno = okulno;
                mfrm.svIP = svIP;
                mfrm.svPort = svPort;
                this.Hide();
                mfrm.ShowDialog();

            }

        }


        private void frmClientLogin_Load(object sender, EventArgs e)
        {
            textBoxIP.Text = Properties.Settings.Default.IpPath;
            textBoxPort.Text = Properties.Settings.Default.PortPath;

        }
    }
}