﻿using System;
using System.Threading.Tasks;
using BT.DataAccess.Identity;

namespace BT.DataAccess.Interfaces
{
    interface IUnitOfWork : IDisposable
    {
        UserManager UserManager { get; }
        IClientManager ClientManager { get; }
        RoleManager RoleManager { get; }
        Task SaveAsync();
    }
}
