﻿using Northwind.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Domain.Base
{
    public interface IRepositoryManager
    {
        ICategoryRepository CategoryRepository { get; }

        void Save();
        Task SaveAsync();
    }
}