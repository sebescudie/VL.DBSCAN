# VL.DBSCAN

_A simple implementation of [viceroypenguin's DBSCAN .NET lib](https://github.com/viceroypenguin/DBSCAN) in VVVV Gamma._

## Usage

Go to gamma's command line and type

> nuget install VL.DBSCAN

Tested with vvvv-gamma preview 624. Strike F1 to open the help browser and look for the _How to track clusters of points_ example.

## Notes

- The library uses Xenko.Core.Mathematics, which is only available on vvvv gamma preview > 624. If you use an earlier version, specify version 1.1.1 in the nuget installer, like so :  `nuget install VL.DBSCAN -version 1.1.1`
- The plugin uses `DBSCAN.Utils.dll` which just implements `IPointData` (required by the original lib) and allows to use VL's Vector2. This part had to be done in Visual Studio since `IPointData` uses the `ref` keyword that's not available in VL.