using AutoMapper;
using DoughTracker.Application.Features.Categories;
using DoughTracker.Application.Features.Categories.Queries.GetCategoryList;
using DoughTracker.Application.Features.Transactions;
using DoughTracker.Application.Features.Transactions.Commands.AddTransaction;
using DoughTracker.Application.Features.Transactions.Queries.GetTransactionList;
using DoughTracker.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DoughTracker.Application.Features.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Transaction, TransactionListVm>().ReverseMap();
            CreateMap<Transaction, TransactionDetailVm>().ReverseMap();
            CreateMap<Transaction, AddTransactionCommand>().ReverseMap();
            CreateMap<Category, CategoryDto>().ReverseMap();
            CreateMap<Category, CategoryListVm>().ReverseMap();
        }
    }
}
