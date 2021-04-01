using System.Threading.Tasks;

namespace ASP.NET.EXR2.Models
{
    public class Information
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Wife { get; set; }
        public string FavoriteIceCream { get; set; }
        public string Dog { get; set; }
        public string DogBreed { get; set; }

        //public static Information[] GetInformation()
        //{
        //    Information samer = new()
        //    {
        //        Name = "Samer",
        //        Age = 30,
        //        Wife = "Christine",
        //        FavoriteIceCream = "Neapolitan",
        //        Dog = "Allie",
        //        DogBreed = "Lab"
        //    };
        //    return new Information[] { samer, null };
        //}
    }
}
