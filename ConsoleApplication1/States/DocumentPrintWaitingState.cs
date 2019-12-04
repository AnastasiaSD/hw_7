using System;

namespace ConsoleApplication1.States
{
    public class DocumentPrintWaitingState : StateBase
    {
        protected override string ErrorMessage => "Ошибка: документ ожидает начала печати.";

        public override void PrintDocument(CopyMachine machine)
        {
            Console.WriteLine("Печать начата.");
            machine.State = new PickUpMoneyWaitingState();
        }
    }
}