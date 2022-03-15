using Data.Entiti;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModels.System;

namespace Application.System.Role
{
    public class RoleService : IRoleService
    {
        private readonly RoleManager<AppRole> _roleManage;

        public RoleService(RoleManager<AppRole> roleManager)
        {
            _roleManage = roleManager;
        }
        public async Task<List<RoleVm>> GetAll()
        {
            var roles = await _roleManage.Roles
                .Select(x => new RoleVm()
                {
                    Id = x.Id,
                    Name = x.Name,
                    Description = x.Description

                }).ToListAsync();

            return roles;
        }
    }
}
