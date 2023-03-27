using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BillyGameCenter.DataAccess.Models
{
    public class PlayerInfoMode
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PlayerInfo_Id { get; set; }

        public string PlayerInfo_Name { get; set; }

        public string Image { get; set; }
    }
}