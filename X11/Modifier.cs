using System;

namespace X11
{
  [Flags]
  public enum Modifier
  {
    ShiftMask = 1,
    LockMask = 2,
    ControlMask = 4,
    Mod1Mask = 8,
    Mod2Mask = 16,
    Mod3Mask = 32,
    Mod4Mask = 64,
    Mod5Mask = 128,
    Button1Mask = 256,
    Button2Mask = 512,
    Button3Mask = 1024,
    Button4Mask = 2048,
    Button5Mask = 4096,
    SuperMask = 67108864,
    HyperMask = 134217728,
    MetaMask = 268435456,
    ReleaseMask = 1073741824,
    ModifierMask = 1073750015,
    None = 0
  }
}