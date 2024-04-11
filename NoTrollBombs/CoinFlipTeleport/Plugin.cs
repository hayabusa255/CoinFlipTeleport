// Decompiled with JetBrains decompiler
// Type: CoinFlipTeleport.Plugin
// Assembly: NoTrollBombs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 4BA9A07F-8B24-4BFD-8319-697D1130D3F4
// Assembly location: C:\Users\user\Downloads\NoTrollBombs.dll

using CoinFlipTeleportConfig;
using Exiled.API.Enums;
using Exiled.API.Extensions;
using Exiled.API.Features;
using Exiled.API.Features.Items;
using Exiled.Events.EventArgs.Player;
using Exiled.Events.Features;
using InventorySystem.Items.Usables.Scp330;
using System;
using System.Collections.Generic;


#nullable enable
namespace CoinFlipTeleport
{
  public class Plugin : Plugin<Config>
  {
    public readonly Config _Config;

    public virtual Version Version => new Version(4, 5, 0);

    public virtual string Author => "Akinasu333";

    public virtual string Name => "CoinFlipTeleport";

    public virtual void OnEnabled() => Exiled.Events.Handlers.Player.FlippingCoin += new CustomEventHandler<FlippingCoinEventArgs>(this.Flipper);

    public virtual void OnDisabled() => Exiled.Events.Handlers.Player.FlippingCoin += new CustomEventHandler<FlippingCoinEventArgs>(this.Flipper);

    public void Flipper(FlippingCoinEventArgs ev)
    {
      if (ev.Player == null)
        Log.Error("Flipper method received a null player reference.");
      else if (Warhead.IsDetonated)
      {
        Exiled.API.Features.Items.Scp330 scp330 = (Exiled.API.Features.Items.Scp330) Item.Create((ItemType) 42, (Exiled.API.Features.Player) null);
        scp330.AddCandy((CandyKindID) 4);
        ev.Player.AddItem((Item) scp330);
        ev.Item.Destroy();
      }
      else
      {
        ev.Player.Teleport((object) Room.Get(CommonExtensions.GetRandomValue<RoomType>((IEnumerable<RoomType>) this._Config.RoomsToTeleport)));
        ev.Item.Destroy();
      }
    }
  }
}
