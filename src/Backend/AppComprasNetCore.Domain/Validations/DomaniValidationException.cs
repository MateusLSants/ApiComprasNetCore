namespace AppComprasNetCore.Domain.Validations;

internal class DomaniValidationException : Exception
{
	public DomaniValidationException(string error) : base()
	{ }

	public static void When(bool hasError , string message)
	{
		if (hasError)
		{
			throw new DomaniValidationException(message);
		}
	}
}
