# Base de données d'espions

Ce projet est une application en C# développée pour gérer une base de données d'espions et de leurs missions associées.

## Structure du projet

Le projet est divisé en plusieurs parties :

- **[Nom].RG.DAL** : Projet d'accès aux données contenant le modèle de données et les méthodes d'accès à la base de données.
- **[Nom].RG.Cli** : Projet de l'application console permettant d'interagir avec la base de données.
- **[Nom].RG.DALTests** : Projet de tests unitaires pour tester les fonctionnalités de la DAL.

## Partie 1 : Le modèle

Le modèle de données comprend les entités Espion et Mission, où un espion peut avoir plusieurs missions.

## Partie 2 : La base de données

Le projet DAL est configuré pour utiliser Entity Framework avec la base de données spécifiée.

## Partie 3 : Le service

Une classe de service est créée pour gérer les opérations sur les données, avec une dépendance sur l'interface de la DAL.

## Partie 4 : Import des espions

L'application console peut être lancée avec l'option -Import suivie d'un fichier contenant les données des espions à importer.

## Partie 5 : Le bon choix

Une méthode de la classe de service renvoie une liste d'espions ayant une mission dans une ville donnée, développée en TDD.

## Partie 6 : Les missions

L'application console peut être lancée avec l'option -mission pour ajouter une mission à un espion.

## Partie 7 : Le bon choix - cli

L'application console peut être lancée avec l'option -choix suivie d'une ville pour afficher les espions ayant eu une mission dans cette ville.

## Auteur

hugo.hochart@ecoles-epsi.net

