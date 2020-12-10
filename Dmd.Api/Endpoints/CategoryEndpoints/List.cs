﻿using Ardalis.ApiEndpoints;
using AutoMapper;
using Dmd.Domain.Core.Entities;
using Dmd.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Dmd.Api.Endpoints.CategoryEndpoints
{
    public class List : BaseAsyncEndpoint<CategoryListResponse>
    {
        private readonly ICategoryRepository _repo;
        private IMapper _mapper;

        public List(ICategoryRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        [HttpGet("api/category/list")]
        public async override Task<ActionResult<CategoryListResponse>> HandleAsync(CancellationToken cancellationToken = default)
        {
            IEnumerable<CategoryListResponse> result = (await _repo.GetCategoryList())
                .Select(_mapper.Map<CategoryListResponse>);
            return Ok(result);
        }
    }
}
