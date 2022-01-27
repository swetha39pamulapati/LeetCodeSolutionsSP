using System;

namespace _111.KclosestToOrigin
{
    internal class Heap<T>
    {
        private Func<object, object, int> p;
        private int v;

        public Heap(Func<object, object, int> p, int v)
        {
            this.p = p;
            this.v = v;
        }
    }
}