using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace part_01.src.Shipping;
public interface IShippingCostCalculator
{
    public decimal Calculate(decimal weightKg);
}
