using AutoMapper;
using Contracts;
using Entities.DataTransferObjects;
using Entities.Models;
using LoggerService;
using Microsoft.AspNetCore.Mvc;

namespace CompanyEmployees.Controllers
{
    [Route("api/owners")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;
        public ClientController(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)

        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }
        [HttpGet]
        public IActionResult GetOwners()
        {
            var clients = _repository.Client.GetAllClient(trackChanges: false);
            var clientsDto = _mapper.Map<IEnumerable<Client>>(clients);
            return Ok(clientsDto);
        }
    }
}
