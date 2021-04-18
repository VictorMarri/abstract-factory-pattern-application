using AbstractFactoryPattern.Interfaces;

namespace AbstractFactoryPattern
{
    /// <summary>
    /// ProductA1
    /// </summary>
    public class NokiaPixel : ISmartPhone
    {
        public string BuscaDetalhesModelo()
        {
            return "Modelo: Nokia Pixel \nRAM: 3GB \nCamera: 8MP";
        }
    }
}
