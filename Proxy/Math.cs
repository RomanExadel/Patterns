namespace Proxy
{
    class Math : IMath<double>
    {
        public double Add(double x, double y) => x + y;

        public double Sub(double x, double y) => x - y;

        public double Mul(double x, double y) => x * y;

        public double Div(double x, double y) => x / y;
    }
}
