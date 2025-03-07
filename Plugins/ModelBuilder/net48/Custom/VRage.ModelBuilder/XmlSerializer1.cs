// Decompiled with JetBrains decompiler
// Type: Microsoft.Xml.Serialization.GeneratedAssembly.XmlSerializer1
// Assembly: VRage.XmlSerializers, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A6DCFDC0-3000-43E3-988A-2A1D50DBB2EA
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\SpaceEngineers\Tools\VRageEditor\Plugins\ModelBuilder\net48\VRage.XmlSerializers.dll

using System.Xml.Serialization;

#nullable disable
namespace Microsoft.Xml.Serialization.GeneratedAssembly
{
  public abstract class XmlSerializer1 : XmlSerializer
  {
    protected override XmlSerializationReader CreateReader()
    {
      return (XmlSerializationReader) new XmlSerializationReader1();
    }

    protected override XmlSerializationWriter CreateWriter()
    {
      return (XmlSerializationWriter) new XmlSerializationWriter1();
    }
  }
}
