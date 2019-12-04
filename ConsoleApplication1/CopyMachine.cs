using ConsoleApplication1.States;

namespace ConsoleApplication1
{
    public class CopyMachine
    {
        public IState State { get; set; }

        public CopyMachine()
        {
            State = new DepositWaitingState();
        }

        public void DepositMoney() => State.DepositMoney(this);
        public void SelectDevice() => State.SelectDevice(this);
        public void SelectDocument() => State.SelectDocument(this);
        public void PrintDocument() => State.PrintDocument(this);
        public void PickUpMoney() => State.PickUpMoney(this);
    }
}