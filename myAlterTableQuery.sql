﻿ALTER TABLE RentalItem ADD CONSTRAINT FK_ToolId FOREIGN KEY (ToolId) REFERENCES Tool (ToolId);

AlTER TABLE RentalItem ADD CONSTRIANT FK_RentalId FOREIGN KEY (RentalId) REFERENCES Rental (RentalId);