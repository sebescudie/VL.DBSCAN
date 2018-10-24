# VL.DBSCAN

_A simple implementation of [viceroypenguin's DBSCAN .NET lib](https://github.com/viceroypenguin/DBSCAN)._

## Usage

- Clone or download the repo
- Open `vs/DBSCAN.sln`. This is just a small class that implements `IPointData` and allows to use VL's Vector2 with the lib
- Build (CTRL+SHIFT+B) and copy the output to `vl/lib`
- Open `root.v4p`, it contains a small VL plugin (`UsesDBSCAN`) that references `VL.DBSCAN` and renders a small demo using Skia

## Notes

- The Visual Studio part is needed since `IPointData` uses the `ref` keyword that's not available in VL
- I'm not quite sure yet how to structure this plugin, any comments are welcome :)