using System.Collections.Generic;

namespace Csla6RestApi.Models
{
    /// <summary>
    /// Defines the helper functions of read-only lists.
    /// </summary>
    public interface IReadOnlyList
    {
        IList<T> ToDto<T>() where T : class;
    }
}
