using Imi.Project.Wpf.ApiResponseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
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

namespace Imi.Project.Wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private HttpClient _httpClient;

        private Guid selectedFilmId = Guid.Empty;
        private Guid selectedFilmDirectorId = Guid.Empty;
        private Guid selectedFilmGenreId = Guid.Empty;
        public MainWindow(IHttpClientFactory httpClientFactory)
        {
            InitializeComponent();
            _httpClientFactory = httpClientFactory;
            _httpClient = _httpClientFactory.CreateClient();
            _httpClient.BaseAddress = new Uri("https://localhost:5001/api/");
        }

        private async void Window_Loaded(object sender, RoutedEventArgs e) 
        {
            await SetupAsync();   
        }

        private async Task SetupAsync() 
        {
            var response = await _httpClient.GetAsync("films");

            if (response.IsSuccessStatusCode)
            {
                using var responseStream = await response.Content.ReadAsStreamAsync();
                var filmsResponse = await JsonSerializer.DeserializeAsync<IEnumerable<FilmsApiResponse>>(responseStream);

                FillFilmInListBox(filmsResponse);
            }
            else
            {
                ShowFeedback(response.ReasonPhrase);
            }
        }

        private void FillFilmInListBox(IEnumerable<FilmsApiResponse> films)
        {
            lstFilms.Items.Clear();
            foreach (var film in films)
            {
                lstFilms.Items.Add(film);
            }
        }

        private void lstFilms_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var film = (FilmsApiResponse)lstFilms.SelectedItem;
            if (film == null)
            {
                ClearFilmDetails();
            }
            else
            {
                GetFilmDetails(film);
            }
        }

        private async void GetFilmDetails(FilmsApiResponse film)
        {
            var response = await _httpClient.GetAsync($"films/{film.Id}");

            if (response.IsSuccessStatusCode)
            {
                using var responseStream = await response.Content.ReadAsStreamAsync();
                var filmDetailResponse = await JsonSerializer.DeserializeAsync<FilmsApiResponse>(responseStream);

                ShowFilmDetails(filmDetailResponse);
            }
            else
            {
                ShowFeedback(response.ReasonPhrase);
            }
        }

        private void ShowFilmDetails(FilmsApiResponse filmDetail)
        {
            txtBoxTitle.Text = filmDetail.Title;
            txtBoxReleaseYear.Text = filmDetail.ReleaseYear.ToString();
            selectedFilmId = filmDetail.Id;
            BitmapImage thumbnail = new BitmapImage();
            thumbnail.BeginInit();
            thumbnail.UriSource = new Uri(filmDetail.Image);
            thumbnail.EndInit();
            imgCover.Source = thumbnail;
        }

        private async void btnSave_Click(object sender, RoutedEventArgs e)
        {
            //var film = new FilmsApiResponse();
            //film.Id = selectedFilmId;
            //film.Title = txtBoxTitle.Text;
            //film.ReleaseYear = Int32.Parse(txtBoxReleaseYear.Text);
            //var filmContent = new StringContent(film);
            //var request = await _httpClient.PutAsync("films", filmContent);
            //await SetupAsync();
        }

        private void ShowFeedback(string message)
        {
            lblFeedback.Content = $"Fout: {message}";
            lblFeedback.Background = Brushes.Red;
            lblFeedback.Foreground = Brushes.White;
            lblFeedback.FontWeight = FontWeights.Bold;
        }

        private void ClearFilmDetails()
        {
            txtBoxReleaseYear.Text = string.Empty;
            txtBoxTitle.Text = string.Empty;
            imgCover.Source = null;
        }
    }
}
