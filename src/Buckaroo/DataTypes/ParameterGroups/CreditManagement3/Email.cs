namespace Buckaroo
{
  public class EmailAddress : ParameterGroup
  {
    public override string GroupName => "Email";

    /// <summary>
    /// The consumer email address 
    /// </summary>
    public string Email { get; set; }
  }
}