using AbstractFactoryPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    /// <summary>
    /// Client
    /// </summary>
    public class CelularClient
    {
        ISmartPhone SmartPhone;
        ICelularComum celularComum;

        public CelularClient(ICelular celularFactory)
        {
            SmartPhone = celularFactory.BuscarSmartPhone();
            celularComum = celularFactory.BuscarCelularComum();
        }

        public string BuscarSmartPhoneModeloDetalhes()
        {
            return SmartPhone.BuscaDetalhesModelo();
        }

        public string BuscarCelularComumDetalhes()
        {
            return celularComum.BuscaDetalhesModelo();
        }

    }
}
