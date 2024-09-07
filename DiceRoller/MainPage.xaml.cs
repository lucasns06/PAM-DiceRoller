namespace DiceRoller;

public partial class MainPage : ContentPage
{

    public MainPage()
    {
        InitializeComponent();
    }
    

    private void RollerButton_Clicked(object sender, EventArgs e)
    {
        int value = Convert.ToInt32(EntryPicker.SelectedItem);
        Random rnd = new Random();
        int ResultNumber = rnd.Next(value);
        LabelResult.Text = ResultNumber.ToString();
    }
    
    //Sortear um número aleatório através do clique do botão
    //Devolver o número sorteado para a interface
    //Conseguir selecionar a quantidade de lados a partir do Picker

}

