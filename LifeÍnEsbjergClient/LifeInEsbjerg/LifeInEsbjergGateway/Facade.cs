﻿using LifeInEsbjergGateway.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeInEsbjergGateway
{
   public class Facade
    {
        public CompanyGatewayService GetComapnyGateway()
        {
            return new CompanyGatewayService();
        }
    }
}
