namespace Lib.AccessModifier
{
    class TestInheritedClass : PublicClass
    {
        public TestInheritedClass()
        {
            PublicProp = 1;
            //PrivateProp = 2;
            ProtectedProp = 3;
            InternalProp = 4;
            ProtectedInternalProp = 5;
            PrivateProtectedProp = 6;

            var publicClass = new PublicClass();
            publicClass.PublicProp = 1;
            //publicClass.PrivateProp = 2;
            //publicClass.ProtectedProp = 3;
            publicClass.InternalProp = 4;
            publicClass.ProtectedInternalProp = 5;
            //publicClass.PrivateProtectedProp = 6;

            // var privateClass = new PrivateClass();
            var protectedClass = new ProtectedClass();
            protectedClass.PublicProp = 1;
            //protectedClass.PrivateProp = 2;
            //protectedClass.ProtectedProp = 3;
            protectedClass.InternalProp = 4;
            protectedClass.ProtectedInternalProp = 5;
            //protectedClass.PrivateProtectedProp = 6;

            var internalClass = new InternalClass();
            internalClass.PublicProp = 1;
            //internalClass.PrivateProp = 2;
            //internalClass.ProtectedProp = 3;
            internalClass.InternalProp = 4;
            internalClass.ProtectedInternalProp = 5;
            //internalClass.PrivateProtectedProp = 6;

            var protectedInternalClass = new ProtectedInternalClass();
            protectedInternalClass.PublicProp = 1;
            //protectedInternalClass.PrivateProp = 2;
            //protectedInternalClass.ProtectedProp = 3;
            protectedInternalClass.InternalProp = 4;
            protectedInternalClass.ProtectedInternalProp = 5;
            //protectedInternalClass.PrivateProtectedProp = 6;

            var PrivateProtectedClass = new PrivateProtectedClass();
            PrivateProtectedClass.PublicProp = 1;
            //PrivateProtectedClass.PrivateProp = 2;
            //PrivateProtectedClass.ProtectedProp = 3;
            PrivateProtectedClass.InternalProp = 4;
            PrivateProtectedClass.ProtectedInternalProp = 5;
            //PrivateProtectedClass.PrivateProtectedProp = 6;
        }
    }
}
