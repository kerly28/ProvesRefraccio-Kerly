### Classes d'Equivalència, Valors Límit i Casos de Prova

### Classes d'equivalència 

``ClassifyAge(int age)`` [0-120]

 - **Infància**: `[0-17]`
   - **Adulta**: `[18-65]`
   - **Senescència**: `[66-120]`
   - **Invàlid**: `[<0, >120]`

``IsEven(int age)`` [Parell-Senar]

`` NameAnalyser(string name)`` [Nom Curt (<5)-Nom Llarg (>5)]

``VerifyColour(string colour)`` [Invàlid(-1), Calmant(0), Exclusiu(1)] 

``PersonalityTest(string preference)`` [Matí-Nit-Qualsevol]

### Valors límits

``1. ClassifyAge(int age)`` [0-120]

- { -1, 0, 119, 120, 121 }

``2. IsEven(int age)`` [Parell-Senar]

- { 0, 1 }

``3. NameAnalyser(string name)`` [Nom Curt (<5)-Nom Llarg (>5)]

- { 5, 6, 4 } lletres

``4. VerifyColour(string colour)`` [Invàlid(-1), Calmant(0), Exclusiu(1)] 

- { blau(0), verd(0), exclusiu(1)}

``5. PersonalityTest(string preference)`` [Matí-Nit-Qualsevol]

- { matí, nit, qualsevol }


### Casos de prova


|Nom| Descripció                                        | Entrades | Accions                                   | Resultat esperat          | Resultat obtingut  |
|---------|--------------------------------------------------------|--------------|------------------------------------------------|----------------------------------|-------------------------|
| 1       | Classifica els rangs permesos                          | -1           | Crida al mètode `ClassifyAge(-1)`               | Invàlid (-1)                | Invàlid                 |
| 1       | Classifica els rangs permesos                          | 0            | Crida al mètode `ClassifyAge(0)`                | Infància (0)                       | Infància                |
| 1       | Classifica els rangs permesos                          | 1            | Crida al mètode `ClassifyAge(1)`                | Infància (0)                     | Infància                |
| 1       | Classifica els rangs permesos                          | 17           | Crida al mètode `ClassifyAge(17)`               | Infància (0)                     | Infància                |
| 1       | Classifica els rangs permesos                          | 18           | Crida al mètode `ClassifyAge(18)`               | Adulta (1)                         | Adulta                  |
| 1       | Classifica els rangs permesos                          | 65           | Crida al mètode `ClassifyAge(65)`               | Adulta (1)                       | Adulta                  |
| 1       | Classifica els rangs permesos                          | 66           | Crida al mètode `ClassifyAge(66)`               | Senescència (2)                     | Senescència             |
| 1       | Classifica els rangs permesos                          | 119          | Crida al mètode `ClassifyAge(119)`              | Senescència (2)                    | Senescència             |
| 1       | Classifica els rangs permesos                          | 120          | Crida al mètode `ClassifyAge(120)`              | Senescència (2)                    | Senescència             |
| 1       | Classifica els rangs permesos                          | 121          | Crida al mètode `ClassifyAge(121)`              | Invàlid (-1)                         | Invàlid                 |
| 2       | Edat parell o senar                                    | 0            | Crida al mètode `IsEven(0)`                     | true                            | false                   |
| 2       | Edat parell o senar                                    | 1            | Crida al mètode `IsEven(1)`                     | false                           | false                   |
| 2       | Edat parell o senar                                    | 2            | Crida al mètode `IsEven(2)`                     | true                            | true                    |
| 3       | Analitza el nom i diu si es curt o llarg i si es palindrome o no | "Paula"     | Crida al mètode `NameAnalyser("Paula")`         | Curt=false - Palindrome=false     | false, false             |
| 3       | Analitza el nom i diu si es curt o llarg i si es palindrome o no | "Anna"      | Crida al mètode `NameAnalyser("Anna")`          | Curt=true - Palindrome=true      | true, true              |
| 3       | Analitza el nom i diu si es curt o llarg i si es palindrome o no | "Adrian"    | Crida al mètode `NameAnalyser("Adrian")`        | Curt=false - Palindrome=false    | false, false            |
| 4       | Verifica color                                          | "Blau"       | Crida al mètode `VerifyColour("Blau")`          | Calmant (0)                  | Calmant                 |
| 4       | Verifica color                                          | "Verd"       | Crida al mètode `VerifyColour("Verd")`          | Calmant (0)                      | Calmant                 |
| 4       | Verifica color                                          | "Roig"       | Crida al mètode `VerifyColour("Roig")`          | Exclusiu  (1)                      | Exclusiu                |
| 4       | Verifica color                                          | ""           | Crida al mètode `VerifyColour("")`              | Invàlid    (-1)                    | Invàlid                 |
| 5       | Adjunta personalitat                                    | "matí"       | Crida al mètode `PersonalityTest("matí")`       | Matinal (0)                      | Matinal                 |
| 5       | Adjunta personalitat                                    | "nit"        | Crida al mètode `PersonalityTest("nit")`        | Nocturnal (1)                      | Nocturnal               |
| 5       | Adjunta personalitat                                    | "tarda"      | Crida al mètode `PersonalityTest("tarda")`      | Imprevista (2)                    | Imprevista              |
