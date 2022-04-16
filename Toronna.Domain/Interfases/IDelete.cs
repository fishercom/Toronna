namespace Toronna.Domain.Interfases;

public interface IDelete<TEntityId>
{
    void Delete(TEntityId EntityId);
}

