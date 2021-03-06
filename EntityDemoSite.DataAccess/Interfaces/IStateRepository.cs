﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EntityDemoSite.Domain;
using EntityDemoSite.Domain.Entities;

namespace EntityDemoSite.DataAccess.Interfaces
{
    public interface IStateRepository
    {
        IEnumerable<State> GetAll();
    }
}
