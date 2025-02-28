namespace _250226.test
{
    public class Book : IBook
    {
        private static int _Count = 0;
        private string _ID;
        private string _Name;
        private string _AuthorName;
        private string _Subject;
        private double _BuyingPrice;
        private double _SellingPrice;
        public string ID
        {
            get { return _ID; }
        }

        public string Name 
        {
            get { return _Name; }
            set { Name = value; }
        }
        public string AuthorName
        {
            get { return _AuthorName; }
            set { AuthorName = value; }
        }
        public string Subject
        {
            get { return _Subject; }
            set { Subject = value; }
        }
        public double BuyingPrice
        {
            get { return _BuyingPrice; }
            set { BuyingPrice = value; }
        }
        public double SellingPrice
        {
            get { return _SellingPrice; }
            set { SellingPrice = value; }
        }

        public void SetDetail(string name, string authorName, string subject, double buyingPrice)
        {
            _Name = name;
            _AuthorName = authorName;
            _Subject = subject;
            _BuyingPrice = buyingPrice;
            _SellingPrice = buyingPrice*1.3;
        }

        public void SetSellingPrice(double newSellingPrice)
        {
            _SellingPrice = newSellingPrice;
        }

        public void ShowDetail()
        {
            Console.WriteLine($"ID: {ID}, Name: {Name}, Author: {AuthorName}, " +
                $"Subject: {Subject}, Buying Price: {BuyingPrice}, Selling Price: {SellingPrice}");
        }

        public Book()
        {
            _Count++;
            if (_Count < 10)
            {
                _ID = "B00" + _Count;
            }
            else
            {
                if (_Count < 100)
                {
                    _ID = "B0" + _Count;
                }
                else
                {
                    _ID = "B" + _Count;
                }
            }
        }
    }
}
