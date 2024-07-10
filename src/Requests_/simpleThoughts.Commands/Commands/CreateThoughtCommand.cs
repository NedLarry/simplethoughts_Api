using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Abstractions.DTOs;
using Abstractions.Interfaces;
using Abstractions.Models;
using MediatR;

namespace Requests_.simpleThoughts.Commands.Commands
{

    
    public class CreateThoughtCommand : IRequest<BaseResponse<Thought>>
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Title { get; set; } = null!;

        [Required]
        [StringLength(500)]
        public string Content { get; set; } = null!;
    }
}