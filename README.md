# 🎭 Projet SAE - Jeu de Mastermind

## 📄 Description
Ce projet est une application en **Visual Basic .NET** qui implémente un jeu de **Mastermind**. Le but est de deviner un motif secret en un nombre limité d'essais. L'application gère plusieurs fonctionnalités comme la gestion des joueurs, l'affichage des statistiques et la personnalisation des paramètres.

---

## 🚀 Fonctionnalités principales

1. **Gestion des joueurs** :
   - Création et gestion des joueurs avec sauvegarde.
   - Historique des performances.

2. **Mécanisme du jeu** :
   - Génération d'un motif secret avec des caractères spécifiques.
   - Système de feedback sur les propositions (éléments bien placés, mal placés, absents).
   - Gestion d'un chronomètre (option activable/désactivable).

3. **Personnalisation** :
   - Configuration du nombre d'essais et de la taille du motif.
   - Définition des couleurs pour les indices visuels.
   - Enregistrement et relecture des paramètres.

4. **Statistiques et sauvegarde** :
   - Affichage des résultats passés.
   - Export des données de jeu.

---

## 🔮 Règles du jeu
1. Le jeu génère un motif secret composé de plusieurs symboles parmi une liste définie.
2. Le joueur doit proposer une combinaison pour tenter de deviner le motif secret.
3. Après chaque tentative, des indices sont donnés :
   - ✅ Un symbole bien placé est indiqué en **vert**.
   - 🔄 Un symbole correct mais mal placé est indiqué en **bleu**.
   - ❌ Un symbole absent du motif est indiqué en **rouge**.
4. Le joueur a un nombre limité d'essais pour trouver la bonne combinaison.
5. Si le motif est deviné dans le temps imparti et avec les essais disponibles, le joueur gagne. Sinon, il perd.

---

## 🛠️ Technologies utilisées
- **Langage** : Visual Basic .NET (VB.NET)
- **Environnement de développement** : Visual Studio
- **Fichiers de ressource** : `.resx` pour la gestion des labels et messages
- **Fichiers de sauvegarde** : Texte (`param.txt` et `lst_joueurs.txt`)

---

## 🛠️ Installation et exécution

### 1️⃣ Cloner le projet
```bash
git clone https://github.com/ton-utilisateur/nom-du-repo.git
cd nom-du-repo
```

### 2️⃣ Ouvrir et exécuter dans Visual Studio
1. Ouvrir **Visual Studio**.
2. Charger la solution `SAE_IHM.sln`.
3. Compiler et exécuter le projet.

---

## 📚 Structure du projet
- `Accueil.vb` : Fenêtre d'accueil du jeu.
- `jeu.vb` : Mécanisme du jeu et interactions utilisateur.
- `Pattern_a_deviner.vb` : Génération et vérification du motif secret.
- `Joueur.vb` : Gestion des joueurs.
- `mod_fichier_joueurs.vb` : Module de sauvegarde et chargement des joueurs.
- `mod_param.vb` : Gestion des paramètres du jeu.
- `statistique.vb` : Gestion des statistiques et historique des parties.
- `param.txt` : Fichier de configuration des paramètres (nombre d'essais, couleur, chronomètre, etc.).

---

## 👨‍💻 Auteur
- **Aymen** - [Ton GitHub](https://github.com/Suupon)

---

