using KitapAp.MODELS;
using KitapApp.BLL;
using KitapApp.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KitapOtomasyonAppEFCodeFirst
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int kitapid = 0;

        private void btnEkle_Click(object sender, EventArgs e)
        {
            KitapBL ktbl = new KitapBL();

            Kitap ktp = new Kitap();


            ktp.KitapId = kitapid;
            ktp.KitapAdi = txtKitapAdi.Text.Trim();
            ktp.YayinEviId = (int)cboxyevi.SelectedValue;
            ktp.BasimYili = txtBasimYili.Text.Trim();
            ktp.KitapTuruId = (int)cboxkturu.SelectedValue;
            ktp.SayfaSayisi = txtSayfaSayisi.Text.Trim();

            switch (kitapid)
            {
                case 0:

                    if (ktbl.Ekle(ktp))
                    {
                        MessageBox.Show("Ekleme Başarılı");
                    }
                    else
                    {
                        MessageBox.Show("Yeniden Dene !!!!");
                    }
                    break;

                  
         
                   
            }
        }

       
        
    }
}
