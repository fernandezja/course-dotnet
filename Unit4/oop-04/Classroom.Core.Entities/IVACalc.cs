using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classroom.Core.Entities
{
    public static class IVACalc
    {
        public static decimal CalculateIVA(decimal amount, decimal ivaPercentage)
        {
            if (amount < 0 || ivaPercentage < 0)
            {
                throw new ArgumentException("Amount and IVA percentage must be non-negative.");
            }
            return amount * (ivaPercentage / 100);
        }

        public static decimal CalculateTotalWithIVA(decimal amount, decimal ivaPercentage)
        {
            if (amount < 0 || ivaPercentage < 0)
            {
                throw new ArgumentException("Amount and IVA percentage must be non-negative.");
            }
            return amount + CalculateIVA(amount, ivaPercentage);
        }

    }
}
