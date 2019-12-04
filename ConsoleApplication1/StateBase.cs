using System;

namespace ConsoleApplication1
{
    public abstract class StateBase : IState
    {
        protected abstract string ErrorMessage { get; }

        public virtual void DepositMoney(CopyMachine machine) => Console.WriteLine(ErrorMessage);
        public virtual void SelectDevice(CopyMachine machine) => Console.WriteLine(ErrorMessage);
        public virtual void SelectDocument(CopyMachine machine) => Console.WriteLine(ErrorMessage);
        public virtual void PrintDocument(CopyMachine machine) => Console.WriteLine(ErrorMessage);
        public virtual void PickUpMoney(CopyMachine machine) => Console.WriteLine(ErrorMessage);
    }
}