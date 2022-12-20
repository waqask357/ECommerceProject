﻿namespace ECommerceProject.Database.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class configTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ConfigurationTable",
                c => new
                    {
                        Key = c.String(nullable: false, maxLength: 128),
                        Value = c.String(),
                    })
                .PrimaryKey(t => t.Key);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ConfigurationTable");
        }
    }
}
