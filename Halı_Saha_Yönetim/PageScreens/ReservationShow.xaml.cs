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
    /// ReservationShow.xaml etkileşim mantığı
    /// </summary>
    public partial class ReservationShow : Page
    {
        db_SahaEntities db = new db_SahaEntities();
        public ReservationShow()
        {
            InitializeComponent();
            dataGridSaha.ItemsSource = db.tbl_rezervasyon.ToList();

        }
    }
}
