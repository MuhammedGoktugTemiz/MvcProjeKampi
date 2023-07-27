﻿namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_vallahisondüzenleme : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Writers", "HeadingStatus", c => c.Boolean(nullable: false));
            DropColumn("dbo.Writers", "WriterStatus");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Writers", "WriterStatus", c => c.Boolean(nullable: false));
            DropColumn("dbo.Writers", "HeadingStatus");
        }
    }
}
