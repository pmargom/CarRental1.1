using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CarRental.api.Controllers
{

    [Route("api/v1/[controller]")]
    public class CarsController: Controller {
        
        private static List<Car> _cars;

        private static List<Car> MockData
        {
            get
            {
                return new List<Car>() {
                    new Car() {
                        id = "1",
                        CarNumber = "HHH-2323",
                        Type = CarType.Generic,
                        YearOfBuild = "2010",
                        Manufacturer = "Toyota",
                        Model = "Rav4",
                        Engine = CarEngine.Hybrid
                    },
                    new Car() {
                        id = "2",
                        CarNumber = "EDG-1290",
                        Type = CarType.Generic,
                        YearOfBuild = "2014",
                        Manufacturer = "Mercedes-Benz",
                        Model = "Clase A",
                        Engine = CarEngine.Petrol
                    },
                    new Car() {
                        id = "3",
                        CarNumber = "HGR-8778",
                        Type = CarType.Truck,
                        YearOfBuild = "2009",
                        Manufacturer = "Scania",
                        Model = "RV12",
                        Engine = CarEngine.Petrol
                    },
                        new Car() {
                        id = "4",
                        CarNumber = "HJJ-3423",
                        Type = CarType.Van,
                        YearOfBuild = "2015",
                        Manufacturer = "Nissan",
                        Model = "Yuke",
                        Engine = CarEngine.Electric
                    },
                };
            }
        }
        static CarsController()
        {
            _cars = MockData;
        }

        [HttpGet]
        public IEnumerable<Car> GetAll()
        {
            return _cars.AsReadOnly();
        }

        [HttpGet("{id}", Name = "GetCar")]
        public IActionResult GetById(string id) {

            _cars = MockData;
            var car = _cars.Find(c => c.id == id);

            if (car == null) {
                return NotFound();
            }

            return new ObjectResult(car);
        }


        // POST cars
        [HttpPost]
        public IActionResult Post([FromBody]Car car)
        {
            var _newCar = new Car();
            // TODO: Add new car to database
            
            return Ok(_newCar);
        }

        // PUT cars/2
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody]Car car)
        {
            // TODO: Update car details into database
            return Ok();
        }

        // DELETE cars/2
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }

}