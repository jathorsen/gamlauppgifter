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

namespace Gammalval3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        Election election = new Election();
        Party party = new Party();
        public void btnRegister_Click(object sender, RoutedEventArgs e)
        {
            //Kallar på party klassen och dess variabler för att sätta värde osv
            Party party = new Party(txtName.Text, txtAbbreviation.Text);

            // lägger till de i List<>
            election.Parties.Add(party);

            // NULL LISTBOX innan värden tilldelas(brukar hjälpa)
            lstParties.ItemsSource = null;
            lstParties.ItemsSource = election.Parties;
            lstParties.SelectedItem = party.Name;



            txtVotes.Text = party.NumberOfVotes.ToString();

        }
        // simpel int.parse txt för att få in det i en int
        private void btnVotes_Click(object sender, RoutedEventArgs e)
        {
            party.NumberOfVotes = int.Parse(txtVotes.Text);
        }


        // Skapade en knapp som väljer det alternativet i listboxen som har klickats på och visar det i en label.
        private void btnChoose_Click(object sender, RoutedEventArgs e)
        {
            lblParty.Content = lstParties.SelectedItem.ToString();
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            // kallar på klassen 
            party = election.FindPartyByShort(txtAbbreviation.Text);
            // Om party är null så kommer partiet sakns att visas, annars visas party.Name;
            if (party == null)
            {
                lblSearchResult.Content = "Partiet saknas";
            }
            else
            {
                lblSearchResult.Content = party.Name;
            }
        }
    }
}
