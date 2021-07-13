namespace Meals_WebApi.Models
{
  public class Meal
  {
    public Meal(){}

    public Meal(int id, string name, string area, string category, string instructions)
    {
      this.Id = id;
      this.Name = name;
      this.Area = area;
      this.Category = category;
      this.Instructions = instructions;
    }

    public int Id { get; set; }

    public string Name { get; set; }

    public string Category { get; set; }

    public string Area { get; set; }

    public string Instructions { get; set; }
  }
}