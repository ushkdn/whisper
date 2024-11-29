using Whisper.Data.Entities.Base;

namespace Whisper.Data.Repositories.CacheRepository;

public interface ICacheRepository
{
    Task<TTable> GetSingleAsync<TTable>(string key, int id) where TTable : class, IEntity;

    Task<List<TTable>> GetListAsync<TTable>(string key) where TTable : class, IEntity;

    Task SetListAsync<TTable>(string key, List<TTable> values) where TTable : class, IEntity;

    Task AddOrUpdateListAsync<TTable>(string key, TTable value) where TTable : class, IEntity;

    Task RemoveByIdAsync<TTable>(string key, int id) where TTable : class, IEntity;

    Task RemoveAllAsync(string key);
}