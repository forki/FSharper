FSharper
========
This project is an attempt to build a plug-in to support the F# programming language in ReSharper.

Broadly speaking, its goals are to:

* Provide ReSharper with a PSI (lexer+parser+inference engine)
* Provide integration with existing R# features (e.g., navigation, search, etc.)
* Provide OOP-related as well as FP-related services (e.g., type inferencing helpers)

Status
======
At the moment, we are working towards the 0.1 release, which aims to have a fully (or maybe 95%) compliant lexer covered with tests. What we need is:

* To correctly define known F# constructs in the `.lex`. file (and also in `Tokens.xml`, but see note in the next section).
* To create a sufficient number of lexer tests to ensure everything works.

A correctly working lexer (plus maybe one lexer-based service, e.g., TODO explorer support) would constitute the 0.1 release ([tentative roadmap](https://github.com/JetBrains/FSharper/wiki/Roadmap)).

Building
========
In order to compile the project, you need the [ReSharper SDK](http://www.jetbrains.com/resharper/download/index.html) and [WiX](http://wix.sourceforge.net/). If you have both of these on the machine, the project should build out of the box.

Please note that, currently, any changes to `Tokens.xml` will need to be processed on our end - this is due to one code generation tool not making it into the SDK (please [vote for it](http://youtrack.jetbrains.com/issue/RSRP-318622)). 

Debugging
=========
 * Set `Plugin` project as StartUp project
 * In the Debug section of the project properties
    * Set the start action to "Start external program" and specify the path to your Visual Studio installation e.g. "C:\Program Files (x86)\Microsoft Visual Studio 11.0\Common7\IDE\devenv.exe".
    * Set the command line arguments to match your debug output directory e.g. "/ReSharper.Internal /ReSharper.Plugin C:\Code\FSharper\bindebug".
 * Press F5 and load a F# project

Contributing
============
Pull requests are most welcome and will be reviewed and integrated as soon as humanly possible. Right now, the bulk of development happens on the `develop` branch, though we may make it more GitFlow-correct in the future.