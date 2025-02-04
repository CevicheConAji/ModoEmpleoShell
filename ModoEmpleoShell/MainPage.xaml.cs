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
            ValidarBotonCalculo();
        }
        public int PrecioFinal
        {
            get { return _precioFinal; }
            set
            {
                _precioFinal = value;
                OnPropertyChanged();
                ValidarBotonCalculo();
            }
        }

        public string? FormaPago 
        { 
            get {return _formaPago;} 
            set { _formaPago = value;
                OnPropertyChanged();
                ValidarBotonCalculo();
            } 
        }
        public int PrecioInicial 
        { 
            get { return _precioInicial; } 
            set 
            {
                _precioInicial = value;
                OnPropertyChanged();
                ValidarBotonCalculo();
            } 
        }
        public string? CursoUsuario 
        {
            get { return _cursoUsuario; }
            set
            {
                _cursoUsuario = value;
                OnPropertyChanged();
                ValidarBotonCalculo();
            }
        }


        private async void btnSeleccionarCurso_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync($"Page2??formaPago={_formaPago}");
        }

        private void btnCalcularPrecio_Clicked(object sender, EventArgs e)
        {
            if (_formaPago == "Tarjeta")
            {
                _precioFinal = (int)(_precioInicial - (_precioInicial * 0.1)); // Descuento del 10%
            }
            else
            {
                _precioFinal = _precioInicial;
            }

            OnPropertyChanged(nameof(PrecioFinal));
        }
        private async void btnSeleccionarFormaPago_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync($"Page3?cursoUsuario={_cursoUsuario}&precioInicial={_precioInicial}");
        }
        private void ValidarBotonCalculo()
        {
            btnCalcularPrecio.IsEnabled = !string.IsNullOrEmpty(CursoUsuario)
                                        && !string.IsNullOrEmpty(FormaPago)
                                        && PrecioInicial > 0;
        }
    }

}
