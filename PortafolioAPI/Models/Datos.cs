using Amazon.SecurityToken.Model;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace PORTAFOLIO.PortafolioAPI.Models
{
    public class Datos
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id {get; set; } = string.Empty;

        [BsonElement("Nombre")]
        public string Nombre {get; set;} = string.Empty;

        [BsonElement("Carrera")]
        public string Carrera {get; set;} = string.Empty;

        [BsonElement("Descripcion")]
        public string Descripcion {get; set; } = string.Empty;

        [BsonElement("Telefono")]
        public string Telefono {get; set;} = string.Empty;

        [BsonElement("Correo Electronico")]
        public string CorreoElectronico {get; set;} = string.Empty;

        [BsonElement("Direccion")]
        public string Direccion {get; set;} = string.Empty;
    }

}