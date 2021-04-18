using AbstractFactoryPattern.Interfaces;
using System;

namespace AbstractFactoryPattern.ConcreteFactories
{
    /// <summary>
    /// ConcreteFactory1
    /// </summary>
    public class Nokia : ICelular
    {
        public ICelularComum BuscarCelularComum()
        {
            return new Nokia1600();
        }

        public ISmartPhone BuscarSmartPhone()
        {
            return new NokiaPixel();
        }
    }
}
