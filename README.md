# EcoEnergy Solutions Segona Fase

# Link document

https://docs.google.com/document/d/1tYSzCPyqMxCKeKUwUl7GBjLZ8LBgJEZ-ZJritEIiO7A/edit?usp=sharing

# Solució del sistema

__Solució proposada__

Per cada página he creat dos arxius cshtml amb el .cs corresponent.
per el cambi de tipus a la part de simulacions he creat una clase nova anomenada 'Simulacio' que accepta tots el valors d'una simulació normal però no n'especifica el tipus obligatoriament.
He utilitzat un select a la part del formulari per indicar-ne el tipus en un string.
Per la part de consums d'aigua i indicadors energetics he posat un selector per que l'usuari pugui escollir que dades vol visualitzar.
A la part d'indicadors energetics només es mostra les dades principal de la clase i les altres dades es posen per defecte en 0.

__CSS__

A la part de css he utilitzat un estil tipus futurista amb blaus i verds, he posat els botons d'afegir simulació/consum/indicador amb un destell verdós i la capceleza amb un afecta que cambia de color quan es pasa el mouse por sobre.
Les tabnles tenen la capzalera verda y he centrat tot el contigut per que quedi mes boniquet.

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
|-------|--------|----------|-------------|-----------------------|
| CalcEnergiaSolarValueNega | calcula l'energia depenen del tipus | Value: -1, Rati: 1, Type: "Solar" | -1 | -1 |
| CalcEnergiaSolarRatiNega | calcula l'energia depenen del tipus | Value: 1, Rati: -1, Type: "Solar" | -1 | -1 |
| CalcEnergiaSolarValueDecimal | calcula l'energia depenen del tipus | Value: 2.2, Rati: 1, Type: "Solar" | 2.2 | 2.2 |
| CalcEnergiaEolicaValueNega | calcula l'energia depenen del tipus | Value: -1, Rati: 1, Type: "Eolica" | -1 | -1 |
| CalcEnergiaEolicaRatiNega | calcula l'energia depenen del tipus | Value: 1, Rati: -1, Type: "Eolica" | -1 | -1 |
| CalcEnergiaEolicaValueDecimal | calcula l'energia depenen del tipus | Value: 2.2, Rati: 1, Type: "Eolica" | 10.648 | 10.648000000000003 |
| CalcEnergiaHidroelectricaValueNega | calcula l'energia depenen del tipus | Value: -1, Rati: 1, Type: "Hidroelectrica" | -9.8 | -9.8 |
| CalcEnergiaHidroelectricaRatiNega | calcula l'energia depenen del tipus | Value: 1, Rati: -1, Type: "Hidroelectrica" | -9.8 | -9.8 |
| CalcEnergiaHidroelectricaValueDecimal | calcula l'energia depenen del tipus | Value: 2.2, Rati: 1, Type: "Hidroelectrica" | 21.56 | 21.560000000001 |
| CalcEnergiaOthers | calcula l'energia depenen del tipus | Value: 1, Rati: 1, Type: "other" | -1 | -1 |

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
|-------|-------|-------|-------------------|---------------------|
| ConfParametreSolarU | mira que el numero estigui en el rang | 1 | true | - |
| ConfParametreSolarCero |mira que el numero estigui en el rang | 0 | false | - |
| ConfParametreSolarDos | mira que el numero estigui en el rang | 2 | true | - |
| ConfParametreEolicaCinc | mira que el numero estigui en el rang | 5 | true | - |
| ConfParametreEolicaSis | mira que el numero estigui en el rang | 6 | true | - |
| ConfParametreEolicaQuatre | mira que el numero estigui en el rang | 4 | false | - |
| ConfParametreHidroelectricaVint | mira que el numero estigui en el rang | 20| true | - |
| ConfParametreHidroelectricaVintiU | mira que el numero estigui en el rang | 21 | true | - |
| ConfParametreHidroelectricaDiNou | mira que el numero estigui en el rang | 19 | false | - |
