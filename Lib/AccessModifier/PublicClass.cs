﻿using System;

namespace Lib
{
    public class PublicClass
    {
        public PublicClass()
        {
            PublicProp = 1;
            PrivateProp = 2;
            ProtectedProp = 3;
            InternalProp = 4;
            ProtectedInternalProp = 5;
            PrivateProtectedProp = 6;

            var publicClass = new PublicClass();
            publicClass.PublicProp = 1;
            publicClass.PrivateProp = 2;
            publicClass.ProtectedProp = 3;
            publicClass.InternalProp = 4;
            publicClass.ProtectedInternalProp = 5;
            publicClass.PrivateProtectedProp = 6;

            var privateClass = new PrivateClass();
            privateClass.PublicProp = 1;
            //privateClass.PrivateProp = 2;
            //privateClass.ProtectedProp = 3;
            privateClass.InternalProp = 4;
            privateClass.ProtectedInternalProp = 5;
            //privateClass.PrivateProtectedProp = 6;

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

        public int PublicProp { get; set; }
        private int PrivateProp { get; set; }
        protected int ProtectedProp { get; set; }
        internal int InternalProp { get; set; }
        protected internal int ProtectedInternalProp { get; set; }
        private protected int PrivateProtectedProp { get; set; }

        private class PrivateClass
        {
            public int PublicProp { get; set; }
            private int PrivateProp { get; set; }
            protected int ProtectedProp { get; set; }
            internal int InternalProp { get; set; }
            protected internal int ProtectedInternalProp { get; set; }
            private protected int PrivateProtectedProp { get; set; }
        }

        protected class ProtectedClass
        {
            public int PublicProp { get; set; }
            private int PrivateProp { get; set; }
            protected int ProtectedProp { get; set; }
            internal int InternalProp { get; set; }
            protected internal int ProtectedInternalProp { get; set; }
            private protected int PrivateProtectedProp { get; set; }
        }

        protected internal class ProtectedInternalClass
        {
            public int PublicProp { get; set; }
            private int PrivateProp { get; set; }
            protected int ProtectedProp { get; set; }
            internal int InternalProp { get; set; }
            protected internal int ProtectedInternalProp { get; set; }
            private protected int PrivateProtectedProp { get; set; }
        }
        private protected class PrivateProtectedClass
        {
            public int PublicProp { get; set; }
            private int PrivateProp { get; set; }
            protected int ProtectedProp { get; set; }
            internal int InternalProp { get; set; }
            protected internal int ProtectedInternalProp { get; set; }
            private protected int PrivateProtectedProp { get; set; }
        }
    }
}
