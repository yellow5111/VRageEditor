﻿// Decompiled with JetBrains decompiler
// Type: Microsoft.Xml.Serialization.GeneratedAssembly.SerializableBoundingBoxDSerializer
// Assembly: VRage.XmlSerializers, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A6DCFDC0-3000-43E3-988A-2A1D50DBB2EA
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\SpaceEngineers\Tools\VRageEditor\Plugins\ModelBuilder\net48\VRage.XmlSerializers.dll

using System.Xml;
using System.Xml.Serialization;

#nullable disable
namespace Microsoft.Xml.Serialization.GeneratedAssembly
{
  public sealed class SerializableBoundingBoxDSerializer : XmlSerializer1
  {
    public override bool CanDeserialize(XmlReader xmlReader)
    {
      return xmlReader.IsStartElement("SerializableBoundingBoxD", "");
    }

    protected override void Serialize(object objectToSerialize, XmlSerializationWriter writer)
    {
      ((XmlSerializationWriter1) writer).Write88_SerializableBoundingBoxD(objectToSerialize);
    }

    protected override object Deserialize(XmlSerializationReader reader)
    {
      return ((XmlSerializationReader1) reader).Read93_SerializableBoundingBoxD();
    }
  }
}
