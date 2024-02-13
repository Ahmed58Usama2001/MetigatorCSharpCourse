namespace Extension_Methods
{
    internal class Pizza
    {
        public string Content { get; set; }
        public decimal TotalPrice { get; set; }

        public Pizza AddSauce()
        {
            this.Content += $"\nTOMATO SAUCE X $2.00";
            this.TotalPrice += 2m;
            return this;
        }
        public override string ToString()
        {
            return $"{Content}\n-----------------------\nTotal Price: ${TotalPrice.ToString("#.##")}";
        }
    }
}
