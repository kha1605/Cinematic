using demo_mvc.Data.Base;
using demo_mvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace demo_mvc.Data.Service
{
    public class CInemaService : EntityBaseRepository<Cinema>, ICinemaService
    {

        public CInemaService(AppDbContext context) :base(context)
        {

        }

       
    }
}

