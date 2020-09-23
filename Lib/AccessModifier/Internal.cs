namespace Lib
{
    internal class InternalClass
    {
        public int PublicProp { get; set; }
        private int PrivateProp { get; set; }
        protected int ProtectedProp { get; set; }
        internal int InternalProp { get; set; }
        protected internal int ProtectedInternalProp { get; set; }
        private protected int PrivateProtectedProp { get; set; }
    }
}
