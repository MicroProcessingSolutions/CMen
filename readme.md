# CMen
C Menager for building C/C++ apps, C/C++ libraries and C/C++ HIL (Hardware-Independent Layer) code for native and embedded platforms.
## Why CMen?
I was tired of using C/C++ project builders. They were not integrated with the project - you had to write, for example, your own Makefile.

CMen has a goal: **Make C Great Again!**.
C/C++ is very commonly used in embedded programming - this languages are powerful, but tools for them... I'm very dissapointed.
CMen is not like Makefile - you don't have to write Makefile to compile project. The only thing you have to do is to type that you demand new file/class/whatever in project:

*cmen class new example*

And now you can choose your favourite editor/IDE and edit header, source and test files!

CMen will be also base for upcoming lightweight C/C++ IDE for embedded devices (around 2070 - stay calm!).

## CMen features (in future) (maybe) (that depends on money I'll earn)
* Lightweight
* Can be used as a base for custom IDE
* Easy console commands
* Configure CMen to deploy your HIL code into ~~bad and confusing~~ IDE's like IAR, Eclipse, MPLab X
* Integrated with Catch unit testing framework
* Written in programmer friendly C# language