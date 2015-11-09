using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomerDistanceMeasure.Entities;
using System.Collections.Generic;
using System.Linq;
using CustomerDistanceMeasure;

namespace CustomerDistanceMeasureTest
{
    [TestClass]
    public class CustomerDistanceMeasureTest
    {
        OfficeMeasure intercomMeasure = new OfficeMeasure(53.3381985, -6.2592576);

        [TestInitialize]
        public void Initialize()
        {
            intercomMeasure.InvitationRange = 100;
        }


        [TestMethod]
        [ExpectedException(typeof(OverflowException))]
        public void WrongLongtitude()
        {
            Customer XY = new Customer();
            XY.longitude = 185;
        }

        [TestMethod]
        [ExpectedException(typeof(OverflowException))]
        public void WrongLatitude()
        {
            Customer XY = new Customer();
            XY.latitude = 105;
        }

        [TestMethod]
        public void InitializeCoordinate()
        {
            Customer XY = new Customer();
            XY.longitude = 105;
            XY.latitude = 82;
            Assert.IsTrue(XY.longitude == 105);
            Assert.IsTrue(XY.latitude == 82);
        }

        [TestMethod]
        public void InitializeCustomer()
        {
            string json = "{\"latitude\": \"52.986375\", \"user_id\": 12, \"name\": \"Christina McArdle\", \"longitude\": \"-6.043701\"}";

            Customer customer = Customer.LoadCustomer(json);
            Assert.IsTrue(customer.user_id == 12);
            Assert.IsTrue(customer.name == "Christina McArdle");
            Assert.IsTrue(customer.latitude == 52.986375);
            Assert.IsTrue(customer.longitude == -6.043701);
        }

        [TestMethod]
        public void InitializeCustomerList()
        {
            List<string> jsonList = new List<string> { "{\"latitude\": \"52.986375\", \"user_id\": 12, \"name\": \"Christina McArdle\", \"longitude\": \"-6.043701\"}", "{ \"latitude\": \"51.92893\", \"user_id\": 1, \"name\": \"Alice Cahill\", \"longitude\": \" -10.27699\"}" };
            List<Customer> customerList = jsonList.Select(json => Customer.LoadCustomer(json)).ToList();
            Assert.IsTrue(customerList.Count == 2);
        }
        [TestMethod]
        public void DegreesToRadian()
        {
            double Degrees30 = 30;
            double Degrees180 = 180;
            Assert.IsFalse(Degrees30.DegreesToRadians() == Math.PI / 4);
            Assert.IsTrue(Degrees180.DegreesToRadians() == Math.PI);
        }
        [TestMethod]
        public void CalculateDistance()
        {
            double distanceCalculated = Measurer.MeasueDistanceInDegrees(40.979871, 28.706529, 40.979097, 28.705456) * 1000;
            double distanceMeasured = 124.44; //Distance of my street according to Google Earth
            Assert.IsTrue(distanceMeasured.EqualsAprroximately(distanceCalculated, 1));
        }
        [TestMethod]
        public void CheckCustomerDistance()
        {
            string jsonInRange = "{\"latitude\": \"52.986375\", \"user_id\": 12, \"name\": \"Christina McArdle\", \"longitude\": \"-6.043701\"}";
            string jsonOutOfRange = "{\"latitude\": \"51.802\", \"user_id\": 21, \"name\": \"David Ahearn\", \"longitude\": \" -9.442\"}";
            Customer customerInRange = Customer.LoadCustomer(jsonInRange);
            Customer customerOutOfRange = Customer.LoadCustomer(jsonOutOfRange);

            Assert.IsTrue(intercomMeasure.isCustomerInRange(customerInRange));
            Assert.IsFalse(intercomMeasure.isCustomerInRange(customerOutOfRange));
        }

    }
}
