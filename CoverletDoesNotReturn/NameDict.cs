namespace CoverletDoesNotReturn
{
    public class NameDict
    {
        private readonly HashSet<string> _propertyNames = new();
        private readonly List<KeyValuePair<string, object?>> _propertyValues = new();

        public void Add(string propertyName, object? propertyValue)
        {
            if (_propertyNames.Add(propertyName))
            {
                _propertyValues.Add(new KeyValuePair<string, object?>(propertyName, propertyValue));
            }
            else
            {
                Helper.ArgumentException(nameof(propertyName), $"Property with name '{propertyName}' was already added");
            }
        }
    }
}