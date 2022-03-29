using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Net.Http;
using Lab2_api;


namespace Forms_Lab2
{
    public partial class Form1 : Form
    {
        public class GetWeather
        {
            public Cord Coord { get; set; }
            public Weather[] Weather { get; set; }
            public Main_part Main { get; set; }
            public Wind Wind { get; set; }
        }

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            var json = GetDataAsync();
        }
        private async Task<string> GetDataAsync()
        {
            string Miasto = getCity.Text;
            string call = "https://api.openweathermap.org/data/2.5/weather?q=" + Miasto + "&appid=6a54ad3554c744c9e365b3e7858658dd&units=metric";
            HttpClient client = new HttpClient();
            string json = await client.GetStringAsync(call);
            GetWeather pogoda = JsonConvert.DeserializeObject<GetWeather>(json);

            AktualnaPogoda.Items.Add(Miasto);
            AktualnaPogoda.Items.Add("Temperatura: " + pogoda.Main.temp + "'C\tTemperatura odczuwalna: " + pogoda.Main.feels_like + "'C\tPredkosc wiatru: " + pogoda.Wind.speed + "km/h ");
            
            return json;
        }
    }
}
