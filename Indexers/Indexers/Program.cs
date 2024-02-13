namespace Indexers
{
    class Program
    {
        static void Main(string[] args)
        {
            //var ip = new IP(192, 155, 55, 20);
            var ip = new IP("192.155.55.20");

            Console.WriteLine(ip.Address);
            Console.WriteLine(ip[0]);
        }
    }


    class IP
    {
        private int[] segments = new int[4];

        public int this[int index]        
        { get
            {
                return segments[index];
            }
            
            set
            { segments[index] = value; }
        }

        public IP(int segment1,int segment2,int segment3,int segment4)
        {
            segments[0] = segment1;
            segments[1] = segment2;
            segments[2] = segment3;
            segments[3] = segment4;
        }

        public IP(string address)
        {
            var segs = address.Split('.');

            for (int i = 0; i < segs.Length; i++)
            {
                segments[i] = Convert.ToInt32(segs[i]);
            }
        }

        public string Address=>string.Join(".", segments);
    }

}
