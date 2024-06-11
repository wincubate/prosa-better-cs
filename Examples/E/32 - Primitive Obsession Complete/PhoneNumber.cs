record class PhoneNumber
{
    public string Value { get; }

    private PhoneNumber(string value)
    {
        Value = value;
    }

    public static PhoneNumber Parse(string value)
    {
        // Validate phone number
        if (value.Any(c => !char.IsDigit(c)))
        {
            throw new PhoneNumberException(value);
        }

        return new PhoneNumber(value);
    }

    public static implicit operator string(PhoneNumber phoneNumber) =>
        phoneNumber.Value;
}
