// Decompiled with JetBrains decompiler
// Type: Microsoft.Xml.Serialization.GeneratedAssembly.XmlSerializationReader1
// Assembly: VRage.XmlSerializers, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A6DCFDC0-3000-43E3-988A-2A1D50DBB2EA
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\SpaceEngineers\Tools\VRageEditor\Plugins\ModelBuilder\net48\VRage.XmlSerializers.dll

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using System.Security;
using System.Xml;
using System.Xml.Serialization;
using VRage;
using VRage.Audio;
using VRage.Data.Audio;
using VRage.GameServices;
using VRage.Library.Utils;
using VRage.Network;
using VRage.Serialization;
using VRage.Utils;
using VRage.Voxels;
using VRageMath;

#nullable disable
namespace Microsoft.Xml.Serialization.GeneratedAssembly
{
  public class XmlSerializationReader1 : XmlSerializationReader
  {
    private string id79_IsAdmin;
    private string id58_long;
    private string id73_ForcePlayoutDelayBuffer;
    private string id112_x;
    private string id125_Quaternion;
    private string id20_EndpointId;
    private string id88_CrossChatEnabled;
    private string id98_WorldSize;
    private string id64_Color;
    private string id138_Distance;
    private string id93_GameMode;
    private string id34_ModVersion;
    private string id43_IconTexture;
    private string id51_IsStoreHidden;
    private string id30_ModMetadata;
    private string id109_Admin;
    private string id32_Hash;
    private string id122_Position;
    private string id83_IsProfiling;
    private string id55_ItemDefinition;
    private string id132_Vector4;
    private string id61_AuthorName;
    private string id44_AssetModifierId;
    private string id90_BlockedUsers;
    private string id89_CustomData;
    private string id12_SerializableVector2I;
    private string id15_SerializableVector3I;
    private string id39_Tradable;
    private string id114_z;
    private string id24_ChatMsg;
    private string id128_Roll;
    private string id127_Pitch;
    private string id76_UsePlayoutDelayBufferForGrids;
    private string id124_Up;
    private string id2_Item;
    private string id5_MyOrientation;
    private string id26_ClientReadyDataMsg;
    private string id139_DistanceCrossfade;
    private string id116_W;
    private string id27_ChatMessageCustomData;
    private string id40_Marketable;
    private string id11_SerializableVector2;
    private string id13_SerializableVector3;
    private string id91_unsignedLong;
    private string id137_End;
    private string id18_MyStringHash;
    private string id57_UsingCharacters;
    private string id60_IsNew;
    private string id126_Yaw;
    private string id54_Exchange;
    private string id108_ServerExperimental;
    private string id97_HostName;
    private string id31_MyCueId;
    private string id62_SenderId;
    private string id3_Wave;
    private string id140_Sound;
    private string id102_WelderMultiplier;
    private string id50_Hidden;
    private string id107_JoinResult;
    private string id37_ID;
    private string id78_ServiceName;
    private string id100_MembersLimit;
    private string id33_ModMetadataFile;
    private string id42_DisplayType;
    private string id113_y;
    private string id63_TextColor;
    private string id8_SerializableBounds;
    private string id74_Item;
    private string id129_OrientationOffset;
    private string id82_ExperimentalMode;
    private string id25_ConnectedClientDataMsg;
    private string id95_AssemblerMultiplier;
    private string id35_MinGameVersion;
    private string id36_MaxGameVersion;
    private string id65_PackedValue;
    private string id59_IsStoreFakeItem;
    private string id28_MyGameInventoryItem;
    private string id101_DataHash;
    private string id53_ItemQuality;
    private string id86_Channel;
    private string id85_Author;
    private string id52_CanBePurchased;
    private string id117_HalfExtent;
    private string id23_BlockList;
    private string id80_Join;
    private string id133_Vector3;
    private string id41_Description;
    private string id14_SerializableVector3D;
    private string id16_SerializableVector3UByte;
    private string id47_NameColor;
    private string id19_SerializableBoundingSphereD;
    private string id48_BackgroundColor;
    private string id120_Max;
    private string id135_Start;
    private string id130_PositionOffset;
    private string id134_Type;
    private string id111_Radius;
    private string id123_Forward;
    private string id136_Loop;
    private string id68_Z;
    private string id119_Min;
    private string id66_X;
    private string id67_Y;
    private string id6_MyPositionAndOrientation;
    private string id106_ServerAnalyticsId;
    private string id71_B;
    private string id69_R;
    private string id10_SerializableQuaternion;
    private string id56_Quantity;
    private string id7_SerializableBoundingBoxD;
    private string id49_DefinitionType;
    private string id105_ServerPasswordSalt;
    private string id121_Default;
    private string id94_InventoryMultiplier;
    private string id77_ClientId;
    private string id131_OrientationAsVector;
    private string id17_MyStorageData;
    private string id4_MyDeltaTransform;
    private string id38_Name;
    private string id72_A;
    private string id70_G;
    private string id46_ToolName;
    private string id21_JoinResultMsg;
    private string id9_Item;
    private string id96_RefineryMultiplier;
    private string id92_WorldName;
    private string id1_DistantSound;
    private string id29_MyGameInventoryItemDefinition;
    private string id87_TargetId;
    private string id84_Text;
    private string id81_Token;
    private string id103_GrinderMultiplier;
    private string id115_w;
    private string id118_Orientation;
    private string id99_AppVersion;
    private string id45_ItemSlot;
    private string id22_ServerDataMsg;
    private string id110_Center;
    private string id75_Item;
    private string id104_BlocksInventoryMultiplier;

    public object Read88_DistantSound()
    {
      object obj = (object) null;
      int content = (int) this.Reader.MoveToContent();
      if (this.Reader.NodeType == XmlNodeType.Element)
      {
        if ((object) this.Reader.LocalName != (object) this.id1_DistantSound || (object) this.Reader.NamespaceURI != (object) this.id2_Item)
          throw this.CreateUnknownNodeException();
        obj = (object) this.Read72_DistantSound(true, true);
      }
      else
        this.UnknownNode((object) null, ":DistantSound");
      return obj;
    }

    public object Read89_Wave()
    {
      object obj = (object) null;
      int content = (int) this.Reader.MoveToContent();
      if (this.Reader.NodeType == XmlNodeType.Element)
      {
        if ((object) this.Reader.LocalName != (object) this.id3_Wave || (object) this.Reader.NamespaceURI != (object) this.id2_Item)
          throw this.CreateUnknownNodeException();
        obj = (object) this.Read39_MyAudioWave(true, true);
      }
      else
        this.UnknownNode((object) null, ":Wave");
      return obj;
    }

    public object Read90_MyDeltaTransform()
    {
      object obj = (object) null;
      int content = (int) this.Reader.MoveToContent();
      if (this.Reader.NodeType == XmlNodeType.Element)
      {
        if ((object) this.Reader.LocalName != (object) this.id4_MyDeltaTransform || (object) this.Reader.NamespaceURI != (object) this.id2_Item)
          throw this.CreateUnknownNodeException();
        obj = (object) this.Read31_MyDeltaTransform(true);
      }
      else
        this.UnknownNode((object) null, ":MyDeltaTransform");
      return obj;
    }

    public object Read91_MyOrientation()
    {
      object obj = (object) null;
      int content = (int) this.Reader.MoveToContent();
      if (this.Reader.NodeType == XmlNodeType.Element)
      {
        if ((object) this.Reader.LocalName != (object) this.id5_MyOrientation || (object) this.Reader.NamespaceURI != (object) this.id2_Item)
          throw this.CreateUnknownNodeException();
        obj = (object) this.Read66_MyOrientation(true);
      }
      else
        this.UnknownNode((object) null, ":MyOrientation");
      return obj;
    }

    public object Read92_MyPositionAndOrientation()
    {
      object obj = (object) null;
      int content = (int) this.Reader.MoveToContent();
      if (this.Reader.NodeType == XmlNodeType.Element)
      {
        if ((object) this.Reader.LocalName != (object) this.id6_MyPositionAndOrientation || (object) this.Reader.NamespaceURI != (object) this.id2_Item)
          throw this.CreateUnknownNodeException();
        obj = (object) this.Read24_MyPositionAndOrientation(true);
      }
      else
        this.UnknownNode((object) null, ":MyPositionAndOrientation");
      return obj;
    }

    public object Read93_SerializableBoundingBoxD()
    {
      object obj = (object) null;
      int content = (int) this.Reader.MoveToContent();
      if (this.Reader.NodeType == XmlNodeType.Element)
      {
        if ((object) this.Reader.LocalName != (object) this.id7_SerializableBoundingBoxD || (object) this.Reader.NamespaceURI != (object) this.id2_Item)
          throw this.CreateUnknownNodeException();
        obj = (object) this.Read53_SerializableBoundingBoxD(true);
      }
      else
        this.UnknownNode((object) null, ":SerializableBoundingBoxD");
      return obj;
    }

    public object Read94_SerializableBounds()
    {
      object obj = (object) null;
      int content = (int) this.Reader.MoveToContent();
      if (this.Reader.NodeType == XmlNodeType.Element)
      {
        if ((object) this.Reader.LocalName != (object) this.id8_SerializableBounds || (object) this.Reader.NamespaceURI != (object) this.id2_Item)
          throw this.CreateUnknownNodeException();
        obj = (object) this.Read2_SerializableBounds(true);
      }
      else
        this.UnknownNode((object) null, ":SerializableBounds");
      return obj;
    }

    public object Read95_Item()
    {
      object obj = (object) null;
      int content = (int) this.Reader.MoveToContent();
      if (this.Reader.NodeType == XmlNodeType.Element)
      {
        if ((object) this.Reader.LocalName != (object) this.id9_Item || (object) this.Reader.NamespaceURI != (object) this.id2_Item)
          throw this.CreateUnknownNodeException();
        obj = (object) this.Read70_Item(true);
      }
      else
        this.UnknownNode((object) null, ":SerializableOrientedBoundingBoxD");
      return obj;
    }

    public object Read96_SerializableQuaternion()
    {
      object obj = (object) null;
      int content = (int) this.Reader.MoveToContent();
      if (this.Reader.NodeType == XmlNodeType.Element)
      {
        if ((object) this.Reader.LocalName != (object) this.id10_SerializableQuaternion || (object) this.Reader.NamespaceURI != (object) this.id2_Item)
          throw this.CreateUnknownNodeException();
        obj = (object) this.Read59_SerializableQuaternion(true);
      }
      else
        this.UnknownNode((object) null, ":SerializableQuaternion");
      return obj;
    }

    public object Read97_SerializableVector2()
    {
      object obj = (object) null;
      int content = (int) this.Reader.MoveToContent();
      if (this.Reader.NodeType == XmlNodeType.Element)
      {
        if ((object) this.Reader.LocalName != (object) this.id11_SerializableVector2 || (object) this.Reader.NamespaceURI != (object) this.id2_Item)
          throw this.CreateUnknownNodeException();
        obj = (object) this.Read26_SerializableVector2(true);
      }
      else
        this.UnknownNode((object) null, ":SerializableVector2");
      return obj;
    }

    public object Read98_SerializableVector2I()
    {
      object obj = (object) null;
      int content = (int) this.Reader.MoveToContent();
      if (this.Reader.NodeType == XmlNodeType.Element)
      {
        if ((object) this.Reader.LocalName != (object) this.id12_SerializableVector2I || (object) this.Reader.NamespaceURI != (object) this.id2_Item)
          throw this.CreateUnknownNodeException();
        obj = (object) this.Read55_SerializableVector2I(true);
      }
      else
        this.UnknownNode((object) null, ":SerializableVector2I");
      return obj;
    }

    public object Read99_SerializableVector3()
    {
      object obj = (object) null;
      int content = (int) this.Reader.MoveToContent();
      if (this.Reader.NodeType == XmlNodeType.Element)
      {
        if ((object) this.Reader.LocalName != (object) this.id13_SerializableVector3 || (object) this.Reader.NamespaceURI != (object) this.id2_Item)
          throw this.CreateUnknownNodeException();
        obj = (object) this.Read74_SerializableVector3(true);
      }
      else
        this.UnknownNode((object) null, ":SerializableVector3");
      return obj;
    }

    public object Read100_SerializableVector3D()
    {
      object obj = (object) null;
      int content = (int) this.Reader.MoveToContent();
      if (this.Reader.NodeType == XmlNodeType.Element)
      {
        if ((object) this.Reader.LocalName != (object) this.id14_SerializableVector3D || (object) this.Reader.NamespaceURI != (object) this.id2_Item)
          throw this.CreateUnknownNodeException();
        obj = (object) this.Read85_SerializableVector3D(true);
      }
      else
        this.UnknownNode((object) null, ":SerializableVector3D");
      return obj;
    }

    public object Read101_SerializableVector3I()
    {
      object obj = (object) null;
      int content = (int) this.Reader.MoveToContent();
      if (this.Reader.NodeType == XmlNodeType.Element)
      {
        if ((object) this.Reader.LocalName != (object) this.id15_SerializableVector3I || (object) this.Reader.NamespaceURI != (object) this.id2_Item)
          throw this.CreateUnknownNodeException();
        obj = (object) this.Read44_SerializableVector3I(true);
      }
      else
        this.UnknownNode((object) null, ":SerializableVector3I");
      return obj;
    }

    public object Read102_SerializableVector3UByte()
    {
      object obj = (object) null;
      int content = (int) this.Reader.MoveToContent();
      if (this.Reader.NodeType == XmlNodeType.Element)
      {
        if ((object) this.Reader.LocalName != (object) this.id16_SerializableVector3UByte || (object) this.Reader.NamespaceURI != (object) this.id2_Item)
          throw this.CreateUnknownNodeException();
        obj = (object) this.Read48_SerializableVector3UByte(true);
      }
      else
        this.UnknownNode((object) null, ":SerializableVector3UByte");
      return obj;
    }

    public object Read103_MyStorageData()
    {
      object obj = (object) null;
      int content = (int) this.Reader.MoveToContent();
      if (this.Reader.NodeType == XmlNodeType.Element)
      {
        if ((object) this.Reader.LocalName != (object) this.id17_MyStorageData || (object) this.Reader.NamespaceURI != (object) this.id2_Item)
          throw this.CreateUnknownNodeException();
        obj = (object) this.Read46_MyStorageData(true, true);
      }
      else
        this.UnknownNode((object) null, ":MyStorageData");
      return obj;
    }

    public object Read104_MyStringHash()
    {
      object obj = (object) null;
      int content = (int) this.Reader.MoveToContent();
      if (this.Reader.NodeType == XmlNodeType.Element)
      {
        if ((object) this.Reader.LocalName != (object) this.id18_MyStringHash || (object) this.Reader.NamespaceURI != (object) this.id2_Item)
          throw this.CreateUnknownNodeException();
        obj = (object) (MyStringHash) this.ReadSerializable((IXmlSerializable) Activator.CreateInstance(typeof (MyStringHash), BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.CreateInstance, (Binder) null, new object[0], (CultureInfo) null));
      }
      else
        this.UnknownNode((object) null, ":MyStringHash");
      return obj;
    }

    public object Read105_SerializableBoundingSphereD()
    {
      object obj = (object) null;
      int content = (int) this.Reader.MoveToContent();
      if (this.Reader.NodeType == XmlNodeType.Element)
      {
        if ((object) this.Reader.LocalName != (object) this.id19_SerializableBoundingSphereD || (object) this.Reader.NamespaceURI != (object) this.id2_Item)
          throw this.CreateUnknownNodeException();
        obj = (object) this.Read42_SerializableBoundingSphereD(true);
      }
      else
        this.UnknownNode((object) null, ":SerializableBoundingSphereD");
      return obj;
    }

    public object Read106_EndpointId()
    {
      object obj = (object) null;
      int content = (int) this.Reader.MoveToContent();
      if (this.Reader.NodeType == XmlNodeType.Element)
      {
        if ((object) this.Reader.LocalName != (object) this.id20_EndpointId || (object) this.Reader.NamespaceURI != (object) this.id2_Item)
          throw this.CreateUnknownNodeException();
        obj = (object) this.Read87_EndpointId(true);
      }
      else
        this.UnknownNode((object) null, ":EndpointId");
      return obj;
    }

    public object Read107_JoinResultMsg()
    {
      object obj = (object) null;
      int content = (int) this.Reader.MoveToContent();
      if (this.Reader.NodeType == XmlNodeType.Element)
      {
        if ((object) this.Reader.LocalName != (object) this.id21_JoinResultMsg || (object) this.Reader.NamespaceURI != (object) this.id2_Item)
          throw this.CreateUnknownNodeException();
        obj = (object) this.Read64_JoinResultMsg(true);
      }
      else
        this.UnknownNode((object) null, ":JoinResultMsg");
      return obj;
    }

    public object Read108_ServerDataMsg()
    {
      object obj = (object) null;
      int content = (int) this.Reader.MoveToContent();
      if (this.Reader.NodeType == XmlNodeType.Element)
      {
        if ((object) this.Reader.LocalName != (object) this.id22_ServerDataMsg || (object) this.Reader.NamespaceURI != (object) this.id2_Item)
          throw this.CreateUnknownNodeException();
        obj = (object) this.Read34_ServerDataMsg(true);
      }
      else
        this.UnknownNode((object) null, ":ServerDataMsg");
      return obj;
    }

    public object Read109_BlockList()
    {
      object obj = (object) null;
      int content = (int) this.Reader.MoveToContent();
      if (this.Reader.NodeType == XmlNodeType.Element)
      {
        if ((object) this.Reader.LocalName != (object) this.id23_BlockList || (object) this.Reader.NamespaceURI != (object) this.id2_Item)
          throw this.CreateUnknownNodeException();
        obj = (object) this.Read50_BlockList(true);
      }
      else
        this.UnknownNode((object) null, ":BlockList");
      return obj;
    }

    public object Read110_ChatMsg()
    {
      object obj = (object) null;
      int content = (int) this.Reader.MoveToContent();
      if (this.Reader.NodeType == XmlNodeType.Element)
      {
        if ((object) this.Reader.LocalName != (object) this.id24_ChatMsg || (object) this.Reader.NamespaceURI != (object) this.id2_Item)
          throw this.CreateUnknownNodeException();
        obj = (object) this.Read19_ChatMsg(true);
      }
      else
        this.UnknownNode((object) null, ":ChatMsg");
      return obj;
    }

    public object Read111_ConnectedClientDataMsg()
    {
      object obj = (object) null;
      int content = (int) this.Reader.MoveToContent();
      if (this.Reader.NodeType == XmlNodeType.Element)
      {
        if ((object) this.Reader.LocalName != (object) this.id25_ConnectedClientDataMsg || (object) this.Reader.NamespaceURI != (object) this.id2_Item)
          throw this.CreateUnknownNodeException();
        obj = (object) this.Read83_ConnectedClientDataMsg(true);
      }
      else
        this.UnknownNode((object) null, ":ConnectedClientDataMsg");
      return obj;
    }

    public object Read112_ClientReadyDataMsg()
    {
      object obj = (object) null;
      int content = (int) this.Reader.MoveToContent();
      if (this.Reader.NodeType == XmlNodeType.Element)
      {
        if ((object) this.Reader.LocalName != (object) this.id26_ClientReadyDataMsg || (object) this.Reader.NamespaceURI != (object) this.id2_Item)
          throw this.CreateUnknownNodeException();
        obj = (object) this.Read57_ClientReadyDataMsg(true);
      }
      else
        this.UnknownNode((object) null, ":ClientReadyDataMsg");
      return obj;
    }

    public object Read113_ChatMessageCustomData()
    {
      object obj = (object) null;
      int content = (int) this.Reader.MoveToContent();
      if (this.Reader.NodeType == XmlNodeType.Element)
      {
        if ((object) this.Reader.LocalName != (object) this.id27_ChatMessageCustomData || (object) this.Reader.NamespaceURI != (object) this.id2_Item)
          throw this.CreateUnknownNodeException();
        obj = (object) this.Read12_ChatMessageCustomData(true);
      }
      else
        this.UnknownNode((object) null, ":ChatMessageCustomData");
      return obj;
    }

    public object Read114_MyGameInventoryItem()
    {
      object obj = (object) null;
      int content = (int) this.Reader.MoveToContent();
      if (this.Reader.NodeType == XmlNodeType.Element)
      {
        if ((object) this.Reader.LocalName != (object) this.id28_MyGameInventoryItem || (object) this.Reader.NamespaceURI != (object) this.id2_Item)
          throw this.CreateUnknownNodeException();
        obj = (object) this.Read80_MyGameInventoryItem(true, true);
      }
      else
        this.UnknownNode((object) null, ":MyGameInventoryItem");
      return obj;
    }

    public object Read115_MyGameInventoryItemDefinition()
    {
      object obj = (object) null;
      int content = (int) this.Reader.MoveToContent();
      if (this.Reader.NodeType == XmlNodeType.Element)
      {
        if ((object) this.Reader.LocalName != (object) this.id29_MyGameInventoryItemDefinition || (object) this.Reader.NamespaceURI != (object) this.id2_Item)
          throw this.CreateUnknownNodeException();
        obj = (object) this.Read7_MyGameInventoryItemDefinition(true, true);
      }
      else
        this.UnknownNode((object) null, ":MyGameInventoryItemDefinition");
      return obj;
    }

    public object Read116_ModMetadata()
    {
      object obj = (object) null;
      int content = (int) this.Reader.MoveToContent();
      if (this.Reader.NodeType == XmlNodeType.Element)
      {
        if ((object) this.Reader.LocalName != (object) this.id30_ModMetadata || (object) this.Reader.NamespaceURI != (object) this.id2_Item)
          throw this.CreateUnknownNodeException();
        obj = (object) this.Read61_ModMetadataFile(true, true);
      }
      else
        this.UnknownNode((object) null, ":ModMetadata");
      return obj;
    }

    public object Read117_MyCueId()
    {
      object obj = (object) null;
      int content = (int) this.Reader.MoveToContent();
      if (this.Reader.NodeType == XmlNodeType.Element)
      {
        if ((object) this.Reader.LocalName != (object) this.id31_MyCueId || (object) this.Reader.NamespaceURI != (object) this.id2_Item)
          throw this.CreateUnknownNodeException();
        obj = (object) this.Read36_MyCueId(true);
      }
      else
        this.UnknownNode((object) null, ":MyCueId");
      return obj;
    }

    private MyCueId Read36_MyCueId(bool checkType)
    {
      XmlQualifiedName xsiType = checkType ? this.GetXsiType() : (XmlQualifiedName) null;
      if (checkType)
      {
        if (!(xsiType == (XmlQualifiedName) null) && ((object) xsiType.Name != (object) this.id31_MyCueId || (object) xsiType.Namespace != (object) this.id2_Item))
          throw this.CreateUnknownTypeException(xsiType);
      }
      MyCueId instance;
      try
      {
        instance = (MyCueId) Activator.CreateInstance(typeof (MyCueId), BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.CreateInstance, (Binder) null, new object[0], (CultureInfo) null);
      }
      catch (MissingMethodException ex)
      {
        throw this.CreateInaccessibleConstructorException("global::VRage.Audio.MyCueId");
      }
      catch (SecurityException ex)
      {
        throw this.CreateCtorHasSecurityException("global::VRage.Audio.MyCueId");
      }
      bool[] flagArray = new bool[1];
      while (this.Reader.MoveToNextAttribute())
      {
        if (!this.IsXmlnsAttribute(this.Reader.Name))
          this.UnknownNode((object) instance);
      }
      this.Reader.MoveToElement();
      if (this.Reader.IsEmptyElement)
      {
        this.Reader.Skip();
        return instance;
      }
      this.Reader.ReadStartElement();
      int content1 = (int) this.Reader.MoveToContent();
      int whileIterations = 0;
      int readerCount = this.ReaderCount;
      while (this.Reader.NodeType != XmlNodeType.EndElement && this.Reader.NodeType != XmlNodeType.None)
      {
        if (this.Reader.NodeType == XmlNodeType.Element)
        {
          if (!flagArray[0] && (object) this.Reader.LocalName == (object) this.id32_Hash && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
          {
            instance.Hash = (MyStringHash) this.ReadSerializable((IXmlSerializable) Activator.CreateInstance(typeof (MyStringHash), BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.CreateInstance, (Binder) null, new object[0], (CultureInfo) null));
            flagArray[0] = true;
          }
          else
            this.UnknownNode((object) instance, ":Hash");
        }
        else
          this.UnknownNode((object) instance, ":Hash");
        int content2 = (int) this.Reader.MoveToContent();
        this.CheckReaderCount(ref whileIterations, ref readerCount);
      }
      this.ReadEndElement();
      return instance;
    }

    private ModMetadataFile Read61_ModMetadataFile(bool isNullable, bool checkType)
    {
      XmlQualifiedName xsiType = checkType ? this.GetXsiType() : (XmlQualifiedName) null;
      bool flag = false;
      if (isNullable)
        flag = this.ReadNull();
      if (checkType && !(xsiType == (XmlQualifiedName) null) && ((object) xsiType.Name != (object) this.id33_ModMetadataFile || (object) xsiType.Namespace != (object) this.id2_Item))
        throw this.CreateUnknownTypeException(xsiType);
      if (flag)
        return (ModMetadataFile) null;
      ModMetadataFile o = new ModMetadataFile();
      bool[] flagArray = new bool[3];
      while (this.Reader.MoveToNextAttribute())
      {
        if (!this.IsXmlnsAttribute(this.Reader.Name))
          this.UnknownNode((object) o);
      }
      this.Reader.MoveToElement();
      if (this.Reader.IsEmptyElement)
      {
        this.Reader.Skip();
        return o;
      }
      this.Reader.ReadStartElement();
      int content1 = (int) this.Reader.MoveToContent();
      int whileIterations = 0;
      int readerCount = this.ReaderCount;
      while (this.Reader.NodeType != XmlNodeType.EndElement && this.Reader.NodeType != XmlNodeType.None)
      {
        if (this.Reader.NodeType == XmlNodeType.Element)
        {
          if (!flagArray[0] && (object) this.Reader.LocalName == (object) this.id34_ModVersion && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
          {
            o.ModVersion = this.Reader.ReadElementString();
            flagArray[0] = true;
          }
          else if (!flagArray[1] && (object) this.Reader.LocalName == (object) this.id35_MinGameVersion && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
          {
            o.MinGameVersion = this.Reader.ReadElementString();
            flagArray[1] = true;
          }
          else if (!flagArray[2] && (object) this.Reader.LocalName == (object) this.id36_MaxGameVersion && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
          {
            o.MaxGameVersion = this.Reader.ReadElementString();
            flagArray[2] = true;
          }
          else
            this.UnknownNode((object) o, ":ModVersion, :MinGameVersion, :MaxGameVersion");
        }
        else
          this.UnknownNode((object) o, ":ModVersion, :MinGameVersion, :MaxGameVersion");
        int content2 = (int) this.Reader.MoveToContent();
        this.CheckReaderCount(ref whileIterations, ref readerCount);
      }
      this.ReadEndElement();
      return o;
    }

    private MyGameInventoryItemDefinition Read7_MyGameInventoryItemDefinition(
      bool isNullable,
      bool checkType)
    {
      XmlQualifiedName xsiType = checkType ? this.GetXsiType() : (XmlQualifiedName) null;
      bool flag = false;
      if (isNullable)
        flag = this.ReadNull();
      if (checkType && !(xsiType == (XmlQualifiedName) null) && ((object) xsiType.Name != (object) this.id29_MyGameInventoryItemDefinition || (object) xsiType.Namespace != (object) this.id2_Item))
        throw this.CreateUnknownTypeException(xsiType);
      if (flag)
        return (MyGameInventoryItemDefinition) null;
      MyGameInventoryItemDefinition o = new MyGameInventoryItemDefinition();
      bool[] flagArray = new bool[18];
      while (this.Reader.MoveToNextAttribute())
      {
        if (!this.IsXmlnsAttribute(this.Reader.Name))
          this.UnknownNode((object) o);
      }
      this.Reader.MoveToElement();
      if (this.Reader.IsEmptyElement)
      {
        this.Reader.Skip();
        return o;
      }
      this.Reader.ReadStartElement();
      int content1 = (int) this.Reader.MoveToContent();
      int whileIterations = 0;
      int readerCount = this.ReaderCount;
      while (this.Reader.NodeType != XmlNodeType.EndElement && this.Reader.NodeType != XmlNodeType.None)
      {
        if (this.Reader.NodeType == XmlNodeType.Element)
        {
          if (!flagArray[0] && (object) this.Reader.LocalName == (object) this.id37_ID && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
          {
            o.ID = XmlConvert.ToInt32(this.Reader.ReadElementString());
            flagArray[0] = true;
          }
          else if (!flagArray[1] && (object) this.Reader.LocalName == (object) this.id38_Name && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
          {
            o.Name = this.Reader.ReadElementString();
            flagArray[1] = true;
          }
          else if (!flagArray[2] && (object) this.Reader.LocalName == (object) this.id39_Tradable && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
          {
            o.Tradable = this.Reader.ReadElementString();
            flagArray[2] = true;
          }
          else if (!flagArray[3] && (object) this.Reader.LocalName == (object) this.id40_Marketable && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
          {
            o.Marketable = this.Reader.ReadElementString();
            flagArray[3] = true;
          }
          else if (!flagArray[4] && (object) this.Reader.LocalName == (object) this.id41_Description && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
          {
            o.Description = this.Reader.ReadElementString();
            flagArray[4] = true;
          }
          else if (!flagArray[5] && (object) this.Reader.LocalName == (object) this.id42_DisplayType && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
          {
            o.DisplayType = this.Reader.ReadElementString();
            flagArray[5] = true;
          }
          else if (!flagArray[6] && (object) this.Reader.LocalName == (object) this.id43_IconTexture && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
          {
            o.IconTexture = this.Reader.ReadElementString();
            flagArray[6] = true;
          }
          else if (!flagArray[7] && (object) this.Reader.LocalName == (object) this.id44_AssetModifierId && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
          {
            o.AssetModifierId = this.Reader.ReadElementString();
            flagArray[7] = true;
          }
          else if (!flagArray[8] && (object) this.Reader.LocalName == (object) this.id45_ItemSlot && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
          {
            o.ItemSlot = this.Read3_MyGameInventoryItemSlot(this.Reader.ReadElementString());
            flagArray[8] = true;
          }
          else if (!flagArray[9] && (object) this.Reader.LocalName == (object) this.id46_ToolName && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
          {
            o.ToolName = this.Reader.ReadElementString();
            flagArray[9] = true;
          }
          else if (!flagArray[10] && (object) this.Reader.LocalName == (object) this.id47_NameColor && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
          {
            o.NameColor = this.Reader.ReadElementString();
            flagArray[10] = true;
          }
          else if (!flagArray[11] && (object) this.Reader.LocalName == (object) this.id48_BackgroundColor && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
          {
            o.BackgroundColor = this.Reader.ReadElementString();
            flagArray[11] = true;
          }
          else if (!flagArray[12] && (object) this.Reader.LocalName == (object) this.id49_DefinitionType && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
          {
            o.DefinitionType = this.Read4_Item(this.Reader.ReadElementString());
            flagArray[12] = true;
          }
          else if (!flagArray[13] && (object) this.Reader.LocalName == (object) this.id50_Hidden && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
          {
            o.Hidden = XmlConvert.ToBoolean(this.Reader.ReadElementString());
            flagArray[13] = true;
          }
          else if (!flagArray[14] && (object) this.Reader.LocalName == (object) this.id51_IsStoreHidden && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
          {
            o.IsStoreHidden = XmlConvert.ToBoolean(this.Reader.ReadElementString());
            flagArray[14] = true;
          }
          else if (!flagArray[15] && (object) this.Reader.LocalName == (object) this.id52_CanBePurchased && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
          {
            o.CanBePurchased = XmlConvert.ToBoolean(this.Reader.ReadElementString());
            flagArray[15] = true;
          }
          else if (!flagArray[16] && (object) this.Reader.LocalName == (object) this.id53_ItemQuality && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
          {
            o.ItemQuality = this.Read5_MyGameInventoryItemQuality(this.Reader.ReadElementString());
            flagArray[16] = true;
          }
          else if (!flagArray[17] && (object) this.Reader.LocalName == (object) this.id54_Exchange && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
          {
            o.Exchange = this.Reader.ReadElementString();
            flagArray[17] = true;
          }
          else
            this.UnknownNode((object) o, ":ID, :Name, :Tradable, :Marketable, :Description, :DisplayType, :IconTexture, :AssetModifierId, :ItemSlot, :ToolName, :NameColor, :BackgroundColor, :DefinitionType, :Hidden, :IsStoreHidden, :CanBePurchased, :ItemQuality, :Exchange");
        }
        else
          this.UnknownNode((object) o, ":ID, :Name, :Tradable, :Marketable, :Description, :DisplayType, :IconTexture, :AssetModifierId, :ItemSlot, :ToolName, :NameColor, :BackgroundColor, :DefinitionType, :Hidden, :IsStoreHidden, :CanBePurchased, :ItemQuality, :Exchange");
        int content2 = (int) this.Reader.MoveToContent();
        this.CheckReaderCount(ref whileIterations, ref readerCount);
      }
      this.ReadEndElement();
      return o;
    }

    private MyGameInventoryItemQuality Read5_MyGameInventoryItemQuality(string s)
    {
      switch (s)
      {
        case "Common":
          return MyGameInventoryItemQuality.Common;
        case "Uncommon":
          return MyGameInventoryItemQuality.Uncommon;
        case "Unusual":
          return MyGameInventoryItemQuality.Unusual;
        case "Rare":
          return MyGameInventoryItemQuality.Rare;
        case "Exceptional":
          return MyGameInventoryItemQuality.Exceptional;
        default:
          throw this.CreateUnknownConstantException(s, typeof (MyGameInventoryItemQuality));
      }
    }

    private MyGameInventoryItemDefinitionType Read4_Item(string s)
    {
      switch (s)
      {
        case "none":
          return MyGameInventoryItemDefinitionType.none;
        case "item":
          return MyGameInventoryItemDefinitionType.item;
        case "bundle":
          return MyGameInventoryItemDefinitionType.bundle;
        case "generator":
          return MyGameInventoryItemDefinitionType.generator;
        case "playtimegenerator":
          return MyGameInventoryItemDefinitionType.playtimegenerator;
        default:
          throw this.CreateUnknownConstantException(s, typeof (MyGameInventoryItemDefinitionType));
      }
    }

    private MyGameInventoryItemSlot Read3_MyGameInventoryItemSlot(string s)
    {
      switch (s)
      {
        case "None":
          return MyGameInventoryItemSlot.None;
        case "Face":
          return MyGameInventoryItemSlot.Face;
        case "Helmet":
          return MyGameInventoryItemSlot.Helmet;
        case "Gloves":
          return MyGameInventoryItemSlot.Gloves;
        case "Boots":
          return MyGameInventoryItemSlot.Boots;
        case "Suit":
          return MyGameInventoryItemSlot.Suit;
        case "Rifle":
          return MyGameInventoryItemSlot.Rifle;
        case "Welder":
          return MyGameInventoryItemSlot.Welder;
        case "Grinder":
          return MyGameInventoryItemSlot.Grinder;
        case "Drill":
          return MyGameInventoryItemSlot.Drill;
        case "Emote":
          return MyGameInventoryItemSlot.Emote;
        case "Armor":
          return MyGameInventoryItemSlot.Armor;
        default:
          throw this.CreateUnknownConstantException(s, typeof (MyGameInventoryItemSlot));
      }
    }

    private MyGameInventoryItem Read80_MyGameInventoryItem(bool isNullable, bool checkType)
    {
      XmlQualifiedName xsiType = checkType ? this.GetXsiType() : (XmlQualifiedName) null;
      bool flag = false;
      if (isNullable)
        flag = this.ReadNull();
      if (checkType && !(xsiType == (XmlQualifiedName) null) && ((object) xsiType.Name != (object) this.id28_MyGameInventoryItem || (object) xsiType.Namespace != (object) this.id2_Item))
        throw this.CreateUnknownTypeException(xsiType);
      if (flag)
        return (MyGameInventoryItem) null;
      MyGameInventoryItem o = new MyGameInventoryItem();
      if (o.UsingCharacters == null)
        o.UsingCharacters = new HashSet<long>();
      HashSet<long> usingCharacters1 = o.UsingCharacters;
      bool[] flagArray = new bool[6];
      while (this.Reader.MoveToNextAttribute())
      {
        if (!this.IsXmlnsAttribute(this.Reader.Name))
          this.UnknownNode((object) o);
      }
      this.Reader.MoveToElement();
      if (this.Reader.IsEmptyElement)
      {
        this.Reader.Skip();
        return o;
      }
      this.Reader.ReadStartElement();
      int content1 = (int) this.Reader.MoveToContent();
      int whileIterations1 = 0;
      int readerCount1 = this.ReaderCount;
      while (this.Reader.NodeType != XmlNodeType.EndElement && this.Reader.NodeType != XmlNodeType.None)
      {
        if (this.Reader.NodeType == XmlNodeType.Element)
        {
          if (!flagArray[0] && (object) this.Reader.LocalName == (object) this.id37_ID && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
          {
            o.ID = XmlConvert.ToUInt64(this.Reader.ReadElementString());
            flagArray[0] = true;
          }
          else if (!flagArray[1] && (object) this.Reader.LocalName == (object) this.id55_ItemDefinition && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
          {
            o.ItemDefinition = this.Read79_MyGameInventoryItemDefinition(false, true);
            flagArray[1] = true;
          }
          else if (!flagArray[2] && (object) this.Reader.LocalName == (object) this.id56_Quantity && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
          {
            o.Quantity = XmlConvert.ToUInt16(this.Reader.ReadElementString());
            flagArray[2] = true;
          }
          else if ((object) this.Reader.LocalName == (object) this.id57_UsingCharacters && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
          {
            if (!this.ReadNull())
            {
              if (o.UsingCharacters == null)
                o.UsingCharacters = new HashSet<long>();
              HashSet<long> usingCharacters2 = o.UsingCharacters;
              if (this.Reader.IsEmptyElement)
              {
                this.Reader.Skip();
              }
              else
              {
                this.Reader.ReadStartElement();
                int content2 = (int) this.Reader.MoveToContent();
                int whileIterations2 = 0;
                int readerCount2 = this.ReaderCount;
                while (this.Reader.NodeType != XmlNodeType.EndElement && this.Reader.NodeType != XmlNodeType.None)
                {
                  if (this.Reader.NodeType == XmlNodeType.Element)
                  {
                    if ((object) this.Reader.LocalName == (object) this.id58_long && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
                      usingCharacters2.Add(XmlConvert.ToInt64(this.Reader.ReadElementString()));
                    else
                      this.UnknownNode((object) null, ":long");
                  }
                  else
                    this.UnknownNode((object) null, ":long");
                  int content3 = (int) this.Reader.MoveToContent();
                  this.CheckReaderCount(ref whileIterations2, ref readerCount2);
                }
                this.ReadEndElement();
              }
            }
          }
          else if (!flagArray[4] && (object) this.Reader.LocalName == (object) this.id59_IsStoreFakeItem && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
          {
            o.IsStoreFakeItem = XmlConvert.ToBoolean(this.Reader.ReadElementString());
            flagArray[4] = true;
          }
          else if (!flagArray[5] && (object) this.Reader.LocalName == (object) this.id60_IsNew && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
          {
            o.IsNew = XmlConvert.ToBoolean(this.Reader.ReadElementString());
            flagArray[5] = true;
          }
          else
            this.UnknownNode((object) o, ":ID, :ItemDefinition, :Quantity, :UsingCharacters, :IsStoreFakeItem, :IsNew");
        }
        else
          this.UnknownNode((object) o, ":ID, :ItemDefinition, :Quantity, :UsingCharacters, :IsStoreFakeItem, :IsNew");
        int content4 = (int) this.Reader.MoveToContent();
        this.CheckReaderCount(ref whileIterations1, ref readerCount1);
      }
      this.ReadEndElement();
      return o;
    }

    private MyGameInventoryItemDefinition Read79_MyGameInventoryItemDefinition(
      bool isNullable,
      bool checkType)
    {
      XmlQualifiedName xsiType = checkType ? this.GetXsiType() : (XmlQualifiedName) null;
      bool flag = false;
      if (isNullable)
        flag = this.ReadNull();
      if (checkType && !(xsiType == (XmlQualifiedName) null) && ((object) xsiType.Name != (object) this.id29_MyGameInventoryItemDefinition || (object) xsiType.Namespace != (object) this.id2_Item))
        throw this.CreateUnknownTypeException(xsiType);
      if (flag)
        return (MyGameInventoryItemDefinition) null;
      MyGameInventoryItemDefinition o = new MyGameInventoryItemDefinition();
      bool[] flagArray = new bool[18];
      while (this.Reader.MoveToNextAttribute())
      {
        if (!this.IsXmlnsAttribute(this.Reader.Name))
          this.UnknownNode((object) o);
      }
      this.Reader.MoveToElement();
      if (this.Reader.IsEmptyElement)
      {
        this.Reader.Skip();
        return o;
      }
      this.Reader.ReadStartElement();
      int content1 = (int) this.Reader.MoveToContent();
      int whileIterations = 0;
      int readerCount = this.ReaderCount;
      while (this.Reader.NodeType != XmlNodeType.EndElement && this.Reader.NodeType != XmlNodeType.None)
      {
        if (this.Reader.NodeType == XmlNodeType.Element)
        {
          if (!flagArray[0] && (object) this.Reader.LocalName == (object) this.id37_ID && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
          {
            o.ID = XmlConvert.ToInt32(this.Reader.ReadElementString());
            flagArray[0] = true;
          }
          else if (!flagArray[1] && (object) this.Reader.LocalName == (object) this.id38_Name && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
          {
            o.Name = this.Reader.ReadElementString();
            flagArray[1] = true;
          }
          else if (!flagArray[2] && (object) this.Reader.LocalName == (object) this.id39_Tradable && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
          {
            o.Tradable = this.Reader.ReadElementString();
            flagArray[2] = true;
          }
          else if (!flagArray[3] && (object) this.Reader.LocalName == (object) this.id40_Marketable && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
          {
            o.Marketable = this.Reader.ReadElementString();
            flagArray[3] = true;
          }
          else if (!flagArray[4] && (object) this.Reader.LocalName == (object) this.id41_Description && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
          {
            o.Description = this.Reader.ReadElementString();
            flagArray[4] = true;
          }
          else if (!flagArray[5] && (object) this.Reader.LocalName == (object) this.id42_DisplayType && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
          {
            o.DisplayType = this.Reader.ReadElementString();
            flagArray[5] = true;
          }
          else if (!flagArray[6] && (object) this.Reader.LocalName == (object) this.id43_IconTexture && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
          {
            o.IconTexture = this.Reader.ReadElementString();
            flagArray[6] = true;
          }
          else if (!flagArray[7] && (object) this.Reader.LocalName == (object) this.id44_AssetModifierId && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
          {
            o.AssetModifierId = this.Reader.ReadElementString();
            flagArray[7] = true;
          }
          else if (!flagArray[8] && (object) this.Reader.LocalName == (object) this.id45_ItemSlot && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
          {
            o.ItemSlot = this.Read75_MyGameInventoryItemSlot(this.Reader.ReadElementString());
            flagArray[8] = true;
          }
          else if (!flagArray[9] && (object) this.Reader.LocalName == (object) this.id46_ToolName && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
          {
            o.ToolName = this.Reader.ReadElementString();
            flagArray[9] = true;
          }
          else if (!flagArray[10] && (object) this.Reader.LocalName == (object) this.id47_NameColor && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
          {
            o.NameColor = this.Reader.ReadElementString();
            flagArray[10] = true;
          }
          else if (!flagArray[11] && (object) this.Reader.LocalName == (object) this.id48_BackgroundColor && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
          {
            o.BackgroundColor = this.Reader.ReadElementString();
            flagArray[11] = true;
          }
          else if (!flagArray[12] && (object) this.Reader.LocalName == (object) this.id49_DefinitionType && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
          {
            o.DefinitionType = this.Read76_Item(this.Reader.ReadElementString());
            flagArray[12] = true;
          }
          else if (!flagArray[13] && (object) this.Reader.LocalName == (object) this.id50_Hidden && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
          {
            o.Hidden = XmlConvert.ToBoolean(this.Reader.ReadElementString());
            flagArray[13] = true;
          }
          else if (!flagArray[14] && (object) this.Reader.LocalName == (object) this.id51_IsStoreHidden && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
          {
            o.IsStoreHidden = XmlConvert.ToBoolean(this.Reader.ReadElementString());
            flagArray[14] = true;
          }
          else if (!flagArray[15] && (object) this.Reader.LocalName == (object) this.id52_CanBePurchased && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
          {
            o.CanBePurchased = XmlConvert.ToBoolean(this.Reader.ReadElementString());
            flagArray[15] = true;
          }
          else if (!flagArray[16] && (object) this.Reader.LocalName == (object) this.id53_ItemQuality && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
          {
            o.ItemQuality = this.Read77_MyGameInventoryItemQuality(this.Reader.ReadElementString());
            flagArray[16] = true;
          }
          else if (!flagArray[17] && (object) this.Reader.LocalName == (object) this.id54_Exchange && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
          {
            o.Exchange = this.Reader.ReadElementString();
            flagArray[17] = true;
          }
          else
            this.UnknownNode((object) o, ":ID, :Name, :Tradable, :Marketable, :Description, :DisplayType, :IconTexture, :AssetModifierId, :ItemSlot, :ToolName, :NameColor, :BackgroundColor, :DefinitionType, :Hidden, :IsStoreHidden, :CanBePurchased, :ItemQuality, :Exchange");
        }
        else
          this.UnknownNode((object) o, ":ID, :Name, :Tradable, :Marketable, :Description, :DisplayType, :IconTexture, :AssetModifierId, :ItemSlot, :ToolName, :NameColor, :BackgroundColor, :DefinitionType, :Hidden, :IsStoreHidden, :CanBePurchased, :ItemQuality, :Exchange");
        int content2 = (int) this.Reader.MoveToContent();
        this.CheckReaderCount(ref whileIterations, ref readerCount);
      }
      this.ReadEndElement();
      return o;
    }

    private MyGameInventoryItemQuality Read77_MyGameInventoryItemQuality(string s)
    {
      switch (s)
      {
        case "Common":
          return MyGameInventoryItemQuality.Common;
        case "Uncommon":
          return MyGameInventoryItemQuality.Uncommon;
        case "Unusual":
          return MyGameInventoryItemQuality.Unusual;
        case "Rare":
          return MyGameInventoryItemQuality.Rare;
        case "Exceptional":
          return MyGameInventoryItemQuality.Exceptional;
        default:
          throw this.CreateUnknownConstantException(s, typeof (MyGameInventoryItemQuality));
      }
    }

    private MyGameInventoryItemDefinitionType Read76_Item(string s)
    {
      switch (s)
      {
        case "none":
          return MyGameInventoryItemDefinitionType.none;
        case "item":
          return MyGameInventoryItemDefinitionType.item;
        case "bundle":
          return MyGameInventoryItemDefinitionType.bundle;
        case "generator":
          return MyGameInventoryItemDefinitionType.generator;
        case "playtimegenerator":
          return MyGameInventoryItemDefinitionType.playtimegenerator;
        default:
          throw this.CreateUnknownConstantException(s, typeof (MyGameInventoryItemDefinitionType));
      }
    }

    private MyGameInventoryItemSlot Read75_MyGameInventoryItemSlot(string s)
    {
      switch (s)
      {
        case "None":
          return MyGameInventoryItemSlot.None;
        case "Face":
          return MyGameInventoryItemSlot.Face;
        case "Helmet":
          return MyGameInventoryItemSlot.Helmet;
        case "Gloves":
          return MyGameInventoryItemSlot.Gloves;
        case "Boots":
          return MyGameInventoryItemSlot.Boots;
        case "Suit":
          return MyGameInventoryItemSlot.Suit;
        case "Rifle":
          return MyGameInventoryItemSlot.Rifle;
        case "Welder":
          return MyGameInventoryItemSlot.Welder;
        case "Grinder":
          return MyGameInventoryItemSlot.Grinder;
        case "Drill":
          return MyGameInventoryItemSlot.Drill;
        case "Emote":
          return MyGameInventoryItemSlot.Emote;
        case "Armor":
          return MyGameInventoryItemSlot.Armor;
        default:
          throw this.CreateUnknownConstantException(s, typeof (MyGameInventoryItemSlot));
      }
    }

    private ChatMessageCustomData Read12_ChatMessageCustomData(bool checkType)
    {
      XmlQualifiedName xsiType = checkType ? this.GetXsiType() : (XmlQualifiedName) null;
      if (checkType)
      {
        if (!(xsiType == (XmlQualifiedName) null) && ((object) xsiType.Name != (object) this.id27_ChatMessageCustomData || (object) xsiType.Namespace != (object) this.id2_Item))
          throw this.CreateUnknownTypeException(xsiType);
      }
      ChatMessageCustomData instance;
      try
      {
        instance = (ChatMessageCustomData) Activator.CreateInstance(typeof (ChatMessageCustomData), BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.CreateInstance, (Binder) null, new object[0], (CultureInfo) null);
      }
      catch (MissingMethodException ex)
      {
        throw this.CreateInaccessibleConstructorException("global::VRage.GameServices.ChatMessageCustomData");
      }
      catch (SecurityException ex)
      {
        throw this.CreateCtorHasSecurityException("global::VRage.GameServices.ChatMessageCustomData");
      }
      bool[] flagArray = new bool[3];
      while (this.Reader.MoveToNextAttribute())
      {
        if (!this.IsXmlnsAttribute(this.Reader.Name))
          this.UnknownNode((object) instance);
      }
      this.Reader.MoveToElement();
      if (this.Reader.IsEmptyElement)
      {
        this.Reader.Skip();
        return instance;
      }
      this.Reader.ReadStartElement();
      int content1 = (int) this.Reader.MoveToContent();
      int whileIterations = 0;
      int readerCount = this.ReaderCount;
      while (this.Reader.NodeType != XmlNodeType.EndElement && this.Reader.NodeType != XmlNodeType.None)
      {
        if (this.Reader.NodeType == XmlNodeType.Element)
        {
          if (!flagArray[0] && (object) this.Reader.LocalName == (object) this.id61_AuthorName && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
          {
            instance.AuthorName = this.Reader.ReadElementString();
            flagArray[0] = true;
          }
          else if (!flagArray[1] && (object) this.Reader.LocalName == (object) this.id62_SenderId && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
          {
            instance.SenderId = this.Read8_NullableOfUInt64(true);
            flagArray[1] = true;
          }
          else if (!flagArray[2] && (object) this.Reader.LocalName == (object) this.id63_TextColor && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
          {
            instance.TextColor = this.Read11_NullableOfColor(true);
            flagArray[2] = true;
          }
          else
            this.UnknownNode((object) instance, ":AuthorName, :SenderId, :TextColor");
        }
        else
          this.UnknownNode((object) instance, ":AuthorName, :SenderId, :TextColor");
        int content2 = (int) this.Reader.MoveToContent();
        this.CheckReaderCount(ref whileIterations, ref readerCount);
      }
      this.ReadEndElement();
      return instance;
    }

    private Color? Read11_NullableOfColor(bool checkType)
    {
      Color? nullable = new Color?();
      if (this.ReadNull())
        return nullable;
      nullable = new Color?(this.Read10_Color(true));
      return nullable;
    }

    private Color Read10_Color(bool checkType)
    {
      XmlQualifiedName xsiType = checkType ? this.GetXsiType() : (XmlQualifiedName) null;
      if (checkType)
      {
        if (!(xsiType == (XmlQualifiedName) null) && ((object) xsiType.Name != (object) this.id64_Color || (object) xsiType.Namespace != (object) this.id2_Item))
          throw this.CreateUnknownTypeException(xsiType);
      }
      Color instance;
      try
      {
        instance = (Color) Activator.CreateInstance(typeof (Color), BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.CreateInstance, (Binder) null, new object[0], (CultureInfo) null);
      }
      catch (MissingMethodException ex)
      {
        throw this.CreateInaccessibleConstructorException("global::VRageMath.Color");
      }
      catch (SecurityException ex)
      {
        throw this.CreateCtorHasSecurityException("global::VRageMath.Color");
      }
      bool[] flagArray = new bool[8];
      while (this.Reader.MoveToNextAttribute())
      {
        if (!this.IsXmlnsAttribute(this.Reader.Name))
          this.UnknownNode((object) instance);
      }
      this.Reader.MoveToElement();
      if (this.Reader.IsEmptyElement)
      {
        this.Reader.Skip();
        return instance;
      }
      this.Reader.ReadStartElement();
      int content1 = (int) this.Reader.MoveToContent();
      int whileIterations = 0;
      int readerCount = this.ReaderCount;
      while (this.Reader.NodeType != XmlNodeType.EndElement && this.Reader.NodeType != XmlNodeType.None)
      {
        if (this.Reader.NodeType == XmlNodeType.Element)
        {
          if (!flagArray[0] && (object) this.Reader.LocalName == (object) this.id65_PackedValue && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
          {
            instance.PackedValue = XmlConvert.ToUInt32(this.Reader.ReadElementString());
            flagArray[0] = true;
          }
          else if (!flagArray[1] && (object) this.Reader.LocalName == (object) this.id66_X && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
          {
            instance.X = XmlConvert.ToByte(this.Reader.ReadElementString());
            flagArray[1] = true;
          }
          else if (!flagArray[2] && (object) this.Reader.LocalName == (object) this.id67_Y && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
          {
            instance.Y = XmlConvert.ToByte(this.Reader.ReadElementString());
            flagArray[2] = true;
          }
          else if (!flagArray[3] && (object) this.Reader.LocalName == (object) this.id68_Z && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
          {
            instance.Z = XmlConvert.ToByte(this.Reader.ReadElementString());
            flagArray[3] = true;
          }
          else if (!flagArray[4] && (object) this.Reader.LocalName == (object) this.id69_R && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
          {
            instance.R = XmlConvert.ToByte(this.Reader.ReadElementString());
            flagArray[4] = true;
          }
          else if (!flagArray[5] && (object) this.Reader.LocalName == (object) this.id70_G && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
          {
            instance.G = XmlConvert.ToByte(this.Reader.ReadElementString());
            flagArray[5] = true;
          }
          else if (!flagArray[6] && (object) this.Reader.LocalName == (object) this.id71_B && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
          {
            instance.B = XmlConvert.ToByte(this.Reader.ReadElementString());
            flagArray[6] = true;
          }
          else if (!flagArray[7] && (object) this.Reader.LocalName == (object) this.id72_A && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
          {
            instance.A = XmlConvert.ToByte(this.Reader.ReadElementString());
            flagArray[7] = true;
          }
          else
            this.UnknownNode((object) instance, ":PackedValue, :X, :Y, :Z, :R, :G, :B, :A");
        }
        else
          this.UnknownNode((object) instance, ":PackedValue, :X, :Y, :Z, :R, :G, :B, :A");
        int content2 = (int) this.Reader.MoveToContent();
        this.CheckReaderCount(ref whileIterations, ref readerCount);
      }
      this.ReadEndElement();
      return instance;
    }

    private ulong? Read8_NullableOfUInt64(bool checkType)
    {
      ulong? nullable = new ulong?();
      if (this.ReadNull())
        return nullable;
      nullable = new ulong?(XmlConvert.ToUInt64(this.Reader.ReadElementString()));
      return nullable;
    }

    private ClientReadyDataMsg Read57_ClientReadyDataMsg(bool checkType)
    {
      XmlQualifiedName xsiType = checkType ? this.GetXsiType() : (XmlQualifiedName) null;
      if (checkType)
      {
        if (!(xsiType == (XmlQualifiedName) null) && ((object) xsiType.Name != (object) this.id26_ClientReadyDataMsg || (object) xsiType.Namespace != (object) this.id2_Item))
          throw this.CreateUnknownTypeException(xsiType);
      }
      ClientReadyDataMsg instance;
      try
      {
        instance = (ClientReadyDataMsg) Activator.CreateInstance(typeof (ClientReadyDataMsg), BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.CreateInstance, (Binder) null, new object[0], (CultureInfo) null);
      }
      catch (MissingMethodException ex)
      {
        throw this.CreateInaccessibleConstructorException("global::VRage.Network.ClientReadyDataMsg");
      }
      catch (SecurityException ex)
      {
        throw this.CreateCtorHasSecurityException("global::VRage.Network.ClientReadyDataMsg");
      }
      bool[] flagArray = new bool[4];
      while (this.Reader.MoveToNextAttribute())
      {
        if (!this.IsXmlnsAttribute(this.Reader.Name))
          this.UnknownNode((object) instance);
      }
      this.Reader.MoveToElement();
      if (this.Reader.IsEmptyElement)
      {
        this.Reader.Skip();
        return instance;
      }
      this.Reader.ReadStartElement();
      int content1 = (int) this.Reader.MoveToContent();
      int whileIterations = 0;
      int readerCount = this.ReaderCount;
      while (this.Reader.NodeType != XmlNodeType.EndElement && this.Reader.NodeType != XmlNodeType.None)
      {
        if (this.Reader.NodeType == XmlNodeType.Element)
        {
          if (!flagArray[0] && (object) this.Reader.LocalName == (object) this.id73_ForcePlayoutDelayBuffer && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
          {
            instance.ForcePlayoutDelayBuffer = XmlConvert.ToBoolean(this.Reader.ReadElementString());
            flagArray[0] = true;
          }
          else if (!flagArray[1] && (object) this.Reader.LocalName == (object) this.id74_Item && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
          {
            instance.UsePlayoutDelayBufferForCharacter = XmlConvert.ToBoolean(this.Reader.ReadElementString());
            flagArray[1] = true;
          }
          else if (!flagArray[2] && (object) this.Reader.LocalName == (object) this.id75_Item && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
          {
            instance.UsePlayoutDelayBufferForJetpack = XmlConvert.ToBoolean(this.Reader.ReadElementString());
            flagArray[2] = true;
          }
          else if (!flagArray[3] && (object) this.Reader.LocalName == (object) this.id76_UsePlayoutDelayBufferForGrids && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
          {
            instance.UsePlayoutDelayBufferForGrids = XmlConvert.ToBoolean(this.Reader.ReadElementString());
            flagArray[3] = true;
          }
          else
            this.UnknownNode((object) instance, ":ForcePlayoutDelayBuffer, :UsePlayoutDelayBufferForCharacter, :UsePlayoutDelayBufferForJetpack, :UsePlayoutDelayBufferForGrids");
        }
        else
          this.UnknownNode((object) instance, ":ForcePlayoutDelayBuffer, :UsePlayoutDelayBufferForCharacter, :UsePlayoutDelayBufferForJetpack, :UsePlayoutDelayBufferForGrids");
        int content2 = (int) this.Reader.MoveToContent();
        this.CheckReaderCount(ref whileIterations, ref readerCount);
      }
      this.ReadEndElement();
      return instance;
    }

    private ConnectedClientDataMsg Read83_ConnectedClientDataMsg(bool checkType)
    {
      XmlQualifiedName xsiType = checkType ? this.GetXsiType() : (XmlQualifiedName) null;
      if (checkType)
      {
        if (!(xsiType == (XmlQualifiedName) null) && ((object) xsiType.Name != (object) this.id25_ConnectedClientDataMsg || (object) xsiType.Namespace != (object) this.id2_Item))
          throw this.CreateUnknownTypeException(xsiType);
      }
      ConnectedClientDataMsg instance;
      try
      {
        instance = (ConnectedClientDataMsg) Activator.CreateInstance(typeof (ConnectedClientDataMsg), BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.CreateInstance, (Binder) null, new object[0], (CultureInfo) null);
      }
      catch (MissingMethodException ex)
      {
        throw this.CreateInaccessibleConstructorException("global::VRage.Network.ConnectedClientDataMsg");
      }
      catch (SecurityException ex)
      {
        throw this.CreateCtorHasSecurityException("global::VRage.Network.ConnectedClientDataMsg");
      }
      bool[] flagArray = new bool[8];
      while (this.Reader.MoveToNextAttribute())
      {
        if (!this.IsXmlnsAttribute(this.Reader.Name))
          this.UnknownNode((object) instance);
      }
      this.Reader.MoveToElement();
      if (this.Reader.IsEmptyElement)
      {
        this.Reader.Skip();
        return instance;
      }
      this.Reader.ReadStartElement();
      int content1 = (int) this.Reader.MoveToContent();
      int whileIterations = 0;
      int readerCount = this.ReaderCount;
      while (this.Reader.NodeType != XmlNodeType.EndElement && this.Reader.NodeType != XmlNodeType.None)
      {
        if (this.Reader.NodeType == XmlNodeType.Element)
        {
          if (!flagArray[0] && (object) this.Reader.LocalName == (object) this.id77_ClientId && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
          {
            instance.ClientId = this.Read82_EndpointId(true);
            flagArray[0] = true;
          }
          else if (!flagArray[1] && (object) this.Reader.LocalName == (object) this.id78_ServiceName && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
          {
            instance.ServiceName = this.Reader.ReadElementString();
            flagArray[1] = true;
          }
          else if (!flagArray[2] && (object) this.Reader.LocalName == (object) this.id38_Name && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
          {
            instance.Name = this.Reader.ReadElementString();
            flagArray[2] = true;
          }
          else if (!flagArray[3] && (object) this.Reader.LocalName == (object) this.id79_IsAdmin && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
          {
            instance.IsAdmin = XmlConvert.ToBoolean(this.Reader.ReadElementString());
            flagArray[3] = true;
          }
          else if (!flagArray[4] && (object) this.Reader.LocalName == (object) this.id80_Join && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
          {
            instance.Join = XmlConvert.ToBoolean(this.Reader.ReadElementString());
            flagArray[4] = true;
          }
          else if (!flagArray[5] && (object) this.Reader.LocalName == (object) this.id81_Token && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
          {
            instance.Token = this.ToByteArrayBase64(false);
            flagArray[5] = true;
          }
          else if (!flagArray[6] && (object) this.Reader.LocalName == (object) this.id82_ExperimentalMode && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
          {
            instance.ExperimentalMode = XmlConvert.ToBoolean(this.Reader.ReadElementString());
            flagArray[6] = true;
          }
          else if (!flagArray[7] && (object) this.Reader.LocalName == (object) this.id83_IsProfiling && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
          {
            instance.IsProfiling = XmlConvert.ToBoolean(this.Reader.ReadElementString());
            flagArray[7] = true;
          }
          else
            this.UnknownNode((object) instance, ":ClientId, :ServiceName, :Name, :IsAdmin, :Join, :Token, :ExperimentalMode, :IsProfiling");
        }
        else
          this.UnknownNode((object) instance, ":ClientId, :ServiceName, :Name, :IsAdmin, :Join, :Token, :ExperimentalMode, :IsProfiling");
        int content2 = (int) this.Reader.MoveToContent();
        this.CheckReaderCount(ref whileIterations, ref readerCount);
      }
      this.ReadEndElement();
      return instance;
    }

    private EndpointId Read82_EndpointId(bool checkType)
    {
      XmlQualifiedName xsiType = checkType ? this.GetXsiType() : (XmlQualifiedName) null;
      if (checkType)
      {
        if (!(xsiType == (XmlQualifiedName) null) && ((object) xsiType.Name != (object) this.id20_EndpointId || (object) xsiType.Namespace != (object) this.id2_Item))
          throw this.CreateUnknownTypeException(xsiType);
      }
      EndpointId instance;
      try
      {
        instance = (EndpointId) Activator.CreateInstance(typeof (EndpointId), BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.CreateInstance, (Binder) null, new object[0], (CultureInfo) null);
      }
      catch (MissingMethodException ex)
      {
        throw this.CreateInaccessibleConstructorException("global::VRage.Network.EndpointId");
      }
      catch (SecurityException ex)
      {
        throw this.CreateCtorHasSecurityException("global::VRage.Network.EndpointId");
      }
      bool[] flagArray = new bool[0];
      while (this.Reader.MoveToNextAttribute())
      {
        if (!this.IsXmlnsAttribute(this.Reader.Name))
          this.UnknownNode((object) instance);
      }
      this.Reader.MoveToElement();
      if (this.Reader.IsEmptyElement)
      {
        this.Reader.Skip();
        return instance;
      }
      this.Reader.ReadStartElement();
      int content1 = (int) this.Reader.MoveToContent();
      int whileIterations = 0;
      int readerCount = this.ReaderCount;
      while (this.Reader.NodeType != XmlNodeType.EndElement && this.Reader.NodeType != XmlNodeType.None)
      {
        if (this.Reader.NodeType == XmlNodeType.Element)
          this.UnknownNode((object) instance, "");
        else
          this.UnknownNode((object) instance, "");
        int content2 = (int) this.Reader.MoveToContent();
        this.CheckReaderCount(ref whileIterations, ref readerCount);
      }
      this.ReadEndElement();
      return instance;
    }

    private ChatMsg Read19_ChatMsg(bool checkType)
    {
      XmlQualifiedName xsiType = checkType ? this.GetXsiType() : (XmlQualifiedName) null;
      if (checkType)
      {
        if (!(xsiType == (XmlQualifiedName) null) && ((object) xsiType.Name != (object) this.id24_ChatMsg || (object) xsiType.Namespace != (object) this.id2_Item))
          throw this.CreateUnknownTypeException(xsiType);
      }
      ChatMsg instance;
      try
      {
        instance = (ChatMsg) Activator.CreateInstance(typeof (ChatMsg), BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.CreateInstance, (Binder) null, new object[0], (CultureInfo) null);
      }
      catch (MissingMethodException ex)
      {
        throw this.CreateInaccessibleConstructorException("global::VRage.Network.ChatMsg");
      }
      catch (SecurityException ex)
      {
        throw this.CreateCtorHasSecurityException("global::VRage.Network.ChatMsg");
      }
      bool[] flagArray = new bool[6];
      while (this.Reader.MoveToNextAttribute())
      {
        if (!this.IsXmlnsAttribute(this.Reader.Name))
          this.UnknownNode((object) instance);
      }
      this.Reader.MoveToElement();
      if (this.Reader.IsEmptyElement)
      {
        this.Reader.Skip();
        return instance;
      }
      this.Reader.ReadStartElement();
      int content1 = (int) this.Reader.MoveToContent();
      int whileIterations = 0;
      int readerCount = this.ReaderCount;
      while (this.Reader.NodeType != XmlNodeType.EndElement && this.Reader.NodeType != XmlNodeType.None)
      {
        if (this.Reader.NodeType == XmlNodeType.Element)
        {
          if (!flagArray[0] && (object) this.Reader.LocalName == (object) this.id84_Text && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
          {
            instance.Text = this.Reader.ReadElementString();
            flagArray[0] = true;
          }
          else if (!flagArray[1] && (object) this.Reader.LocalName == (object) this.id85_Author && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
          {
            instance.Author = XmlConvert.ToUInt64(this.Reader.ReadElementString());
            flagArray[1] = true;
          }
          else if (!flagArray[2] && (object) this.Reader.LocalName == (object) this.id86_Channel && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
          {
            instance.Channel = XmlConvert.ToByte(this.Reader.ReadElementString());
            flagArray[2] = true;
          }
          else if (!flagArray[3] && (object) this.Reader.LocalName == (object) this.id87_TargetId && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
          {
            instance.TargetId = XmlConvert.ToInt64(this.Reader.ReadElementString());
            flagArray[3] = true;
          }
          else if (!flagArray[4] && (object) this.Reader.LocalName == (object) this.id88_CrossChatEnabled && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
          {
            instance.CrossChatEnabled = XmlConvert.ToBoolean(this.Reader.ReadElementString());
            flagArray[4] = true;
          }
          else if (!flagArray[5] && (object) this.Reader.LocalName == (object) this.id89_CustomData && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
          {
            instance.CustomData = this.Read18_Item(true);
            flagArray[5] = true;
          }
          else
            this.UnknownNode((object) instance, ":Text, :Author, :Channel, :TargetId, :CrossChatEnabled, :CustomData");
        }
        else
          this.UnknownNode((object) instance, ":Text, :Author, :Channel, :TargetId, :CrossChatEnabled, :CustomData");
        int content2 = (int) this.Reader.MoveToContent();
        this.CheckReaderCount(ref whileIterations, ref readerCount);
      }
      this.ReadEndElement();
      return instance;
    }

    private ChatMessageCustomData? Read18_Item(bool checkType)
    {
      ChatMessageCustomData? nullable = new ChatMessageCustomData?();
      if (this.ReadNull())
        return nullable;
      nullable = new ChatMessageCustomData?(this.Read17_ChatMessageCustomData(true));
      return nullable;
    }

    private ChatMessageCustomData Read17_ChatMessageCustomData(bool checkType)
    {
      XmlQualifiedName xsiType = checkType ? this.GetXsiType() : (XmlQualifiedName) null;
      if (checkType)
      {
        if (!(xsiType == (XmlQualifiedName) null) && ((object) xsiType.Name != (object) this.id27_ChatMessageCustomData || (object) xsiType.Namespace != (object) this.id2_Item))
          throw this.CreateUnknownTypeException(xsiType);
      }
      ChatMessageCustomData instance;
      try
      {
        instance = (ChatMessageCustomData) Activator.CreateInstance(typeof (ChatMessageCustomData), BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.CreateInstance, (Binder) null, new object[0], (CultureInfo) null);
      }
      catch (MissingMethodException ex)
      {
        throw this.CreateInaccessibleConstructorException("global::VRage.GameServices.ChatMessageCustomData");
      }
      catch (SecurityException ex)
      {
        throw this.CreateCtorHasSecurityException("global::VRage.GameServices.ChatMessageCustomData");
      }
      bool[] flagArray = new bool[3];
      while (this.Reader.MoveToNextAttribute())
      {
        if (!this.IsXmlnsAttribute(this.Reader.Name))
          this.UnknownNode((object) instance);
      }
      this.Reader.MoveToElement();
      if (this.Reader.IsEmptyElement)
      {
        this.Reader.Skip();
        return instance;
      }
      this.Reader.ReadStartElement();
      int content1 = (int) this.Reader.MoveToContent();
      int whileIterations = 0;
      int readerCount = this.ReaderCount;
      while (this.Reader.NodeType != XmlNodeType.EndElement && this.Reader.NodeType != XmlNodeType.None)
      {
        if (this.Reader.NodeType == XmlNodeType.Element)
        {
          if (!flagArray[0] && (object) this.Reader.LocalName == (object) this.id61_AuthorName && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
          {
            instance.AuthorName = this.Reader.ReadElementString();
            flagArray[0] = true;
          }
          else if (!flagArray[1] && (object) this.Reader.LocalName == (object) this.id62_SenderId && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
          {
            instance.SenderId = this.Read13_NullableOfUInt64(true);
            flagArray[1] = true;
          }
          else if (!flagArray[2] && (object) this.Reader.LocalName == (object) this.id63_TextColor && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
          {
            instance.TextColor = this.Read16_NullableOfColor(true);
            flagArray[2] = true;
          }
          else
            this.UnknownNode((object) instance, ":AuthorName, :SenderId, :TextColor");
        }
        else
          this.UnknownNode((object) instance, ":AuthorName, :SenderId, :TextColor");
        int content2 = (int) this.Reader.MoveToContent();
        this.CheckReaderCount(ref whileIterations, ref readerCount);
      }
      this.ReadEndElement();
      return instance;
    }

    private Color? Read16_NullableOfColor(bool checkType)
    {
      Color? nullable = new Color?();
      if (this.ReadNull())
        return nullable;
      nullable = new Color?(this.Read15_Color(true));
      return nullable;
    }

    private Color Read15_Color(bool checkType)
    {
      XmlQualifiedName xsiType = checkType ? this.GetXsiType() : (XmlQualifiedName) null;
      if (checkType)
      {
        if (!(xsiType == (XmlQualifiedName) null) && ((object) xsiType.Name != (object) this.id64_Color || (object) xsiType.Namespace != (object) this.id2_Item))
          throw this.CreateUnknownTypeException(xsiType);
      }
      Color instance;
      try
      {
        instance = (Color) Activator.CreateInstance(typeof (Color), BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.CreateInstance, (Binder) null, new object[0], (CultureInfo) null);
      }
      catch (MissingMethodException ex)
      {
        throw this.CreateInaccessibleConstructorException("global::VRageMath.Color");
      }
      catch (SecurityException ex)
      {
        throw this.CreateCtorHasSecurityException("global::VRageMath.Color");
      }
      bool[] flagArray = new bool[8];
      while (this.Reader.MoveToNextAttribute())
      {
        if (!this.IsXmlnsAttribute(this.Reader.Name))
          this.UnknownNode((object) instance);
      }
      this.Reader.MoveToElement();
      if (this.Reader.IsEmptyElement)
      {
        this.Reader.Skip();
        return instance;
      }
      this.Reader.ReadStartElement();
      int content1 = (int) this.Reader.MoveToContent();
      int whileIterations = 0;
      int readerCount = this.ReaderCount;
      while (this.Reader.NodeType != XmlNodeType.EndElement && this.Reader.NodeType != XmlNodeType.None)
      {
        if (this.Reader.NodeType == XmlNodeType.Element)
        {
          if (!flagArray[0] && (object) this.Reader.LocalName == (object) this.id65_PackedValue && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
          {
            instance.PackedValue = XmlConvert.ToUInt32(this.Reader.ReadElementString());
            flagArray[0] = true;
          }
          else if (!flagArray[1] && (object) this.Reader.LocalName == (object) this.id66_X && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
          {
            instance.X = XmlConvert.ToByte(this.Reader.ReadElementString());
            flagArray[1] = true;
          }
          else if (!flagArray[2] && (object) this.Reader.LocalName == (object) this.id67_Y && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
          {
            instance.Y = XmlConvert.ToByte(this.Reader.ReadElementString());
            flagArray[2] = true;
          }
          else if (!flagArray[3] && (object) this.Reader.LocalName == (object) this.id68_Z && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
          {
            instance.Z = XmlConvert.ToByte(this.Reader.ReadElementString());
            flagArray[3] = true;
          }
          else if (!flagArray[4] && (object) this.Reader.LocalName == (object) this.id69_R && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
          {
            instance.R = XmlConvert.ToByte(this.Reader.ReadElementString());
            flagArray[4] = true;
          }
          else if (!flagArray[5] && (object) this.Reader.LocalName == (object) this.id70_G && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
          {
            instance.G = XmlConvert.ToByte(this.Reader.ReadElementString());
            flagArray[5] = true;
          }
          else if (!flagArray[6] && (object) this.Reader.LocalName == (object) this.id71_B && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
          {
            instance.B = XmlConvert.ToByte(this.Reader.ReadElementString());
            flagArray[6] = true;
          }
          else if (!flagArray[7] && (object) this.Reader.LocalName == (object) this.id72_A && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
          {
            instance.A = XmlConvert.ToByte(this.Reader.ReadElementString());
            flagArray[7] = true;
          }
          else
            this.UnknownNode((object) instance, ":PackedValue, :X, :Y, :Z, :R, :G, :B, :A");
        }
        else
          this.UnknownNode((object) instance, ":PackedValue, :X, :Y, :Z, :R, :G, :B, :A");
        int content2 = (int) this.Reader.MoveToContent();
        this.CheckReaderCount(ref whileIterations, ref readerCount);
      }
      this.ReadEndElement();
      return instance;
    }

    private ulong? Read13_NullableOfUInt64(bool checkType)
    {
      ulong? nullable = new ulong?();
      if (this.ReadNull())
        return nullable;
      nullable = new ulong?(XmlConvert.ToUInt64(this.Reader.ReadElementString()));
      return nullable;
    }

    private BlockList Read50_BlockList(bool checkType)
    {
      XmlQualifiedName xsiType = checkType ? this.GetXsiType() : (XmlQualifiedName) null;
      if (checkType)
      {
        if (!(xsiType == (XmlQualifiedName) null) && ((object) xsiType.Name != (object) this.id23_BlockList || (object) xsiType.Namespace != (object) this.id2_Item))
          throw this.CreateUnknownTypeException(xsiType);
      }
      BlockList instance;
      try
      {
        instance = (BlockList) Activator.CreateInstance(typeof (BlockList), BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.CreateInstance, (Binder) null, new object[0], (CultureInfo) null);
      }
      catch (MissingMethodException ex)
      {
        throw this.CreateInaccessibleConstructorException("global::VRage.Network.BlockList");
      }
      catch (SecurityException ex)
      {
        throw this.CreateCtorHasSecurityException("global::VRage.Network.BlockList");
      }
      bool[] flagArray = new bool[1];
      while (this.Reader.MoveToNextAttribute())
      {
        if (!this.IsXmlnsAttribute(this.Reader.Name))
          this.UnknownNode((object) instance);
      }
      this.Reader.MoveToElement();
      if (this.Reader.IsEmptyElement)
      {
        this.Reader.Skip();
        return instance;
      }
      this.Reader.ReadStartElement();
      int content1 = (int) this.Reader.MoveToContent();
      int whileIterations1 = 0;
      int readerCount1 = this.ReaderCount;
      while (this.Reader.NodeType != XmlNodeType.EndElement && this.Reader.NodeType != XmlNodeType.None)
      {
        if (this.Reader.NodeType == XmlNodeType.Element)
        {
          if ((object) this.Reader.LocalName == (object) this.id90_BlockedUsers && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
          {
            if (!this.ReadNull())
            {
              ulong[] a = (ulong[]) null;
              int num = 0;
              if (this.Reader.IsEmptyElement)
              {
                this.Reader.Skip();
              }
              else
              {
                this.Reader.ReadStartElement();
                int content2 = (int) this.Reader.MoveToContent();
                int whileIterations2 = 0;
                int readerCount2 = this.ReaderCount;
                while (this.Reader.NodeType != XmlNodeType.EndElement && this.Reader.NodeType != XmlNodeType.None)
                {
                  if (this.Reader.NodeType == XmlNodeType.Element)
                  {
                    if ((object) this.Reader.LocalName == (object) this.id91_unsignedLong && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
                    {
                      a = (ulong[]) this.EnsureArrayIndex((Array) a, num, typeof (ulong));
                      a[num++] = XmlConvert.ToUInt64(this.Reader.ReadElementString());
                    }
                    else
                      this.UnknownNode((object) null, ":unsignedLong");
                  }
                  else
                    this.UnknownNode((object) null, ":unsignedLong");
                  int content3 = (int) this.Reader.MoveToContent();
                  this.CheckReaderCount(ref whileIterations2, ref readerCount2);
                }
                this.ReadEndElement();
              }
              instance.BlockedUsers = (ulong[]) this.ShrinkArray((Array) a, num, typeof (ulong), false);
            }
          }
          else
            this.UnknownNode((object) instance, ":BlockedUsers");
        }
        else
          this.UnknownNode((object) instance, ":BlockedUsers");
        int content4 = (int) this.Reader.MoveToContent();
        this.CheckReaderCount(ref whileIterations1, ref readerCount1);
      }
      this.ReadEndElement();
      return instance;
    }

    private ServerDataMsg Read34_ServerDataMsg(bool checkType)
    {
      XmlQualifiedName xsiType = checkType ? this.GetXsiType() : (XmlQualifiedName) null;
      if (checkType)
      {
        if (!(xsiType == (XmlQualifiedName) null) && ((object) xsiType.Name != (object) this.id22_ServerDataMsg || (object) xsiType.Namespace != (object) this.id2_Item))
          throw this.CreateUnknownTypeException(xsiType);
      }
      ServerDataMsg instance;
      try
      {
        instance = (ServerDataMsg) Activator.CreateInstance(typeof (ServerDataMsg), BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.CreateInstance, (Binder) null, new object[0], (CultureInfo) null);
      }
      catch (MissingMethodException ex)
      {
        throw this.CreateInaccessibleConstructorException("global::VRage.Network.ServerDataMsg");
      }
      catch (SecurityException ex)
      {
        throw this.CreateCtorHasSecurityException("global::VRage.Network.ServerDataMsg");
      }
      bool[] flagArray = new bool[15];
      while (this.Reader.MoveToNextAttribute())
      {
        if (!this.IsXmlnsAttribute(this.Reader.Name))
          this.UnknownNode((object) instance);
      }
      this.Reader.MoveToElement();
      if (this.Reader.IsEmptyElement)
      {
        this.Reader.Skip();
        return instance;
      }
      this.Reader.ReadStartElement();
      int content1 = (int) this.Reader.MoveToContent();
      int whileIterations = 0;
      int readerCount = this.ReaderCount;
      while (this.Reader.NodeType != XmlNodeType.EndElement && this.Reader.NodeType != XmlNodeType.None)
      {
        if (this.Reader.NodeType == XmlNodeType.Element)
        {
          if (!flagArray[0] && (object) this.Reader.LocalName == (object) this.id92_WorldName && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
          {
            instance.WorldName = this.Reader.ReadElementString();
            flagArray[0] = true;
          }
          else if (!flagArray[1] && (object) this.Reader.LocalName == (object) this.id93_GameMode && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
          {
            instance.GameMode = this.Read32_MyGameModeEnum(this.Reader.ReadElementString());
            flagArray[1] = true;
          }
          else if (!flagArray[2] && (object) this.Reader.LocalName == (object) this.id94_InventoryMultiplier && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
          {
            instance.InventoryMultiplier = XmlConvert.ToSingle(this.Reader.ReadElementString());
            flagArray[2] = true;
          }
          else if (!flagArray[3] && (object) this.Reader.LocalName == (object) this.id95_AssemblerMultiplier && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
          {
            instance.AssemblerMultiplier = XmlConvert.ToSingle(this.Reader.ReadElementString());
            flagArray[3] = true;
          }
          else if (!flagArray[4] && (object) this.Reader.LocalName == (object) this.id96_RefineryMultiplier && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
          {
            instance.RefineryMultiplier = XmlConvert.ToSingle(this.Reader.ReadElementString());
            flagArray[4] = true;
          }
          else if (!flagArray[5] && (object) this.Reader.LocalName == (object) this.id97_HostName && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
          {
            instance.HostName = this.Reader.ReadElementString();
            flagArray[5] = true;
          }
          else if (!flagArray[6] && (object) this.Reader.LocalName == (object) this.id98_WorldSize && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
          {
            instance.WorldSize = XmlConvert.ToUInt64(this.Reader.ReadElementString());
            flagArray[6] = true;
          }
          else if (!flagArray[7] && (object) this.Reader.LocalName == (object) this.id99_AppVersion && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
          {
            instance.AppVersion = XmlConvert.ToInt32(this.Reader.ReadElementString());
            flagArray[7] = true;
          }
          else if (!flagArray[8] && (object) this.Reader.LocalName == (object) this.id100_MembersLimit && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
          {
            instance.MembersLimit = XmlConvert.ToInt32(this.Reader.ReadElementString());
            flagArray[8] = true;
          }
          else if (!flagArray[9] && (object) this.Reader.LocalName == (object) this.id101_DataHash && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
          {
            instance.DataHash = this.Reader.ReadElementString();
            flagArray[9] = true;
          }
          else if (!flagArray[10] && (object) this.Reader.LocalName == (object) this.id102_WelderMultiplier && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
          {
            instance.WelderMultiplier = XmlConvert.ToSingle(this.Reader.ReadElementString());
            flagArray[10] = true;
          }
          else if (!flagArray[11] && (object) this.Reader.LocalName == (object) this.id103_GrinderMultiplier && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
          {
            instance.GrinderMultiplier = XmlConvert.ToSingle(this.Reader.ReadElementString());
            flagArray[11] = true;
          }
          else if (!flagArray[12] && (object) this.Reader.LocalName == (object) this.id104_BlocksInventoryMultiplier && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
          {
            instance.BlocksInventoryMultiplier = XmlConvert.ToSingle(this.Reader.ReadElementString());
            flagArray[12] = true;
          }
          else if (!flagArray[13] && (object) this.Reader.LocalName == (object) this.id105_ServerPasswordSalt && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
          {
            instance.ServerPasswordSalt = this.Reader.ReadElementString();
            flagArray[13] = true;
          }
          else if (!flagArray[14] && (object) this.Reader.LocalName == (object) this.id106_ServerAnalyticsId && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
          {
            instance.ServerAnalyticsId = this.Reader.ReadElementString();
            flagArray[14] = true;
          }
          else
            this.UnknownNode((object) instance, ":WorldName, :GameMode, :InventoryMultiplier, :AssemblerMultiplier, :RefineryMultiplier, :HostName, :WorldSize, :AppVersion, :MembersLimit, :DataHash, :WelderMultiplier, :GrinderMultiplier, :BlocksInventoryMultiplier, :ServerPasswordSalt, :ServerAnalyticsId");
        }
        else
          this.UnknownNode((object) instance, ":WorldName, :GameMode, :InventoryMultiplier, :AssemblerMultiplier, :RefineryMultiplier, :HostName, :WorldSize, :AppVersion, :MembersLimit, :DataHash, :WelderMultiplier, :GrinderMultiplier, :BlocksInventoryMultiplier, :ServerPasswordSalt, :ServerAnalyticsId");
        int content2 = (int) this.Reader.MoveToContent();
        this.CheckReaderCount(ref whileIterations, ref readerCount);
      }
      this.ReadEndElement();
      return instance;
    }

    private MyGameModeEnum Read32_MyGameModeEnum(string s)
    {
      switch (s)
      {
        case "Creative":
          return MyGameModeEnum.Creative;
        case "Survival":
          return MyGameModeEnum.Survival;
        default:
          throw this.CreateUnknownConstantException(s, typeof (MyGameModeEnum));
      }
    }

    private JoinResultMsg Read64_JoinResultMsg(bool checkType)
    {
      XmlQualifiedName xsiType = checkType ? this.GetXsiType() : (XmlQualifiedName) null;
      if (checkType)
      {
        if (!(xsiType == (XmlQualifiedName) null) && ((object) xsiType.Name != (object) this.id21_JoinResultMsg || (object) xsiType.Namespace != (object) this.id2_Item))
          throw this.CreateUnknownTypeException(xsiType);
      }
      JoinResultMsg instance;
      try
      {
        instance = (JoinResultMsg) Activator.CreateInstance(typeof (JoinResultMsg), BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.CreateInstance, (Binder) null, new object[0], (CultureInfo) null);
      }
      catch (MissingMethodException ex)
      {
        throw this.CreateInaccessibleConstructorException("global::VRage.Network.JoinResultMsg");
      }
      catch (SecurityException ex)
      {
        throw this.CreateCtorHasSecurityException("global::VRage.Network.JoinResultMsg");
      }
      bool[] flagArray = new bool[3];
      while (this.Reader.MoveToNextAttribute())
      {
        if (!this.IsXmlnsAttribute(this.Reader.Name))
          this.UnknownNode((object) instance);
      }
      this.Reader.MoveToElement();
      if (this.Reader.IsEmptyElement)
      {
        this.Reader.Skip();
        return instance;
      }
      this.Reader.ReadStartElement();
      int content1 = (int) this.Reader.MoveToContent();
      int whileIterations = 0;
      int readerCount = this.ReaderCount;
      while (this.Reader.NodeType != XmlNodeType.EndElement && this.Reader.NodeType != XmlNodeType.None)
      {
        if (this.Reader.NodeType == XmlNodeType.Element)
        {
          if (!flagArray[0] && (object) this.Reader.LocalName == (object) this.id107_JoinResult && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
          {
            instance.JoinResult = this.Read62_JoinResult(this.Reader.ReadElementString());
            flagArray[0] = true;
          }
          else if (!flagArray[1] && (object) this.Reader.LocalName == (object) this.id108_ServerExperimental && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
          {
            instance.ServerExperimental = XmlConvert.ToBoolean(this.Reader.ReadElementString());
            flagArray[1] = true;
          }
          else if (!flagArray[2] && (object) this.Reader.LocalName == (object) this.id109_Admin && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
          {
            instance.Admin = XmlConvert.ToUInt64(this.Reader.ReadElementString());
            flagArray[2] = true;
          }
          else
            this.UnknownNode((object) instance, ":JoinResult, :ServerExperimental, :Admin");
        }
        else
          this.UnknownNode((object) instance, ":JoinResult, :ServerExperimental, :Admin");
        int content2 = (int) this.Reader.MoveToContent();
        this.CheckReaderCount(ref whileIterations, ref readerCount);
      }
      this.ReadEndElement();
      return instance;
    }

    private JoinResult Read62_JoinResult(string s)
    {
      switch (s)
      {
        case "OK":
          return JoinResult.OK;
        case "AlreadyJoined":
          return JoinResult.AlreadyJoined;
        case "TicketInvalid":
          return JoinResult.TicketInvalid;
        case "SteamServersOffline":
          return JoinResult.SteamServersOffline;
        case "NotInGroup":
          return JoinResult.NotInGroup;
        case "GroupIdInvalid":
          return JoinResult.GroupIdInvalid;
        case "ServerFull":
          return JoinResult.ServerFull;
        case "BannedByAdmins":
          return JoinResult.BannedByAdmins;
        case "KickedRecently":
          return JoinResult.KickedRecently;
        case "TicketCanceled":
          return JoinResult.TicketCanceled;
        case "TicketAlreadyUsed":
          return JoinResult.TicketAlreadyUsed;
        case "LoggedInElseWhere":
          return JoinResult.LoggedInElseWhere;
        case "NoLicenseOrExpired":
          return JoinResult.NoLicenseOrExpired;
        case "UserNotConnected":
          return JoinResult.UserNotConnected;
        case "VACBanned":
          return JoinResult.VACBanned;
        case "VACCheckTimedOut":
          return JoinResult.VACCheckTimedOut;
        case "PasswordRequired":
          return JoinResult.PasswordRequired;
        case "WrongPassword":
          return JoinResult.WrongPassword;
        case "ExperimentalMode":
          return JoinResult.ExperimentalMode;
        case "ProfilingNotAllowed":
          return JoinResult.ProfilingNotAllowed;
        case "FamilySharing":
          return JoinResult.FamilySharing;
        case "NotFound":
          return JoinResult.NotFound;
        case "IncorrectTime":
          return JoinResult.IncorrectTime;
        default:
          throw this.CreateUnknownConstantException(s, typeof (JoinResult));
      }
    }

    private EndpointId Read87_EndpointId(bool checkType)
    {
      XmlQualifiedName xsiType = checkType ? this.GetXsiType() : (XmlQualifiedName) null;
      if (checkType)
      {
        if (!(xsiType == (XmlQualifiedName) null) && ((object) xsiType.Name != (object) this.id20_EndpointId || (object) xsiType.Namespace != (object) this.id2_Item))
          throw this.CreateUnknownTypeException(xsiType);
      }
      EndpointId instance;
      try
      {
        instance = (EndpointId) Activator.CreateInstance(typeof (EndpointId), BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.CreateInstance, (Binder) null, new object[0], (CultureInfo) null);
      }
      catch (MissingMethodException ex)
      {
        throw this.CreateInaccessibleConstructorException("global::VRage.Network.EndpointId");
      }
      catch (SecurityException ex)
      {
        throw this.CreateCtorHasSecurityException("global::VRage.Network.EndpointId");
      }
      bool[] flagArray = new bool[0];
      while (this.Reader.MoveToNextAttribute())
      {
        if (!this.IsXmlnsAttribute(this.Reader.Name))
          this.UnknownNode((object) instance);
      }
      this.Reader.MoveToElement();
      if (this.Reader.IsEmptyElement)
      {
        this.Reader.Skip();
        return instance;
      }
      this.Reader.ReadStartElement();
      int content1 = (int) this.Reader.MoveToContent();
      int whileIterations = 0;
      int readerCount = this.ReaderCount;
      while (this.Reader.NodeType != XmlNodeType.EndElement && this.Reader.NodeType != XmlNodeType.None)
      {
        if (this.Reader.NodeType == XmlNodeType.Element)
          this.UnknownNode((object) instance, "");
        else
          this.UnknownNode((object) instance, "");
        int content2 = (int) this.Reader.MoveToContent();
        this.CheckReaderCount(ref whileIterations, ref readerCount);
      }
      this.ReadEndElement();
      return instance;
    }

    private SerializableBoundingSphereD Read42_SerializableBoundingSphereD(bool checkType)
    {
      XmlQualifiedName xsiType = checkType ? this.GetXsiType() : (XmlQualifiedName) null;
      if (checkType)
      {
        if (!(xsiType == (XmlQualifiedName) null) && ((object) xsiType.Name != (object) this.id19_SerializableBoundingSphereD || (object) xsiType.Namespace != (object) this.id2_Item))
          throw this.CreateUnknownTypeException(xsiType);
      }
      SerializableBoundingSphereD instance;
      try
      {
        instance = (SerializableBoundingSphereD) Activator.CreateInstance(typeof (SerializableBoundingSphereD), BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.CreateInstance, (Binder) null, new object[0], (CultureInfo) null);
      }
      catch (MissingMethodException ex)
      {
        throw this.CreateInaccessibleConstructorException("global::VRage.Serialization.SerializableBoundingSphereD");
      }
      catch (SecurityException ex)
      {
        throw this.CreateCtorHasSecurityException("global::VRage.Serialization.SerializableBoundingSphereD");
      }
      bool[] flagArray = new bool[2];
      while (this.Reader.MoveToNextAttribute())
      {
        if (!this.IsXmlnsAttribute(this.Reader.Name))
          this.UnknownNode((object) instance);
      }
      this.Reader.MoveToElement();
      if (this.Reader.IsEmptyElement)
      {
        this.Reader.Skip();
        return instance;
      }
      this.Reader.ReadStartElement();
      int content1 = (int) this.Reader.MoveToContent();
      int whileIterations = 0;
      int readerCount = this.ReaderCount;
      while (this.Reader.NodeType != XmlNodeType.EndElement && this.Reader.NodeType != XmlNodeType.None)
      {
        if (this.Reader.NodeType == XmlNodeType.Element)
        {
          if (!flagArray[0] && (object) this.Reader.LocalName == (object) this.id110_Center && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
          {
            instance.Center = this.Read41_SerializableVector3D(true);
            flagArray[0] = true;
          }
          else if (!flagArray[1] && (object) this.Reader.LocalName == (object) this.id111_Radius && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
          {
            instance.Radius = XmlConvert.ToDouble(this.Reader.ReadElementString());
            flagArray[1] = true;
          }
          else
            this.UnknownNode((object) instance, ":Center, :Radius");
        }
        else
          this.UnknownNode((object) instance, ":Center, :Radius");
        int content2 = (int) this.Reader.MoveToContent();
        this.CheckReaderCount(ref whileIterations, ref readerCount);
      }
      this.ReadEndElement();
      return instance;
    }

    private SerializableVector3D Read41_SerializableVector3D(bool checkType)
    {
      XmlQualifiedName xsiType = checkType ? this.GetXsiType() : (XmlQualifiedName) null;
      if (checkType)
      {
        if (!(xsiType == (XmlQualifiedName) null) && ((object) xsiType.Name != (object) this.id14_SerializableVector3D || (object) xsiType.Namespace != (object) this.id2_Item))
          throw this.CreateUnknownTypeException(xsiType);
      }
      SerializableVector3D instance;
      try
      {
        instance = (SerializableVector3D) Activator.CreateInstance(typeof (SerializableVector3D), BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.CreateInstance, (Binder) null, new object[0], (CultureInfo) null);
      }
      catch (MissingMethodException ex)
      {
        throw this.CreateInaccessibleConstructorException("global::VRage.SerializableVector3D");
      }
      catch (SecurityException ex)
      {
        throw this.CreateCtorHasSecurityException("global::VRage.SerializableVector3D");
      }
      bool[] flagArray = new bool[6];
      while (this.Reader.MoveToNextAttribute())
      {
        if (!flagArray[3] && (object) this.Reader.LocalName == (object) this.id112_x && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
        {
          instance.x = XmlConvert.ToDouble(this.Reader.Value);
          flagArray[3] = true;
        }
        else if (!flagArray[4] && (object) this.Reader.LocalName == (object) this.id113_y && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
        {
          instance.y = XmlConvert.ToDouble(this.Reader.Value);
          flagArray[4] = true;
        }
        else if (!flagArray[5] && (object) this.Reader.LocalName == (object) this.id114_z && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
        {
          instance.z = XmlConvert.ToDouble(this.Reader.Value);
          flagArray[5] = true;
        }
        else if (!this.IsXmlnsAttribute(this.Reader.Name))
          this.UnknownNode((object) instance, ":x, :y, :z");
      }
      this.Reader.MoveToElement();
      if (this.Reader.IsEmptyElement)
      {
        this.Reader.Skip();
        return instance;
      }
      this.Reader.ReadStartElement();
      int content1 = (int) this.Reader.MoveToContent();
      int whileIterations = 0;
      int readerCount = this.ReaderCount;
      while (this.Reader.NodeType != XmlNodeType.EndElement && this.Reader.NodeType != XmlNodeType.None)
      {
        if (this.Reader.NodeType == XmlNodeType.Element)
        {
          if (!flagArray[0] && (object) this.Reader.LocalName == (object) this.id66_X && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
          {
            instance.X = XmlConvert.ToDouble(this.Reader.ReadElementString());
            flagArray[0] = true;
          }
          else if (!flagArray[1] && (object) this.Reader.LocalName == (object) this.id67_Y && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
          {
            instance.Y = XmlConvert.ToDouble(this.Reader.ReadElementString());
            flagArray[1] = true;
          }
          else if (!flagArray[2] && (object) this.Reader.LocalName == (object) this.id68_Z && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
          {
            instance.Z = XmlConvert.ToDouble(this.Reader.ReadElementString());
            flagArray[2] = true;
          }
          else
            this.UnknownNode((object) instance, ":X, :Y, :Z");
        }
        else
          this.UnknownNode((object) instance, ":X, :Y, :Z");
        int content2 = (int) this.Reader.MoveToContent();
        this.CheckReaderCount(ref whileIterations, ref readerCount);
      }
      this.ReadEndElement();
      return instance;
    }

    private MyStorageData Read46_MyStorageData(bool isNullable, bool checkType)
    {
      XmlQualifiedName xsiType = checkType ? this.GetXsiType() : (XmlQualifiedName) null;
      bool flag = false;
      if (isNullable)
        flag = this.ReadNull();
      if (checkType && !(xsiType == (XmlQualifiedName) null) && ((object) xsiType.Name != (object) this.id17_MyStorageData || (object) xsiType.Namespace != (object) this.id2_Item))
        throw this.CreateUnknownTypeException(xsiType);
      if (flag)
        return (MyStorageData) null;
      MyStorageData o = new MyStorageData();
      bool[] flagArray = new bool[0];
      while (this.Reader.MoveToNextAttribute())
      {
        if (!this.IsXmlnsAttribute(this.Reader.Name))
          this.UnknownNode((object) o);
      }
      this.Reader.MoveToElement();
      if (this.Reader.IsEmptyElement)
      {
        this.Reader.Skip();
        return o;
      }
      this.Reader.ReadStartElement();
      int content1 = (int) this.Reader.MoveToContent();
      int whileIterations = 0;
      int readerCount = this.ReaderCount;
      while (this.Reader.NodeType != XmlNodeType.EndElement && this.Reader.NodeType != XmlNodeType.None)
      {
        if (this.Reader.NodeType == XmlNodeType.Element)
          this.UnknownNode((object) o, "");
        else
          this.UnknownNode((object) o, "");
        int content2 = (int) this.Reader.MoveToContent();
        this.CheckReaderCount(ref whileIterations, ref readerCount);
      }
      this.ReadEndElement();
      return o;
    }

    private SerializableVector3UByte Read48_SerializableVector3UByte(bool checkType)
    {
      XmlQualifiedName xsiType = checkType ? this.GetXsiType() : (XmlQualifiedName) null;
      if (checkType)
      {
        if (!(xsiType == (XmlQualifiedName) null) && ((object) xsiType.Name != (object) this.id16_SerializableVector3UByte || (object) xsiType.Namespace != (object) this.id2_Item))
          throw this.CreateUnknownTypeException(xsiType);
      }
      SerializableVector3UByte instance;
      try
      {
        instance = (SerializableVector3UByte) Activator.CreateInstance(typeof (SerializableVector3UByte), BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.CreateInstance, (Binder) null, new object[0], (CultureInfo) null);
      }
      catch (MissingMethodException ex)
      {
        throw this.CreateInaccessibleConstructorException("global::VRage.SerializableVector3UByte");
      }
      catch (SecurityException ex)
      {
        throw this.CreateCtorHasSecurityException("global::VRage.SerializableVector3UByte");
      }
      bool[] flagArray = new bool[6];
      while (this.Reader.MoveToNextAttribute())
      {
        if (!flagArray[3] && (object) this.Reader.LocalName == (object) this.id112_x && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
        {
          instance.x = XmlConvert.ToByte(this.Reader.Value);
          flagArray[3] = true;
        }
        else if (!flagArray[4] && (object) this.Reader.LocalName == (object) this.id113_y && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
        {
          instance.y = XmlConvert.ToByte(this.Reader.Value);
          flagArray[4] = true;
        }
        else if (!flagArray[5] && (object) this.Reader.LocalName == (object) this.id114_z && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
        {
          instance.z = XmlConvert.ToByte(this.Reader.Value);
          flagArray[5] = true;
        }
        else if (!this.IsXmlnsAttribute(this.Reader.Name))
          this.UnknownNode((object) instance, ":x, :y, :z");
      }
      this.Reader.MoveToElement();
      if (this.Reader.IsEmptyElement)
      {
        this.Reader.Skip();
        return instance;
      }
      this.Reader.ReadStartElement();
      int content1 = (int) this.Reader.MoveToContent();
      int whileIterations = 0;
      int readerCount = this.ReaderCount;
      while (this.Reader.NodeType != XmlNodeType.EndElement && this.Reader.NodeType != XmlNodeType.None)
      {
        if (this.Reader.NodeType == XmlNodeType.Element)
        {
          if (!flagArray[0] && (object) this.Reader.LocalName == (object) this.id66_X && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
          {
            instance.X = XmlConvert.ToByte(this.Reader.ReadElementString());
            flagArray[0] = true;
          }
          else if (!flagArray[1] && (object) this.Reader.LocalName == (object) this.id67_Y && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
          {
            instance.Y = XmlConvert.ToByte(this.Reader.ReadElementString());
            flagArray[1] = true;
          }
          else if (!flagArray[2] && (object) this.Reader.LocalName == (object) this.id68_Z && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
          {
            instance.Z = XmlConvert.ToByte(this.Reader.ReadElementString());
            flagArray[2] = true;
          }
          else
            this.UnknownNode((object) instance, ":X, :Y, :Z");
        }
        else
          this.UnknownNode((object) instance, ":X, :Y, :Z");
        int content2 = (int) this.Reader.MoveToContent();
        this.CheckReaderCount(ref whileIterations, ref readerCount);
      }
      this.ReadEndElement();
      return instance;
    }

    private SerializableVector3I Read44_SerializableVector3I(bool checkType)
    {
      XmlQualifiedName xsiType = checkType ? this.GetXsiType() : (XmlQualifiedName) null;
      if (checkType)
      {
        if (!(xsiType == (XmlQualifiedName) null) && ((object) xsiType.Name != (object) this.id15_SerializableVector3I || (object) xsiType.Namespace != (object) this.id2_Item))
          throw this.CreateUnknownTypeException(xsiType);
      }
      SerializableVector3I instance;
      try
      {
        instance = (SerializableVector3I) Activator.CreateInstance(typeof (SerializableVector3I), BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.CreateInstance, (Binder) null, new object[0], (CultureInfo) null);
      }
      catch (MissingMethodException ex)
      {
        throw this.CreateInaccessibleConstructorException("global::VRage.SerializableVector3I");
      }
      catch (SecurityException ex)
      {
        throw this.CreateCtorHasSecurityException("global::VRage.SerializableVector3I");
      }
      bool[] flagArray = new bool[6];
      while (this.Reader.MoveToNextAttribute())
      {
        if (!flagArray[3] && (object) this.Reader.LocalName == (object) this.id112_x && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
        {
          instance.x = XmlConvert.ToInt32(this.Reader.Value);
          flagArray[3] = true;
        }
        else if (!flagArray[4] && (object) this.Reader.LocalName == (object) this.id113_y && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
        {
          instance.y = XmlConvert.ToInt32(this.Reader.Value);
          flagArray[4] = true;
        }
        else if (!flagArray[5] && (object) this.Reader.LocalName == (object) this.id114_z && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
        {
          instance.z = XmlConvert.ToInt32(this.Reader.Value);
          flagArray[5] = true;
        }
        else if (!this.IsXmlnsAttribute(this.Reader.Name))
          this.UnknownNode((object) instance, ":x, :y, :z");
      }
      this.Reader.MoveToElement();
      if (this.Reader.IsEmptyElement)
      {
        this.Reader.Skip();
        return instance;
      }
      this.Reader.ReadStartElement();
      int content1 = (int) this.Reader.MoveToContent();
      int whileIterations = 0;
      int readerCount = this.ReaderCount;
      while (this.Reader.NodeType != XmlNodeType.EndElement && this.Reader.NodeType != XmlNodeType.None)
      {
        if (this.Reader.NodeType == XmlNodeType.Element)
        {
          if (!flagArray[0] && (object) this.Reader.LocalName == (object) this.id66_X && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
          {
            instance.X = XmlConvert.ToInt32(this.Reader.ReadElementString());
            flagArray[0] = true;
          }
          else if (!flagArray[1] && (object) this.Reader.LocalName == (object) this.id67_Y && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
          {
            instance.Y = XmlConvert.ToInt32(this.Reader.ReadElementString());
            flagArray[1] = true;
          }
          else if (!flagArray[2] && (object) this.Reader.LocalName == (object) this.id68_Z && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
          {
            instance.Z = XmlConvert.ToInt32(this.Reader.ReadElementString());
            flagArray[2] = true;
          }
          else
            this.UnknownNode((object) instance, ":X, :Y, :Z");
        }
        else
          this.UnknownNode((object) instance, ":X, :Y, :Z");
        int content2 = (int) this.Reader.MoveToContent();
        this.CheckReaderCount(ref whileIterations, ref readerCount);
      }
      this.ReadEndElement();
      return instance;
    }

    private SerializableVector3D Read85_SerializableVector3D(bool checkType)
    {
      XmlQualifiedName xsiType = checkType ? this.GetXsiType() : (XmlQualifiedName) null;
      if (checkType)
      {
        if (!(xsiType == (XmlQualifiedName) null) && ((object) xsiType.Name != (object) this.id14_SerializableVector3D || (object) xsiType.Namespace != (object) this.id2_Item))
          throw this.CreateUnknownTypeException(xsiType);
      }
      SerializableVector3D instance;
      try
      {
        instance = (SerializableVector3D) Activator.CreateInstance(typeof (SerializableVector3D), BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.CreateInstance, (Binder) null, new object[0], (CultureInfo) null);
      }
      catch (MissingMethodException ex)
      {
        throw this.CreateInaccessibleConstructorException("global::VRage.SerializableVector3D");
      }
      catch (SecurityException ex)
      {
        throw this.CreateCtorHasSecurityException("global::VRage.SerializableVector3D");
      }
      bool[] flagArray = new bool[6];
      while (this.Reader.MoveToNextAttribute())
      {
        if (!flagArray[3] && (object) this.Reader.LocalName == (object) this.id112_x && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
        {
          instance.x = XmlConvert.ToDouble(this.Reader.Value);
          flagArray[3] = true;
        }
        else if (!flagArray[4] && (object) this.Reader.LocalName == (object) this.id113_y && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
        {
          instance.y = XmlConvert.ToDouble(this.Reader.Value);
          flagArray[4] = true;
        }
        else if (!flagArray[5] && (object) this.Reader.LocalName == (object) this.id114_z && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
        {
          instance.z = XmlConvert.ToDouble(this.Reader.Value);
          flagArray[5] = true;
        }
        else if (!this.IsXmlnsAttribute(this.Reader.Name))
          this.UnknownNode((object) instance, ":x, :y, :z");
      }
      this.Reader.MoveToElement();
      if (this.Reader.IsEmptyElement)
      {
        this.Reader.Skip();
        return instance;
      }
      this.Reader.ReadStartElement();
      int content1 = (int) this.Reader.MoveToContent();
      int whileIterations = 0;
      int readerCount = this.ReaderCount;
      while (this.Reader.NodeType != XmlNodeType.EndElement && this.Reader.NodeType != XmlNodeType.None)
      {
        if (this.Reader.NodeType == XmlNodeType.Element)
        {
          if (!flagArray[0] && (object) this.Reader.LocalName == (object) this.id66_X && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
          {
            instance.X = XmlConvert.ToDouble(this.Reader.ReadElementString());
            flagArray[0] = true;
          }
          else if (!flagArray[1] && (object) this.Reader.LocalName == (object) this.id67_Y && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
          {
            instance.Y = XmlConvert.ToDouble(this.Reader.ReadElementString());
            flagArray[1] = true;
          }
          else if (!flagArray[2] && (object) this.Reader.LocalName == (object) this.id68_Z && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
          {
            instance.Z = XmlConvert.ToDouble(this.Reader.ReadElementString());
            flagArray[2] = true;
          }
          else
            this.UnknownNode((object) instance, ":X, :Y, :Z");
        }
        else
          this.UnknownNode((object) instance, ":X, :Y, :Z");
        int content2 = (int) this.Reader.MoveToContent();
        this.CheckReaderCount(ref whileIterations, ref readerCount);
      }
      this.ReadEndElement();
      return instance;
    }

    private SerializableVector3 Read74_SerializableVector3(bool checkType)
    {
      XmlQualifiedName xsiType = checkType ? this.GetXsiType() : (XmlQualifiedName) null;
      if (checkType)
      {
        if (!(xsiType == (XmlQualifiedName) null) && ((object) xsiType.Name != (object) this.id13_SerializableVector3 || (object) xsiType.Namespace != (object) this.id2_Item))
          throw this.CreateUnknownTypeException(xsiType);
      }
      SerializableVector3 instance;
      try
      {
        instance = (SerializableVector3) Activator.CreateInstance(typeof (SerializableVector3), BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.CreateInstance, (Binder) null, new object[0], (CultureInfo) null);
      }
      catch (MissingMethodException ex)
      {
        throw this.CreateInaccessibleConstructorException("global::VRage.SerializableVector3");
      }
      catch (SecurityException ex)
      {
        throw this.CreateCtorHasSecurityException("global::VRage.SerializableVector3");
      }
      bool[] flagArray = new bool[6];
      while (this.Reader.MoveToNextAttribute())
      {
        if (!flagArray[3] && (object) this.Reader.LocalName == (object) this.id112_x && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
        {
          instance.x = XmlConvert.ToSingle(this.Reader.Value);
          flagArray[3] = true;
        }
        else if (!flagArray[4] && (object) this.Reader.LocalName == (object) this.id113_y && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
        {
          instance.y = XmlConvert.ToSingle(this.Reader.Value);
          flagArray[4] = true;
        }
        else if (!flagArray[5] && (object) this.Reader.LocalName == (object) this.id114_z && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
        {
          instance.z = XmlConvert.ToSingle(this.Reader.Value);
          flagArray[5] = true;
        }
        else if (!this.IsXmlnsAttribute(this.Reader.Name))
          this.UnknownNode((object) instance, ":x, :y, :z");
      }
      this.Reader.MoveToElement();
      if (this.Reader.IsEmptyElement)
      {
        this.Reader.Skip();
        return instance;
      }
      this.Reader.ReadStartElement();
      int content1 = (int) this.Reader.MoveToContent();
      int whileIterations = 0;
      int readerCount = this.ReaderCount;
      while (this.Reader.NodeType != XmlNodeType.EndElement && this.Reader.NodeType != XmlNodeType.None)
      {
        if (this.Reader.NodeType == XmlNodeType.Element)
        {
          if (!flagArray[0] && (object) this.Reader.LocalName == (object) this.id66_X && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
          {
            instance.X = XmlConvert.ToSingle(this.Reader.ReadElementString());
            flagArray[0] = true;
          }
          else if (!flagArray[1] && (object) this.Reader.LocalName == (object) this.id67_Y && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
          {
            instance.Y = XmlConvert.ToSingle(this.Reader.ReadElementString());
            flagArray[1] = true;
          }
          else if (!flagArray[2] && (object) this.Reader.LocalName == (object) this.id68_Z && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
          {
            instance.Z = XmlConvert.ToSingle(this.Reader.ReadElementString());
            flagArray[2] = true;
          }
          else
            this.UnknownNode((object) instance, ":X, :Y, :Z");
        }
        else
          this.UnknownNode((object) instance, ":X, :Y, :Z");
        int content2 = (int) this.Reader.MoveToContent();
        this.CheckReaderCount(ref whileIterations, ref readerCount);
      }
      this.ReadEndElement();
      return instance;
    }

    private SerializableVector2I Read55_SerializableVector2I(bool checkType)
    {
      XmlQualifiedName xsiType = checkType ? this.GetXsiType() : (XmlQualifiedName) null;
      if (checkType)
      {
        if (!(xsiType == (XmlQualifiedName) null) && ((object) xsiType.Name != (object) this.id12_SerializableVector2I || (object) xsiType.Namespace != (object) this.id2_Item))
          throw this.CreateUnknownTypeException(xsiType);
      }
      SerializableVector2I instance;
      try
      {
        instance = (SerializableVector2I) Activator.CreateInstance(typeof (SerializableVector2I), BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.CreateInstance, (Binder) null, new object[0], (CultureInfo) null);
      }
      catch (MissingMethodException ex)
      {
        throw this.CreateInaccessibleConstructorException("global::VRage.SerializableVector2I");
      }
      catch (SecurityException ex)
      {
        throw this.CreateCtorHasSecurityException("global::VRage.SerializableVector2I");
      }
      bool[] flagArray = new bool[4];
      while (this.Reader.MoveToNextAttribute())
      {
        if (!flagArray[2] && (object) this.Reader.LocalName == (object) this.id112_x && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
        {
          instance.x = XmlConvert.ToInt32(this.Reader.Value);
          flagArray[2] = true;
        }
        else if (!flagArray[3] && (object) this.Reader.LocalName == (object) this.id113_y && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
        {
          instance.y = XmlConvert.ToInt32(this.Reader.Value);
          flagArray[3] = true;
        }
        else if (!this.IsXmlnsAttribute(this.Reader.Name))
          this.UnknownNode((object) instance, ":x, :y");
      }
      this.Reader.MoveToElement();
      if (this.Reader.IsEmptyElement)
      {
        this.Reader.Skip();
        return instance;
      }
      this.Reader.ReadStartElement();
      int content1 = (int) this.Reader.MoveToContent();
      int whileIterations = 0;
      int readerCount = this.ReaderCount;
      while (this.Reader.NodeType != XmlNodeType.EndElement && this.Reader.NodeType != XmlNodeType.None)
      {
        if (this.Reader.NodeType == XmlNodeType.Element)
        {
          if (!flagArray[0] && (object) this.Reader.LocalName == (object) this.id66_X && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
          {
            instance.X = XmlConvert.ToInt32(this.Reader.ReadElementString());
            flagArray[0] = true;
          }
          else if (!flagArray[1] && (object) this.Reader.LocalName == (object) this.id67_Y && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
          {
            instance.Y = XmlConvert.ToInt32(this.Reader.ReadElementString());
            flagArray[1] = true;
          }
          else
            this.UnknownNode((object) instance, ":X, :Y");
        }
        else
          this.UnknownNode((object) instance, ":X, :Y");
        int content2 = (int) this.Reader.MoveToContent();
        this.CheckReaderCount(ref whileIterations, ref readerCount);
      }
      this.ReadEndElement();
      return instance;
    }

    private SerializableVector2 Read26_SerializableVector2(bool checkType)
    {
      XmlQualifiedName xsiType = checkType ? this.GetXsiType() : (XmlQualifiedName) null;
      if (checkType)
      {
        if (!(xsiType == (XmlQualifiedName) null) && ((object) xsiType.Name != (object) this.id11_SerializableVector2 || (object) xsiType.Namespace != (object) this.id2_Item))
          throw this.CreateUnknownTypeException(xsiType);
      }
      SerializableVector2 instance;
      try
      {
        instance = (SerializableVector2) Activator.CreateInstance(typeof (SerializableVector2), BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.CreateInstance, (Binder) null, new object[0], (CultureInfo) null);
      }
      catch (MissingMethodException ex)
      {
        throw this.CreateInaccessibleConstructorException("global::VRage.SerializableVector2");
      }
      catch (SecurityException ex)
      {
        throw this.CreateCtorHasSecurityException("global::VRage.SerializableVector2");
      }
      bool[] flagArray = new bool[4];
      while (this.Reader.MoveToNextAttribute())
      {
        if (!flagArray[2] && (object) this.Reader.LocalName == (object) this.id112_x && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
        {
          instance.x = XmlConvert.ToSingle(this.Reader.Value);
          flagArray[2] = true;
        }
        else if (!flagArray[3] && (object) this.Reader.LocalName == (object) this.id113_y && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
        {
          instance.y = XmlConvert.ToSingle(this.Reader.Value);
          flagArray[3] = true;
        }
        else if (!this.IsXmlnsAttribute(this.Reader.Name))
          this.UnknownNode((object) instance, ":x, :y");
      }
      this.Reader.MoveToElement();
      if (this.Reader.IsEmptyElement)
      {
        this.Reader.Skip();
        return instance;
      }
      this.Reader.ReadStartElement();
      int content1 = (int) this.Reader.MoveToContent();
      int whileIterations = 0;
      int readerCount = this.ReaderCount;
      while (this.Reader.NodeType != XmlNodeType.EndElement && this.Reader.NodeType != XmlNodeType.None)
      {
        if (this.Reader.NodeType == XmlNodeType.Element)
        {
          if (!flagArray[0] && (object) this.Reader.LocalName == (object) this.id66_X && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
          {
            instance.X = XmlConvert.ToSingle(this.Reader.ReadElementString());
            flagArray[0] = true;
          }
          else if (!flagArray[1] && (object) this.Reader.LocalName == (object) this.id67_Y && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
          {
            instance.Y = XmlConvert.ToSingle(this.Reader.ReadElementString());
            flagArray[1] = true;
          }
          else
            this.UnknownNode((object) instance, ":X, :Y");
        }
        else
          this.UnknownNode((object) instance, ":X, :Y");
        int content2 = (int) this.Reader.MoveToContent();
        this.CheckReaderCount(ref whileIterations, ref readerCount);
      }
      this.ReadEndElement();
      return instance;
    }

    private SerializableQuaternion Read59_SerializableQuaternion(bool checkType)
    {
      XmlQualifiedName xsiType = checkType ? this.GetXsiType() : (XmlQualifiedName) null;
      if (checkType)
      {
        if (!(xsiType == (XmlQualifiedName) null) && ((object) xsiType.Name != (object) this.id10_SerializableQuaternion || (object) xsiType.Namespace != (object) this.id2_Item))
          throw this.CreateUnknownTypeException(xsiType);
      }
      SerializableQuaternion instance;
      try
      {
        instance = (SerializableQuaternion) Activator.CreateInstance(typeof (SerializableQuaternion), BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.CreateInstance, (Binder) null, new object[0], (CultureInfo) null);
      }
      catch (MissingMethodException ex)
      {
        throw this.CreateInaccessibleConstructorException("global::VRage.SerializableQuaternion");
      }
      catch (SecurityException ex)
      {
        throw this.CreateCtorHasSecurityException("global::VRage.SerializableQuaternion");
      }
      bool[] flagArray = new bool[8];
      while (this.Reader.MoveToNextAttribute())
      {
        if (!flagArray[4] && (object) this.Reader.LocalName == (object) this.id112_x && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
        {
          instance.x = XmlConvert.ToSingle(this.Reader.Value);
          flagArray[4] = true;
        }
        else if (!flagArray[5] && (object) this.Reader.LocalName == (object) this.id113_y && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
        {
          instance.y = XmlConvert.ToSingle(this.Reader.Value);
          flagArray[5] = true;
        }
        else if (!flagArray[6] && (object) this.Reader.LocalName == (object) this.id114_z && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
        {
          instance.z = XmlConvert.ToSingle(this.Reader.Value);
          flagArray[6] = true;
        }
        else if (!flagArray[7] && (object) this.Reader.LocalName == (object) this.id115_w && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
        {
          instance.w = XmlConvert.ToSingle(this.Reader.Value);
          flagArray[7] = true;
        }
        else if (!this.IsXmlnsAttribute(this.Reader.Name))
          this.UnknownNode((object) instance, ":x, :y, :z, :w");
      }
      this.Reader.MoveToElement();
      if (this.Reader.IsEmptyElement)
      {
        this.Reader.Skip();
        return instance;
      }
      this.Reader.ReadStartElement();
      int content1 = (int) this.Reader.MoveToContent();
      int whileIterations = 0;
      int readerCount = this.ReaderCount;
      while (this.Reader.NodeType != XmlNodeType.EndElement && this.Reader.NodeType != XmlNodeType.None)
      {
        if (this.Reader.NodeType == XmlNodeType.Element)
        {
          if (!flagArray[0] && (object) this.Reader.LocalName == (object) this.id66_X && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
          {
            instance.X = XmlConvert.ToSingle(this.Reader.ReadElementString());
            flagArray[0] = true;
          }
          else if (!flagArray[1] && (object) this.Reader.LocalName == (object) this.id67_Y && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
          {
            instance.Y = XmlConvert.ToSingle(this.Reader.ReadElementString());
            flagArray[1] = true;
          }
          else if (!flagArray[2] && (object) this.Reader.LocalName == (object) this.id68_Z && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
          {
            instance.Z = XmlConvert.ToSingle(this.Reader.ReadElementString());
            flagArray[2] = true;
          }
          else if (!flagArray[3] && (object) this.Reader.LocalName == (object) this.id116_W && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
          {
            instance.W = XmlConvert.ToSingle(this.Reader.ReadElementString());
            flagArray[3] = true;
          }
          else
            this.UnknownNode((object) instance, ":X, :Y, :Z, :W");
        }
        else
          this.UnknownNode((object) instance, ":X, :Y, :Z, :W");
        int content2 = (int) this.Reader.MoveToContent();
        this.CheckReaderCount(ref whileIterations, ref readerCount);
      }
      this.ReadEndElement();
      return instance;
    }

    private SerializableOrientedBoundingBoxD Read70_Item(bool checkType)
    {
      XmlQualifiedName xsiType = checkType ? this.GetXsiType() : (XmlQualifiedName) null;
      if (checkType)
      {
        if (!(xsiType == (XmlQualifiedName) null) && ((object) xsiType.Name != (object) this.id9_Item || (object) xsiType.Namespace != (object) this.id2_Item))
          throw this.CreateUnknownTypeException(xsiType);
      }
      SerializableOrientedBoundingBoxD instance;
      try
      {
        instance = (SerializableOrientedBoundingBoxD) Activator.CreateInstance(typeof (SerializableOrientedBoundingBoxD), BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.CreateInstance, (Binder) null, new object[0], (CultureInfo) null);
      }
      catch (MissingMethodException ex)
      {
        throw this.CreateInaccessibleConstructorException("global::VRage.SerializableOrientedBoundingBoxD");
      }
      catch (SecurityException ex)
      {
        throw this.CreateCtorHasSecurityException("global::VRage.SerializableOrientedBoundingBoxD");
      }
      bool[] flagArray = new bool[3];
      while (this.Reader.MoveToNextAttribute())
      {
        if (!this.IsXmlnsAttribute(this.Reader.Name))
          this.UnknownNode((object) instance);
      }
      this.Reader.MoveToElement();
      if (this.Reader.IsEmptyElement)
      {
        this.Reader.Skip();
        return instance;
      }
      this.Reader.ReadStartElement();
      int content1 = (int) this.Reader.MoveToContent();
      int whileIterations = 0;
      int readerCount = this.ReaderCount;
      while (this.Reader.NodeType != XmlNodeType.EndElement && this.Reader.NodeType != XmlNodeType.None)
      {
        if (this.Reader.NodeType == XmlNodeType.Element)
        {
          if (!flagArray[0] && (object) this.Reader.LocalName == (object) this.id110_Center && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
          {
            instance.Center = this.Read68_SerializableVector3D(true);
            flagArray[0] = true;
          }
          else if (!flagArray[1] && (object) this.Reader.LocalName == (object) this.id117_HalfExtent && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
          {
            instance.HalfExtent = this.Read68_SerializableVector3D(true);
            flagArray[1] = true;
          }
          else if (!flagArray[2] && (object) this.Reader.LocalName == (object) this.id118_Orientation && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
          {
            instance.Orientation = this.Read69_SerializableQuaternion(true);
            flagArray[2] = true;
          }
          else
            this.UnknownNode((object) instance, ":Center, :HalfExtent, :Orientation");
        }
        else
          this.UnknownNode((object) instance, ":Center, :HalfExtent, :Orientation");
        int content2 = (int) this.Reader.MoveToContent();
        this.CheckReaderCount(ref whileIterations, ref readerCount);
      }
      this.ReadEndElement();
      return instance;
    }

    private SerializableQuaternion Read69_SerializableQuaternion(bool checkType)
    {
      XmlQualifiedName xsiType = checkType ? this.GetXsiType() : (XmlQualifiedName) null;
      if (checkType)
      {
        if (!(xsiType == (XmlQualifiedName) null) && ((object) xsiType.Name != (object) this.id10_SerializableQuaternion || (object) xsiType.Namespace != (object) this.id2_Item))
          throw this.CreateUnknownTypeException(xsiType);
      }
      SerializableQuaternion instance;
      try
      {
        instance = (SerializableQuaternion) Activator.CreateInstance(typeof (SerializableQuaternion), BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.CreateInstance, (Binder) null, new object[0], (CultureInfo) null);
      }
      catch (MissingMethodException ex)
      {
        throw this.CreateInaccessibleConstructorException("global::VRage.SerializableQuaternion");
      }
      catch (SecurityException ex)
      {
        throw this.CreateCtorHasSecurityException("global::VRage.SerializableQuaternion");
      }
      bool[] flagArray = new bool[8];
      while (this.Reader.MoveToNextAttribute())
      {
        if (!flagArray[4] && (object) this.Reader.LocalName == (object) this.id112_x && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
        {
          instance.x = XmlConvert.ToSingle(this.Reader.Value);
          flagArray[4] = true;
        }
        else if (!flagArray[5] && (object) this.Reader.LocalName == (object) this.id113_y && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
        {
          instance.y = XmlConvert.ToSingle(this.Reader.Value);
          flagArray[5] = true;
        }
        else if (!flagArray[6] && (object) this.Reader.LocalName == (object) this.id114_z && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
        {
          instance.z = XmlConvert.ToSingle(this.Reader.Value);
          flagArray[6] = true;
        }
        else if (!flagArray[7] && (object) this.Reader.LocalName == (object) this.id115_w && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
        {
          instance.w = XmlConvert.ToSingle(this.Reader.Value);
          flagArray[7] = true;
        }
        else if (!this.IsXmlnsAttribute(this.Reader.Name))
          this.UnknownNode((object) instance, ":x, :y, :z, :w");
      }
      this.Reader.MoveToElement();
      if (this.Reader.IsEmptyElement)
      {
        this.Reader.Skip();
        return instance;
      }
      this.Reader.ReadStartElement();
      int content1 = (int) this.Reader.MoveToContent();
      int whileIterations = 0;
      int readerCount = this.ReaderCount;
      while (this.Reader.NodeType != XmlNodeType.EndElement && this.Reader.NodeType != XmlNodeType.None)
      {
        if (this.Reader.NodeType == XmlNodeType.Element)
        {
          if (!flagArray[0] && (object) this.Reader.LocalName == (object) this.id66_X && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
          {
            instance.X = XmlConvert.ToSingle(this.Reader.ReadElementString());
            flagArray[0] = true;
          }
          else if (!flagArray[1] && (object) this.Reader.LocalName == (object) this.id67_Y && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
          {
            instance.Y = XmlConvert.ToSingle(this.Reader.ReadElementString());
            flagArray[1] = true;
          }
          else if (!flagArray[2] && (object) this.Reader.LocalName == (object) this.id68_Z && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
          {
            instance.Z = XmlConvert.ToSingle(this.Reader.ReadElementString());
            flagArray[2] = true;
          }
          else if (!flagArray[3] && (object) this.Reader.LocalName == (object) this.id116_W && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
          {
            instance.W = XmlConvert.ToSingle(this.Reader.ReadElementString());
            flagArray[3] = true;
          }
          else
            this.UnknownNode((object) instance, ":X, :Y, :Z, :W");
        }
        else
          this.UnknownNode((object) instance, ":X, :Y, :Z, :W");
        int content2 = (int) this.Reader.MoveToContent();
        this.CheckReaderCount(ref whileIterations, ref readerCount);
      }
      this.ReadEndElement();
      return instance;
    }

    private SerializableVector3D Read68_SerializableVector3D(bool checkType)
    {
      XmlQualifiedName xsiType = checkType ? this.GetXsiType() : (XmlQualifiedName) null;
      if (checkType)
      {
        if (!(xsiType == (XmlQualifiedName) null) && ((object) xsiType.Name != (object) this.id14_SerializableVector3D || (object) xsiType.Namespace != (object) this.id2_Item))
          throw this.CreateUnknownTypeException(xsiType);
      }
      SerializableVector3D instance;
      try
      {
        instance = (SerializableVector3D) Activator.CreateInstance(typeof (SerializableVector3D), BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.CreateInstance, (Binder) null, new object[0], (CultureInfo) null);
      }
      catch (MissingMethodException ex)
      {
        throw this.CreateInaccessibleConstructorException("global::VRage.SerializableVector3D");
      }
      catch (SecurityException ex)
      {
        throw this.CreateCtorHasSecurityException("global::VRage.SerializableVector3D");
      }
      bool[] flagArray = new bool[6];
      while (this.Reader.MoveToNextAttribute())
      {
        if (!flagArray[3] && (object) this.Reader.LocalName == (object) this.id112_x && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
        {
          instance.x = XmlConvert.ToDouble(this.Reader.Value);
          flagArray[3] = true;
        }
        else if (!flagArray[4] && (object) this.Reader.LocalName == (object) this.id113_y && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
        {
          instance.y = XmlConvert.ToDouble(this.Reader.Value);
          flagArray[4] = true;
        }
        else if (!flagArray[5] && (object) this.Reader.LocalName == (object) this.id114_z && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
        {
          instance.z = XmlConvert.ToDouble(this.Reader.Value);
          flagArray[5] = true;
        }
        else if (!this.IsXmlnsAttribute(this.Reader.Name))
          this.UnknownNode((object) instance, ":x, :y, :z");
      }
      this.Reader.MoveToElement();
      if (this.Reader.IsEmptyElement)
      {
        this.Reader.Skip();
        return instance;
      }
      this.Reader.ReadStartElement();
      int content1 = (int) this.Reader.MoveToContent();
      int whileIterations = 0;
      int readerCount = this.ReaderCount;
      while (this.Reader.NodeType != XmlNodeType.EndElement && this.Reader.NodeType != XmlNodeType.None)
      {
        if (this.Reader.NodeType == XmlNodeType.Element)
        {
          if (!flagArray[0] && (object) this.Reader.LocalName == (object) this.id66_X && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
          {
            instance.X = XmlConvert.ToDouble(this.Reader.ReadElementString());
            flagArray[0] = true;
          }
          else if (!flagArray[1] && (object) this.Reader.LocalName == (object) this.id67_Y && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
          {
            instance.Y = XmlConvert.ToDouble(this.Reader.ReadElementString());
            flagArray[1] = true;
          }
          else if (!flagArray[2] && (object) this.Reader.LocalName == (object) this.id68_Z && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
          {
            instance.Z = XmlConvert.ToDouble(this.Reader.ReadElementString());
            flagArray[2] = true;
          }
          else
            this.UnknownNode((object) instance, ":X, :Y, :Z");
        }
        else
          this.UnknownNode((object) instance, ":X, :Y, :Z");
        int content2 = (int) this.Reader.MoveToContent();
        this.CheckReaderCount(ref whileIterations, ref readerCount);
      }
      this.ReadEndElement();
      return instance;
    }

    private SerializableBounds Read2_SerializableBounds(bool checkType)
    {
      XmlQualifiedName xsiType = checkType ? this.GetXsiType() : (XmlQualifiedName) null;
      if (checkType)
      {
        if (!(xsiType == (XmlQualifiedName) null) && ((object) xsiType.Name != (object) this.id8_SerializableBounds || (object) xsiType.Namespace != (object) this.id2_Item))
          throw this.CreateUnknownTypeException(xsiType);
      }
      SerializableBounds instance;
      try
      {
        instance = (SerializableBounds) Activator.CreateInstance(typeof (SerializableBounds), BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.CreateInstance, (Binder) null, new object[0], (CultureInfo) null);
      }
      catch (MissingMethodException ex)
      {
        throw this.CreateInaccessibleConstructorException("global::VRage.SerializableBounds");
      }
      catch (SecurityException ex)
      {
        throw this.CreateCtorHasSecurityException("global::VRage.SerializableBounds");
      }
      bool[] flagArray = new bool[3];
      while (this.Reader.MoveToNextAttribute())
      {
        if (!flagArray[0] && (object) this.Reader.LocalName == (object) this.id119_Min && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
        {
          instance.Min = XmlConvert.ToSingle(this.Reader.Value);
          flagArray[0] = true;
        }
        else if (!flagArray[1] && (object) this.Reader.LocalName == (object) this.id120_Max && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
        {
          instance.Max = XmlConvert.ToSingle(this.Reader.Value);
          flagArray[1] = true;
        }
        else if (!flagArray[2] && (object) this.Reader.LocalName == (object) this.id121_Default && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
        {
          instance.Default = XmlConvert.ToSingle(this.Reader.Value);
          flagArray[2] = true;
        }
        else if (!this.IsXmlnsAttribute(this.Reader.Name))
          this.UnknownNode((object) instance, ":Min, :Max, :Default");
      }
      this.Reader.MoveToElement();
      if (this.Reader.IsEmptyElement)
      {
        this.Reader.Skip();
        return instance;
      }
      this.Reader.ReadStartElement();
      int content1 = (int) this.Reader.MoveToContent();
      int whileIterations = 0;
      int readerCount = this.ReaderCount;
      while (this.Reader.NodeType != XmlNodeType.EndElement && this.Reader.NodeType != XmlNodeType.None)
      {
        if (this.Reader.NodeType == XmlNodeType.Element)
          this.UnknownNode((object) instance, "");
        else
          this.UnknownNode((object) instance, "");
        int content2 = (int) this.Reader.MoveToContent();
        this.CheckReaderCount(ref whileIterations, ref readerCount);
      }
      this.ReadEndElement();
      return instance;
    }

    private SerializableBoundingBoxD Read53_SerializableBoundingBoxD(bool checkType)
    {
      XmlQualifiedName xsiType = checkType ? this.GetXsiType() : (XmlQualifiedName) null;
      if (checkType)
      {
        if (!(xsiType == (XmlQualifiedName) null) && ((object) xsiType.Name != (object) this.id7_SerializableBoundingBoxD || (object) xsiType.Namespace != (object) this.id2_Item))
          throw this.CreateUnknownTypeException(xsiType);
      }
      SerializableBoundingBoxD instance;
      try
      {
        instance = (SerializableBoundingBoxD) Activator.CreateInstance(typeof (SerializableBoundingBoxD), BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.CreateInstance, (Binder) null, new object[0], (CultureInfo) null);
      }
      catch (MissingMethodException ex)
      {
        throw this.CreateInaccessibleConstructorException("global::VRage.SerializableBoundingBoxD");
      }
      catch (SecurityException ex)
      {
        throw this.CreateCtorHasSecurityException("global::VRage.SerializableBoundingBoxD");
      }
      bool[] flagArray = new bool[2];
      while (this.Reader.MoveToNextAttribute())
      {
        if (!this.IsXmlnsAttribute(this.Reader.Name))
          this.UnknownNode((object) instance);
      }
      this.Reader.MoveToElement();
      if (this.Reader.IsEmptyElement)
      {
        this.Reader.Skip();
        return instance;
      }
      this.Reader.ReadStartElement();
      int content1 = (int) this.Reader.MoveToContent();
      int whileIterations = 0;
      int readerCount = this.ReaderCount;
      while (this.Reader.NodeType != XmlNodeType.EndElement && this.Reader.NodeType != XmlNodeType.None)
      {
        if (this.Reader.NodeType == XmlNodeType.Element)
        {
          if (!flagArray[0] && (object) this.Reader.LocalName == (object) this.id119_Min && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
          {
            instance.Min = this.Read52_SerializableVector3D(true);
            flagArray[0] = true;
          }
          else if (!flagArray[1] && (object) this.Reader.LocalName == (object) this.id120_Max && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
          {
            instance.Max = this.Read52_SerializableVector3D(true);
            flagArray[1] = true;
          }
          else
            this.UnknownNode((object) instance, ":Min, :Max");
        }
        else
          this.UnknownNode((object) instance, ":Min, :Max");
        int content2 = (int) this.Reader.MoveToContent();
        this.CheckReaderCount(ref whileIterations, ref readerCount);
      }
      this.ReadEndElement();
      return instance;
    }

    private SerializableVector3D Read52_SerializableVector3D(bool checkType)
    {
      XmlQualifiedName xsiType = checkType ? this.GetXsiType() : (XmlQualifiedName) null;
      if (checkType)
      {
        if (!(xsiType == (XmlQualifiedName) null) && ((object) xsiType.Name != (object) this.id14_SerializableVector3D || (object) xsiType.Namespace != (object) this.id2_Item))
          throw this.CreateUnknownTypeException(xsiType);
      }
      SerializableVector3D instance;
      try
      {
        instance = (SerializableVector3D) Activator.CreateInstance(typeof (SerializableVector3D), BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.CreateInstance, (Binder) null, new object[0], (CultureInfo) null);
      }
      catch (MissingMethodException ex)
      {
        throw this.CreateInaccessibleConstructorException("global::VRage.SerializableVector3D");
      }
      catch (SecurityException ex)
      {
        throw this.CreateCtorHasSecurityException("global::VRage.SerializableVector3D");
      }
      bool[] flagArray = new bool[6];
      while (this.Reader.MoveToNextAttribute())
      {
        if (!flagArray[3] && (object) this.Reader.LocalName == (object) this.id112_x && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
        {
          instance.x = XmlConvert.ToDouble(this.Reader.Value);
          flagArray[3] = true;
        }
        else if (!flagArray[4] && (object) this.Reader.LocalName == (object) this.id113_y && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
        {
          instance.y = XmlConvert.ToDouble(this.Reader.Value);
          flagArray[4] = true;
        }
        else if (!flagArray[5] && (object) this.Reader.LocalName == (object) this.id114_z && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
        {
          instance.z = XmlConvert.ToDouble(this.Reader.Value);
          flagArray[5] = true;
        }
        else if (!this.IsXmlnsAttribute(this.Reader.Name))
          this.UnknownNode((object) instance, ":x, :y, :z");
      }
      this.Reader.MoveToElement();
      if (this.Reader.IsEmptyElement)
      {
        this.Reader.Skip();
        return instance;
      }
      this.Reader.ReadStartElement();
      int content1 = (int) this.Reader.MoveToContent();
      int whileIterations = 0;
      int readerCount = this.ReaderCount;
      while (this.Reader.NodeType != XmlNodeType.EndElement && this.Reader.NodeType != XmlNodeType.None)
      {
        if (this.Reader.NodeType == XmlNodeType.Element)
        {
          if (!flagArray[0] && (object) this.Reader.LocalName == (object) this.id66_X && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
          {
            instance.X = XmlConvert.ToDouble(this.Reader.ReadElementString());
            flagArray[0] = true;
          }
          else if (!flagArray[1] && (object) this.Reader.LocalName == (object) this.id67_Y && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
          {
            instance.Y = XmlConvert.ToDouble(this.Reader.ReadElementString());
            flagArray[1] = true;
          }
          else if (!flagArray[2] && (object) this.Reader.LocalName == (object) this.id68_Z && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
          {
            instance.Z = XmlConvert.ToDouble(this.Reader.ReadElementString());
            flagArray[2] = true;
          }
          else
            this.UnknownNode((object) instance, ":X, :Y, :Z");
        }
        else
          this.UnknownNode((object) instance, ":X, :Y, :Z");
        int content2 = (int) this.Reader.MoveToContent();
        this.CheckReaderCount(ref whileIterations, ref readerCount);
      }
      this.ReadEndElement();
      return instance;
    }

    private MyPositionAndOrientation Read24_MyPositionAndOrientation(bool checkType)
    {
      XmlQualifiedName xsiType = checkType ? this.GetXsiType() : (XmlQualifiedName) null;
      if (checkType)
      {
        if (!(xsiType == (XmlQualifiedName) null) && ((object) xsiType.Name != (object) this.id6_MyPositionAndOrientation || (object) xsiType.Namespace != (object) this.id2_Item))
          throw this.CreateUnknownTypeException(xsiType);
      }
      MyPositionAndOrientation instance;
      try
      {
        instance = (MyPositionAndOrientation) Activator.CreateInstance(typeof (MyPositionAndOrientation), BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.CreateInstance, (Binder) null, new object[0], (CultureInfo) null);
      }
      catch (MissingMethodException ex)
      {
        throw this.CreateInaccessibleConstructorException("global::VRage.MyPositionAndOrientation");
      }
      catch (SecurityException ex)
      {
        throw this.CreateCtorHasSecurityException("global::VRage.MyPositionAndOrientation");
      }
      bool[] flagArray = new bool[4];
      while (this.Reader.MoveToNextAttribute())
      {
        if (!this.IsXmlnsAttribute(this.Reader.Name))
          this.UnknownNode((object) instance);
      }
      this.Reader.MoveToElement();
      if (this.Reader.IsEmptyElement)
      {
        this.Reader.Skip();
        return instance;
      }
      this.Reader.ReadStartElement();
      int content1 = (int) this.Reader.MoveToContent();
      int whileIterations = 0;
      int readerCount = this.ReaderCount;
      while (this.Reader.NodeType != XmlNodeType.EndElement && this.Reader.NodeType != XmlNodeType.None)
      {
        if (this.Reader.NodeType == XmlNodeType.Element)
        {
          if (!flagArray[0] && (object) this.Reader.LocalName == (object) this.id122_Position && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
          {
            instance.Position = this.Read21_SerializableVector3D(true);
            flagArray[0] = true;
          }
          else if (!flagArray[1] && (object) this.Reader.LocalName == (object) this.id123_Forward && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
          {
            instance.Forward = this.Read22_SerializableVector3(true);
            flagArray[1] = true;
          }
          else if (!flagArray[2] && (object) this.Reader.LocalName == (object) this.id124_Up && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
          {
            instance.Up = this.Read22_SerializableVector3(true);
            flagArray[2] = true;
          }
          else if (!flagArray[3] && (object) this.Reader.LocalName == (object) this.id118_Orientation && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
          {
            instance.Orientation = this.Read23_Quaternion(true);
            flagArray[3] = true;
          }
          else
            this.UnknownNode((object) instance, ":Position, :Forward, :Up, :Orientation");
        }
        else
          this.UnknownNode((object) instance, ":Position, :Forward, :Up, :Orientation");
        int content2 = (int) this.Reader.MoveToContent();
        this.CheckReaderCount(ref whileIterations, ref readerCount);
      }
      this.ReadEndElement();
      return instance;
    }

    private Quaternion Read23_Quaternion(bool checkType)
    {
      XmlQualifiedName xsiType = checkType ? this.GetXsiType() : (XmlQualifiedName) null;
      if (checkType)
      {
        if (!(xsiType == (XmlQualifiedName) null) && ((object) xsiType.Name != (object) this.id125_Quaternion || (object) xsiType.Namespace != (object) this.id2_Item))
          throw this.CreateUnknownTypeException(xsiType);
      }
      Quaternion instance;
      try
      {
        instance = (Quaternion) Activator.CreateInstance(typeof (Quaternion), BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.CreateInstance, (Binder) null, new object[0], (CultureInfo) null);
      }
      catch (MissingMethodException ex)
      {
        throw this.CreateInaccessibleConstructorException("global::VRageMath.Quaternion");
      }
      catch (SecurityException ex)
      {
        throw this.CreateCtorHasSecurityException("global::VRageMath.Quaternion");
      }
      bool[] flagArray = new bool[4];
      while (this.Reader.MoveToNextAttribute())
      {
        if (!this.IsXmlnsAttribute(this.Reader.Name))
          this.UnknownNode((object) instance);
      }
      this.Reader.MoveToElement();
      if (this.Reader.IsEmptyElement)
      {
        this.Reader.Skip();
        return instance;
      }
      this.Reader.ReadStartElement();
      int content1 = (int) this.Reader.MoveToContent();
      int whileIterations = 0;
      int readerCount = this.ReaderCount;
      while (this.Reader.NodeType != XmlNodeType.EndElement && this.Reader.NodeType != XmlNodeType.None)
      {
        if (this.Reader.NodeType == XmlNodeType.Element)
        {
          if (!flagArray[0] && (object) this.Reader.LocalName == (object) this.id66_X && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
          {
            instance.X = XmlConvert.ToSingle(this.Reader.ReadElementString());
            flagArray[0] = true;
          }
          else if (!flagArray[1] && (object) this.Reader.LocalName == (object) this.id67_Y && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
          {
            instance.Y = XmlConvert.ToSingle(this.Reader.ReadElementString());
            flagArray[1] = true;
          }
          else if (!flagArray[2] && (object) this.Reader.LocalName == (object) this.id68_Z && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
          {
            instance.Z = XmlConvert.ToSingle(this.Reader.ReadElementString());
            flagArray[2] = true;
          }
          else if (!flagArray[3] && (object) this.Reader.LocalName == (object) this.id116_W && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
          {
            instance.W = XmlConvert.ToSingle(this.Reader.ReadElementString());
            flagArray[3] = true;
          }
          else
            this.UnknownNode((object) instance, ":X, :Y, :Z, :W");
        }
        else
          this.UnknownNode((object) instance, ":X, :Y, :Z, :W");
        int content2 = (int) this.Reader.MoveToContent();
        this.CheckReaderCount(ref whileIterations, ref readerCount);
      }
      this.ReadEndElement();
      return instance;
    }

    private SerializableVector3 Read22_SerializableVector3(bool checkType)
    {
      XmlQualifiedName xsiType = checkType ? this.GetXsiType() : (XmlQualifiedName) null;
      if (checkType)
      {
        if (!(xsiType == (XmlQualifiedName) null) && ((object) xsiType.Name != (object) this.id13_SerializableVector3 || (object) xsiType.Namespace != (object) this.id2_Item))
          throw this.CreateUnknownTypeException(xsiType);
      }
      SerializableVector3 instance;
      try
      {
        instance = (SerializableVector3) Activator.CreateInstance(typeof (SerializableVector3), BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.CreateInstance, (Binder) null, new object[0], (CultureInfo) null);
      }
      catch (MissingMethodException ex)
      {
        throw this.CreateInaccessibleConstructorException("global::VRage.SerializableVector3");
      }
      catch (SecurityException ex)
      {
        throw this.CreateCtorHasSecurityException("global::VRage.SerializableVector3");
      }
      bool[] flagArray = new bool[6];
      while (this.Reader.MoveToNextAttribute())
      {
        if (!flagArray[3] && (object) this.Reader.LocalName == (object) this.id112_x && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
        {
          instance.x = XmlConvert.ToSingle(this.Reader.Value);
          flagArray[3] = true;
        }
        else if (!flagArray[4] && (object) this.Reader.LocalName == (object) this.id113_y && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
        {
          instance.y = XmlConvert.ToSingle(this.Reader.Value);
          flagArray[4] = true;
        }
        else if (!flagArray[5] && (object) this.Reader.LocalName == (object) this.id114_z && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
        {
          instance.z = XmlConvert.ToSingle(this.Reader.Value);
          flagArray[5] = true;
        }
        else if (!this.IsXmlnsAttribute(this.Reader.Name))
          this.UnknownNode((object) instance, ":x, :y, :z");
      }
      this.Reader.MoveToElement();
      if (this.Reader.IsEmptyElement)
      {
        this.Reader.Skip();
        return instance;
      }
      this.Reader.ReadStartElement();
      int content1 = (int) this.Reader.MoveToContent();
      int whileIterations = 0;
      int readerCount = this.ReaderCount;
      while (this.Reader.NodeType != XmlNodeType.EndElement && this.Reader.NodeType != XmlNodeType.None)
      {
        if (this.Reader.NodeType == XmlNodeType.Element)
        {
          if (!flagArray[0] && (object) this.Reader.LocalName == (object) this.id66_X && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
          {
            instance.X = XmlConvert.ToSingle(this.Reader.ReadElementString());
            flagArray[0] = true;
          }
          else if (!flagArray[1] && (object) this.Reader.LocalName == (object) this.id67_Y && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
          {
            instance.Y = XmlConvert.ToSingle(this.Reader.ReadElementString());
            flagArray[1] = true;
          }
          else if (!flagArray[2] && (object) this.Reader.LocalName == (object) this.id68_Z && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
          {
            instance.Z = XmlConvert.ToSingle(this.Reader.ReadElementString());
            flagArray[2] = true;
          }
          else
            this.UnknownNode((object) instance, ":X, :Y, :Z");
        }
        else
          this.UnknownNode((object) instance, ":X, :Y, :Z");
        int content2 = (int) this.Reader.MoveToContent();
        this.CheckReaderCount(ref whileIterations, ref readerCount);
      }
      this.ReadEndElement();
      return instance;
    }

    private SerializableVector3D Read21_SerializableVector3D(bool checkType)
    {
      XmlQualifiedName xsiType = checkType ? this.GetXsiType() : (XmlQualifiedName) null;
      if (checkType)
      {
        if (!(xsiType == (XmlQualifiedName) null) && ((object) xsiType.Name != (object) this.id14_SerializableVector3D || (object) xsiType.Namespace != (object) this.id2_Item))
          throw this.CreateUnknownTypeException(xsiType);
      }
      SerializableVector3D instance;
      try
      {
        instance = (SerializableVector3D) Activator.CreateInstance(typeof (SerializableVector3D), BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.CreateInstance, (Binder) null, new object[0], (CultureInfo) null);
      }
      catch (MissingMethodException ex)
      {
        throw this.CreateInaccessibleConstructorException("global::VRage.SerializableVector3D");
      }
      catch (SecurityException ex)
      {
        throw this.CreateCtorHasSecurityException("global::VRage.SerializableVector3D");
      }
      bool[] flagArray = new bool[6];
      while (this.Reader.MoveToNextAttribute())
      {
        if (!flagArray[3] && (object) this.Reader.LocalName == (object) this.id112_x && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
        {
          instance.x = XmlConvert.ToDouble(this.Reader.Value);
          flagArray[3] = true;
        }
        else if (!flagArray[4] && (object) this.Reader.LocalName == (object) this.id113_y && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
        {
          instance.y = XmlConvert.ToDouble(this.Reader.Value);
          flagArray[4] = true;
        }
        else if (!flagArray[5] && (object) this.Reader.LocalName == (object) this.id114_z && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
        {
          instance.z = XmlConvert.ToDouble(this.Reader.Value);
          flagArray[5] = true;
        }
        else if (!this.IsXmlnsAttribute(this.Reader.Name))
          this.UnknownNode((object) instance, ":x, :y, :z");
      }
      this.Reader.MoveToElement();
      if (this.Reader.IsEmptyElement)
      {
        this.Reader.Skip();
        return instance;
      }
      this.Reader.ReadStartElement();
      int content1 = (int) this.Reader.MoveToContent();
      int whileIterations = 0;
      int readerCount = this.ReaderCount;
      while (this.Reader.NodeType != XmlNodeType.EndElement && this.Reader.NodeType != XmlNodeType.None)
      {
        if (this.Reader.NodeType == XmlNodeType.Element)
        {
          if (!flagArray[0] && (object) this.Reader.LocalName == (object) this.id66_X && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
          {
            instance.X = XmlConvert.ToDouble(this.Reader.ReadElementString());
            flagArray[0] = true;
          }
          else if (!flagArray[1] && (object) this.Reader.LocalName == (object) this.id67_Y && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
          {
            instance.Y = XmlConvert.ToDouble(this.Reader.ReadElementString());
            flagArray[1] = true;
          }
          else if (!flagArray[2] && (object) this.Reader.LocalName == (object) this.id68_Z && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
          {
            instance.Z = XmlConvert.ToDouble(this.Reader.ReadElementString());
            flagArray[2] = true;
          }
          else
            this.UnknownNode((object) instance, ":X, :Y, :Z");
        }
        else
          this.UnknownNode((object) instance, ":X, :Y, :Z");
        int content2 = (int) this.Reader.MoveToContent();
        this.CheckReaderCount(ref whileIterations, ref readerCount);
      }
      this.ReadEndElement();
      return instance;
    }

    private MyOrientation Read66_MyOrientation(bool checkType)
    {
      XmlQualifiedName xsiType = checkType ? this.GetXsiType() : (XmlQualifiedName) null;
      if (checkType)
      {
        if (!(xsiType == (XmlQualifiedName) null) && ((object) xsiType.Name != (object) this.id5_MyOrientation || (object) xsiType.Namespace != (object) this.id2_Item))
          throw this.CreateUnknownTypeException(xsiType);
      }
      MyOrientation instance;
      try
      {
        instance = (MyOrientation) Activator.CreateInstance(typeof (MyOrientation), BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.CreateInstance, (Binder) null, new object[0], (CultureInfo) null);
      }
      catch (MissingMethodException ex)
      {
        throw this.CreateInaccessibleConstructorException("global::VRage.MyOrientation");
      }
      catch (SecurityException ex)
      {
        throw this.CreateCtorHasSecurityException("global::VRage.MyOrientation");
      }
      bool[] flagArray = new bool[3];
      while (this.Reader.MoveToNextAttribute())
      {
        if (!flagArray[0] && (object) this.Reader.LocalName == (object) this.id126_Yaw && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
        {
          instance.Yaw = XmlConvert.ToSingle(this.Reader.Value);
          flagArray[0] = true;
        }
        else if (!flagArray[1] && (object) this.Reader.LocalName == (object) this.id127_Pitch && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
        {
          instance.Pitch = XmlConvert.ToSingle(this.Reader.Value);
          flagArray[1] = true;
        }
        else if (!flagArray[2] && (object) this.Reader.LocalName == (object) this.id128_Roll && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
        {
          instance.Roll = XmlConvert.ToSingle(this.Reader.Value);
          flagArray[2] = true;
        }
        else if (!this.IsXmlnsAttribute(this.Reader.Name))
          this.UnknownNode((object) instance, ":Yaw, :Pitch, :Roll");
      }
      this.Reader.MoveToElement();
      if (this.Reader.IsEmptyElement)
      {
        this.Reader.Skip();
        return instance;
      }
      this.Reader.ReadStartElement();
      int content1 = (int) this.Reader.MoveToContent();
      int whileIterations = 0;
      int readerCount = this.ReaderCount;
      while (this.Reader.NodeType != XmlNodeType.EndElement && this.Reader.NodeType != XmlNodeType.None)
      {
        if (this.Reader.NodeType == XmlNodeType.Element)
          this.UnknownNode((object) instance, "");
        else
          this.UnknownNode((object) instance, "");
        int content2 = (int) this.Reader.MoveToContent();
        this.CheckReaderCount(ref whileIterations, ref readerCount);
      }
      this.ReadEndElement();
      return instance;
    }

    private MyDeltaTransform Read31_MyDeltaTransform(bool checkType)
    {
      XmlQualifiedName xsiType = checkType ? this.GetXsiType() : (XmlQualifiedName) null;
      if (checkType)
      {
        if (!(xsiType == (XmlQualifiedName) null) && ((object) xsiType.Name != (object) this.id4_MyDeltaTransform || (object) xsiType.Namespace != (object) this.id2_Item))
          throw this.CreateUnknownTypeException(xsiType);
      }
      MyDeltaTransform instance;
      try
      {
        instance = (MyDeltaTransform) Activator.CreateInstance(typeof (MyDeltaTransform), BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.CreateInstance, (Binder) null, new object[0], (CultureInfo) null);
      }
      catch (MissingMethodException ex)
      {
        throw this.CreateInaccessibleConstructorException("global::VRage.MyDeltaTransform");
      }
      catch (SecurityException ex)
      {
        throw this.CreateCtorHasSecurityException("global::VRage.MyDeltaTransform");
      }
      bool[] flagArray = new bool[3];
      while (this.Reader.MoveToNextAttribute())
      {
        if (!this.IsXmlnsAttribute(this.Reader.Name))
          this.UnknownNode((object) instance);
      }
      this.Reader.MoveToElement();
      if (this.Reader.IsEmptyElement)
      {
        this.Reader.Skip();
        return instance;
      }
      this.Reader.ReadStartElement();
      int content1 = (int) this.Reader.MoveToContent();
      int whileIterations = 0;
      int readerCount = this.ReaderCount;
      while (this.Reader.NodeType != XmlNodeType.EndElement && this.Reader.NodeType != XmlNodeType.None)
      {
        if (this.Reader.NodeType == XmlNodeType.Element)
        {
          if (!flagArray[0] && (object) this.Reader.LocalName == (object) this.id129_OrientationOffset && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
          {
            instance.OrientationOffset = this.Read28_Quaternion(true);
            flagArray[0] = true;
          }
          else if (!flagArray[1] && (object) this.Reader.LocalName == (object) this.id130_PositionOffset && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
          {
            instance.PositionOffset = this.Read29_Vector3(true);
            flagArray[1] = true;
          }
          else if (!flagArray[2] && (object) this.Reader.LocalName == (object) this.id131_OrientationAsVector && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
          {
            instance.OrientationAsVector = this.Read30_Vector4(true);
            flagArray[2] = true;
          }
          else
            this.UnknownNode((object) instance, ":OrientationOffset, :PositionOffset, :OrientationAsVector");
        }
        else
          this.UnknownNode((object) instance, ":OrientationOffset, :PositionOffset, :OrientationAsVector");
        int content2 = (int) this.Reader.MoveToContent();
        this.CheckReaderCount(ref whileIterations, ref readerCount);
      }
      this.ReadEndElement();
      return instance;
    }

    private Vector4 Read30_Vector4(bool checkType)
    {
      XmlQualifiedName xsiType = checkType ? this.GetXsiType() : (XmlQualifiedName) null;
      if (checkType)
      {
        if (!(xsiType == (XmlQualifiedName) null) && ((object) xsiType.Name != (object) this.id132_Vector4 || (object) xsiType.Namespace != (object) this.id2_Item))
          throw this.CreateUnknownTypeException(xsiType);
      }
      Vector4 instance;
      try
      {
        instance = (Vector4) Activator.CreateInstance(typeof (Vector4), BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.CreateInstance, (Binder) null, new object[0], (CultureInfo) null);
      }
      catch (MissingMethodException ex)
      {
        throw this.CreateInaccessibleConstructorException("global::VRageMath.Vector4");
      }
      catch (SecurityException ex)
      {
        throw this.CreateCtorHasSecurityException("global::VRageMath.Vector4");
      }
      bool[] flagArray = new bool[4];
      while (this.Reader.MoveToNextAttribute())
      {
        if (!this.IsXmlnsAttribute(this.Reader.Name))
          this.UnknownNode((object) instance);
      }
      this.Reader.MoveToElement();
      if (this.Reader.IsEmptyElement)
      {
        this.Reader.Skip();
        return instance;
      }
      this.Reader.ReadStartElement();
      int content1 = (int) this.Reader.MoveToContent();
      int whileIterations = 0;
      int readerCount = this.ReaderCount;
      while (this.Reader.NodeType != XmlNodeType.EndElement && this.Reader.NodeType != XmlNodeType.None)
      {
        if (this.Reader.NodeType == XmlNodeType.Element)
        {
          if (!flagArray[0] && (object) this.Reader.LocalName == (object) this.id66_X && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
          {
            instance.X = XmlConvert.ToSingle(this.Reader.ReadElementString());
            flagArray[0] = true;
          }
          else if (!flagArray[1] && (object) this.Reader.LocalName == (object) this.id67_Y && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
          {
            instance.Y = XmlConvert.ToSingle(this.Reader.ReadElementString());
            flagArray[1] = true;
          }
          else if (!flagArray[2] && (object) this.Reader.LocalName == (object) this.id68_Z && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
          {
            instance.Z = XmlConvert.ToSingle(this.Reader.ReadElementString());
            flagArray[2] = true;
          }
          else if (!flagArray[3] && (object) this.Reader.LocalName == (object) this.id116_W && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
          {
            instance.W = XmlConvert.ToSingle(this.Reader.ReadElementString());
            flagArray[3] = true;
          }
          else
            this.UnknownNode((object) instance, ":X, :Y, :Z, :W");
        }
        else
          this.UnknownNode((object) instance, ":X, :Y, :Z, :W");
        int content2 = (int) this.Reader.MoveToContent();
        this.CheckReaderCount(ref whileIterations, ref readerCount);
      }
      this.ReadEndElement();
      return instance;
    }

    private Vector3 Read29_Vector3(bool checkType)
    {
      XmlQualifiedName xsiType = checkType ? this.GetXsiType() : (XmlQualifiedName) null;
      if (checkType)
      {
        if (!(xsiType == (XmlQualifiedName) null) && ((object) xsiType.Name != (object) this.id133_Vector3 || (object) xsiType.Namespace != (object) this.id2_Item))
          throw this.CreateUnknownTypeException(xsiType);
      }
      Vector3 instance;
      try
      {
        instance = (Vector3) Activator.CreateInstance(typeof (Vector3), BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.CreateInstance, (Binder) null, new object[0], (CultureInfo) null);
      }
      catch (MissingMethodException ex)
      {
        throw this.CreateInaccessibleConstructorException("global::VRageMath.Vector3");
      }
      catch (SecurityException ex)
      {
        throw this.CreateCtorHasSecurityException("global::VRageMath.Vector3");
      }
      bool[] flagArray = new bool[3];
      while (this.Reader.MoveToNextAttribute())
      {
        if (!this.IsXmlnsAttribute(this.Reader.Name))
          this.UnknownNode((object) instance);
      }
      this.Reader.MoveToElement();
      if (this.Reader.IsEmptyElement)
      {
        this.Reader.Skip();
        return instance;
      }
      this.Reader.ReadStartElement();
      int content1 = (int) this.Reader.MoveToContent();
      int whileIterations = 0;
      int readerCount = this.ReaderCount;
      while (this.Reader.NodeType != XmlNodeType.EndElement && this.Reader.NodeType != XmlNodeType.None)
      {
        if (this.Reader.NodeType == XmlNodeType.Element)
        {
          if (!flagArray[0] && (object) this.Reader.LocalName == (object) this.id66_X && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
          {
            instance.X = XmlConvert.ToSingle(this.Reader.ReadElementString());
            flagArray[0] = true;
          }
          else if (!flagArray[1] && (object) this.Reader.LocalName == (object) this.id67_Y && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
          {
            instance.Y = XmlConvert.ToSingle(this.Reader.ReadElementString());
            flagArray[1] = true;
          }
          else if (!flagArray[2] && (object) this.Reader.LocalName == (object) this.id68_Z && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
          {
            instance.Z = XmlConvert.ToSingle(this.Reader.ReadElementString());
            flagArray[2] = true;
          }
          else
            this.UnknownNode((object) instance, ":X, :Y, :Z");
        }
        else
          this.UnknownNode((object) instance, ":X, :Y, :Z");
        int content2 = (int) this.Reader.MoveToContent();
        this.CheckReaderCount(ref whileIterations, ref readerCount);
      }
      this.ReadEndElement();
      return instance;
    }

    private Quaternion Read28_Quaternion(bool checkType)
    {
      XmlQualifiedName xsiType = checkType ? this.GetXsiType() : (XmlQualifiedName) null;
      if (checkType)
      {
        if (!(xsiType == (XmlQualifiedName) null) && ((object) xsiType.Name != (object) this.id125_Quaternion || (object) xsiType.Namespace != (object) this.id2_Item))
          throw this.CreateUnknownTypeException(xsiType);
      }
      Quaternion instance;
      try
      {
        instance = (Quaternion) Activator.CreateInstance(typeof (Quaternion), BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.CreateInstance, (Binder) null, new object[0], (CultureInfo) null);
      }
      catch (MissingMethodException ex)
      {
        throw this.CreateInaccessibleConstructorException("global::VRageMath.Quaternion");
      }
      catch (SecurityException ex)
      {
        throw this.CreateCtorHasSecurityException("global::VRageMath.Quaternion");
      }
      bool[] flagArray = new bool[4];
      while (this.Reader.MoveToNextAttribute())
      {
        if (!this.IsXmlnsAttribute(this.Reader.Name))
          this.UnknownNode((object) instance);
      }
      this.Reader.MoveToElement();
      if (this.Reader.IsEmptyElement)
      {
        this.Reader.Skip();
        return instance;
      }
      this.Reader.ReadStartElement();
      int content1 = (int) this.Reader.MoveToContent();
      int whileIterations = 0;
      int readerCount = this.ReaderCount;
      while (this.Reader.NodeType != XmlNodeType.EndElement && this.Reader.NodeType != XmlNodeType.None)
      {
        if (this.Reader.NodeType == XmlNodeType.Element)
        {
          if (!flagArray[0] && (object) this.Reader.LocalName == (object) this.id66_X && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
          {
            instance.X = XmlConvert.ToSingle(this.Reader.ReadElementString());
            flagArray[0] = true;
          }
          else if (!flagArray[1] && (object) this.Reader.LocalName == (object) this.id67_Y && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
          {
            instance.Y = XmlConvert.ToSingle(this.Reader.ReadElementString());
            flagArray[1] = true;
          }
          else if (!flagArray[2] && (object) this.Reader.LocalName == (object) this.id68_Z && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
          {
            instance.Z = XmlConvert.ToSingle(this.Reader.ReadElementString());
            flagArray[2] = true;
          }
          else if (!flagArray[3] && (object) this.Reader.LocalName == (object) this.id116_W && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
          {
            instance.W = XmlConvert.ToSingle(this.Reader.ReadElementString());
            flagArray[3] = true;
          }
          else
            this.UnknownNode((object) instance, ":X, :Y, :Z, :W");
        }
        else
          this.UnknownNode((object) instance, ":X, :Y, :Z, :W");
        int content2 = (int) this.Reader.MoveToContent();
        this.CheckReaderCount(ref whileIterations, ref readerCount);
      }
      this.ReadEndElement();
      return instance;
    }

    private MyAudioWave Read39_MyAudioWave(bool isNullable, bool checkType)
    {
      XmlQualifiedName xsiType = checkType ? this.GetXsiType() : (XmlQualifiedName) null;
      bool flag = false;
      if (isNullable)
        flag = this.ReadNull();
      if (checkType && !(xsiType == (XmlQualifiedName) null) && ((object) xsiType.Name != (object) this.id3_Wave || (object) xsiType.Namespace != (object) this.id2_Item))
        throw this.CreateUnknownTypeException(xsiType);
      if (flag)
        return (MyAudioWave) null;
      MyAudioWave o = new MyAudioWave();
      bool[] flagArray = new bool[4];
      while (this.Reader.MoveToNextAttribute())
      {
        if (!flagArray[0] && (object) this.Reader.LocalName == (object) this.id134_Type && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
        {
          o.Type = this.Read37_MySoundDimensions(this.Reader.Value);
          flagArray[0] = true;
        }
        else if (!this.IsXmlnsAttribute(this.Reader.Name))
          this.UnknownNode((object) o, ":Type");
      }
      this.Reader.MoveToElement();
      if (this.Reader.IsEmptyElement)
      {
        this.Reader.Skip();
        return o;
      }
      this.Reader.ReadStartElement();
      int content1 = (int) this.Reader.MoveToContent();
      int whileIterations = 0;
      int readerCount = this.ReaderCount;
      while (this.Reader.NodeType != XmlNodeType.EndElement && this.Reader.NodeType != XmlNodeType.None)
      {
        if (this.Reader.NodeType == XmlNodeType.Element)
        {
          if (!flagArray[1] && (object) this.Reader.LocalName == (object) this.id135_Start && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
          {
            o.Start = this.Reader.ReadElementString();
            flagArray[1] = true;
          }
          else if (!flagArray[2] && (object) this.Reader.LocalName == (object) this.id136_Loop && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
          {
            o.Loop = this.Reader.ReadElementString();
            flagArray[2] = true;
          }
          else if (!flagArray[3] && (object) this.Reader.LocalName == (object) this.id137_End && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
          {
            o.End = this.Reader.ReadElementString();
            flagArray[3] = true;
          }
          else
            this.UnknownNode((object) o, ":Start, :Loop, :End");
        }
        else
          this.UnknownNode((object) o, ":Start, :Loop, :End");
        int content2 = (int) this.Reader.MoveToContent();
        this.CheckReaderCount(ref whileIterations, ref readerCount);
      }
      this.ReadEndElement();
      return o;
    }

    private MySoundDimensions Read37_MySoundDimensions(string s)
    {
      switch (s)
      {
        case "D2":
          return MySoundDimensions.D2;
        case "D3":
          return MySoundDimensions.D3;
        default:
          throw this.CreateUnknownConstantException(s, typeof (MySoundDimensions));
      }
    }

    private DistantSound Read72_DistantSound(bool isNullable, bool checkType)
    {
      XmlQualifiedName xsiType = checkType ? this.GetXsiType() : (XmlQualifiedName) null;
      bool flag = false;
      if (isNullable)
        flag = this.ReadNull();
      if (checkType && !(xsiType == (XmlQualifiedName) null) && ((object) xsiType.Name != (object) this.id1_DistantSound || (object) xsiType.Namespace != (object) this.id2_Item))
        throw this.CreateUnknownTypeException(xsiType);
      if (flag)
        return (DistantSound) null;
      DistantSound o = new DistantSound();
      bool[] flagArray = new bool[3];
      while (this.Reader.MoveToNextAttribute())
      {
        if (!flagArray[0] && (object) this.Reader.LocalName == (object) this.id138_Distance && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
        {
          o.Distance = XmlConvert.ToSingle(this.Reader.Value);
          flagArray[0] = true;
        }
        else if (!flagArray[1] && (object) this.Reader.LocalName == (object) this.id139_DistanceCrossfade && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
        {
          o.DistanceCrossfade = XmlConvert.ToSingle(this.Reader.Value);
          flagArray[1] = true;
        }
        else if (!flagArray[2] && (object) this.Reader.LocalName == (object) this.id140_Sound && (object) this.Reader.NamespaceURI == (object) this.id2_Item)
        {
          o.Sound = this.Reader.Value;
          flagArray[2] = true;
        }
        else if (!this.IsXmlnsAttribute(this.Reader.Name))
          this.UnknownNode((object) o, ":Distance, :DistanceCrossfade, :Sound");
      }
      this.Reader.MoveToElement();
      if (this.Reader.IsEmptyElement)
      {
        this.Reader.Skip();
        return o;
      }
      this.Reader.ReadStartElement();
      int content1 = (int) this.Reader.MoveToContent();
      int whileIterations = 0;
      int readerCount = this.ReaderCount;
      while (this.Reader.NodeType != XmlNodeType.EndElement && this.Reader.NodeType != XmlNodeType.None)
      {
        if (this.Reader.NodeType == XmlNodeType.Element)
          this.UnknownNode((object) o, "");
        else
          this.UnknownNode((object) o, "");
        int content2 = (int) this.Reader.MoveToContent();
        this.CheckReaderCount(ref whileIterations, ref readerCount);
      }
      this.ReadEndElement();
      return o;
    }

    protected override void InitCallbacks()
    {
    }

    protected override void InitIDs()
    {
      this.id79_IsAdmin = this.Reader.NameTable.Add("IsAdmin");
      this.id58_long = this.Reader.NameTable.Add("long");
      this.id73_ForcePlayoutDelayBuffer = this.Reader.NameTable.Add("ForcePlayoutDelayBuffer");
      this.id112_x = this.Reader.NameTable.Add("x");
      this.id125_Quaternion = this.Reader.NameTable.Add("Quaternion");
      this.id20_EndpointId = this.Reader.NameTable.Add("EndpointId");
      this.id88_CrossChatEnabled = this.Reader.NameTable.Add("CrossChatEnabled");
      this.id98_WorldSize = this.Reader.NameTable.Add("WorldSize");
      this.id64_Color = this.Reader.NameTable.Add("Color");
      this.id138_Distance = this.Reader.NameTable.Add("Distance");
      this.id93_GameMode = this.Reader.NameTable.Add("GameMode");
      this.id34_ModVersion = this.Reader.NameTable.Add("ModVersion");
      this.id43_IconTexture = this.Reader.NameTable.Add("IconTexture");
      this.id51_IsStoreHidden = this.Reader.NameTable.Add("IsStoreHidden");
      this.id30_ModMetadata = this.Reader.NameTable.Add("ModMetadata");
      this.id109_Admin = this.Reader.NameTable.Add("Admin");
      this.id32_Hash = this.Reader.NameTable.Add("Hash");
      this.id122_Position = this.Reader.NameTable.Add("Position");
      this.id83_IsProfiling = this.Reader.NameTable.Add("IsProfiling");
      this.id55_ItemDefinition = this.Reader.NameTable.Add("ItemDefinition");
      this.id132_Vector4 = this.Reader.NameTable.Add("Vector4");
      this.id61_AuthorName = this.Reader.NameTable.Add("AuthorName");
      this.id44_AssetModifierId = this.Reader.NameTable.Add("AssetModifierId");
      this.id90_BlockedUsers = this.Reader.NameTable.Add("BlockedUsers");
      this.id89_CustomData = this.Reader.NameTable.Add("CustomData");
      this.id12_SerializableVector2I = this.Reader.NameTable.Add("SerializableVector2I");
      this.id15_SerializableVector3I = this.Reader.NameTable.Add("SerializableVector3I");
      this.id39_Tradable = this.Reader.NameTable.Add("Tradable");
      this.id114_z = this.Reader.NameTable.Add("z");
      this.id24_ChatMsg = this.Reader.NameTable.Add("ChatMsg");
      this.id128_Roll = this.Reader.NameTable.Add("Roll");
      this.id127_Pitch = this.Reader.NameTable.Add("Pitch");
      this.id76_UsePlayoutDelayBufferForGrids = this.Reader.NameTable.Add("UsePlayoutDelayBufferForGrids");
      this.id124_Up = this.Reader.NameTable.Add("Up");
      this.id2_Item = this.Reader.NameTable.Add("");
      this.id5_MyOrientation = this.Reader.NameTable.Add("MyOrientation");
      this.id26_ClientReadyDataMsg = this.Reader.NameTable.Add("ClientReadyDataMsg");
      this.id139_DistanceCrossfade = this.Reader.NameTable.Add("DistanceCrossfade");
      this.id116_W = this.Reader.NameTable.Add("W");
      this.id27_ChatMessageCustomData = this.Reader.NameTable.Add("ChatMessageCustomData");
      this.id40_Marketable = this.Reader.NameTable.Add("Marketable");
      this.id11_SerializableVector2 = this.Reader.NameTable.Add("SerializableVector2");
      this.id13_SerializableVector3 = this.Reader.NameTable.Add("SerializableVector3");
      this.id91_unsignedLong = this.Reader.NameTable.Add("unsignedLong");
      this.id137_End = this.Reader.NameTable.Add("End");
      this.id18_MyStringHash = this.Reader.NameTable.Add("MyStringHash");
      this.id57_UsingCharacters = this.Reader.NameTable.Add("UsingCharacters");
      this.id60_IsNew = this.Reader.NameTable.Add("IsNew");
      this.id126_Yaw = this.Reader.NameTable.Add("Yaw");
      this.id54_Exchange = this.Reader.NameTable.Add("Exchange");
      this.id108_ServerExperimental = this.Reader.NameTable.Add("ServerExperimental");
      this.id97_HostName = this.Reader.NameTable.Add("HostName");
      this.id31_MyCueId = this.Reader.NameTable.Add("MyCueId");
      this.id62_SenderId = this.Reader.NameTable.Add("SenderId");
      this.id3_Wave = this.Reader.NameTable.Add("Wave");
      this.id140_Sound = this.Reader.NameTable.Add("Sound");
      this.id102_WelderMultiplier = this.Reader.NameTable.Add("WelderMultiplier");
      this.id50_Hidden = this.Reader.NameTable.Add("Hidden");
      this.id107_JoinResult = this.Reader.NameTable.Add("JoinResult");
      this.id37_ID = this.Reader.NameTable.Add("ID");
      this.id78_ServiceName = this.Reader.NameTable.Add("ServiceName");
      this.id100_MembersLimit = this.Reader.NameTable.Add("MembersLimit");
      this.id33_ModMetadataFile = this.Reader.NameTable.Add("ModMetadataFile");
      this.id42_DisplayType = this.Reader.NameTable.Add("DisplayType");
      this.id113_y = this.Reader.NameTable.Add("y");
      this.id63_TextColor = this.Reader.NameTable.Add("TextColor");
      this.id8_SerializableBounds = this.Reader.NameTable.Add("SerializableBounds");
      this.id74_Item = this.Reader.NameTable.Add("UsePlayoutDelayBufferForCharacter");
      this.id129_OrientationOffset = this.Reader.NameTable.Add("OrientationOffset");
      this.id82_ExperimentalMode = this.Reader.NameTable.Add("ExperimentalMode");
      this.id25_ConnectedClientDataMsg = this.Reader.NameTable.Add("ConnectedClientDataMsg");
      this.id95_AssemblerMultiplier = this.Reader.NameTable.Add("AssemblerMultiplier");
      this.id35_MinGameVersion = this.Reader.NameTable.Add("MinGameVersion");
      this.id36_MaxGameVersion = this.Reader.NameTable.Add("MaxGameVersion");
      this.id65_PackedValue = this.Reader.NameTable.Add("PackedValue");
      this.id59_IsStoreFakeItem = this.Reader.NameTable.Add("IsStoreFakeItem");
      this.id28_MyGameInventoryItem = this.Reader.NameTable.Add("MyGameInventoryItem");
      this.id101_DataHash = this.Reader.NameTable.Add("DataHash");
      this.id53_ItemQuality = this.Reader.NameTable.Add("ItemQuality");
      this.id86_Channel = this.Reader.NameTable.Add("Channel");
      this.id85_Author = this.Reader.NameTable.Add("Author");
      this.id52_CanBePurchased = this.Reader.NameTable.Add("CanBePurchased");
      this.id117_HalfExtent = this.Reader.NameTable.Add("HalfExtent");
      this.id23_BlockList = this.Reader.NameTable.Add("BlockList");
      this.id80_Join = this.Reader.NameTable.Add("Join");
      this.id133_Vector3 = this.Reader.NameTable.Add("Vector3");
      this.id41_Description = this.Reader.NameTable.Add("Description");
      this.id14_SerializableVector3D = this.Reader.NameTable.Add("SerializableVector3D");
      this.id16_SerializableVector3UByte = this.Reader.NameTable.Add("SerializableVector3UByte");
      this.id47_NameColor = this.Reader.NameTable.Add("NameColor");
      this.id19_SerializableBoundingSphereD = this.Reader.NameTable.Add("SerializableBoundingSphereD");
      this.id48_BackgroundColor = this.Reader.NameTable.Add("BackgroundColor");
      this.id120_Max = this.Reader.NameTable.Add("Max");
      this.id135_Start = this.Reader.NameTable.Add("Start");
      this.id130_PositionOffset = this.Reader.NameTable.Add("PositionOffset");
      this.id134_Type = this.Reader.NameTable.Add("Type");
      this.id111_Radius = this.Reader.NameTable.Add("Radius");
      this.id123_Forward = this.Reader.NameTable.Add("Forward");
      this.id136_Loop = this.Reader.NameTable.Add("Loop");
      this.id68_Z = this.Reader.NameTable.Add("Z");
      this.id119_Min = this.Reader.NameTable.Add("Min");
      this.id66_X = this.Reader.NameTable.Add("X");
      this.id67_Y = this.Reader.NameTable.Add("Y");
      this.id6_MyPositionAndOrientation = this.Reader.NameTable.Add("MyPositionAndOrientation");
      this.id106_ServerAnalyticsId = this.Reader.NameTable.Add("ServerAnalyticsId");
      this.id71_B = this.Reader.NameTable.Add("B");
      this.id69_R = this.Reader.NameTable.Add("R");
      this.id10_SerializableQuaternion = this.Reader.NameTable.Add("SerializableQuaternion");
      this.id56_Quantity = this.Reader.NameTable.Add("Quantity");
      this.id7_SerializableBoundingBoxD = this.Reader.NameTable.Add("SerializableBoundingBoxD");
      this.id49_DefinitionType = this.Reader.NameTable.Add("DefinitionType");
      this.id105_ServerPasswordSalt = this.Reader.NameTable.Add("ServerPasswordSalt");
      this.id121_Default = this.Reader.NameTable.Add("Default");
      this.id94_InventoryMultiplier = this.Reader.NameTable.Add("InventoryMultiplier");
      this.id77_ClientId = this.Reader.NameTable.Add("ClientId");
      this.id131_OrientationAsVector = this.Reader.NameTable.Add("OrientationAsVector");
      this.id17_MyStorageData = this.Reader.NameTable.Add("MyStorageData");
      this.id4_MyDeltaTransform = this.Reader.NameTable.Add("MyDeltaTransform");
      this.id38_Name = this.Reader.NameTable.Add("Name");
      this.id72_A = this.Reader.NameTable.Add("A");
      this.id70_G = this.Reader.NameTable.Add("G");
      this.id46_ToolName = this.Reader.NameTable.Add("ToolName");
      this.id21_JoinResultMsg = this.Reader.NameTable.Add("JoinResultMsg");
      this.id9_Item = this.Reader.NameTable.Add("SerializableOrientedBoundingBoxD");
      this.id96_RefineryMultiplier = this.Reader.NameTable.Add("RefineryMultiplier");
      this.id92_WorldName = this.Reader.NameTable.Add("WorldName");
      this.id1_DistantSound = this.Reader.NameTable.Add("DistantSound");
      this.id29_MyGameInventoryItemDefinition = this.Reader.NameTable.Add("MyGameInventoryItemDefinition");
      this.id87_TargetId = this.Reader.NameTable.Add("TargetId");
      this.id84_Text = this.Reader.NameTable.Add("Text");
      this.id81_Token = this.Reader.NameTable.Add("Token");
      this.id103_GrinderMultiplier = this.Reader.NameTable.Add("GrinderMultiplier");
      this.id115_w = this.Reader.NameTable.Add("w");
      this.id118_Orientation = this.Reader.NameTable.Add("Orientation");
      this.id99_AppVersion = this.Reader.NameTable.Add("AppVersion");
      this.id45_ItemSlot = this.Reader.NameTable.Add("ItemSlot");
      this.id22_ServerDataMsg = this.Reader.NameTable.Add("ServerDataMsg");
      this.id110_Center = this.Reader.NameTable.Add("Center");
      this.id75_Item = this.Reader.NameTable.Add("UsePlayoutDelayBufferForJetpack");
      this.id104_BlocksInventoryMultiplier = this.Reader.NameTable.Add("BlocksInventoryMultiplier");
    }
  }
}
