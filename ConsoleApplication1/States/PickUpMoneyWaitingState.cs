using System;

namespace ConsoleApplication1.States
{
    public class PickUpMoneyWaitingState : StateBase
    {
        protected override string ErrorMessage => "Ошибка: не забрали сдачу.";

        public override void PickUpMoney(CopyMachine machine)
        {
            Console.WriteLine("Сдача выдана.");
            machine.State = new DepositWaitingState();
        }
        
        public override void SelectDocument(CopyMachine machine)
        {
            Console.WriteLine("Документ выбран.");
            machine.State = new DocumentPrintWaitingState();
        }
    }
}