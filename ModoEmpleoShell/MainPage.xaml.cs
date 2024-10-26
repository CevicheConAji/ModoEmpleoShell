namespace ModoEmpleoShell
{
    [QueryProperty(nameof(CursoUsuario), "cursoUsuario")]
    [QueryProperty(nameof(PrecioInicial), "precioInicial")]
    [QueryProperty(nameof(FormaPago),"formaPago")]
    [QueryProperty(nameof(PrecioFinal), "precioFinal")]
    
    public partial class MainPage : ContentPage
    {
        public string? _cursoUsuario;
        public int _precioInicial;
        public string? _formaPago;
        public int _precioFinal;
        public MainPage()
        {
            InitializeComponent();
            BindingContext = this;
        }
        public int PrecioFinal
        {
            get { return _precioFinal; }
            set
            {
                _precioFinal = value;
                OnPropertyChanged();
            }
        }

        public string? FormaPago 
        { 
            get {return _formaPago;} 
            set { _formaPago = value;
                OnPropertyChanged(); } 
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


        private async void btnSeleccionarCurso_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync($"Page2??formaPago={_formaPago}");
        }

        private void btnCalcularPrecio_Clicked(object sender, EventArgs e)
        {
            _precioFinal = _precioInicial;

            if (_formaPago == "Efectivo")
            {
                _precioFinal = (int)(_precioInicial - (_precioInicial * 0.1));
                OnPropertyChanged(nameof(PrecioFinal));
            }
            else
            {
                OnPropertyChanged(nameof(PrecioFinal));
            }
        }
        private async void btnSeleccionarFormaPago_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync($"Page3?cursoUsuario={_cursoUsuario}&precioInicial={_precioInicial}");
        }
    }

}
