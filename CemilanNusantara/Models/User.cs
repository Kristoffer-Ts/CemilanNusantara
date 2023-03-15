
using System.ComponentModel.DataAnnotations;

namespace CemilanNusantara.Models
{
    public class user
    {// public class adalah nama dari table db nya, sedangkan dibawahnya adalah attributenya
        [Key]
        public int id { get; set; }
        [Required]
        public string nama { get; set; }
        public string email { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string address { get; set; }
        public int no_hp { get; set; }
        public int id_roles { get; set; }
        public int nama_toko { get; set; }

    }
}
