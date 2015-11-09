using CustomerDistanceMeasure.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerDistanceMeasure
{
    public class OfficeMeasure
    {
        public OfficeMeasure(double officeLatitude, double officeLongitude)
        {
            OfficeLatitude = officeLatitude;
            OfficeLongitude = officeLongitude;
        }

        public double OfficeLatitude { get; private set; }
        public double OfficeLongitude { get; private set; }
        public double InvitationRange { get; set; }

        public bool isCustomerInRange(Customer cust)
        {
            return Measurer.MeasueDistanceInDegrees(OfficeLatitude, OfficeLongitude, cust.latitude, cust.longitude) <= InvitationRange;
        }

    }
}
 