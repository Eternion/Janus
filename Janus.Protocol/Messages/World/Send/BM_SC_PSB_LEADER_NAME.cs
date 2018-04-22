﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Janus.Core.IO;
using Janus.Protocol.Enums;

namespace Janus.Protocol.Messages.World.Send
{
    public class BM_SC_PSB_LEADER_NAME : NetworkMessage
    {
        public const ushort Id = 2184;

        public string leaderName;

        public BM_SC_PSB_LEADER_NAME()
        {
        }

        public BM_SC_PSB_LEADER_NAME(string leaderName)
        {
            this.leaderName = leaderName;
        }

        public override ushort MessageId => Id;

        public override ServerEnum[] ServerEnum => new Enums.ServerEnum[] { Enums.ServerEnum.WorldServer };

        public override void Deserialize(IDataReader reader)
        {
            throw NetworkMessageException.DeserializeException;
        }

        public override void Serialize(IDataWriter writer)
        {
            writer.WriteUTFBytes(leaderName, 40);
        }
    }
}
