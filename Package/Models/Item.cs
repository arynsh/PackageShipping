using System.Collections.Generic;
using Package.Controllers;

namespace Package.Models
{
  public class Item
  {
    public int Length { get; set; }
    public int Width { get; set; }
    public int Height { get; set; }
    public int Weight { get; set; }
    public string Description { get; set; }
    public static List<Item> _instances = new List<Item> {};
    // public Item(string description) 
    // {
    //         Description = description;
    //         // _instances.Add(this);
    // }

    public Item (int length, int width, int height, int weight)
    {
      Length = length;
      Width = width;
      Height = height;
      Weight = weight;
      // Total = 0; 

      _instances.Add(this);
    }

    public int GetVolume()
    {
      return this.Length * this.Width * this.Height;
    }

    public int GetPrice()
    {
      return GetVolume() * this.Weight;
    }

    // public int GetTotal()
    // {
    //   int total = 0;
    //   foreach (Item instance in _instances)
    //   {
    //     total += GetPrice();
    //   }
    //   return total;
    // }

    // public Item (string description)
    // {
    //   this.Description = description;
    // }

    // public static List<Item> GetAll()
    // {
    //   return _instances;
    // }

    public static void ClearAll()
    {
      _instances.Clear();
    }

  }
}




// <ul>
//   <li>Length: @Model.Length</li>
//   <li>Width: @Model.Width</li>
//   <li>Height: @Model.Height</li>
//   <li>Weight: @Model.Weight</li>
// </ul>