namespace Csla6RestApi.Models
{
    /// <summary>
    /// Defines the helper functions of read-only models.
    /// </summary>
    public interface IReadOnlyModel
    {
        T ToDto<T>() where T : class;
    }
}
