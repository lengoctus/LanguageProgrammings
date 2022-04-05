using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoSession18_EFCore.Profiles
{
    public class OrderProfile : Profile
    {
        public OrderProfile() {
            CreateMap<Models.Entities.Orders, Models.ModelView.OrderView>();
        }
    }
}
