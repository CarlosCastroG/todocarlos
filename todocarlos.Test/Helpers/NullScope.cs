using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace todocarlos.Test.Helpers
{
    public class NullScope : IDisposable
    {
        public static NullScope Instance { get; } = new NullScope();

        private NullScope() { }

        public void Dispose(){ }
    }
}
