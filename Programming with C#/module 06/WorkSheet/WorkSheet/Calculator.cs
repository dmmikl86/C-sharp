using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkSheet
{
    class Calculator : IDisposable
    {
        private bool disposed = false;

        public Calculator()
        {
            Debug.WriteLine("Calculator being created");
        }

        public int Divide(int first, int second)
        {
            return first/second;
        }

        ~Calculator()
        {
            Debug.WriteLine("Calculator being finalized");
            this.Dispose();
        }

        public void Dispose()
        {
            if (!this.disposed)
            {
                Debug.WriteLine("Calculator being disposed");
            }
            this.disposed = true;
            GC.SuppressFinalize(this);
        }
    }
}
