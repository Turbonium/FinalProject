using LearningCenter.ClassDatabase;

namespace LearningCenter.Repository
{
    public class DatabaseAccessor
    {
        private static readonly LearningCenterDBEntities entities;

        static DatabaseAccessor()
        {
            entities = new LearningCenterDBEntities();
            entities.Database.Connection.Open();
        }

        public static LearningCenterDBEntities Instance
        {
            get
            {
                return entities;
            }
        }
    }
}