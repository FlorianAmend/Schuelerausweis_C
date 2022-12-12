using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace Schuelerausweis_C
{
    class SAP
    {
        public void Main()
        {
            Console.WriteLine("Hello World!");
        }
    }

    class Student 
    {
        string FullName { get; set; }
        string Name { get; set; }
        string Nachname { get; set; }
        string AName { get; set; }
        public string ANachname { get; set; }
        public DateTime GebDat { get; set; }
        public byte Foto { get; set; }
        public DateTime Einschulung { get; set; }
        public DateTime GueltiBis { get; set; }
        public string Status { get; set; }
        public DateTime DueDate { get; set; }

    }
}
