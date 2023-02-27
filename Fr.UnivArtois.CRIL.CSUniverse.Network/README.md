# UNIvERSE - mUlti laNguage unIfied intErface foR conStraint solvErs

## Description
 
`CSUuniverse` is a `C#` version of [UNIVERSE](https://github.com/crillab/universe) library and proposes generic interfaces for combinatorial problems solvers. 

- [SAT Solver](src/main/java/fr/univartois/cril/juniverse/sat/IUniverseSatSolver.java)
- [PB Solver](src/main/java/fr/univartois/cril/juniverse/pb/IUniversePseudoBooleanSolver.java)
- [XCSP Solver](src/main/java/fr/univartois/cril/juniverse/csp/IUniverseCSPSolver.java) 

These interfaces are described in the following diagrams :

![Solvers Interface](./doc/figures/solverinterfaces.png)

`Universe` offers an interface for create Solver. This interface follows the factory design pattern and is described
in the following diagrams: 

![factory](./doc/figures/factory.png)