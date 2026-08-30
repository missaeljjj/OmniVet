namespace OmniVet.Core.Exceptions;

public class DomainException : Exception
{
    public string? FieldName { get; protected set; }

    public DomainException() { }

    public DomainException(string message) 
        : base(message) { }

    public DomainException(string message, Exception inner) 
        : base(message, inner) { }

    public DomainException(string message, string fieldName) 
        : base(message) 
    {
        FieldName = fieldName?.ToLower();
    }

    public static DomainException ObjectNotFound(string paramName)
        => new($"{paramName} no encontrado.", paramName);
}