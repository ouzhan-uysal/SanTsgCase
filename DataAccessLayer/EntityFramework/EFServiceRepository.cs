﻿using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EFHotelRepository : GenericRepository<Hotel>, IHotelDAL
    {
    }
    public class EFFlightRepository : GenericRepository<Flight>, IFlightDAL
    {
    }
}
