using System;

namespace ConsoleApplication1.States
{
    public class DepositWaitingState : StateBase
    {
        protected override string ErrorMessage => "Ошибка: внесите деньги.";

        public override void DepositMoney(CopyMachine machine)
        {
            Console.WriteLine("Деньги внесены.");
            machine.State = new DeviceSelectionWaitingState();
        }
    }
}