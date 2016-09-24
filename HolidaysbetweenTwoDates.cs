using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Holidays_between_Two_Dates
{
    class Program
    {
        static void Main(string[] args)
        {
            string Date1 = Console.ReadLine();
            string Date2 = Console.ReadLine();
            DateTime startDate;
            DateTime endDate;

            if (DateTime.TryParseExact(Date1,
            "dd.M.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out startDate))
                startDate = DateTime.ParseExact(Date1, "dd.M.yyyy", CultureInfo.InvariantCulture);
            else
                startDate = DateTime.ParseExact(Date1, "d.M.yyyy", CultureInfo.InvariantCulture);
            if (DateTime.TryParseExact(Date2, "dd.M.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out endDate))
                endDate = DateTime.ParseExact(Date2, "dd.M.yyyy", CultureInfo.InvariantCulture);
            else
                endDate = DateTime.ParseExact(Date2, "d.M.yyyy", CultureInfo.InvariantCulture);
            var holidaysCount = 0;
            for (DateTime date = startDate; date.Date <= endDate.Date; date = date.AddDays(1))
                if (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday) holidaysCount++;
            Console.WriteLine(holidaysCount);
        }
    }
}