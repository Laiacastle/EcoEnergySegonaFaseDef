# Casos de prova

## Calc energia

### Classes d'equivalencia

Value
- nombres positius
- nombres negatius
- nombre decimals

Rati
- nombres positius
- nombres negatius
- nombre decimals

Type
- solar, eolica, hidroelectrica
- altres textes

## Valors Limits

Value
- 0
- 1
- -1
- 2.2

Rati
- 0
- 1
- -1
- 2.2

Type
- Solar, Eolica, Hidroelectrica
- other

## Jocs de prova

| nom | que fa | input | resultat esperat | resultat obtingut |
-------------------------------------------------------------
| CalcEnergiaSolarValueNega | calcula l'energia depenen del tipus | Value: -1, Rati: 1, Type: "Solar" | -1 | - |
------------------------------------------------------------------------
| CalcEnergiaSolarRatiNega | calcula l'energia depenen del tipus | Value: 1, Rati: -1, Type: "Solar" | -1 | - |
-------------------------------------------------------------------
| CalcEnergiaSolarValueDecimal | calcula l'energia depenen del tipus | Value: 2.2, Rati: 1, Type: "Solar" | 2.2 | - |
---------------------------------------------------------------------
| CalcEnergiaEolicaValueNega | calcula l'energia depenen del tipus | Value: -1, Rati: 1, Type: "Eolica" | -1 | - |
-----------------------------------------------------------------------
| CalcEnergiaEolicaRatiNega | calcula l'energia depenen del tipus | Value: 1, Rati: -1, Type: "Eolica" | -1 | - |
------------------------------------------------------------------------
| CalcEnergiaEolicaValueDecimal | calcula l'energia depenen del tipus | Value: 2.2, Rati: 1, Type: "Eolica" | 2.2 | - |
----------------------------------------------------------------
| CalcEnergiaHidroelectricaValueNega | calcula l'energia depenen del tipus | Value: -1, Rati: 1, Type: "Hidroelectrica" | -9.8 | - |
---------------------------------------------------------------------------
| CalcEnergiaHidroelectricaRatiNega | calcula l'energia depenen del tipus | Value: 1, Rati: -1, Type: "Hidroelectrica" | -9.8 | - |
----------------------------------------------------------------------------
| CalcEnergiaHidroelectricaValueDecimal | calcula l'energia depenen del tipus | Value: 2.2, Rati: 1, Type: "Hidroelectrica" | 21.56 | - |
-----------------------------------------------------------------------------------
| CalcEnergiaOthers | calcula l'energia depenen del tipus | Value: 1, Rati: 1, Type: "other" | -1 | - |
----------------


## ConfParametres

### Classes d'equivalencia

Solar
- nombres positius
- nombres negatius
- 0

Eolica
- nombres positius
- nombres negatius
- 0

Hidroelectrica
- nombres positius
- nombres negatius
- 0

## Valors Limits

Solar
- 0
- 1
- 2

Eolica
- 5
- 6
- 4

Hidroelectrica
- 20
- 21
- 19

## Jocs de prova

| nom | que fa | input | resultat esperat | resultat obtingut |
-------------------------------------------------------------
| ConfParametreSolarU | mira que el numero estigui en el rang | 1 | true | - |
----------------
| ConfParametreSolarCero |mira que el numero estigui en el rang | 0 | false | - |
----------------
| ConfParametreSolarDos | mira que el numero estigui en el rang | 2 | true | - |
---------------
| ConfParametreEolicaCinc | mira que el numero estigui en el rang | 5 | true | - |
---------------
| ConfParametreEolicaSis | mira que el numero estigui en el rang | 6 | true | - |
-----------------
| ConfParametreEolicaQuatre | mira que el numero estigui en el rang | 4 | false | - |
------------------
| ConfParametreHidroelectricaVint | mira que el numero estigui en el rang | 20| true | - |
------------------
| ConfParametreHidroelectricaVintiU | mira que el numero estigui en el rang | 21 | true | - |
------------------
| ConfParametreHidroelectricaDiNou | mira que el numero estigui en el rang | 19 | false | - |
------------------
