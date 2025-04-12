using OShop.DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OShop.DataLayer.Entities
{
    public class Product
    {
        public int ProductId { get; set; }
        public String ProductName { get; set; }
        public String ProductDescripton { get; set; }
        public int Views { get; set; } = 0;
        public int SellCount { get; set; } = 0;
        public DateTimeOffset PublishDate { get; set; }
        public bool IsExists { get; set; } = true;
        public double Price { get; set; }

        public bool IsDeleted { get; set; } = false;
        public bool IsPublished { get; set; } = true;
        public string Thumbnail { get; set; } = "No.png";
        public int UserId { get; set; }
        #region Relations
        public ProductGroup ProductGroup { get; set; }
        public ICollection<Gallery> Galleries { get; set; }
        public ICollection<Comment> Comments { get; set; }
        public ICollection<Question> Questions { get; set; }
        public User seller { get; set; }
        


        #endregion


    }
}
