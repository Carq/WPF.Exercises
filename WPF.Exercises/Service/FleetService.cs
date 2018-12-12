using System;
using System.Collections.Generic;
using WPF.Exercises.Service.Dto;

namespace WPF.Exercises.Service
{
    public class FleetService
    {
        private readonly IList<CarDto> _cars;

        public FleetService()
        {
            _cars = new List<CarDto>();
            GenerateFakeData();
        }

        private void GenerateFakeData()
        {
            var fakeDate = DateTime.Now.AddYears(-1);
            for (int i = 0; i < 50; i++)
            {
                var fakeCar = CarList.Cars[i % CarList.Count];
                _cars.Add(new CarDto
                {
                    Id = i + 1,
                    Brand = fakeCar.Brand,
                    Model = fakeCar.Model,
                    Photo = fakeCar.Photo,
                    DateOfLastInspection = fakeDate.AddDays(i * 3).AddMinutes(i * 31),
                    IsUsed = i % 2 == 0
                });
            }
        }

        public IList<CarDto> GetAllCars()
        {
            return _cars;
        }
    }
}