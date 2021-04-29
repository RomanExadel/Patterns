namespace Proxy
{
    interface IMath<T>
    {
        T Add(T x, T y);

        T Sub(T x, T y);

        T Mul(T x, T y);

        T Div(T x, T y);
    }
}
