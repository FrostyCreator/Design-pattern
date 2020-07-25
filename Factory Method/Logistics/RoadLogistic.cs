using Factory_Method.Transports;

namespace Factory_Method.Logistics
{
    class RoadLogistic : Logistic
    {
        public override Transport CreateTransport()
        {
            return new Truck();
        }
    }
}
