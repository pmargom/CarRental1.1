using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using CarRental.api.db;
using Microsoft.AspNetCore.Mvc;

namespace CarRental.api.Controllers
{

    [Route("api/v1/[controller]")]
    public class CarsController: Controller {
        
        private static CarRentalContext _context;

        static CarsController()
        {
            _context = new CarRentalContext();
            //_cars = MockData;
            //_cars = MockData;
        }

        [HttpGet]
        public IEnumerable<Car> GetAll()
        {
            var cars = _context.Cars;
            if (cars == null || cars.Count() == 0) {
                return null;
            }
            return cars;
        }

        [HttpGet("{id}", Name = "GetCar")]
        public IActionResult GetById(string id) {

            //_cars = MockData;
            var car = _context.Cars.ToList().Where(c => c.id == id);

            if (car == null) {
                return NotFound();
            }

            return new ObjectResult(car);
        }

        // POST cars
        [HttpPost]
        public IActionResult Post([FromBody]Car car)
        {
            _context.Cars.Add(car);
            _context.SaveChanges();
            var newCar = _context.Cars.ToList().Where(c => car.CarNumber == car.CarNumber );
            if (newCar == null) {
                return NotFound();
            }
            return Ok(newCar);
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
    }

}