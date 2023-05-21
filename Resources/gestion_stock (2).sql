-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3306
-- Généré le : dim. 21 mai 2023 à 16:05
-- Version du serveur : 5.7.36
-- Version de PHP : 7.4.26

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `gestion_stock`
--

-- --------------------------------------------------------

--
-- Structure de la table `fournisseurs`
--

DROP TABLE IF EXISTS `fournisseurs`;
CREATE TABLE IF NOT EXISTS `fournisseurs` (
  `id_fou` int(10) NOT NULL AUTO_INCREMENT,
  `reference_fou` varchar(255) NOT NULL,
  `label_fou` varchar(30) NOT NULL,
  PRIMARY KEY (`id_fou`)
) ENGINE=MyISAM AUTO_INCREMENT=12 DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `fournisseurs`
--

INSERT INTO `fournisseurs` (`id_fou`, `reference_fou`, `label_fou`) VALUES
(6, '4523', 'PCLEADER'),
(11, '1458', 'NOVE');

-- --------------------------------------------------------

--
-- Structure de la table `produit`
--

DROP TABLE IF EXISTS `produit`;
CREATE TABLE IF NOT EXISTS `produit` (
  `id_produit` int(10) NOT NULL AUTO_INCREMENT,
  `label_produit` varchar(62) NOT NULL,
  `fou_produit` varchar(255) NOT NULL,
  `prix_produit` int(50) NOT NULL,
  `quantite` int(10) NOT NULL DEFAULT '0',
  PRIMARY KEY (`id_produit`)
) ENGINE=MyISAM AUTO_INCREMENT=1240 DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `produit`
--

INSERT INTO `produit` (`id_produit`, `label_produit`, `fou_produit`, `prix_produit`, `quantite`) VALUES
(1237, 'Samsung A52s 5G', 'PCLDEADER', 500, 12),
(1225, 'ordinateur HP', 'NOVE', 144, 35),
(1238, 'barrette HYPERX', 'MICROMANIA', 188, 78),
(1239, 'boitier HEDEN', 'PCLEADER', 1458, 789);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
