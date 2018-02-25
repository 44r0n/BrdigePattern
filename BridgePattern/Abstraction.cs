namespace BridgePattern
{
    public abstract class Abstraction
    {
        private Implementor implementor;

        public void Operation()
        {
            implementor.OperationImp();
        }

        public void SetImplementor(Implementor implementor)
        {
            this.implementor = implementor;
        }
    }
}
