namespace NSBooks
{
    public class Book:IBook
    {
        private static int Count = 0;
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime PublishDate { get; set; }
        public string Author { get; set; }
        public string Language { get; set; }
        
        public float _AveragePrice;
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
            Console.WriteLine ($"Name: {Name}, Publish Date: {PublishDate}, Author: {Author}, Language: {Language}, Average Price: {AveragePrice}");
        }


        private static int?[] PriceList = new int?[5];

        float IBook.this[int id] { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
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
            set { PriceList[index] = value; }
        }

        public void Calculate()
        {
            //if () throw new ArgumentNullException("Price list not has any element");
            float? sum = 0;
            int count = 0;
            foreach (float? price in PriceList) 
            {
                count++;
                sum += price;
            }
            _AveragePrice = (float)sum / count;
        }
    }
}
