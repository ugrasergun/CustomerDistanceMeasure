using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Web.Script.Serialization;

namespace CustomerDistanceMeasure.Entities
{
    public class Customer
    {
        public static Customer LoadCustomer(string json)
        {
            JsonSerializerSettings settings = new JsonSerializerSettings();
            settings.FloatParseHandling = FloatParseHandling.Decimal;
            return JsonConvert.DeserializeObject<Customer>(json,settings);
        }
        public int user_id { get; set; }
        public string name { get; set; }
        private double _longitude;
        public double longitude
        {
            get
            {
                return _longitude;
            }

            set
            {
                if (Math.Abs(value) > 180)
                    throw new OverflowException("Longitude can not be greater than 180");
                _longitude = value;
            }
        }
        
        private double _latitude;
        public double latitude
        {
            get
            {
                return _latitude;
            }

            set
            {
                if (Math.Abs(value) > 90)
                    throw new OverflowException("Latitude can not be greater than 90");
                _latitude = value;
            }
        }

        
    }
}
