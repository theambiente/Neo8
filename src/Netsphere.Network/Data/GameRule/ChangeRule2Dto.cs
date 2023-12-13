﻿using System;
using BlubLib.Serialization;
using Netsphere.Network.Serializers;

namespace Netsphere.Network.Data.GameRule
{
    [BlubContract]
    public class ChangeRule2Dto
    {
        [BlubMember(0)]
        public Netsphere.GameRule GameRule { get; set; }

        [BlubMember(1)]
        public byte Map { get; set; }

        [BlubMember(2)]
        public byte PlayerLimit { get; set; }

        [BlubMember(3)]
        public ushort ScoreLimit { get; set; }

        [BlubMember(4)]
        public int Unk3 { get; set; }

        [BlubMember(5)]
        [BlubSerializer(typeof(TimeLimitSerializer))]
        public TimeSpan TimeLimit { get; set; }

        [BlubMember(6)]
        public int ItemLimit { get; set; }

        [BlubMember(7)]
        public string Password { get; set; }

        [BlubMember(8)]
        public string Name { get; set; }

        [BlubMember(9)]
        public bool IsSpectatingEnabled { get; set; }

        [BlubMember(10)]
        public byte SpectatorLimit { get; set; }

        [BlubMember(11)]
        public byte Unk7 { get; set; }

        [BlubMember(12)]
        public int Unk8 { get; set; }

        [BlubMember(13)]
        public int Unk9 { get; set; }

        [BlubMember(14)]
        public byte Unk10 { get; set; }

        [BlubMember(15)]
        public RoomRandomSettings RandomSettings { get; set; }

        [BlubMember(16)]
        public RoomSettings Settings { get; set; }

        [BlubMember(17)]
        public int Unk13 { get; set; }

        [BlubMember(18)]
        public byte Unk14 { get; set; }

        public ChangeRule2Dto()
        {
            Name = "";
            Password = "";
            Unk10 = 144;
            Unk14 = 176;
        }
    }
}
