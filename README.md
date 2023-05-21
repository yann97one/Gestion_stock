## IMPORTANT
- Avant de demarrer le logiciel veuillez importer la bdd (elle se trouve dans le dossier 'ressources') dans votre phpMyAdmin et démarrer wampserver !

###
## Diagramme de cas d'utilisation - Logiciel de Gestion de Stock

### Acteurs
- Utilisateur

### Cas d'utilisation
1. Afficher une liste de produits
2. Créer un produit
3. Modifier un produit
4. Supprimer un produit
5. Afficher une liste de fournisseurs
6. Créer un fournisseur
7. Modifier un fournisseur
8. Supprimer un fournisseur
9. Rechercher des produits

### Description des cas d'utilisation

#### Cas d'utilisation 1 : Afficher une liste de produits
- L'utilisateur demande l'affichage de la liste des produits depuis la base de données.
- Le système récupère la liste des produits depuis la base de données.
- Le système affiche la liste des produits à l'utilisateur.

#### Cas d'utilisation 2 : Créer un produit
- L'utilisateur souhaite créer un nouveau produit.
- L'utilisateur fournit les informations nécessaires pour créer le produit (nom, prix, quantité, fournisseur).
- Le système vérifie que le nom du produit n'existe pas déjà dans la base de données.
- Le système vérifie que le fournisseur spécifié existe dans la base de données.
- Le système crée un nouveau produit avec les informations fournies et l'ajoute à la base de données.

#### Cas d'utilisation 3 : Modifier un produit
- L'utilisateur souhaite modifier un produit existant.
- L'utilisateur sélectionne le produit à modifier.
- L'utilisateur modifie les informations du produit (nom, prix, quantité, fournisseur).
- Le système vérifie que le nom modifié du produit n'existe pas déjà dans la base de données (à l'exception du produit sélectionné).
- Le système vérifie que le fournisseur spécifié existe dans la base de données.
- Le système met à jour les informations du produit dans la base de données.

#### Cas d'utilisation 4 : Supprimer un produit
- L'utilisateur souhaite supprimer un produit existant.
- L'utilisateur sélectionne le produit à supprimer.
- Le système confirme la suppression du produit.
- Le système supprime le produit de la base de données.

#### Cas d'utilisation 5 : Afficher une liste de fournisseurs
- L'utilisateur demande l'affichage de la liste des fournisseurs depuis la base de données.
- Le système récupère la liste des fournisseurs depuis la base de données.
- Le système affiche la liste des fournisseurs à l'utilisateur.

#### Cas d'utilisation 6 : Créer un fournisseur
- L'utilisateur souhaite créer un nouveau fournisseur.
- L'utilisateur fournit les informations nécessaires pour créer le fournisseur (nom, adresse, contact).
- Le système crée un nouveau fournisseur avec les informations fournies et l'ajoute à la base de données.

#### Cas d'utilisation 7 : Modifier un fournisseur
- L'utilisateur souhaite modifier un fournisseur existant.
- L'utilisateur sélectionne le fournisseur à modifier.
- L'utilisateur modifie les informations du fournisseur (nom, adresse, contact).
- Le système met à jour les informations du fournisseur dans la base de données.

#### Cas d'utilisation 8 : Supprimer un fournisseur
- L'utilisateur souhaite supprimer un fournisseur existant.
- L'utilisateur sélectionne le fournisseur à supprimer.
- Le système confirme la suppression du fournisseur.
- Le système supprime le fournisseur de la base de données.

#### Cas d'utilisation
