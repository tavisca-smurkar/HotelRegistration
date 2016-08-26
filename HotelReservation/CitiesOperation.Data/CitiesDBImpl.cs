using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.EnterpriseLibrary.Data;
using HotelReservation.Entities;
using System.Data.Common;

namespace CitiesOperation.Data
{
    public class CitiesDBImpl
    {
        private const string DBName = "HotelDB";
        public List<Cities> SelectCities()
        {
            DatabaseProviderFactory dbfactory = new DatabaseProviderFactory();
            Database defaultdatabase = dbfactory.CreateDefault();
            Database database = dbfactory.Create(DBName);
            DbCommand command = database.GetStoredProcCommand("spShowCities");

            List<Cities> cities = CitiesTranslate.ParseCities(database.ExecuteDataSet(command));
            return cities;
        }
    }
}
