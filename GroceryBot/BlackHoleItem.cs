using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryBot
{
    internal class BlackHoleItem : IBlackHoleItem
    {
        public string Name { get; set; }
        public int Id { get; set; }

        public override string ToString() => Name;

        public static Task<List<IBlackHoleItem>> GetBlackHoleItems()
        {
            var dict = new Dictionary<int, string>
            {
                {3, "Carrot" },
                {28, "Sake" },
                {29, "Tomato Juice" },
                {34, "Fish" },
                {1036, "Gummy Duck" },
                {1035, "Wrench" },
                {1034, "Alien Thing" },
                {58, "Cup of Blood"  },
                {70, "Chicken Leg"},
                {71, "Toast" },
                {1013, "Painkiller" },
                {1014, "Syringe" },
                {1015, "Bio Bag" },
                {1029, "Balloon" },
                {1030, "Paint Brush" },
                {1031, "Torch" },
                {1032, "Major Tom" },
                {1033, "UFO" },
                {1, "Tea" },
                {1037, "Snake" },
                {1038, "Stick" },
                {1019, "Bolly Flower" },
                {36, "Pear" },
                {38, "Orange" },
                {39, "Pineapple" },
                {37, "Peach" }
            };

            var list = new List<IBlackHoleItem>();
            foreach (var keyValuePair in dict)
            {
                list.Add(new BlackHoleItem
                {
                    Id = keyValuePair.Key,
                    Name = keyValuePair.Value
                });
            }

            return Task.FromResult(list);
        }
    }
}
