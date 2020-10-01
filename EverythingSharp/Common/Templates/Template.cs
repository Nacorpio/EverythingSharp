using EverythingSharp.API.Templates;

namespace EverythingSharp.Common.Templates
{

  public abstract class TemplateBase : ITemplate
  {
    protected internal TemplateBase(ulong? id)
    {
      Id = id;

      Name = "<Name>";
      DisplayName = "<DisplayName>";
      Summary = "<Summary>";
    }

    public ulong? Id { get; }

    public string Name { get; set; }
    public string DisplayName { get; set; }
    public string Summary { get; set; }
  }

}