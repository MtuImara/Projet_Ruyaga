-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Mar 24, 2022 at 04:42 PM
-- Server version: 10.4.19-MariaDB
-- PHP Version: 8.0.7

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `ruyaga`
--

-- --------------------------------------------------------

--
-- Table structure for table `entreestock`
--

CREATE TABLE `entreestock` (
  `id_entree` int(11) NOT NULL,
  `nom_produit` varchar(100) NOT NULL,
  `quantite` double DEFAULT NULL,
  `date_entree` date DEFAULT NULL,
  `origine` text DEFAULT NULL,
  `fournisseur` varchar(100) NOT NULL,
  `observation` text DEFAULT NULL,
  `utilisateur` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `entreestock`
--

INSERT INTO `entreestock` (`id_entree`, `nom_produit`, `quantite`, `date_entree`, `origine`, `fournisseur`, `observation`, `utilisateur`) VALUES
(12, 'Avocat', 20, '2021-08-09', 'Ngozi', 'Coordo Omar', 'Bonne qualité', 'Imara'),
(13, 'Tomate', 60, '2021-08-12', 'bukirasazi', 'Coordo Omar', 'Bonne', 'Imara'),
(14, 'Riz', 300, '2021-08-03', 'Musenyi', 'Imara Kabemba', 'Mutanzania', 'Imara'),
(15, 'Orange', 250, '2021-08-12', 'Makamba', 'Ngabe Christian', 'Super', 'Imara'),
(17, 'biharage', 16.5, '2021-08-12', 'bukirasazi', 'Coordo Omar', 'Bonne', 'Imara');

-- --------------------------------------------------------

--
-- Table structure for table `fournisseur`
--

CREATE TABLE `fournisseur` (
  `id_fournisseur` int(11) NOT NULL,
  `nom_prenom` varchar(100) NOT NULL,
  `adresse` text DEFAULT NULL,
  `phone` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `fournisseur`
--

INSERT INTO `fournisseur` (`id_fournisseur`, `nom_prenom`, `adresse`, `phone`) VALUES
(1, 'Imara Kabemba', 'Carama', '75'),
(2, 'Ngabe Christian', 'Rohero', '69'),
(3, 'Coordo Omar', 'Ntahangwa', '79');

-- --------------------------------------------------------

--
-- Table structure for table `produit`
--

CREATE TABLE `produit` (
  `id_prod` int(11) NOT NULL,
  `nom_produit` varchar(100) NOT NULL,
  `type_produit` text DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `produit`
--

INSERT INTO `produit` (`id_prod`, `nom_produit`, `type_produit`) VALUES
(1, 'Avocat', 'Fruit'),
(2, 'Tomate', 'legume'),
(3, 'Riz', 'Aliment'),
(4, 'muceri', 'aliment'),
(5, 'biharage', 'legume'),
(6, 'Orange', 'Fruit');

-- --------------------------------------------------------

--
-- Table structure for table `sortiestock`
--

CREATE TABLE `sortiestock` (
  `id_sortie` int(11) NOT NULL,
  `nom_produit` varchar(100) NOT NULL,
  `quantite` double DEFAULT NULL,
  `date_sortie` date DEFAULT NULL,
  `destination` text DEFAULT NULL,
  `quantite_Retourne` double NOT NULL,
  `utilisateur` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `sortiestock`
--

INSERT INTO `sortiestock` (`id_sortie`, `nom_produit`, `quantite`, `date_sortie`, `destination`, `quantite_Retourne`, `utilisateur`) VALUES
(12, 'Riz', 80, '2021-08-09', 'Alimentation', 0, 'Imara'),
(13, 'Tomate', 30, '2021-08-12', 'Etude', 0, 'Imara'),
(14, 'Orange', 160, '2021-08-15', 'Etude', 20, 'Imara'),
(15, 'Riz', 20, '2021-08-15', 'Alimentation', 0, 'Imara'),
(16, 'Tomate', 80, '2021-08-18', 'aliment', 0, 'Imara');

-- --------------------------------------------------------

--
-- Table structure for table `stock`
--

CREATE TABLE `stock` (
  `id_stock` int(11) NOT NULL,
  `nom_produit` varchar(100) NOT NULL,
  `quantite` double DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `stock`
--

INSERT INTO `stock` (`id_stock`, `nom_produit`, `quantite`) VALUES
(1, 'Tomate', 0),
(2, 'Riz', 320),
(4, 'Avocat', 90),
(5, 'muceri', 200),
(6, 'biharage', 116.5),
(7, 'Orange', 240);

-- --------------------------------------------------------

--
-- Table structure for table `utilisateurs`
--

CREATE TABLE `utilisateurs` (
  `id_login` int(11) NOT NULL,
  `nom` text NOT NULL,
  `prenom` text NOT NULL,
  `login` varchar(100) NOT NULL,
  `password` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `utilisateurs`
--

INSERT INTO `utilisateurs` (`id_login`, `nom`, `prenom`, `login`, `password`) VALUES
(1, 'Imara', 'Kabemba', 'Imara', '00'),
(3, 'Ngabe', 'Christian', 'New_Chris', '123');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `entreestock`
--
ALTER TABLE `entreestock`
  ADD PRIMARY KEY (`id_entree`),
  ADD KEY `fk_produit_vers_entreeS` (`nom_produit`),
  ADD KEY `fk_fournisseur_vers_entreeS` (`fournisseur`),
  ADD KEY `fk_login_vers_entreeS` (`utilisateur`);

--
-- Indexes for table `fournisseur`
--
ALTER TABLE `fournisseur`
  ADD PRIMARY KEY (`id_fournisseur`),
  ADD UNIQUE KEY `unique_four` (`nom_prenom`);

--
-- Indexes for table `produit`
--
ALTER TABLE `produit`
  ADD PRIMARY KEY (`id_prod`),
  ADD UNIQUE KEY `unique_prod` (`nom_produit`);

--
-- Indexes for table `sortiestock`
--
ALTER TABLE `sortiestock`
  ADD PRIMARY KEY (`id_sortie`),
  ADD KEY `fk_produit_vers_Sortie` (`nom_produit`),
  ADD KEY `fk_login_vers_Sortie` (`utilisateur`);

--
-- Indexes for table `stock`
--
ALTER TABLE `stock`
  ADD PRIMARY KEY (`id_stock`),
  ADD KEY `fk_produit_vers_stock` (`nom_produit`);

--
-- Indexes for table `utilisateurs`
--
ALTER TABLE `utilisateurs`
  ADD PRIMARY KEY (`id_login`),
  ADD UNIQUE KEY `unique_user` (`login`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `entreestock`
--
ALTER TABLE `entreestock`
  MODIFY `id_entree` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=18;

--
-- AUTO_INCREMENT for table `fournisseur`
--
ALTER TABLE `fournisseur`
  MODIFY `id_fournisseur` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `produit`
--
ALTER TABLE `produit`
  MODIFY `id_prod` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT for table `sortiestock`
--
ALTER TABLE `sortiestock`
  MODIFY `id_sortie` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=17;

--
-- AUTO_INCREMENT for table `stock`
--
ALTER TABLE `stock`
  MODIFY `id_stock` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT for table `utilisateurs`
--
ALTER TABLE `utilisateurs`
  MODIFY `id_login` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `entreestock`
--
ALTER TABLE `entreestock`
  ADD CONSTRAINT `fk_fournisseur_vers_entreeS` FOREIGN KEY (`fournisseur`) REFERENCES `fournisseur` (`nom_prenom`) ON UPDATE CASCADE,
  ADD CONSTRAINT `fk_login_vers_entreeS` FOREIGN KEY (`utilisateur`) REFERENCES `utilisateurs` (`login`) ON UPDATE CASCADE,
  ADD CONSTRAINT `fk_produit_vers_entreeS` FOREIGN KEY (`nom_produit`) REFERENCES `produit` (`nom_produit`) ON UPDATE CASCADE;

--
-- Constraints for table `sortiestock`
--
ALTER TABLE `sortiestock`
  ADD CONSTRAINT `fk_login_vers_Sortie` FOREIGN KEY (`utilisateur`) REFERENCES `utilisateurs` (`login`) ON UPDATE CASCADE,
  ADD CONSTRAINT `fk_produit_vers_Sortie` FOREIGN KEY (`nom_produit`) REFERENCES `produit` (`nom_produit`) ON UPDATE CASCADE;

--
-- Constraints for table `stock`
--
ALTER TABLE `stock`
  ADD CONSTRAINT `fk_produit_vers_stock` FOREIGN KEY (`nom_produit`) REFERENCES `produit` (`nom_produit`) ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
