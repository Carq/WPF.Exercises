using System;
using System.Collections.Generic;
using WPF.Exercises.Service.Dto;

namespace WPF.Exercises.Service
{
    public class FleetService
    {
        public IList<CarDto> GetAllCars()
        {
            return new[]
            {
                new CarDto
                {
                    Id = 1,
                    Brand = "Ford",
                    Model = "Mondeo",
                    IsUsed = true,
                    DateOfLastInspection = DateTime.Parse("16.11.2018 07:22:16"),
                    Photo = "/WPF.Exercises;component/Resources/Cars/ford-mondeo01.jpg"
                }
            };
        } 
    }
}