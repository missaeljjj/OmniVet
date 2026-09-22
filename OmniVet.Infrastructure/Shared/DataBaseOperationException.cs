namespace OmniVet.Infrastructure.Shared;

public class DataBaseOperationException : Exception
{
    public string? FieldName { get; protected set; }

    public DataBaseOperationException() { }

    public DataBaseOperationException(string message) 
        : base(message) { }

    public DataBaseOperationException(string message, Exception inner) 
        : base(message, inner) { }

    public DataBaseOperationException(string message, string fieldName) 
        : base(message) 
    {
        FieldName = fieldName?.ToLower();
    }

    public static DataBaseOperationException ObjectNotFound(string paramName)
        => new($"{paramName} no encontrado.", paramName);
}