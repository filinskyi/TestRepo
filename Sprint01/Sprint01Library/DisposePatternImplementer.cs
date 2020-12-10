using System;

namespace Sprint01Library
{
    public class DisposePatternImplementer : CloseableResource, IDisposable
    {
        private bool disposedValue;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                // Console.WriteLine(disposing? "Disposing by developer": "Disposing by GC");
                if (disposing)
                {
                    Console.WriteLine("Disposing by developer");
                }
                else
                {
                    Console.WriteLine("Disposing by GC");
                }
                disposedValue = true;
                Close();
            }
        }
        ~DisposePatternImplementer()
        {

            Dispose(disposing: false);
        }
        public void Dispose()
        {

            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
