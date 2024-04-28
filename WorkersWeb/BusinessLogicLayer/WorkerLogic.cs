using ModelLibrary.Models;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class WorkerLogic
    {
        private DBWorker _dbworker;

        public WorkerLogic(DBWorker dbworker)
        {
            _dbworker = dbworker;
        }

        public IEnumerable<IWorker> GetAllWorkers()
        {
            throw new NotImplementedException();
        }

        public void AddNewWorker(IWorker worker)
        {
            if (worker == null)
            {
                return;
            }

            switch (worker.WorkerType)
            {
                case 1:
                    _dbworker.AddEmployee((Employee)worker);
                    break;
                case 2:
                    _dbworker.AddSupervisor((Supervisor)worker);
                    break;
                case 3:
                    _dbworker.AddManager((Manager)worker);
                    break;
                default:
                    break;
            }
        }
    }
}
