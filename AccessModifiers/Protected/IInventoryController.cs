namespace AccessModifiers.Protected
{
    public interface IInventoryController
    {
        public void PushInventoryItem(InventoryItem item);
        protected InventoryItem PullInventoryItem(int id);
    }
}
