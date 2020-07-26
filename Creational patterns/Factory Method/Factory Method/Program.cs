using Factory_Method.Logistics;
using Factory_Method.Transports;

namespace Factory_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            Logistic logistic = new RoadLogistic();

            Transport transport1 = logistic.CreateTransport();
            transport1.Deliver();                               //  Доставка на грузовике

            logistic = new SeaLogistic();
            Transport transport2 = logistic.CreateTransport();
            transport2.Deliver();                               //  Доставка на корабле
        }
    }
}
