using System.Collections.Generic;

using EverythingSharp.API.Entities;

namespace EverythingSharp.Common.Collections
{
  public class EntityMap<TEntity> where TEntity : class, IEntity
  {
    private readonly KeyValueMap<ulong, TEntity> _map;

    public EntityMap()
    {
      _map = new KeyValueMap<ulong, TEntity>();
    }

    public TEntity this[ulong entityId] => TryGetEntity(entityId, out var entity) ? entity : null;

    public IEnumerable <TEntity> Entities => _map.Values;

    public void Add(TEntity entity)
    {
      _map.Add(entity.Id, entity);
    }

    public bool Remove(TEntity entity)
    {
      return Contains(entity) && _map.Remove(entity.Id);
    }

    public bool Contains(TEntity entity)
    {
      return _map.Contains(entity.Id);
    }

    public bool TryGetEntity(ulong entityId, out TEntity entity)
    {
      return _map.TryGetItem(entityId, out entity);
    }
  }

}