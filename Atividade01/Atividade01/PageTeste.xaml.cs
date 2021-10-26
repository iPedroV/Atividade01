using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Atividade01
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageTeste : ContentPage
    {
        public PageTeste()
        {
            InitializeComponent();

            lb1.Text += "\nCódigo" + Application.Current.Properties["Codigo"].ToString();
            lb1.Text += "\nTítulo" + Application.Current.Properties["Titulo"].ToString();
            lb1.Text += "\nAutor" + Application.Current.Properties["Autor"].ToString();
            lb1.Text += "\nEditora" + Application.Current.Properties["Editora"].ToString();
            lb1.Text += "\nAno" + Application.Current.Properties["Ano"].ToString();
        }
    }
}