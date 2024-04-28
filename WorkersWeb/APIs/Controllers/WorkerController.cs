using Microsoft.AspNetCore.Mvc;
using ModelLibrary.Models;
using BusinessLogicLayer;

namespace APIs.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WorkerController : ControllerBase
    {
        private WorkerLogic _workerLogic;
        private readonly ILogger<WorkerController> _logger;

        public WorkerController(ILogger<WorkerController> logger, WorkerLogic workerLogic)
        {
            _logger = logger;
            _workerLogic = workerLogic;
        }

        [HttpGet(Name = "GetAllWorkers")]
        public IEnumerable<IWorker> Get()
        {
            return _workerLogic.GetAllWorkers();
        }

        [HttpPut(Name = "AddNewWorker")]
        public IActionResult Put(IWorker worker)
        {
            _workerLogic.AddNewWorker(worker);
            return Ok(worker);
        }
    }
}
