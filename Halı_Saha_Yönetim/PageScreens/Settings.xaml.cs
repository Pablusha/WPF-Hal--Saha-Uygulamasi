using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Halı_Saha_Yönetim.PageScreens
{
    /// <summary>
    /// Interaction logic for Settings.xaml
    /// </summary>
    public partial class Settings : Page
    {

        db_SahaEntities db = new db_SahaEntities();
        public Settings()
        {
            InitializeComponent();
            dataGridSaha.ItemsSource = db.tbl_saha.ToList();
        }
   
        private void Button_Ekle(object sender, RoutedEventArgs e)
        {
            //ADD Data
            tbl_saha yeniSaha = new tbl_saha();
            yeniSaha.Saha_Ad = txtSahaAd.Text;
            yeniSaha.Fiyat = Convert.ToInt32(txtFiyat.Text);
            yeniSaha.Kapasite = Convert.ToInt32(txtSahaKapasite.Text);

            db.tbl_saha.Add(yeniSaha);
            db.SaveChanges();
            dataGridSaha.ItemsSource = db.tbl_saha.ToList(); //Kayıt ekledikten sonra yenilemek için                                                           
        }
      
        private void Button_Sil(object sender, RoutedEventArgs e)
        {
            int silinecek = Convert.ToInt32(txtSecim.Text);
            var silineceksaha = db.tbl_saha.Where(w => w.ID == silinecek).FirstOrDefault();
            db.tbl_saha.Remove(silineceksaha);
            db.SaveChanges();
            dataGridSaha.ItemsSource = db.tbl_saha.ToList();
        }

            
        
    }
}
