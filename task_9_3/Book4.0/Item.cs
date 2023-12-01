namespace Book4._0
{
    abstract class Item
    {
        protected long inventoryNumber { get; }
        protected bool taken;
        public Item() : this(0, true) {}
        public Item(long inventoryNumber, bool taken)
        {
            this.inventoryNumber = inventoryNumber;
            this.taken = taken;
        }
        public void Take()
        {
            taken = false;
        }
        abstract public void Return();

        public override string ToString()
        {
            return $"\nStorage unit status: {taken}\nInventory number: {inventoryNumber}";
        }
    }
}
