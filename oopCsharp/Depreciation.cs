namespace oopCsharp6
{
    interface IDepresiasi
    {
        // Interface
        double Depresiasi();
    }

    abstract class DepresiasiAktiva : IDepresiasi
    {
        // Abstract Class
        public abstract double Depresiasi();
    }
}