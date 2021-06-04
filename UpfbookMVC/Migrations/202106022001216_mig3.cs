namespace PhonebookMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Publications", "ImagePub", c => c.Binary());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Publications", "ImagePub");
        }
    }
}
