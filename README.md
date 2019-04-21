# VL.DBSCAN

_A simple implementation of [viceroypenguin's DBSCAN .NET lib](https://github.com/viceroypenguin/DBSCAN)._

## Usage

Go to VL's command line and type

> nuget install VL.DBSCAN

Testes with vvvv-gamma 222

## Notes

The plugin uses `DBSCAN.Utils.dll` which just implements `IPointData` (required by the original lib) and allows to use VL's Vector2. This part had to be done in Visual Studio since `IPointData` uses the `ref` keyword that's not available in VL.
