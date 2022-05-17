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

namespace DoughTracker.Application.Features.Transactions.Commands.AddTransaction
{
    public class AddTransactionCommandHandler : IRequestHandler<AddTransactionCommand, AddTransactionCommandResponse>
    {
        private readonly ITransactionRepository _transactionRepository;
        private readonly IMapper _mapper;

        public AddTransactionCommandHandler(IMapper mapper, ITransactionRepository transactionRepository)
        {
            _mapper = mapper;
            _transactionRepository = transactionRepository;
        }

        public async Task<AddTransactionCommandResponse> Handle(AddTransactionCommand request, CancellationToken cancellationToken)
        {
            AddTransactionCommandResponse addTransactionCommandResponse = new AddTransactionCommandResponse();
            AddTransactionCommandValidator validationer = new AddTransactionCommandValidator();

            var validationResult = await validationer.ValidateAsync(request);

            if (validationResult.Errors.Any())
            {
                addTransactionCommandResponse.Success = false;
                addTransactionCommandResponse.ValidationErrors = new List<string>();
                foreach(var error in validationResult.Errors)
                {
                    addTransactionCommandResponse.ValidationErrors.Add(error.ErrorMessage);
                }
            }
            if (addTransactionCommandResponse.Success)
            {

                var transaction = new Transaction() 
                { 
                    Description = request.Description 
                };

                transaction = (await _transactionRepository.AddAsync(transaction));
                addTransactionCommandResponse.Transaction = _mapper.Map<AddTransactionDto>(transaction);
            }

            return addTransactionCommandResponse;
        }
    }
}
