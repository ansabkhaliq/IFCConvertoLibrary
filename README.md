# IFCConvertoLibrary
## Table of Contents
1. [Project Description](#Project-Description)
2. [Features](#Features)
3. [System Requirements](#System-Requirements)
4. [Technologies Used](#Technologies-Used)
5. [Setup Guide](#Setup-Guide)
6. [Release Histroy](#Release-History)
7. [Attribution](#Attribution)

## Project Description
This repository contain a library project that is consumed by the [Dekstop Utility](https://github.com/ansabkhaliq/IFCConverto). This library project basically uses a [IfcOpenShell](http://ifcopenshell.org/ifcconvert) .exe file and packs it in to a .dll file which can then be added as a dependency in other projects. 

The library project is configured such that, you can use it to generate 32bit dll or 64bit dll, depending on your requirements and usecase. 

The version of the current .exe file is 0.6.0. 

## Features
* Takes a .exe file to and packs it in to the .dll
* Can be used to generate the 32bit or 64bit dll
* The .exe files can be replaced with newer version to generate .dll files for newer version of CLI exe
* The .dll file produced by this library project can be used in other projects to convert IFC files in to following formats: .obj, .dae, .stp, .igs, .xml, .svg, .glb

## System Requirements
* Visual Studio 2019
* .Net Standard 2.0

## Technologies Used
* C#

## Setup Guide
* Clone the project from the repository
* Open the IFCConvertoLibrary.sln file using Visual Studio 2019
* Right click the solution in the solution explorer window and click clean
* Choose the Solution Platform (either x64 or x86) from the top menu and right click the solution file to choose build option
* Depending on the Solution Platform chosen you will find appropriate Release folder (Release64 or Release86) in the bin folder which will contain the dll file

## Release History
### Sprint 2
* 1.0.0 - Initial Release. Done as part of userstory *ID: 4; Name: Converting IFC files in to the 3D Model* in project [IFC Converto](https://github.com/ansabkhaliq/IFCConverto) on [branch](https://github.com/ansabkhaliq/IFCConverto/tree/ConvertIFCFileTo3DModels%26ProcessTextfiles)

## Attribution
Created by SQ-Wombat
