using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfTestInterface
{
  internal interface IAnimal
  {
    string Species { get; set; }
    string Speak(string sound);
  }
}
