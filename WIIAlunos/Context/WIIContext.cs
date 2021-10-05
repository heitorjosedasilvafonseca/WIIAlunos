using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WIIAlunos.Models;

namespace WIIAlunos.Context
{
    public class WIIContext : DbContext
    {
        public WIIContext() : base("WII") { }
        public DbSet<Aluno> Alunos { get; set; }
    }
}