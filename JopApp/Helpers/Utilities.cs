using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JopApp.Helpers
{
    public static class Utilities
    {
        public static bool check(string value)
        {
			try
			{
				Convert.ToInt32(value);
				return true;
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
				throw;
			}

        }
    }
}
