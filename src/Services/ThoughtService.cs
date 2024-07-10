using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abstractions.DTOs;
using Abstractions.Interfaces;
using Abstractions.Models;
using Abstractions.Models.context;

namespace Services
{
    public class ThoughtService : IThoughtService
    {

        private readonly ThoughtContext _context;

        public ThoughtService(ThoughtContext _context)
        {
            this._context = _context;
        }


        //TODO : Refactor return models
        public async Task<BaseResponse<Thought>> CreateThought(CreateThoughtDTO thought)
        {
            BaseResponse<Thought> response = new BaseResponse<Thought>();

            try
            {

                if (_context.Thoughts.Any(t => t.Title.Equals(thought.Title)))
                {
                    response.responseCode = "01";
                    response.description = $"Thought with title already exists";
                    return response;
                }

                var newThought = new Thought 
                {
                    Title = thought.Title,
                    Content = thought.Content
                };


                await _context.Thoughts.AddAsync(newThought);

                await _context.SaveChangesAsync();

                response.responseCode = "00";
                response.description = $"Thought created successfully";
                response.data = newThought;

                return response;

            }catch(Exception ex)
            {
                response.responseCode = "99";
                response.description = ex.Message;
                return response;
            }
        }
    }
}