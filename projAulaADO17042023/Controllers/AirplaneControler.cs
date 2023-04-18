using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using projAulaADO17042023.Models;
using projAulaADO17042023.Services;

namespace projAulaADO17042023.Controllers
{
    public class AirplaneControler
    {
        public bool Insert(AirPlane airplane)
        {
            return new AirplaneService().Insert(airplane);
        }

        public List<AirPlane> FindAll()
        {
            return new AirplaneService().FindAll();
        }
    }
}
