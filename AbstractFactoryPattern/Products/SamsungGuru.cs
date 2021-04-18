using AbstractFactoryPattern.Interfaces;

namespace AbstractFactoryPattern
{
    /// <summary>
    /// ProductB2
    /// </summary>
    public class SamsungGuru : ICelularComum
    {
        public string BuscaDetalhesModelo()
        {
            return "Modelo: Samsung Guru \nRAM: NA \nCamera: NA";
        }
    }
}
