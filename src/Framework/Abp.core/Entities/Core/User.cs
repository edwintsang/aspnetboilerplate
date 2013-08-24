namespace Abp.Entities.Core
{
    /// <summary>
    /// Represents a user in entire system.
    /// </summary>
    public class User : Entity<int>
    {
        /// <summary>
        /// Email address of the user.
        /// </summary>
        public virtual string EmailAddress { get; set; }

        /// <summary>
        /// Password of the user.
        /// </summary>
        public virtual string Password { get; set; }
    }
}