﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfPost.Data
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class postappEntities : DbContext
    {

        private static postappEntities _context;

        public postappEntities()
            : base("name=postappEntities")
        {
        }

        public static postappEntities GetContext()
        {
            if(_context == null)
            {
                _context = new postappEntities();
            }
            return _context;
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<posts> posts { get; set; }
        public virtual DbSet<roles> roles { get; set; }
        public virtual DbSet<users> users { get; set; }
    }
}
