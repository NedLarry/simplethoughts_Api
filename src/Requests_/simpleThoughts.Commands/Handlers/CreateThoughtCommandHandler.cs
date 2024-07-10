using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abstractions.DTOs;
using Abstractions.Interfaces;
using Abstractions.Models;
using MediatR;
using Requests_.simpleThoughts.Commands.Commands;

namespace Requests_.simpleThoughts.Commands.Handlers
{
    public class CreateThoughtCommandHandler : IRequestHandler<CreateThoughtCommand, BaseResponse<Thought>>
    {

        private readonly IThoughtService _thoughtService;

        public CreateThoughtCommandHandler(IThoughtService _thoughtService)
        {
            this._thoughtService = _thoughtService;
        }

        public async Task<BaseResponse<Thought>> Handle(CreateThoughtCommand request, CancellationToken cancellationToken)
        {
            var createdThought = await _thoughtService.CreateThought(new CreateThoughtDTO {
                Title = request.Title,
                Content = request.Content
            });

            return createdThought;
        }
    }
}