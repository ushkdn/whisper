﻿using Whisper.Data.Entities;
using Whisper.Data.Repositories.Base;

namespace Whisper.Data.Repositories.UserRepository;

public interface IUserRepository : IRepository<UserEntity>
{
    Task<UserEntity> GetByEmailOrPhoneNumberAsync(string emailOrPhoneNumber);
}