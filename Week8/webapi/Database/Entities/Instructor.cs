using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

[Table("instructor")]
public class Instructor
{
    [Column("instructor_id")]
    [Key]
    public long instructor_id {get; set;}

    [Column("fname")]
    public string fname {get; set;}

    [Column("mname")]
    public string mname {get; set;}

    [Column("lname")]
    public string lname {get; set;}

}