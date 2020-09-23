
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
            publicClass.InternalProp = 4;
            publicClass.ProtectedInternalProp = 5;
            //publicClass.PrivateProtectedProp = 6;

            // var privateClass = new PrivateClass();
            //var protectedClass = new ProtectedClass();
 
            var internalClass = new InternalClass();
            internalClass.PublicProp = 1;
            //internalClass.PrivateProp = 2;
            //internalClass.ProtectedProp = 3;
            internalClass.InternalProp = 4;
            internalClass.ProtectedInternalProp = 5;
            //internalClass.PrivateProtectedProp = 6;

            var protectedInternalClass = new PublicClass.ProtectedInternalClass();
            protectedInternalClass.PublicProp = 1;
            //protectedInternalClass.PrivateProp = 2;
            //protectedInternalClass.ProtectedProp = 3;
            protectedInternalClass.InternalProp = 4;
            protectedInternalClass.ProtectedInternalProp = 5;
            //protectedInternalClass.PrivateProtectedProp = 6;

            // var PrivateProtectedClass = new PrivateProtectedClass();
        }
    }
}
