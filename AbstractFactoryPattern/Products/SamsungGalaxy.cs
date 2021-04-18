using AbstractFactoryPattern.Interfaces;

namespace AbstractFactoryPattern
{
    /// <summary>
    /// ProductA2
    /// </summary>
    public class SamsungGalaxy : ISmartPhone
    {
        public string BuscaDetalhesModelo()
        {
            return "Modelo: Samsung Galaxy \nRAM: 8GB \nCamera: 16MP";
        }
    }
}
