writer.WriteStartElement("Employee");
writer.WriteAttributeString("Id", "12345");
writer.WriteElementString("FirstName", "John");
writer.WriteElementString("LastName", "Doe");
writer.WriteElementString("Position", "Software Developer");
writer.WriteEndElement(); // Closes the Employee element
