namespace ModoEmpleoShell;

[QueryProperty(nameof(FormaPago), "formaPago")]
public partial class Page2 : ContentPage
{
    public string _formaPago;
    string _cursoUsuario;
    int _precioInicial;
    public Page2()
	{
		InitializeComponent();
	}
    public string? FormaPago
    {
        get { return _formaPago; }
        set
        {
            _formaPago = value;
            OnPropertyChanged();
        }
    }

    private async void btnCursoUFO_Clicked(object sender, EventArgs e)
    {
        _cursoUsuario = "Ufología";
        _precioInicial = 100;
        await Shell.Current.GoToAsync($"//MainPage?cursoUsuario={_cursoUsuario}&precioInicial={_precioInicial}&formaPago={_formaPago}");
    }

    private async void btnCursoZombie_Clicked(object sender, EventArgs e)
    {
        _cursoUsuario = "Sobrevivir al apocalipsis zombie";
        _precioInicial = 200;
        await Shell.Current.GoToAsync($"//MainPage?cursoUsuario={_cursoUsuario}&precioInicial={_precioInicial}&?formaPago={_formaPago}");
    }
}