namespace DiceRoller;

public partial class MainPage : ContentPage
{

    public MainPage()
    {
        InitializeComponent();
    }
    public class Dado
    {

        private int quantidadeDeDados;
        private int modificador;

        public int RolarDado()
        {
            int value = Convert.ToInt32(SidesPicker.SelectedItem.ToString());
            int ResultNumber = new Random().Next(1, value + 1);
            ResultLabel.Text = ResultNumber.ToString();
        }
    }
    /*
   Quantidade de dados : rolar o dado ex: qtddados = 3, vai rolar 3 vezes obvio
    modificador > somar cada resultado pelo valor.
     */

    Dado dado = new Dado();
    private void RollerButton_Clicked(object sender, EventArgs e)
    {
        int qtdDados = Convert.ToInt32(EntryQtdDados.ToString());
        dado.RolarDado();
    }
    
    //Sortear um número aleatório através do clique do botão
    //Devolver o número sorteado para a interface
    //Conseguir selecionar a quantidade de lados a partir do Picker

}

