using System;
using System.Collections.Generic;
using System.Text;

namespace Packt.Shared
{
    public partial class Person
    {
        //a readonly property defined using C# 1 - 5 syntax
        public string Origin
        {
            get
            {
                return string.Format("{0} was born on {1}",
                    arg0: Name,
                    arg1: HomePlanet);
            }
        }

        //two readonly properties defined using C# lambda expression body syntax
        public string Greeting => $"{Name} says 'Hello!'";
        public int Age => DateTime.Today.Year - DateOfBirth.Year;

        //a read write property defined using C# 3.0 syntax
        public string? FavoriteIceCream { get; set; }

        //a private field to store the property value
        private string? favoritePrimaryColor;

        //a public property to read and write to the field
        public string? FavoritePrimaryColor
        {
            get
            {
                return favoritePrimaryColor;
            }
            set
            {
                switch (value?.ToLower())
                {
                    case "red":
                    case "green":
                    case "blue":
                        favoritePrimaryColor = value;
                        break;
                    default:
                        throw new ArgumentException($"{value} is not a primary color. Choose from: red, green, blue.");
                }
            }
        }
    }
}
