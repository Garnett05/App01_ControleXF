using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App01_ControleXF.Controles
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SearchBarPage : ContentPage
    {
        private List<String> conferenciaLeste;
        public SearchBarPage()
        {
            InitializeComponent();

            conferenciaLeste = new List<string>();
            conferenciaLeste.Add("Celtics");
            conferenciaLeste.Add("Knicks");
            conferenciaLeste.Add("Nets");
            conferenciaLeste.Add("Raptors");
            conferenciaLeste.Add("Hawks");
            conferenciaLeste.Add("Bucks");
            conferenciaLeste.Add("Sixers");
            conferenciaLeste.Add("Hornets");
            conferenciaLeste.Add("Pacers");
            conferenciaLeste.Add("Pistons");
            conferenciaLeste.Add("Magic");
            conferenciaLeste.Add("Heat");
            conferenciaLeste.Add("Cavaliers");
            conferenciaLeste.Add("Wizards");
            conferenciaLeste.Add("Bulls");

            Preencher(conferenciaLeste);            
        }
        private void Pesquisar(object sender, TextChangedEventArgs args)
        {
            var resultado = conferenciaLeste.Where(a => a.Contains(args.NewTextValue)).ToList<string>();

            Preencher(resultado);
        }
        private void Preencher(List<String> conferenciaLeste)
        {
            ListResult.Children.Clear();
            foreach (var times in conferenciaLeste)
            {
                ListResult.Children.Add(new Label { Text = times });
            }
        }
    }
}