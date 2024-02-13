namespace Enumerators_Iterators
{
    class Temperature :IComparable
    {
        private int _value;

        public int Value => _value;

        public Temperature(int value)
        {
            _value = value;
        }

        public int CompareTo(object? obj)
        {
            if (obj == null)
                return 1;

            var temp=obj as Temperature;

            if (temp == null)
                throw new ArgumentException("Object is not a temprature");

            return this.Value.CompareTo(temp.Value);
        }
    }

}
