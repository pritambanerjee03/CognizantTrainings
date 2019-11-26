namespace IndexerLab1
{
    internal class IndexNames
    {
        internal int Size;
        private string[] arr;

        public IndexNames(int size)
        {
            Size = size;
            arr = new string[size];

            for (int i = 0; i < size; i++)
            {
                arr[i] = "NA";
            }
        }
        public string this[int index]
        {
            get
            {
                if (index >=0 && index < Size)
                {
                    return arr[index];
                }
                return "NA";
            }
            set
            {
                if (index >=0 && index < Size)
                {
                    arr[index] = value;
                }
            }
        }
    }
}