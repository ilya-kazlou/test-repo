public class Service {
    private ILogger _logger;

    private readonly IService _service;

    public Service(ILogger logger, IService service) {
        _logger = logger;
        _service = service;
    }

    public void Create() {
        _service.Create();
        _logger.log("Created");
    }
}