# TOR 5.0.0

**edited by BosuFPS**

This mod is not affiliated with Among Us or Innersloth LLC, and the content contained therein is not endorsed or otherwise sponsored by Innersloth LLC. Portions of the materials contained herein are property of Innersloth LLC. © Innersloth LLC.

---

## Install

This repository includes the mod plugin and BepInEx runtime files needed to load it. It does not include Among Us game files.

1. Install Among Us on Steam.
2. Download this repository as ZIP or clone it.
3. Copy `.doorstop_version`, `BepInEx/`, `dotnet/`, `doorstop_config.ini`, `winhttp.dll`, and `steam_appid.txt` into your Among Us game folder, next to `Among Us.exe`.
4. Start `Among Us.exe` once. The first start can take a few minutes while BepInEx generates IL2CPP interop files.
5. If it loaded correctly, `BepInEx/LogOutput.log` contains `Loading [The Other Roles 5.0.0]` and `Loading TOR completed!`.

## Licensing

- The Other Roles code and this mod version are distributed under the GPL license in `LICENSE`.
- BepInEx is included as the only external runtime and is licensed under LGPL-2.1-or-later.
- BepInEx license details are in `THIRD_PARTY_NOTICES.md` and `LICENSES/BepInEx-LGPL-2.1.txt`.
- No Among Us game files are included.

---

## Snitch Rework

- Snitch receives early info on a killing role (excluding Sheriff) after completing **50%** of tasks.
- Snitch gains **armor** after completing **75%** of tasks.
- Armor blocks one kill attempt and breaks afterward.

## New Roles

### Sleepwalker (Crew)
Wakes up in a random room after meetings. Creates alibi and positioning dynamics without a direct kill ability.

### Leech (Neutral)
Receives a host as a target. Wins if the host wins at the end. Must indirectly support the host and stay alive.

### Collector (Neutral)
Auto-assigned a random target among **Impostor / Jackal / Sidekick** at game start. Wins if that target dies — but not by the Collector's own hand. No player choice.

### Locksmith (Crew)
Can open locked doors instantly a limited number of times. Counters sabotage / Impostor door control.

### Archivist (Crew)
After each meeting, automatically saves a short history:
- Who died since the last meeting
- How many kills occurred
- Whether at least one neutral role is still alive

## Changelog v5.0.0

- Snitch: early killing-role info at 50% tasks, armor at 75% tasks, armor breaks on first kill
- Added Sleepwalker, Leech, Collector, Locksmith, Archivist
- Gambler removed
- Collector reworked: auto-assigns random killing-role target at game start
- Optional Role Draft mode for role selection
- Added option for medic to shift the medic shield
- Partial key rebinding
- Various bug fixes and improvements
