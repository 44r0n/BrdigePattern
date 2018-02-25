using System;
namespace BridgePattern
{
    public class ConcreteImplementorB : Implementor
    {
        public void OperationImp()
        {
            Console.WriteLine("I am in ConcreteImplementorB");
        }
    }
}
