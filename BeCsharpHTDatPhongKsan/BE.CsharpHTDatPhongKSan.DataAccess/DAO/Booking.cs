using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE.CsharpHTDatPhongKSan.DataAccess.DAO
{
    public class Booking
    {
        public int bookingid {  get; set; }
        public string customerName { get; set; }
        public int RoomNumber { get; set; }
        public DateTime checkInDate { get; set; }
        public DateTime checkOutDate { get; set; }
    }
}
