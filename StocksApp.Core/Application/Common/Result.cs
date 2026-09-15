namespace StocksApp.Server.Application.Common
{
    public class Result<T> where T : class
    {
        public T? Value { get; init; }
        public string? Error { get; init; }
        public bool IsSuccess => Error is null;

        public static Result<T> Success(T value) => new() { Value = value };

        public static Result<T> Failure(string error) => new() { Error = error };
    }
}
