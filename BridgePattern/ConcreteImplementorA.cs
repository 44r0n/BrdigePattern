using System;
namespace BridgePattern
{
    public class ConcreteImplementorA : Implementor
    {
        public void OperationImp()
        {
            Console.WriteLine("I am in ConcreteImplementorA");
        }
    }
}
