namespace Book5._0
{
    internal class Magazine : Item , IPubs
    {
        #region Fields
        private string volume;
        private int number;
        private string title;
        private int year;
        #endregion

        #region Constructors
        public Magazine()
        {
            
        }

        public Magazine(string volume, int number, string title, int year, long inventoryNumber, bool taken) : base(inventoryNumber, taken)
        {
            this.volume = volume;
            this.number = number;
            this.title = title;
            this.year = year;
        }

        public bool isSubscription { get; set; }
        #endregion

        #region Methods
        public override void Return()
        {
            taken = true;
        }

        public (string title, bool isSubscription) subscription()
        {
            return (title, isSubscription);
        }

        public override string ToString()
        {
            return $"\nMagazine:\nVolume: {volume}\nNumber: {number}\nTitle: {title}\nPublished: {year}" + base.ToString();
        }
        #endregion
    }
}
