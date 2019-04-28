using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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

namespace GOT
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

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
           






        }

        private void BtnSubmit_Click(object sender, RoutedEventArgs e)
        {
            using (HttpClient client = new HttpClient())
            {
                var Response = client.GetAsync(@"http://swquotesapi.digitaljedi.dk/api/SWQuote/RandomStarWarsQuote").Result; /*https://got-quotes.herokuapp.com/quotes*/
                if (Response.IsSuccessStatusCode)
                {
                    var Content = Response.Content.ReadAsStringAsync().Result;
                    Quote q = JsonConvert.DeserializeObject<Quote>(Content);
                    //Create Image element
                    Image I = new Image();
                    I.Width = 792;
                    I.Height = 452;
                    I.Margin = new Thickness(5);

                    if (Content.Contains("Obi-Wan Kenobi"))
                    {
                        txtQuote.Inlines.Add((new Italic(new Run(Content))));
                        // Create source.
                        BitmapImage bi = new BitmapImage();
                        // BitmapImage.UriSource must be in a BeginInit/EndInit block.
                        bi.BeginInit();
                        bi.UriSource = new Uri(@"https://spacequotations.com/wp-content/uploads/2018/11/obi-wan-kenobi-810x455.jpg", UriKind.RelativeOrAbsolute);
                        bi.EndInit();
                        // Set the image source.
                        I.Source = bi;

                        txtImage1.Inlines.Add(I);

                    }
                    if (Content.Contains("Yoda"))
                    {
                        txtQuote.Inlines.Add((new Italic(new Run(Content))));
                        // Create source.
                        BitmapImage bi = new BitmapImage();
                        // BitmapImage.UriSource must be in a BeginInit/EndInit block.
                        bi.BeginInit();
                        bi.UriSource = new Uri(@"https://images.spot.im/v1/production/e11udzsxyowj05nzydtj", UriKind.RelativeOrAbsolute);
                        bi.EndInit();
                        // Set the image source.
                        I.Source = bi;

                        txtImage1.Inlines.Add(I);

                    }
                    if (Content.Contains("Jango Fett"))
                    {
                        txtQuote.Inlines.Add((new Italic(new Run(Content))));
                        // Create source.
                        BitmapImage bi = new BitmapImage();
                        // BitmapImage.UriSource must be in a BeginInit/EndInit block.
                        bi.BeginInit();
                        bi.UriSource = new Uri(@"https://cdn3.volusion.com/ondfq.dtexo/v/vspfiles/photos/BAN07787-2.jpg?1517950095", UriKind.RelativeOrAbsolute);
                        bi.EndInit();
                        // Set the image source.
                        I.Source = bi;

                        txtImage1.Inlines.Add(I);

                    }
                    if (Content.Contains("Gon Jinn"))
                    {
                        txtQuote.Inlines.Add((new Italic(new Run(Content))));
                        // Create source.
                        BitmapImage bi = new BitmapImage();
                        // BitmapImage.UriSource must be in a BeginInit/EndInit block.
                        bi.BeginInit();
                        bi.UriSource = new Uri(@"https://sfzone1-legalbrandmarket.netdna-ssl.com/wp-content/uploads/2018/01/Qui-Gon-Jinn.jpg", UriKind.RelativeOrAbsolute);
                        bi.EndInit();
                        // Set the image source.
                        I.Source = bi;

                        txtImage1.Inlines.Add(I);

                    }
                    if (Content.Contains("Bendu"))
                    {
                        txtQuote.Inlines.Add((new Italic(new Run(Content))));
                        // Create source.
                        BitmapImage bi = new BitmapImage();
                        // BitmapImage.UriSource must be in a BeginInit/EndInit block.
                        bi.BeginInit();
                        bi.UriSource = new Uri(@"https://thewookieegunner.files.wordpress.com/2016/12/star-wars-rebels-visions-and-voices-kanan-jarrus-ezra-bridger-bendu-01.png", UriKind.RelativeOrAbsolute);
                        bi.EndInit();
                        // Set the image source.
                        I.Source = bi;

                        txtImage1.Inlines.Add(I);

                    }
                    if (Content.Contains("Duchess Satine Kryze"))
                    {
                        txtQuote.Inlines.Add((new Italic(new Run(Content))));
                        // Create source.
                        BitmapImage bi = new BitmapImage();
                        // BitmapImage.UriSource must be in a BeginInit/EndInit block.
                        bi.BeginInit();
                        bi.UriSource = new Uri(@"https://i.pinimg.com/236x/37/89/e4/3789e49ff13c15e7aa38d6681f01a3bf--cosplay--cosplay-star-wars.jpg", UriKind.RelativeOrAbsolute);
                        bi.EndInit();
                        // Set the image source.
                        I.Source = bi;

                        txtImage1.Inlines.Add(I);

                    }
                    if (Content.Contains("Han Solo"))
                    {
                        txtQuote.Inlines.Add((new Italic(new Run(Content))));
                        // Create source.
                        BitmapImage bi = new BitmapImage();
                        // BitmapImage.UriSource must be in a BeginInit/EndInit block.
                        bi.BeginInit();
                        bi.UriSource = new Uri(@"https://vignette.wikia.nocookie.net/lucasfilm/images/0/01/Hansoloprofile.jpg/revision/latest?cb=20130924194740", UriKind.RelativeOrAbsolute);
                        bi.EndInit();
                        // Set the image source.
                        I.Source = bi;

                        txtImage1.Inlines.Add(I);

                    }
                    if (Content.Contains("Anakin Skywalker"))
                    {
                        txtQuote.Inlines.Add((new Italic(new Run(Content))));
                        // Create source.
                        BitmapImage bi = new BitmapImage();
                        // BitmapImage.UriSource must be in a BeginInit/EndInit block.
                        bi.BeginInit();
                        bi.UriSource = new Uri(@"https://vignette.wikia.nocookie.net/starwars/images/6/6f/Anakin_Skywalker_RotS.png/revision/latest?cb=20130621175844", UriKind.RelativeOrAbsolute);
                        bi.EndInit();
                        // Set the image source.
                        I.Source = bi;

                        txtImage1.Inlines.Add(I);

                    }
                    if (Content.Contains("Rey"))
                    {
                        txtQuote.Inlines.Add((new Italic(new Run(Content))));
                        // Create source.
                        BitmapImage bi = new BitmapImage();
                        // BitmapImage.UriSource must be in a BeginInit/EndInit block.
                        bi.BeginInit();
                        bi.UriSource = new Uri(@"https://www.cheatsheet.com/wp-content/uploads/2017/11/Rey-looking-straight-ahead-startled.png", UriKind.RelativeOrAbsolute);
                        bi.EndInit();
                        // Set the image source.
                        I.Source = bi;

                        txtImage1.Inlines.Add(I);

                    }
                    if (txtQuote.Text=="")
                    {
                        MessageBox.Show("No Picture");

                    }
                    
                    


                }
            }

        }

        private void Btnclear_Click(object sender, RoutedEventArgs e)
        {
            txtQuote.Text = "";
            txtImage1.Text = "";
        }
    }
}
