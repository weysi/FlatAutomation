using FlatAutomation.BussinesLogic;

namespace FlatAutomation
{
    class UnitOfWork
    {
        public GelirlerRepo gelirlerRepo { get; set; }
        public GiderlerRepo giderlerRepo { get; set; }
        public UnitOfWork()
        {
         gelirlerRepo = new GelirlerRepo();
            giderlerRepo = new GiderlerRepo();
        }
        
    }
}
