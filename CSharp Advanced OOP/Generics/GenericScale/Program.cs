using System;

namespace GenericScale
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EqualityScale<int> equalityScale = new EqualityScale<int>(4, 4);
            Console.WriteLine(equalityScale.AreEqual());
        }
    }

    public class EqualityScale<T>
    {
        private T left;
        private T right;

        public EqualityScale(T left, T right)
        {
            this.left = left;
            this.right = right;
        }

        public bool AreEqual() => left.Equals(right);
    }
}
