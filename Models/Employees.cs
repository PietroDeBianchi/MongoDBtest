using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;

namespace mongoDB.Models
{
    public class Employee
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public string Matricola { get; set; } // Map Matricola to MongoDB Id

        public string Nome { get; set; }
        public string Cognome { get; set; }
        public int Eta { get; set; }
        public string Indirizzo { get; set; }
        public string Citta { get; set; }
        public string Provincia { get; set; }
        public string Cap { get; set; }
        public string Telefono { get; set; }
        public List<EmployeeRole> EmployeesRole { get; set; } = new List<EmployeeRole>();
        public List<EmployeeActivity> EmployeesActivities { get; set; } = new List<EmployeeActivity>();
    }

    public class EmployeeRole
    {
        public string Ruolo { get; set; }
        public string Reparto { get; set; }
    }

    public class EmployeeActivity
    {
        public string DataAttivita { get; set; }
        public string Attivita { get; set; }
        public int Ore { get; set; }
        public string Matricola { get; set; }

    }
}
