namespace MultiRegras.Customers
{

    //public abstract class Imposto
    //{
    //    public virtual decimal CalcularICMS(decimal valor)
    //    {
    //        return valor * 2;
    //    }
    //}

    //public class ImpostoBalta : Imposto
    //{
    //    public override decimal CalcularICMS(decimal valor)
    //    {
    //        return valor * 3;
    //    }
    //}


    public interface IImposto
    {
        public decimal CalcularICMS(decimal valor);
    }
}