using AbstractFactoryPattern.Interfaces;

namespace AbstractFactoryPattern
{
    /// <summary>
    /// ProductB1
    /// </summary>
    public class Nokia1600 : ICelularComum
    {
        public string BuscaDetalhesModelo()
        {
            return "Model: Nokia 1600 \n RAM: NA \nCamera: NA";
        }
    }
}
