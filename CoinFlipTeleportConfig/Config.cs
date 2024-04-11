// Decompiled with JetBrains decompiler
// Type: CoinFlipTeleportConfig.Config
// Assembly: NoTrollBombs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 4BA9A07F-8B24-4BFD-8319-697D1130D3F4
// Assembly location: C:\Users\user\Downloads\NoTrollBombs.dll

using Exiled.API.Enums;
using Exiled.API.Interfaces;
using System.Collections.Generic;

namespace CoinFlipTeleportConfig
{
  public class Config : IConfig
  {
    public bool IsEnabled { get; set; } = true;

    public bool Debug { get; set; } = false;

    public List<RoomType> RoomsToTeleport { get; set; } = new List<RoomType>()
    {
      (RoomType) 41,
      (RoomType) 50,
      (RoomType) 39,
      (RoomType) 37,
      (RoomType) 35,
      (RoomType) 34,
      (RoomType) 33,
      (RoomType) 43,
      (RoomType) 32,
      (RoomType) 36,
      (RoomType) 40,
      (RoomType) 48,
      (RoomType) 42,
      (RoomType) 31,
      (RoomType) 22,
      (RoomType) 16,
      (RoomType) 30,
      (RoomType) 24,
      (RoomType) 20,
      (RoomType) 19,
      (RoomType) 23,
      (RoomType) 29,
      (RoomType) 52,
      (RoomType) 53,
      (RoomType) 17,
      (RoomType) 18,
      (RoomType) 21,
      (RoomType) 25,
      (RoomType) 27,
      (RoomType) 47,
      (RoomType) 28,
      (RoomType) 26,
      (RoomType) 51,
      (RoomType) 11,
      (RoomType) 49,
      (RoomType) 4,
      (RoomType) 10,
      (RoomType) 1,
      (RoomType) 7,
      (RoomType) 15,
      (RoomType) 13,
      (RoomType) 12,
      (RoomType) 5,
      (RoomType) 2,
      (RoomType) 14,
      (RoomType) 8,
      (RoomType) 3,
      (RoomType) 6,
      (RoomType) 9,
      (RoomType) 46
    };
  }
}
