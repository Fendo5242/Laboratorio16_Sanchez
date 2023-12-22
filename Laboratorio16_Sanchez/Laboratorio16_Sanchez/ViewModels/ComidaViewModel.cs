using Laboratorio16_Sanchez.Models;
using Laboratorio16_Sanchez.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;


namespace Laboratorio16_Sanchez.ViewModels
{
    public class ComidaViewModel : INotifyPropertyChanged
    {
        private List<ComidaModel> _listings;
        public List<ComidaModel> Listings
        {
            get { return _listings; }
            set { _listings = value; OnPropertyChanged(); }
        }

        public Command LoadListingsCommand { get; set; }

        public ComidaViewModel()
        {
            LoadListingsCommand = new Command(async () => await LoadListings());
            Listings = new List<ComidaModel>();
        }

        async Task LoadListings()
        {
            var apiService = new ComidaService();
            Listings = await apiService.GetListingsAsync("https://comidas-api.vercel.app/comidas");
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
