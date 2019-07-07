using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AutopliusCrawler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void PriceFrom_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void NumericUpDown1_ValueChanged_1(object sender, EventArgs e)
        {

        }

        private void NumericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            return;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(searched_number.Text) || !Regexes.PhoneNumbers2.IsMatch(searched_number.Text))
            {
                MessageBox.Show("Įveskite ieškomą numerį tinkamu formatu!");
                return;
            }

            AutopliusBot bot = new AutopliusBot()
            {
                crawler = new Crawler(),
                mileageTo = (int)Mileage_to.Value,
                mileageFrom = (int)Mileage_from.Value,
                searchedCity = City.Text ?? string.Empty,
                yearFrom = (int)Year_from.Value,
                yearTo = (int)Year_to.Value,
                olderNot = string.IsNullOrEmpty(Age_of_advertisement.SelectedItem?.ToString()) ? 0 : int.Parse(Age_of_advertisement.SelectedItem?.ToString()),
                countryID = 1,
                priceFrom = (int)Price_from.Value,
                priceTo = (int)Price_to.Value,
                searchedNumber = searched_number.Text,
            };

            int cityID = 0;

            if (!bot.CollectCityIDs(Urls.SearchPage) || (!string.IsNullOrEmpty(bot.searchedCity) && !Dictionaries.CityToID.TryGetValue(bot.searchedCity.ToUpper(), out cityID)))
            {
                MessageBox.Show("Failed to construct cities dictionary or the key for the city has not been found!");
                return;
            }

            bot.cityID = cityID;

            bot.CollectData();

            if (AutopliusBot.urlsWithNumber.Any())
            {
                StringBuilder sb = new StringBuilder();

                AutopliusBot.urlsWithNumber.ForEach(url => sb.Append($"{url},{Environment.NewLine}"));

                MessageBox.Show("Found advertisements:" + Environment.NewLine + $"{sb.ToString()}");
            }
        }
    }
}
