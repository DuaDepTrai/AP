namespace OnlineBookShop
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
                _Name = value;
            }
        }
        public string AuthorName
        {
            get
            {
                return _AuthorName;
            }
            set
            {
                _AuthorName = value;
            }
        }
        public string Subject
        {
            get
            {
                return _Subject;
            }
            set
            {
                _Subject = value;
            }
        }
        public double BuyingPrice
        {
            get
            {
                return _BuyingPrice;
            }
            set
            {
                _BuyingPrice = value;
            }
        }
        public double SellingPrice
        {
            get
            {
                return _SellingPrice;
            }
            set
            {
                _SellingPrice = value;
            }
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

        public void SetDetail(string name, string authorname, string subject, double buyingprice)
        {
            _Name = name;
            _AuthorName = authorname;
            _Subject = subject;
            _BuyingPrice = buyingprice;
            _SellingPrice = buyingprice * 1.3;
        }

        public void SetSellingPrice(double newSellingPrice)
        {
            _SellingPrice = newSellingPrice;
        }

        public void ShowDetail()
        {
            Console.WriteLine($"Name: {Name}, Author Name: {AuthorName}, Subject: {Subject}, Buying Price: {BuyingPrice}, Selling Price: {SellingPrice}");
        }

    }
}
