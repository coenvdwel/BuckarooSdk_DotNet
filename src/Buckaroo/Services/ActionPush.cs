using System;
using System.Linq;

namespace Buckaroo
{
  public abstract class ActionPush
  {
    public abstract ServiceEnum ServiceEnum { get; }

    public virtual void FillFromPush(ServiceResponse servicePush)
    {
      var ownType = GetType();
      var publicProperties = ownType.GetProperties(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Instance);

      foreach (var property in publicProperties)
      {
        var propertyName = property.Name;

        // TODO: Make dictionary/lookup?
        var parameter = GetParameter(servicePush, propertyName);

        if (parameter == null)
        {
          continue;
        }

        var convertedValue = ConvertValue(parameter.Value, property.PropertyType);
        property.SetValue(this, convertedValue);
      }
    }

    protected ResponseParameter GetParameter(ServiceResponse serviceResponse, string parameterName)
    {
      return serviceResponse.Parameters.FirstOrDefault(param => param.Name.Equals(parameterName, StringComparison.OrdinalIgnoreCase));
    }

    protected T ConvertValue<T>(string value)
    {
      return (T)ConvertValue(value, typeof(T));
    }

    protected object ConvertValue(string value, Type toType)
    {
      return Convert.ChangeType(value, toType);
    }
  }
}