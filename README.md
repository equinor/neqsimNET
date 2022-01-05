# NeqSim NET
NeqSim .NET is part of the [NeqSim project](https://equinor.github.io/neqsimhome/). NeqSimNET is a .NET interface to the [NeqSim Java library](https://github.com/equinor/neqsim) for estimation of fluid behavior and process design for oil and gas production.

# Documentation
See https://github.com/equinor/neqsim. NeqSim can be used via .Net using the same API as via Java. NeqSim is used in .NET by referencing the [NeqSim.dll](https://github.com/equinor/neqsimNET/tree/master/lib) library and the [IKVM libraries](https://github.com/equinor/neqsimNET/tree/master/ikvm-bin). The [IKVM tool](https://www.ikvm.net/) has been used to convert the [NeqSim Java library](https://github.com/equinor/neqsim) to a .NET dll using the ikmc compiler (ikvmc -target:library -out:"NeqSim.dll" NeqSim.jar).

Examples of how to use NeqSim.NET is seen in the [example folder](https://github.com/equinor/neqsimNET/tree/master/examples).

## Discussion forum
Questions related to neqsim can be posted in the [github discussion pages](https://github.com/equinor/neqsim/discussions).

## Authors and contact persons
Even Solbraa (esolbraa@gmail.com),  Marlene Louise Lund

## Licence
NeqSim is distributed under the [Apache-2.0](https://github.com/equinor/neqsimsource/blob/master/LICENSE) licence.

## Acknowledgments
A number of master and PhD students at NTNU have contributed to development of NeqSim. We greatly acknowledge their contributions.

## NeqSim modules
NeqSim is built upon six base modules:
1. Thermodynamic Routines
2. Physical Properties Routines
3. Fluid Mechanic Routines
4. Unit Operations
5. Chemical Reactions Routines
6. Parameter Fitting Routines
7. Process simulation routines


## File System
>neqsim/: main library with all modules 
>
>neqsim/thermo/: Main path for thermodynamic routines
>neqsim/thermo/util/examples/: examples of use of Thermodynamic Models and Routines
>
>neqsim/thermodynamicOperation: Main path for flash routines (TPflash, phase envelopes, etc.)
>neqsim/thermodynamicOperation/util/example/: examples of use of thermodynamic operations (eg. flash calculations etc.)
>
>neqsim/physicalProperties: Main path for Physical Property methods
>neqsim/physicalProperties/util/examples/: Examples of use of physical properties calculations
>
>neqsim/physicalProperties: Main path for Physical Property methods
>neqsim/physicalProperties/util/examples/: Examples of use of physical properties calculations
>
>neqsim/processSimulation: Main path for Process Simulation Calculations
>neqsim/processSimulation/util/examples/: Examples of use of Process Simulation calculations

