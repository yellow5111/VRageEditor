// Decompiled with JetBrains decompiler
// Type: Microsoft.Xml.Serialization.GeneratedAssembly.XmlSerializerContract
// Assembly: VRage.XmlSerializers, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A6DCFDC0-3000-43E3-988A-2A1D50DBB2EA
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\SpaceEngineers\Tools\VRageEditor\Plugins\ModelBuilder\net48\VRage.XmlSerializers.dll

using System;
using System.Collections;
using System.Xml.Serialization;
using VRage;
using VRage.Audio;
using VRage.GameServices;
using VRage.Network;
using VRage.Serialization;
using VRage.Utils;
using VRage.Voxels;

#nullable disable
namespace Microsoft.Xml.Serialization.GeneratedAssembly
{
  public class XmlSerializerContract : XmlSerializerImplementation
  {
    private Hashtable readMethods = (Hashtable) null;
    private Hashtable writeMethods = (Hashtable) null;
    private Hashtable typedSerializers = (Hashtable) null;

    public override XmlSerializationReader Reader
    {
      get => (XmlSerializationReader) new XmlSerializationReader1();
    }

    public override XmlSerializationWriter Writer
    {
      get => (XmlSerializationWriter) new XmlSerializationWriter1();
    }

    public override Hashtable ReadMethods
    {
      get
      {
        if (this.readMethods == null)
        {
          Hashtable hashtable = new Hashtable();
          hashtable[(object) "VRage.DistantSound::"] = (object) "Read88_DistantSound";
          hashtable[(object) "VRage.MyAudioWave::"] = (object) "Read89_Wave";
          hashtable[(object) "VRage.MyDeltaTransform::"] = (object) "Read90_MyDeltaTransform";
          hashtable[(object) "VRage.MyOrientation::"] = (object) "Read91_MyOrientation";
          hashtable[(object) "VRage.MyPositionAndOrientation::"] = (object) "Read92_MyPositionAndOrientation";
          hashtable[(object) "VRage.SerializableBoundingBoxD::"] = (object) "Read93_SerializableBoundingBoxD";
          hashtable[(object) "VRage.SerializableBounds::"] = (object) "Read94_SerializableBounds";
          hashtable[(object) "VRage.SerializableOrientedBoundingBoxD::"] = (object) "Read95_Item";
          hashtable[(object) "VRage.SerializableQuaternion::"] = (object) "Read96_SerializableQuaternion";
          hashtable[(object) "VRage.SerializableVector2::"] = (object) "Read97_SerializableVector2";
          hashtable[(object) "VRage.SerializableVector2I::"] = (object) "Read98_SerializableVector2I";
          hashtable[(object) "VRage.SerializableVector3::"] = (object) "Read99_SerializableVector3";
          hashtable[(object) "VRage.SerializableVector3D::"] = (object) "Read100_SerializableVector3D";
          hashtable[(object) "VRage.SerializableVector3I::"] = (object) "Read101_SerializableVector3I";
          hashtable[(object) "VRage.SerializableVector3UByte::"] = (object) "Read102_SerializableVector3UByte";
          hashtable[(object) "VRage.Voxels.MyStorageData::"] = (object) "Read103_MyStorageData";
          hashtable[(object) "VRage.Utils.MyStringHash::"] = (object) "Read104_MyStringHash";
          hashtable[(object) "VRage.Serialization.SerializableBoundingSphereD::"] = (object) "Read105_SerializableBoundingSphereD";
          hashtable[(object) "VRage.Network.EndpointId::"] = (object) "Read106_EndpointId";
          hashtable[(object) "VRage.Network.JoinResultMsg::"] = (object) "Read107_JoinResultMsg";
          hashtable[(object) "VRage.Network.ServerDataMsg::"] = (object) "Read108_ServerDataMsg";
          hashtable[(object) "VRage.Network.BlockList::"] = (object) "Read109_BlockList";
          hashtable[(object) "VRage.Network.ChatMsg::"] = (object) "Read110_ChatMsg";
          hashtable[(object) "VRage.Network.ConnectedClientDataMsg::"] = (object) "Read111_ConnectedClientDataMsg";
          hashtable[(object) "VRage.Network.ClientReadyDataMsg::"] = (object) "Read112_ClientReadyDataMsg";
          hashtable[(object) "VRage.GameServices.ChatMessageCustomData::"] = (object) "Read113_ChatMessageCustomData";
          hashtable[(object) "VRage.GameServices.MyGameInventoryItem::"] = (object) "Read114_MyGameInventoryItem";
          hashtable[(object) "VRage.GameServices.MyGameInventoryItemDefinition::"] = (object) "Read115_MyGameInventoryItemDefinition";
          hashtable[(object) "VRage.GameServices.ModMetadataFile::ModMetadata:True:"] = (object) "Read116_ModMetadata";
          hashtable[(object) "VRage.Audio.MyCueId::"] = (object) "Read117_MyCueId";
          if (this.readMethods == null)
            this.readMethods = hashtable;
        }
        return this.readMethods;
      }
    }

    public override Hashtable WriteMethods
    {
      get
      {
        if (this.writeMethods == null)
        {
          Hashtable hashtable = new Hashtable();
          hashtable[(object) "VRage.DistantSound::"] = (object) "Write83_DistantSound";
          hashtable[(object) "VRage.MyAudioWave::"] = (object) "Write84_Wave";
          hashtable[(object) "VRage.MyDeltaTransform::"] = (object) "Write85_MyDeltaTransform";
          hashtable[(object) "VRage.MyOrientation::"] = (object) "Write86_MyOrientation";
          hashtable[(object) "VRage.MyPositionAndOrientation::"] = (object) "Write87_MyPositionAndOrientation";
          hashtable[(object) "VRage.SerializableBoundingBoxD::"] = (object) "Write88_SerializableBoundingBoxD";
          hashtable[(object) "VRage.SerializableBounds::"] = (object) "Write89_SerializableBounds";
          hashtable[(object) "VRage.SerializableOrientedBoundingBoxD::"] = (object) "Write90_Item";
          hashtable[(object) "VRage.SerializableQuaternion::"] = (object) "Write91_SerializableQuaternion";
          hashtable[(object) "VRage.SerializableVector2::"] = (object) "Write92_SerializableVector2";
          hashtable[(object) "VRage.SerializableVector2I::"] = (object) "Write93_SerializableVector2I";
          hashtable[(object) "VRage.SerializableVector3::"] = (object) "Write94_SerializableVector3";
          hashtable[(object) "VRage.SerializableVector3D::"] = (object) "Write95_SerializableVector3D";
          hashtable[(object) "VRage.SerializableVector3I::"] = (object) "Write96_SerializableVector3I";
          hashtable[(object) "VRage.SerializableVector3UByte::"] = (object) "Write97_SerializableVector3UByte";
          hashtable[(object) "VRage.Voxels.MyStorageData::"] = (object) "Write98_MyStorageData";
          hashtable[(object) "VRage.Utils.MyStringHash::"] = (object) "Write99_MyStringHash";
          hashtable[(object) "VRage.Serialization.SerializableBoundingSphereD::"] = (object) "Write100_SerializableBoundingSphereD";
          hashtable[(object) "VRage.Network.EndpointId::"] = (object) "Write101_EndpointId";
          hashtable[(object) "VRage.Network.JoinResultMsg::"] = (object) "Write102_JoinResultMsg";
          hashtable[(object) "VRage.Network.ServerDataMsg::"] = (object) "Write103_ServerDataMsg";
          hashtable[(object) "VRage.Network.BlockList::"] = (object) "Write104_BlockList";
          hashtable[(object) "VRage.Network.ChatMsg::"] = (object) "Write105_ChatMsg";
          hashtable[(object) "VRage.Network.ConnectedClientDataMsg::"] = (object) "Write106_ConnectedClientDataMsg";
          hashtable[(object) "VRage.Network.ClientReadyDataMsg::"] = (object) "Write107_ClientReadyDataMsg";
          hashtable[(object) "VRage.GameServices.ChatMessageCustomData::"] = (object) "Write108_ChatMessageCustomData";
          hashtable[(object) "VRage.GameServices.MyGameInventoryItem::"] = (object) "Write109_MyGameInventoryItem";
          hashtable[(object) "VRage.GameServices.MyGameInventoryItemDefinition::"] = (object) "Write110_MyGameInventoryItemDefinition";
          hashtable[(object) "VRage.GameServices.ModMetadataFile::ModMetadata:True:"] = (object) "Write111_ModMetadata";
          hashtable[(object) "VRage.Audio.MyCueId::"] = (object) "Write112_MyCueId";
          if (this.writeMethods == null)
            this.writeMethods = hashtable;
        }
        return this.writeMethods;
      }
    }

    public override Hashtable TypedSerializers
    {
      get
      {
        if (this.typedSerializers == null)
        {
          Hashtable hashtable = new Hashtable();
          hashtable.Add((object) "VRage.GameServices.ModMetadataFile::ModMetadata:True:", (object) new ModMetadataFileSerializer());
          hashtable.Add((object) "VRage.Voxels.MyStorageData::", (object) new MyStorageDataSerializer());
          hashtable.Add((object) "VRage.SerializableBounds::", (object) new SerializableBoundsSerializer());
          hashtable.Add((object) "VRage.Network.BlockList::", (object) new BlockListSerializer());
          hashtable.Add((object) "VRage.SerializableVector2I::", (object) new SerializableVector2ISerializer());
          hashtable.Add((object) "VRage.Audio.MyCueId::", (object) new MyCueIdSerializer());
          hashtable.Add((object) "VRage.SerializableBoundingBoxD::", (object) new SerializableBoundingBoxDSerializer());
          hashtable.Add((object) "VRage.SerializableQuaternion::", (object) new SerializableQuaternionSerializer());
          hashtable.Add((object) "VRage.SerializableVector3UByte::", (object) new SerializableVector3UByteSerializer());
          hashtable.Add((object) "VRage.Network.ClientReadyDataMsg::", (object) new ClientReadyDataMsgSerializer());
          hashtable.Add((object) "VRage.Serialization.SerializableBoundingSphereD::", (object) new SerializableBoundingSphereDSerializer());
          hashtable.Add((object) "VRage.Utils.MyStringHash::", (object) new MyStringHashSerializer());
          hashtable.Add((object) "VRage.MyPositionAndOrientation::", (object) new MyPositionAndOrientationSerializer());
          hashtable.Add((object) "VRage.GameServices.MyGameInventoryItemDefinition::", (object) new MyGameInventoryItemDefinitionSerializer());
          hashtable.Add((object) "VRage.Network.ConnectedClientDataMsg::", (object) new ConnectedClientDataMsgSerializer());
          hashtable.Add((object) "VRage.Network.EndpointId::", (object) new EndpointIdSerializer());
          hashtable.Add((object) "VRage.GameServices.MyGameInventoryItem::", (object) new MyGameInventoryItemSerializer());
          hashtable.Add((object) "VRage.MyDeltaTransform::", (object) new MyDeltaTransformSerializer());
          hashtable.Add((object) "VRage.Network.ServerDataMsg::", (object) new ServerDataMsgSerializer());
          hashtable.Add((object) "VRage.Network.JoinResultMsg::", (object) new JoinResultMsgSerializer());
          hashtable.Add((object) "VRage.MyAudioWave::", (object) new MyAudioWaveSerializer());
          hashtable.Add((object) "VRage.SerializableVector3::", (object) new SerializableVector3Serializer());
          hashtable.Add((object) "VRage.MyOrientation::", (object) new MyOrientationSerializer());
          hashtable.Add((object) "VRage.SerializableOrientedBoundingBoxD::", (object) new SerializableOrientedBoundingBoxDSerializer());
          hashtable.Add((object) "VRage.Network.ChatMsg::", (object) new ChatMsgSerializer());
          hashtable.Add((object) "VRage.SerializableVector3I::", (object) new SerializableVector3ISerializer());
          hashtable.Add((object) "VRage.SerializableVector3D::", (object) new SerializableVector3DSerializer());
          hashtable.Add((object) "VRage.SerializableVector2::", (object) new SerializableVector2Serializer());
          hashtable.Add((object) "VRage.GameServices.ChatMessageCustomData::", (object) new ChatMessageCustomDataSerializer());
          hashtable.Add((object) "VRage.DistantSound::", (object) new DistantSoundSerializer());
          if (this.typedSerializers == null)
            this.typedSerializers = hashtable;
        }
        return this.typedSerializers;
      }
    }

    public override bool CanSerialize(Type type)
    {
      return type == typeof (DistantSound) || type == typeof (MyAudioWave) || type == typeof (MyDeltaTransform) || type == typeof (MyOrientation) || type == typeof (MyPositionAndOrientation) || type == typeof (SerializableBoundingBoxD) || type == typeof (SerializableBounds) || type == typeof (SerializableOrientedBoundingBoxD) || type == typeof (SerializableQuaternion) || type == typeof (SerializableVector2) || type == typeof (SerializableVector2I) || type == typeof (SerializableVector3) || type == typeof (SerializableVector3D) || type == typeof (SerializableVector3I) || type == typeof (SerializableVector3UByte) || type == typeof (MyStorageData) || type == typeof (MyStringHash) || type == typeof (SerializableBoundingSphereD) || type == typeof (EndpointId) || type == typeof (JoinResultMsg) || type == typeof (ServerDataMsg) || type == typeof (BlockList) || type == typeof (ChatMsg) || type == typeof (ConnectedClientDataMsg) || type == typeof (ClientReadyDataMsg) || type == typeof (ChatMessageCustomData) || type == typeof (MyGameInventoryItem) || type == typeof (MyGameInventoryItemDefinition) || type == typeof (ModMetadataFile) || type == typeof (MyCueId);
    }

    public override XmlSerializer GetSerializer(Type type)
    {
      if (type == typeof (DistantSound))
        return (XmlSerializer) new DistantSoundSerializer();
      if (type == typeof (MyAudioWave))
        return (XmlSerializer) new MyAudioWaveSerializer();
      if (type == typeof (MyDeltaTransform))
        return (XmlSerializer) new MyDeltaTransformSerializer();
      if (type == typeof (MyOrientation))
        return (XmlSerializer) new MyOrientationSerializer();
      if (type == typeof (MyPositionAndOrientation))
        return (XmlSerializer) new MyPositionAndOrientationSerializer();
      if (type == typeof (SerializableBoundingBoxD))
        return (XmlSerializer) new SerializableBoundingBoxDSerializer();
      if (type == typeof (SerializableBounds))
        return (XmlSerializer) new SerializableBoundsSerializer();
      if (type == typeof (SerializableOrientedBoundingBoxD))
        return (XmlSerializer) new SerializableOrientedBoundingBoxDSerializer();
      if (type == typeof (SerializableQuaternion))
        return (XmlSerializer) new SerializableQuaternionSerializer();
      if (type == typeof (SerializableVector2))
        return (XmlSerializer) new SerializableVector2Serializer();
      if (type == typeof (SerializableVector2I))
        return (XmlSerializer) new SerializableVector2ISerializer();
      if (type == typeof (SerializableVector3))
        return (XmlSerializer) new SerializableVector3Serializer();
      if (type == typeof (SerializableVector3D))
        return (XmlSerializer) new SerializableVector3DSerializer();
      if (type == typeof (SerializableVector3I))
        return (XmlSerializer) new SerializableVector3ISerializer();
      if (type == typeof (SerializableVector3UByte))
        return (XmlSerializer) new SerializableVector3UByteSerializer();
      if (type == typeof (MyStorageData))
        return (XmlSerializer) new MyStorageDataSerializer();
      if (type == typeof (MyStringHash))
        return (XmlSerializer) new MyStringHashSerializer();
      if (type == typeof (SerializableBoundingSphereD))
        return (XmlSerializer) new SerializableBoundingSphereDSerializer();
      if (type == typeof (EndpointId))
        return (XmlSerializer) new EndpointIdSerializer();
      if (type == typeof (JoinResultMsg))
        return (XmlSerializer) new JoinResultMsgSerializer();
      if (type == typeof (ServerDataMsg))
        return (XmlSerializer) new ServerDataMsgSerializer();
      if (type == typeof (BlockList))
        return (XmlSerializer) new BlockListSerializer();
      if (type == typeof (ChatMsg))
        return (XmlSerializer) new ChatMsgSerializer();
      if (type == typeof (ConnectedClientDataMsg))
        return (XmlSerializer) new ConnectedClientDataMsgSerializer();
      if (type == typeof (ClientReadyDataMsg))
        return (XmlSerializer) new ClientReadyDataMsgSerializer();
      if (type == typeof (ChatMessageCustomData))
        return (XmlSerializer) new ChatMessageCustomDataSerializer();
      if (type == typeof (MyGameInventoryItem))
        return (XmlSerializer) new MyGameInventoryItemSerializer();
      if (type == typeof (MyGameInventoryItemDefinition))
        return (XmlSerializer) new MyGameInventoryItemDefinitionSerializer();
      if (type == typeof (ModMetadataFile))
        return (XmlSerializer) new ModMetadataFileSerializer();
      return type == typeof (MyCueId) ? (XmlSerializer) new MyCueIdSerializer() : (XmlSerializer) null;
    }
  }
}
