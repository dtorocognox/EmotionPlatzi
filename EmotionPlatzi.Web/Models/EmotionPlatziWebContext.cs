using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EmotionPlatzi.Web.Models
{
    public class EmotionPlatziWebContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public EmotionPlatziWebContext() : base("name=EmotionPlatziAzure")
        {
            //Reconstruye la base de datos si existe algun cambio en ella
            Database.SetInitializer<EmotionPlatziWebContext>(new DropCreateDatabaseIfModelChanges<EmotionPlatziWebContext>());
        }

        public System.Data.Entity.DbSet<EmoPicture> EmoPictures { get; set; }
        public System.Data.Entity.DbSet<EmoFace> EmoFaces { get; set; }
        public System.Data.Entity.DbSet<EmoEmotion> EmoEmotions { get; set; }
        public System.Data.Entity.DbSet<Home> Homes { get; set; }
    }
}
