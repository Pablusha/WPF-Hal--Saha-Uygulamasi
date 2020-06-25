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
    /// Interaction logic for ReservationAttempt.xaml
    /// </summary>
    public partial class ReservationAdd : Page
    {
        db_SahaEntities db = new db_SahaEntities();
        public ReservationAdd()
        {
            InitializeComponent();           

            var sahalar = db.tbl_saha.ToList();
           
            foreach (var saha in sahalar)
            {
                cmbSaha.Items.Add(saha.ID);
            }
           
        }        

        string tarih;
        private void Tarih_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            var picker = sender as DatePicker;
            DateTime? date = picker.SelectedDate;
            tarih = date.Value.ToShortDateString();
        }

        private void CmbSaha_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var deger = Convert.ToInt32(cmbSaha.SelectedItem.ToString());
            var saha = db.tbl_saha.Where(y => y.ID == deger).FirstOrDefault();
            sahaAd.Content = "Rezervasyon yapılan sahanın adı: " + saha.Saha_Ad;
            sahaFiyat.Content = "Rezervasyon yapılan sahanın fiyatı: " + saha.Fiyat;
            sahaKapasite.Content = "Rezervasyon yapılan sahanın kapasitesi: " + saha.Kapasite;
        }

        private void BtnSaveResAttempt_Click(object sender, RoutedEventArgs e)
        {

            if (cmbSaat.SelectedItem == null || cmbSaha.SelectedItem == null)
            {
                MessageBox.Show("Alanlar boş bırakılamaz.");
            }

            else
            {
                tbl_rezervasyon rezervasyon = new tbl_rezervasyon();

                var deger=cmbSaha.SelectedItem.ToString();

                rezervasyon.SahaID = Convert.ToInt32(deger);
                rezervasyon.Tarih = tarih;
                rezervasyon.Saat = cmbSaat.Text;
                rezervasyon.Not = rezNot.Text;
                rezervasyon.Durum = true;
                db.tbl_rezervasyon.Add(rezervasyon);
                db.SaveChanges();
               
            }
        }
    }
}
