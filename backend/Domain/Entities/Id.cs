namespace BookingKata.Domain.Entities;

public abstract record Id<TValue>(TValue Value)
{
  public override string ToString() => Value!.ToString()!;

  public static implicit operator TValue(Id<TValue> id) => id.Value;
}