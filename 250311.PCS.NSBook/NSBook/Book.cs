namespace NSBooks
{
    public class Book : IBook
    {
        private static int Count = 0;
        private int _ID;
        private string _Name;
        private DateTime _PublishDate;
        private string _Author;
        private string _Language;
        private float _AveragePrice;

        public int ID 
        { 
            get
            {
                return _ID;
            }
        }
        public string Name
        {
            get 
            {
                return _Name;
            }
            set 
            {
                Name = value;
            }
        }
        public DateTime PublishDate
        {
            get
            {
                return _PublishDate;
            }
            set
            {
                PublishDate = value;
            }
        }
        public string Author
        {
            get
            {
                return _Author;
            }
            set
            {
                Author = value;
            }
        }
        public string Language
        {
            get
            {
                return _Language;
            }
            set
            {
                Language = value;
            }
        }

        public float AveragePrice { get { return _AveragePrice; } }


        public Book(string name, DateTime publishDate, string author, string language)
        {
            Count++;
            _ID = Count;
            _Name = name;
            _PublishDate = publishDate;
            _Author = author;
            _Language = language;
        }

        public void Display()
        {
            Console.WriteLine($"ID: {ID}, Name: {Name}, Publish Date: {PublishDate}, Author: {Author}, Language: {Language}, Average Price: {AveragePrice}");
        }


        private int?[] PriceList = new int?[5];

        public int? this[int index]
        {
            get
            {
                if (index >= 0 && index < PriceList.Length)
                {
                    return PriceList[index];
                }
                else
                {
                    throw new IndexOutOfRangeException();
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
                if (price.HasValue)
                {
                    sum += price.Value;
                    count++;
                }
            }
            _AveragePrice = (count > 0) ? (float)(sum / count) : 0;
        }
    }
}
