public class Service {
    private ILogger _logger;

    public Service(ILogger logger) {
        _logger = logger;
    }

    public void Create() {
        _logger.log("Created");

        if (true) {
            _logger.log("Fly");
        }
    }

    public void Update() {
        _logger.log("Updated");

        if (true) {
            _logger.log("Fly");
        }
    }
}