//Martin Carrion
//    MIS 3033
//    Makeup Homework
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace Problems
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<CastingVote> Cvotes = new List<CastingVote>();

        public MainWindow()
        {
            InitializeComponent();

        }

        private void BtnSelectFile_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
           // DO THIS if Below does not work string downloadsDirectory = Environment.GetEnvironmentVariable("USERPROFILE") + @"\Downloads
            dlg.InitialDirectory = @"C:\Users\Martin\Desktop\";
            var Result=dlg.ShowDialog();
            if (Result==true)
            {
                txtSelect.Text = dlg.FileName;

            }

        }

        private void BtnAnalyze_Click(object sender, RoutedEventArgs e)
        {
            
            if (File.Exists(txtSelect.Text))
            {
               var lines= File.ReadAllLines(txtSelect.Text);
                int Count = 0;
                foreach (var line in lines)
                {
                    if (Count!=0)
                    {
                        var linePieces = line.Split('|');
                        string firstname, lastname, email, gender,votes;
                       

                        firstname = linePieces[0];
                        lastname = linePieces[1];
                        email= linePieces[2];
                        gender= linePieces[3];
                        votes=linePieces[4];

                        CastingVote Cvote = new CastingVote(firstname, lastname, email, gender, votes);
                        Cvotes.Add(Cvote);
                    }
                    Count++;

                }

                VotesforStarWars();
                VotesforGameofThrones();

            }


        }
        private void VotesforStarWars()
        {
            foreach (var Cvote in Cvotes)
            {
                if (Cvote.Vote.Contains("StarWars"))
                {

                    lstStarWars.Items.Add(Cvote);
                }

            }


        }
        private void VotesforGameofThrones()
        {
            Image I = new Image();
            I.Stretch = Stretch.Fill;
            I.Width = 835;
            I.Height = 249;
            I.Margin = new Thickness(5);
            foreach (var Cvote in Cvotes)
            {
                if (Cvote.Vote.Contains("GOT")) /*Cvo.Email.Contains("@dropbox.com")*/
                {
                    lst_GameofThrones.Items.Add(Cvote);
                    

                    
                    
                }

            }
            
            MessageBox.Show(Cvotes.Count().ToString() + " have voted!");
            if (lst_GameofThrones.Items.Count > lstStarWars.Items.Count)
            {
                MessageBox.Show("Game of Thrones WINS!");
                BitmapImage bi = new BitmapImage();
                bi.BeginInit();
                bi.UriSource = new Uri(@"https://www.fuzionvapor.com/pub/media/magefan_blog/p/h/photo.jpg", UriKind.RelativeOrAbsolute);
                bi.EndInit();
                I.Source = bi;
                txtImage.Inlines.Add(I);
                

            }
            else if (lstStarWars.Items.Count > lst_GameofThrones.Items.Count)
            {
                MessageBox.Show("Star Wars Wins!");
                BitmapImage bi = new BitmapImage();
                bi.BeginInit();
                bi.UriSource = new Uri(@"https://upload.wikimedia.org/wikipedia/commons/thumb/6/6c/Star_Wars_Logo.svg/1280px-Star_Wars_Logo.svg.png", UriKind.RelativeOrAbsolute);
                bi.EndInit();
                I.Source = bi;
                txtImage.Inlines.Add(I);
            }
            else if (lst_GameofThrones.Items.Count==lstStarWars.Items.Count)
            {
                MessageBox.Show("IT'S a TIE!");

            }


        }

        private void BtnClear_Click(object sender, RoutedEventArgs e)
        {
            

        }
    }
}
