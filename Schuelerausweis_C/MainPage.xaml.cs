using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using Microsoft.Data.Sqlite;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using System.Data;


// Die Elementvorlage "Leere Seite" wird unter https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x407 dokumentiert.

namespace Schuelerausweis_C
{
    /// <summary>
    /// Eine leere Seite, die eigenständig verwendet oder zu der innerhalb eines Rahmens navigiert werden kann.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        DateTime startDate = DateTime.Now;


        public MainPage()
        {
            this.InitializeComponent();
            PopulateProjects();

        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {
           

        }

        //Schueler wird in der Datenbank gespeichert
        void SchSave(object sender, RoutedEventArgs e)
        {
            String name = textBox_name.Text;
            String nachname = textBox_nachname.Text;
            String aname = textBox_a_name.Text;
            String anachname = textBox_a_nachname.Text;
            String gebdat = textBox_gebdat.Text;
            String kid = textBox_kid.Text;
            String status = textBox_status.Text;

        }

        //Schüeler wird aus der Datenbank gelöscht
        void SchDelet(object sender, RoutedEventArgs e)
        {
            String name = textBox_name.Text;
            String nachname = textBox_nachname.Text;
            String aname = textBox_a_name.Text;
            String anachname = textBox_a_nachname.Text;
            String gebdat = textBox_gebdat.Text;
            String kid = textBox_kid.Text;
            String status = textBox_status.Text;
        }

        //Schüler Bild wird dem Schüler in der Datenbank hinzugefügt
        void SchBildAdd(object sender, RoutedEventArgs e)
        {
            String name = textBox_name.Text;
            String nachname = textBox_nachname.Text;
            String aname = textBox_a_name.Text;
            String anachname = textBox_a_nachname.Text;
            String gebdat = textBox_gebdat.Text;
            String kid = textBox_kid.Text;
            String status = textBox_status.Text;
        }
        //Bild des Schülers wird aus der Datenbank gelöscht
        void SchBildDelet(object sender, RoutedEventArgs e)
        {
            String name = textBox_name.Text;
            String nachname = textBox_nachname.Text;
            String aname = textBox_a_name.Text;
            String anachname = textBox_a_nachname.Text;
            String gebdat = textBox_gebdat.Text;
            String kid = textBox_kid.Text;
            String status = textBox_status.Text;
        }
        void ButtonTest(object sender, RoutedEventArgs e)
        {
            
            textBlock3.Text = textBox_name.Text;
            textBlock4.Text = "";
            textBlock5.Text = "";
            textBlock6.Text = "";
            textBlock7.Text = "";
            textBlock8.Text = "";
            textBlock9.Text = "";
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {

        }

        private void textBlock_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }

        private void GridView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        private void PopulateProjects()
        {
            List<Schueler> Schulers = new List<Schueler>();

            Schueler newSchueler = new Schueler();
            newSchueler.Activities.Add(new Activity()
            {
                Name = "Florian",
                Nachname = "Amend",
                AName = "Florian",
                ANachname = "Amend",
                GebDat = startDate.AddDays(2),
                Einschulung = startDate.AddDays(3),
                GueltiBis = startDate.AddDays(4),
                Status = "Aktiv",
                DueDate = startDate.AddDays(4)
            }); ;
            Schulers.Add(newSchueler);

            cvsProjects.Source = Schulers;
        }
    }

    public class Schueler
    {
        public Schueler()
        {
            Activities = new ObservableCollection<Activity>();
        }

        public string Name { get; set; }
        public ObservableCollection<Activity> Activities { get; private set; }
    }

    public class Activity
    {
        public string FullName { get; set; }
        public string Name { get; set; }
        public string Nachname { get; set; }
        public string AName { get; set; }
        public string ANachname { get; set; }
        public DateTime GebDat { get; set; }
        public byte Foto { get; set; }
        public DateTime Einschulung { get; set; }
        public DateTime GueltiBis { get; set; }
        public string Status { get; set; }
        public DateTime DueDate { get; set; }

    }
}

