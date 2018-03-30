
CREATE TABLE `Profiles_DisagProfile`(
	`Value` longtext NOT NULL, 
	`Id` int NOT NULL);

ALTER TABLE `Profiles_DisagProfile` ADD PRIMARY KEY (`Id`);


CREATE TABLE `Profiles_ManualProfile`(
	`Id` int NOT NULL);

ALTER TABLE `Profiles_ManualProfile` ADD PRIMARY KEY (`Id`);


-- Creating foreign key on `Id` in table 'Profiles_DisagProfile'

ALTER TABLE `Profiles_DisagProfile`
ADD CONSTRAINT `FK_DisagProfile_inherits_Profile`
    FOREIGN KEY (`Id`)
    REFERENCES `Profiles`
        (`Id`)
    ON DELETE CASCADE ON UPDATE NO ACTION;



-- Creating foreign key on `Id` in table 'Profiles_ManualProfile'

ALTER TABLE `Profiles_ManualProfile`
ADD CONSTRAINT `FK_ManualProfile_inherits_Profile`
    FOREIGN KEY (`Id`)
    REFERENCES `Profiles`
        (`Id`)
    ON DELETE CASCADE ON UPDATE NO ACTION;
	
-- Shifting the data around
INSERT INTO `Profiles_DisagProfile` SELECT `Value`, `Id` FROM `Profiles`;
ALTER TABLE `Profiles` DROP Value;