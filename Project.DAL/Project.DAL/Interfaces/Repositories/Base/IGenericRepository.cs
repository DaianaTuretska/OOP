﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Project.DAL.Interfaces.Entities;

namespace Project.DAL.Interfaces.Repositories.Base
{
    public interface IGenericRepository<T> where T : class, IEntity
    {
        Task<IEnumerable<T>> GetAll();
        Task<T> GetById(int id);
        Task Insert(T obj);
        void Update(T obj);
        void Delete(int id);

    }
}