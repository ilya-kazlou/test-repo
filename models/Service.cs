public class Service {
    private ILogger _logger;

    public Service(ILogger logger) {
        _logger = logger;
    }

    public void Create() {
        _logger.log("Created");
    }
}