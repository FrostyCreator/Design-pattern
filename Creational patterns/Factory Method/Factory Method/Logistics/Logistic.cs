using Factory_Method.Transports;

namespace Factory_Method.Logistics
{
    public abstract class Logistic
    {
        public abstract Transport CreateTransport();
    }
}
