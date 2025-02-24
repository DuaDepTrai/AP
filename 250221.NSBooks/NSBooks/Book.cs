namespace NSBooks
{
    public class Book:IBook
    {
        private static int Count = 0;
        public int ID { get; }
        public string Name { get; set; }
        public DateTime PublishDate { get; set; }
        public string Author { get; set; }
        public string Language { get; set; }
        
        private float _AveragePrice;
        public float AveragePrice { get { return _AveragePrice; } }


        public Book (string name, DateTime publishDate, string author, string language)
        {
            Count++;
            ID = Count;
            Name = name;
            PublishDate = publishDate;
            Author = author;
            Language = language;
        }

        public void Display()
        {
            Console.WriteLine ($"ID: {ID}, Name: {Name}, Publish Date: {PublishDate}, Author: {Author}, Language: {Language}, Average Price: {AveragePrice}");
        }


        private int?[] PriceList = new int?[5];

        public int? this[int index]
        {
            get 
            { 
                if ( index >=0 && index < PriceList.Length )
                {
                    return PriceList[index];
                }
                else
                {
                    throw new IndexOutOfRangeException ();
                }
            }
            set 
            {
                if (index >= 0 && index < PriceList.Length)
                {
                    PriceList[index] = value;
                }
                else 
                {
                    throw new IndexOutOfRangeException();
                }
            }
        }

        public void Calculate()
        {
            if (PriceList.All(price => price == null)) 
            {
                Console.WriteLine("Price list is empty, cannot calculate average price");
                return;
            }

            float sum = 0;
            int count = 0;
            foreach (float? price in PriceList) 
            {
                if (price.HasValue) { 
                    sum += price.Value;
                    count++;
                }
            }
            _AveragePrice =  (count > 0) ? (float)(sum / count) : 0;
        }
    }
}
