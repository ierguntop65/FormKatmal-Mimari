﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Abstract
{
    using Entities.Concreate;

    public interface ICategoryManager
    {
        IList<Category> GetAll();
    }
}
