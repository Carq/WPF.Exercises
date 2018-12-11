using System;

namespace WPF.Exercises.Service.Dto
{
    public class CarDto
    {
        public int Id { get; set; }

        public string Brand { get; set; }

        public string Model { get; set; }

        public DateTime DateOfLastInspection { get; set; }

        public string Photo { get; set; }
    }
}
