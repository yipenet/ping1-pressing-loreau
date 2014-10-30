﻿using System;
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


namespace App_pressing_Loreau.Interfaces
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class Accueil : Window
    {
        Button user1, user2, user3, user4, user5, user6 ;
        public Accueil()
        {
            InitializeComponent();

        }

         void CommandBtn_Click(Object sender, RoutedEventArgs e) {   
            switch (1)
            {

                //case "btn_user1":
                //    btn_user1.Background = Brushes.Red;
                //    break;
                //case "btn_user2":
                //    btn_user1.Background = Brushes.Red;
                //    break;
                //case "btn_user3":
                //    btn_user1.Background = Brushes.Red;
                //    break;
                //case "btn_user4":
                //    btn_user1.Background = Brushes.Red;
                //    break;
                //case "btn_user5":
                //    btn_user1.Background = Brushes.Red;
                //    break;
                //case "btn_user6":
                //    btn_user1.Background = Brushes.Red;
                //    break;
            }

        }
     

        private void btn_accueil_reception_Click(object sender, RoutedEventArgs e)
        {
            IdentificationClient identificationClient = new IdentificationClient();
            dp.Children.Clear();
            dp.Children.Add(identificationClient);
        }

        private void btn_accueil_rendu_Click(object sender, RoutedEventArgs e)
        {
            dp.Children.Clear();
            dp.Children.Add(new RestitutionArticles());


        }

        private void btn_accueil_facture_Click(object sender, RoutedEventArgs e)
        {
            dp.Children.Clear();

        }

        private void btn_accueil_client_pro_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_accueil_administrateur_Click(object sender, RoutedEventArgs e)
        {
            dp.Children.Clear();
            dp.Children.Add(new IdentificationAdmin());
        }

        private void btn_accueil_convoyeur_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_accueil_image_Click(object sender, RoutedEventArgs e)
        {
            dp.Children.Clear();
        }

        private void btn_user6_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_accueil_impression_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_user1_Click(object sender, RoutedEventArgs e)
        {
            btn_user1.Background = Brushes.Red; 
        }



    }
}
