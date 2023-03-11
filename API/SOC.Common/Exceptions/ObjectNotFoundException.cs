using System.Text.RegularExpressions;

namespace SOC.Common.Exceptions
{
    public class ObjectNotFoundException : Exception
    {
        private static String objectNotFoundMessage = "{0} with provided id ({1}) could not be found.";
        public ObjectNotFoundException(Type objectType, Guid id) : base(GetExceptionMessage(objectType, id))
        {

        }

        private static string GetExceptionMessage(Type objectType, Guid id)
        {
            return String.Format(objectNotFoundMessage, Regex.Replace(objectType.Name, "([a-z])([A-Z])", "$1 $2"), id);
        }

    }
}