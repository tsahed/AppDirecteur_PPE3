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
using System.Windows.Shapes;

namespace AppDirecteur_PPE3
{
    /// <summary>
    /// Logique d'interaction pour Avis.xaml
    /// </summary>
    public partial class Avis : Window
    {
        public Avis()
        {
            InitializeComponent();
        }

        private void btn_Stat_pAvis_Click(object sender, RoutedEventArgs e)
        {
            Statistiques Stat = new Statistiques();
            Stat.Show();
        }

        private void btn_theme_pAvis_Click(object sender, RoutedEventArgs e)
        {
            Theme_Obstacle T_O = new Theme_Obstacle();
            T_O.Show();
        }

        private void btn_quitte_pAvis_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult mbr_confirmation;
            mbr_confirmation = MessageBox.Show("Êtes-vous sur de vouloir quitter ?", "Fermeture", MessageBoxButton.YesNo);

            if (mbr_confirmation == MessageBoxResult.Yes)
            {
                Close();
            }
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MessageBoxResult mbr_confirmation;
            mbr_confirmation = MessageBox.Show("Êtes-vous sur de vouloir quitter ?", "Fermeture", MessageBoxButton.YesNo);
            if (mbr_confirmation == MessageBoxResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
