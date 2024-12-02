Kerly Guanoquiza Lucero

# T2. PR2. Proves i refacció

## 1. Quines són les característiques i els escenaris d'ús de les metodologies àgils de desenvolupament de programari? Explica amb detall i posa un exemple.

Les característiques de les metodologies àgils d’un programari són:
- **Treball per sprints**: El projecte es divideix en cicles curts amb entregues freqüents.
- **Flexibilitat**: Es poden fer canvis segons les necessitats del client o usuaris.
- **Col·laboració**: L’equip treballa amb el client per entendre i millorar el projecte.
- **Millora contínua**: Sempre s’intenta optimitzar el que s’ha fet.
- **Qualitat constant**: Es fan proves i revisions per garantir que tot funcioni bé.

Les característiques dels escenaris d’ús són:
- Projectes amb requisits canviants.
- Equips petits o mitjans.
- Necessitat d'entregar ràpidament prototips o productes funcionals.

**Exemple pràctic en un videojoc:**
En aquest cas faré d’exemple el **LOL**. En el cas de desenvolupar aquest utilitzant metodologies àgils, constaria d’aquests passos:
1. Crear un mapa i els moviments dels personatges.
2. Afegir monstres pel mapa i per tant la generació del sistema de combat.
3. Introducció de nous campions que es diferencien de la resta, perquè tots tenen habilitats úniques.
4. Afegir objectius (torres, innibidors, dracs, etc.) i modes de joc (ranked, aram, tft).
5. Millora dels gràfics i dels lags.
6. Proves per comprovar que les noves actualitzacions es desenvolupen correctament.

## 2. Què són els dobles de prova? Explica amb detall els diferents tipus i posa un exemple d’ús per a una solució en C#.

Els **dobles de prova** són objectes utilitzats en les proves unitàries per simular el comportament de dependències externes i facilitar les proves de components en aïllament.

### Tipus de dobles de prova:
- **Stub**: Retorna valors predeterminats per simular la resposta d'una dependència sense lògica addicional.
- **Mock**: A part de simular respostes, comprova si les crides als mètodes es fan amb els arguments correctes.
- **Fake**: Té una implementació simplificada, però real, la qual emula una dependència.
- **Spy**: Registra informació sobre les crides a mètodes (com els arguments passats), però no fa verificacions directes.
- **Dummy**: Objectes creats només per complir amb les necessitats d’un mètode o constructor, però no es fan servir en la prova.

**Exemple de stub**
```csharp
using System;

namespace Exercici3
{
    public class NumeroStub
    {
        public int ObtenirNumero()
        {
            return 4; // Serà el numero amb el que farem la prova per verificar si aquest es parell o no
        }
    }

    public class Programa
    {
        // mètode per comprovar si el número és parell o no
        public static bool IsEven(int numero)
        {
            return numero % 2 == 0;
        }

        public static void Main()
        {
            // es crea un stub
            NumeroStub stub = new NumeroStub();

            // per rebre el número 4 
            int numero = stub.ObtenirNumero();

            // comprovem si és parell o senar utilitzant el mètode IsEven
            if (IsEven(numero))
            {
                Console.WriteLine($"El número {numero} és parell.");
            }
            else
            {
                Console.WriteLine($"El número {numero} és senar.");
            }
        }
    }
}
```


## 3. Què és CI/CD? Fes un vídeo explicant les característiques bàsiques, el seu flux de treball i un exemple pràctic d’integració amb GitHub d’una solució en C#.

**CI (Integració Contínua)** té com objectiu integrar canvis de codi de manera freqüent i funciona de manera que cada cop que es fa un "commit", el codi es compila automàticament, tenint com a propòsit detectar errors ràpidament i evitar conflictes de codi.

**CD (Desplegament Continu)** té com objectiu automatitzar el desplegament del codi als entorns de producció i funciona de manera que un cop integrat el codi, el sistema CD actualitza automàticament l’aplicació.

**Flux de treball:**
1. El desenvolupador fa canvis al codi.
2. Es fa un **commit** i **push** al repositori de **GitHub**.
3. El sistema de **CI** detecta el canvi, el compila i executa proves de manera automàtica.
4. Si tot està bé, el codi es desplega al servidor de producció.


enllaç del video: https://www.youtube.com/watch?v=v--7Z1jnzXM 


## 4. Aplica els patrons de refacció més habituals en el codi que trobaràs en aquest enllaç. Hauràs de:

**- crear un projecte vinculat al teu repositori de la tasca**

**- crear una issue per cada tasca que s’hagi de dur a terme per aplicar els diferents patrons**

**- tancar les tasques mitjançant Visual Studio i les pull requests (PR)**

**- crear els tests unitaris per a validar el teu codi**

**- documentar els patrons que has aplicat i els criteris per a executar els casos de prova**

```csharp
using System;

class Program
{
    static void Main(string[] args)
    {
        // Sol·licita l'entrada de l'usuari per calcular l'àrea d'un rectangle
        Console.WriteLine("Introdueix l'amplada del rectangle:");
        double width = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Introdueix l'altura del rectangle:");
        double height = Convert.ToDouble(Console.ReadLine());

        // Calcula l'àrea
        double area = width * height;
        Console.WriteLine("L'àrea del rectangle és: " + area);

        // Sol·licita l'entrada de l'usuari per calcular la circumferència d'un cercle
        Console.WriteLine("Introdueix el radi del cercle:");
        double radius = Convert.ToDouble(Console.ReadLine());
        double circumference = 2 * Math.PI * radius;

        Console.WriteLine("La circumferència del cercle és: " + circumference);

        // Imprimeix un missatge basat en el valor de l'àrea
        if (area > 50)
        {
            Console.WriteLine("L'àrea és més gran de 50");
        }
        else if (area > 20)
        {
            Console.WriteLine("L'àrea és entre 20 i 50");
        }
        else
        {
            Console.WriteLine("L'àrea és menor o igual a 20");
        }
    }
}
```

Aquest codi està implementat d'una manera incorrecta tot i que fa el que és demana, però és díficl de llegir, és gens robust i poc flexible.

Llavors en el metòdes de refracció que hem aprés a classe aquest tipus de codi mal implementat cal modificar-ho per a què estigui estructurat d'una manera que el codi sigui fàcil d ellegir, robust i flexible.

### Refracció del codi

**1.Generar mètodes dins d'una llibreria**

```csharp
namespace Utils
{
    public class MyUtils
    {
        //T2. PR2. Proves i refacció

        // Metòde per calcular l'àrea d'un rectangle
        public static double AreaRec(double width, double height)
        {
            return width * height;
        }
        //Metòde per evaluar en quin rang està l'àrea
        public static string EvalueArea(int area)
        {
            return area > 50 ? "L'àrea és més gran de 50" :
                   area > 20 ? "L'àrea és entre 20 i 50" :
                               "L'àrea és menor o igual a 20";
        }
        // Metòde per calcular la circumferència d'un cercle
        public static double CirCerc(double radius)
        {
            return 2 * Math.PI * radius;
        }
    }
}
```

**2.Implementació del dll al programa principal, tal que el programa conjuntament quedaría tal que així**

```csharp
using Utils;
using System;

namespace Activitat
{
    public class ProvesRefraccio
    {
        public static void Main(string[] args)
        {
            //genero constants per als missatges
            // missatges d'entrada
            const string inputWidthRec = "Introdueix l'amplada del rectangle:";
            const string inputHeightRec = "Introdueix l'altura del rectangle:";
            const string radiusCercle = "Introdueix el radi del cercle";
            //missatges de sortida
            const string areaRec = "L'àrea del rectangle és:";
            const string circumCerc = "La circumferència del cercle és: ";
            
            try
            {
                // Invocar els mètodes per calcular l'àrea del rectangle
                Console.WriteLine(inputWidthRec);
                double inputWidthRecValue = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine(inputHeightRec);
                double inputHeightRecValue = Convert.ToDouble(Console.ReadLine());

                double area = MyUtils.AreaRec(inputWidthRecValue, inputHeightRecValue);
                Console.WriteLine($"{areaRec}{area}");

                // Invocar el mètode per avaluar l'àrea del rectangle
                string rankArea = MyUtils.EvalueArea((int)area); // Pasamos el área real aquí
                Console.WriteLine(rankArea);

                // Invocar els mètodes per obtenir la circumferència del cercle
                Console.WriteLine(radiusCercle);
                double radiusCercleValue = Convert.ToDouble(Console.ReadLine());
                double circum = MyUtils.CirCerc(radiusCercleValue); // Llamamos al método estático
                Console.WriteLine($"{circumCerc}{circum}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error");
            }
        }
    }
}
```

### Classes d'Equivalència, Valors Límit i Casos de Prova

### Classes d'equivalència 

 ``AreaRec`` [>= 50]

 ``AreaRec`` [>20]

 ``AreaRec`` [<= 20] 

### Valors límit

 ``AreaRec`` [>50]
 
 - { 50, 49, 51 }

 ``AreaRec`` [>20]
 
 - { 20, 21, 49 }

 ``AreaRec`` [<= 20]
 
 - { 19, 20, 21 } 

### Casos de prova

**- Descripció:**

```Area```: Es dona ranks per desprès informar a l'usuari a quin dels tres ranks es trobam l'àrea del rectangle 

| Entrada |  Accions | Resultat esperat | Resultat obtingut |
|-------------|-------------|-------------|-------------|
| 50     | Crida al mètode ```EvalueArea```      |  "L'àrea és entre 21 i 50"     |  "L'àrea és entre 21 i 50"     |
| 49      | Crida al mètode ```EvalueArea```      | "L'àrea és entre 21 i 50"  |  "L'àrea és entre 21 i 50"  |
| 51 | Crida al mètode ```EvalueArea``` | "L'àrea és més gran de 50"  | "L'àrea és més gran de 50"  |
| 20     | Crida al mètode ```EvalueArea```      |  "L'àrea és menor o igual a 20"     |  "L'àrea és menor o igual a 20"     |
| 21      | Crida al mètode ```EvalueArea```      | "L'àrea és entre 21 i 50"  | "L'àrea és entre 21 i 50"  |
| 49 | Crida al mètode ```EvalueArea``` | "L'àrea és entre 20 i 50" "  | "L'àrea és entre 20 i 50" "  |
| 19     | Crida al mètode ```EvalueArea```      |  "L'àrea és menor o igual a 20"     |  "L'àrea és menor o igual a 20"     |


### Tests unitaris

https://github.com/kerly28/ProvesRefraccio-Kerly.git branca ex/exercici4



## 5. Defineix els casos de prova i implementa els tests unitaris pel següent problema:

La llibreria **PersonaHelper** ha estat creada per ajudar en l'anàlisi de dades personals. Proporciona mètodes per classificar l'edat d'una persona, comprovar si un nombre és parell, analitzar les característiques d'un nom, verificar la categoria d'un color, i determinar la preferència de personalitat d'acord amb el moment del dia. L'objectiu és testar aquests mètodes amb classes d'equivalència, valors límit i casos de prova per assegurar-ne el correcte funcionament.

### Les restriccions són les següents:

- **public int ClassifyAge(int age):** Edats vàlides [0-120]
- **public bool IsEven(int age):** Retorna si l’edat és parell o senar
- **public (bool IsShort, bool IsPalindrome) NameAnalyser(string name):** 
  - < 5 caràcters: És un nom curt
  - ≥ 5 caràcters: No és un nom curt
  - Retorna si el nom és palíndrom o no
- **public int VerifyColour(string colour):** 
  - -1: Invàlid
  - 0: Calmants [blau, verd]
  - 1: Exclusiu
- **public int PersonalityTest(string preference):** 
  - “matí”: Retorna 0 [Personalitat Matinal]
  - “nit”: Retorna 1 [Personalitat Nocturna]
  - Qualsevol altre cas: Retorna 2 [Personalitat Imprevista]

### Tasques:
1. Crear una **issue** per la tasca que s’ha de dur a terme per fer les proves.
2. Tancar les tasques mitjançant **Visual Studio** i les **Pull Requests (PR)**.
3. Crear els **tests unitaris** per a validar la .dll fent servir el framework **XUnit**.
4. Documentar els criteris per a executar els casos de prova i les incidències detectades (si s’escau).


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



### Tests unitaris

https://github.com/kerly28/ProvesRefraccio-Kerly.git branca ex/exercici5


## 6. Què són els analitzadors de codi? Fes un vídeo explicant les característiques principals i mostra la configuració i funcionament de SonarQube amb una solució teva en C#.

Els **analitzadors de codi** són eines que revisen automàticament el codi per identificar errors, problemes de seguretat o possibles millores. Això ens permet evitar la revisió manual de tot el codi, fent-ho de manera ràpida i eficient.

### Quins problemes poden detectar?
- **Errors de sintaxi o lògica:** Per exemple, variables no utilitzades o codi innecessari.
- **Vulnerabilitats de seguretat:** Com contrasenyes exposades o dades sensibles.
- **Codi duplicat:** Si hi ha codi que es repeteix sovint, pot complicar el manteniment del projecte.
- **Estils de codi:** Com assegurar-se que les variables i funcions segueixin bones pràctiques, per exemple, anomenant-les de manera clara i coherent.

### Resum:
Els analitzadors de codi ens ajuden a mantenir el nostre projecte més net, segur i fàcil de gestionar.

## 7. Indica les referències que has consultat (pàgines web, llibres, revistes,IA...), seguint el següent format:

## 📎 Características dels escenaris d'ús i de les metodologies àgils de desenvolupament de programari

Les metodologies àgils són enfocaments de desenvolupament de programari que prioritzen la flexibilitat, la col·laboració i la resposta ràpida als canvis. Les característiques principals són:
- **Iteracions curtes (Sprints)**: El desenvolupament es fa en cicles curts (normalment de 1 a 4 setmanes), amb la finalitat de lliurar versions funcionals del producte de manera contínua.
- **Col·laboració constant**: Els equips treballen en estreta comunicació, tant entre ells com amb els clients o usuaris finals, per garantir que els requisits siguin adequats i evolucionin durant el procés.
- **Adaptació als canvis**: Les metodologies àgils promouen l'acceptació de canvis en els requisits, fins i tot en les etapes més avançades del desenvolupament.
- **Focalització en el valor**: Són prioritzades les funcionalitats que aporten més valor al client, amb un enfocament en lliuraments ràpids i útils.
- **Autonomia dels equips**: Els equips àgils són autoorganitzats, amb un alt grau d'autonomia en la presa de decisions.

### Escenaris d'ús:
- **Projectes amb requisits canviants**: Quan els requisits poden evolucionar amb el temps (per exemple, el desenvolupament de programari per a dispositius mòbils o videojocs), les metodologies àgils permeten adaptar-se de manera ràpida.

---

## 📎 CI/CD: Què és i els passos que cal seguir a GitHub

**CI/CD** són acrònims de dues pràctiques fonamentals en el desenvolupament de programari que ajuden a automatitzar la integració i entrega contínua del codi. Aquestes pràctiques són essencials per mantenir la qualitat del programari i accelerar els cicles de desenvolupament.
- **CI (Integració Continua)**: És la pràctica d'integrar canvis en el codi de manera freqüent, generalment diverses vegades al dia, per assegurar-se que el codi estigui sempre llest per ser alliberat. Es focalitza en l'automatització de la compilació, les proves i la verificació del codi per detectar errors d'integració el més aviat possible.
- **CD (Entrega Continua / Desplegament Continu)**: Tot i que CD pot significar tant "Entrega Continua" com "Desplegament Continu", es refereix a l'automatització de l'entrega o desplegament d'una aplicació en un entorn de producció o staging, assegurant-se que el codi estigui sempre llest per ser desplegat de manera segura i sense errors.

### Passos a seguir:
1. Crear un repositori a GitHub si no en tens un.
2. Crear la carpeta `.github/workflows` al teu repositori.
3. Crear un arxiu YAML per definir el teu flux de treball CI/CD.
4. Configurar els passos per CI (com executar proves) i/o CD (com el desplegament).
5. Fer un push al repositori per executar el flux de treball.
6. Monitoritzar l'execució des de la pestanya "Actions" a GitHub.

---

## 📎 Dobles de prova en C#

### Tipus de Dobles de Prova
- **Dummy**: És un objecte que s'utilitza simplement per satisfer la signatura d'un mètode, però que no té un comportament rellevant. Es crea només per evitar errors de compilació, però no interactua amb el codi.
  
  Exemple: Imagina que tens un mètode que necessita un paràmetre de tipus string, però no necessites utilitzar aquest paràmetre en la prova. Crees un dummy que simplement el passa.

- **Fake**: És un objecte que té una implementació bàsica però funcional. Sovint, els fakes són implementacions simplificades de les interfícies o classes reals, utilitzades per evitar dependències costoses com una base de dades. Per exemple, un fake pot emmagatzemar dades en memòria en lloc d'en una base de dades real.

- **Stub**: Aquest tipus d'objecte simula el comportament d'una dependència al retornar valors predefinits quan es criden els seus mètodes. Els stubs no verifiquen les interaccions, simplement retornen resultats per a proves.

- **Mock**: Un mock és més sofisticat que un stub. No només simula el comportament d'un objecte, sinó que també verifica que les interaccions amb l'objecte (crides a mètodes) s'hagin produït d'una manera específica. És útil quan necessites assegurar-te que un mètode ha estat cridat amb certs paràmetres o certes vegades.

- **Spy**: Similar a un mock, però un spy guarda informació sobre les interaccions per tal que puguis analitzar-la després que s'executi la prova. Els spies no només simulen el comportament, sinó que permeten inspeccionar el comportament de les interaccions amb l'objecte durant la prova.

---

## 📎 Què són els analitzadors de codi? Què és SonarQube i com instal·lar-lo per fer un exemple en C#?

Un **analitzador de codi** és una eina que revisa el codi font per detectar errors, vulnerabilitats, males pràctiques i altres problemes que puguin afectar la qualitat i el rendiment del programari. Els analitzadors de codi poden detectar problemes com codi duplicat, manca de proves, possibles errors de seguretat, o violacions de les convencions d'estil de programació.

### Característiques dels analitzadors de codi:
- **Detecció d'errors**: Ajuda a trobar errors al codi abans que es converteixin en problemes reals en producció.
- **Millora de la qualitat del codi**: Fomenta millors pràctiques de desenvolupament i manté el codi net i comprensible.
- **Anàlisi de seguretat**: Identifica vulnerabilitats o punts febles en la seguretat del codi.
- **Compliment d'estàndards**: Assegura que el codi compleixi amb les normes d'estil i les convencions definides pel equip o la comunitat.
- **Automatització**: Permet integrar l'anàlisi de codi en el procés de CI/CD, per garantir que el codi estigui sempre en bones condicions.

**SonarQube** és una eina potent per millorar la qualitat del codi i detectar possibles problemes en el teu projecte. Integrar-lo amb Visual Studio 2022 és senzill mitjançant l'ús de **SonarScanner for MSBuild**. Seguint aquests passos, pots automatitzar l'anàlisi del teu codi i garantir que es mantingui net, segur i de gran qualitat.

### Instal·lació:
1. Instalar SonarQube en la teva màquina local o en un servidor.
2. Descarregar **SonarScanner for MSBuild**.
3. Crear i configurar el fitxer `sonar-project.properties` al teu projecte.
4. Executar els comandaments de SonarScanner per analitzar el teu projecte.
5. Veure els resultats de l'anàlisi a la interfície web de SonarQube.

---

## Cites

| **Referència**                                    | **Font**                                      |
|--------------------------------------------------|-----------------------------------------------|
| Característiques dels escenaris d'ús i de les metodologies àgils de desenvolupament de programari | [Atlassian Agile Methodology Guide](https://www.atlassian.com/agile) |
| CI/CD que és i els passos que cal seguir a GitHub | [GitHub Actions Documentation](https://docs.github.com/en/actions) |
| Dobles de prova en C#                            | [Martin Fowler - Mocks Aren't Stubs](https://martinfowler.com/articles/mocksArentStubs.html) |
| Què són els analitzadors de codi i SonarQube      | [SonarQube Official Documentation](https://docs.sonarqube.org/) |
