﻿using System;
using TrueCraft.API.World;
using TrueCraft.API.Networking;
using TrueCraft.API.Server;

namespace TrueCraft.API.Logic
{
    public interface IBlockProvider
    {
        byte ID { get; }
        double BlastResistance { get; }
        double Hardness { get; }
        byte Luminance { get; }
        bool Opaque { get; }
        byte LightModifier { get; }
        string DisplayName { get; }
        Tuple<int, int> GetTextureMap(byte metadata);
        bool BlockRightClicked(BlockDescriptor descriptor, BlockFace face, IWorld world, IRemoteClient user);
        void BlockPlaced(BlockDescriptor descriptor, BlockFace face, IWorld world, IRemoteClient user);
        void BlockMined(BlockDescriptor descriptor, BlockFace face, IWorld world, IRemoteClient user);
        void BlockUpdate(BlockDescriptor descriptor, IMultiplayerServer server, IWorld world);
        void BlockScheduledEvent(BlockDescriptor descriptor, IWorld world, object data);
    }
}