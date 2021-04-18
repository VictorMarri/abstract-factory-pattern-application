using AbstractFactoryPattern.Interfaces;
using System;

namespace AbstractFactoryPattern.ConcreteFactories
{
    /// <summary>
    /// ConcreteFactory2
    /// </summary>
    public class Samsung : ICelular
    {
        public ICelularComum BuscarCelularComum()
        {
            return new SamsungGuru();
        }

        public ISmartPhone BuscarSmartPhone()
        {
            return new SamsungGalaxy();
        }
    }
}
