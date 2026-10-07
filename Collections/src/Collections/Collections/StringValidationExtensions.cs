using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Collections;
public static class StringValidationExtensions
{
   public static bool IsValidEgyptianPhone(this string phone)
    {
        if (string.IsNullOrWhiteSpace(phone))
            return false;

       string pattern = @"^(010\d{8}|011\d{8}|012\d{8}|015\d{8}|\+2010\d{8}|\+2011\d{8}|\+2012\d{8}|\+2015\d{8})$";

       return Regex.IsMatch(phone, pattern);
    }

    public static bool IsValidEgyptianNationalId(this string nationalId)
    {
        if (string.IsNullOrWhiteSpace(nationalId))
            return false;

        string pattern = @"^[23]\d{13}$";

        return Regex.IsMatch(nationalId, pattern);
    }
}
