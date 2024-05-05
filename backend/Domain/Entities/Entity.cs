namespace BookingKata.Domain.Entities;

public abstract record Entity<TId>
{
    public Id<TId> Id { get; }

    protected Entity(Id<TId> id) => Id = id;
}