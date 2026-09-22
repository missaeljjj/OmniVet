namespace OmniVet.Infrastructure.Shared;

public class DataBaseConnectionException : Exception
{
    public string? FieldName { get; protected set; }

    public DataBaseConnectionException() { }

    public DataBaseConnectionException(string message) 
        : base(message) { }

    public DataBaseConnectionException(string message, Exception inner) 
        : base(message, inner) { }

    public DataBaseConnectionException(string message, string fieldName) 
        : base(message) 
    {
        FieldName = fieldName?.ToLower();
    }

    public static DataBaseConnectionException ObjectNotFound(string paramName)
        => new($"{paramName} no encontrado.", paramName);
}

