using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projAulaADO17042023.Models
{
    public class AirPlane
    {
        #region Properties
        public int Id { get; set; }
        public string Name { get; set; }
        public int NumberOfPassagers { get; set;}
        public string Description { get; set; }
        public Engine Engine { get; set; }

        #endregion

        public override string ToString()
        {
            return "Id: " + Id +
                   "\nNome: " + Name +
                   "\nNumero de Passageiros:" + NumberOfPassagers +
                   "\nDescrição: " + Description +
                   "\nMotor:" + Engine;
        }
    }
}
