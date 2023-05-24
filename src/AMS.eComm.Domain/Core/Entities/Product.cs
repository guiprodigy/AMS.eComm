using System;
using System.Text;
namespace AMS.eComm.Domain.Core.Entities
{
    public class Product
    {
        
        #region CONSTRUCTORS
        /// <summary>
        ///CONSTRUCTORS
        /// <Author>Silva, Guilherme</Author>
        /// </summary>

        public Product(Guid id, string description, decimal price, 
        Guid colorId, Guid categoryId, bool isActive) 
        {
            Id = id;
            Description = description;
            Price = price;
            ColorId = colorId;
            CategoryId = categoryId;
            IsActive = isActive;
        }

        #endregion

        public Guid Id { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public Guid ColorId { get; set; }
        public Guid CategoryId { get; set; }
        public bool  IsActive {get; set;}
    }
}