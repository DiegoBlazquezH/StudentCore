using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Common.Logic.Models
{
    public class Student
    {
        #region Propiedades
        public Guid GUID { get; set; }
        // Primary Key
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string DNI { get; set; }
        public DateTime BirthDate { get; set; }
        public int Age { get; set; }
        public DateTime RegisterDate { get; set; }
        #endregion

        #region Constructores
        protected Student() => GUID = Guid.NewGuid();

        protected Student(Guid gUID, int iD, string name, string surname, string dNI, DateTime birthDate, int age, DateTime registerDate)
        {
            GUID = gUID;
            ID = iD;
            Name = name;
            Surname = surname;
            DNI = dNI;
            BirthDate = birthDate;
            Age = age;
            RegisterDate = registerDate;
        }

        protected Student(int iD, string name, string surname, string dNI, DateTime birthDate, int age, DateTime registerDate)
        {
            GUID = Guid.NewGuid();
            ID = iD;
            Name = name;
            Surname = surname;
            DNI = dNI;
            BirthDate = birthDate;
            Age = age;
            RegisterDate = registerDate;
        }

        protected Student(int iD, string name, string surname, string dNI, DateTime birthDate)
        {
            ID = iD;
            Name = name;
            Surname = surname;
            DNI = dNI;
            BirthDate = birthDate;
        }
        #endregion

        public void SetGuid()
        {
            GUID = Guid.NewGuid();
        }

        public override string ToString()
        {
            return string.Concat(GUID.ToString(), ",",
                                ID.ToString(), ",",
                                Name, ",",
                                Surname, ",",
                                DNI, ",",
                                BirthDate, ",",
                                Age.ToString(), ",",
                                RegisterDate.ToString());
        }

        public override bool Equals(object obj)
        {
            var persona = obj as Student;
            return persona != null &&
                   GUID.Equals(persona.GUID) &&
                   ID == persona.ID &&
                   Name == persona.Name &&
                   Surname == persona.Surname &&
                   DNI == persona.DNI &&
                   BirthDate.Date == persona.BirthDate.Date &&
                   Age == persona.Age &&
                   RegisterDate.Date == persona.RegisterDate.Date;
        }

        public override int GetHashCode()
        {
            var hashCode = 564319517;
            hashCode = hashCode * -1521134295 + EqualityComparer<Guid>.Default.GetHashCode(GUID);
            hashCode = hashCode * -1521134295 + ID.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Surname);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(DNI);
            hashCode = hashCode * -1521134295 + BirthDate.GetHashCode();
            hashCode = hashCode * -1521134295 + Age.GetHashCode();
            hashCode = hashCode * -1521134295 + RegisterDate.GetHashCode();
            return hashCode;
        }
    }
}
