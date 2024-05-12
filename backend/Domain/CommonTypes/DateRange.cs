public readonly record struct DateRange
{
  public DateTimeOffset Start { get; }
  public DateTimeOffset End { get; }

  private DateRange(DateTimeOffset start, DateTimeOffset end) =>
    (Start, End) = (start, end);

  public static DateRange Create(DateTimeOffset start, DateTimeOffset end)
  {
    return start > end
      ? throw new ArgumentException("Start should be earlier than End", nameof(start))
      : new(start, end);
  }
}