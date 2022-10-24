# Cours-soutien-Debutant-Unity

Ce repository est un exercice de cours de soutien a Unity et au C# pour débutant créé par Henno Théo

## Contenu : 

L'objectif de ce cours est de réussir à faire un clicker plus ou moins complexe. Il contient une scene déja préconfigurée ainsi qu'un GameManager en Singleton.

## Rappels : 

**Les types de variables** : 

* int : nombre entier, 1
* float : nombre a virgule, 2.5f
* bool : condition vrai ou faux, true
* string : chaine de charactères, "mot"
* Autres

**Les niveaux de protections** : 

* public : accessible par tous
* protected : accessible par les scripts qui hérite de cette classe
* private : accessible uniquement par cette classe.

Une variable s'écrit généralement sous la forme suivante : 

Niveau-de-protection Type nom = valeur-initiale;

Exemple :
```
public float nombre = 1.2f;
```

**Les fonctions** : 

Une fonction est une "commande" qui retourne généralement une valeur en prenant en compte plusieurs paramètres.

Exemple : 

Retourne la multiplication de A et de B
```
public float Multiply(float a, float b)
{
    return a * b;
}
```

```
float result = Multiply(2f, 4f);
```

donc result = 2x4 = 8.