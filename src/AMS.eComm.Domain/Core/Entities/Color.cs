namespace AMS.eComm.Domain.Core.Entities
{
    public class Color
    {
        #region CONSTRUCTORS
        /// <summary>
        ///CONSTRUCTORS
        /// <Author>Silva, Guilherme</Author>
        /// </summary>

        public Color(){}

        public Color(Guid id, string description , bool isActive)
        {
            Id = id;
            Description = description;
            IsActive = IsActive;
        }

        #endregion
        public Guid Id { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
    }
}