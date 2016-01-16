using System;

namespace Game
{
  [Flags]
  enum GameEvent
  {
    None = 0x0,

    Update = 1<<0,
    Stop = 1<<1,

    ShipForward = 1<<2,
    ShipBackward = 1<<3,
    ShipTurnLeft = 1<<4,
    ShipTurnRight = 1<<5,

    ZoomIn = 1<<6,
    ZoomOut = 1<<7,
    SpeedUp = 1<<8,

    ShipStrafeLeft = 1<<9,
    ShipStrafeRight = 1<<10,

    Reset = 1<<11,

    MoveSceneUp = 1<<12,
    MoveSceneDown = 1<<13,
    MoveSceneLeft = 1<<14,
    MoveSceneRight = 1<<15,
    RotateSceneLeft = 1<<16,
    RotateSceneRight = 1<<17,

    ShiftPressed = 1<<18,

    AddStar = 1<<19,

    DeltaDec = 1<<20,
    DeltaInc = 1<<21,
  }
}