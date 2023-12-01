namespace Book5._0
{
    abstract class Item
    {
        #region Fields
        protected long inventoryNumber { get; }
        protected bool taken;
        #endregion

        #region Constructors
        public Item() : this(0, true) {}
        public Item(long inventoryNumber, bool taken)
        {
            this.inventoryNumber = inventoryNumber;
            this.taken = taken;
        }
        #endregion

        #region Methods
        public void Take()
        {
            taken = false;
        }
        abstract public void Return();
        public override string ToString()
        {
            return $"\nStorage unit status: {taken}\nInventory number: {inventoryNumber}";
        }
        #endregion
    }
}
