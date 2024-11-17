namespace MauiAppMeuCombustivel
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            try
            {
                double etanol = Convert.ToDouble(txt_etanol.Text);
                double gasolina = Convert.ToDouble(txt_gasolina.Text);

                string marca = Convert.ToString(txt_Marca.Text);
                string modelo = Convert.ToString(txt_Modelo.Text);

                string msg = "";
                
                if(etanol <= (gasolina * 0.7) )
                {
                    msg = "O etanol está compensando para o seu {marca} e {modelo}.";
                } else
                {
                    msg = "O etanol não compensando para o seu {marca} e {modelo}.";
                }

                DisplayAlert("Calculado", msg, "OK");

            } catch(Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "Fechar");
            }

        } 
    } 
} 
