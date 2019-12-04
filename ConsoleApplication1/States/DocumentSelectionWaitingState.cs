using System;

namespace ConsoleApplication1.States
{
    public class DocumentSelectionWaitingState : StateBase
    {
        protected override string ErrorMessage => "Ошибка: документ не выбран.";

        public override void SelectDocument(CopyMachine machine)
        {
            Console.WriteLine("Документ выбран.");
            machine.State = new DocumentPrintWaitingState();
        }
    }
}