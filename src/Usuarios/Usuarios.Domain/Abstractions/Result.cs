namespace Usuarios.Domain.Abstractions;
using System.Diagnostics.CodeAnalysis;

    public class Result
    {
        protected internal Result(bool isSuccess, Error error)
        {
            if (isSuccess && error != Error.None){
                throw new InvalidTimeZoneException("");
            }

            if (!isSuccess && error != Error.None){
                throw new InvalidTimeZoneException("");
            }
            IsSuccess = isSuccess;
            Error = error;
        }

        public bool IsSuccess { get; }
        public Error Error { get; }
        public bool IsFailure => !IsSuccess;

        public static Result Success() => new(true, Error.None);

        public static Result Failure(Error error) => new(false, error);

        public static Result<TValue> Success<TValue>(TValue value)
        => new(value, true, Error.None);

        public static Result<TValue> Failure<TValue>(Error error)
        => new(default,false,error);
        
        public static Result<TValue> Create<TValue>(TValue? value)
        => value is not null
        ? Success(value)
        : Failure<TValue>(Error.NullValue);
    }

    public class Result<Tvalue> : Result
    {
        private readonly Tvalue? _value;

        protected internal Result(Tvalue? value, bool isSuccess, Error error)
        : base(isSuccess,error)
        {
            _value = value;
        }

        [NotNull]
        public Tvalue Value => IsSuccess
        ? _value!
        : throw new InvalidOperationException("The result of the error value is not expected");

        public static implicit operator Result<Tvalue>(Tvalue value) => Create(value); 

    }