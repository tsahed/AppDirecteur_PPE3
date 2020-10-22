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
    /// Logique d'interaction pour Statistiques.xaml
    /// </summary>
    public partial class Statistiques : Window
    {
        public Statistiques()
        {
            InitializeComponent();
        }

        private void btn_theme_pStat_Click(object sender, RoutedEventArgs e)
        {
            Theme_Obstacle T_O = new Theme_Obstacle();
            T_O.Show();
        }

        private void btn_avis_pStat_Click(object sender, RoutedEventArgs e)
        {
            Avis avis = new Avis();
            avis.Show();
        }

        private void btn_fermer_pStat_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult mbr_confirmation;
            mbr_confirmation = MessageBox.Show("Êtes-vous sur de vouloir quitter ?", "Fermeture", MessageBoxButton.YesNo);

            if (mbr_confirmation == MessageBoxResult.Yes)
            {
                Close();
            }
        }
    }
}
