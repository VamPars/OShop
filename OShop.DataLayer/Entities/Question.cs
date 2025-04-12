
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OShop.DataLayer.Entities
{
    public class Question
    {
        public int QuestionId { get; set; }
        public string QuestionTitle { get; set; }
        public string QuestionMessage { get; set; }
        public int? SenderId { get; set; }
        public DateTimeOffset QuestedAt { get; set; }
        public bool IsAnswerd { get; set; } = false;
        public string? Answer { get; set; } = null;
        #region Relations
        public User? Questioner { get; set; }
        public Product Product { get; set; }


        #endregion


    }
}
