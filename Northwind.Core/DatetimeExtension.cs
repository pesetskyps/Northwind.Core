using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Core
{
    public class DatetimeExtension
    {
        DateTime thisDate1 = new DateTime(2011, 6, 10);

        public string DayYearMonthDate(DateTime time)
        {
            return time.ToString("MMMM dd,yyyy");
        }

        public string Year2015(string date)
        {
            var array = date.Split(',').ToList();
            return array.First(x => x.Equals("2015"));
        }
    }
}
