using System.ComponentModel.DataAnnotations;

namespace new_identity_api_demo.Models;

[Serializable]
public class JwtData
{
    [Required]
    public string Token { get; set; }
    [Required]
    public DateTime Expiration { get; set; }
}