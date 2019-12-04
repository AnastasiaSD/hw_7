namespace ConsoleApplication1
{
    public interface IState
    {
        void DepositMoney(CopyMachine machine);
        void SelectDevice(CopyMachine machine);
        void SelectDocument(CopyMachine machine);
        void PrintDocument(CopyMachine machine);
        void PickUpMoney(CopyMachine machine);
    }
}