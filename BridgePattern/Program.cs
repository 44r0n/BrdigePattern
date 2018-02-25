using System;

namespace BridgePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Abstraction operatorObj = new RefinedAbstraction();
            operatorObj.SetImplementor(new ConcreteImplementorA());
            operatorObj.Operation();
            operatorObj.SetImplementor(new ConcreteImplementorB());
            operatorObj.Operation();
        }
    }
}
