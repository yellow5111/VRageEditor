// Decompiled with JetBrains decompiler
// Type: Microsoft.Xml.Serialization.GeneratedAssembly.XmlSerializationWriter1
// Assembly: VRage.XmlSerializers, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A6DCFDC0-3000-43E3-988A-2A1D50DBB2EA
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\SpaceEngineers\Tools\VRageEditor\Plugins\ModelBuilder\net48\VRage.XmlSerializers.dll

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Xml;
using System.Xml.Serialization;
using VRage;
using VRage.Audio;
using VRage.Data.Audio;
using VRage.GameServices;
using VRage.Library.Utils;
using VRage.Network;
using VRage.Serialization;
using VRage.Voxels;
using VRageMath;

#nullable disable
namespace Microsoft.Xml.Serialization.GeneratedAssembly
{
  public class XmlSerializationWriter1 : XmlSerializationWriter
  {
    public void Write83_DistantSound(object o)
    {
      this.WriteStartDocument();
      if (o == null)
      {
        this.WriteNullTagLiteral("DistantSound", "");
      }
      else
      {
        this.TopLevelElement();
        this.Write67_DistantSound("DistantSound", "", (DistantSound) o, true, false);
      }
    }

    public void Write84_Wave(object o)
    {
      this.WriteStartDocument();
      if (o == null)
      {
        this.WriteNullTagLiteral("Wave", "");
      }
      else
      {
        this.TopLevelElement();
        this.Write34_MyAudioWave("Wave", "", (MyAudioWave) o, true, false);
      }
    }

    public void Write85_MyDeltaTransform(object o)
    {
      this.WriteStartDocument();
      if (o == null)
        this.WriteEmptyTag("MyDeltaTransform", "");
      else
        this.Write26_MyDeltaTransform("MyDeltaTransform", "", (MyDeltaTransform) o, false);
    }

    public void Write86_MyOrientation(object o)
    {
      this.WriteStartDocument();
      if (o == null)
        this.WriteEmptyTag("MyOrientation", "");
      else
        this.Write61_MyOrientation("MyOrientation", "", (MyOrientation) o, false);
    }

    public void Write87_MyPositionAndOrientation(object o)
    {
      this.WriteStartDocument();
      if (o == null)
        this.WriteEmptyTag("MyPositionAndOrientation", "");
      else
        this.Write19_MyPositionAndOrientation("MyPositionAndOrientation", "", (MyPositionAndOrientation) o, false);
    }

    public void Write88_SerializableBoundingBoxD(object o)
    {
      this.WriteStartDocument();
      if (o == null)
        this.WriteEmptyTag("SerializableBoundingBoxD", "");
      else
        this.Write48_SerializableBoundingBoxD("SerializableBoundingBoxD", "", (SerializableBoundingBoxD) o, false);
    }

    public void Write89_SerializableBounds(object o)
    {
      this.WriteStartDocument();
      if (o == null)
        this.WriteEmptyTag("SerializableBounds", "");
      else
        this.Write2_SerializableBounds("SerializableBounds", "", (SerializableBounds) o, false);
    }

    public void Write90_Item(object o)
    {
      this.WriteStartDocument();
      if (o == null)
        this.WriteEmptyTag("SerializableOrientedBoundingBoxD", "");
      else
        this.Write65_Item("SerializableOrientedBoundingBoxD", "", (SerializableOrientedBoundingBoxD) o, false);
    }

    public void Write91_SerializableQuaternion(object o)
    {
      this.WriteStartDocument();
      if (o == null)
        this.WriteEmptyTag("SerializableQuaternion", "");
      else
        this.Write54_SerializableQuaternion("SerializableQuaternion", "", (SerializableQuaternion) o, false);
    }

    public void Write92_SerializableVector2(object o)
    {
      this.WriteStartDocument();
      if (o == null)
        this.WriteEmptyTag("SerializableVector2", "");
      else
        this.Write21_SerializableVector2("SerializableVector2", "", (SerializableVector2) o, false);
    }

    public void Write93_SerializableVector2I(object o)
    {
      this.WriteStartDocument();
      if (o == null)
        this.WriteEmptyTag("SerializableVector2I", "");
      else
        this.Write50_SerializableVector2I("SerializableVector2I", "", (SerializableVector2I) o, false);
    }

    public void Write94_SerializableVector3(object o)
    {
      this.WriteStartDocument();
      if (o == null)
        this.WriteEmptyTag("SerializableVector3", "");
      else
        this.Write69_SerializableVector3("SerializableVector3", "", (SerializableVector3) o, false);
    }

    public void Write95_SerializableVector3D(object o)
    {
      this.WriteStartDocument();
      if (o == null)
        this.WriteEmptyTag("SerializableVector3D", "");
      else
        this.Write80_SerializableVector3D("SerializableVector3D", "", (SerializableVector3D) o, false);
    }

    public void Write96_SerializableVector3I(object o)
    {
      this.WriteStartDocument();
      if (o == null)
        this.WriteEmptyTag("SerializableVector3I", "");
      else
        this.Write39_SerializableVector3I("SerializableVector3I", "", (SerializableVector3I) o, false);
    }

    public void Write97_SerializableVector3UByte(object o)
    {
      this.WriteStartDocument();
      if (o == null)
        this.WriteEmptyTag("SerializableVector3UByte", "");
      else
        this.Write43_SerializableVector3UByte("SerializableVector3UByte", "", (SerializableVector3UByte) o, false);
    }

    public void Write98_MyStorageData(object o)
    {
      this.WriteStartDocument();
      if (o == null)
      {
        this.WriteNullTagLiteral("MyStorageData", "");
      }
      else
      {
        this.TopLevelElement();
        this.Write41_MyStorageData("MyStorageData", "", (MyStorageData) o, true, false);
      }
    }

    public void Write99_MyStringHash(object o)
    {
      this.WriteStartDocument();
      if (o == null)
        this.WriteEmptyTag("MyStringHash", "");
      else
        this.WriteSerializable((IXmlSerializable) o, "MyStringHash", "", false, true);
    }

    public void Write100_SerializableBoundingSphereD(object o)
    {
      this.WriteStartDocument();
      if (o == null)
        this.WriteEmptyTag("SerializableBoundingSphereD", "");
      else
        this.Write37_SerializableBoundingSphereD("SerializableBoundingSphereD", "", (SerializableBoundingSphereD) o, false);
    }

    public void Write101_EndpointId(object o)
    {
      this.WriteStartDocument();
      if (o == null)
        this.WriteEmptyTag("EndpointId", "");
      else
        this.Write82_EndpointId("EndpointId", "", (EndpointId) o, false);
    }

    public void Write102_JoinResultMsg(object o)
    {
      this.WriteStartDocument();
      if (o == null)
        this.WriteEmptyTag("JoinResultMsg", "");
      else
        this.Write59_JoinResultMsg("JoinResultMsg", "", (JoinResultMsg) o, false);
    }

    public void Write103_ServerDataMsg(object o)
    {
      this.WriteStartDocument();
      if (o == null)
        this.WriteEmptyTag("ServerDataMsg", "");
      else
        this.Write29_ServerDataMsg("ServerDataMsg", "", (ServerDataMsg) o, false);
    }

    public void Write104_BlockList(object o)
    {
      this.WriteStartDocument();
      if (o == null)
        this.WriteEmptyTag("BlockList", "");
      else
        this.Write45_BlockList("BlockList", "", (BlockList) o, false);
    }

    public void Write105_ChatMsg(object o)
    {
      this.WriteStartDocument();
      if (o == null)
        this.WriteEmptyTag("ChatMsg", "");
      else
        this.Write14_ChatMsg("ChatMsg", "", (ChatMsg) o, false);
    }

    public void Write106_ConnectedClientDataMsg(object o)
    {
      this.WriteStartDocument();
      if (o == null)
        this.WriteEmptyTag("ConnectedClientDataMsg", "");
      else
        this.Write78_ConnectedClientDataMsg("ConnectedClientDataMsg", "", (ConnectedClientDataMsg) o, false);
    }

    public void Write107_ClientReadyDataMsg(object o)
    {
      this.WriteStartDocument();
      if (o == null)
        this.WriteEmptyTag("ClientReadyDataMsg", "");
      else
        this.Write52_ClientReadyDataMsg("ClientReadyDataMsg", "", (ClientReadyDataMsg) o, false);
    }

    public void Write108_ChatMessageCustomData(object o)
    {
      this.WriteStartDocument();
      if (o == null)
        this.WriteEmptyTag("ChatMessageCustomData", "");
      else
        this.Write10_ChatMessageCustomData("ChatMessageCustomData", "", (ChatMessageCustomData) o, false);
    }

    public void Write109_MyGameInventoryItem(object o)
    {
      this.WriteStartDocument();
      if (o == null)
      {
        this.WriteNullTagLiteral("MyGameInventoryItem", "");
      }
      else
      {
        this.TopLevelElement();
        this.Write75_MyGameInventoryItem("MyGameInventoryItem", "", (MyGameInventoryItem) o, true, false);
      }
    }

    public void Write110_MyGameInventoryItemDefinition(object o)
    {
      this.WriteStartDocument();
      if (o == null)
      {
        this.WriteNullTagLiteral("MyGameInventoryItemDefinition", "");
      }
      else
      {
        this.TopLevelElement();
        this.Write7_MyGameInventoryItemDefinition("MyGameInventoryItemDefinition", "", (MyGameInventoryItemDefinition) o, true, false);
      }
    }

    public void Write111_ModMetadata(object o)
    {
      this.WriteStartDocument();
      if (o == null)
      {
        this.WriteNullTagLiteral("ModMetadata", "");
      }
      else
      {
        this.TopLevelElement();
        this.Write56_ModMetadataFile("ModMetadata", "", (ModMetadataFile) o, true, false);
      }
    }

    public void Write112_MyCueId(object o)
    {
      this.WriteStartDocument();
      if (o == null)
        this.WriteEmptyTag("MyCueId", "");
      else
        this.Write31_MyCueId("MyCueId", "", (MyCueId) o, false);
    }

    private void Write31_MyCueId(string n, string ns, MyCueId o, bool needType)
    {
      if (!needType && !(o.GetType() == typeof (MyCueId)))
        throw this.CreateUnknownTypeException((object) o);
      this.WriteStartElement(n, ns, (object) o, false, (XmlSerializerNamespaces) null);
      if (needType)
        this.WriteXsiType("MyCueId", "");
      this.WriteSerializable((IXmlSerializable) o.Hash, "Hash", "", false, true);
      this.WriteEndElement((object) o);
    }

    private void Write56_ModMetadataFile(
      string n,
      string ns,
      ModMetadataFile o,
      bool isNullable,
      bool needType)
    {
      if (o == null)
      {
        if (!isNullable)
          return;
        this.WriteNullTagLiteral(n, ns);
      }
      else
      {
        if (!needType && !(o.GetType() == typeof (ModMetadataFile)))
          throw this.CreateUnknownTypeException((object) o);
        this.WriteStartElement(n, ns, (object) o, false, (XmlSerializerNamespaces) null);
        if (needType)
          this.WriteXsiType("ModMetadataFile", "");
        this.WriteElementString("ModVersion", "", o.ModVersion);
        this.WriteElementString("MinGameVersion", "", o.MinGameVersion);
        this.WriteElementString("MaxGameVersion", "", o.MaxGameVersion);
        this.WriteEndElement((object) o);
      }
    }

    private void Write7_MyGameInventoryItemDefinition(
      string n,
      string ns,
      MyGameInventoryItemDefinition o,
      bool isNullable,
      bool needType)
    {
      if (o == null)
      {
        if (!isNullable)
          return;
        this.WriteNullTagLiteral(n, ns);
      }
      else
      {
        if (!needType && !(o.GetType() == typeof (MyGameInventoryItemDefinition)))
          throw this.CreateUnknownTypeException((object) o);
        this.WriteStartElement(n, ns, (object) o, false, (XmlSerializerNamespaces) null);
        if (needType)
          this.WriteXsiType("MyGameInventoryItemDefinition", "");
        this.WriteElementStringRaw("ID", "", XmlConvert.ToString(o.ID));
        this.WriteElementString("Name", "", o.Name);
        this.WriteElementString("Tradable", "", o.Tradable);
        this.WriteElementString("Marketable", "", o.Marketable);
        this.WriteElementString("Description", "", o.Description);
        this.WriteElementString("DisplayType", "", o.DisplayType);
        this.WriteElementString("IconTexture", "", o.IconTexture);
        this.WriteElementString("AssetModifierId", "", o.AssetModifierId);
        this.WriteElementString("ItemSlot", "", this.Write3_MyGameInventoryItemSlot(o.ItemSlot));
        this.WriteElementString("ToolName", "", o.ToolName);
        this.WriteElementString("NameColor", "", o.NameColor);
        this.WriteElementString("BackgroundColor", "", o.BackgroundColor);
        this.WriteElementString("DefinitionType", "", this.Write4_Item(o.DefinitionType));
        this.WriteElementStringRaw("Hidden", "", XmlConvert.ToString(o.Hidden));
        this.WriteElementStringRaw("IsStoreHidden", "", XmlConvert.ToString(o.IsStoreHidden));
        this.WriteElementStringRaw("CanBePurchased", "", XmlConvert.ToString(o.CanBePurchased));
        this.WriteElementString("ItemQuality", "", this.Write5_MyGameInventoryItemQuality(o.ItemQuality));
        this.WriteElementString("Exchange", "", o.Exchange);
        this.WriteEndElement((object) o);
      }
    }

    private string Write5_MyGameInventoryItemQuality(MyGameInventoryItemQuality v)
    {
      string str;
      switch (v)
      {
        case MyGameInventoryItemQuality.Common:
          str = "Common";
          break;
        case MyGameInventoryItemQuality.Uncommon:
          str = "Uncommon";
          break;
        case MyGameInventoryItemQuality.Unusual:
          str = "Unusual";
          break;
        case MyGameInventoryItemQuality.Rare:
          str = "Rare";
          break;
        case MyGameInventoryItemQuality.Exceptional:
          str = "Exceptional";
          break;
        default:
          throw this.CreateInvalidEnumValueException((object) ((long) v).ToString((IFormatProvider) CultureInfo.InvariantCulture), "VRage.GameServices.MyGameInventoryItemQuality");
      }
      return str;
    }

    private string Write4_Item(MyGameInventoryItemDefinitionType v)
    {
      string str;
      switch (v)
      {
        case MyGameInventoryItemDefinitionType.none:
          str = "none";
          break;
        case MyGameInventoryItemDefinitionType.item:
          str = "item";
          break;
        case MyGameInventoryItemDefinitionType.bundle:
          str = "bundle";
          break;
        case MyGameInventoryItemDefinitionType.generator:
          str = "generator";
          break;
        case MyGameInventoryItemDefinitionType.playtimegenerator:
          str = "playtimegenerator";
          break;
        default:
          throw this.CreateInvalidEnumValueException((object) ((long) v).ToString((IFormatProvider) CultureInfo.InvariantCulture), "VRage.GameServices.MyGameInventoryItemDefinitionType");
      }
      return str;
    }

    private string Write3_MyGameInventoryItemSlot(MyGameInventoryItemSlot v)
    {
      string str;
      switch (v)
      {
        case MyGameInventoryItemSlot.None:
          str = "None";
          break;
        case MyGameInventoryItemSlot.Face:
          str = "Face";
          break;
        case MyGameInventoryItemSlot.Helmet:
          str = "Helmet";
          break;
        case MyGameInventoryItemSlot.Gloves:
          str = "Gloves";
          break;
        case MyGameInventoryItemSlot.Boots:
          str = "Boots";
          break;
        case MyGameInventoryItemSlot.Suit:
          str = "Suit";
          break;
        case MyGameInventoryItemSlot.Rifle:
          str = "Rifle";
          break;
        case MyGameInventoryItemSlot.Welder:
          str = "Welder";
          break;
        case MyGameInventoryItemSlot.Grinder:
          str = "Grinder";
          break;
        case MyGameInventoryItemSlot.Drill:
          str = "Drill";
          break;
        case MyGameInventoryItemSlot.Emote:
          str = "Emote";
          break;
        case MyGameInventoryItemSlot.Armor:
          str = "Armor";
          break;
        default:
          throw this.CreateInvalidEnumValueException((object) ((long) v).ToString((IFormatProvider) CultureInfo.InvariantCulture), "VRage.GameServices.MyGameInventoryItemSlot");
      }
      return str;
    }

    private void Write75_MyGameInventoryItem(
      string n,
      string ns,
      MyGameInventoryItem o,
      bool isNullable,
      bool needType)
    {
      if (o == null)
      {
        if (!isNullable)
          return;
        this.WriteNullTagLiteral(n, ns);
      }
      else
      {
        if (!needType && !(o.GetType() == typeof (MyGameInventoryItem)))
          throw this.CreateUnknownTypeException((object) o);
        this.WriteStartElement(n, ns, (object) o, false, (XmlSerializerNamespaces) null);
        if (needType)
          this.WriteXsiType("MyGameInventoryItem", "");
        this.WriteElementStringRaw("ID", "", XmlConvert.ToString(o.ID));
        this.Write74_MyGameInventoryItemDefinition("ItemDefinition", "", o.ItemDefinition, false, false);
        this.WriteElementStringRaw("Quantity", "", XmlConvert.ToString(o.Quantity));
        HashSet<long> usingCharacters = o.UsingCharacters;
        if (usingCharacters != null)
        {
          this.WriteStartElement("UsingCharacters", "", (object) null, false);
          IEnumerator enumerator = (IEnumerator) usingCharacters.GetEnumerator();
          if (enumerator != null)
          {
            while (enumerator.MoveNext())
              this.WriteElementStringRaw("long", "", XmlConvert.ToString((long) enumerator.Current));
          }
          this.WriteEndElement();
        }
        this.WriteElementStringRaw("IsStoreFakeItem", "", XmlConvert.ToString(o.IsStoreFakeItem));
        this.WriteElementStringRaw("IsNew", "", XmlConvert.ToString(o.IsNew));
        this.WriteEndElement((object) o);
      }
    }

    private void Write74_MyGameInventoryItemDefinition(
      string n,
      string ns,
      MyGameInventoryItemDefinition o,
      bool isNullable,
      bool needType)
    {
      if (o == null)
      {
        if (!isNullable)
          return;
        this.WriteNullTagLiteral(n, ns);
      }
      else
      {
        if (!needType && !(o.GetType() == typeof (MyGameInventoryItemDefinition)))
          throw this.CreateUnknownTypeException((object) o);
        this.WriteStartElement(n, ns, (object) o, false, (XmlSerializerNamespaces) null);
        if (needType)
          this.WriteXsiType("MyGameInventoryItemDefinition", "");
        this.WriteElementStringRaw("ID", "", XmlConvert.ToString(o.ID));
        this.WriteElementString("Name", "", o.Name);
        this.WriteElementString("Tradable", "", o.Tradable);
        this.WriteElementString("Marketable", "", o.Marketable);
        this.WriteElementString("Description", "", o.Description);
        this.WriteElementString("DisplayType", "", o.DisplayType);
        this.WriteElementString("IconTexture", "", o.IconTexture);
        this.WriteElementString("AssetModifierId", "", o.AssetModifierId);
        this.WriteElementString("ItemSlot", "", this.Write70_MyGameInventoryItemSlot(o.ItemSlot));
        this.WriteElementString("ToolName", "", o.ToolName);
        this.WriteElementString("NameColor", "", o.NameColor);
        this.WriteElementString("BackgroundColor", "", o.BackgroundColor);
        this.WriteElementString("DefinitionType", "", this.Write71_Item(o.DefinitionType));
        this.WriteElementStringRaw("Hidden", "", XmlConvert.ToString(o.Hidden));
        this.WriteElementStringRaw("IsStoreHidden", "", XmlConvert.ToString(o.IsStoreHidden));
        this.WriteElementStringRaw("CanBePurchased", "", XmlConvert.ToString(o.CanBePurchased));
        this.WriteElementString("ItemQuality", "", this.Write72_MyGameInventoryItemQuality(o.ItemQuality));
        this.WriteElementString("Exchange", "", o.Exchange);
        this.WriteEndElement((object) o);
      }
    }

    private string Write72_MyGameInventoryItemQuality(MyGameInventoryItemQuality v)
    {
      string str;
      switch (v)
      {
        case MyGameInventoryItemQuality.Common:
          str = "Common";
          break;
        case MyGameInventoryItemQuality.Uncommon:
          str = "Uncommon";
          break;
        case MyGameInventoryItemQuality.Unusual:
          str = "Unusual";
          break;
        case MyGameInventoryItemQuality.Rare:
          str = "Rare";
          break;
        case MyGameInventoryItemQuality.Exceptional:
          str = "Exceptional";
          break;
        default:
          throw this.CreateInvalidEnumValueException((object) ((long) v).ToString((IFormatProvider) CultureInfo.InvariantCulture), "VRage.GameServices.MyGameInventoryItemQuality");
      }
      return str;
    }

    private string Write71_Item(MyGameInventoryItemDefinitionType v)
    {
      string str;
      switch (v)
      {
        case MyGameInventoryItemDefinitionType.none:
          str = "none";
          break;
        case MyGameInventoryItemDefinitionType.item:
          str = "item";
          break;
        case MyGameInventoryItemDefinitionType.bundle:
          str = "bundle";
          break;
        case MyGameInventoryItemDefinitionType.generator:
          str = "generator";
          break;
        case MyGameInventoryItemDefinitionType.playtimegenerator:
          str = "playtimegenerator";
          break;
        default:
          throw this.CreateInvalidEnumValueException((object) ((long) v).ToString((IFormatProvider) CultureInfo.InvariantCulture), "VRage.GameServices.MyGameInventoryItemDefinitionType");
      }
      return str;
    }

    private string Write70_MyGameInventoryItemSlot(MyGameInventoryItemSlot v)
    {
      string str;
      switch (v)
      {
        case MyGameInventoryItemSlot.None:
          str = "None";
          break;
        case MyGameInventoryItemSlot.Face:
          str = "Face";
          break;
        case MyGameInventoryItemSlot.Helmet:
          str = "Helmet";
          break;
        case MyGameInventoryItemSlot.Gloves:
          str = "Gloves";
          break;
        case MyGameInventoryItemSlot.Boots:
          str = "Boots";
          break;
        case MyGameInventoryItemSlot.Suit:
          str = "Suit";
          break;
        case MyGameInventoryItemSlot.Rifle:
          str = "Rifle";
          break;
        case MyGameInventoryItemSlot.Welder:
          str = "Welder";
          break;
        case MyGameInventoryItemSlot.Grinder:
          str = "Grinder";
          break;
        case MyGameInventoryItemSlot.Drill:
          str = "Drill";
          break;
        case MyGameInventoryItemSlot.Emote:
          str = "Emote";
          break;
        case MyGameInventoryItemSlot.Armor:
          str = "Armor";
          break;
        default:
          throw this.CreateInvalidEnumValueException((object) ((long) v).ToString((IFormatProvider) CultureInfo.InvariantCulture), "VRage.GameServices.MyGameInventoryItemSlot");
      }
      return str;
    }

    private void Write10_ChatMessageCustomData(
      string n,
      string ns,
      ChatMessageCustomData o,
      bool needType)
    {
      if (!needType && !(o.GetType() == typeof (ChatMessageCustomData)))
        throw this.CreateUnknownTypeException((object) o);
      this.WriteStartElement(n, ns, (object) o, false, (XmlSerializerNamespaces) null);
      if (needType)
        this.WriteXsiType("ChatMessageCustomData", "");
      this.WriteElementString("AuthorName", "", o.AuthorName);
      if (o.SenderId.HasValue)
        this.WriteNullableStringLiteralRaw("SenderId", "", XmlConvert.ToString(o.SenderId.Value));
      else
        this.WriteNullTagLiteral("SenderId", "");
      if (o.TextColor.HasValue)
        this.Write9_Color("TextColor", "", o.TextColor.Value, false);
      else
        this.WriteNullTagLiteral("TextColor", "");
      this.WriteEndElement((object) o);
    }

    private void Write9_Color(string n, string ns, Color o, bool needType)
    {
      if (!needType && !(o.GetType() == typeof (Color)))
        throw this.CreateUnknownTypeException((object) o);
      this.WriteStartElement(n, ns, (object) o, false, (XmlSerializerNamespaces) null);
      if (needType)
        this.WriteXsiType("Color", "");
      this.WriteElementStringRaw("PackedValue", "", XmlConvert.ToString(o.PackedValue));
      this.WriteElementStringRaw("X", "", XmlConvert.ToString(o.X));
      this.WriteElementStringRaw("Y", "", XmlConvert.ToString(o.Y));
      this.WriteElementStringRaw("Z", "", XmlConvert.ToString(o.Z));
      this.WriteElementStringRaw("R", "", XmlConvert.ToString(o.R));
      this.WriteElementStringRaw("G", "", XmlConvert.ToString(o.G));
      this.WriteElementStringRaw("B", "", XmlConvert.ToString(o.B));
      this.WriteElementStringRaw("A", "", XmlConvert.ToString(o.A));
      this.WriteEndElement((object) o);
    }

    private void Write52_ClientReadyDataMsg(
      string n,
      string ns,
      ClientReadyDataMsg o,
      bool needType)
    {
      if (!needType && !(o.GetType() == typeof (ClientReadyDataMsg)))
        throw this.CreateUnknownTypeException((object) o);
      this.WriteStartElement(n, ns, (object) o, false, (XmlSerializerNamespaces) null);
      if (needType)
        this.WriteXsiType("ClientReadyDataMsg", "");
      this.WriteElementStringRaw("ForcePlayoutDelayBuffer", "", XmlConvert.ToString(o.ForcePlayoutDelayBuffer));
      this.WriteElementStringRaw("UsePlayoutDelayBufferForCharacter", "", XmlConvert.ToString(o.UsePlayoutDelayBufferForCharacter));
      this.WriteElementStringRaw("UsePlayoutDelayBufferForJetpack", "", XmlConvert.ToString(o.UsePlayoutDelayBufferForJetpack));
      this.WriteElementStringRaw("UsePlayoutDelayBufferForGrids", "", XmlConvert.ToString(o.UsePlayoutDelayBufferForGrids));
      this.WriteEndElement((object) o);
    }

    private void Write78_ConnectedClientDataMsg(
      string n,
      string ns,
      ConnectedClientDataMsg o,
      bool needType)
    {
      if (!needType && !(o.GetType() == typeof (ConnectedClientDataMsg)))
        throw this.CreateUnknownTypeException((object) o);
      this.WriteStartElement(n, ns, (object) o, false, (XmlSerializerNamespaces) null);
      if (needType)
        this.WriteXsiType("ConnectedClientDataMsg", "");
      this.Write77_EndpointId("ClientId", "", o.ClientId, false);
      this.WriteElementString("ServiceName", "", o.ServiceName);
      this.WriteElementString("Name", "", o.Name);
      this.WriteElementStringRaw("IsAdmin", "", XmlConvert.ToString(o.IsAdmin));
      this.WriteElementStringRaw("Join", "", XmlConvert.ToString(o.Join));
      this.WriteElementStringRaw("Token", "", XmlSerializationWriter.FromByteArrayBase64(o.Token));
      this.WriteElementStringRaw("ExperimentalMode", "", XmlConvert.ToString(o.ExperimentalMode));
      this.WriteElementStringRaw("IsProfiling", "", XmlConvert.ToString(o.IsProfiling));
      this.WriteEndElement((object) o);
    }

    private void Write77_EndpointId(string n, string ns, EndpointId o, bool needType)
    {
      if (!needType && !(o.GetType() == typeof (EndpointId)))
        throw this.CreateUnknownTypeException((object) o);
      this.WriteStartElement(n, ns, (object) o, false, (XmlSerializerNamespaces) null);
      if (needType)
        this.WriteXsiType("EndpointId", "");
      this.WriteEndElement((object) o);
    }

    private void Write14_ChatMsg(string n, string ns, ChatMsg o, bool needType)
    {
      if (!needType && !(o.GetType() == typeof (ChatMsg)))
        throw this.CreateUnknownTypeException((object) o);
      this.WriteStartElement(n, ns, (object) o, false, (XmlSerializerNamespaces) null);
      if (needType)
        this.WriteXsiType("ChatMsg", "");
      this.WriteElementString("Text", "", o.Text);
      this.WriteElementStringRaw("Author", "", XmlConvert.ToString(o.Author));
      this.WriteElementStringRaw("Channel", "", XmlConvert.ToString(o.Channel));
      this.WriteElementStringRaw("TargetId", "", XmlConvert.ToString(o.TargetId));
      this.WriteElementStringRaw("CrossChatEnabled", "", XmlConvert.ToString(o.CrossChatEnabled));
      if (o.CustomData.HasValue)
        this.Write13_ChatMessageCustomData("CustomData", "", o.CustomData.Value, false);
      else
        this.WriteNullTagLiteral("CustomData", "");
      this.WriteEndElement((object) o);
    }

    private void Write13_ChatMessageCustomData(
      string n,
      string ns,
      ChatMessageCustomData o,
      bool needType)
    {
      if (!needType && !(o.GetType() == typeof (ChatMessageCustomData)))
        throw this.CreateUnknownTypeException((object) o);
      this.WriteStartElement(n, ns, (object) o, false, (XmlSerializerNamespaces) null);
      if (needType)
        this.WriteXsiType("ChatMessageCustomData", "");
      this.WriteElementString("AuthorName", "", o.AuthorName);
      if (o.SenderId.HasValue)
        this.WriteNullableStringLiteralRaw("SenderId", "", XmlConvert.ToString(o.SenderId.Value));
      else
        this.WriteNullTagLiteral("SenderId", "");
      if (o.TextColor.HasValue)
        this.Write12_Color("TextColor", "", o.TextColor.Value, false);
      else
        this.WriteNullTagLiteral("TextColor", "");
      this.WriteEndElement((object) o);
    }

    private void Write12_Color(string n, string ns, Color o, bool needType)
    {
      if (!needType && !(o.GetType() == typeof (Color)))
        throw this.CreateUnknownTypeException((object) o);
      this.WriteStartElement(n, ns, (object) o, false, (XmlSerializerNamespaces) null);
      if (needType)
        this.WriteXsiType("Color", "");
      this.WriteElementStringRaw("PackedValue", "", XmlConvert.ToString(o.PackedValue));
      this.WriteElementStringRaw("X", "", XmlConvert.ToString(o.X));
      this.WriteElementStringRaw("Y", "", XmlConvert.ToString(o.Y));
      this.WriteElementStringRaw("Z", "", XmlConvert.ToString(o.Z));
      this.WriteElementStringRaw("R", "", XmlConvert.ToString(o.R));
      this.WriteElementStringRaw("G", "", XmlConvert.ToString(o.G));
      this.WriteElementStringRaw("B", "", XmlConvert.ToString(o.B));
      this.WriteElementStringRaw("A", "", XmlConvert.ToString(o.A));
      this.WriteEndElement((object) o);
    }

    private void Write45_BlockList(string n, string ns, BlockList o, bool needType)
    {
      if (!needType && !(o.GetType() == typeof (BlockList)))
        throw this.CreateUnknownTypeException((object) o);
      this.WriteStartElement(n, ns, (object) o, false, (XmlSerializerNamespaces) null);
      if (needType)
        this.WriteXsiType("BlockList", "");
      ulong[] blockedUsers = o.BlockedUsers;
      if (blockedUsers != null)
      {
        this.WriteStartElement("BlockedUsers", "", (object) null, false);
        for (int index = 0; index < blockedUsers.Length; ++index)
          this.WriteElementStringRaw("unsignedLong", "", XmlConvert.ToString(blockedUsers[index]));
        this.WriteEndElement();
      }
      this.WriteEndElement((object) o);
    }

    private void Write29_ServerDataMsg(string n, string ns, ServerDataMsg o, bool needType)
    {
      if (!needType && !(o.GetType() == typeof (ServerDataMsg)))
        throw this.CreateUnknownTypeException((object) o);
      this.WriteStartElement(n, ns, (object) o, false, (XmlSerializerNamespaces) null);
      if (needType)
        this.WriteXsiType("ServerDataMsg", "");
      this.WriteElementString("WorldName", "", o.WorldName);
      this.WriteElementString("GameMode", "", this.Write27_MyGameModeEnum(o.GameMode));
      this.WriteElementStringRaw("InventoryMultiplier", "", XmlConvert.ToString(o.InventoryMultiplier));
      this.WriteElementStringRaw("AssemblerMultiplier", "", XmlConvert.ToString(o.AssemblerMultiplier));
      this.WriteElementStringRaw("RefineryMultiplier", "", XmlConvert.ToString(o.RefineryMultiplier));
      this.WriteElementString("HostName", "", o.HostName);
      this.WriteElementStringRaw("WorldSize", "", XmlConvert.ToString(o.WorldSize));
      this.WriteElementStringRaw("AppVersion", "", XmlConvert.ToString(o.AppVersion));
      this.WriteElementStringRaw("MembersLimit", "", XmlConvert.ToString(o.MembersLimit));
      this.WriteElementString("DataHash", "", o.DataHash);
      this.WriteElementStringRaw("WelderMultiplier", "", XmlConvert.ToString(o.WelderMultiplier));
      this.WriteElementStringRaw("GrinderMultiplier", "", XmlConvert.ToString(o.GrinderMultiplier));
      this.WriteElementStringRaw("BlocksInventoryMultiplier", "", XmlConvert.ToString(o.BlocksInventoryMultiplier));
      this.WriteElementString("ServerPasswordSalt", "", o.ServerPasswordSalt);
      this.WriteElementString("ServerAnalyticsId", "", o.ServerAnalyticsId);
      this.WriteEndElement((object) o);
    }

    private string Write27_MyGameModeEnum(MyGameModeEnum v)
    {
      string str;
      switch (v)
      {
        case MyGameModeEnum.Creative:
          str = "Creative";
          break;
        case MyGameModeEnum.Survival:
          str = "Survival";
          break;
        default:
          throw this.CreateInvalidEnumValueException((object) ((long) v).ToString((IFormatProvider) CultureInfo.InvariantCulture), "VRage.Library.Utils.MyGameModeEnum");
      }
      return str;
    }

    private void Write59_JoinResultMsg(string n, string ns, JoinResultMsg o, bool needType)
    {
      if (!needType && !(o.GetType() == typeof (JoinResultMsg)))
        throw this.CreateUnknownTypeException((object) o);
      this.WriteStartElement(n, ns, (object) o, false, (XmlSerializerNamespaces) null);
      if (needType)
        this.WriteXsiType("JoinResultMsg", "");
      this.WriteElementString("JoinResult", "", this.Write57_JoinResult(o.JoinResult));
      this.WriteElementStringRaw("ServerExperimental", "", XmlConvert.ToString(o.ServerExperimental));
      this.WriteElementStringRaw("Admin", "", XmlConvert.ToString(o.Admin));
      this.WriteEndElement((object) o);
    }

    private string Write57_JoinResult(JoinResult v)
    {
      string str;
      switch (v)
      {
        case JoinResult.OK:
          str = "OK";
          break;
        case JoinResult.AlreadyJoined:
          str = "AlreadyJoined";
          break;
        case JoinResult.TicketInvalid:
          str = "TicketInvalid";
          break;
        case JoinResult.SteamServersOffline:
          str = "SteamServersOffline";
          break;
        case JoinResult.NotInGroup:
          str = "NotInGroup";
          break;
        case JoinResult.GroupIdInvalid:
          str = "GroupIdInvalid";
          break;
        case JoinResult.ServerFull:
          str = "ServerFull";
          break;
        case JoinResult.BannedByAdmins:
          str = "BannedByAdmins";
          break;
        case JoinResult.KickedRecently:
          str = "KickedRecently";
          break;
        case JoinResult.TicketCanceled:
          str = "TicketCanceled";
          break;
        case JoinResult.TicketAlreadyUsed:
          str = "TicketAlreadyUsed";
          break;
        case JoinResult.LoggedInElseWhere:
          str = "LoggedInElseWhere";
          break;
        case JoinResult.NoLicenseOrExpired:
          str = "NoLicenseOrExpired";
          break;
        case JoinResult.UserNotConnected:
          str = "UserNotConnected";
          break;
        case JoinResult.VACBanned:
          str = "VACBanned";
          break;
        case JoinResult.VACCheckTimedOut:
          str = "VACCheckTimedOut";
          break;
        case JoinResult.PasswordRequired:
          str = "PasswordRequired";
          break;
        case JoinResult.WrongPassword:
          str = "WrongPassword";
          break;
        case JoinResult.ExperimentalMode:
          str = "ExperimentalMode";
          break;
        case JoinResult.ProfilingNotAllowed:
          str = "ProfilingNotAllowed";
          break;
        case JoinResult.FamilySharing:
          str = "FamilySharing";
          break;
        case JoinResult.NotFound:
          str = "NotFound";
          break;
        case JoinResult.IncorrectTime:
          str = "IncorrectTime";
          break;
        default:
          throw this.CreateInvalidEnumValueException((object) ((long) v).ToString((IFormatProvider) CultureInfo.InvariantCulture), "VRage.Network.JoinResult");
      }
      return str;
    }

    private void Write82_EndpointId(string n, string ns, EndpointId o, bool needType)
    {
      if (!needType && !(o.GetType() == typeof (EndpointId)))
        throw this.CreateUnknownTypeException((object) o);
      this.WriteStartElement(n, ns, (object) o, false, (XmlSerializerNamespaces) null);
      if (needType)
        this.WriteXsiType("EndpointId", "");
      this.WriteEndElement((object) o);
    }

    private void Write37_SerializableBoundingSphereD(
      string n,
      string ns,
      SerializableBoundingSphereD o,
      bool needType)
    {
      if (!needType && !(o.GetType() == typeof (SerializableBoundingSphereD)))
        throw this.CreateUnknownTypeException((object) o);
      this.WriteStartElement(n, ns, (object) o, false, (XmlSerializerNamespaces) null);
      if (needType)
        this.WriteXsiType("SerializableBoundingSphereD", "");
      this.Write36_SerializableVector3D("Center", "", o.Center, false);
      this.WriteElementStringRaw("Radius", "", XmlConvert.ToString(o.Radius));
      this.WriteEndElement((object) o);
    }

    private void Write36_SerializableVector3D(
      string n,
      string ns,
      SerializableVector3D o,
      bool needType)
    {
      if (!needType && !(o.GetType() == typeof (SerializableVector3D)))
        throw this.CreateUnknownTypeException((object) o);
      this.WriteStartElement(n, ns, (object) o, false, (XmlSerializerNamespaces) null);
      if (needType)
        this.WriteXsiType("SerializableVector3D", "");
      this.WriteAttribute("x", "", XmlConvert.ToString(o.x));
      this.WriteAttribute("y", "", XmlConvert.ToString(o.y));
      this.WriteAttribute("z", "", XmlConvert.ToString(o.z));
      if (o.ShouldSerializeX())
        this.WriteElementStringRaw("X", "", XmlConvert.ToString(o.X));
      if (o.ShouldSerializeY())
        this.WriteElementStringRaw("Y", "", XmlConvert.ToString(o.Y));
      if (o.ShouldSerializeZ())
        this.WriteElementStringRaw("Z", "", XmlConvert.ToString(o.Z));
      this.WriteEndElement((object) o);
    }

    private void Write41_MyStorageData(
      string n,
      string ns,
      MyStorageData o,
      bool isNullable,
      bool needType)
    {
      if (o == null)
      {
        if (!isNullable)
          return;
        this.WriteNullTagLiteral(n, ns);
      }
      else
      {
        if (!needType && !(o.GetType() == typeof (MyStorageData)))
          throw this.CreateUnknownTypeException((object) o);
        this.WriteStartElement(n, ns, (object) o, false, (XmlSerializerNamespaces) null);
        if (needType)
          this.WriteXsiType("MyStorageData", "");
        this.WriteEndElement((object) o);
      }
    }

    private void Write43_SerializableVector3UByte(
      string n,
      string ns,
      SerializableVector3UByte o,
      bool needType)
    {
      if (!needType && !(o.GetType() == typeof (SerializableVector3UByte)))
        throw this.CreateUnknownTypeException((object) o);
      this.WriteStartElement(n, ns, (object) o, false, (XmlSerializerNamespaces) null);
      if (needType)
        this.WriteXsiType("SerializableVector3UByte", "");
      this.WriteAttribute("x", "", XmlConvert.ToString(o.x));
      this.WriteAttribute("y", "", XmlConvert.ToString(o.y));
      this.WriteAttribute("z", "", XmlConvert.ToString(o.z));
      if (o.ShouldSerializeX())
        this.WriteElementStringRaw("X", "", XmlConvert.ToString(o.X));
      if (o.ShouldSerializeY())
        this.WriteElementStringRaw("Y", "", XmlConvert.ToString(o.Y));
      if (o.ShouldSerializeZ())
        this.WriteElementStringRaw("Z", "", XmlConvert.ToString(o.Z));
      this.WriteEndElement((object) o);
    }

    private void Write39_SerializableVector3I(
      string n,
      string ns,
      SerializableVector3I o,
      bool needType)
    {
      if (!needType && !(o.GetType() == typeof (SerializableVector3I)))
        throw this.CreateUnknownTypeException((object) o);
      this.WriteStartElement(n, ns, (object) o, false, (XmlSerializerNamespaces) null);
      if (needType)
        this.WriteXsiType("SerializableVector3I", "");
      this.WriteAttribute("x", "", XmlConvert.ToString(o.x));
      this.WriteAttribute("y", "", XmlConvert.ToString(o.y));
      this.WriteAttribute("z", "", XmlConvert.ToString(o.z));
      if (o.ShouldSerializeX())
        this.WriteElementStringRaw("X", "", XmlConvert.ToString(o.X));
      if (o.ShouldSerializeY())
        this.WriteElementStringRaw("Y", "", XmlConvert.ToString(o.Y));
      if (o.ShouldSerializeZ())
        this.WriteElementStringRaw("Z", "", XmlConvert.ToString(o.Z));
      this.WriteEndElement((object) o);
    }

    private void Write80_SerializableVector3D(
      string n,
      string ns,
      SerializableVector3D o,
      bool needType)
    {
      if (!needType && !(o.GetType() == typeof (SerializableVector3D)))
        throw this.CreateUnknownTypeException((object) o);
      this.WriteStartElement(n, ns, (object) o, false, (XmlSerializerNamespaces) null);
      if (needType)
        this.WriteXsiType("SerializableVector3D", "");
      this.WriteAttribute("x", "", XmlConvert.ToString(o.x));
      this.WriteAttribute("y", "", XmlConvert.ToString(o.y));
      this.WriteAttribute("z", "", XmlConvert.ToString(o.z));
      if (o.ShouldSerializeX())
        this.WriteElementStringRaw("X", "", XmlConvert.ToString(o.X));
      if (o.ShouldSerializeY())
        this.WriteElementStringRaw("Y", "", XmlConvert.ToString(o.Y));
      if (o.ShouldSerializeZ())
        this.WriteElementStringRaw("Z", "", XmlConvert.ToString(o.Z));
      this.WriteEndElement((object) o);
    }

    private void Write69_SerializableVector3(
      string n,
      string ns,
      SerializableVector3 o,
      bool needType)
    {
      if (!needType && !(o.GetType() == typeof (SerializableVector3)))
        throw this.CreateUnknownTypeException((object) o);
      this.WriteStartElement(n, ns, (object) o, false, (XmlSerializerNamespaces) null);
      if (needType)
        this.WriteXsiType("SerializableVector3", "");
      this.WriteAttribute("x", "", XmlConvert.ToString(o.x));
      this.WriteAttribute("y", "", XmlConvert.ToString(o.y));
      this.WriteAttribute("z", "", XmlConvert.ToString(o.z));
      if (o.ShouldSerializeX())
        this.WriteElementStringRaw("X", "", XmlConvert.ToString(o.X));
      if (o.ShouldSerializeY())
        this.WriteElementStringRaw("Y", "", XmlConvert.ToString(o.Y));
      if (o.ShouldSerializeZ())
        this.WriteElementStringRaw("Z", "", XmlConvert.ToString(o.Z));
      this.WriteEndElement((object) o);
    }

    private void Write50_SerializableVector2I(
      string n,
      string ns,
      SerializableVector2I o,
      bool needType)
    {
      if (!needType && !(o.GetType() == typeof (SerializableVector2I)))
        throw this.CreateUnknownTypeException((object) o);
      this.WriteStartElement(n, ns, (object) o, false, (XmlSerializerNamespaces) null);
      if (needType)
        this.WriteXsiType("SerializableVector2I", "");
      this.WriteAttribute("x", "", XmlConvert.ToString(o.x));
      this.WriteAttribute("y", "", XmlConvert.ToString(o.y));
      if (o.ShouldSerializeX())
        this.WriteElementStringRaw("X", "", XmlConvert.ToString(o.X));
      if (o.ShouldSerializeY())
        this.WriteElementStringRaw("Y", "", XmlConvert.ToString(o.Y));
      this.WriteEndElement((object) o);
    }

    private void Write21_SerializableVector2(
      string n,
      string ns,
      SerializableVector2 o,
      bool needType)
    {
      if (!needType && !(o.GetType() == typeof (SerializableVector2)))
        throw this.CreateUnknownTypeException((object) o);
      this.WriteStartElement(n, ns, (object) o, false, (XmlSerializerNamespaces) null);
      if (needType)
        this.WriteXsiType("SerializableVector2", "");
      this.WriteAttribute("x", "", XmlConvert.ToString(o.x));
      this.WriteAttribute("y", "", XmlConvert.ToString(o.y));
      if (o.ShouldSerializeX())
        this.WriteElementStringRaw("X", "", XmlConvert.ToString(o.X));
      if (o.ShouldSerializeY())
        this.WriteElementStringRaw("Y", "", XmlConvert.ToString(o.Y));
      this.WriteEndElement((object) o);
    }

    private void Write54_SerializableQuaternion(
      string n,
      string ns,
      SerializableQuaternion o,
      bool needType)
    {
      if (!needType && !(o.GetType() == typeof (SerializableQuaternion)))
        throw this.CreateUnknownTypeException((object) o);
      this.WriteStartElement(n, ns, (object) o, false, (XmlSerializerNamespaces) null);
      if (needType)
        this.WriteXsiType("SerializableQuaternion", "");
      this.WriteAttribute("x", "", XmlConvert.ToString(o.x));
      this.WriteAttribute("y", "", XmlConvert.ToString(o.y));
      this.WriteAttribute("z", "", XmlConvert.ToString(o.z));
      this.WriteAttribute("w", "", XmlConvert.ToString(o.w));
      if (o.ShouldSerializeX())
        this.WriteElementStringRaw("X", "", XmlConvert.ToString(o.X));
      if (o.ShouldSerializeY())
        this.WriteElementStringRaw("Y", "", XmlConvert.ToString(o.Y));
      if (o.ShouldSerializeZ())
        this.WriteElementStringRaw("Z", "", XmlConvert.ToString(o.Z));
      if (o.ShouldSerializeW())
        this.WriteElementStringRaw("W", "", XmlConvert.ToString(o.W));
      this.WriteEndElement((object) o);
    }

    private void Write65_Item(
      string n,
      string ns,
      SerializableOrientedBoundingBoxD o,
      bool needType)
    {
      if (!needType && !(o.GetType() == typeof (SerializableOrientedBoundingBoxD)))
        throw this.CreateUnknownTypeException((object) o);
      this.WriteStartElement(n, ns, (object) o, false, (XmlSerializerNamespaces) null);
      if (needType)
        this.WriteXsiType("SerializableOrientedBoundingBoxD", "");
      this.Write63_SerializableVector3D("Center", "", o.Center, false);
      this.Write63_SerializableVector3D("HalfExtent", "", o.HalfExtent, false);
      this.Write64_SerializableQuaternion("Orientation", "", o.Orientation, false);
      this.WriteEndElement((object) o);
    }

    private void Write64_SerializableQuaternion(
      string n,
      string ns,
      SerializableQuaternion o,
      bool needType)
    {
      if (!needType && !(o.GetType() == typeof (SerializableQuaternion)))
        throw this.CreateUnknownTypeException((object) o);
      this.WriteStartElement(n, ns, (object) o, false, (XmlSerializerNamespaces) null);
      if (needType)
        this.WriteXsiType("SerializableQuaternion", "");
      this.WriteAttribute("x", "", XmlConvert.ToString(o.x));
      this.WriteAttribute("y", "", XmlConvert.ToString(o.y));
      this.WriteAttribute("z", "", XmlConvert.ToString(o.z));
      this.WriteAttribute("w", "", XmlConvert.ToString(o.w));
      if (o.ShouldSerializeX())
        this.WriteElementStringRaw("X", "", XmlConvert.ToString(o.X));
      if (o.ShouldSerializeY())
        this.WriteElementStringRaw("Y", "", XmlConvert.ToString(o.Y));
      if (o.ShouldSerializeZ())
        this.WriteElementStringRaw("Z", "", XmlConvert.ToString(o.Z));
      if (o.ShouldSerializeW())
        this.WriteElementStringRaw("W", "", XmlConvert.ToString(o.W));
      this.WriteEndElement((object) o);
    }

    private void Write63_SerializableVector3D(
      string n,
      string ns,
      SerializableVector3D o,
      bool needType)
    {
      if (!needType && !(o.GetType() == typeof (SerializableVector3D)))
        throw this.CreateUnknownTypeException((object) o);
      this.WriteStartElement(n, ns, (object) o, false, (XmlSerializerNamespaces) null);
      if (needType)
        this.WriteXsiType("SerializableVector3D", "");
      this.WriteAttribute("x", "", XmlConvert.ToString(o.x));
      this.WriteAttribute("y", "", XmlConvert.ToString(o.y));
      this.WriteAttribute("z", "", XmlConvert.ToString(o.z));
      if (o.ShouldSerializeX())
        this.WriteElementStringRaw("X", "", XmlConvert.ToString(o.X));
      if (o.ShouldSerializeY())
        this.WriteElementStringRaw("Y", "", XmlConvert.ToString(o.Y));
      if (o.ShouldSerializeZ())
        this.WriteElementStringRaw("Z", "", XmlConvert.ToString(o.Z));
      this.WriteEndElement((object) o);
    }

    private void Write2_SerializableBounds(
      string n,
      string ns,
      SerializableBounds o,
      bool needType)
    {
      if (!needType && !(o.GetType() == typeof (SerializableBounds)))
        throw this.CreateUnknownTypeException((object) o);
      this.WriteStartElement(n, ns, (object) o, false, (XmlSerializerNamespaces) null);
      if (needType)
        this.WriteXsiType("SerializableBounds", "");
      this.WriteAttribute("Min", "", XmlConvert.ToString(o.Min));
      this.WriteAttribute("Max", "", XmlConvert.ToString(o.Max));
      this.WriteAttribute("Default", "", XmlConvert.ToString(o.Default));
      this.WriteEndElement((object) o);
    }

    private void Write48_SerializableBoundingBoxD(
      string n,
      string ns,
      SerializableBoundingBoxD o,
      bool needType)
    {
      if (!needType && !(o.GetType() == typeof (SerializableBoundingBoxD)))
        throw this.CreateUnknownTypeException((object) o);
      this.WriteStartElement(n, ns, (object) o, false, (XmlSerializerNamespaces) null);
      if (needType)
        this.WriteXsiType("SerializableBoundingBoxD", "");
      this.Write47_SerializableVector3D("Min", "", o.Min, false);
      this.Write47_SerializableVector3D("Max", "", o.Max, false);
      this.WriteEndElement((object) o);
    }

    private void Write47_SerializableVector3D(
      string n,
      string ns,
      SerializableVector3D o,
      bool needType)
    {
      if (!needType && !(o.GetType() == typeof (SerializableVector3D)))
        throw this.CreateUnknownTypeException((object) o);
      this.WriteStartElement(n, ns, (object) o, false, (XmlSerializerNamespaces) null);
      if (needType)
        this.WriteXsiType("SerializableVector3D", "");
      this.WriteAttribute("x", "", XmlConvert.ToString(o.x));
      this.WriteAttribute("y", "", XmlConvert.ToString(o.y));
      this.WriteAttribute("z", "", XmlConvert.ToString(o.z));
      if (o.ShouldSerializeX())
        this.WriteElementStringRaw("X", "", XmlConvert.ToString(o.X));
      if (o.ShouldSerializeY())
        this.WriteElementStringRaw("Y", "", XmlConvert.ToString(o.Y));
      if (o.ShouldSerializeZ())
        this.WriteElementStringRaw("Z", "", XmlConvert.ToString(o.Z));
      this.WriteEndElement((object) o);
    }

    private void Write19_MyPositionAndOrientation(
      string n,
      string ns,
      MyPositionAndOrientation o,
      bool needType)
    {
      if (!needType && !(o.GetType() == typeof (MyPositionAndOrientation)))
        throw this.CreateUnknownTypeException((object) o);
      this.WriteStartElement(n, ns, (object) o, false, (XmlSerializerNamespaces) null);
      if (needType)
        this.WriteXsiType("MyPositionAndOrientation", "");
      this.Write16_SerializableVector3D("Position", "", o.Position, false);
      this.Write17_SerializableVector3("Forward", "", o.Forward, false);
      this.Write17_SerializableVector3("Up", "", o.Up, false);
      this.Write18_Quaternion("Orientation", "", o.Orientation, false);
      this.WriteEndElement((object) o);
    }

    private void Write18_Quaternion(string n, string ns, Quaternion o, bool needType)
    {
      if (!needType && !(o.GetType() == typeof (Quaternion)))
        throw this.CreateUnknownTypeException((object) o);
      this.WriteStartElement(n, ns, (object) o, false, (XmlSerializerNamespaces) null);
      if (needType)
        this.WriteXsiType("Quaternion", "");
      this.WriteElementStringRaw("X", "", XmlConvert.ToString(o.X));
      this.WriteElementStringRaw("Y", "", XmlConvert.ToString(o.Y));
      this.WriteElementStringRaw("Z", "", XmlConvert.ToString(o.Z));
      this.WriteElementStringRaw("W", "", XmlConvert.ToString(o.W));
      this.WriteEndElement((object) o);
    }

    private void Write17_SerializableVector3(
      string n,
      string ns,
      SerializableVector3 o,
      bool needType)
    {
      if (!needType && !(o.GetType() == typeof (SerializableVector3)))
        throw this.CreateUnknownTypeException((object) o);
      this.WriteStartElement(n, ns, (object) o, false, (XmlSerializerNamespaces) null);
      if (needType)
        this.WriteXsiType("SerializableVector3", "");
      this.WriteAttribute("x", "", XmlConvert.ToString(o.x));
      this.WriteAttribute("y", "", XmlConvert.ToString(o.y));
      this.WriteAttribute("z", "", XmlConvert.ToString(o.z));
      if (o.ShouldSerializeX())
        this.WriteElementStringRaw("X", "", XmlConvert.ToString(o.X));
      if (o.ShouldSerializeY())
        this.WriteElementStringRaw("Y", "", XmlConvert.ToString(o.Y));
      if (o.ShouldSerializeZ())
        this.WriteElementStringRaw("Z", "", XmlConvert.ToString(o.Z));
      this.WriteEndElement((object) o);
    }

    private void Write16_SerializableVector3D(
      string n,
      string ns,
      SerializableVector3D o,
      bool needType)
    {
      if (!needType && !(o.GetType() == typeof (SerializableVector3D)))
        throw this.CreateUnknownTypeException((object) o);
      this.WriteStartElement(n, ns, (object) o, false, (XmlSerializerNamespaces) null);
      if (needType)
        this.WriteXsiType("SerializableVector3D", "");
      this.WriteAttribute("x", "", XmlConvert.ToString(o.x));
      this.WriteAttribute("y", "", XmlConvert.ToString(o.y));
      this.WriteAttribute("z", "", XmlConvert.ToString(o.z));
      if (o.ShouldSerializeX())
        this.WriteElementStringRaw("X", "", XmlConvert.ToString(o.X));
      if (o.ShouldSerializeY())
        this.WriteElementStringRaw("Y", "", XmlConvert.ToString(o.Y));
      if (o.ShouldSerializeZ())
        this.WriteElementStringRaw("Z", "", XmlConvert.ToString(o.Z));
      this.WriteEndElement((object) o);
    }

    private void Write61_MyOrientation(string n, string ns, MyOrientation o, bool needType)
    {
      if (!needType && !(o.GetType() == typeof (MyOrientation)))
        throw this.CreateUnknownTypeException((object) o);
      this.WriteStartElement(n, ns, (object) o, false, (XmlSerializerNamespaces) null);
      if (needType)
        this.WriteXsiType("MyOrientation", "");
      this.WriteAttribute("Yaw", "", XmlConvert.ToString(o.Yaw));
      this.WriteAttribute("Pitch", "", XmlConvert.ToString(o.Pitch));
      this.WriteAttribute("Roll", "", XmlConvert.ToString(o.Roll));
      this.WriteEndElement((object) o);
    }

    private void Write26_MyDeltaTransform(string n, string ns, MyDeltaTransform o, bool needType)
    {
      if (!needType && !(o.GetType() == typeof (MyDeltaTransform)))
        throw this.CreateUnknownTypeException((object) o);
      this.WriteStartElement(n, ns, (object) o, false, (XmlSerializerNamespaces) null);
      if (needType)
        this.WriteXsiType("MyDeltaTransform", "");
      this.Write23_Quaternion("OrientationOffset", "", o.OrientationOffset, false);
      this.Write24_Vector3("PositionOffset", "", o.PositionOffset, false);
      this.Write25_Vector4("OrientationAsVector", "", o.OrientationAsVector, false);
      this.WriteEndElement((object) o);
    }

    private void Write25_Vector4(string n, string ns, Vector4 o, bool needType)
    {
      if (!needType && !(o.GetType() == typeof (Vector4)))
        throw this.CreateUnknownTypeException((object) o);
      this.WriteStartElement(n, ns, (object) o, false, (XmlSerializerNamespaces) null);
      if (needType)
        this.WriteXsiType("Vector4", "");
      this.WriteElementStringRaw("X", "", XmlConvert.ToString(o.X));
      this.WriteElementStringRaw("Y", "", XmlConvert.ToString(o.Y));
      this.WriteElementStringRaw("Z", "", XmlConvert.ToString(o.Z));
      this.WriteElementStringRaw("W", "", XmlConvert.ToString(o.W));
      this.WriteEndElement((object) o);
    }

    private void Write24_Vector3(string n, string ns, Vector3 o, bool needType)
    {
      if (!needType && !(o.GetType() == typeof (Vector3)))
        throw this.CreateUnknownTypeException((object) o);
      this.WriteStartElement(n, ns, (object) o, false, (XmlSerializerNamespaces) null);
      if (needType)
        this.WriteXsiType("Vector3", "");
      this.WriteElementStringRaw("X", "", XmlConvert.ToString(o.X));
      this.WriteElementStringRaw("Y", "", XmlConvert.ToString(o.Y));
      this.WriteElementStringRaw("Z", "", XmlConvert.ToString(o.Z));
      this.WriteEndElement((object) o);
    }

    private void Write23_Quaternion(string n, string ns, Quaternion o, bool needType)
    {
      if (!needType && !(o.GetType() == typeof (Quaternion)))
        throw this.CreateUnknownTypeException((object) o);
      this.WriteStartElement(n, ns, (object) o, false, (XmlSerializerNamespaces) null);
      if (needType)
        this.WriteXsiType("Quaternion", "");
      this.WriteElementStringRaw("X", "", XmlConvert.ToString(o.X));
      this.WriteElementStringRaw("Y", "", XmlConvert.ToString(o.Y));
      this.WriteElementStringRaw("Z", "", XmlConvert.ToString(o.Z));
      this.WriteElementStringRaw("W", "", XmlConvert.ToString(o.W));
      this.WriteEndElement((object) o);
    }

    private void Write34_MyAudioWave(
      string n,
      string ns,
      MyAudioWave o,
      bool isNullable,
      bool needType)
    {
      if (o == null)
      {
        if (!isNullable)
          return;
        this.WriteNullTagLiteral(n, ns);
      }
      else
      {
        if (!needType && !(o.GetType() == typeof (MyAudioWave)))
          throw this.CreateUnknownTypeException((object) o);
        this.WriteStartElement(n, ns, (object) o, false, (XmlSerializerNamespaces) null);
        if (needType)
          this.WriteXsiType("Wave", "");
        this.WriteAttribute("Type", "", this.Write32_MySoundDimensions(o.Type));
        if (o.Start != null && o.Start.Length != 0)
          this.WriteElementString("Start", "", o.Start);
        if (o.Loop != null && o.Loop.Length != 0)
          this.WriteElementString("Loop", "", o.Loop);
        if (o.End != null && o.End.Length != 0)
          this.WriteElementString("End", "", o.End);
        this.WriteEndElement((object) o);
      }
    }

    private string Write32_MySoundDimensions(MySoundDimensions v)
    {
      string str;
      switch (v)
      {
        case MySoundDimensions.D2:
          str = "D2";
          break;
        case MySoundDimensions.D3:
          str = "D3";
          break;
        default:
          throw this.CreateInvalidEnumValueException((object) ((long) v).ToString((IFormatProvider) CultureInfo.InvariantCulture), "VRage.Data.Audio.MySoundDimensions");
      }
      return str;
    }

    private void Write67_DistantSound(
      string n,
      string ns,
      DistantSound o,
      bool isNullable,
      bool needType)
    {
      if (o == null)
      {
        if (!isNullable)
          return;
        this.WriteNullTagLiteral(n, ns);
      }
      else
      {
        if (!needType && !(o.GetType() == typeof (DistantSound)))
          throw this.CreateUnknownTypeException((object) o);
        this.WriteStartElement(n, ns, (object) o, false, (XmlSerializerNamespaces) null);
        if (needType)
          this.WriteXsiType("DistantSound", "");
        this.WriteAttribute("Distance", "", XmlConvert.ToString(o.Distance));
        this.WriteAttribute("DistanceCrossfade", "", XmlConvert.ToString(o.DistanceCrossfade));
        this.WriteAttribute("Sound", "", o.Sound);
        this.WriteEndElement((object) o);
      }
    }

    protected override void InitCallbacks()
    {
    }
  }
}
