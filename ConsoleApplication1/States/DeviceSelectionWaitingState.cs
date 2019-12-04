using System;

namespace ConsoleApplication1.States
{
    public class DeviceSelectionWaitingState : StateBase
    {
        protected override string ErrorMessage => "Ошибка: устройство не выбрано.";

        public override void SelectDevice(CopyMachine machine)
        {
            Console.WriteLine("Устройство выбрано.");
            machine.State = new DocumentSelectionWaitingState();
        }

        public override void PickUpMoney(CopyMachine machine)
        {
            Console.WriteLine("Деньги возвращены.");
            machine.State = new DepositWaitingState();
        }
    }
}