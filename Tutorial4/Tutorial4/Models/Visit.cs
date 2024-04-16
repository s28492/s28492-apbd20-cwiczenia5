using System.Runtime.InteropServices.JavaScript;

namespace Tutorial4.Models;

public class Visit
{
    public DateTime VisitDay { get; set; }
    public Animal VisitingAnimal { get; set; }
    public string Description  { get; set; }
    public double?  Cost { get; set; }
}