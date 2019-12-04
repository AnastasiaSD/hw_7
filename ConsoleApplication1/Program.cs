namespace ConsoleApplication1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var copyMachine = new CopyMachine();
            copyMachine.SelectDevice();
            copyMachine.DepositMoney();
            copyMachine.PrintDocument();
            copyMachine.SelectDevice();
            copyMachine.DepositMoney();
            copyMachine.SelectDocument();
            copyMachine.DepositMoney();
            copyMachine.PrintDocument();
            copyMachine.DepositMoney();
            copyMachine.SelectDocument();
            copyMachine.PrintDocument();
            copyMachine.PickUpMoney();
            copyMachine.DepositMoney();
            copyMachine.PickUpMoney();
        }
    }
}