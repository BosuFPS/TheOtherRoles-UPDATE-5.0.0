# TOR 5.0.0

The Other Roles is a role mod for Among Us.

This repository contains the GPL source files for this TOR 5.0.0 build. It does not include Among Us game files, BepInEx runtime files, Unity libraries, dotnet runtime files, or other third-party binaries.

All changes in this repository are distributed under the GPLv3, the same license used by the original The Other Roles source this build is based on.

## Installation

Build the project from source and install the resulting plugin into a compatible BepInEx IL2CPP setup for Among Us.

You need your own legal copy of Among Us and the required mod loader files from their original sources.

## Included

- Source code
- Embedded resources used by the mod
- Project files
- GPL license

## Role changes

### Snitch

Snitch was changed to reveal information earlier, but in a softer way:

- At 50% finished tasks, Snitch gets info about a killing role.
- Sheriff is excluded from this info.
- At 75% finished tasks, Snitch gets one-time armor.
- The armor blocks one kill attempt and then breaks.

### Roles

**Sleepwalker**

Crewmate role. After meetings, the player wakes up in a random room.

**Locksmith**

Crewmate role. Can open locked doors instantly with limited uses.

**Archivist**

Crewmate role. Keeps short meeting history information, for example who died since the last meeting and how many kills happened.

**Leech**

Neutral role. Gets a host and wins if that host wins.

**Collector**

Neutral role. Gets a random target from Impostor, Jackal, or Sidekick at game start. Collector wins if that target dies by someone else.

## Notes

- The project targets Among Us `2024.10.29`.
- Built against BepInEx IL2CPP `6.0.0-be.697`.
- Based on the GPL-licensed The Other Roles source.

## Disclaimer

This mod is not affiliated with Among Us or Innersloth LLC. Among Us and related assets belong to Innersloth LLC.
