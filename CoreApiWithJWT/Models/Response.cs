using System.ComponentModel.DataAnnotations;

namespace CoreApiWithJWT.Models
{
    public class Response
    {
        [Key]
        public int Id { get; set; }
        public string Status { get; set; }
        public string  Message { get; set; }
    }
}
