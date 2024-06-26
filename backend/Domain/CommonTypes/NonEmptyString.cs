namespace BookingKata.Domain.CommonTypes;

public readonly record struct NonEmptyString
{
    public string Value { get; }

    private NonEmptyString(string value) => Value = value;

    // ToDo: use language-ext instead of exceptions
    public static NonEmptyString Create(string value) =>
      string.IsNullOrWhiteSpace(value) ? throw new ArgumentNullException(nameof(value)) : new(value);
}