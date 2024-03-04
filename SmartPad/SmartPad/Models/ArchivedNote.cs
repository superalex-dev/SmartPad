using System.ComponentModel.DataAnnotations;

namespace SmartPad.Models;

public class ArchivedNote
{
    [Key]
    public int Id { get; set; }
    public string? Content { get; set; }
    public DateTime? CreationDate { get; set; }
    public DateTime? ArchiveDate { get; set; }
}