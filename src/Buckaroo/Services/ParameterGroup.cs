﻿using System.Collections;
using System.Collections.Generic;

namespace Buckaroo
{
  public interface IParameterGroup
  {
    string GroupName { get; }
  }

  public abstract class ParameterGroup : IParameterGroup
  {
    public virtual string GroupName => this.GetType().Name;
  }

  public interface IParameterGroupCollection : IEnumerable
  {
    string GroupName { get; }
  }

  public class ParameterGroupCollection<T> : List<T>, IParameterGroupCollection
  {
    public string GroupName { get; set; }

    public ParameterGroupCollection(string groupName)
    {
      GroupName = groupName;
    }
  }
}