using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_Task5
{
 public class Character
    {
        public string Name { get; set; }
        public int Height { get; set; }
        public string Build { get; set; }
        public string HairColor { get; set; }
        public string EyeColor { get; set; }
        public string Outfit { get; set; }
        public List<string> Inventory { get; set; } = new List<string>();
        public List<string> Actions { get; set; } = new List<string>();

        public void ShowInfo()
        {
            Console.WriteLine($"Name: {Name}\nHeight: {Height} cm\nBuild: {Build}\nHair Color: {HairColor}\nEye Color: {EyeColor}\nOutfit: {Outfit}");
            Console.WriteLine("Inventory: " + string.Join(", ", Inventory));
            Console.WriteLine("Actions: " + string.Join(", ", Actions));
        }
    }
}
