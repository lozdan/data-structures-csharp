using System;

namespace DataStructure
{
    public class MyList<T> where T : IComparable<T>
    {
        private T[] values;
        private int length;

        public MyList()
        {
            values = new T[10];
            length = 0;
        }

        public int Length
        {
            get
            {
                return length;
            }
        }

        public T[] Values
        {
            get
            {
                return values;
            }
        }

        public T this[int a]
        {
            get
            {
                if (a > -1 && a > length - 1 || a < 0 && length + a < 0)
                    throw new IndexOutOfRangeException();
                else if (a > -1)
                    return values[a];
                else
                    return values[length + a];
            }

            set
            {
                if (a > -1 && a > length - 1 || a < 0 && length + a < 0)
                    throw new IndexOutOfRangeException();
                if (a > -1)
                    values[a] = value;
                else
                    values[length + a] = value;
            }
        }

        private void Capacity(int newElements)
        {
            if (length + newElements >= values.Length)
            {
                int factor = 1;
                while (length + newElements >= values.Length * factor)
                    factor = factor << 1;
                Array.Resize(ref values, values.Length * factor);
            }
        }

        public void Add(T value)
        {
            Capacity(1);
            values[length] = value;
            length++;
        }

        public void Insert(T value, int index)
        {
            Capacity(1);
            for (int i = length; i > index; i--)
                values[i] = values[i - 1];

            values[index] = value;
        }

        public void Remove(int index)
        {
            if (index >= length)
            {
                throw new IndexOutOfRangeException();
            }

            for (int i = index; i < length; i++)
            {
                values[i] = values[i + 1];
            }
            length--;
        }

        public bool Contains(T value)
        {
            for (int i = 0; i < length; i++)
            {
                if (values[i].CompareTo(value) == 0)
                    return true;
            }
            return false;

        }

        public void AddRange(T[] sequence)
        {
            int prevLength = length;
            Capacity(sequence.Length);
            length += sequence.Length;
            int count = 0;
            for (int i = prevLength; i < length; i++)
            {
                values[i] = sequence[count];
                count++;
            }
        }

        public void RemoveAll(T value)
        {
            int i = 0;
            while (i < length)
            {
                if (values[i].CompareTo(value) == 0)
                {
                    for (int j = i; j < length; j++)
                    {
                        values[j] = values[j + 1];
                    }
                    length--;
                    i--;
                }
                i++;
            }
        }
    }
}
