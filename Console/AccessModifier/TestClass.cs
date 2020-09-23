
namespace Lib.AccessModifier
{
    class TestClass
    {
        public TestClass()
        {
            var publicClass = new PublicClass();
            publicClass.PublicProp = 1;
            //publicClass.PrivateProp = 2;
            //publicClass.ProtectedProp = 3;
            //publicClass.InternalProp = 4;
            //publicClass.ProtectedInternalProp = 5;
            //publicClass.PrivateProtectedProp = 6;

            // var privateClass = new PrivateClass();
            //var protectedClass = new ProtectedClass();
            //var internalClass = new InternalClass();
            //var protectedInternalClass = new PublicClass.ProtectedInternalClass();
            // var PrivateProtectedClass = new PrivateProtectedClass();
        }
    }
}
