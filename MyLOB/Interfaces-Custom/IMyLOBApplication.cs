using EasyLOB;
using System;

namespace MyLOB
{
    public interface IMyLOBApplication : IDisposable
    {
        #region Properties

        IDIManager DIManager { get; }

        #endregion Properties
    }
}