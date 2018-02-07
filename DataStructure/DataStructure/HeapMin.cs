using System;

namespace DataStructure
{
    public class HeapMin
    {
        private int[] numbers;
        private int len;
        private int capacity;

        public int Length
        {
            get
            {
                return len;
            }
        }

        public HeapMin()
        {
            numbers = new int[10];
            len = 0;
            capacity = 10;
        }

        public int Peek()
        {
            if (len == 0)
                throw new InvalidOperationException("Empty Heap");
            return numbers[0];
        }

        private void Capacity()
        {
            if (len == capacity)
            {
                Array.Resize(ref numbers, capacity * 2);
                capacity *= 2;
            }
        }

        public HeapMin BuildHeap(int[] elements)
        {
            numbers = elements;
            len = elements.Length;
            capacity = len;
            for (int i = numbers.Length / 2; i > 0; i--)
            {
                HeapIfyDown(i);
            }
            return this;
        }

        private void Swap(int x, int y)
        {
            int aux = numbers[x];
            numbers[x] = numbers[y];
            numbers[y] = aux;
        }

        private void HeapIfyUp(int currentIndex)
        {
            while (currentIndex > 0)
            {
                int parent = (currentIndex - 1) / 2;
                if (numbers[parent] <= numbers[currentIndex])
                    break;
                Swap(currentIndex, parent);
                currentIndex = parent;
            }
        }

        private void HeapIfyDown(int currentIndex)
        {
            while (2 * currentIndex + 1 < len)
            {
                int l = 2 * currentIndex + 1;
                int r = 2 * currentIndex + 2;
                int m = l;
                if (r < len && numbers[r] < numbers[l])
                    m = r;
                if (numbers[currentIndex] < numbers[m])
                    break;
                Swap(currentIndex, m);
                currentIndex = m;
            }
        }

        public void Push(int x)
        {
            Capacity();
            numbers[len] = x;
            HeapIfyUp(len);
            len++;
        }

        public int Pop()
        {
            if (len == 0)
                throw new InvalidOperationException("Empty Heap");
            int minor = numbers[0];
            numbers[0] = numbers[len - 1];
            len--;
            HeapIfyDown(0);
            return minor;
        }
    }
}
