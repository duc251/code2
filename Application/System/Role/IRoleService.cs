﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModels.System;

namespace Application.System.Role
{
    public interface IRoleService
    {
        Task<List<RoleVm>> GetAll();
    }
}
