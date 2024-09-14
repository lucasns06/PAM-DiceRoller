namespace DiceRoller;

public partial class MainPage : ContentPage
{

    public MainPage()
    {
        InitializeComponent();
    }
    public class Dado
    {

        private int quantidadeDeLados;
        private int modificador;

        public int QuantidadeDeLados { get => quantidadeDeLados; set => quantidadeDeLados = value; }
        public int Modificador { get => modificador; set => modificador = value; }

        public int RolarDado()
        {
            return new Random().Next(1, QuantidadeDeLados + 1);
        }
    }
    /*
   Quantidade de dados : rolar o dado ex: qtddados = 3, vai rolar 3 vezes obvio
    modificador > somar cada resultado pelo valor.
     */
    
    private void RollerButton_Clicked(object sender, EventArgs e)
    {
        try
        {
            int qtdDados = Convert.ToInt32(EntryQtdDados.Text.ToString());
            int soma = 0;
            int resultado;
            String exibir = null;

            for (int cont = 0; cont < qtdDados; cont++)
            {
                Dado dado = new Dado();

                int modPicker = Convert.ToInt32(ModPicker.SelectedItem.ToString());
                int itemPicker = Convert.ToInt32(SidesPicker.SelectedItem.ToString());

                dado.QuantidadeDeLados = itemPicker;
                dado.Modificador = modPicker;

                resultado = dado.RolarDado();
                soma = soma + resultado;

                exibir = exibir + resultado + " , ";
                
                ResultLabel2.Text = "Você tirou: " + exibir.ToString();
                ResultLabel.Text = soma.ToString();
            }
        }
        catch (Exception ex)
        {
            DisplayAlert("Janela", "Algo está errado", "OK");
        }
    }
    /*
     
   
     */
    //Sortear um número aleatório através do clique do botão
    //Devolver o número sorteado para a interface
    //Conseguir selecionar a quantidade de lados a partir do Picker

}

