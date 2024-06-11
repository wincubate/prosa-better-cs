sealed class PhoneNumberException(string phoneNumber)
    : Exception($"Illegal phone number \"{phoneNumber}\". Must consists of digits only!")
{
    public string Value { get; } = phoneNumber;
}
