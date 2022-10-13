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
    public partial class MainWindow : Window
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private HttpClient _httpClient;
        public MainWindow(IHttpClientFactory httpClientFactory)
        {
            InitializeComponent();
            _httpClientFactory = httpClientFactory;
            _httpClient = _httpClientFactory.CreateClient();
            _httpClient.BaseAddress = new Uri("https://localhost:5001/api/");
        }

        private async void Window_Loaded(object sender, RoutedEventArgs e) 
        {
            var respone = await _httpClient.GetAsync("films");

            if (respone.IsSuccessStatusCode)
            {
                using var responseStream = await respone.Content.ReadAsStreamAsync();
                //var filmsResponse = await JsonSerializer.DeserializeAsync<ApiBaseResponse<IEnumerable<FilmsApiResponse>>>(responseStream);

            }
        }
    }
}
