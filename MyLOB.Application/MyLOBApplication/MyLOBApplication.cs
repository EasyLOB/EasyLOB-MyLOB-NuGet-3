using EasyLOB;
using MyLOB.Persistence;
using System;

namespace MyLOB.Application
{
    public partial class MyLOBApplication : IMyLOBApplication
    {
        #region Properties

        public IMyLOBUnitOfWork UnitOfWork { get; }

        public IDIManager DIManager { get; }

        #endregion Properties

        #region Methods

        public MyLOBApplication(IMyLOBUnitOfWork unitOfWork, IDIManager diManager)
        {
            UnitOfWork = unitOfWork;
            DIManager = diManager;
        }

        #endregion Methods

        #region Methods IDispose

        private bool disposed = false;

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                }

                disposed = true;
            }
        }

        #endregion Methods IDispose
    }
}