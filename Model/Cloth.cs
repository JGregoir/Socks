using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Socks.Model
{
    public class Cloth
    {
        public Cloth(int id, string name, string size, string color)
        {
            Id = id;
            Name = name;
            Size = size;
            Color = color;
        }

        public int Id { get; set; }
		public string Name { get; set; }
		public string Size { get; set; }
		public string Color { get; set; }

        public override string ToString()
        {
            return $"Cloth: Name:{Name}, Size:{Size}, Color:{Color}";
        }

		public override bool Equals(object? obj)
		{
			return 
                obj is Cloth && Name == ((Cloth)obj).Name && Size == ((Cloth)obj).Size && Color == ((Cloth)obj).Color;
		}
	}
}
