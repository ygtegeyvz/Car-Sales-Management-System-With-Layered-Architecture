﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Entities.Concrete;

namespace DataAccess.Abstract
{
    public interface IAdDal:IEntityRepository<Ad>
    {
    }
}
