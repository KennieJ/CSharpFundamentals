using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _05_Classes
{
    [TestClass]
    public class ClassesTests
    {
        [TestMethod]
        public void CookieTests()
        {
            Cookie cookie = new Cookie();
            cookie.Name = "Snickerdoodle";
            cookie.HasNuts = false;
            
            Cookie anotherCookie = new Cookie();
            anotherCookie.Name = "Something else";
            anotherCookie.GramsOfFlour = 10;

            Cookie snickerdoodle = new Cookie("Snickerdoodle", false, 11.5); //constructor
            Cookie newCookie = new Cookie("Peanut Butter", true, 150);
        }

        [TestMethod]
        public void VehicleTests()
        {
            Vehicle car = new Vehicle();
            car.TypeOfVehicle = VehicleType.Car;

            //object initialization syntax...maybe dont set all teh parameters
            Vehicle newCar = new Vehicle
            {
                TypeOfVehicle = VehicleType.Motorcycle,
                Make = "Honda",
                Model = "Civic"
            };
        }
    }
}
