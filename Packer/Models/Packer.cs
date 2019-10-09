using System.Collections.Generic;

namespace Packer.Models
{
    public class PackList
    {
        public string Item { get; set; }
        public bool IsPurchased { get; set; }
        private static List<PackList> _instances = new List<PackList> {};

    public PackList (string item, bool isPurchased)
    {
        Item = item;
        IsPurchased = isPurchased;
        _instances.Add(this);
    }

     public static void ClearAll()
    {
      _instances.Clear();
    }

    public static List<PackList> GetAll()
    {
      return _instances;
    }

  

    }

}