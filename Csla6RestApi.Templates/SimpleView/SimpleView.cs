using Csla;
using Csla.Data;
using $defaultnamespace$.Contracts;
using $defaultnamespace$.Contracts.$safeitemname$;
using Csla6RestApi.CslaExtensions.Models;
using Csla6RestApi.Dal.Contracts;

namespace $rootnamespace$
{
    /// <summary>
    /// Represents a read-only $safeitemname$ object.
    /// </summary>
    [Serializable]
    public class $safeitemname$View : ReadOnlyModel<$safeitemname$View>
    {
        #region Properties

        public static readonly PropertyInfo<long?> $safeitemname$KeyProperty = RegisterProperty<long?>(nameof($safeitemname$Key));
        public long? $safeitemname$Key
        {
            get => GetProperty($safeitemname$KeyProperty);
            private set => LoadProperty($safeitemname$KeyProperty, value);
        }

        public static readonly PropertyInfo<long?> $safeitemname$IdProperty = RegisterProperty<long?>(nameof($safeitemname$Id), RelationshipTypes.PrivateField);
        public string $safeitemname$Id
        {
            get => KeyHash.Encode(ID.$safeitemname$, $safeitemname$Key);
            private set => $safeitemname$Key = KeyHash.Decode(ID.$safeitemname$, value);
        }

        public static readonly PropertyInfo<string> $safeitemname$CodeProperty = RegisterProperty<string>(nameof($safeitemname$Code));
        public string $safeitemname$Code
        {
            get => GetProperty($safeitemname$CodeProperty);
            private set => LoadProperty($safeitemname$CodeProperty, value);
        }

        public static readonly PropertyInfo<string> $safeitemname$NameProperty = RegisterProperty<string>(nameof($safeitemname$Name));
        public string $safeitemname$Name
        {
            get => GetProperty($safeitemname$NameProperty);
            private set => LoadProperty($safeitemname$NameProperty, value);
        }

        #endregion

        #region Business Rules

        //protected override void AddBusinessRules()
        //{
        //    // Add authorization rules.
        //    BusinessRules.AddRule(
        //        new IsInRole(
        //            AuthorizationActions.ReadProperty,
        //            $safeitemname$NameProperty,
        //            "Manager"
        //            )
        //        );
        //}

        //private static void AddObjectAuthorizationRules()
        //{
        //    // Add authorization rules.
        //    BusinessRules.AddRule(
        //        typeof($safeitemname$View),
        //        new IsInRole(
        //            AuthorizationActions.GetObject,
        //            "Manager"
        //            )
        //        );
        //}

        #endregion

        #region Factory Methods

        /// <summary>
        /// Gets the specified $safeitemname$ details to display.
        /// </summary>
        /// <param name="factory">The data portal factory.</param>
        /// <param name="id">The identifier of the $safeitemname$.</param>
        /// <returns>The requested $safeitemname$ view.</returns>
        public static async Task<$safeitemname$View> Get(
            IDataPortalFactory factory,
            string id
            )
        {
            var criteria = new $safeitemname$ViewParams(id);
            return await factory.GetPortal<$safeitemname$View>().FetchAsync(criteria.Decode());
        }

        #endregion

        #region Data Access

        [Fetch]
        private void Fetch(
            $safeitemname$ViewCriteria criteria,
            [Inject] I$safeitemname$ViewDal dal
            )
        {
            // Set values from data access object.
            $safeitemname$ViewDao dao = dal.Fetch(criteria);
            DataMapper.Map(dao, this);
        }

        #endregion
    }
}
