using EccomerceApiCleanArchitecture.Core.Bases;
using EccomerceApiCleanArchitecture.Data.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EccomerceApiCleanArchitecture.Core.Features._Categories.Command.Model
{
    public class CreateNewCategoryCommand : IRequest<Response<int>>
    {
      
        public string Name { get; set; }
        public string? Desc { get; set; }

        public bool IsActive { get; set; } = true;

      
    }
}
