using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace Abstractions.DTOs
{
    public class BaseResponse<T> where T : class
    {
        public string responseCode {get; set;} = null!;

        public string description {get; set;} = null!;

        public T? data {get; set;}
    }
}