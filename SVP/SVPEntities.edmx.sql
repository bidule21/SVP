use SVP2;
DROP DATABASE SVP2;
CREATE DATABASE SVP2;










































-- -----------------------------------------------------------
-- Entity Designer DDL Script for MySQL Server 4.1 and higher
-- -----------------------------------------------------------
-- Date Created: 05/07/2017 18:16:52

-- Generated from EDMX file: C:\Users\christopher\Source\Repos\SVP\SVP\SVPEntities.edmx
-- Target version: 3.0.0.0

-- --------------------------------------------------



-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- NOTE: if the constraint does not exist, an ignorable error will be reported.
-- --------------------------------------------------


--    ALTER TABLE `Participants_Member` DROP CONSTRAINT `FK_ClubMember`;

--    ALTER TABLE `Sequences` DROP CONSTRAINT `FK_ProfileSequence`;

--    ALTER TABLE `Shots` DROP CONSTRAINT `FK_SequenceShot`;

--    ALTER TABLE `Sequences` DROP CONSTRAINT `FK_MemberSequence`;

--    ALTER TABLE `MemberGroup` DROP CONSTRAINT `FK_MemberGroup_Member`;

--    ALTER TABLE `MemberGroup` DROP CONSTRAINT `FK_MemberGroup_Group`;

--    ALTER TABLE `Participants_Group` DROP CONSTRAINT `FK_GroupCompetitionGroup`;

--    ALTER TABLE `Participants_Member` DROP CONSTRAINT `FK_SingleCompetitionMember`;

--    ALTER TABLE `Awards` DROP CONSTRAINT `FK_CompetitionAward`;

--    ALTER TABLE `Awards` DROP CONSTRAINT `FK_MemberAward`;

--    ALTER TABLE `Prices` DROP CONSTRAINT `FK_CompetitionPrice`;

--    ALTER TABLE `Prices` DROP CONSTRAINT `FK_PriceParticipant`;

--    ALTER TABLE `Sequences` DROP CONSTRAINT `FK_PriceSequence`;

--    ALTER TABLE `Prices` DROP CONSTRAINT `FK_ProfilePrice`;

--    ALTER TABLE `Participants_Member` DROP CONSTRAINT `FK_Member_inherits_Participant`;

--    ALTER TABLE `Participants_Group` DROP CONSTRAINT `FK_Group_inherits_Participant`;

--    ALTER TABLE `Competitions_GroupCompetition` DROP CONSTRAINT `FK_GroupCompetition_inherits_Competition`;

--    ALTER TABLE `Competitions_SingleCompetition` DROP CONSTRAINT `FK_SingleCompetition_inherits_Competition`;


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------
SET foreign_key_checks = 0;

    DROP TABLE IF EXISTS `Clubs`;

    DROP TABLE IF EXISTS `Profiles`;

    DROP TABLE IF EXISTS `Sequences`;

    DROP TABLE IF EXISTS `Shots`;

    DROP TABLE IF EXISTS `Competitions`;

    DROP TABLE IF EXISTS `Awards`;

    DROP TABLE IF EXISTS `Prices`;

    DROP TABLE IF EXISTS `Participants`;

    DROP TABLE IF EXISTS `Participants_Member`;

    DROP TABLE IF EXISTS `Participants_Group`;

    DROP TABLE IF EXISTS `Competitions_GroupCompetition`;

    DROP TABLE IF EXISTS `Competitions_SingleCompetition`;

    DROP TABLE IF EXISTS `MemberGroup`;

SET foreign_key_checks = 1;

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------


CREATE TABLE `Clubs`(
	`Id` int NOT NULL AUTO_INCREMENT UNIQUE, 
	`Name` longtext NOT NULL);

ALTER TABLE `Clubs` ADD PRIMARY KEY (`Id`);





CREATE TABLE `Profiles`(
	`Id` int NOT NULL AUTO_INCREMENT UNIQUE, 
	`Name` longtext NOT NULL, 
	`Value` longtext NOT NULL);

ALTER TABLE `Profiles` ADD PRIMARY KEY (`Id`);





CREATE TABLE `Sequences`(
	`Id` int NOT NULL AUTO_INCREMENT UNIQUE, 
	`Date` datetime NOT NULL, 
	`Profile_Id` int NOT NULL, 
	`Member_Id` int NOT NULL, 
	`Price_Id` int, 
	`PreviousSequence_Id` int);

ALTER TABLE `Sequences` ADD PRIMARY KEY (`Id`);





CREATE TABLE `Shots`(
	`Id` int NOT NULL AUTO_INCREMENT UNIQUE, 
	`Value` double NOT NULL, 
	`ShotNumber` smallint NOT NULL, 
	`FactorValue` double NOT NULL, 
	`Angle` double NOT NULL, 
	`Valid` bool NOT NULL, 
	`Sequence_Id` int NOT NULL);

ALTER TABLE `Shots` ADD PRIMARY KEY (`Id`);





CREATE TABLE `Competitions`(
	`Id` int NOT NULL AUTO_INCREMENT UNIQUE, 
	`Name` longtext NOT NULL, 
	`Date` datetime NOT NULL, 
	`Finished` bool NOT NULL);

ALTER TABLE `Competitions` ADD PRIMARY KEY (`Id`);





CREATE TABLE `Awards`(
	`Id` int NOT NULL AUTO_INCREMENT UNIQUE, 
	`Name` longtext NOT NULL, 
	`Competition_Id` int NOT NULL, 
	`Winner_Id` int);

ALTER TABLE `Awards` ADD PRIMARY KEY (`Id`);





CREATE TABLE `Prices`(
	`Id` int NOT NULL AUTO_INCREMENT UNIQUE, 
	`Name` longtext NOT NULL, 
	`Evaluation` CHAR(36) BINARY, 
	`Competition_Id` int NOT NULL, 
	`Winner_Id` int, 
	`Profile_Id` int NOT NULL);

ALTER TABLE `Prices` ADD PRIMARY KEY (`Id`);





CREATE TABLE `Participants`(
	`Id` int NOT NULL AUTO_INCREMENT UNIQUE);

ALTER TABLE `Participants` ADD PRIMARY KEY (`Id`);





CREATE TABLE `Participants_Member`(
	`Firstname` longtext NOT NULL, 
	`Name` longtext NOT NULL, 
	`Birthday` datetime, 
	`Shortname` longtext NOT NULL, 
	`Id` int NOT NULL, 
	`Club_Id` int NOT NULL, 
	`SingleCompetition_Id` int);

ALTER TABLE `Participants_Member` ADD PRIMARY KEY (`Id`);





CREATE TABLE `Participants_Group`(
	`Name` longtext NOT NULL, 
	`Id` int NOT NULL, 
	`GroupCompetition_Id` int NOT NULL);

ALTER TABLE `Participants_Group` ADD PRIMARY KEY (`Id`);





CREATE TABLE `Competitions_GroupCompetition`(
	`Id` int NOT NULL);

ALTER TABLE `Competitions_GroupCompetition` ADD PRIMARY KEY (`Id`);





CREATE TABLE `Competitions_SingleCompetition`(
	`Id` int NOT NULL);

ALTER TABLE `Competitions_SingleCompetition` ADD PRIMARY KEY (`Id`);





CREATE TABLE `MemberGroup`(
	`Member_Id` int NOT NULL, 
	`Groups_Id` int NOT NULL);

ALTER TABLE `MemberGroup` ADD PRIMARY KEY (`Member_Id`, `Groups_Id`);







-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------


-- Creating foreign key on `Club_Id` in table 'Participants_Member'

ALTER TABLE `Participants_Member`
ADD CONSTRAINT `FK_ClubMember`
    FOREIGN KEY (`Club_Id`)
    REFERENCES `Clubs`
        (`Id`)
    ON DELETE NO ACTION ON UPDATE NO ACTION;


-- Creating non-clustered index for FOREIGN KEY 'FK_ClubMember'

CREATE INDEX `IX_FK_ClubMember`
    ON `Participants_Member`
    (`Club_Id`);



-- Creating foreign key on `Profile_Id` in table 'Sequences'

ALTER TABLE `Sequences`
ADD CONSTRAINT `FK_ProfileSequence`
    FOREIGN KEY (`Profile_Id`)
    REFERENCES `Profiles`
        (`Id`)
    ON DELETE NO ACTION ON UPDATE NO ACTION;


-- Creating non-clustered index for FOREIGN KEY 'FK_ProfileSequence'

CREATE INDEX `IX_FK_ProfileSequence`
    ON `Sequences`
    (`Profile_Id`);



-- Creating foreign key on `Sequence_Id` in table 'Shots'

ALTER TABLE `Shots`
ADD CONSTRAINT `FK_SequenceShot`
    FOREIGN KEY (`Sequence_Id`)
    REFERENCES `Sequences`
        (`Id`)
    ON DELETE NO ACTION ON UPDATE NO ACTION;


-- Creating non-clustered index for FOREIGN KEY 'FK_SequenceShot'

CREATE INDEX `IX_FK_SequenceShot`
    ON `Shots`
    (`Sequence_Id`);



-- Creating foreign key on `Member_Id` in table 'Sequences'

ALTER TABLE `Sequences`
ADD CONSTRAINT `FK_MemberSequence`
    FOREIGN KEY (`Member_Id`)
    REFERENCES `Participants_Member`
        (`Id`)
    ON DELETE NO ACTION ON UPDATE NO ACTION;


-- Creating non-clustered index for FOREIGN KEY 'FK_MemberSequence'

CREATE INDEX `IX_FK_MemberSequence`
    ON `Sequences`
    (`Member_Id`);



-- Creating foreign key on `Member_Id` in table 'MemberGroup'

ALTER TABLE `MemberGroup`
ADD CONSTRAINT `FK_MemberGroup_Member`
    FOREIGN KEY (`Member_Id`)
    REFERENCES `Participants_Member`
        (`Id`)
    ON DELETE NO ACTION ON UPDATE NO ACTION;



-- Creating foreign key on `Groups_Id` in table 'MemberGroup'

ALTER TABLE `MemberGroup`
ADD CONSTRAINT `FK_MemberGroup_Group`
    FOREIGN KEY (`Groups_Id`)
    REFERENCES `Participants_Group`
        (`Id`)
    ON DELETE NO ACTION ON UPDATE NO ACTION;


-- Creating non-clustered index for FOREIGN KEY 'FK_MemberGroup_Group'

CREATE INDEX `IX_FK_MemberGroup_Group`
    ON `MemberGroup`
    (`Groups_Id`);



-- Creating foreign key on `GroupCompetition_Id` in table 'Participants_Group'

ALTER TABLE `Participants_Group`
ADD CONSTRAINT `FK_GroupCompetitionGroup`
    FOREIGN KEY (`GroupCompetition_Id`)
    REFERENCES `Competitions_GroupCompetition`
        (`Id`)
    ON DELETE NO ACTION ON UPDATE NO ACTION;


-- Creating non-clustered index for FOREIGN KEY 'FK_GroupCompetitionGroup'

CREATE INDEX `IX_FK_GroupCompetitionGroup`
    ON `Participants_Group`
    (`GroupCompetition_Id`);



-- Creating foreign key on `SingleCompetition_Id` in table 'Participants_Member'

ALTER TABLE `Participants_Member`
ADD CONSTRAINT `FK_SingleCompetitionMember`
    FOREIGN KEY (`SingleCompetition_Id`)
    REFERENCES `Competitions_SingleCompetition`
        (`Id`)
    ON DELETE NO ACTION ON UPDATE NO ACTION;


-- Creating non-clustered index for FOREIGN KEY 'FK_SingleCompetitionMember'

CREATE INDEX `IX_FK_SingleCompetitionMember`
    ON `Participants_Member`
    (`SingleCompetition_Id`);



-- Creating foreign key on `Competition_Id` in table 'Awards'

ALTER TABLE `Awards`
ADD CONSTRAINT `FK_CompetitionAward`
    FOREIGN KEY (`Competition_Id`)
    REFERENCES `Competitions`
        (`Id`)
    ON DELETE NO ACTION ON UPDATE NO ACTION;


-- Creating non-clustered index for FOREIGN KEY 'FK_CompetitionAward'

CREATE INDEX `IX_FK_CompetitionAward`
    ON `Awards`
    (`Competition_Id`);



-- Creating foreign key on `Winner_Id` in table 'Awards'

ALTER TABLE `Awards`
ADD CONSTRAINT `FK_MemberAward`
    FOREIGN KEY (`Winner_Id`)
    REFERENCES `Participants_Member`
        (`Id`)
    ON DELETE NO ACTION ON UPDATE NO ACTION;


-- Creating non-clustered index for FOREIGN KEY 'FK_MemberAward'

CREATE INDEX `IX_FK_MemberAward`
    ON `Awards`
    (`Winner_Id`);



-- Creating foreign key on `Competition_Id` in table 'Prices'

ALTER TABLE `Prices`
ADD CONSTRAINT `FK_CompetitionPrice`
    FOREIGN KEY (`Competition_Id`)
    REFERENCES `Competitions`
        (`Id`)
    ON DELETE NO ACTION ON UPDATE NO ACTION;


-- Creating non-clustered index for FOREIGN KEY 'FK_CompetitionPrice'

CREATE INDEX `IX_FK_CompetitionPrice`
    ON `Prices`
    (`Competition_Id`);



-- Creating foreign key on `Winner_Id` in table 'Prices'

ALTER TABLE `Prices`
ADD CONSTRAINT `FK_PriceParticipant`
    FOREIGN KEY (`Winner_Id`)
    REFERENCES `Participants`
        (`Id`)
    ON DELETE NO ACTION ON UPDATE NO ACTION;


-- Creating non-clustered index for FOREIGN KEY 'FK_PriceParticipant'

CREATE INDEX `IX_FK_PriceParticipant`
    ON `Prices`
    (`Winner_Id`);



-- Creating foreign key on `Price_Id` in table 'Sequences'

ALTER TABLE `Sequences`
ADD CONSTRAINT `FK_PriceSequence`
    FOREIGN KEY (`Price_Id`)
    REFERENCES `Prices`
        (`Id`)
    ON DELETE NO ACTION ON UPDATE NO ACTION;


-- Creating non-clustered index for FOREIGN KEY 'FK_PriceSequence'

CREATE INDEX `IX_FK_PriceSequence`
    ON `Sequences`
    (`Price_Id`);



-- Creating foreign key on `Profile_Id` in table 'Prices'

ALTER TABLE `Prices`
ADD CONSTRAINT `FK_ProfilePrice`
    FOREIGN KEY (`Profile_Id`)
    REFERENCES `Profiles`
        (`Id`)
    ON DELETE NO ACTION ON UPDATE NO ACTION;


-- Creating non-clustered index for FOREIGN KEY 'FK_ProfilePrice'

CREATE INDEX `IX_FK_ProfilePrice`
    ON `Prices`
    (`Profile_Id`);



-- Creating foreign key on `PreviousSequence_Id` in table 'Sequences'

ALTER TABLE `Sequences`
ADD CONSTRAINT `FK_SequenceSequence`
    FOREIGN KEY (`PreviousSequence_Id`)
    REFERENCES `Sequences`
        (`Id`)
    ON DELETE NO ACTION ON UPDATE NO ACTION;


-- Creating non-clustered index for FOREIGN KEY 'FK_SequenceSequence'

CREATE INDEX `IX_FK_SequenceSequence`
    ON `Sequences`
    (`PreviousSequence_Id`);



-- Creating foreign key on `Id` in table 'Participants_Member'

ALTER TABLE `Participants_Member`
ADD CONSTRAINT `FK_Member_inherits_Participant`
    FOREIGN KEY (`Id`)
    REFERENCES `Participants`
        (`Id`)
    ON DELETE CASCADE ON UPDATE NO ACTION;



-- Creating foreign key on `Id` in table 'Participants_Group'

ALTER TABLE `Participants_Group`
ADD CONSTRAINT `FK_Group_inherits_Participant`
    FOREIGN KEY (`Id`)
    REFERENCES `Participants`
        (`Id`)
    ON DELETE CASCADE ON UPDATE NO ACTION;



-- Creating foreign key on `Id` in table 'Competitions_GroupCompetition'

ALTER TABLE `Competitions_GroupCompetition`
ADD CONSTRAINT `FK_GroupCompetition_inherits_Competition`
    FOREIGN KEY (`Id`)
    REFERENCES `Competitions`
        (`Id`)
    ON DELETE CASCADE ON UPDATE NO ACTION;



-- Creating foreign key on `Id` in table 'Competitions_SingleCompetition'

ALTER TABLE `Competitions_SingleCompetition`
ADD CONSTRAINT `FK_SingleCompetition_inherits_Competition`
    FOREIGN KEY (`Id`)
    REFERENCES `Competitions`
        (`Id`)
    ON DELETE CASCADE ON UPDATE NO ACTION;



-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------
