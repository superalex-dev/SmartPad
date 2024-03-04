using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace SmartPad.Models;

public class ActiveNote
{
    [Key]
    public int Id { get; set; }
    public string? Content { get; set; }
    public DateTime? CreationDate { get; set; }
}