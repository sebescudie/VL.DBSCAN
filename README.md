# VL.DBSCAN

[![Nuget](https://img.shields.io/nuget/v/VL.DBSCAN?style=flat-square)](https://www.nuget.org/packages/VL.DBSCAN)

_A simple implementation of [viceroypenguin's DBSCAN .NET lib](https://github.com/viceroypenguin/DBSCAN) in VVVV Gamma._

## Usage

Go to gamma's quad menu/manage nugets/command-line and type

```
nuget install VL.DBSCAN
```
Open the help browser (<kbd>F1</kbd>) and look for DBSCAN, you'll find a simple help patch showing how to cluster points.

## Notes

- The plugin uses `DBSCAN.Utils.dll` which just implements `IPointData` (required by the original lib) and allows to use VL's Vector2. This part had to be done in Visual Studio since `IPointData` uses the `ref` keyword that's not available in VL.
