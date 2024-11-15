namespace Usuarios.Domain.Abstractions;
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

        }
    }