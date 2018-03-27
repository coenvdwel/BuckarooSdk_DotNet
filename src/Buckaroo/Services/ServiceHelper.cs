using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Buckaroo
{
  internal static class ServiceHelper
  {
    internal static List<RequestParameter> CreateServiceParameters(object request)
    {
      return CreateServiceParametersImplementation(request);
    }

    private static List<RequestParameter> CreateServiceParametersImplementation(object fullOrPartialRequest, string groupName = "", string groupId = "")
    {
      var result = new List<RequestParameter>();

      var properties = fullOrPartialRequest.GetType().GetProperties(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Instance)
          .Where(property => property.Name != nameof(IParameterGroup.GroupName))
          .ToList();

      foreach (var property in properties)
      {
        var propertyValue = property.GetValue(fullOrPartialRequest);

        if (propertyValue == null)
        {
          continue;
        }

        // Group with EVERY PARAM MaxOccurs > 1:
        // Recurse into this method for each item
        if (propertyValue is IParameterGroupCollection)
        {
          var groupValue = propertyValue as IParameterGroupCollection;
          var i = 1;
          foreach (var item in groupValue)
          {
            var subResult = CreateServiceParametersImplementation(item, groupValue.GroupName, i.ToString());
            result.AddRange(subResult);
            i++;
          }
        }

        // Group:
        // Recurse into this method
        else if (propertyValue is IParameterGroup)
        {
          var groupValue = propertyValue as IParameterGroup;
          var subResult = CreateServiceParametersImplementation(groupValue, groupValue.GroupName);
          result.AddRange(subResult);
        }

        // No group, but MaxOccurs > 1:
        // Make param for each item
        else if (propertyValue is System.Collections.IEnumerable && !(propertyValue is string))
        {
          var collectionValue = propertyValue as System.Collections.IEnumerable;
          var i = 1;
          foreach (var item in collectionValue)
          {
            result.Add(CreateParameter(item, property.Name, groupName, i.ToString()));
            i++;
          }
        }

        // typecast enumerations to their integer equivalent
        else if (propertyValue is Enum)
        {
          result.Add(CreateParameter((int)propertyValue, property.Name, groupName, groupId));
        }

        // No group, MaxOccurs = 1 (simple parameter):
        // Make param for this item
        else
        {
          result.Add(CreateParameter(propertyValue, property.Name, groupName, groupId));
        }
      }

      return result;
    }

    private static RequestParameter CreateParameter(object value, string name, string groupName = "", string groupId = "")
    {
      return new RequestParameter
      {
        Name = name,
        Value = StringifyParameter(value),
        GroupType = groupName,
        GroupId = groupId,
      };
    }

    private static string StringifyParameter(object value)
    {
      return (value is decimal)
        ? ((decimal)value).ToString(CultureInfo.InvariantCulture)
        : value?.ToString();
    }
  }
}