
using System.ComponentModel.DataAnnotations;

namespace Fluent.API.DAL.Entities
{
    public class Review
    {
        public const int NameLength = 100;

        public int ReviewId { get; set; }

        [MaxLength(NameLength)]
        public string VoterName { get; set; }

        public int NumStars { get; set; }
        public string Comment { get; set; }

        //-----------------------------------------
        //Relationships

        public int BookId { get; set; }
    }

}