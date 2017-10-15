using Bytes2you.Validation;
using Movie_DB.Commands.Contracts;
using Movie_DB.Commands.Core.Factories;
using Movie_DB.Core.Providers;
using Movie_DB.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie_DB.Commands.Creating
{
    public class CreatePersonCommand : ICommand
    {
       // private readonly MovieDbContext context;
        private readonly IMovieFactory factory;
        private readonly IReader reader;
        private readonly IWriter writer;
        private List<string> personData = new List<string>();

        public CreatePersonCommand(/*MovieDbContext context,*/ IMovieFactory factory, IReader reader, IWriter writer)
        {
           // this.context = context;
            this.factory = factory;
            this.reader = reader;
            this.writer = writer;
        }

        public void CollectData()
        {
            writer.WriteLine("Enter First Name:");
            personData.Add(reader.ReadLine());
            writer.WriteLine("Enter Last Name:");
            personData.Add(reader.ReadLine());
            writer.WriteLine("Enter Job:");
            personData.Add(reader.ReadLine());
        }

        public string Execute()
        {
           CollectData();
            var Person = this.factory.CreatePerson(personData[0], personData[1], personData[0]);
            writer.Write("ei ma");
            return "Person Created";
        }
    }
}
