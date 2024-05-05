namespace BookingKata.Domain.Entities;

public abstract record Id<TValue>
{
  private TValue Value { get; }

  protected Id(TValue value) => Value = value;

  // ToDo replace exception with Option<Id> from language-ext
  // public static Id<TValue> Create(TValue value) =>
  //   value is null ? throw new ArgumentNullException(nameof(value)) : new(value);

  // ToDo: Value is not allowed to be null, find a way to make compiler happy again
  public override string ToString() => Value!.ToString()!;
}