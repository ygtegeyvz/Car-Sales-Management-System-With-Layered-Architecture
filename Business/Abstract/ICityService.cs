﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Abstract
{
   public interface ICityService
    {
        List<City> GetAll();
    }
}
