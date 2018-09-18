using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace SmartParkdll
{
    public class ParkingLotTests
    {
        string licensePlate = "AA50823";
        string anotherLicensePlate = "TT58000";

        [Fact]
        public void WhenCarArrives_RegisterIt()
        {
            //Arrange
            var sut = new ParkingLot();

            //Act
            sut.EnterParkingLot(new Car(licensePlate));
            var amountOfCars = sut.GetAllCars();

            //Assert
            Assert.Equal(1, amountOfCars.Count);
        }

        [Fact]
        public void WhenCarArrives_CheckIfDuplicate()
        {
            var sut = new ParkingLot();
            var car = new Car(licensePlate);

            sut.EnterParkingLot(car);


            var ex = Assert.Throws<Exception>(() => sut.EnterParkingLot(car));
            Assert.Equal("Duplicate registration number", ex.Message);
        }

        [Fact]
        public void WhenCarDeparts_RegisterIt()
        {
            var sut = new ParkingLot();
            var car = new Car(licensePlate);

            sut.EnterParkingLot(car);
            sut.LeaveParkingLot(car);
            var parkingLotCount = sut.GetAllCars();

            Assert.Equal(0, parkingLotCount.Count);
        }

        [Fact]
        public void WhenCarDoesNotExist_ThrowException()
        {
            var sut = new ParkingLot();
            sut.EnterParkingLot(new Car(anotherLicensePlate));

            var ex = Assert.Throws<NullReferenceException>(() => sut.GetCar(new Car(licensePlate)));
            Assert.Equal("Car is not parked in parking lot", ex.Message);
        }
    }
}
