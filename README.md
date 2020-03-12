# NeqSim NET
NeqSim .NET is part of the [NeqSim project](https://equinor.github.io/neqsimhome/). NeqSimNET is a .NET interface to the [NeqSim Java library](https://github.com/equinor/neqsim) for estimation of fluid behavior and process design for oil and gas production.

# Documentation
See https://github.com/equinor/neqsim. NeqSim can be used via .Net using the same API as via Java. NeqSim is used in .NET by referencing the [NeqSim.dll]() library and the [IKVM libraries](). [IKVM](https://www.ikvm.net/) has been used to convert the [NeqSim Java library](https://github.com/equinor/neqsim) to a .NET dll using the ikmc compiler (ikvmc -target:library -out:"NeqSim.dll" NeqSim.jar).
