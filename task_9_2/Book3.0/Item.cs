namespace Book3._0
{
    internal class Item
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

        public void Return()
        {
            taken = true;
        }

        public override string ToString()
        {
            return $"\nStorage unit status: {taken}\nInventory number: {inventoryNumber}";
        }
    }
}
