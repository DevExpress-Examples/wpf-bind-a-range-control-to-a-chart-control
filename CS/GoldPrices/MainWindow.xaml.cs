using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows;
using System.Windows.Resources;
using System.Xml.Linq;

namespace GoldPrices {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }
        List<GoldPrice> CreateDataSource() {
            XDocument document = DataLoader.LoadXmlFromResources("/Data/GoldPrices.xml");
            List<GoldPrice> goldPrices = new List<GoldPrice>();
            if (document != null) {
                foreach (XElement element in document.Element("GoldPrices").Elements()) {
                    DateTime date = Convert.ToDateTime(element.Element("Date").Value, CultureInfo.InvariantCulture);
                    double price = Convert.ToDouble(element.Element("Price").Value, CultureInfo.InvariantCulture);
                    goldPrices.Add(new GoldPrice(date, price));
                }
            }
            return goldPrices;
        }
        private void OnLoaded(object sender, RoutedEventArgs e) {
            this.DataContext = CreateDataSource();
        }
    }
    public class GoldPrice {
        readonly DateTime date;
        readonly double price;
        public DateTime Date { get { return date; } }
        public double Price { get { return price; } }
        public GoldPrice(DateTime date, double price) {
            this.date = date;
            this.price = price;
        }
    }
    public static class DataLoader {
        public static XDocument LoadXmlFromResources(string fileName) {
            try {
                Uri uri = new Uri(fileName, UriKind.RelativeOrAbsolute);
                StreamResourceInfo info = Application.GetResourceStream(uri);
                return XDocument.Load(info.Stream);
            }
            catch {
                return null;
            }
        }
    }
}
