using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using HotelReservation.Entities;

namespace CitiesOperation.Data
{
    public static class CitiesTranslate
    {
        public static List<Cities> ParseCities(DataSet citiesdataset)
        {
            if (citiesdataset == null) return null;

            if (citiesdataset.Tables.Count > 0 && citiesdataset.Tables[0].Rows.Count > 0)
            {
                List<Cities> citiesList = new List<Cities>();
                foreach (DataRow row in citiesdataset.Tables[0].Rows)
                {
                    Cities cities = new Cities();
                    cities.CityCode = Convert.ToInt64(row["CityCode"]);
                    cities.CityName = row["CityName"].ToString();
                    citiesList.Add(cities);
                }
                return citiesList;

            }


            return null;

        }
    }
}
