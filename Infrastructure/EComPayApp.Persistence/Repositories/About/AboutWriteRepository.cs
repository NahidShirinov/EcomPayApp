﻿using EComPayApp.Application.Interfaces.Repositories;
using EComPayApp.Domain.Entities;
using EComPayApp.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EComPayApp.Persistence.Repositories
{
    public class AboutWriteRepository : WriteRepository<About>, IAboutWriteRepository
    {
        public AboutWriteRepository(EComPayAppDbContext context) : base(context)
        {
        }
    }
}
