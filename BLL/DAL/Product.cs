#nullable disable   // It allows you to remove question marks for nullable attributes
using System.Reflection.Emit;
using System.Runtime.InteropServices.JavaScript;

namespace BLL.DAL;
public class Product
{
    // THIS IS THE JAVA VAY TO IMPLEMENT BASIC GET SET.
    
    // private int id;
    //
    // public void setId(int id)
    // {
    //     this.id = id;
    // }
    //
    // public int getId()
    // {
    //     return this.id;
    // }
    
    
    // THIS IS THE C# WAY TO IMPLEMENT BASIC GET SET.
    // In C# if you do not assign any values on numeric types,
    // the default values will be 0.
    // Property
    public int Id { get; set; }
    public string Name { get; set; }                 // In C#, if a variable can be nullable, then you should add question marks to make it nullable.
    public double OldUnitPrice { get; set; }         // (Will not be used) Like in C++, in C# double is also precision dependent.
    public decimal UnitPrice { get; set; }           // This is why it is better to use decimal type
    public DateTime ExpirationDate { get; set; }
    public int CategoryId { get; set; }
    public int StockAmount { get; set; }
    public Category Category { get; set; }          // Is this something like composition??? 
}