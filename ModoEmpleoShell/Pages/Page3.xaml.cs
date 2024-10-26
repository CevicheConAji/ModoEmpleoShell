namespace ModoEmpleoShell.Pages;
[QueryProperty(nameof(CursoUsuario), "cursoUsuario")]
[QueryProperty(nameof(PrecioInicial), "precioInicial")]

public partial class Page3 : ContentPage
{
    string _formaPago;
    public string? _cursoUsuario;
    public int _precioInicial;

    public Page3()
	{
		InitializeComponent();
	}
    public int PrecioInicial
    {
        get { return _precioInicial; }
        set
        {
            _precioInicial = value;
            OnPropertyChanged();
        }
    }
    public string? CursoUsuario
    {
        get { return _cursoUsuario; }
        set
        {
            _cursoUsuario = value;
            OnPropertyChanged();
        }
    }
    private async void btnEfectivo_Clicked(object sender, EventArgs e)
    {
        _formaPago = "Efectivo";
        await Shell.Current.GoToAsync($"//MainPage?formaPago={_formaPago}&cursoUsuario={_cursoUsuario}&precioInicial={_precioInicial}");
    }

    private async void btnTarjeta_Clicked(object sender, EventArgs e)
    {
        _formaPago = "Tarjeta";
        await Shell.Current.GoToAsync($"//MainPage?formaPago={_formaPago}&cursoUsuario={_cursoUsuario}&precioInicial={_precioInicial}");
    }
}