﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskZ_Application.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {        
        Task<T> GetByIdAsync(int id);
        Task<List<T>> GetAllAsync();
        Task<int> AddAsync(T entity);
       //Task<int> UpdateAsync(T entity);
        Task<int> DeleteAsync(int id);
    }
}
