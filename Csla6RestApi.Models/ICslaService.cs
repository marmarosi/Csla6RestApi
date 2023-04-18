using Csla;
using Csla6RestApi.Dal;

namespace Csla6RestApi.CslaExtensions
{
    /// <summary>
    /// Defines the CSLA helper service.
    /// </summary>
    public interface ICslaService
    {
        /// <summary>
        /// Gets the CSLA data portal factory.
        /// </summary>
        public IDataPortalFactory Factory { get; }

        /// <summary>
        /// Gets the CSLA child data portal factory.
        /// </summary>
        public IChildDataPortalFactory ChildFactory { get; }

        /// <summary>
        /// Gets the deadlock detector service.
        /// </summary>
        public IDeadLockDetector DeadLock { get; }
    }
}
