using System.Collections.Generic;

namespace WPF.Exercises.Service.Dto
{
    public static class CarList
    {
        static CarList()
        {
            Cars = new List<CarDto>()
            {
                new CarDto
                {
                    Brand = "Ford",
                    Model = "Mondeo",
                    Photo = "/WPF.Exercises;component/Resources/Cars/ford-mondeo01.jpg"
                },
                new CarDto
                {
                    Brand = "Fiat",
                    Model = "Grande Punto",
                    Photo = "/WPF.Exercises;component/Resources/Cars/fiat-punto.jpg"
                },
                new CarDto
                {
                    Brand = "Audi",
                    Model = "A4",
                },
                new CarDto
                {
                    Brand = "Skoda",
                    Model = "Fabia",
                },
                new CarDto
                {
                    Brand = "Mazda",
                    Model = "3",
                },
                new CarDto
                {
                    Brand = "Volkswagen",
                    Model = "Golf",
                    Photo = "/WPF.Exercises;component/Resources/Cars/volkswagen-golf.jpg"
                },
            
            };
        }

        public static int Count => Cars.Count;

        public static IList<CarDto> Cars { get; }
    }
}