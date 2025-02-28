namespace _250226.test
{
    public class Book : IBook
    {
        private static int _Count = 0;

        private string _ID;
        public string ID
        {
            get { return _ID; }
        }

        private string _Name;
        public string Name 
        {
            get { return _Name; }
            set { Name = value; }
        }

        private string _AuthorName;
        public string AuthorName
        {
            get { return _AuthorName; }
            set { AuthorName = value; }
        }

        private string _Subject;
        public string Subject
        {
            get { return _Subject; }
            set { Subject = value; }
        }

        private double _BuyingPrice;
        public double BuyingPrice
        {
            get { return _BuyingPrice; }
            set { BuyingPrice = value; }
        }

        private double _SellingPrice;
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
            _ID = "B00".Substring(0, 4-_Count.ToString().Length) + _Count.ToString();
            //if (_Count < 10)
            //{
            //    ID = "B00" + _Count;
            //}
            //else
            //{
            //    if (_Count < 100)
            //    {
            //        ID = "B0" + _Count;
            //    }
            //    else
            //    {
            //        ID = "B" + _Count;
            //    }
            //}
        }
    }
}
