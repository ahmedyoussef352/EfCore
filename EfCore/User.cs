namespace EfCore;

public class User
{
    public int Id { get; set; }   //Id
    public string Name { get; set; } = null!;
    public decimal? Salary { get; set; }
    public bool IsDeleted { get; set; }
    public string Address { get; set; } = null!;
    public int Test1 { get; set; }
    public int Test2 { get; set; }
    //public byte IsMail { get; set; }

}
