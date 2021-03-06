﻿using System;
using System.Threading.Tasks;
using DbContextScope.Tests.DatabaseContext;

namespace DbContextScope.Tests.DemoWithScope.Repositories
{
  public interface IUserRepository
  {
    User Get(Guid userId);

    Task<User> GetAsync(Guid userId);

    void Add(User user);
  }
}
