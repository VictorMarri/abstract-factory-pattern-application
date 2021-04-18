namespace AbstractFactoryPattern.Interfaces
{
    /// <summary>
    /// Abstract Factory
    /// </summary>
    public interface ICelular
    {
        ISmartPhone BuscarSmartPhone();
        ICelularComum BuscarCelularComum();
    }
}
