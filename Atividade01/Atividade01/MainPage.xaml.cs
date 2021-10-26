using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;


namespace Atividade01
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Application.Current.Properties["Codigo"] = TxtCodigo.Text;
            Application.Current.Properties["Titulo"] = TxtTitulo.Text;
            Application.Current.Properties["Autor"] = TxtAutor.Text;
            Application.Current.Properties["Editora"] = TxtEditora.Text;
            Application.Current.Properties["Ano"] = TxtAno.Text;
            
            //DisplayAlert("SwitchEnviaEmail", Application.Current.Properties["EnviaEmail"].ToString(), "Ok");
            // se quiser salvar imediatamente
            Application.Current.SavePropertiesAsync();
            
                
            
        }

        private void Button2_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new DadosArquivo());
        }

        private void bt2(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PageTeste());
        }
    }
}
