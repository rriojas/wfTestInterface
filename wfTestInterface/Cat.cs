﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfTestInterface
{
  internal class Cat : Pet, IAnimal
  {
    public string Species 
    {
      get; set;
    }

    public string Speak(string sound)
    {
      return sound;
    }
  }
}
