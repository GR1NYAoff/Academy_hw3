using System.Collections;

namespace Hw3.Exercise3
{
    public class MyAwesomeList<T> : IEnumerable<T>
    {
        private T[] _array = Array.Empty<T>();

        public T this[int index]
        {
            get => _array[index];
            set => _array[index] = value;
        }
        public int Count => _array.Length;

        public MyAwesomeList(int _ = 1)
        {
        }

        public T GetByIndex(int index)
        {
            return index >= 0 && index < _array.Length ? _array[index] : throw new ArgumentOutOfRangeException(nameof(index));

        }

        public void DeleteByIndex(int index)
        {
            if (index >= 0 && index < _array.Length)
            {
                var newArray = new T[_array.Length - 1];

                for (var i = 0; i < index; i++)
                {
                    newArray[i] = _array[i];
                }

                for (var i = index; i < newArray.Length; i++)
                {
                    newArray[i] = _array[i + 1];
                }
                _array = newArray;
            }
            else
            {
                throw new ArgumentOutOfRangeException(nameof(index));
            }
        }

        public bool DeleteAllElements()
        {
            _array = Array.Empty<T>();
            return _array.Length == 0;
        }

        public void Add(T element)
        {
            var newArray = new T[_array.Length + 1];

            for (var i = 0; i < _array.Length; i++)
            {
                newArray[i] = _array[i];
            }

            newArray[_array.Length] = element;

            _array = newArray;
        }

        public void InsertAt(T element, int index)
        {
            if (index >= 0 && index < _array.Length)
            {
                var newArray = new T[_array.Length + 1];

                for (var i = 0; i < index; i++)
                {
                    newArray[i] = _array[i];
                }
                newArray[index] = element;

                for (var i = index; i < _array.Length; i++)
                {
                    newArray[i + 1] = _array[i];
                }

                _array = newArray;

            }
            else if (index >= _array.Length)
            {
                var newArray = new T[_array.Length + (index + 1 - _array.Length)];
                for (var i = 0; i < _array.Length; i++)
                {
                    newArray[i] = _array[i];
                }


                for (var i = 0; i < index; i++)
                {
                    newArray[i] = element;
                }

                newArray[index] = element;
                _array = newArray;
            }
            else
            {
                throw new ArgumentOutOfRangeException(nameof(index));
            }
        }

        public bool Contains(T value)
        {
            return _array.Contains(value);
        }

        public IEnumerator GetEnumerator()
        {
            for (var i = 0; i < _array.Length; i++)
                yield return _array[i];
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            for (var i = 0; i < _array.Length; i++)
                yield return _array[i];
        }
    }
}
