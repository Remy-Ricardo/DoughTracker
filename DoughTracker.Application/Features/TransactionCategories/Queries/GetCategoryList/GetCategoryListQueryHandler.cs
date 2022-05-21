using AutoMapper;
using DoughTracker.Application.Contracts.Persistence;
using DoughTracker.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DoughTracker.Application.Features.Categories.Queries.GetCategoryList
{
    public class GetCategoryListQueryHandler : IRequestHandler<GetCategoryListQuery, List<CategoryListVm>>
    {
        private readonly ITransactionCategoryRepository _transactionCategoryRepository;
        private readonly IMapper _mapper;

        public GetCategoryListQueryHandler(IMapper mapper, ITransactionCategoryRepository transactionCategoryRepository)
        {
            _mapper = mapper;
            _transactionCategoryRepository = transactionCategoryRepository;
        }

        public async Task<List<CategoryListVm>> Handle(GetCategoryListQuery request, CancellationToken cancellationToken)
        {
            var allCategories = (await _transactionCategoryRepository.ListAllAsync()).OrderBy(x => x.CategoryName);

            return _mapper.Map<List<CategoryListVm>>(allCategories);

            
        }
    }
}
