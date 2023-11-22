using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wema.BIT.Models
{
    internal class Payment
    {
        public int PaymentId { get; set; }
        public int UserID { get; set; }
        public double Payment_amount { get; set; }
    }
}
