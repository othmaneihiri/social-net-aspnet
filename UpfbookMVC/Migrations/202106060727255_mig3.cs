namespace PhonebookMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig3 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Publications", "ImagePub");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Publications", "ImagePub", c => c.Binary());
        }
    }
}
