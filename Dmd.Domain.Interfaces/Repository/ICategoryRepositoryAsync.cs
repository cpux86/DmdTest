﻿using Dmd.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Dmd.Domain.Interfaces.Repository
{
    public interface ICategoryRepositoryAsync : IGenericRepositoryAsync<Category>
    {
        //Task<IReadOnlyList<Category>> GetListByParentId(int parentId);
        //Task<IReadOnlyList<Category>> GetCategoryList(Expression<Func<Category, bool>> predicate);
        bool Find(int catId);
    }
}
