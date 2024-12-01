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
