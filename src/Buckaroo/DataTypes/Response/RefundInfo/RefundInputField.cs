﻿namespace Buckaroo
{
  public class RefundInputField
  {
    public RefundParameterDescription FieldDefenition { get; set; }
    public string CurrentValue { get; set; }
    public bool CurrentValueNotCorrect { get; set; }
    public bool CurrentValueEditable { get; set; }
  }
}