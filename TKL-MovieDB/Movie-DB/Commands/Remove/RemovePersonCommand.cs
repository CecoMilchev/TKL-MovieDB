﻿using Movie_DB.Commands.Abstarcts;
using Movie_DB.Commands.Contracts;
using Movie_DB.Commands.Core.Factories;
using Movie_DB.Core.Providers;
using Movie_DB.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie_DB.Commands.Remove
{
    public class RemovePersonCommand : AbstractCommand, ICommand
    {
        List<string> removeData = new List<string>();

        public RemovePersonCommand(IMovieDbContext context, IMovieFactory factory, IReader reader, IWriter writer)
             : base(context, factory, reader, writer)
        {

        }
        public void CollectData()

        {
            writer.WriteLine("=================");
            writer.WriteLine("Enter First Name:");
            removeData.Add(reader.ReadLine());
            writer.WriteLine("Enter Last Name:");
            removeData.Add(reader.ReadLine());

        }

        public string Execute()
        {
            CollectData();
            var removeByName = context.Persons.Where(x => x.FirstName == removeData[0] && x.LastName == removeData[1]);
            context.Persons.Remove(removeByName);

            return @"=================
Persons Removed!
=================";
        }
    }
}
